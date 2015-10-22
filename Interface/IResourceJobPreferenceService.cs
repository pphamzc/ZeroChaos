using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public interface IResourceJobPreferenceService
    {

        /// This method will return the resource job preferences details from ResourceJobPreference table based  on ResourceID

         ResourceJobPreference GetResourceJobPreferenceByResourceID(int resourceID);

        /// This method will add the resource job preference details in ResourceJobPreference table.
         int AddResourceJobPreference(ResourceJobPreference resourceJobPreference);

        /// This method will update the resource job preference details.
         bool UpdateResourceJobPreference(ResourceJobPreference resourceJobPreference);

        /// This method will populate the Job Preference tab details of Resource Dossier.
        /// This method will return ResourceJobPreferenceResponse  which consist of Job Preference details
         ResourceJobPreferenceResponse GetResourceJobPreferenceResponseByResourceID(int resourceID);

    }
}
