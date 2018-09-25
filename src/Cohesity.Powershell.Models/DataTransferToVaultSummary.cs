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
    /// Specifies statistics about the transfer of data from this Cohesity Cluster to a Vault.
    /// </summary>
    [DataContract]
    public partial class DataTransferToVaultSummary :  IEquatable<DataTransferToVaultSummary>
    {
        /// <summary>
        /// Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VaultTypeEnum
        {
            
            /// <summary>
            /// Enum KNearline for value: kNearline
            /// </summary>
            [EnumMember(Value = "kNearline")]
            KNearline = 1,
            
            /// <summary>
            /// Enum KColdline for value: kColdline
            /// </summary>
            [EnumMember(Value = "kColdline")]
            KColdline = 2,
            
            /// <summary>
            /// Enum KGlacier for value: kGlacier
            /// </summary>
            [EnumMember(Value = "kGlacier")]
            KGlacier = 3,
            
            /// <summary>
            /// Enum KS3 for value: kS3
            /// </summary>
            [EnumMember(Value = "kS3")]
            KS3 = 4,
            
            /// <summary>
            /// Enum KAzureStandard for value: kAzureStandard
            /// </summary>
            [EnumMember(Value = "kAzureStandard")]
            KAzureStandard = 5,
            
            /// <summary>
            /// Enum KS3Compatible for value: kS3Compatible
            /// </summary>
            [EnumMember(Value = "kS3Compatible")]
            KS3Compatible = 6,
            
            /// <summary>
            /// Enum KQStarTape for value: kQStarTape
            /// </summary>
            [EnumMember(Value = "kQStarTape")]
            KQStarTape = 7,
            
            /// <summary>
            /// Enum KGoogleStandard for value: kGoogleStandard
            /// </summary>
            [EnumMember(Value = "kGoogleStandard")]
            KGoogleStandard = 8,
            
            /// <summary>
            /// Enum KGoogleDRA for value: kGoogleDRA
            /// </summary>
            [EnumMember(Value = "kGoogleDRA")]
            KGoogleDRA = 9,
            
            /// <summary>
            /// Enum KAWSGovCloud for value: kAWSGovCloud
            /// </summary>
            [EnumMember(Value = "kAWSGovCloud")]
            KAWSGovCloud = 10,
            
            /// <summary>
            /// Enum KNAS for value: kNAS
            /// </summary>
            [EnumMember(Value = "kNAS")]
            KNAS = 11,
            
            /// <summary>
            /// Enum KAzureGovCloud for value: kAzureGovCloud
            /// </summary>
            [EnumMember(Value = "kAzureGovCloud")]
            KAzureGovCloud = 12
        }

        /// <summary>
        /// Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.</value>
        [DataMember(Name="vaultType", EmitDefaultValue=false)]
        public VaultTypeEnum? VaultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferToVaultSummary" /> class.
        /// </summary>
        /// <param name="dataTransferPerProtectionJob">Specifies the data transfer summary statistics for each Protection Job that is transferring data from this Cohesity Cluster to this Vault (External Target)..</param>
        /// <param name="logicalDataTransferredBytesDuringTimeRange">Specifies the logical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numLogicalBytesTransferred">Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numPhysicalBytesTransferred">Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault..</param>
        /// <param name="numProtectionJobs">Specifies the number of Protection Jobs that transfer data to this Vault..</param>
        /// <param name="physicalDataTransferredBytesDuringTimeRange">Specifies the physical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned..</param>
        /// <param name="storageConsumedBytes">Specifies the storage consumed on the Vault as of last day in the specified time range..</param>
        /// <param name="vaultId">The vault Id associated with the vault..</param>
        /// <param name="vaultName">Specifies the name of the Vault (External Target)..</param>
        /// <param name="vaultType">Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault..</param>
        public DataTransferToVaultSummary(List<DataTransferToVaultPerProtectionJob> dataTransferPerProtectionJob = default(List<DataTransferToVaultPerProtectionJob>), List<long?> logicalDataTransferredBytesDuringTimeRange = default(List<long?>), long? numLogicalBytesTransferred = default(long?), long? numPhysicalBytesTransferred = default(long?), long? numProtectionJobs = default(long?), List<long?> physicalDataTransferredBytesDuringTimeRange = default(List<long?>), long? storageConsumedBytes = default(long?), long? vaultId = default(long?), string vaultName = default(string), VaultTypeEnum? vaultType = default(VaultTypeEnum?))
        {
            this.DataTransferPerProtectionJob = dataTransferPerProtectionJob;
            this.LogicalDataTransferredBytesDuringTimeRange = logicalDataTransferredBytesDuringTimeRange;
            this.NumLogicalBytesTransferred = numLogicalBytesTransferred;
            this.NumPhysicalBytesTransferred = numPhysicalBytesTransferred;
            this.NumProtectionJobs = numProtectionJobs;
            this.PhysicalDataTransferredBytesDuringTimeRange = physicalDataTransferredBytesDuringTimeRange;
            this.StorageConsumedBytes = storageConsumedBytes;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
            this.VaultType = vaultType;
        }
        
        /// <summary>
        /// Specifies the data transfer summary statistics for each Protection Job that is transferring data from this Cohesity Cluster to this Vault (External Target).
        /// </summary>
        /// <value>Specifies the data transfer summary statistics for each Protection Job that is transferring data from this Cohesity Cluster to this Vault (External Target).</value>
        [DataMember(Name="dataTransferPerProtectionJob", EmitDefaultValue=false)]
        public List<DataTransferToVaultPerProtectionJob> DataTransferPerProtectionJob { get; set; }

        /// <summary>
        /// Specifies the logical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the logical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="logicalDataTransferredBytesDuringTimeRange", EmitDefaultValue=false)]
        public List<long?> LogicalDataTransferredBytesDuringTimeRange { get; set; }

        /// <summary>
        /// Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="numLogicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumLogicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault.
        /// </summary>
        /// <value>Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault.</value>
        [DataMember(Name="numPhysicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumPhysicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the number of Protection Jobs that transfer data to this Vault.
        /// </summary>
        /// <value>Specifies the number of Protection Jobs that transfer data to this Vault.</value>
        [DataMember(Name="numProtectionJobs", EmitDefaultValue=false)]
        public long? NumProtectionJobs { get; set; }

        /// <summary>
        /// Specifies the physical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned.
        /// </summary>
        /// <value>Specifies the physical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned.</value>
        [DataMember(Name="physicalDataTransferredBytesDuringTimeRange", EmitDefaultValue=false)]
        public List<long?> PhysicalDataTransferredBytesDuringTimeRange { get; set; }

        /// <summary>
        /// Specifies the storage consumed on the Vault as of last day in the specified time range.
        /// </summary>
        /// <value>Specifies the storage consumed on the Vault as of last day in the specified time range.</value>
        [DataMember(Name="storageConsumedBytes", EmitDefaultValue=false)]
        public long? StorageConsumedBytes { get; set; }

        /// <summary>
        /// The vault Id associated with the vault.
        /// </summary>
        /// <value>The vault Id associated with the vault.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Specifies the name of the Vault (External Target).
        /// </summary>
        /// <value>Specifies the name of the Vault (External Target).</value>
        [DataMember(Name="vaultName", EmitDefaultValue=false)]
        public string VaultName { get; set; }


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
            return this.Equals(input as DataTransferToVaultSummary);
        }

        /// <summary>
        /// Returns true if DataTransferToVaultSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferToVaultSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferToVaultSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataTransferPerProtectionJob == input.DataTransferPerProtectionJob ||
                    this.DataTransferPerProtectionJob != null &&
                    this.DataTransferPerProtectionJob.SequenceEqual(input.DataTransferPerProtectionJob)
                ) && 
                (
                    this.LogicalDataTransferredBytesDuringTimeRange == input.LogicalDataTransferredBytesDuringTimeRange ||
                    this.LogicalDataTransferredBytesDuringTimeRange != null &&
                    this.LogicalDataTransferredBytesDuringTimeRange.SequenceEqual(input.LogicalDataTransferredBytesDuringTimeRange)
                ) && 
                (
                    this.NumLogicalBytesTransferred == input.NumLogicalBytesTransferred ||
                    (this.NumLogicalBytesTransferred != null &&
                    this.NumLogicalBytesTransferred.Equals(input.NumLogicalBytesTransferred))
                ) && 
                (
                    this.NumPhysicalBytesTransferred == input.NumPhysicalBytesTransferred ||
                    (this.NumPhysicalBytesTransferred != null &&
                    this.NumPhysicalBytesTransferred.Equals(input.NumPhysicalBytesTransferred))
                ) && 
                (
                    this.NumProtectionJobs == input.NumProtectionJobs ||
                    (this.NumProtectionJobs != null &&
                    this.NumProtectionJobs.Equals(input.NumProtectionJobs))
                ) && 
                (
                    this.PhysicalDataTransferredBytesDuringTimeRange == input.PhysicalDataTransferredBytesDuringTimeRange ||
                    this.PhysicalDataTransferredBytesDuringTimeRange != null &&
                    this.PhysicalDataTransferredBytesDuringTimeRange.SequenceEqual(input.PhysicalDataTransferredBytesDuringTimeRange)
                ) && 
                (
                    this.StorageConsumedBytes == input.StorageConsumedBytes ||
                    (this.StorageConsumedBytes != null &&
                    this.StorageConsumedBytes.Equals(input.StorageConsumedBytes))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
                ) && 
                (
                    this.VaultType == input.VaultType ||
                    (this.VaultType != null &&
                    this.VaultType.Equals(input.VaultType))
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
                if (this.DataTransferPerProtectionJob != null)
                    hashCode = hashCode * 59 + this.DataTransferPerProtectionJob.GetHashCode();
                if (this.LogicalDataTransferredBytesDuringTimeRange != null)
                    hashCode = hashCode * 59 + this.LogicalDataTransferredBytesDuringTimeRange.GetHashCode();
                if (this.NumLogicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.NumLogicalBytesTransferred.GetHashCode();
                if (this.NumPhysicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.NumPhysicalBytesTransferred.GetHashCode();
                if (this.NumProtectionJobs != null)
                    hashCode = hashCode * 59 + this.NumProtectionJobs.GetHashCode();
                if (this.PhysicalDataTransferredBytesDuringTimeRange != null)
                    hashCode = hashCode * 59 + this.PhysicalDataTransferredBytesDuringTimeRange.GetHashCode();
                if (this.StorageConsumedBytes != null)
                    hashCode = hashCode * 59 + this.StorageConsumedBytes.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                if (this.VaultType != null)
                    hashCode = hashCode * 59 + this.VaultType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

