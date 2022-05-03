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
    /// ClusterConfigProtoVaultCloudTierInfo
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudTierInfo :  IEquatable<ClusterConfigProtoVaultCloudTierInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudTierInfo" /> class.
        /// </summary>
        /// <param name="numSecsToMoveAfter">Represents the number of seconds since the snapshot first got archived (to default tier) after which it needs to be moved to the target tier. For example, if user selects target as an AWS vault (default: S3 tier) with 3 months retention, move to glacier after 1 month, and move to deep glacier after 2 months, then the below field should be set to appropriate number of seconds corresponding to 1 or 2 months by iris. The snapshot will reside in S3 (default tier) for 1 month, then 1 month in glacier tier, and then another 1 month in deep glacier before being deleted..</param>
        /// <param name="targetTierType">targetTierType.</param>
        public ClusterConfigProtoVaultCloudTierInfo(long? numSecsToMoveAfter = default(long?), ClusterConfigProtoVaultCloudTierType targetTierType = default(ClusterConfigProtoVaultCloudTierType))
        {
            this.NumSecsToMoveAfter = numSecsToMoveAfter;
            this.TargetTierType = targetTierType;
        }
        
        /// <summary>
        /// Represents the number of seconds since the snapshot first got archived (to default tier) after which it needs to be moved to the target tier. For example, if user selects target as an AWS vault (default: S3 tier) with 3 months retention, move to glacier after 1 month, and move to deep glacier after 2 months, then the below field should be set to appropriate number of seconds corresponding to 1 or 2 months by iris. The snapshot will reside in S3 (default tier) for 1 month, then 1 month in glacier tier, and then another 1 month in deep glacier before being deleted.
        /// </summary>
        /// <value>Represents the number of seconds since the snapshot first got archived (to default tier) after which it needs to be moved to the target tier. For example, if user selects target as an AWS vault (default: S3 tier) with 3 months retention, move to glacier after 1 month, and move to deep glacier after 2 months, then the below field should be set to appropriate number of seconds corresponding to 1 or 2 months by iris. The snapshot will reside in S3 (default tier) for 1 month, then 1 month in glacier tier, and then another 1 month in deep glacier before being deleted.</value>
        [DataMember(Name="numSecsToMoveAfter", EmitDefaultValue=false)]
        public long? NumSecsToMoveAfter { get; set; }

        /// <summary>
        /// Gets or Sets TargetTierType
        /// </summary>
        [DataMember(Name="targetTierType", EmitDefaultValue=false)]
        public ClusterConfigProtoVaultCloudTierType TargetTierType { get; set; }

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
            return this.Equals(input as ClusterConfigProtoVaultCloudTierInfo);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudTierInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudTierInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudTierInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumSecsToMoveAfter == input.NumSecsToMoveAfter ||
                    (this.NumSecsToMoveAfter != null &&
                    this.NumSecsToMoveAfter.Equals(input.NumSecsToMoveAfter))
                ) && 
                (
                    this.TargetTierType == input.TargetTierType ||
                    (this.TargetTierType != null &&
                    this.TargetTierType.Equals(input.TargetTierType))
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
                if (this.NumSecsToMoveAfter != null)
                    hashCode = hashCode * 59 + this.NumSecsToMoveAfter.GetHashCode();
                if (this.TargetTierType != null)
                    hashCode = hashCode * 59 + this.TargetTierType.GetHashCode();
                return hashCode;
            }
        }

    }

}

