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
    /// Specifies the Oracle Cloud Credentials to connect to an Oracle S3 Compatible vault account.  Oracle Cloud Credentials Region, Access-Key-Id and Secret-Access-Key. Oracle Cloud properties Tenant and Tier Type.
    /// </summary>
    [DataContract]
    public partial class OracleCloudCredentials :  IEquatable<OracleCloudCredentials>
    {
        /// <summary>
        /// Specifies the storage class of Oracle vault. OracleTierType specifies the storage class for Oracle. &#39;kOracleTierStandard&#39; indicates a tier type of Oracle properties that requires fast, immediate and frequent access. &#39;kOracleTierArchive&#39; indicates a tier type of Oracle properties that is rarely accesed and preserved for long times.
        /// </summary>
        /// <value>Specifies the storage class of Oracle vault. OracleTierType specifies the storage class for Oracle. &#39;kOracleTierStandard&#39; indicates a tier type of Oracle properties that requires fast, immediate and frequent access. &#39;kOracleTierArchive&#39; indicates a tier type of Oracle properties that is rarely accesed and preserved for long times.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TierTypeEnum
        {
            /// <summary>
            /// Enum KOracleTierStandard for value: kOracleTierStandard
            /// </summary>
            [EnumMember(Value = "kOracleTierStandard")]
            KOracleTierStandard = 1,

            /// <summary>
            /// Enum KOracleTierArchive for value: kOracleTierArchive
            /// </summary>
            [EnumMember(Value = "kOracleTierArchive")]
            KOracleTierArchive = 2

        }

        /// <summary>
        /// Specifies the storage class of Oracle vault. OracleTierType specifies the storage class for Oracle. &#39;kOracleTierStandard&#39; indicates a tier type of Oracle properties that requires fast, immediate and frequent access. &#39;kOracleTierArchive&#39; indicates a tier type of Oracle properties that is rarely accesed and preserved for long times.
        /// </summary>
        /// <value>Specifies the storage class of Oracle vault. OracleTierType specifies the storage class for Oracle. &#39;kOracleTierStandard&#39; indicates a tier type of Oracle properties that requires fast, immediate and frequent access. &#39;kOracleTierArchive&#39; indicates a tier type of Oracle properties that is rarely accesed and preserved for long times.</value>
        [DataMember(Name="tierType", EmitDefaultValue=true)]
        public TierTypeEnum? TierType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleCloudCredentials" /> class.
        /// </summary>
        /// <param name="accessKeyId">Specifies access key to connect to Oracle S3 Compatible vault account..</param>
        /// <param name="region">Specifies the region for Oracle S3 Compatible vault account..</param>
        /// <param name="secretAccessKey">Specifies the secret access key for Oracle S3 Compatible vault account..</param>
        /// <param name="tenant">Specifies the tenant which is part of the REST endpoints for Oracle S3 compatible vaults..</param>
        /// <param name="tierType">Specifies the storage class of Oracle vault. OracleTierType specifies the storage class for Oracle. &#39;kOracleTierStandard&#39; indicates a tier type of Oracle properties that requires fast, immediate and frequent access. &#39;kOracleTierArchive&#39; indicates a tier type of Oracle properties that is rarely accesed and preserved for long times..</param>
        public OracleCloudCredentials(string accessKeyId = default(string), string region = default(string), string secretAccessKey = default(string), string tenant = default(string), TierTypeEnum? tierType = default(TierTypeEnum?))
        {
            this.AccessKeyId = accessKeyId;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey;
            this.Tenant = tenant;
            this.TierType = tierType;
            this.AccessKeyId = accessKeyId;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey;
            this.Tenant = tenant;
            this.TierType = tierType;
        }
        
        /// <summary>
        /// Specifies access key to connect to Oracle S3 Compatible vault account.
        /// </summary>
        /// <value>Specifies access key to connect to Oracle S3 Compatible vault account.</value>
        [DataMember(Name="accessKeyId", EmitDefaultValue=true)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Specifies the region for Oracle S3 Compatible vault account.
        /// </summary>
        /// <value>Specifies the region for Oracle S3 Compatible vault account.</value>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public string Region { get; set; }

        /// <summary>
        /// Specifies the secret access key for Oracle S3 Compatible vault account.
        /// </summary>
        /// <value>Specifies the secret access key for Oracle S3 Compatible vault account.</value>
        [DataMember(Name="secretAccessKey", EmitDefaultValue=true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Specifies the tenant which is part of the REST endpoints for Oracle S3 compatible vaults.
        /// </summary>
        /// <value>Specifies the tenant which is part of the REST endpoints for Oracle S3 compatible vaults.</value>
        [DataMember(Name="tenant", EmitDefaultValue=true)]
        public string Tenant { get; set; }

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
            return this.Equals(input as OracleCloudCredentials);
        }

        /// <summary>
        /// Returns true if OracleCloudCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleCloudCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleCloudCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKeyId == input.AccessKeyId ||
                    (this.AccessKeyId != null &&
                    this.AccessKeyId.Equals(input.AccessKeyId))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SecretAccessKey == input.SecretAccessKey ||
                    (this.SecretAccessKey != null &&
                    this.SecretAccessKey.Equals(input.SecretAccessKey))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.TierType == input.TierType ||
                    this.TierType.Equals(input.TierType)
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
                if (this.AccessKeyId != null)
                    hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                hashCode = hashCode * 59 + this.TierType.GetHashCode();
                return hashCode;
            }
        }

    }

}

