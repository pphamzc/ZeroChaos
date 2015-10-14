using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public interface IResourceWorkExperienceService
    {
        /// This method return resource work experience details based on resourceid.
        List<ResourceWorkExperience> GetResourceWorkExperienceByResourceID(int resourceID);

        /// This method will populate the Work experience tab of resource dossier
        ResourceWorkExperienceResponse GetResourceWorkExperiencesResponseByResourceID(int resourceID);

        /// This method add resource work experience details.
        int AddResourceWorkExperience(ResourceWorkExperience resourceWorkExperience);

        /// This method update resource work experience details.
        bool UpdateResourceWorkExperience(ResourceWorkExperience resourceWorkExperience);

        /// This method will return all the work preference from look up table.
        List<BaseEntity.WorkPreference> GetAllWorkPreferences();


    }
}
