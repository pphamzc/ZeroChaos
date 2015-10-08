﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceJobSkillService : IResourceJobSkillService
    {
        /// This method will return resource job skills details based on resourceid. 
        public List<ResourceJobSkill> GetResourceJobSkillByResourceID(int resourceID)
        {
            return new List<ResourceJobSkill>();
        }

        /// This method will add the resource job skill.
        public int AddResourceJobSkill(ResourceJobSkill resourceJobSkill)
        {
            return 0;
        }

        /// This method will update the resource job skill.
        public bool UpdateResourceJobSkill(ResourceJobSkill resourceJobSkill)
        {
            return true;
        }

        /// This method will populate the skill and certifications tab details of Resource Dossier.
        /// This method will return ResourceJobSkillCertificationResponse  which consist of job skills details and certification details of the resource.
        public ResourceJobSkillCertificationResponse GetResourceSkillCertificationResponseByResourceID(int resourceID)
        {
            return new ResourceJobSkillCertificationResponse();
        }
    }
}
