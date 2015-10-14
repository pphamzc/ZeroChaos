using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ZeroChaos.Business.Entities
{
    public class ResourceWebReferences : BaseEntity
    {
        public int ResourceWebReferencesID { get; set; }
        public int ResourceID { get; set; }
        public string Description { get; set; }
        public string WebSiteAddress { get; set; }
        public bool IsDeleted { get; set; }

        public override BaseEntity AutoPopulate()
        {
            this.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing";
            this.WebSiteAddress = "mylink.com";
            this.ResourceWebReferencesID = 1;
            this.ResourceID = 2;

            return this;
        }
    }
}
