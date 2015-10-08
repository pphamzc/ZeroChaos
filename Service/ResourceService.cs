using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceService : IResourceService
    {

        /// This method will populate the My Dossier tab of Resource Dossier.
        /// This method will return ResourceDossierResponse  which consist of resource details and personal information details of the resource.
        public ResourceDossierResponse GetResourceDossierResponseByResourceID(int resourceID)
        {
            return new ResourceDossierResponse();
        }

        /// This method will populate the Requisition Summary tab of Resource Dossier.
        /// This method will return ResourceRequisitionSubmissionResponse  which consist of req submission for the resource.
        public ResourceRequisitionSubmissionResponse GetResourceRequisitionSubmissionResponseByResourceID(int resourceID)
        {
            return new ResourceRequisitionSubmissionResponse();
        }

        /// This method will populate the Resume & Attachment tab of Resource Dossier.
        /// This method will return ResourceResumeAttachmentResponse  which consist of resume details and attachment details for the resource.
        public ResourceResumeAttachmentResponse GetResourceResumeAttachmentResponseByResourceID(int resourceID)
        {
            return new ResourceResumeAttachmentResponse();
        }

        /// This method will populate the Personal Information tab of Resource Dossier.
        /// This method will return ResourcePersonalInformationResponse  which consist of resource personal information details.
        public ResourcePersonalInformationResponse GetResourcePersonalInformationResponseByResourceID(int resourceID)
        {
            return new ResourcePersonalInformationResponse();
        }

        /// This method will populate the Projects & Reviews  tab of Resource Dossier.
        /// This method will return ResourceProjectReviewResponse  which consist of resource project details and survey review details.
        public ResourceProjectReviewResponse GetResourceProjectReviewResponseByResourceID(int resourceID)
        {
            return new ResourceProjectReviewResponse();
        }

        /// This method will add / update the resource personal information.
        public int AddUpdateResourcePersonalInformationByResourceID(ResourceRequest resourceRequest)
        {
            return 0;
        }

    }
}
