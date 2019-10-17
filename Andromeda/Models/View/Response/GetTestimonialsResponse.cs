using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andromeda.Models.View.Response
{
    public class GetTestimonialsResponse : BaseResponse
    {
        public IEnumerable<TestimonialDetails> Testimonials { get; set; }
        public class TestimonialDetails
        {
            public string FirstName { get; internal set; }
            public string MiddleName { get; internal set; }
            public string LastName { get; internal set; }
            public string Testimony { get; internal set; }
            public string Position { get; internal set; }
            public string Company { get; internal set; }
        }
    }
}
