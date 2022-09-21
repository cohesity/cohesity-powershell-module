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
    /// Specifies the storage usage on vaults.
    /// </summary>
    [DataContract]
    public partial class VaultStats :  IEquatable<VaultStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultStats" /> class.
        /// </summary>
        /// <param name="awsUsageBytes">Specifies the usage on AWS vaults..</param>
        /// <param name="azureUsageBytes">Specifies the usage on Azure vaults..</param>
        /// <param name="gcpUsageBytes">Specifies the usage on GCP vaults..</param>
        /// <param name="nasUsageBytes">Specifies the usage on NAS vaults..</param>
        /// <param name="oracleUsageBytes">Specifies the usage on Oracle vaults..</param>
        /// <param name="qstarUsageBytes">Specifies the usage on QStar Tape vaults..</param>
        /// <param name="s3cUsageBytes">Specifies the usage on S3 Compatible vaults..</param>
        /// <param name="vaultStatsList">Specifies the stats of all vaults on the cluster..</param>
        public VaultStats(long? awsUsageBytes = default(long?), long? azureUsageBytes = default(long?), long? gcpUsageBytes = default(long?), long? nasUsageBytes = default(long?), long? oracleUsageBytes = default(long?), long? qstarUsageBytes = default(long?), long? s3cUsageBytes = default(long?), List<VaultStatsInfo> vaultStatsList = default(List<VaultStatsInfo>))
        {
            this.AwsUsageBytes = awsUsageBytes;
            this.AzureUsageBytes = azureUsageBytes;
            this.GcpUsageBytes = gcpUsageBytes;
            this.NasUsageBytes = nasUsageBytes;
            this.OracleUsageBytes = oracleUsageBytes;
            this.QstarUsageBytes = qstarUsageBytes;
            this.S3cUsageBytes = s3cUsageBytes;
            this.AwsUsageBytes = awsUsageBytes;
            this.AzureUsageBytes = azureUsageBytes;
            this.GcpUsageBytes = gcpUsageBytes;
            this.NasUsageBytes = nasUsageBytes;
            this.OracleUsageBytes = oracleUsageBytes;
            this.QstarUsageBytes = qstarUsageBytes;
            this.S3cUsageBytes = s3cUsageBytes;
            this.VaultStatsList = vaultStatsList;
        }
        
        /// <summary>
        /// Specifies the usage on AWS vaults.
        /// </summary>
        /// <value>Specifies the usage on AWS vaults.</value>
        [DataMember(Name="awsUsageBytes", EmitDefaultValue=true)]
        public long? AwsUsageBytes { get; set; }

        /// <summary>
        /// Specifies the usage on Azure vaults.
        /// </summary>
        /// <value>Specifies the usage on Azure vaults.</value>
        [DataMember(Name="azureUsageBytes", EmitDefaultValue=true)]
        public long? AzureUsageBytes { get; set; }

        /// <summary>
        /// Specifies the usage on GCP vaults.
        /// </summary>
        /// <value>Specifies the usage on GCP vaults.</value>
        [DataMember(Name="gcpUsageBytes", EmitDefaultValue=true)]
        public long? GcpUsageBytes { get; set; }

        /// <summary>
        /// Specifies the usage on NAS vaults.
        /// </summary>
        /// <value>Specifies the usage on NAS vaults.</value>
        [DataMember(Name="nasUsageBytes", EmitDefaultValue=true)]
        public long? NasUsageBytes { get; set; }

        /// <summary>
        /// Specifies the usage on Oracle vaults.
        /// </summary>
        /// <value>Specifies the usage on Oracle vaults.</value>
        [DataMember(Name="oracleUsageBytes", EmitDefaultValue=true)]
        public long? OracleUsageBytes { get; set; }

        /// <summary>
        /// Specifies the usage on QStar Tape vaults.
        /// </summary>
        /// <value>Specifies the usage on QStar Tape vaults.</value>
        [DataMember(Name="qstarUsageBytes", EmitDefaultValue=true)]
        public long? QstarUsageBytes { get; set; }

        /// <summary>
        /// Specifies the usage on S3 Compatible vaults.
        /// </summary>
        /// <value>Specifies the usage on S3 Compatible vaults.</value>
        [DataMember(Name="s3cUsageBytes", EmitDefaultValue=true)]
        public long? S3cUsageBytes { get; set; }

        /// <summary>
        /// Specifies the stats of all vaults on the cluster.
        /// </summary>
        /// <value>Specifies the stats of all vaults on the cluster.</value>
        [DataMember(Name="vaultStatsList", EmitDefaultValue=false)]
        public List<VaultStatsInfo> VaultStatsList { get; set; }

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
            return this.Equals(input as VaultStats);
        }

        /// <summary>
        /// Returns true if VaultStats instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsUsageBytes == input.AwsUsageBytes ||
                    (this.AwsUsageBytes != null &&
                    this.AwsUsageBytes.Equals(input.AwsUsageBytes))
                ) && 
                (
                    this.AzureUsageBytes == input.AzureUsageBytes ||
                    (this.AzureUsageBytes != null &&
                    this.AzureUsageBytes.Equals(input.AzureUsageBytes))
                ) && 
                (
                    this.GcpUsageBytes == input.GcpUsageBytes ||
                    (this.GcpUsageBytes != null &&
                    this.GcpUsageBytes.Equals(input.GcpUsageBytes))
                ) && 
                (
                    this.NasUsageBytes == input.NasUsageBytes ||
                    (this.NasUsageBytes != null &&
                    this.NasUsageBytes.Equals(input.NasUsageBytes))
                ) && 
                (
                    this.OracleUsageBytes == input.OracleUsageBytes ||
                    (this.OracleUsageBytes != null &&
                    this.OracleUsageBytes.Equals(input.OracleUsageBytes))
                ) && 
                (
                    this.QstarUsageBytes == input.QstarUsageBytes ||
                    (this.QstarUsageBytes != null &&
                    this.QstarUsageBytes.Equals(input.QstarUsageBytes))
                ) && 
                (
                    this.S3cUsageBytes == input.S3cUsageBytes ||
                    (this.S3cUsageBytes != null &&
                    this.S3cUsageBytes.Equals(input.S3cUsageBytes))
                ) && 
                (
                    this.VaultStatsList == input.VaultStatsList ||
                    this.VaultStatsList != null &&
                    input.VaultStatsList != null &&
                    this.VaultStatsList.Equals(input.VaultStatsList)
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
                if (this.AwsUsageBytes != null)
                    hashCode = hashCode * 59 + this.AwsUsageBytes.GetHashCode();
                if (this.AzureUsageBytes != null)
                    hashCode = hashCode * 59 + this.AzureUsageBytes.GetHashCode();
                if (this.GcpUsageBytes != null)
                    hashCode = hashCode * 59 + this.GcpUsageBytes.GetHashCode();
                if (this.NasUsageBytes != null)
                    hashCode = hashCode * 59 + this.NasUsageBytes.GetHashCode();
                if (this.OracleUsageBytes != null)
                    hashCode = hashCode * 59 + this.OracleUsageBytes.GetHashCode();
                if (this.QstarUsageBytes != null)
                    hashCode = hashCode * 59 + this.QstarUsageBytes.GetHashCode();
                if (this.S3cUsageBytes != null)
                    hashCode = hashCode * 59 + this.S3cUsageBytes.GetHashCode();
                if (this.VaultStatsList != null)
                    hashCode = hashCode * 59 + this.VaultStatsList.GetHashCode();
                return hashCode;
            }
        }

    }

}

