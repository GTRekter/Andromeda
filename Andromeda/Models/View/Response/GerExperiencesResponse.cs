using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andromeda.Models.View.Response
{
    public class GetExperiencesResponse : BaseResponse
    {
        public IEnumerable<ExperienceDetails> Experiences { get; set; }
        public class ExperienceDetails
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Company { get; set; }
            public string Website { get; set; }          
            public string DateStart { get; set; }
            public string DateEnd { get; set; }
            public string Country { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public string State { get; set; }
        }
    }
}
