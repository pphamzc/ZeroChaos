using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZeroChaos.Business.Entities.Interface;


namespace ZeroChaos.Business.Entities
{
    public class ResourceResumeAttachmentResponse : IPoco<ResourceResumeAttachmentResponse>
    {
        public List<ResourceResume> ResourceResume { get; set; }
        public List<ResourceAttachment> ResourceAttachment { get; set; }
        public List<ResourceWebReferences> ResourceWebReferences { get; set; }



        public ResourceResumeAttachmentResponse AutoPopulate()
        {
            this.ResourceResume = new List<ResourceResume>();
            ResourceResume res = (ResourceResume)new ResourceResume().AutoPopulate();
            this.ResourceResume.Add(res);

            this.ResourceAttachment = new List<ResourceAttachment>();
            ResourceAttachment att = (ResourceAttachment)new ResourceAttachment().AutoPopulate();
            this.ResourceAttachment.Add(att);

            this.ResourceWebReferences = new List<ResourceWebReferences>();
            ResourceWebReferences wref = (ResourceWebReferences)new ResourceWebReferences().AutoPopulate();
            this.ResourceWebReferences.Add(wref);

            return this;
        }
    }
}
