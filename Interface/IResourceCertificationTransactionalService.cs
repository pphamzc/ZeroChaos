using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.TransactionalInterfaces
{
    public interface IResourceCertificationTransactionalService
    {
        /// This method will add / update the resource certification details.
        bool AddUpdateResourceCertifications(List<ResourceCertification> resourceCertifications);
    }

}
