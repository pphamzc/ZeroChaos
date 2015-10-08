using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public interface IResourceJobClassificationService
    {

        /// This method will return List of Resource JobClassification based on ResourceID
        List<ResourceJobClassification> GetResourceJobClassificationByResourceId(int resourceID);

        /// This method will insert  Resource JobClassification based on ResourceID
        int AddResourceJobClassification(ResourceJobClassification resourceJobClassification);

        /// This method will update the Resource Jobclassification
        bool UpdateResourceJobClassification(ResourceJobClassification resourceJobClassification);

    }
}
