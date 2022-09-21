// Copyright 2019 Cohesity Inc.


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Model
{
    /// <summary>
    /// Specifies a domain and its trusted domains.
    /// </summary>
    [DataContract]
    public partial class Domain :  IEquatable<Domain>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Domain" /> class.
        /// </summary>
        /// <param name="domainName">Specifies the domain name..</param>
        /// <param name="trustedDomains">Specifies a list of trusted domains of this domain..</param>
        public Domain(string domainName = default(string), List<string> trustedDomains = default(List<string>))
        {
            this.DomainName = domainName;
            this.TrustedDomains = trustedDomains;
            this.DomainName = domainName;
            this.TrustedDomains = trustedDomains;
        }
        
        /// <summary>
        /// Specifies the domain name.
        /// </summary>
        /// <value>Specifies the domain name.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies a list of trusted domains of this domain.
        /// </summary>
        /// <value>Specifies a list of trusted domains of this domain.</value>
        [DataMember(Name="trustedDomains", EmitDefaultValue=true)]
        public List<string> TrustedDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Domain);
        }

        /// <summary>
        /// Returns true if Domain instances are equal
        /// </summary>
        /// <param name="input">Instance of Domain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Domain input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.TrustedDomains == input.TrustedDomains ||
                    this.TrustedDomains != null &&
                    input.TrustedDomains != null &&
                    this.TrustedDomains.Equals(input.TrustedDomains)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.TrustedDomains != null)
                    hashCode = hashCode * 59 + this.TrustedDomains.GetHashCode();
                return hashCode;
            }
        }

    }

}

