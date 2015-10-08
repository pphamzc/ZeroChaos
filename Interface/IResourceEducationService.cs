using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public interface IResourceEducationService
    {
        /// This method will return ResourceEducation details from ResourceEducation table based on ResourceID.
        List<ResourceEducation> GetResourceEducationByResourceID(int resourceID);

	    /// This method will insert the Resource Education details in ResourceEducation Table.
        int AddResourceEducation(ResourceEducation ResourceEducation);

	/// This method will update the existing resource education record.
        bool UpdateResourceEducation(ResourceEducation ResourceEducation);

	/// This method will populate the Education Tab of Resource Dossier.
    /// This method will return ResourceEducationLanguageResponse  which consist of ResourceEducation  
    ///  Details and Resource Language Proficiency detail.
    ResourceEducationLanguageResponse GetResourceEducationLanguageResponseByResourceID (int resourceID);

    }
}
