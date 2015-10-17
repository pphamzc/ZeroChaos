using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceJobClassification : BaseEntity
    {
        public int ResourceJobClassificationID{get;set;}
        public int ResourceJobPreferenceID { get; set; }
        public int JobClassID { get; set; }

        public override BaseEntity AutoPopulate()
        {
            this.ResourceJobClassificationID = 1;
            this.ResourceJobPreferenceID = 2;
            return this;
        }
    }
}
