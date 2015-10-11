using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceJobSkillCertificationResponse
    {
        public	List<ResourceJobSkill> ResourceJobSkill {get;set;}
        public List<ResourceCertification> ResourceCertification { get; set; }
    }
}
