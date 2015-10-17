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


        public override BaseEntity AutoPopulate()
        {
            this.JobPreferenceStatusID = 1;
            this.ResourceID = 1;
            this.JobPreferenceCurrencyCode = "USD";
            this.JobPreferenceDateAvailable = new DateTime(2015, 1, 3);
            this.JobPreferencePreferredPay = 100.00;
            this.JobPreferenceMinimumPay = 100.00;
            this.JobPreferenceDesiredPosition = "Manager";
            this.JobPreferenceWillingToRelocate = true;
            return this;
        }
    }
}
