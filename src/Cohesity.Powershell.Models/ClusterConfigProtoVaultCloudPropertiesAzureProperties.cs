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
    /// ClusterConfigProtoVaultCloudPropertiesAzureProperties
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudPropertiesAzureProperties :  IEquatable<ClusterConfigProtoVaultCloudPropertiesAzureProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudPropertiesAzureProperties" /> class.
        /// </summary>
        /// <param name="tierType">tierType.</param>
        public ClusterConfigProtoVaultCloudPropertiesAzureProperties(int? tierType = default(int?))
        {
            this.TierType = tierType;
        }
        
        /// <summary>
        /// Gets or Sets TierType
        /// </summary>
        [DataMember(Name="tierType", EmitDefaultValue=false)]
        public int? TierType { get; set; }

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
            return this.Equals(input as ClusterConfigProtoVaultCloudPropertiesAzureProperties);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudPropertiesAzureProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudPropertiesAzureProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudPropertiesAzureProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TierType == input.TierType ||
                    (this.TierType != null &&
                    this.TierType.Equals(input.TierType))
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
                if (this.TierType != null)
                    hashCode = hashCode * 59 + this.TierType.GetHashCode();
                return hashCode;
            }
        }

    }

}

