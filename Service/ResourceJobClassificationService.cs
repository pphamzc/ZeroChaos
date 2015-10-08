using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceJobClassificationService : IResourceJobClassificationService
    {

        /// This method will return List of Resource JobClassification based on ResourceID
        public List<ResourceJobClassification> GetResourceJobClassificationByResourceId(int resourceID)
        {
            return new List<ResourceJobClassification>();
        }

        /// This method will insert  Resource JobClassification based on ResourceID
        public int AddResourceJobClassification(ResourceJobClassification resourceJobClassification)
        {
            return 0;
        }

        /// This method will update the Resource Jobclassification
        public bool UpdateResourceJobClassification(ResourceJobClassification resourceJobClassification)
        {
            return true;
        }

    }
}
