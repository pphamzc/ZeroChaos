using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceDossierResponse
    {

        public Resource ResourceProfile { get; set; }
        public int ActiveProjects { get; set; }
        public int PastProjects { get; set; }
        public int Submissions { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ResourceWorkExperience> ResourceWorkExperiences { get; set; }
        public ResourceEducation ResourceHighestEducation { get; set; }
        public ResourceLanguageProficiency ResourcePrimaryLanguageProficiency { get; set; }
    }
}
