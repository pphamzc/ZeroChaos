using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceLanguageProficiency : BaseEntity
    {

        
        public int ResourceLanguageProficiencyID{get;set;}
        public int ResourceID { get; set; }
        public int LanguageID { get; set; }
        public string Language { get; set; }
        public int SpeakProficiency { get; set; }
        public int ReadProficiency { get; set; }
        public int WriteProficiency { get; set; }
        public bool IsPrimary { get; set; }
    }
}
