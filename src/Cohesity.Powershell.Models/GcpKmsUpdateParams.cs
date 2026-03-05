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
    /// GcpKmsUpdateParams
    /// </summary>
    [DataContract]
    public partial class GcpKmsUpdateParams :  IEquatable<GcpKmsUpdateParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpKmsUpdateParams" /> class.
        /// </summary>
        /// <param name="impersonationAccountId">Specifies the account id to impersonate for gcp kms access.</param>
        public GcpKmsUpdateParams(string impersonationAccountId = default(string))
        {
            this.ImpersonationAccountId = impersonationAccountId;
            this.ImpersonationAccountId = impersonationAccountId;
        }
        
        /// <summary>
        /// Specifies the account id to impersonate for gcp kms access
        /// </summary>
        /// <value>Specifies the account id to impersonate for gcp kms access</value>
        [DataMember(Name="impersonationAccountId", EmitDefaultValue=true)]
        public string ImpersonationAccountId { get; set; }

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
            return this.Equals(input as GcpKmsUpdateParams);
        }

        /// <summary>
        /// Returns true if GcpKmsUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpKmsUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpKmsUpdateParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImpersonationAccountId == input.ImpersonationAccountId ||
                    (this.ImpersonationAccountId != null &&
                    this.ImpersonationAccountId.Equals(input.ImpersonationAccountId))
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
                if (this.ImpersonationAccountId != null)
                    hashCode = hashCode * 59 + this.ImpersonationAccountId.GetHashCode();
                return hashCode;
            }
        }

    }

}

