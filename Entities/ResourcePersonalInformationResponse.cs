using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourcePersonalInformationResponse
    {
        public ResourcePersonalInformationResponse()
        {
            this.Resource = (Resource)new Resource().AutoPopulate();
        }
        Resource Resource { get; set; }
    }
}
