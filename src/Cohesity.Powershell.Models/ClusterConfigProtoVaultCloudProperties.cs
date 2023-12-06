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
    /// The following represents the cloud properties proto which handles different properties supported by different cloud providers.
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudProperties :  IEquatable<ClusterConfigProtoVaultCloudProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudProperties" /> class.
        /// </summary>
        /// <param name="amazonProperties">amazonProperties.</param>
        /// <param name="azureProperties">azureProperties.</param>
        /// <param name="googleProperties">googleProperties.</param>
        /// <param name="oracleProperties">oracleProperties.</param>
        public ClusterConfigProtoVaultCloudProperties(ClusterConfigProtoVaultCloudPropertiesAmazonProperties amazonProperties = default(ClusterConfigProtoVaultCloudPropertiesAmazonProperties), ClusterConfigProtoVaultCloudPropertiesAzureProperties azureProperties = default(ClusterConfigProtoVaultCloudPropertiesAzureProperties), ClusterConfigProtoVaultCloudPropertiesGoogleProperties googleProperties = default(ClusterConfigProtoVaultCloudPropertiesGoogleProperties), ClusterConfigProtoVaultCloudPropertiesOracleProperties oracleProperties = default(ClusterConfigProtoVaultCloudPropertiesOracleProperties))
        {
            this.AmazonProperties = amazonProperties;
            this.AzureProperties = azureProperties;
            this.GoogleProperties = googleProperties;
            this.OracleProperties = oracleProperties;
        }
        
        /// <summary>
        /// Gets or Sets AmazonProperties
        /// </summary>
        [DataMember(Name="amazonProperties", EmitDefaultValue=false)]
        public ClusterConfigProtoVaultCloudPropertiesAmazonProperties AmazonProperties { get; set; }

        /// <summary>
        /// Gets or Sets AzureProperties
        /// </summary>
        [DataMember(Name="azureProperties", EmitDefaultValue=false)]
        public ClusterConfigProtoVaultCloudPropertiesAzureProperties AzureProperties { get; set; }

        /// <summary>
        /// Gets or Sets GoogleProperties
        /// </summary>
        [DataMember(Name="googleProperties", EmitDefaultValue=false)]
        public ClusterConfigProtoVaultCloudPropertiesGoogleProperties GoogleProperties { get; set; }

        /// <summary>
        /// Gets or Sets OracleProperties
        /// </summary>
        [DataMember(Name="oracleProperties", EmitDefaultValue=false)]
        public ClusterConfigProtoVaultCloudPropertiesOracleProperties OracleProperties { get; set; }

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
            return this.Equals(input as ClusterConfigProtoVaultCloudProperties);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmazonProperties == input.AmazonProperties ||
                    (this.AmazonProperties != null &&
                    this.AmazonProperties.Equals(input.AmazonProperties))
                ) && 
                (
                    this.AzureProperties == input.AzureProperties ||
                    (this.AzureProperties != null &&
                    this.AzureProperties.Equals(input.AzureProperties))
                ) && 
                (
                    this.GoogleProperties == input.GoogleProperties ||
                    (this.GoogleProperties != null &&
                    this.GoogleProperties.Equals(input.GoogleProperties))
                ) && 
                (
                    this.OracleProperties == input.OracleProperties ||
                    (this.OracleProperties != null &&
                    this.OracleProperties.Equals(input.OracleProperties))
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
                if (this.AmazonProperties != null)
                    hashCode = hashCode * 59 + this.AmazonProperties.GetHashCode();
                if (this.AzureProperties != null)
                    hashCode = hashCode * 59 + this.AzureProperties.GetHashCode();
                if (this.GoogleProperties != null)
                    hashCode = hashCode * 59 + this.GoogleProperties.GetHashCode();
                if (this.OracleProperties != null)
                    hashCode = hashCode * 59 + this.OracleProperties.GetHashCode();
                return hashCode;
            }
        }

    }

}

