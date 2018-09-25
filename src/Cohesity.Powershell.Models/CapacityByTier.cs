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
    /// CapacityByTier provides the physical capacity in bytes of each storage tier.
    /// </summary>
    [DataContract]
    public partial class CapacityByTier :  IEquatable<CapacityByTier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityByTier" /> class.
        /// </summary>
        /// <param name="storageTier">StorageTier is the type of StorageTier..</param>
        /// <param name="tierMaxPhysicalCapacityBytes">TierMaxPhysicalCapacityBytes is the maximum physical capacity in bytes of the storage tier..</param>
        public CapacityByTier(long? storageTier = default(long?), long? tierMaxPhysicalCapacityBytes = default(long?))
        {
            this.StorageTier = storageTier;
            this.TierMaxPhysicalCapacityBytes = tierMaxPhysicalCapacityBytes;
        }
        
        /// <summary>
        /// StorageTier is the type of StorageTier.
        /// </summary>
        /// <value>StorageTier is the type of StorageTier.</value>
        [DataMember(Name="storageTier", EmitDefaultValue=false)]
        public long? StorageTier { get; set; }

        /// <summary>
        /// TierMaxPhysicalCapacityBytes is the maximum physical capacity in bytes of the storage tier.
        /// </summary>
        /// <value>TierMaxPhysicalCapacityBytes is the maximum physical capacity in bytes of the storage tier.</value>
        [DataMember(Name="tierMaxPhysicalCapacityBytes", EmitDefaultValue=false)]
        public long? TierMaxPhysicalCapacityBytes { get; set; }

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
            return this.Equals(input as CapacityByTier);
        }

        /// <summary>
        /// Returns true if CapacityByTier instances are equal
        /// </summary>
        /// <param name="input">Instance of CapacityByTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityByTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorageTier == input.StorageTier ||
                    (this.StorageTier != null &&
                    this.StorageTier.Equals(input.StorageTier))
                ) && 
                (
                    this.TierMaxPhysicalCapacityBytes == input.TierMaxPhysicalCapacityBytes ||
                    (this.TierMaxPhysicalCapacityBytes != null &&
                    this.TierMaxPhysicalCapacityBytes.Equals(input.TierMaxPhysicalCapacityBytes))
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
                if (this.StorageTier != null)
                    hashCode = hashCode * 59 + this.StorageTier.GetHashCode();
                if (this.TierMaxPhysicalCapacityBytes != null)
                    hashCode = hashCode * 59 + this.TierMaxPhysicalCapacityBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

