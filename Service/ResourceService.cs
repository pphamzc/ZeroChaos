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


        ResourceDossierResponse rdr;
        ResourceEducation re;
        ResourceLanguageProficiency rl;
        List<ResourceEducation> lre;

        public ResourceService()
        {

            re = new ResourceEducation(); 
            rl = new ResourceLanguageProficiency();
            lre = new List<ResourceEducation>();
            lre.Add((ResourceEducation)re.AutoPopulate());

            rdr = new ResourceDossierResponse();
            rdr.PastProjects = 1;
            rdr.ResourceHighestEducation = re;
            rdr.ResourcePrimaryLanguageProficiency = rl;
            Resource r = new Resource();


            rdr.ResourceProfile = (Resource)r.AutoPopulate();
        }



        /// This method will populate the My Dossier tab of Resource Dossier.
        /// This method will return ResourceDossierResponse  which consist of resource details and personal information details of the resource.
        public ResourceDossierResponse GetResourceDossierResponseByResourceID(int resourceID)
        {
            return rdr;
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
            ResourceResumeAttachmentResponse rrar = new ResourceResumeAttachmentResponse();
            rrar.ResourceAttachment = new List<ResourceAttachment>();
            rrar.ResourceAttachment.Add((ResourceAttachment)new ResourceAttachment().AutoPopulate());
            rrar.ResourceResume = new List<ResourceResume>();
            rrar.ResourceResume.Add((ResourceResume)new ResourceResume().AutoPopulate());
            rrar.ResourceWebReferences = new List<ResourceWebReferences>();
            rrar.ResourceWebReferences.Add((ResourceWebReferences)new ResourceWebReferences().AutoPopulate());
            return rrar;
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
            return 1;
        }

    }
}
