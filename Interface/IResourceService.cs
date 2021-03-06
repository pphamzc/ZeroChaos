﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;


namespace ZeroChaos.Service.Interface
{
    public interface IResourceService
    {

        /// This method will populate the My Dossier tab of Resource Dossier.
        /// This method will return ResourceDossierResponse  which consist of resource details and personal information details of the resource.
        ResourceDossierResponse GetResourceDossierResponseByResourceID(int resourceID);

        /// This method will populate the Requisition Summary tab of Resource Dossier.
        /// This method will return ResourceRequisitionSubmissionResponse  which consist of req submission for the resource.
        ResourceRequisitionSubmissionResponse GetResourceRequisitionSubmissionResponseByResourceID(int resourceID);

        /// This method will populate the Resume & Attachment tab of Resource Dossier.
        /// This method will return ResourceResumeAttachmentResponse  which consist of resume details and attachment details for the resource.
        ResourceResumeAttachmentResponse GetResourceResumeAttachmentResponseByResourceID(int resourceID);

        /// This method will populate the Personal Information tab of Resource Dossier.
        /// This method will return ResourcePersonalInformationResponse  which consist of resource personal information details.
        ResourcePersonalInformationResponse GetResourcePersonalInformationResponseByResourceID(int resourceID);

        /// This method will populate the Projects & Reviews  tab of Resource Dossier.
        /// This method will return ResourceProjectReviewResponse  which consist of resource project details and survey review details.
        ResourceProjectReviewResponse GetResourceProjectReviewResponseByResourceID(int resourceID);

        /// This method will add / update the resource personal information.
        int AddUpdateResourcePersonalInformationByResourceID(ResourceRequest resourceRequest);

    }
}
