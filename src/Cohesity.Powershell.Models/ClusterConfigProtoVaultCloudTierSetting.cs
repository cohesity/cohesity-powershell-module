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
    /// ClusterConfigProtoVaultCloudTierSetting
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudTierSetting :  IEquatable<ClusterConfigProtoVaultCloudTierSetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudTierSetting" /> class.
        /// </summary>
        /// <param name="tierInfoVec">Information about tiering/migrating the cloud snapshots..</param>
        public ClusterConfigProtoVaultCloudTierSetting(List<ClusterConfigProtoVaultCloudTierInfo> tierInfoVec = default(List<ClusterConfigProtoVaultCloudTierInfo>))
        {
            this.TierInfoVec = tierInfoVec;
            this.TierInfoVec = tierInfoVec;
        }
        
        /// <summary>
        /// Information about tiering/migrating the cloud snapshots.
        /// </summary>
        /// <value>Information about tiering/migrating the cloud snapshots.</value>
        [DataMember(Name="tierInfoVec", EmitDefaultValue=true)]
        public List<ClusterConfigProtoVaultCloudTierInfo> TierInfoVec { get; set; }

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
            return this.Equals(input as ClusterConfigProtoVaultCloudTierSetting);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudTierSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudTierSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudTierSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TierInfoVec == input.TierInfoVec ||
                    this.TierInfoVec != null &&
                    input.TierInfoVec != null &&
                    this.TierInfoVec.SequenceEqual(input.TierInfoVec)
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
                if (this.TierInfoVec != null)
                    hashCode = hashCode * 59 + this.TierInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

