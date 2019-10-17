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
    public class CertificationController : Controller
    {
        #region Private
        protected readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public CertificationController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet("[action]")]
        public GetCertificationsResponse GetCertifications()
        {
            GetCertificationsResponse viewModel = new GetCertificationsResponse();

            try
            {
                viewModel.Certifications = _context.AN_Certifications
                    .Join(_context.AN_Companies, 
                        c => c.IdAndromedaCompany,
                        s => s.IdAndromeda,
                        (c, s) => new { Certification = c, Company = s })
                    .Where(e => e.Certification.Visible)
                    .Select(e => new GetCertificationsResponse.CertificationDetails()
                    {
                        Code = e.Certification.Code,
                        Name = e.Certification.Name,
                        Description = e.Certification.Description,
                        DateStart = e.Certification.DateStart.ToString("yyyy-MM"),
                        DateEnd = e.Certification.DateEnd != null ? ((DateTime)e.Certification.DateEnd).ToString("d MMM, yyyy") : null,
                        ExpirationDate = e.Certification.ExpirationDate != null ? ((DateTime)e.Certification.ExpirationDate).ToString("yyyy-MM") : null,
                        Company = e.Company.Name
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
