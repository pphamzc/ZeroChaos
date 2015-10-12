using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceEducation : BaseEntity
    {

        public int ResourceEducationID{get;set;}
        public int ResourceID { get; set; }
        public int EducationID { get; set; }
        public string InstituteName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Degree { get; set; }
        public string StudyField { get; set; }


        public override BaseEntity AutoPopulate()
        {
            base.AutoPopulate();
            this.ResourceEducationID = 1;
            this.Degree = "Masters Degrees";
            this.InstituteName = "Purdue University";
            this.StudyField = "Engineering";
            this.StartDate = new DateTime(200, 1, 1);
            this.EndDate = new DateTime(2004, 1, 1);

            return this;
        } 
    }
}
