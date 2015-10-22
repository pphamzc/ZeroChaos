using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.TransactionalInterfaces;

namespace ZeroChaos.Service.Services
{
    public class ResourceResumeTransactionalService : IResourceResumeTransactionalService
    {
        /// This method will add / update the resource Resume Attachment details.
        public ResourceResumeAttachmentResponse AddUpdateResourceResumes(ResourceResumeAttachmentRequest resourceResumeAttachmentRequest)
        {
            return new ResourceResumeAttachmentResponse().AutoPopulate();
        }
    }
}
