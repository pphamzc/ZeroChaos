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
        ResourceEducation re = new ResourceEducation();
        ResourceLanguageProficiency rl;
        List<ResourceEducation> lre;
        public ResourceEducationService()
        {
          
            rl = new ResourceLanguageProficiency() { Language = "English", IsPrimary = true, SpeakProficiency = 5 };
            lre = new List<ResourceEducation>();
            lre.Add((ResourceEducation)re.AutoPopulate());
        }
        /// This method will return ResourceEducation details from ResourceEducation table based on ResourceID.
        public List<ResourceEducation> GetResourceEducationByResourceID(int resourceID)
        {
           
            return lre;
        }

        /// This method will insert the Resource Education details in ResourceEducation Table.
        public int AddResourceEducation(ResourceEducation ResourceEducation)
        {
            return 1;
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
            ResourceEducationLanguageResponse relp = new ResourceEducationLanguageResponse();
            relp.ResourceEducations = lre;
            relp.ResourceLanguageProficiencies = new List<ResourceLanguageProficiency>();

            relp.ResourceLanguageProficiencies.Add(new ResourceLanguageProficiency() { Language = "English", IsPrimary = true });
            return relp;
        }

    }
}
