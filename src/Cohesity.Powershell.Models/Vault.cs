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
        /// Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed.
        /// </summary>
        /// <value>Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed.</value>
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
            KCompressionLow = 2

        }

        /// <summary>
        /// Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed.
        /// </summary>
        /// <value>Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed.</value>
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
        /// Specifies the type of Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault. &#39;kAzure&#39; indiactes an Azure vault. &#39;kGoogle&#39; indcates a Google vault. &#39;kAmazon&#39; indicates an AWS vault. &#39;kOracle&#39; indicates an Oracle vault. &#39;kAmazonC2S&#39; indicates an AWS C2S vault.
        /// </summary>
        /// <value>Specifies the type of Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault. &#39;kAzure&#39; indiactes an Azure vault. &#39;kGoogle&#39; indcates a Google vault. &#39;kAmazon&#39; indicates an AWS vault. &#39;kOracle&#39; indicates an Oracle vault. &#39;kAmazonC2S&#39; indicates an AWS C2S vault.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExternalTargetTypeEnum
        {
            /// <summary>
            /// Enum KS3Compatible for value: kS3Compatible
            /// </summary>
            [EnumMember(Value = "kS3Compatible")]
            KS3Compatible = 1,

            /// <summary>
            /// Enum KQStarTape for value: kQStarTape
            /// </summary>
            [EnumMember(Value = "kQStarTape")]
            KQStarTape = 2,

            /// <summary>
            /// Enum KAWSGovCloud for value: kAWSGovCloud
            /// </summary>
            [EnumMember(Value = "kAWSGovCloud")]
            KAWSGovCloud = 3,

            /// <summary>
            /// Enum KNAS for value: kNAS
            /// </summary>
            [EnumMember(Value = "kNAS")]
            KNAS = 4,

            /// <summary>
            /// Enum KAzureGovCloud for value: kAzureGovCloud
            /// </summary>
            [EnumMember(Value = "kAzureGovCloud")]
            KAzureGovCloud = 5,

            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 6,

            /// <summary>
            /// Enum KGoogle for value: kGoogle
            /// </summary>
            [EnumMember(Value = "kGoogle")]
            KGoogle = 7,

            /// <summary>
            /// Enum KAmazon for value: kAmazon
            /// </summary>
            [EnumMember(Value = "kAmazon")]
            KAmazon = 8,

            /// <summary>
            /// Enum KOracle for value: kOracle
            /// </summary>
            [EnumMember(Value = "kOracle")]
            KOracle = 9,

            /// <summary>
            /// Enum KAmazonC2S for value: kAmazonC2S
            /// </summary>
            [EnumMember(Value = "kAmazonC2S")]
            KAmazonC2S = 10

        }

        /// <summary>
        /// Specifies the type of Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault. &#39;kAzure&#39; indiactes an Azure vault. &#39;kGoogle&#39; indcates a Google vault. &#39;kAmazon&#39; indicates an AWS vault. &#39;kOracle&#39; indicates an Oracle vault. &#39;kAmazonC2S&#39; indicates an AWS C2S vault.
        /// </summary>
        /// <value>Specifies the type of Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault. &#39;kAzure&#39; indiactes an Azure vault. &#39;kGoogle&#39; indcates a Google vault. &#39;kAmazon&#39; indicates an AWS vault. &#39;kOracle&#39; indicates an Oracle vault. &#39;kAmazonC2S&#39; indicates an AWS C2S vault.</value>
        [DataMember(Name="externalTargetType", EmitDefaultValue=true)]
        public ExternalTargetTypeEnum? ExternalTargetType { get; set; }
        /// <summary>
        /// Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
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
        /// Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.
        /// </summary>
        /// <value>Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data.
        /// </summary>
        /// <value>Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data.</value>
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
        /// Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data.
        /// </summary>
        /// <value>Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data.</value>
        [DataMember(Name="usageType", EmitDefaultValue=true)]
        public UsageTypeEnum? UsageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Vault" /> class.
        /// </summary>
        /// <param name="caTrustedCertificate">Specifies the CA (certificate authority) trusted certificate..</param>
        /// <param name="clientCertificate">Specifies the client CA  certificate. This certificate is in pem format..</param>
        /// <param name="clientPrivateKey">Specifies the client private key. This certificate is in pem format..</param>
        /// <param name="compressionPolicy">Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed..</param>
        /// <param name="config">config.</param>
        /// <param name="customerManagingEncryptionKeys">Specifies whether to manage the encryption key manually or let the Cohesity Cluster manage it. If true, you must get the encryption key store it outside the Cluster, before disaster strikes such as the source local Cohesity Cluster being down. You can get the encryption key by downloading it using the Cohesity Dashboard or by calling the GET /public/vaults/encryptionKey/{id} operation..</param>
        /// <param name="dedupEnabled">Specifies whether to deduplicate data before sending it to the Vault..</param>
        /// <param name="description">Specifies a description about the Vault..</param>
        /// <param name="desiredWalLocation">Desired location for write ahead logs(wal). &#39;kHomePartition&#39; indicates desired wal location to be the home partition. &#39;kDisk&#39; indicates desired wal location to be the same disk as chunk repo. &#39;kScribe&#39; indicates desired wal location to be scribe. &#39;kScribeTable&#39; indicates chunk repository state is kept as key-value pairs in scribe..</param>
        /// <param name="encryptionKeyFileDownloaded">Specifies if the encryption key file has been downloaded using the Cohesity Dashboard (Cohesity UI). If true, the encryption key has been downloaded using the Cohesity Dashboard. An encryption key can only be downloaded once using the Cohesity Dashboard..</param>
        /// <param name="encryptionPolicy">Specifies whether to send and store data in an encrypted format. &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted..</param>
        /// <param name="externalTargetType">Specifies the type of Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault. &#39;kAzure&#39; indiactes an Azure vault. &#39;kGoogle&#39; indcates a Google vault. &#39;kAmazon&#39; indicates an AWS vault. &#39;kOracle&#39; indicates an Oracle vault. &#39;kAmazonC2S&#39; indicates an AWS C2S vault..</param>
        /// <param name="fullArchiveIntervalDays">Specifies the number days between full archives to the Vault. The current default is 90 days. This is only meaningful when incrementalArchivesEnabled is true and the Vault usage type is kArchival..</param>
        /// <param name="id">Specifies an id that identifies the Vault..</param>
        /// <param name="incrementalArchivesEnabled">Specifies whether to perform incremental archival when sending data to the Vault. If false, only full backups are performed. If true, incremental backups are performed between the full backups..</param>
        /// <param name="keyFileDownloadTimeUsecs">Specifies the time (in microseconds) when the encryption key file was downloaded from the Cohesity Dashboard (Cohesity UI). An encryption key can only be downloaded once using the Cohesity Dashboard..</param>
        /// <param name="keyFileDownloadUser">Specifies the user who downloaded the encryption key from the Cohesity Dashboard (Cohesity UI). This field is only populated if encryption is enabled for the Vault and customerManagingEncryptionKeys is true..</param>
        /// <param name="name">Specifies the name of the Vault..</param>
        /// <param name="type">Specifies the type of Vault. This field is deprecated. This field is split into ExternalTargetType in and TierType in respective credentials. Initialize those fields instead. deprecated: true &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault..</param>
        /// <param name="usageType">Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data..</param>
        /// <param name="vaultBandwidthLimits">vaultBandwidthLimits.</param>
        public Vault(string caTrustedCertificate = default(string), string clientCertificate = default(string), string clientPrivateKey = default(string), CompressionPolicyEnum? compressionPolicy = default(CompressionPolicyEnum?), VaultConfig config = default(VaultConfig), bool? customerManagingEncryptionKeys = default(bool?), bool? dedupEnabled = default(bool?), string description = default(string), DesiredWalLocationEnum? desiredWalLocation = default(DesiredWalLocationEnum?), bool? encryptionKeyFileDownloaded = default(bool?), EncryptionPolicyEnum? encryptionPolicy = default(EncryptionPolicyEnum?), ExternalTargetTypeEnum? externalTargetType = default(ExternalTargetTypeEnum?), long? fullArchiveIntervalDays = default(long?), long? id = default(long?), bool? incrementalArchivesEnabled = default(bool?), long? keyFileDownloadTimeUsecs = default(long?), string keyFileDownloadUser = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?), UsageTypeEnum? usageType = default(UsageTypeEnum?), VaultBandwidthLimits vaultBandwidthLimits = default(VaultBandwidthLimits))
        {
            this.CaTrustedCertificate = caTrustedCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientPrivateKey = clientPrivateKey;
            this.CompressionPolicy = compressionPolicy;
            this.CustomerManagingEncryptionKeys = customerManagingEncryptionKeys;
            this.DedupEnabled = dedupEnabled;
            this.Description = description;
            this.DesiredWalLocation = desiredWalLocation;
            this.EncryptionKeyFileDownloaded = encryptionKeyFileDownloaded;
            this.EncryptionPolicy = encryptionPolicy;
            this.ExternalTargetType = externalTargetType;
            this.FullArchiveIntervalDays = fullArchiveIntervalDays;
            this.Id = id;
            this.IncrementalArchivesEnabled = incrementalArchivesEnabled;
            this.KeyFileDownloadTimeUsecs = keyFileDownloadTimeUsecs;
            this.KeyFileDownloadUser = keyFileDownloadUser;
            this.Name = name;
            this.Type = type;
            this.UsageType = usageType;
            this.CaTrustedCertificate = caTrustedCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientPrivateKey = clientPrivateKey;
            this.CompressionPolicy = compressionPolicy;
            this.Config = config;
            this.CustomerManagingEncryptionKeys = customerManagingEncryptionKeys;
            this.DedupEnabled = dedupEnabled;
            this.Description = description;
            this.DesiredWalLocation = desiredWalLocation;
            this.EncryptionKeyFileDownloaded = encryptionKeyFileDownloaded;
            this.EncryptionPolicy = encryptionPolicy;
            this.ExternalTargetType = externalTargetType;
            this.FullArchiveIntervalDays = fullArchiveIntervalDays;
            this.Id = id;
            this.IncrementalArchivesEnabled = incrementalArchivesEnabled;
            this.KeyFileDownloadTimeUsecs = keyFileDownloadTimeUsecs;
            this.KeyFileDownloadUser = keyFileDownloadUser;
            this.Name = name;
            this.Type = type;
            this.UsageType = usageType;
            this.VaultBandwidthLimits = vaultBandwidthLimits;
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
        /// Specifies the name of the Vault.
        /// </summary>
        /// <value>Specifies the name of the Vault.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets VaultBandwidthLimits
        /// </summary>
        [DataMember(Name="vaultBandwidthLimits", EmitDefaultValue=false)]
        public VaultBandwidthLimits VaultBandwidthLimits { get; set; }

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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = hashCode * 59 + this.CompressionPolicy.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.CustomerManagingEncryptionKeys != null)
                    hashCode = hashCode * 59 + this.CustomerManagingEncryptionKeys.GetHashCode();
                if (this.DedupEnabled != null)
                    hashCode = hashCode * 59 + this.DedupEnabled.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.DesiredWalLocation.GetHashCode();
                if (this.EncryptionKeyFileDownloaded != null)
                    hashCode = hashCode * 59 + this.EncryptionKeyFileDownloaded.GetHashCode();
                hashCode = hashCode * 59 + this.EncryptionPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.ExternalTargetType.GetHashCode();
                if (this.FullArchiveIntervalDays != null)
                    hashCode = hashCode * 59 + this.FullArchiveIntervalDays.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncrementalArchivesEnabled != null)
                    hashCode = hashCode * 59 + this.IncrementalArchivesEnabled.GetHashCode();
                if (this.KeyFileDownloadTimeUsecs != null)
                    hashCode = hashCode * 59 + this.KeyFileDownloadTimeUsecs.GetHashCode();
                if (this.KeyFileDownloadUser != null)
                    hashCode = hashCode * 59 + this.KeyFileDownloadUser.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.UsageType.GetHashCode();
                if (this.VaultBandwidthLimits != null)
                    hashCode = hashCode * 59 + this.VaultBandwidthLimits.GetHashCode();
                return hashCode;
            }
        }

    }

}

