using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.TransactionalInterfaces;

namespace ZeroChaos.Service.Services
{
    public class ResourceWorkExperienceTransactionalService : IResourceWorkExperienceTransactionalService
    {
        /// This method will add / update the resource Work Experience details.
        public ResourceWorkExperienceResponse AddUpdateResourceWorkExperiencies(ResourceWorkExperienceRequest resourceWorkExperienceRequest)
        {
            ResourceWorkExperienceResponse temp = new ResourceWorkExperienceResponse();
            temp.ResourceWorkExperience = new List<ResourceWorkExperience>();
            temp.ResourceWorkExperience.Add(new ResourceWorkExperience(){ CompanyName = "My Company", CompanyWebsite = "www.mylink.com", JobTitle = "My Title"});
            return temp;
        }
    }
}
