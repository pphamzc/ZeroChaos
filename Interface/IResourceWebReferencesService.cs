using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public interface IResourceWebReferencesService
    {
        /// This method return Web references details of the resource.
        List<ResourceWebReferences> GetResourceWebReferencesByResourceID(int resourceID);

        /// This method add the Web references details of the resource.
        int AddResourceWebReferences(ResourceWebReferences resourceWebReferences);

        /// This method update the Web references details of the resource.
        bool UpdateResourceWebReferences(ResourceWebReferences resourceWebReferences);

    }
}
