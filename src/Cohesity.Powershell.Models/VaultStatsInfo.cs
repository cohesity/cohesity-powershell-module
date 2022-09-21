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
    public partial class VaultStatsInfo :  IEquatable<VaultStatsInfo>
    {
        /// <summary>
        /// Specifies the Vault type.
        /// </summary>
        /// <value>Specifies the Vault type.</value>
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
        /// Specifies the Vault type.
        /// </summary>
        /// <value>Specifies the Vault type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultStatsInfo" /> class.
        /// </summary>
        /// <param name="id">Specifies the Vault Id..</param>
        /// <param name="name">Specifies the Vault name..</param>
        /// <param name="type">Specifies the Vault type..</param>
        /// <param name="usageBytes">Specifies the bytes used by the Vault..</param>
        public VaultStatsInfo(long? id = default(long?), string name = default(string), TypeEnum? type = default(TypeEnum?), long? usageBytes = default(long?))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.UsageBytes = usageBytes;
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.UsageBytes = usageBytes;
        }
        
        /// <summary>
        /// Specifies the Vault Id.
        /// </summary>
        /// <value>Specifies the Vault Id.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the Vault name.
        /// </summary>
        /// <value>Specifies the Vault name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the bytes used by the Vault.
        /// </summary>
        /// <value>Specifies the bytes used by the Vault.</value>
        [DataMember(Name="usageBytes", EmitDefaultValue=true)]
        public long? UsageBytes { get; set; }

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
            return this.Equals(input as VaultStatsInfo);
        }

        /// <summary>
        /// Returns true if VaultStatsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultStatsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultStatsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.UsageBytes == input.UsageBytes ||
                    (this.UsageBytes != null &&
                    this.UsageBytes.Equals(input.UsageBytes))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UsageBytes != null)
                    hashCode = hashCode * 59 + this.UsageBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

