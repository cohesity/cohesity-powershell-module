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
    /// Quota
    /// </summary>
    [DataContract]
    public partial class Quota :  IEquatable<Quota>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quota" /> class.
        /// </summary>
        /// <param name="deleted">Total space consumed by files in the recycle bin, in bytes. Read-only..</param>
        /// <param name="remaining">Total space remaining before reaching the quota limit, in bytes..</param>
        /// <param name="state">Enumeration value that indicates the state of the storage space..</param>
        /// <param name="total">Total allowed storage space, in bytes. Read-only..</param>
        /// <param name="used">Total space used, in bytes. Read-only..</param>
        public Quota(long? deleted = default(long?), long? remaining = default(long?), string state = default(string), long? total = default(long?), long? used = default(long?))
        {
            this.Deleted = deleted;
            this.Remaining = remaining;
            this.State = state;
            this.Total = total;
            this.Used = used;
            this.Deleted = deleted;
            this.Remaining = remaining;
            this.State = state;
            this.Total = total;
            this.Used = used;
        }
        
        /// <summary>
        /// Total space consumed by files in the recycle bin, in bytes. Read-only.
        /// </summary>
        /// <value>Total space consumed by files in the recycle bin, in bytes. Read-only.</value>
        [DataMember(Name="deleted", EmitDefaultValue=true)]
        public long? Deleted { get; set; }

        /// <summary>
        /// Total space remaining before reaching the quota limit, in bytes.
        /// </summary>
        /// <value>Total space remaining before reaching the quota limit, in bytes.</value>
        [DataMember(Name="remaining", EmitDefaultValue=true)]
        public long? Remaining { get; set; }

        /// <summary>
        /// Enumeration value that indicates the state of the storage space.
        /// </summary>
        /// <value>Enumeration value that indicates the state of the storage space.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public string State { get; set; }

        /// <summary>
        /// Total allowed storage space, in bytes. Read-only.
        /// </summary>
        /// <value>Total allowed storage space, in bytes. Read-only.</value>
        [DataMember(Name="total", EmitDefaultValue=true)]
        public long? Total { get; set; }

        /// <summary>
        /// Total space used, in bytes. Read-only.
        /// </summary>
        /// <value>Total space used, in bytes. Read-only.</value>
        [DataMember(Name="used", EmitDefaultValue=true)]
        public long? Used { get; set; }

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
            return this.Equals(input as Quota);
        }

        /// <summary>
        /// Returns true if Quota instances are equal
        /// </summary>
        /// <param name="input">Instance of Quota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quota input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.Remaining == input.Remaining ||
                    (this.Remaining != null &&
                    this.Remaining.Equals(input.Remaining))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
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
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.Remaining != null)
                    hashCode = hashCode * 59 + this.Remaining.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                return hashCode;
            }
        }

    }

}

