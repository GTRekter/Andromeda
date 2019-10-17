using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andromeda.Models.View.Response
{
    public class GetEducationsResponse : BaseResponse
    {
        public IEnumerable<EducationDetails> Educations { get; set; }
        public class EducationDetails
        {
            public string Name { get; internal set; }
            public string Description { get; internal set; }
            public string School { get; internal set; }
            public string Country { get; internal set; }
            public string FieldOfStudy { get; internal set; }
            public string DateStart { get; internal set; }
            public string DateEnd { get; internal set; }
            public bool Dropped { get; internal set; }
        }
    }
}
