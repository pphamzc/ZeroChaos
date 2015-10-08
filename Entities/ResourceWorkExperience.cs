using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceWorkExperience : BaseEntity
    {

        public int ResourceWorkExperienceID{get;set;}
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
    }
}
