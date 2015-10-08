using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceJobPreferenceService : IResourceJobPreferenceService
    {

        /// This method will return the resource job preferences details from ResourceJobPreference table based  on ResourceID

        public ResourceJobPreference GetResourceJobPreferenceByResourceID(int resourceID)
        {
            return new ResourceJobPreference();
        }

        /// This method will add the resource job preference details in ResourceJobPreference table.
        public int AddResourceJobPreference(ResourceJobPreference resourceJobPreference)
        {
            return 0;
        }

        /// This method will update the resource job preference details.
        public bool UpdateResourceJobPreference(ResourceJobPreference resourceJobPreference)
        {
            return true;
        }

        /// This method will populate the Job Preference tab details of Resource Dossier.
        /// This method will return ResourceJobPreferenceResponse  which consist of Job Preference details
        public ResourceJobPreferenceResponse GetResourceJobPreferenceResponseByResourceID(int resourceID)
        {
            return new ResourceJobPreferenceResponse();
        }

    }
}
