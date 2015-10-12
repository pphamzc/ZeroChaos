using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroChaos.Business.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseEntity
    {

        public enum LanguageProfiency { Fluent, Intermediate, Beginner };
        public enum JobPreferenceStatus { Available, FutureAvailable, NotAvailable };
        public enum WorkPreference { Onsite, Remote, Both };
        public enum ResourceJobPreferenceForCountry { LegallyAllowedToWork, PreferredToWork };

        public BaseEntity()
        {

        }
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        public int CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// Gets or sets the modified by identifier.
        /// </summary>
        /// <value>
        /// The modified by identifier.
        /// </value>
        public int ModifiedByID { get; set; }
        /// <summary>
        /// Gets or sets the updated by login.
        /// </summary>
        /// <value>
        /// The updated by login.
        /// </value>
        public string UpdatedByLogin { get; set; }

        public virtual BaseEntity AutoPopulate()
        {
            return new BaseEntity() { CreatedBy = 1, CreatedDate = new DateTime(2015, 1, 1), ModifiedByID = 1, ModifiedDate = new DateTime(2015, 2, 1) };
        }
    }
}
