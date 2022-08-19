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
    /// ClusterConfigProtoVaultCloudTierType
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudTierType :  IEquatable<ClusterConfigProtoVaultCloudTierType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudTierType" /> class.
        /// </summary>
        /// <param name="cloudProperties">cloudProperties.</param>
        /// <param name="cloudType">Field representing the cloud type. Currently tiers are supported for kAzure, kGoogle, kAmazon, kOracle..</param>
        public ClusterConfigProtoVaultCloudTierType(ClusterConfigProtoVaultCloudProperties cloudProperties = default(ClusterConfigProtoVaultCloudProperties), int? cloudType = default(int?))
        {
            this.CloudType = cloudType;
            this.CloudProperties = cloudProperties;
            this.CloudType = cloudType;
        }
        
        /// <summary>
        /// Gets or Sets CloudProperties
        /// </summary>
        [DataMember(Name="cloudProperties", EmitDefaultValue=false)]
        public ClusterConfigProtoVaultCloudProperties CloudProperties { get; set; }

        /// <summary>
        /// Field representing the cloud type. Currently tiers are supported for kAzure, kGoogle, kAmazon, kOracle.
        /// </summary>
        /// <value>Field representing the cloud type. Currently tiers are supported for kAzure, kGoogle, kAmazon, kOracle.</value>
        [DataMember(Name="cloudType", EmitDefaultValue=true)]
        public int? CloudType { get; set; }

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
            return this.Equals(input as ClusterConfigProtoVaultCloudTierType);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudTierType instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudTierType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudTierType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudProperties == input.CloudProperties ||
                    (this.CloudProperties != null &&
                    this.CloudProperties.Equals(input.CloudProperties))
                ) && 
                (
                    this.CloudType == input.CloudType ||
                    (this.CloudType != null &&
                    this.CloudType.Equals(input.CloudType))
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
                if (this.CloudProperties != null)
                    hashCode = hashCode * 59 + this.CloudProperties.GetHashCode();
                if (this.CloudType != null)
                    hashCode = hashCode * 59 + this.CloudType.GetHashCode();
                return hashCode;
            }
        }

    }

}

