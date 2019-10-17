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
    public class SkillController : Controller
    {
        #region Private
        protected readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public SkillController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet("[action]")]
        public GetSkillsResponse GetSkills()
        {
            GetSkillsResponse viewModel = new GetSkillsResponse();

            try
            {
                viewModel.Skills = _context.AN_Skills
                    .Select(s => new GetSkillsResponse.SkillDetails() {
                        Name = s.Name,
                        Proficency = s.Proficency,
                        Evidence = s.Evidence
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
