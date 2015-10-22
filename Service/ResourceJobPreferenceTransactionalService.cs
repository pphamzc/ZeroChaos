using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.TransactionalInterfaces
{

    public class ResourceJobPreferenceTransactionalService : IResourceJobPreferenceTransactionalService 
    {
        /// This method will add / update the resource job preference details.
        public ResourceJobPreferenceResponse AddUpdateResourceJobPreferences(ResourceJobPreferenceRequest resourceJobPreferenceRequest)
        {
            return new ResourceJobPreferenceResponse().AutoPopulate();
        }
    }
}
