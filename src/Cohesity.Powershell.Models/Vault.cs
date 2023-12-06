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
    /// Specifies an external storage location and is equivalent to an External Target in the Cohesity Dashboard. A Vault can provide an additional Cloud Tier where cold data of the Cohesity Cluster can be stored in the Cloud. A Vault can also provide archive storage for backup data. This archive data is stored on Tapes and in Cloud Vaults.
    /// </summary>
    [DataContract]
    public partial class Vault :  IEquatable<Vault>
    {
        /// <summary>
        /// Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.
        /// </summary>
        /// <value>Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionPolicyEnum
        {
            /// <summary>
            /// Enum KCompressionNone for value: kCompressionNone
            /// </summary>
            [EnumMember(Value = "kCompressionNone")]
            KCompressionNone = 1,

            /// <summary>
            /// Enum KCompressionLow for value: kCompressionLow
            /// </summary>
            [EnumMember(Value = "kCompressionLow")]
            KCompressionLow = 2,

            /// <summary>
            /// Enum KCompressionHigh for value: kCompressionHigh
            /// </summary>
            [EnumMember(Value = "kCompressionHigh")]
            KCompressionHigh = 3

        }

        /// <summary>
        /// Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.
        /// </summary>
        /// <value>Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.</value>
        [DataMember(Name="compressionPolicy", EmitDefaultValue=true)]
        public CompressionPolicyEnum? CompressionPolicy { get; set; }
        /// <summary>
        /// Desired location for write ahead logs(wal). &#39;kHomePartition&#39; indicates desired wal location to be the home partition. &#39;kDisk&#39; indicates desired wal location to be the same disk as chunk repo. &#39;kScribe&#39; indicates desired wal location to be scribe. &#39;kScribeTable&#39; indicates chunk repository state is kept as key-value pairs in scribe.
        /// </summary>
        /// <value>Desired location for write ahead logs(wal). &#39;kHomePartition&#39; indicates desired wal location to be the home partition. &#39;kDisk&#39; indicates desired wal location to be the same disk as chunk repo. &#39;kScribe&#39; indicates desired wal location to be scribe. &#39;kScribeTable&#39; indicates chunk repository state is kept as key-value pairs in scribe.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DesiredWalLocationEnum
        {
            /// <summary>
            /// Enum KHomePartition for value: kHomePartition
            /// </summary>
            [EnumMember(Value = "kHomePartition")]
            KHomePartition = 1,

            /// <summary>
            /// Enum KDisk for value: kDisk
            /// </summary>
            [EnumMember(Value = "kDisk")]
            KDisk = 2,

            /// <summary>
            /// Enum KScribe for value: kScribe
            /// </summary>
            [EnumMember(Value = "kScribe")]
            KScribe = 3,

            /// <summary>
            /// Enum KScribeTable for value: kScribeTable
            /// </summary>
            [EnumMember(Value = "kScribeTable")]
            KScribeTable = 4

        }

        /// <summary>
        /// Desired location for write ahead logs(wal). &#39;kHomePartition&#39; indicates desired wal location to be the home partition. &#39;kDisk&#39; indicates desired wal location to be the same disk as chunk repo. &#39;kScribe&#39; indicates desired wal location to be scribe. &#39;kScribeTable&#39; indicates chunk repository state is kept as key-value pairs in scribe.
        /// </summary>
        /// <value>Desired location for write ahead logs(wal). &#39;kHomePartition&#39; indicates desired wal location to be the home partition. &#39;kDisk&#39; indicates desired wal location to be the same disk as chunk repo. &#39;kScribe&#39; indicates desired wal location to be scribe. &#39;kScribeTable&#39; indicates chunk repository state is kept as key-value pairs in scribe.</value>
        [DataMember(Name="desiredWalLocation", EmitDefaultValue=true)]
        public DesiredWalLocationEnum? DesiredWalLocation { get; set; }
        /// <summary>
        /// Specifies whether to send and store data in an encrypted format. &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.
        /// </summary>
        /// <value>Specifies whether to send and store data in an encrypted format. &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionPolicyEnum
        {
            /// <summary>
            /// Enum KEncryptionNone for value: kEncryptionNone
            /// </summary>
            [EnumMember(Value = "kEncryptionNone")]
            KEncryptionNone = 1,

            /// <summary>
            /// Enum KEncryptionStrong for value: kEncryptionStrong
            /// </summary>
            [EnumMember(Value = "kEncryptionStrong")]
            KEncryptionStrong = 2,

            /// <summary>
            /// Enum KEncryptionWeak for value: kEncryptionWeak
            /// </summary>
            [EnumMember(Value = "kEncryptionWeak")]
            KEncryptionWeak = 3

        }

        /// <summary>
        /// Specifies whether to send and store data in an encrypted format. &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.
        /// </summary>
        /// <value>Specifies whether to send and store data in an encrypted format. &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.</value>
        [DataMember(Name="encryptionPolicy", EmitDefaultValue=true)]
        public EncryptionPolicyEnum? EncryptionPolicy { get; set; }
        /// <summary>
        /// Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExternalTargetTypeEnum
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
        [DataMember(Name="externalTargetType", EmitDefaultValue=true)]
        public ExternalTargetTypeEnum? ExternalTargetType { get; set; }
        /// <summary>
        /// Specifies the state of the vault to be removed. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the state of the vault to be removed. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemovalStateEnum
        {
            /// <summary>
            /// Enum KDontRemove for value: kDontRemove
            /// </summary>
            [EnumMember(Value = "kDontRemove")]
            KDontRemove = 1,

            /// <summary>
            /// Enum KMarkedForRemoval for value: kMarkedForRemoval
            /// </summary>
            [EnumMember(Value = "kMarkedForRemoval")]
            KMarkedForRemoval = 2,

            /// <summary>
            /// Enum KOkToRemove for value: kOkToRemove
            /// </summary>
            [EnumMember(Value = "kOkToRemove")]
            KOkToRemove = 3

        }

        /// <summary>
        /// Specifies the state of the vault to be removed. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the state of the vault to be removed. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [DataMember(Name="removalState", EmitDefaultValue=true)]
        public RemovalStateEnum? RemovalState { get; set; }
        /// <summary>
        /// Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
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
        /// Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data. &#39;kRpaasArchival&#39; indicates the Vault is for RPaaS.
        /// </summary>
        /// <value>Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data. &#39;kRpaasArchival&#39; indicates the Vault is for RPaaS.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UsageTypeEnum
        {
            /// <summary>
            /// Enum KArchival for value: kArchival
            /// </summary>
            [EnumMember(Value = "kArchival")]
            KArchival = 1,

            /// <summary>
            /// Enum KCloudSpill for value: kCloudSpill
            /// </summary>
            [EnumMember(Value = "kCloudSpill")]
            KCloudSpill = 2

        }

        /// <summary>
        /// Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data. &#39;kRpaasArchival&#39; indicates the Vault is for RPaaS.
        /// </summary>
        /// <value>Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data. &#39;kRpaasArchival&#39; indicates the Vault is for RPaaS.</value>
        [DataMember(Name="usageType", EmitDefaultValue=true)]
        public UsageTypeEnum? UsageType { get; set; }
        /// <summary>
        /// Specifies the ownership context for consumption. &#39;kOwnershipContextLocal&#39; indicates the Vault is used for local consumption &#39;kOwnershipContextFortKnox&#39; indicates the Vault is used for Fortknox consumption
        /// </summary>
        /// <value>Specifies the ownership context for consumption. &#39;kOwnershipContextLocal&#39; indicates the Vault is used for local consumption &#39;kOwnershipContextFortKnox&#39; indicates the Vault is used for Fortknox consumption</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VaultOwnershipEnum
        {
            /// <summary>
            /// Enum KOwnershipContextLocal for value: kOwnershipContextLocal
            /// </summary>
            [EnumMember(Value = "kOwnershipContextLocal")]
            KOwnershipContextLocal = 1,

            /// <summary>
            /// Enum KOwnershipContextFortKnox for value: kOwnershipContextFortKnox
            /// </summary>
            [EnumMember(Value = "kOwnershipContextFortKnox")]
            KOwnershipContextFortKnox = 2

        }

        /// <summary>
        /// Specifies the ownership context for consumption. &#39;kOwnershipContextLocal&#39; indicates the Vault is used for local consumption &#39;kOwnershipContextFortKnox&#39; indicates the Vault is used for Fortknox consumption
        /// </summary>
        /// <value>Specifies the ownership context for consumption. &#39;kOwnershipContextLocal&#39; indicates the Vault is used for local consumption &#39;kOwnershipContextFortKnox&#39; indicates the Vault is used for Fortknox consumption</value>
        [DataMember(Name="vaultOwnership", EmitDefaultValue=true)]
        public VaultOwnershipEnum? VaultOwnership { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Vault" /> class.
        /// </summary>
        /// <param name="caTrustedCertificate">Specifies the CA (certificate authority) trusted certificate..</param>
        /// <param name="clientCertificate">Specifies the client CA  certificate. This certificate is in pem format..</param>
        /// <param name="clientPrivateKey">Specifies the client private key. This certificate is in pem format..</param>
        /// <param name="cloudArchivalDirectConfig">cloudArchivalDirectConfig.</param>
        /// <param name="cloudDomainList">Specifies the cloud domain information..</param>
        /// <param name="compressionPolicy">Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip..</param>
        /// <param name="config">config.</param>
        /// <param name="customerManagingEncryptionKeys">Specifies whether to manage the encryption key manually or let the Cohesity Cluster manage it. If true, you must get the encryption key store it outside the Cluster, before disaster strikes such as the source local Cohesity Cluster being down. You can get the encryption key by downloading it using the Cohesity Dashboard or by calling the GET /public/vaults/encryptionKey/{id} operation..</param>
        /// <param name="dedupEnabled">Specifies whether to deduplicate data before sending it to the Vault..</param>
        /// <param name="dekRotationEnabled">Specifies whether DEK(Data Encryption Key) rotation is enabled for this vault. This is applicable only when the viewbox uses AWS or similar KMS in which the KEK (Key Encryption Key) is not created and maintained by Cohesity. For Internal KMS and keys stored in Safenet servers, DEK rotation will not be performed..</param>
        /// <param name="deleteVaultError">Specifies the error message when deleting a vault..</param>
        /// <param name="description">Specifies a description about the Vault..</param>
        /// <param name="desiredWalLocation">Desired location for write ahead logs(wal). &#39;kHomePartition&#39; indicates desired wal location to be the home partition. &#39;kDisk&#39; indicates desired wal location to be the same disk as chunk repo. &#39;kScribe&#39; indicates desired wal location to be scribe. &#39;kScribeTable&#39; indicates chunk repository state is kept as key-value pairs in scribe..</param>
        /// <param name="encryptionKeyFileDownloaded">Specifies if the encryption key file has been downloaded using the Cohesity Dashboard (Cohesity UI). If true, the encryption key has been downloaded using the Cohesity Dashboard. An encryption key can only be downloaded once using the Cohesity Dashboard..</param>
        /// <param name="encryptionPolicy">Specifies whether to send and store data in an encrypted format. &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted..</param>
        /// <param name="externalTargetType">Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault..</param>
        /// <param name="fullArchiveIntervalDays">Specifies the number days between full archives to the Vault. The current default is 90 days. This is only meaningful when incrementalArchivesEnabled is true and the Vault usage type is kArchival..</param>
        /// <param name="globalId">Specifies the global identifier of the Vault..</param>
        /// <param name="id">Specifies an id that identifies the Vault..</param>
        /// <param name="incrementalArchivesEnabled">Specifies whether to perform incremental archival when sending data to the Vault. If false, only full backups are performed. If true, incremental backups are performed between the full backups..</param>
        /// <param name="isAwsSnowball">Specifies whether the vault is aws snowball or not..</param>
        /// <param name="isForeverIncrementalArchiveEnabled">Specifies whether forever incremental archival is enabled on this vault..</param>
        /// <param name="isPasswordEncrypted">Specifies if given password is not encrypted or not in the cluster config..</param>
        /// <param name="keyFileDownloadTimeUsecs">Specifies the time (in microseconds) when the encryption key file was downloaded from the Cohesity Dashboard (Cohesity UI). An encryption key can only be downloaded once using the Cohesity Dashboard..</param>
        /// <param name="keyFileDownloadUser">Specifies the user who downloaded the encryption key from the Cohesity Dashboard (Cohesity UI). This field is only populated if encryption is enabled for the Vault and customerManagingEncryptionKeys is true..</param>
        /// <param name="kmsServerId">Specifies the associated KMS Server ID..</param>
        /// <param name="name">Specifies the name of the Vault..</param>
        /// <param name="removalState">Specifies the state of the vault to be removed. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster..</param>
        /// <param name="tenantIds">Specifies the list of tenants which will have a access to current vault..</param>
        /// <param name="type">Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kGlacier&#39; indicates an AWS Glacier Vault. &#39;kS3&#39; indicates an AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates an S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAmazonS3StandardIA&#39; indicates an Amazon S3 Standard-IA Vault. &#39;kAWSGovCloud&#39; indicates an AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kAzureGovCloud&#39; indicates a Microsoft Azure Gov Cloud Vault. &#39;kAzureArchive&#39; indicates an Azure Archive Vault. &#39;kAzure&#39; indicates an Azure Vault. &#39;kGoogle&#39; indicates a Google Vault. &#39;kAmazon&#39; indicates an Amazon Vault. &#39;kOracle&#39; indicates an Oracle Vault. &#39;kOracleTierStandard&#39; indicates an Oracle Tier Standard Vault. &#39;kOracleTierArchive&#39; indicates an Oracle Tier Archive Vault. &#39;kAmazonC2S&#39; indicates an Amazon Commercial Cloud Services Vault..</param>
        /// <param name="usageType">Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data. &#39;kRpaasArchival&#39; indicates the Vault is for RPaaS..</param>
        /// <param name="vaultBandwidthLimits">vaultBandwidthLimits.</param>
        /// <param name="vaultOwnership">Specifies the ownership context for consumption. &#39;kOwnershipContextLocal&#39; indicates the Vault is used for local consumption &#39;kOwnershipContextFortKnox&#39; indicates the Vault is used for Fortknox consumption.</param>
        /// <param name="viewBoxName">Specifies the name of the associated viewbox that is to be created while registering vault in NextGen CE..</param>
        public Vault(string caTrustedCertificate = default(string), string clientCertificate = default(string), string clientPrivateKey = default(string), CloudArchivalDirectConfig cloudArchivalDirectConfig = default(CloudArchivalDirectConfig), List<CloudDomainList> cloudDomainList = default(List<CloudDomainList>), CompressionPolicyEnum? compressionPolicy = default(CompressionPolicyEnum?), VaultConfig config = default(VaultConfig), bool? customerManagingEncryptionKeys = default(bool?), bool? dedupEnabled = default(bool?), bool? dekRotationEnabled = default(bool?), string deleteVaultError = default(string), string description = default(string), DesiredWalLocationEnum? desiredWalLocation = default(DesiredWalLocationEnum?), bool? encryptionKeyFileDownloaded = default(bool?), EncryptionPolicyEnum? encryptionPolicy = default(EncryptionPolicyEnum?), ExternalTargetTypeEnum? externalTargetType = default(ExternalTargetTypeEnum?), long? fullArchiveIntervalDays = default(long?), string globalId = default(string), long? id = default(long?), bool? incrementalArchivesEnabled = default(bool?), bool? isAwsSnowball = default(bool?), bool? isForeverIncrementalArchiveEnabled = default(bool?), bool? isPasswordEncrypted = default(bool?), long? keyFileDownloadTimeUsecs = default(long?), string keyFileDownloadUser = default(string), long? kmsServerId = default(long?), string name = default(string), RemovalStateEnum? removalState = default(RemovalStateEnum?), List<string> tenantIds = default(List<string>), TypeEnum? type = default(TypeEnum?), UsageTypeEnum? usageType = default(UsageTypeEnum?), VaultBandwidthLimits vaultBandwidthLimits = default(VaultBandwidthLimits), VaultOwnershipEnum? vaultOwnership = default(VaultOwnershipEnum?), string viewBoxName = default(string))
        {
            this.CaTrustedCertificate = caTrustedCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientPrivateKey = clientPrivateKey;
            this.CloudDomainList = cloudDomainList;
            this.CompressionPolicy = compressionPolicy;
            this.CustomerManagingEncryptionKeys = customerManagingEncryptionKeys;
            this.DedupEnabled = dedupEnabled;
            this.DekRotationEnabled = dekRotationEnabled;
            this.DeleteVaultError = deleteVaultError;
            this.Description = description;
            this.DesiredWalLocation = desiredWalLocation;
            this.EncryptionKeyFileDownloaded = encryptionKeyFileDownloaded;
            this.EncryptionPolicy = encryptionPolicy;
            this.ExternalTargetType = externalTargetType;
            this.FullArchiveIntervalDays = fullArchiveIntervalDays;
            this.GlobalId = globalId;
            this.Id = id;
            this.IncrementalArchivesEnabled = incrementalArchivesEnabled;
            this.IsAwsSnowball = isAwsSnowball;
            this.IsForeverIncrementalArchiveEnabled = isForeverIncrementalArchiveEnabled;
            this.IsPasswordEncrypted = isPasswordEncrypted;
            this.KeyFileDownloadTimeUsecs = keyFileDownloadTimeUsecs;
            this.KeyFileDownloadUser = keyFileDownloadUser;
            this.KmsServerId = kmsServerId;
            this.Name = name;
            this.RemovalState = removalState;
            this.TenantIds = tenantIds;
            this.Type = type;
            this.UsageType = usageType;
            this.VaultOwnership = vaultOwnership;
            this.ViewBoxName = viewBoxName;
            this.CaTrustedCertificate = caTrustedCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientPrivateKey = clientPrivateKey;
            this.CloudArchivalDirectConfig = cloudArchivalDirectConfig;
            this.CloudDomainList = cloudDomainList;
            this.CompressionPolicy = compressionPolicy;
            this.Config = config;
            this.CustomerManagingEncryptionKeys = customerManagingEncryptionKeys;
            this.DedupEnabled = dedupEnabled;
            this.DekRotationEnabled = dekRotationEnabled;
            this.DeleteVaultError = deleteVaultError;
            this.Description = description;
            this.DesiredWalLocation = desiredWalLocation;
            this.EncryptionKeyFileDownloaded = encryptionKeyFileDownloaded;
            this.EncryptionPolicy = encryptionPolicy;
            this.ExternalTargetType = externalTargetType;
            this.FullArchiveIntervalDays = fullArchiveIntervalDays;
            this.GlobalId = globalId;
            this.Id = id;
            this.IncrementalArchivesEnabled = incrementalArchivesEnabled;
            this.IsAwsSnowball = isAwsSnowball;
            this.IsForeverIncrementalArchiveEnabled = isForeverIncrementalArchiveEnabled;
            this.IsPasswordEncrypted = isPasswordEncrypted;
            this.KeyFileDownloadTimeUsecs = keyFileDownloadTimeUsecs;
            this.KeyFileDownloadUser = keyFileDownloadUser;
            this.KmsServerId = kmsServerId;
            this.Name = name;
            this.RemovalState = removalState;
            this.TenantIds = tenantIds;
            this.Type = type;
            this.UsageType = usageType;
            this.VaultBandwidthLimits = vaultBandwidthLimits;
            this.VaultOwnership = vaultOwnership;
            this.ViewBoxName = viewBoxName;
        }
        
        /// <summary>
        /// Specifies the CA (certificate authority) trusted certificate.
        /// </summary>
        /// <value>Specifies the CA (certificate authority) trusted certificate.</value>
        [DataMember(Name="caTrustedCertificate", EmitDefaultValue=true)]
        public string CaTrustedCertificate { get; set; }

        /// <summary>
        /// Specifies the client CA  certificate. This certificate is in pem format.
        /// </summary>
        /// <value>Specifies the client CA  certificate. This certificate is in pem format.</value>
        [DataMember(Name="clientCertificate", EmitDefaultValue=true)]
        public string ClientCertificate { get; set; }

        /// <summary>
        /// Specifies the client private key. This certificate is in pem format.
        /// </summary>
        /// <value>Specifies the client private key. This certificate is in pem format.</value>
        [DataMember(Name="clientPrivateKey", EmitDefaultValue=true)]
        public string ClientPrivateKey { get; set; }

        /// <summary>
        /// Gets or Sets CloudArchivalDirectConfig
        /// </summary>
        [DataMember(Name="cloudArchivalDirectConfig", EmitDefaultValue=false)]
        public CloudArchivalDirectConfig CloudArchivalDirectConfig { get; set; }

        /// <summary>
        /// Specifies the cloud domain information.
        /// </summary>
        /// <value>Specifies the cloud domain information.</value>
        [DataMember(Name="cloudDomainList", EmitDefaultValue=true)]
        public List<CloudDomainList> CloudDomainList { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public VaultConfig Config { get; set; }

        /// <summary>
        /// Specifies whether to manage the encryption key manually or let the Cohesity Cluster manage it. If true, you must get the encryption key store it outside the Cluster, before disaster strikes such as the source local Cohesity Cluster being down. You can get the encryption key by downloading it using the Cohesity Dashboard or by calling the GET /public/vaults/encryptionKey/{id} operation.
        /// </summary>
        /// <value>Specifies whether to manage the encryption key manually or let the Cohesity Cluster manage it. If true, you must get the encryption key store it outside the Cluster, before disaster strikes such as the source local Cohesity Cluster being down. You can get the encryption key by downloading it using the Cohesity Dashboard or by calling the GET /public/vaults/encryptionKey/{id} operation.</value>
        [DataMember(Name="customerManagingEncryptionKeys", EmitDefaultValue=true)]
        public bool? CustomerManagingEncryptionKeys { get; set; }

        /// <summary>
        /// Specifies whether to deduplicate data before sending it to the Vault.
        /// </summary>
        /// <value>Specifies whether to deduplicate data before sending it to the Vault.</value>
        [DataMember(Name="dedupEnabled", EmitDefaultValue=true)]
        public bool? DedupEnabled { get; set; }

        /// <summary>
        /// Specifies whether DEK(Data Encryption Key) rotation is enabled for this vault. This is applicable only when the viewbox uses AWS or similar KMS in which the KEK (Key Encryption Key) is not created and maintained by Cohesity. For Internal KMS and keys stored in Safenet servers, DEK rotation will not be performed.
        /// </summary>
        /// <value>Specifies whether DEK(Data Encryption Key) rotation is enabled for this vault. This is applicable only when the viewbox uses AWS or similar KMS in which the KEK (Key Encryption Key) is not created and maintained by Cohesity. For Internal KMS and keys stored in Safenet servers, DEK rotation will not be performed.</value>
        [DataMember(Name="dekRotationEnabled", EmitDefaultValue=true)]
        public bool? DekRotationEnabled { get; set; }

        /// <summary>
        /// Specifies the error message when deleting a vault.
        /// </summary>
        /// <value>Specifies the error message when deleting a vault.</value>
        [DataMember(Name="deleteVaultError", EmitDefaultValue=true)]
        public string DeleteVaultError { get; set; }

        /// <summary>
        /// Specifies a description about the Vault.
        /// </summary>
        /// <value>Specifies a description about the Vault.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if the encryption key file has been downloaded using the Cohesity Dashboard (Cohesity UI). If true, the encryption key has been downloaded using the Cohesity Dashboard. An encryption key can only be downloaded once using the Cohesity Dashboard.
        /// </summary>
        /// <value>Specifies if the encryption key file has been downloaded using the Cohesity Dashboard (Cohesity UI). If true, the encryption key has been downloaded using the Cohesity Dashboard. An encryption key can only be downloaded once using the Cohesity Dashboard.</value>
        [DataMember(Name="encryptionKeyFileDownloaded", EmitDefaultValue=true)]
        public bool? EncryptionKeyFileDownloaded { get; set; }

        /// <summary>
        /// Specifies the number days between full archives to the Vault. The current default is 90 days. This is only meaningful when incrementalArchivesEnabled is true and the Vault usage type is kArchival.
        /// </summary>
        /// <value>Specifies the number days between full archives to the Vault. The current default is 90 days. This is only meaningful when incrementalArchivesEnabled is true and the Vault usage type is kArchival.</value>
        [DataMember(Name="fullArchiveIntervalDays", EmitDefaultValue=true)]
        public long? FullArchiveIntervalDays { get; set; }

        /// <summary>
        /// Specifies the global identifier of the Vault.
        /// </summary>
        /// <value>Specifies the global identifier of the Vault.</value>
        [DataMember(Name="globalId", EmitDefaultValue=true)]
        public string GlobalId { get; set; }

        /// <summary>
        /// Specifies an id that identifies the Vault.
        /// </summary>
        /// <value>Specifies an id that identifies the Vault.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies whether to perform incremental archival when sending data to the Vault. If false, only full backups are performed. If true, incremental backups are performed between the full backups.
        /// </summary>
        /// <value>Specifies whether to perform incremental archival when sending data to the Vault. If false, only full backups are performed. If true, incremental backups are performed between the full backups.</value>
        [DataMember(Name="incrementalArchivesEnabled", EmitDefaultValue=true)]
        public bool? IncrementalArchivesEnabled { get; set; }

        /// <summary>
        /// Specifies whether the vault is aws snowball or not.
        /// </summary>
        /// <value>Specifies whether the vault is aws snowball or not.</value>
        [DataMember(Name="isAwsSnowball", EmitDefaultValue=true)]
        public bool? IsAwsSnowball { get; set; }

        /// <summary>
        /// Specifies whether forever incremental archival is enabled on this vault.
        /// </summary>
        /// <value>Specifies whether forever incremental archival is enabled on this vault.</value>
        [DataMember(Name="isForeverIncrementalArchiveEnabled", EmitDefaultValue=true)]
        public bool? IsForeverIncrementalArchiveEnabled { get; set; }

        /// <summary>
        /// Specifies if given password is not encrypted or not in the cluster config.
        /// </summary>
        /// <value>Specifies if given password is not encrypted or not in the cluster config.</value>
        [DataMember(Name="isPasswordEncrypted", EmitDefaultValue=true)]
        public bool? IsPasswordEncrypted { get; set; }

        /// <summary>
        /// Specifies the time (in microseconds) when the encryption key file was downloaded from the Cohesity Dashboard (Cohesity UI). An encryption key can only be downloaded once using the Cohesity Dashboard.
        /// </summary>
        /// <value>Specifies the time (in microseconds) when the encryption key file was downloaded from the Cohesity Dashboard (Cohesity UI). An encryption key can only be downloaded once using the Cohesity Dashboard.</value>
        [DataMember(Name="keyFileDownloadTimeUsecs", EmitDefaultValue=true)]
        public long? KeyFileDownloadTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the user who downloaded the encryption key from the Cohesity Dashboard (Cohesity UI). This field is only populated if encryption is enabled for the Vault and customerManagingEncryptionKeys is true.
        /// </summary>
        /// <value>Specifies the user who downloaded the encryption key from the Cohesity Dashboard (Cohesity UI). This field is only populated if encryption is enabled for the Vault and customerManagingEncryptionKeys is true.</value>
        [DataMember(Name="keyFileDownloadUser", EmitDefaultValue=true)]
        public string KeyFileDownloadUser { get; set; }

        /// <summary>
        /// Specifies the associated KMS Server ID.
        /// </summary>
        /// <value>Specifies the associated KMS Server ID.</value>
        [DataMember(Name="kmsServerId", EmitDefaultValue=true)]
        public long? KmsServerId { get; set; }

        /// <summary>
        /// Specifies the name of the Vault.
        /// </summary>
        /// <value>Specifies the name of the Vault.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the list of tenants which will have a access to current vault.
        /// </summary>
        /// <value>Specifies the list of tenants which will have a access to current vault.</value>
        [DataMember(Name="tenantIds", EmitDefaultValue=true)]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Gets or Sets VaultBandwidthLimits
        /// </summary>
        [DataMember(Name="vaultBandwidthLimits", EmitDefaultValue=false)]
        public VaultBandwidthLimits VaultBandwidthLimits { get; set; }

        /// <summary>
        /// Specifies the name of the associated viewbox that is to be created while registering vault in NextGen CE.
        /// </summary>
        /// <value>Specifies the name of the associated viewbox that is to be created while registering vault in NextGen CE.</value>
        [DataMember(Name="viewBoxName", EmitDefaultValue=true)]
        public string ViewBoxName { get; set; }

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
            return this.Equals(input as Vault);
        }

        /// <summary>
        /// Returns true if Vault instances are equal
        /// </summary>
        /// <param name="input">Instance of Vault to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vault input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaTrustedCertificate == input.CaTrustedCertificate ||
                    (this.CaTrustedCertificate != null &&
                    this.CaTrustedCertificate.Equals(input.CaTrustedCertificate))
                ) && 
                (
                    this.ClientCertificate == input.ClientCertificate ||
                    (this.ClientCertificate != null &&
                    this.ClientCertificate.Equals(input.ClientCertificate))
                ) && 
                (
                    this.ClientPrivateKey == input.ClientPrivateKey ||
                    (this.ClientPrivateKey != null &&
                    this.ClientPrivateKey.Equals(input.ClientPrivateKey))
                ) && 
                (
                    this.CloudArchivalDirectConfig == input.CloudArchivalDirectConfig ||
                    (this.CloudArchivalDirectConfig != null &&
                    this.CloudArchivalDirectConfig.Equals(input.CloudArchivalDirectConfig))
                ) && 
                (
                    this.CloudDomainList == input.CloudDomainList ||
                    this.CloudDomainList != null &&
                    input.CloudDomainList != null &&
                    this.CloudDomainList.SequenceEqual(input.CloudDomainList)
                ) && 
                (
                    this.CompressionPolicy == input.CompressionPolicy ||
                    this.CompressionPolicy.Equals(input.CompressionPolicy)
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.CustomerManagingEncryptionKeys == input.CustomerManagingEncryptionKeys ||
                    (this.CustomerManagingEncryptionKeys != null &&
                    this.CustomerManagingEncryptionKeys.Equals(input.CustomerManagingEncryptionKeys))
                ) && 
                (
                    this.DedupEnabled == input.DedupEnabled ||
                    (this.DedupEnabled != null &&
                    this.DedupEnabled.Equals(input.DedupEnabled))
                ) && 
                (
                    this.DekRotationEnabled == input.DekRotationEnabled ||
                    (this.DekRotationEnabled != null &&
                    this.DekRotationEnabled.Equals(input.DekRotationEnabled))
                ) && 
                (
                    this.DeleteVaultError == input.DeleteVaultError ||
                    (this.DeleteVaultError != null &&
                    this.DeleteVaultError.Equals(input.DeleteVaultError))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DesiredWalLocation == input.DesiredWalLocation ||
                    this.DesiredWalLocation.Equals(input.DesiredWalLocation)
                ) && 
                (
                    this.EncryptionKeyFileDownloaded == input.EncryptionKeyFileDownloaded ||
                    (this.EncryptionKeyFileDownloaded != null &&
                    this.EncryptionKeyFileDownloaded.Equals(input.EncryptionKeyFileDownloaded))
                ) && 
                (
                    this.EncryptionPolicy == input.EncryptionPolicy ||
                    this.EncryptionPolicy.Equals(input.EncryptionPolicy)
                ) && 
                (
                    this.ExternalTargetType == input.ExternalTargetType ||
                    this.ExternalTargetType.Equals(input.ExternalTargetType)
                ) && 
                (
                    this.FullArchiveIntervalDays == input.FullArchiveIntervalDays ||
                    (this.FullArchiveIntervalDays != null &&
                    this.FullArchiveIntervalDays.Equals(input.FullArchiveIntervalDays))
                ) && 
                (
                    this.GlobalId == input.GlobalId ||
                    (this.GlobalId != null &&
                    this.GlobalId.Equals(input.GlobalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncrementalArchivesEnabled == input.IncrementalArchivesEnabled ||
                    (this.IncrementalArchivesEnabled != null &&
                    this.IncrementalArchivesEnabled.Equals(input.IncrementalArchivesEnabled))
                ) && 
                (
                    this.IsAwsSnowball == input.IsAwsSnowball ||
                    (this.IsAwsSnowball != null &&
                    this.IsAwsSnowball.Equals(input.IsAwsSnowball))
                ) && 
                (
                    this.IsForeverIncrementalArchiveEnabled == input.IsForeverIncrementalArchiveEnabled ||
                    (this.IsForeverIncrementalArchiveEnabled != null &&
                    this.IsForeverIncrementalArchiveEnabled.Equals(input.IsForeverIncrementalArchiveEnabled))
                ) && 
                (
                    this.IsPasswordEncrypted == input.IsPasswordEncrypted ||
                    (this.IsPasswordEncrypted != null &&
                    this.IsPasswordEncrypted.Equals(input.IsPasswordEncrypted))
                ) && 
                (
                    this.KeyFileDownloadTimeUsecs == input.KeyFileDownloadTimeUsecs ||
                    (this.KeyFileDownloadTimeUsecs != null &&
                    this.KeyFileDownloadTimeUsecs.Equals(input.KeyFileDownloadTimeUsecs))
                ) && 
                (
                    this.KeyFileDownloadUser == input.KeyFileDownloadUser ||
                    (this.KeyFileDownloadUser != null &&
                    this.KeyFileDownloadUser.Equals(input.KeyFileDownloadUser))
                ) && 
                (
                    this.KmsServerId == input.KmsServerId ||
                    (this.KmsServerId != null &&
                    this.KmsServerId.Equals(input.KmsServerId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RemovalState == input.RemovalState ||
                    this.RemovalState.Equals(input.RemovalState)
                ) && 
                (
                    this.TenantIds == input.TenantIds ||
                    this.TenantIds != null &&
                    input.TenantIds != null &&
                    this.TenantIds.SequenceEqual(input.TenantIds)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UsageType == input.UsageType ||
                    this.UsageType.Equals(input.UsageType)
                ) && 
                (
                    this.VaultBandwidthLimits == input.VaultBandwidthLimits ||
                    (this.VaultBandwidthLimits != null &&
                    this.VaultBandwidthLimits.Equals(input.VaultBandwidthLimits))
                ) && 
                (
                    this.VaultOwnership == input.VaultOwnership ||
                    this.VaultOwnership.Equals(input.VaultOwnership)
                ) && 
                (
                    this.ViewBoxName == input.ViewBoxName ||
                    (this.ViewBoxName != null &&
                    this.ViewBoxName.Equals(input.ViewBoxName))
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
                if (this.CaTrustedCertificate != null)
                    hashCode = hashCode * 59 + this.CaTrustedCertificate.GetHashCode();
                if (this.ClientCertificate != null)
                    hashCode = hashCode * 59 + this.ClientCertificate.GetHashCode();
                if (this.ClientPrivateKey != null)
                    hashCode = hashCode * 59 + this.ClientPrivateKey.GetHashCode();
                if (this.CloudArchivalDirectConfig != null)
                    hashCode = hashCode * 59 + this.CloudArchivalDirectConfig.GetHashCode();
                if (this.CloudDomainList != null)
                    hashCode = hashCode * 59 + this.CloudDomainList.GetHashCode();
                hashCode = hashCode * 59 + this.CompressionPolicy.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.CustomerManagingEncryptionKeys != null)
                    hashCode = hashCode * 59 + this.CustomerManagingEncryptionKeys.GetHashCode();
                if (this.DedupEnabled != null)
                    hashCode = hashCode * 59 + this.DedupEnabled.GetHashCode();
                if (this.DekRotationEnabled != null)
                    hashCode = hashCode * 59 + this.DekRotationEnabled.GetHashCode();
                if (this.DeleteVaultError != null)
                    hashCode = hashCode * 59 + this.DeleteVaultError.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.DesiredWalLocation.GetHashCode();
                if (this.EncryptionKeyFileDownloaded != null)
                    hashCode = hashCode * 59 + this.EncryptionKeyFileDownloaded.GetHashCode();
                hashCode = hashCode * 59 + this.EncryptionPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.ExternalTargetType.GetHashCode();
                if (this.FullArchiveIntervalDays != null)
                    hashCode = hashCode * 59 + this.FullArchiveIntervalDays.GetHashCode();
                if (this.GlobalId != null)
                    hashCode = hashCode * 59 + this.GlobalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncrementalArchivesEnabled != null)
                    hashCode = hashCode * 59 + this.IncrementalArchivesEnabled.GetHashCode();
                if (this.IsAwsSnowball != null)
                    hashCode = hashCode * 59 + this.IsAwsSnowball.GetHashCode();
                if (this.IsForeverIncrementalArchiveEnabled != null)
                    hashCode = hashCode * 59 + this.IsForeverIncrementalArchiveEnabled.GetHashCode();
                if (this.IsPasswordEncrypted != null)
                    hashCode = hashCode * 59 + this.IsPasswordEncrypted.GetHashCode();
                if (this.KeyFileDownloadTimeUsecs != null)
                    hashCode = hashCode * 59 + this.KeyFileDownloadTimeUsecs.GetHashCode();
                if (this.KeyFileDownloadUser != null)
                    hashCode = hashCode * 59 + this.KeyFileDownloadUser.GetHashCode();
                if (this.KmsServerId != null)
                    hashCode = hashCode * 59 + this.KmsServerId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.RemovalState.GetHashCode();
                if (this.TenantIds != null)
                    hashCode = hashCode * 59 + this.TenantIds.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.UsageType.GetHashCode();
                if (this.VaultBandwidthLimits != null)
                    hashCode = hashCode * 59 + this.VaultBandwidthLimits.GetHashCode();
                hashCode = hashCode * 59 + this.VaultOwnership.GetHashCode();
                if (this.ViewBoxName != null)
                    hashCode = hashCode * 59 + this.ViewBoxName.GetHashCode();
                return hashCode;
            }
        }

    }

}

