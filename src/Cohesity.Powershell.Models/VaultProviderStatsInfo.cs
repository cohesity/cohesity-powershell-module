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
    /// Specifies the stats for each vault.
    /// </summary>
    [DataContract]
    public partial class VaultProviderStatsInfo :  IEquatable<VaultProviderStatsInfo>
    {
        /// <summary>
        /// Specifies the cloud vendor type.
        /// </summary>
        /// <value>Specifies the cloud vendor type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VaultGroupEnum
        {
            /// <summary>
            /// Enum KAws for value: kAws
            /// </summary>
            [EnumMember(Value = "kAws")]
            KAws = 1,

            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 2,

            /// <summary>
            /// Enum KGcp for value: kGcp
            /// </summary>
            [EnumMember(Value = "kGcp")]
            KGcp = 3,

            /// <summary>
            /// Enum KOracle for value: kOracle
            /// </summary>
            [EnumMember(Value = "kOracle")]
            KOracle = 4,

            /// <summary>
            /// Enum KNas for value: kNas
            /// </summary>
            [EnumMember(Value = "kNas")]
            KNas = 5,

            /// <summary>
            /// Enum KQStar for value: kQStar
            /// </summary>
            [EnumMember(Value = "kQStar")]
            KQStar = 6,

            /// <summary>
            /// Enum KS3C for value: kS3C
            /// </summary>
            [EnumMember(Value = "kS3C")]
            KS3C = 7,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 8

        }

        /// <summary>
        /// Specifies the cloud vendor type.
        /// </summary>
        /// <value>Specifies the cloud vendor type.</value>
        [DataMember(Name="vaultGroup", EmitDefaultValue=false)]
        public VaultGroupEnum? VaultGroup { get; set; }
        /// <summary>
        /// Specifies the External Target type.
        /// </summary>
        /// <value>Specifies the External Target type.</value>
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
        /// Specifies the External Target type.
        /// </summary>
        /// <value>Specifies the External Target type.</value>
        [DataMember(Name="vaultType", EmitDefaultValue=false)]
        public VaultTypeEnum? VaultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultProviderStatsInfo" /> class.
        /// </summary>
        /// <param name="changeRate">Specifies the relative change of size of entities on the vault..</param>
        /// <param name="clusterId">Specifies the cluster id..</param>
        /// <param name="clusterIncarnationId">Specifies the cluster incarnation id..</param>
        /// <param name="clusterName">Specifies the cluster name..</param>
        /// <param name="readBandwidth">Specifies the average read bandwidth over the last 24 hours..</param>
        /// <param name="statsByEnv">Specifies the stats by environments..</param>
        /// <param name="vaultGroup">Specifies the cloud vendor type..</param>
        /// <param name="vaultId">Specifies the Vault id..</param>
        /// <param name="vaultType">Specifies the External Target type..</param>
        /// <param name="vaultname">Specifies the Vault name..</param>
        /// <param name="writeBandwidth">Specifies the average write bandwidth over the last 24 hours..</param>
        public VaultProviderStatsInfo(long? changeRate = default(long?), long? clusterId = default(long?), long? clusterIncarnationId = default(long?), string clusterName = default(string), long? readBandwidth = default(long?), List<VaultProviderStatsByEnv> statsByEnv = default(List<VaultProviderStatsByEnv>), VaultGroupEnum? vaultGroup = default(VaultGroupEnum?), long? vaultId = default(long?), VaultTypeEnum? vaultType = default(VaultTypeEnum?), string vaultname = default(string), long? writeBandwidth = default(long?))
        {
            this.ChangeRate = changeRate;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.ClusterName = clusterName;
            this.ReadBandwidth = readBandwidth;
            this.StatsByEnv = statsByEnv;
            this.VaultGroup = vaultGroup;
            this.VaultId = vaultId;
            this.VaultType = vaultType;
            this.Vaultname = vaultname;
            this.WriteBandwidth = writeBandwidth;
        }
        
        /// <summary>
        /// Specifies the relative change of size of entities on the vault.
        /// </summary>
        /// <value>Specifies the relative change of size of entities on the vault.</value>
        [DataMember(Name="changeRate", EmitDefaultValue=false)]
        public long? ChangeRate { get; set; }

        /// <summary>
        /// Specifies the cluster id.
        /// </summary>
        /// <value>Specifies the cluster id.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the cluster incarnation id.
        /// </summary>
        /// <value>Specifies the cluster incarnation id.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=false)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies the cluster name.
        /// </summary>
        /// <value>Specifies the cluster name.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies the average read bandwidth over the last 24 hours.
        /// </summary>
        /// <value>Specifies the average read bandwidth over the last 24 hours.</value>
        [DataMember(Name="readBandwidth", EmitDefaultValue=false)]
        public long? ReadBandwidth { get; set; }

        /// <summary>
        /// Specifies the stats by environments.
        /// </summary>
        /// <value>Specifies the stats by environments.</value>
        [DataMember(Name="statsByEnv", EmitDefaultValue=false)]
        public List<VaultProviderStatsByEnv> StatsByEnv { get; set; }


        /// <summary>
        /// Specifies the Vault id.
        /// </summary>
        /// <value>Specifies the Vault id.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }


        /// <summary>
        /// Specifies the Vault name.
        /// </summary>
        /// <value>Specifies the Vault name.</value>
        [DataMember(Name="vaultname", EmitDefaultValue=false)]
        public string Vaultname { get; set; }

        /// <summary>
        /// Specifies the average write bandwidth over the last 24 hours.
        /// </summary>
        /// <value>Specifies the average write bandwidth over the last 24 hours.</value>
        [DataMember(Name="writeBandwidth", EmitDefaultValue=false)]
        public long? WriteBandwidth { get; set; }

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
            return this.Equals(input as VaultProviderStatsInfo);
        }

        /// <summary>
        /// Returns true if VaultProviderStatsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultProviderStatsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultProviderStatsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangeRate == input.ChangeRate ||
                    (this.ChangeRate != null &&
                    this.ChangeRate.Equals(input.ChangeRate))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.ReadBandwidth == input.ReadBandwidth ||
                    (this.ReadBandwidth != null &&
                    this.ReadBandwidth.Equals(input.ReadBandwidth))
                ) && 
                (
                    this.StatsByEnv == input.StatsByEnv ||
                    this.StatsByEnv != null &&
                    this.StatsByEnv.Equals(input.StatsByEnv)
                ) && 
                (
                    this.VaultGroup == input.VaultGroup ||
                    (this.VaultGroup != null &&
                    this.VaultGroup.Equals(input.VaultGroup))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.VaultType == input.VaultType ||
                    (this.VaultType != null &&
                    this.VaultType.Equals(input.VaultType))
                ) && 
                (
                    this.Vaultname == input.Vaultname ||
                    (this.Vaultname != null &&
                    this.Vaultname.Equals(input.Vaultname))
                ) && 
                (
                    this.WriteBandwidth == input.WriteBandwidth ||
                    (this.WriteBandwidth != null &&
                    this.WriteBandwidth.Equals(input.WriteBandwidth))
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
                if (this.ChangeRate != null)
                    hashCode = hashCode * 59 + this.ChangeRate.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.ReadBandwidth != null)
                    hashCode = hashCode * 59 + this.ReadBandwidth.GetHashCode();
                if (this.StatsByEnv != null)
                    hashCode = hashCode * 59 + this.StatsByEnv.GetHashCode();
                if (this.VaultGroup != null)
                    hashCode = hashCode * 59 + this.VaultGroup.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultType != null)
                    hashCode = hashCode * 59 + this.VaultType.GetHashCode();
                if (this.Vaultname != null)
                    hashCode = hashCode * 59 + this.Vaultname.GetHashCode();
                if (this.WriteBandwidth != null)
                    hashCode = hashCode * 59 + this.WriteBandwidth.GetHashCode();
                return hashCode;
            }
        }

    }

}

