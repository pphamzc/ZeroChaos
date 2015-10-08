using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.TransactionalInterfaces;

namespace ZeroChaos.Service.Services
{


    public class ResourceLanguageProficiencyTransactionalService : IResourceLanguageProficiencyTransactionalService 
    {
        /// This method will add / update the resource language proficiency details.
        public bool AddUpdateResourceLanguageProficiencies(List<ResourceLanguageProficiency> resourceLanguageProficiencies)
        {
            return true;
        }
    }


}
