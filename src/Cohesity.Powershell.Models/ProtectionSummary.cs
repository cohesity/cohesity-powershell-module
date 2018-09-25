// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the number of protected and unprotected objects, and their sizes information of the given entity.
    /// </summary>
    [DataContract]
    public partial class ProtectionSummary :  IEquatable<ProtectionSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSummary" /> class.
        /// </summary>
        /// <param name="protectedCount">Specifies the number of objects that are protected under the given entity..</param>
        /// <param name="protectedSize">Specifies the total size of the protected objects under the given entity..</param>
        /// <param name="unprotectedCount">Specifies the number of objects that are not protected under the given entity..</param>
        /// <param name="unprotectedSize">Specifies the total size of the unprotected objects under the given entity..</param>
        public ProtectionSummary(long? protectedCount = default(long?), long? protectedSize = default(long?), long? unprotectedCount = default(long?), long? unprotectedSize = default(long?))
        {
            this.ProtectedCount = protectedCount;
            this.ProtectedSize = protectedSize;
            this.UnprotectedCount = unprotectedCount;
            this.UnprotectedSize = unprotectedSize;
        }
        
        /// <summary>
        /// Specifies the number of objects that are protected under the given entity.
        /// </summary>
        /// <value>Specifies the number of objects that are protected under the given entity.</value>
        [DataMember(Name="protectedCount", EmitDefaultValue=false)]
        public long? ProtectedCount { get; set; }

        /// <summary>
        /// Specifies the total size of the protected objects under the given entity.
        /// </summary>
        /// <value>Specifies the total size of the protected objects under the given entity.</value>
        [DataMember(Name="protectedSize", EmitDefaultValue=false)]
        public long? ProtectedSize { get; set; }

        /// <summary>
        /// Specifies the number of objects that are not protected under the given entity.
        /// </summary>
        /// <value>Specifies the number of objects that are not protected under the given entity.</value>
        [DataMember(Name="unprotectedCount", EmitDefaultValue=false)]
        public long? UnprotectedCount { get; set; }

        /// <summary>
        /// Specifies the total size of the unprotected objects under the given entity.
        /// </summary>
        /// <value>Specifies the total size of the unprotected objects under the given entity.</value>
        [DataMember(Name="unprotectedSize", EmitDefaultValue=false)]
        public long? UnprotectedSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as ProtectionSummary);
        }

        /// <summary>
        /// Returns true if ProtectionSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectedCount == input.ProtectedCount ||
                    (this.ProtectedCount != null &&
                    this.ProtectedCount.Equals(input.ProtectedCount))
                ) && 
                (
                    this.ProtectedSize == input.ProtectedSize ||
                    (this.ProtectedSize != null &&
                    this.ProtectedSize.Equals(input.ProtectedSize))
                ) && 
                (
                    this.UnprotectedCount == input.UnprotectedCount ||
                    (this.UnprotectedCount != null &&
                    this.UnprotectedCount.Equals(input.UnprotectedCount))
                ) && 
                (
                    this.UnprotectedSize == input.UnprotectedSize ||
                    (this.UnprotectedSize != null &&
                    this.UnprotectedSize.Equals(input.UnprotectedSize))
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
                if (this.ProtectedCount != null)
                    hashCode = hashCode * 59 + this.ProtectedCount.GetHashCode();
                if (this.ProtectedSize != null)
                    hashCode = hashCode * 59 + this.ProtectedSize.GetHashCode();
                if (this.UnprotectedCount != null)
                    hashCode = hashCode * 59 + this.UnprotectedCount.GetHashCode();
                if (this.UnprotectedSize != null)
                    hashCode = hashCode * 59 + this.UnprotectedSize.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

