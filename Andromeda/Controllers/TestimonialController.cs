using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models.View.Response;
using Andromeda.Models.Data;
using Andromeda.Models;

namespace Andromeda.Controllers
{
    [Route("api/[controller]")]
    public class TestimonialController : Controller
    {
        #region Private
        protected readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public TestimonialController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet("[action]")]
        public GetTestimonialsResponse GetTestimonials()
        {
            GetTestimonialsResponse viewModel = new GetTestimonialsResponse();

            try
            {
                viewModel.Testimonials = _context.AN_Testimonials
                    .Join(_context.AN_People, 
                        t => t.IdAndromedaPerson,
                        p => p.IdAndromeda,
                        (t, p) => new { Testimonial = t, Person = p })
                    .Join(_context.AN_Employees,
                        p => p.Person.IdAndromeda,
                        e => e.IdAndromedaPerson,
                        (p, e) => new { p.Person, p.Testimonial, Employee = e })
                    .Join(_context.AN_Companies,
                        e => e.Employee.IdAndromedaCompany,
                        p => p.IdAndromeda,
                        (e, p) => new { e.Person, e.Testimonial, Company = p })
                    .Select(t => new GetTestimonialsResponse.TestimonialDetails()
                    {
                         FirstName = t.Person.FirstName,
                         MiddleName = t.Person.MiddleName,
                         LastName = t.Person.LastName,
                         Testimony = t.Testimonial.Testimony,
                         Position = t.Person.Position,
                         Company = t.Company.Name
                    });
            }
            catch (Exception exc)
            {
                viewModel.ResultInfo.Result = BaseResponse.ResultInfoDto.ResultEnum.Error;
                viewModel.ResultInfo.ErrorMessage = exc.Message;
            }

            return viewModel;
        }
    }
}
