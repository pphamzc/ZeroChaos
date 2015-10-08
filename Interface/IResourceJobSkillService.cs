using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public interface IResourceJobSkillService
    {

        /// This method will return resource job skills details based on resourceid. 
        List<ResourceJobSkill> GetResourceJobSkillByResourceID(int resourceID);

        /// This method will add the resource job skill.
        int AddResourceJobSkill(ResourceJobSkill resourceJobSkill);

        /// This method will update the resource job skill.
        bool UpdateResourceJobSkill(ResourceJobSkill resourceJobSkill);

        /// This method will populate the skill and certifications tab details of Resource Dossier.
        /// This method will return ResourceJobSkillCertificationResponse  which consist of job skills details and certification details of the resource.
        ResourceJobSkillCertificationResponse GetResourceSkillCertificationResponseByResourceID(int resourceID);

    }
}
