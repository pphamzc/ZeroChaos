using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceWorkExperience : BaseEntity
    {

        public int ResourceWorkExperienceID { get; set; }
        public int ResourceID { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CompanyWebsite { get; set; }
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public string Link3 { get; set; }
        public string WorkDescription { get; set; }
        public bool IsDeleted { get; set; }

        public override BaseEntity AutoPopulate()
        {
            this.ResourceWorkExperienceID = 1;
            this.ResourceID = 2;

            this.CompanyName = "My Company";
            this.JobTitle = "My Title";
            this.StartDate = new DateTime(2014, 1, 5);
            this.EndDate = new DateTime(2014, 1, 5);
            this.CompanyWebsite = "www.mylink.com";
            this.Link1 = "www.mylink1.com";
            this.Link2 = "www.mylink2.com";
            this.Link3 = "www.mylink3.com";
            this.WorkDescription = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est.";
            this.IsDeleted = false;

            return this;
        }
    }



}
