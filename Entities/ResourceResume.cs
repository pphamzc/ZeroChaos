using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceResume : BaseEntity
    {

        public int ResourceResumeID { get; set; }
        public int ResourceID { get; set; }
        public string ResumeText { get; set; }
        public bool IsResume { get; set; }
        public bool IsDeleted { get; set; }

        public override BaseEntity AutoPopulate()
        {
            this.ResourceResumeID = 1;
            this.ResourceID = 2;
            this.ResumeText = @"Human resources manager with solid skills in HR administration, policy and procedure development, traditional and electronic recruiting, hiring, training, employee relations, corporate communications, contract management, and affirmative action.
Effective change manager with record of success managing people and projects in fast-paced, high pressure environments.
Solid knowledge of state and federal employment / unemployment laws, EEOC, ADA, and OSHA regulations.
Well-developed interpersonal and communication skills.
Proficient with Windows, Microsoft Word, Microsoft Excel, and HRIS systems.
Experience WEST REHAB - West Creek, Mississippi Human Resources Manager Directed and managed staffing for 22 facilities. Recruited, hired, and trained staff. Supervised five staffing coordinators and handled all HR management functions.
Successfully improved company profits through effective management of human resources.
Conducted interviews, screened applicants, and provided new hire orientations.
Authored employee handbooks for three companies.
Implemented custom HRIS system to coordinate resource allocation and staff scheduling.
Developed and implemented policies, procedures, and initiatives that improved customer relations and dramatically reduced staff turnover.";

            return this;
        }
    }
}
