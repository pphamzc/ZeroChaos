using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.TransactionalInterfaces
{

    public interface IResourceLanguageProficiencyTransactionalService
    {
        /// This method will add / update the resource language proficiency details.
        bool AddUpdateResourceLanguageProficiencies(List<ResourceLanguageProficiency> resourceLanguageProficiencies);
    }
}
