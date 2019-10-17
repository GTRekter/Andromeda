using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andromeda.Models.View.Response
{
    public class GetSkillsResponse : BaseResponse
    {
        public IEnumerable<SkillDetails> Skills { get; set; }
        public class SkillDetails
        {
            public string Name { get; internal set; }
            public double? Proficency { get; internal set; }
            public bool Evidence { get; internal set; }
        }
    }
}
