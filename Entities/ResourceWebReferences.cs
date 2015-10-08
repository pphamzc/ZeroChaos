using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ZeroChaos.Business.Entities
{
    public class ResourceWebReferences
    {
        public int ResourceWebReferencesID { get; set; }
        public int ResourceID { get; set; }
        public string Description { get; set; }
        public string WebSiteAddress { get; set; }
        public bool IsDeleted { get; set; }

    }
}
