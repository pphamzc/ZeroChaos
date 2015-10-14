using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceResumeAttachmentResponse
    {
        public List<ResourceResume> ResourceResume { get; set; }
        public List<ResourceAttachment> ResourceAttachment { get; set; }
        public List<ResourceWebReferences> ResourceWebReferences { get; set; }

    }
}
