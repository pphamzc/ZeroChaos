using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ObjectIndustryMapping : BaseEntity
    {
        public int ObjectIndustryMappingID { get; set; }
        public int ObjectID { get; set; }
        public int ObjectPKID { get; set; }
        public int IndustryGroupID { get; set; }

        public override BaseEntity AutoPopulate()
        {
            this.ObjectID = 1;
            this.ObjectIndustryMappingID = 2;

            return this;
        }

    }
}
