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
    public class EducationController : Controller
    {
        #region Private
        protected readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public EducationController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet("[action]")]
        public GetEducationsResponse GetEducations()
        {
            GetEducationsResponse viewModel = new GetEducationsResponse();

            try
            {
                viewModel.Educations = _context.AN_Educations
                    .Join(_context.AN_Schools, 
                        e => e.IdAndromedaSchool,
                        s => s.IdAndromeda,
                        (e, s) => new { Education = e, School = s })
                    .Join(_context.AN_Countries,
                        e => e.School.IdCountry,
                        c => c.Id,
                        (e, c) => new { e.Education, e.School, Country = c })
                    .Select(e => new GetEducationsResponse.EducationDetails()
                    {
                        Name = e.Education.Name,
                        Description = e.Education.Description,
                        FieldOfStudy = e.Education.FieldOfStudy,
                        School = e.School.Name,
                        DateStart = e.Education.DateStart.ToString("yyyy-MM"),
                        DateEnd = e.Education.DateEnd != null ? ((DateTime)e.Education.DateEnd).ToString("yyyy-MM") : null,
                        Country = e.Country.Name,
                        Dropped = e.Education.Dropped
                    })
                    .OrderByDescending(e => e.DateStart);
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
