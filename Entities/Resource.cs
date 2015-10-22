using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroChaos.Business.Entities
{
    public class Resource : BaseEntity

    {
        public string CareerGoal { get; set; }
        public string AspiringQuote { get; set; }
        public string website { get; set; }
        public string MonthAndDayOfBirth { get; set; }
        public int UniqueResourceID { get; set; }
        public string NationalID { get; set; }
        public string CitizenCountryCode { get; set; }
        public bool AllowProfileSearch { get; set; }
        public bool WillingToRelocate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override BaseEntity AutoPopulate()
        {

            this.CareerGoal = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod.";
            this.AspiringQuote = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est.";
            this.website = "www.mysite.com";
            this.WillingToRelocate = true;
            this.FirstName = "John";
            this.LastName = "Doe";
            return this;
        }
    }
}
