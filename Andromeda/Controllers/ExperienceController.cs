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
    public class ExperienceController : Controller
    {
        #region Private
        protected readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public ExperienceController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet("[action]")]
        public GetExperiencesResponse GetExperiences()
        {
            GetExperiencesResponse viewModel = new GetExperiencesResponse();

            try
            {
                viewModel.Experiences = _context.AN_Experiences
                    .Join(_context.AN_Companies, 
                        e => e.IdAndromedaCompany,
                        c => c.IdAndromeda,
                        (e, c) => new { Experience = e, Company = c })
                    .Join(_context.AN_Addresses,
                        e => e.Company.IdAndromedaAddress,
                        a => a.IdAndromeda,
                        (e, a) => new { e.Experience, e.Company, Address = a })
                    .Join(_context.AN_Countries,
                        a => a.Address.IdCountry,
                        c => c.Id,
                        (a, c) => new { a.Experience, a.Company, a.Address, Country = c })
                    .Select(e => new GetExperiencesResponse.ExperienceDetails()
                    {
                        Name = e.Experience.Name,
                        Description = e.Experience.Description,
                        DateStart = e.Experience.DateStart.ToString("yyyy-MM"),
                        DateEnd = e.Experience.DateEnd != null ? ((DateTime)e.Experience.DateEnd).ToString("yyyy-MM") : null,
                        Company = e.Company.Name,
                        Website = e.Company.Website,
                        Street = e.Address.Street,
                        City = e.Address.City,
                        Zip = e.Address.Zip,
                        State = e.Address.State,
                        Country = e.Country.Name
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
