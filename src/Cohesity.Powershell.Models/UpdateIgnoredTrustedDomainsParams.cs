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
    /// Specifies the params to update the list of ignored trusted domains.
    /// </summary>
    [DataContract]
    public partial class UpdateIgnoredTrustedDomainsParams :  IEquatable<UpdateIgnoredTrustedDomainsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIgnoredTrustedDomainsParams" /> class.
        /// </summary>
        /// <param name="ignoredTrustedDomains">Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery..</param>
        public UpdateIgnoredTrustedDomainsParams(List<string> ignoredTrustedDomains = default(List<string>))
        {
            this.IgnoredTrustedDomains = ignoredTrustedDomains;
            this.IgnoredTrustedDomains = ignoredTrustedDomains;
        }
        
        /// <summary>
        /// Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery.
        /// </summary>
        /// <value>Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery.</value>
        [DataMember(Name="ignoredTrustedDomains", EmitDefaultValue=true)]
        public List<string> IgnoredTrustedDomains { get; set; }

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
            return this.Equals(input as UpdateIgnoredTrustedDomainsParams);
        }

        /// <summary>
        /// Returns true if UpdateIgnoredTrustedDomainsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateIgnoredTrustedDomainsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateIgnoredTrustedDomainsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IgnoredTrustedDomains == input.IgnoredTrustedDomains ||
                    this.IgnoredTrustedDomains != null &&
                    input.IgnoredTrustedDomains != null &&
                    this.IgnoredTrustedDomains.Equals(input.IgnoredTrustedDomains)
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
                if (this.IgnoredTrustedDomains != null)
                    hashCode = hashCode * 59 + this.IgnoredTrustedDomains.GetHashCode();
                return hashCode;
            }
        }

    }

}

