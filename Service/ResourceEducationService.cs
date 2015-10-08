using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;
using ZeroChaos.Service.TransactionalInterfaces;

namespace ZeroChaos.Service.Services
{
    public class ResourceEducationService : IResourceEducationService
    {
        /// This method will return ResourceEducation details from ResourceEducation table based on ResourceID.
        public List<ResourceEducation> GetResourceEducationByResourceID(int resourceID)
        {
            return new List<ResourceEducation>();
        }

        /// This method will insert the Resource Education details in ResourceEducation Table.
        public int AddResourceEducation(ResourceEducation ResourceEducation)
        {
            return 0;
        }

        /// This method will update the existing resource education record.
        public bool UpdateResourceEducation(ResourceEducation ResourceEducation)
        {
            return true;
        }

        /// This method will populate the Education Tab of Resource Dossier.
        /// This method will return ResourceEducationLanguageResponse  which consist of ResourceEducation  
        ///  Details and Resource Language Proficiency detail.
        public ResourceEducationLanguageResponse GetResourceEducationLanguageResponseByResourceID(int resourceID)
        {
            return new ResourceEducationLanguageResponse();
        }

    }
}
