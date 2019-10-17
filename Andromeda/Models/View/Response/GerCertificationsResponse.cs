using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andromeda.Models.View.Response
{
    public class GetCertificationsResponse : BaseResponse
    {
        public IEnumerable<CertificationDetails> Certifications { get; set; }
        public class CertificationDetails
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Company { get; set; }                
            public string DateStart { get; set; }
            public string DateEnd { get; set; }
            public string ExpirationDate { get; set; }
        }
    }
}
