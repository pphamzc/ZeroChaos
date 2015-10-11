using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroChaos.Business.Entities.Enums
{
    public class Enums
    {
        public enum LanguageProfiency { Fluent, Intermediate, Beginner };
        public enum JobPreferenceStatus { Available, FutureAvailable, NotAvailable};
        public enum WorkPreference { Onsite, Remote, Both };
        public enum ResourceJobPreferenceForCountry { LegallyAllowedToWork, PreferredToWork };
    }
}
