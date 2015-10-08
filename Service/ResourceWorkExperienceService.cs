using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceWorkExperienceService : IResourceWorkExperienceService
    {

        /// This method return resource work experience details based on resourceid.
        public List<ResourceWorkExperience> GetResourceWorkExperienceByResourceID(int resourceID)
        {
            return new List<ResourceWorkExperience>();
        }

        /// This method will populate the Work experience tab of resource dossier
        public ResourceWorkExperienceResponse GetResourceWorkExperiencesResponseByResourceID(int resourceID)
        {
            return new ResourceWorkExperienceResponse();
        }

        /// This method add resource work experience details.
        public int AddResourceWorkExperience(ResourceWorkExperience resourceWorkExperience)
        {
            return 0;
        }

        /// This method update resource work experience details.
        public bool UpdateResourceWorkExperience(ResourceWorkExperience resourceWorkExperience)
        {
            return false;
        }

        /// This method will return all the work preference from look up table.
        public List<WorkPreference> GetAllWorkPreferences()
        {
            return new List<WorkPreference>();
        }
    }
}
