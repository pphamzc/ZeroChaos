using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceJobPreferenceCountryService : IResourceJobPreferenceCountryService
    {
        /// This method will return the country names resource preferred to work or legally able to work.
        public List<ResourceJobPreferenceCountry> GetResourceJobPreferenceCountryByJobPreferenceIDResourcePreferenceForCountryID(int jobPreferenceID, int resourcePreferenceForCountryID)
        {
            return new List<ResourceJobPreferenceCountry>();
        }

        /// This method will add the country resource preferred to work.
        public int AddResourceJobPreferenceCountry(ResourceJobPreferenceCountry resourceJobPreferenceCountry)
        {
            return 0;
        }

        /// This method will update the country resource preferred to work.
        public bool UpdateResourceJobPreferenceCountry(ResourceJobPreferenceCountry resourceJobPreferenceCountry)
        {
            return true;
        }


    }
}
