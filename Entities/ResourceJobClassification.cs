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
    }
}
