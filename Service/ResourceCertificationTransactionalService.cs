using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;
using ZeroChaos.Service.TransactionalInterfaces;

namespace ZeroChaos.Service.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceCertificationTransactionalService : IResourceCertificationTransactionalService
    {
        /// <summary>
        /// </summary>
        /// <param name="resourceCertifications"></param>
        /// <returns></returns>
        /// This method will add / update the resource certification details.
        public bool AddUpdateResourceCertifications(List<ResourceCertification> resourceCertifications)
        {
            return true;
        }
    }
}
