using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZeroChaos.Business.Entities.Interface;

namespace ZeroChaos.Business.Entities
{
    public class ResourceJobPreferenceResponse : IPoco<ResourceJobPreferenceResponse> 
    {
        public ResourceJobPreference ResourceJobPreference { get; set; }
        public List<ObjectJobCategoryMapping> jobCategory { get; set; }
        public List<ResourceJobClassification> jobClassification { get; set; }
        public List<ObjectIndustryMapping> resourceIndustry { get; set; }
        public List<ResourceJobPreferenceCountry> ResourceJobPreferenceCountry { get; set; }
        public string ResourcePreferenceForCountry { get; set; }

        public ResourceJobPreferenceResponse()
        {

        }

        public ResourceJobPreferenceResponse AutoPopulate()
        {
            this.ResourceJobPreference = (ResourceJobPreference)new ResourceJobPreference().AutoPopulate();
            this.jobCategory = new List<ObjectJobCategoryMapping>();
            this.jobClassification = new List<ResourceJobClassification>();
            ResourceJobClassification rjclass = (ResourceJobClassification)new ResourceJobClassification().AutoPopulate();
            this.resourceIndustry = new List<ObjectIndustryMapping>();
            this.ResourceJobPreferenceCountry = new List<ResourceJobPreferenceCountry>();
            ResourceJobPreferenceCountry cou = new ResourceJobPreferenceCountry().AutoPopulate();
            this.ResourceJobPreferenceCountry.Add(cou);

            return this;

        }
    }
}
