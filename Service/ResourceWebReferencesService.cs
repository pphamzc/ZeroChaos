using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceWebReferencesService : IResourceWebReferencesService
    {
        /// This method return Web references details of the resource.
        public List<ResourceWebReferences> GetResourceWebReferencesByResourceID(int resourceID)
        {
            List<ResourceWebReferences> r = new List<ResourceWebReferences>();
            r.Add((ResourceWebReferences)new ResourceWebReferences().AutoPopulate());
            return r;
        }

        /// This method add the Web references details of the resource.
        public int AddResourceWebReferences(ResourceWebReferences resourceWebReferences)
        {
            return 0;
        }

        /// This method update the Web references details of the resource.
        public bool UpdateResourceWebReferences(ResourceWebReferences resourceWebReferences)
        {
            return false;
        }

    }
}
