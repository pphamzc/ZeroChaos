using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceJobPreferenceResponse
    {
        public ResourceJobPreference ResourceJobPreference { get; set; }
        public List<ObjectJobCategoryMapping> jobCategory { get; set; }
        public List<ResourceJobClassification> jobClassification { get; set; }
        public List<ObjectIndustryMapping> resourceIndustry { get; set; }
        public List<ResourceJobPreferenceCountry> ResourceJobPreferenceCountry { get; set; }
        public string ResourcePreferenceForCountry { get; set; }

    }
}
