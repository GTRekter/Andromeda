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
    public class PersonController : Controller
    {
        #region Private
        protected readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet("[action]")]
        public GetPersonResponse GetPerson()
        {
            GetPersonResponse viewModel = new GetPersonResponse();

            try
            {
                var person = _context.AN_People
                    .Join(_context.AN_PersonAddresses, 
                        p => p.IdAndromeda,
                        pa => pa.IdAndromedaPerson,
                        (p, pa) => new { Person = p, PersonAddress = pa })
                    .Where(pa => pa.PersonAddress.Primary)
                    .FirstOrDefault();

                if (person != null)
                {
                    var address = _context.AN_Addresses
                    .Where(a => a.IdAndromeda == person.PersonAddress.IdAndromedaAddress)
                    .Join(_context.AN_Countries,
                        a => a.IdCountry,
                        c => c.Id,
                        (a, c) => new { Address = a, Country = c })
                    .FirstOrDefault();

                    viewModel.Person = new GetPersonResponse.PersonDetails()
                    {
                        FirstName = person.Person.FirstName,
                        MiddleName = person.Person.MiddleName,
                        LastName = person.Person.LastName,
                        DateOfBirth = person.Person.DateOfBirth,
                        Mobile = person.Person.Mobile,
                        Email = person.Person.Email,                      
                        Street = address?.Address.Street,
                        Zip = address?.Address.Zip,
                        City = address?.Address.City,
                        State = address?.Address.State,
                        Country = address?.Country.Name,
                        Github = person.Person.Github,
                        Linkedin = person.Person.Linkedin,
                        Twitter = person.Person.Twitter,
                        Facebook = person.Person.Facebook,
                        Position = person.Person.Position
                    };
                }
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
