using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceCertification
    {

        /// <summary>
        /// Gets or sets the resource certification identifier.
        /// </summary>
        /// <value>
        /// The resource certification identifier.
        /// </value>
        public int ResourceCertificationID { get; set; }
        /// <summary>
        /// Gets or sets the resource identifier.
        /// </summary>
        /// <value>
        /// The resource identifier.
        /// </value>
        public int ResourceID { get; set; }
        /// <summary>
        /// Gets or sets the job cert identifier.
        /// </summary>
        /// <value>
        /// The job cert identifier.
        /// </value>
        public int JobCertID { get; set; }
        /// <summary>
        /// Gets or sets the issuing authority.
        /// </summary>
        /// <value>
        /// The issuing authority.
        /// </value>
        public int IssuingAuthority { get; set; }
        /// <summary>
        /// Gets or sets the certification number.
        /// </summary>
        /// <value>
        /// The certification number.
        /// </value>
        public int CertificationNumber { get; set; }

        /// <summary>
        /// Gets or sets the issued date.
        /// </summary>
        /// <value>
        /// The issued date.
        /// </value>
        public DateTime IssuedDate { get; set; }
        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [never expire].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [never expire]; otherwise, <c>false</c>.
        /// </value>
        public bool NeverExpire { get; set; }
        /// <summary>
        /// Gets or sets the verification status identifier.
        /// </summary>
        /// <value>
        /// The verification status identifier.
        /// </value>
        public int VerificationStatusID { get; set; }
        /// <summary>
        /// Gets or sets the verified date.
        /// </summary>
        /// <value>
        /// The verified date.
        /// </value>
        public DateTime VerifiedDate { get; set; }
        /// <summary>
        /// Gets or sets the effective date.
        /// </summary>
        /// <value>
        /// The effective date.
        /// </value>
        public DateTime EffectiveDate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is required.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is required; otherwise, <c>false</c>.
        /// </value>
        public bool IsRequired { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeleted { get; set; }





    }
}
