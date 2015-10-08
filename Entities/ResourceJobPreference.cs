using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceJobPreference : BaseEntity
    {

        public int ResourceJobPreferenceID { get; set; }
        public int ResourceID { get; set; }
        public int JobPreferenceStatusID { get; set; }
        public DateTime JobPreferenceDateAvailable { get; set; }
        public double JobPreferencePreferredPay { get; set; }
        public double JobPreferenceMinimumPay { get; set; }
        public string JobPreferenceCurrencyCode { get; set; }
        public string JobPreferenceDesiredPosition { get; set; }
        public int JobPreferenceWorkPreferencesID { get; set; }
        public bool JobPreferenceWillingToRelocate { get; set; }

    }
}
