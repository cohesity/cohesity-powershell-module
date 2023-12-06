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
    /// ClusterConfigProtoVaultCloudPropertiesOracleProperties
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudPropertiesOracleProperties :  IEquatable<ClusterConfigProtoVaultCloudPropertiesOracleProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudPropertiesOracleProperties" /> class.
        /// </summary>
        /// <param name="tenant">Tenant part of the REST endpoints for Oracle S3 compatible vaults..</param>
        /// <param name="tierType">tierType.</param>
        public ClusterConfigProtoVaultCloudPropertiesOracleProperties(string tenant = default(string), int? tierType = default(int?))
        {
            this.Tenant = tenant;
            this.TierType = tierType;
            this.Tenant = tenant;
            this.TierType = tierType;
        }
        
        /// <summary>
        /// Tenant part of the REST endpoints for Oracle S3 compatible vaults.
        /// </summary>
        /// <value>Tenant part of the REST endpoints for Oracle S3 compatible vaults.</value>
        [DataMember(Name="tenant", EmitDefaultValue=true)]
        public string Tenant { get; set; }

        /// <summary>
        /// Gets or Sets TierType
        /// </summary>
        [DataMember(Name="tierType", EmitDefaultValue=true)]
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
            return this.Equals(input as ClusterConfigProtoVaultCloudPropertiesOracleProperties);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudPropertiesOracleProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudPropertiesOracleProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudPropertiesOracleProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
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
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.TierType != null)
                    hashCode = hashCode * 59 + this.TierType.GetHashCode();
                return hashCode;
            }
        }

    }

}

