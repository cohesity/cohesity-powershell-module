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
    /// Specifies statistics about the transfer of data from this Cohesity Cluster to a Vault.
    /// </summary>
    [DataContract]
    public partial class DataTransferToVaultSummary :  IEquatable<DataTransferToVaultSummary>
    {
        /// <summary>
        /// Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VaultTypeEnum
        {
            /// <summary>
            /// Enum KNearline for value: kNearline
            /// </summary>
            [EnumMember(Value = "kNearline")]
            KNearline = 1,

            /// <summary>
            /// Enum KGlacier for value: kGlacier
            /// </summary>
            [EnumMember(Value = "kGlacier")]
            KGlacier = 2,

            /// <summary>
            /// Enum KS3 for value: kS3
            /// </summary>
            [EnumMember(Value = "kS3")]
            KS3 = 3,

            /// <summary>
            /// Enum KAzureStandard for value: kAzureStandard
            /// </summary>
            [EnumMember(Value = "kAzureStandard")]
            KAzureStandard = 4,

            /// <summary>
            /// Enum KS3Compatible for value: kS3Compatible
            /// </summary>
            [EnumMember(Value = "kS3Compatible")]
            KS3Compatible = 5,

            /// <summary>
            /// Enum KQStarTape for value: kQStarTape
            /// </summary>
            [EnumMember(Value = "kQStarTape")]
            KQStarTape = 6,

            /// <summary>
            /// Enum KGoogleStandard for value: kGoogleStandard
            /// </summary>
            [EnumMember(Value = "kGoogleStandard")]
            KGoogleStandard = 7,

            /// <summary>
            /// Enum KGoogleDRA for value: kGoogleDRA
            /// </summary>
            [EnumMember(Value = "kGoogleDRA")]
            KGoogleDRA = 8,

            /// <summary>
            /// Enum KAmazonS3StandardIA for value: kAmazonS3StandardIA
            /// </summary>
            [EnumMember(Value = "kAmazonS3StandardIA")]
            KAmazonS3StandardIA = 9,

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
            /// Enum KColdline for value: kColdline
            /// </summary>
            [EnumMember(Value = "kColdline")]
            KColdline = 12,

            /// <summary>
            /// Enum KAzureGovCloud for value: kAzureGovCloud
            /// </summary>
            [EnumMember(Value = "kAzureGovCloud")]
            KAzureGovCloud = 13,

            /// <summary>
            /// Enum KAzureArchive for value: kAzureArchive
            /// </summary>
            [EnumMember(Value = "kAzureArchive")]
            KAzureArchive = 14,

            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 15,

            /// <summary>
            /// Enum KGoogle for value: kGoogle
            /// </summary>
            [EnumMember(Value = "kGoogle")]
            KGoogle = 16,

            /// <summary>
            /// Enum KAmazon for value: kAmazon
            /// </summary>
            [EnumMember(Value = "kAmazon")]
            KAmazon = 17,

            /// <summary>
            /// Enum KOracle for value: kOracle
            /// </summary>
            [EnumMember(Value = "kOracle")]
            KOracle = 18,

            /// <summary>
            /// Enum KOracleTierStandard for value: kOracleTierStandard
            /// </summary>
            [EnumMember(Value = "kOracleTierStandard")]
            KOracleTierStandard = 19,

            /// <summary>
            /// Enum KOracleTierArchive for value: kOracleTierArchive
            /// </summary>
            [EnumMember(Value = "kOracleTierArchive")]
            KOracleTierArchive = 20,

            /// <summary>
            /// Enum KAmazonC2S for value: kAmazonC2S
            /// </summary>
            [EnumMember(Value = "kAmazonC2S")]
            KAmazonC2S = 21

        }

        /// <summary>
        /// Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.</value>
        [DataMember(Name="vaultType", EmitDefaultValue=true)]
        public VaultTypeEnum? VaultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferToVaultSummary" /> class.
        /// </summary>
        /// <param name="dataTransferPerProtectionJob">Array of Data Transfer Statistics Per Protection Jobs.  Specifies the data transfer summary statistics for each Protection Job that is transferring data from this Cohesity Cluster to this Vault (External Target)..</param>
        /// <param name="logicalDataTransferredBytesDuringTimeRange">Array of Logical Data Transferred Per Day.  Specifies the logical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numLogicalBytesTransferred">Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numPhysicalBytesTransferred">Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault..</param>
        /// <param name="numProtectionJobs">Specifies the number of Protection Jobs that transfer data to this Vault..</param>
        /// <param name="physicalDataTransferredBytesDuringTimeRange">Array of Physical Data Transferred Per Day.  Specifies the physical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned..</param>
        /// <param name="storageConsumedBytes">Specifies the storage consumed on the Vault as of last day in the specified time range..</param>
        /// <param name="vaultId">The vault Id associated with the vault..</param>
        /// <param name="vaultName">Specifies the name of the Vault (External Target)..</param>
        /// <param name="vaultType">Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault..</param>
        public DataTransferToVaultSummary(List<DataTransferToVaultPerProtectionJob> dataTransferPerProtectionJob = default(List<DataTransferToVaultPerProtectionJob>), List<long> logicalDataTransferredBytesDuringTimeRange = default(List<long>), long? numLogicalBytesTransferred = default(long?), long? numPhysicalBytesTransferred = default(long?), long? numProtectionJobs = default(long?), List<long> physicalDataTransferredBytesDuringTimeRange = default(List<long>), long? storageConsumedBytes = default(long?), long? vaultId = default(long?), string vaultName = default(string), VaultTypeEnum? vaultType = default(VaultTypeEnum?))
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
        /// Array of Data Transfer Statistics Per Protection Jobs.  Specifies the data transfer summary statistics for each Protection Job that is transferring data from this Cohesity Cluster to this Vault (External Target).
        /// </summary>
        /// <value>Array of Data Transfer Statistics Per Protection Jobs.  Specifies the data transfer summary statistics for each Protection Job that is transferring data from this Cohesity Cluster to this Vault (External Target).</value>
        [DataMember(Name="dataTransferPerProtectionJob", EmitDefaultValue=true)]
        public List<DataTransferToVaultPerProtectionJob> DataTransferPerProtectionJob { get; set; }

        /// <summary>
        /// Array of Logical Data Transferred Per Day.  Specifies the logical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Array of Logical Data Transferred Per Day.  Specifies the logical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="logicalDataTransferredBytesDuringTimeRange", EmitDefaultValue=true)]
        public List<long> LogicalDataTransferredBytesDuringTimeRange { get; set; }

        /// <summary>
        /// Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="numLogicalBytesTransferred", EmitDefaultValue=true)]
        public long? NumLogicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault.
        /// </summary>
        /// <value>Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault.</value>
        [DataMember(Name="numPhysicalBytesTransferred", EmitDefaultValue=true)]
        public long? NumPhysicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the number of Protection Jobs that transfer data to this Vault.
        /// </summary>
        /// <value>Specifies the number of Protection Jobs that transfer data to this Vault.</value>
        [DataMember(Name="numProtectionJobs", EmitDefaultValue=true)]
        public long? NumProtectionJobs { get; set; }

        /// <summary>
        /// Array of Physical Data Transferred Per Day.  Specifies the physical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned.
        /// </summary>
        /// <value>Array of Physical Data Transferred Per Day.  Specifies the physical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned.</value>
        [DataMember(Name="physicalDataTransferredBytesDuringTimeRange", EmitDefaultValue=true)]
        public List<long> PhysicalDataTransferredBytesDuringTimeRange { get; set; }

        /// <summary>
        /// Specifies the storage consumed on the Vault as of last day in the specified time range.
        /// </summary>
        /// <value>Specifies the storage consumed on the Vault as of last day in the specified time range.</value>
        [DataMember(Name="storageConsumedBytes", EmitDefaultValue=true)]
        public long? StorageConsumedBytes { get; set; }

        /// <summary>
        /// The vault Id associated with the vault.
        /// </summary>
        /// <value>The vault Id associated with the vault.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Specifies the name of the Vault (External Target).
        /// </summary>
        /// <value>Specifies the name of the Vault (External Target).</value>
        [DataMember(Name="vaultName", EmitDefaultValue=true)]
        public string VaultName { get; set; }

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
                    input.DataTransferPerProtectionJob != null &&
                    this.DataTransferPerProtectionJob.SequenceEqual(input.DataTransferPerProtectionJob)
                ) && 
                (
                    this.LogicalDataTransferredBytesDuringTimeRange == input.LogicalDataTransferredBytesDuringTimeRange ||
                    this.LogicalDataTransferredBytesDuringTimeRange != null &&
                    input.LogicalDataTransferredBytesDuringTimeRange != null &&
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
                    input.PhysicalDataTransferredBytesDuringTimeRange != null &&
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
                    this.VaultType.Equals(input.VaultType)
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
                hashCode = hashCode * 59 + this.VaultType.GetHashCode();
                return hashCode;
            }
        }

    }

}

