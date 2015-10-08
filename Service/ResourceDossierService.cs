using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    /// <summary>
    /// Resource Dossier
    /// Main Class to View/Edit Resource Dossier
    /// </summary>
    public class ResourceDossierService
    {

        #region View Dossier
        /// <summary>
        /// GetResourceDossierResponseByResourceID
        /// </summary>
        /// <param name="resourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceDossierResponse GetResourceDossierResponseByResourceID(int resourceID)
        {
            return new ResourceDossierResponse();
        }

        /// <summary>
        /// Gets the resource personal information response by resource identifier.
        /// </summary>
        /// <param name="resourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceResponse GetResourcePersonalInformationResponseByResourceID(int resourceID)
        {
            return new ResourceResponse();
        }

        /// <summary>
        /// Gets the resource job preference response by resource identifier.
        /// </summary>
        /// <param name="ResourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceJobPreferenceResponse GetResourceJobPreferenceResponseByResourceID(int ResourceID)
        {
            return new ResourceJobPreferenceResponse();
        }

        /// <summary>
        /// Gets the resource requisition submission response by resource identifier.
        /// </summary>
        /// <param name="resourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceRequisitionSubmissionResponse GetResourceRequisitionSubmissionResponseByResourceID(int resourceID)
        {
            return new ResourceRequisitionSubmissionResponse();
        }

        /// <summary>
        /// Gets the resource project review response by resource identifier.
        /// </summary>
        /// <param name="ResourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceProjectReviewResponse GetResourceProjectReviewResponseByResourceID(int ResourceID)
        {
            return new ResourceProjectReviewResponse();
        }

        /// <summary>
        /// Gets the resource work experiences response by resource identifier.
        /// </summary>
        /// <param name="resourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceWorkExperienceResponse GetResourceWorkExperiencesResponseByResourceID(int resourceID)
        {
            return new ResourceWorkExperienceResponse();
        }

        /// <summary>
        /// Gets the resource job skill certification response by resource identifier.
        /// </summary>
        /// <param name="resourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceJobSkillCertificationResponse GetResourceJobSkillCertificationResponseByResourceID(int resourceID)
        {
            return new ResourceJobSkillCertificationResponse();
        }

        /// <summary>
        /// Gets the resource resume attachment response by resource identifier.
        /// </summary>
        /// <param name="resourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceResumeAttachmentResponse GetResourceResumeAttachmentResponseByResourceID(int resourceID)
        {
            return new ResourceResumeAttachmentResponse();
        }

        /// <summary>
        /// Gets the resource education language response by resource identifier.
        /// </summary>
        /// <param name="resourceID">The resource identifier.</param>
        /// <returns></returns>
        public ResourceEducationLanguageResponse GetResourceEducationLanguageResponseByResourceID(int resourceID)
        {
            return new ResourceEducationLanguageResponse();
        }

        #endregion


        #region Edit Dossier
        /// <summary>
        /// Adds the update resource personal information by resource identifier.
        /// </summary>
        /// <param name="resourceRequest">The resource request.</param>
        /// <returns></returns>
        public int AddUpdateResourcePersonalInformationByResourceID(ResourceRequest resourceRequest)
        {
            return 0;
        }

        /// <summary>
        /// Adds the update resource job preference.
        /// </summary>
        /// <param name="resourceJobPreferenceRequest">The resource job preference request.</param>
        /// <returns></returns>
        public int AddUpdateResourceJobPreference(ResourceJobPreferenceRequest resourceJobPreferenceRequest)
        {
            return 0;
        }

        /// <summary>
        /// Adds the resource work experiencies.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int AddResourceWorkExperiencies(List<ResourceWorkExperience> list)
        {
            return 0;
        }

        /// <summary>
        /// Updates the resource work experiencies.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int UpdateResourceWorkExperiencies(List<ResourceWorkExperience> list)
        {
            return 0;
        }

        /// <summary>
        /// Adds the resource job skills.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int AddResourceJobSkills(List<ResourceJobSkill> list)
        {
            return 0;
        }

        /// <summary>
        /// Updates the resource job skills.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int UpdateResourceJobSkills(List<ResourceJobSkill> list)
        {
            return 0;
        }

        /// <summary>
        /// Adds the resource certifications.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int AddResourceCertifications(List<ResourceCertification> list)
        {
            return 0;
        }

        /// <summary>
        /// Updates the resource certification.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int UpdateResourceCertification(List<ResourceCertification> list)
        {
            return 0;
        }

        /// <summary>
        /// Adds the resource resume.
        /// </summary>
        /// <param name="resourceResumeRequest">The resource resume request.</param>
        /// <returns></returns>
        public int AddResourceResume(ResourceResumeRequest resourceResumeRequest)
        {
            return 0;
        }

        /// <summary>
        /// Updates the resource resume.
        /// </summary>
        /// <param name="resourceResumeRequest">The resource resume request.</param>
        /// <returns></returns>
        public int UpdateResourceResume(ResourceResumeRequest resourceResumeRequest)
        {
            return 0;
        }

        /// <summary>
        /// Updates the resource education.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int UpdateResourceEducation(List<ResourceEducation> list)
        {
            return 0;
        }

        /// <summary>
        /// Adds the resource education.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int AddResourceEducation(List<ResourceEducation> list)
        {
            return 0;
        }

        /// <summary>
        /// Adds the resource language proficiency.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int AddResourceLanguageProficiency(List<ResourceLanguageProficiency> list)
        {
            return 0;
        }

        /// <summary>
        /// Updates the resource language proficiency.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public int UpdateResourceLanguageProficiency(List<ResourceLanguageProficiency> list)
        {
            return 0;
        }

        #endregion
    }

}
