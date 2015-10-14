using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceAttachment : BaseEntity
    {
        public string AttachementType { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime DateUploaded { get; set; }
        public string Uploadedby { get; set; }
        public bool HasResume { get; set; }

        public override BaseEntity AutoPopulate()
        {
            this.AttachementType = "Primary Resume";
            this.FileName = "123456789099876543211234567890.doc";
            this.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,";
            this.DateUploaded = new DateTime(2014, 6, 5);
            this.Uploadedby = "John Doe";
            this.HasResume = true;

            return this;
        }
    }
}
