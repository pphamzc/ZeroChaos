using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.TransactionalInterfaces;

namespace ZeroChaos.Service.Services
{
    public class ResourceJobSkillTransactionalService : IResourceJobSkillTransactionalService
    {
        /// This method will add / update the resource job skill details.
        public bool AddUpdateResourceJobSkills(List<ResourceJobSkill> resourceJobSkills)
        { return true; }
    }
}
