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
    /// GcpKmsConfiguration
    /// </summary>
    [DataContract]
    public partial class GcpKmsConfiguration :  IEquatable<GcpKmsConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpKmsConfiguration" /> class.
        /// </summary>
        /// <param name="impersonationAccountId">The account id to impersonate in order to access the kms server.</param>
        /// <param name="kmsKeyUrl">Url for the gcp kms key..</param>
        public GcpKmsConfiguration(string impersonationAccountId = default(string), string kmsKeyUrl = default(string))
        {
            this.ImpersonationAccountId = impersonationAccountId;
            this.KmsKeyUrl = kmsKeyUrl;
            this.ImpersonationAccountId = impersonationAccountId;
            this.KmsKeyUrl = kmsKeyUrl;
        }
        
        /// <summary>
        /// The account id to impersonate in order to access the kms server
        /// </summary>
        /// <value>The account id to impersonate in order to access the kms server</value>
        [DataMember(Name="impersonationAccountId", EmitDefaultValue=true)]
        public string ImpersonationAccountId { get; set; }

        /// <summary>
        /// Url for the gcp kms key.
        /// </summary>
        /// <value>Url for the gcp kms key.</value>
        [DataMember(Name="kmsKeyUrl", EmitDefaultValue=true)]
        public string KmsKeyUrl { get; set; }

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
            return this.Equals(input as GcpKmsConfiguration);
        }

        /// <summary>
        /// Returns true if GcpKmsConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpKmsConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpKmsConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImpersonationAccountId == input.ImpersonationAccountId ||
                    (this.ImpersonationAccountId != null &&
                    this.ImpersonationAccountId.Equals(input.ImpersonationAccountId))
                ) && 
                (
                    this.KmsKeyUrl == input.KmsKeyUrl ||
                    (this.KmsKeyUrl != null &&
                    this.KmsKeyUrl.Equals(input.KmsKeyUrl))
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
                if (this.KmsKeyUrl != null)
                    hashCode = hashCode * 59 + this.KmsKeyUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}

