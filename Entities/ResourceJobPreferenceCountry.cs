using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZeroChaos.Business.Entities.Interface;

namespace ZeroChaos.Business.Entities
{
    public class ResourceJobPreferenceCountry : IPoco<ResourceJobPreferenceCountry>
    {
        public int ResourceJobPreferenceCountryID { get; set; }
        public int ResourceJobPreferenceID { get; set; }
        public int ResourcePreferenceForCountryID { get; set; }
        public string CountryCode { get; set; }



        public ResourceJobPreferenceCountry AutoPopulate()
        {
            this.CountryCode = "US";
            this.ResourceJobPreferenceCountryID = 2;
            this.ResourceJobPreferenceID = 3;
            this.ResourcePreferenceForCountryID = 4;

            return this;
        }
    }
}
