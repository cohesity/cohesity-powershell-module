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
    /// Specifies the params to update trusted domain enable flag.
    /// </summary>
    [DataContract]
    public partial class UpdateTrustedDomainEnableParams :  IEquatable<UpdateTrustedDomainEnableParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrustedDomainEnableParams" /> class.
        /// </summary>
        /// <param name="trustedDomainsEnabled">Request to update enable trusted domains state of an Active Directory..</param>
        public UpdateTrustedDomainEnableParams(bool? trustedDomainsEnabled = default(bool?))
        {
            this.TrustedDomainsEnabled = trustedDomainsEnabled;
            this.TrustedDomainsEnabled = trustedDomainsEnabled;
        }
        
        /// <summary>
        /// Request to update enable trusted domains state of an Active Directory.
        /// </summary>
        /// <value>Request to update enable trusted domains state of an Active Directory.</value>
        [DataMember(Name="trustedDomainsEnabled", EmitDefaultValue=true)]
        public bool? TrustedDomainsEnabled { get; set; }

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
            return this.Equals(input as UpdateTrustedDomainEnableParams);
        }

        /// <summary>
        /// Returns true if UpdateTrustedDomainEnableParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTrustedDomainEnableParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTrustedDomainEnableParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrustedDomainsEnabled == input.TrustedDomainsEnabled ||
                    (this.TrustedDomainsEnabled != null &&
                    this.TrustedDomainsEnabled.Equals(input.TrustedDomainsEnabled))
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
                if (this.TrustedDomainsEnabled != null)
                    hashCode = hashCode * 59 + this.TrustedDomainsEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}

