using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceEducationLanguageResponse
    {
        public	List<ResourceEducation> ResourceEducations { get; set; }
        public List<ResourceLanguageProficiency> ResourceLanguageProficiencies { get; set; }

    }
}
