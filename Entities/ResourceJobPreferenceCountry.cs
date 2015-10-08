using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceJobPreferenceCountry
    {
        public int ResourceJobPreferenceCountryID { get; set; }
        public int ResourceJobPreferenceID { get; set; }
        public int ResourcePreferenceForCountryID { get; set; }
        public string CountryCode { get; set; }

    }
}
