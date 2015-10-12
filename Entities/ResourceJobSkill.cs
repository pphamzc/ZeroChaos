using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceJobSkill : BaseEntity
    {


        /// <summary>
        /// Gets or sets the resource job skill identifier.
        /// </summary>
        /// <value>
        /// The resource job skill identifier.
        /// </value>
        public int ResourceJobSkillID{get;set;}
        /// <summary>
        /// Gets or sets the resource identifier.
        /// </summary>
        /// <value>
        /// The resource identifier.
        /// </value>
        public int ResourceID { get; set; }
        /// <summary>
        /// Gets or sets the job skill identifier.
        /// </summary>
        /// <value>
        /// The job skill identifier.
        /// </value>
        public int JobSkillID { get; set; }
        /// <summary>
        /// Gets or sets the competency identifier.
        /// </summary>
        /// <value>
        /// The competency identifier.
        /// </value>
        public int CompetencyID { get; set; }
        /// <summary>
        /// Gets or sets the years experience.
        /// </summary>
        /// <value>
        /// The years experience.
        /// </value>
        public int YearsExperience { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeleted { get; set; }


        public override BaseEntity AutoPopulate()
        {
            this.JobSkillID = 1;
            this.ResourceJobSkillID = 2;
            this.YearsExperience = 5;
            this.CompetencyID = 3;
            this.ResourceID = 6;

            return this;
        }

    }
}
