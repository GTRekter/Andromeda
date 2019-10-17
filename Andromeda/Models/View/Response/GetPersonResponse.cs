using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andromeda.Models.View.Response
{
    public class GetPersonResponse : BaseResponse
    {
        public PersonDetails Person { get; set; }
        public class PersonDetails
        {
            public string FirstName { get; internal set; }
            public string MiddleName { get; internal set; }
            public string LastName { get; internal set; }
            public DateTime? DateOfBirth { get; internal set; }
            public string Email { get; internal set; }
            public string Street { get; internal set; }
            public string Zip { get; internal set; }
            public string City { get; internal set; }
            public object State { get; internal set; }
            public string Country { get; internal set; }
            public string Mobile { get; internal set; }
            public string Github { get; internal set; }
            public string Linkedin { get; internal set; }
            public string Twitter { get; internal set; }
            public string Facebook { get; internal set; }
            public string Position { get; internal set; }
        }
    }
}
