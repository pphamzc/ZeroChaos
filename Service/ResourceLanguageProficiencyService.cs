using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    interface IResourceLanguageProficiencyService
    {

        /// This method will return resource language proficiency details based on resourceid. 
        List<ResourceLanguageProficiency> GetResourceLanguageProficiencyByResourceID(int resourceID);

        /// This method will add resource language proficiency details.
        int AddResourceLanguageProficiency(ResourceLanguageProficiency resourceLanguageProficiency);

        /// This method will update resource language proficiency level.
        bool UpdateResourceLanguageProficiency(ResourceLanguageProficiency resourceLanguageProficiency);

    }
}
