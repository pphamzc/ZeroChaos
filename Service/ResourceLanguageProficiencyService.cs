using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public class ResourceLanguageProficiencyService : IResourceLanguageProficiencyService
    {

        /// This method will return resource language proficiency details based on resourceid. 
        public List<ResourceLanguageProficiency> GetResourceLanguageProficiencyByResourceID(int resourceID)
        {
            List<ResourceLanguageProficiency> l = new List<ResourceLanguageProficiency>();
            l.Add((ResourceLanguageProficiency)new ResourceLanguageProficiency().AutoPopulate());
            return l;
        }

        /// This method will add resource language proficiency details.
        public int AddResourceLanguageProficiency(ResourceLanguageProficiency resourceLanguageProficiency)
        {
            return 1;
        }

        /// This method will update resource language proficiency level.
        public bool UpdateResourceLanguageProficiency(ResourceLanguageProficiency resourceLanguageProficiency)
        {
            return true;
        }

    }
}
