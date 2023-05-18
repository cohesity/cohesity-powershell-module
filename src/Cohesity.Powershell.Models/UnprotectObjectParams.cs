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
    /// Specifies the parameters to unprotect an object.
    /// </summary>
    [DataContract]
    public partial class UnprotectObjectParams :  IEquatable<UnprotectObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnprotectObjectParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnprotectObjectParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnprotectObjectParams" /> class.
        /// </summary>
        /// <param name="deleteSnapshots">Specifies whether to delete the snapshots of the Protection Object..</param>
        /// <param name="protectionSourceId">Specifies the id of the Protection Source to be unprotected. (required).</param>
        /// <param name="rpoPolicyId">Specifies the id of the Rpo Policy from which to unprotect the object. (required).</param>
        public UnprotectObjectParams(bool? deleteSnapshots = default(bool?), long? protectionSourceId = default(long?), string rpoPolicyId = default(string))
        {
            this.DeleteSnapshots = deleteSnapshots;
            this.ProtectionSourceId = protectionSourceId;
            this.RpoPolicyId = rpoPolicyId;
            this.DeleteSnapshots = deleteSnapshots;
        }
        
        /// <summary>
        /// Specifies whether to delete the snapshots of the Protection Object.
        /// </summary>
        /// <value>Specifies whether to delete the snapshots of the Protection Object.</value>
        [DataMember(Name="deleteSnapshots", EmitDefaultValue=true)]
        public bool? DeleteSnapshots { get; set; }

        /// <summary>
        /// Specifies the id of the Protection Source to be unprotected.
        /// </summary>
        /// <value>Specifies the id of the Protection Source to be unprotected.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=true)]
        public long? ProtectionSourceId { get; set; }

        /// <summary>
        /// Specifies the id of the Rpo Policy from which to unprotect the object.
        /// </summary>
        /// <value>Specifies the id of the Rpo Policy from which to unprotect the object.</value>
        [DataMember(Name="rpoPolicyId", EmitDefaultValue=true)]
        public string RpoPolicyId { get; set; }

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
            return this.Equals(input as UnprotectObjectParams);
        }

        /// <summary>
        /// Returns true if UnprotectObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UnprotectObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnprotectObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteSnapshots == input.DeleteSnapshots ||
                    (this.DeleteSnapshots != null &&
                    this.DeleteSnapshots.Equals(input.DeleteSnapshots))
                ) && 
                (
                    this.ProtectionSourceId == input.ProtectionSourceId ||
                    (this.ProtectionSourceId != null &&
                    this.ProtectionSourceId.Equals(input.ProtectionSourceId))
                ) && 
                (
                    this.RpoPolicyId == input.RpoPolicyId ||
                    (this.RpoPolicyId != null &&
                    this.RpoPolicyId.Equals(input.RpoPolicyId))
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
                if (this.DeleteSnapshots != null)
                    hashCode = hashCode * 59 + this.DeleteSnapshots.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                if (this.RpoPolicyId != null)
                    hashCode = hashCode * 59 + this.RpoPolicyId.GetHashCode();
                return hashCode;
            }
        }

    }

}

