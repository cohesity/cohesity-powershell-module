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
    /// Specifies the cloud credentials to connect to a Microsoft Azure service account.
    /// </summary>
    [DataContract]
    public partial class AzureCloudCredentials :  IEquatable<AzureCloudCredentials>
    {
        /// <summary>
        /// Specifies the storage class of Azure. AzureTierType specifies the storage class for Azure. &#39;kAzureTierHot&#39; indicates a tier type of Azure properties that is accessed frequently. &#39;kAzureTierCool&#39; indicates a tier type of Azure properties that is accessed less frequently, and stored for at least 30 days. &#39;kAzureTierArchive&#39; indicates a tier type of Azure properties that is accessed rarely and stored for at least 180 days.
        /// </summary>
        /// <value>Specifies the storage class of Azure. AzureTierType specifies the storage class for Azure. &#39;kAzureTierHot&#39; indicates a tier type of Azure properties that is accessed frequently. &#39;kAzureTierCool&#39; indicates a tier type of Azure properties that is accessed less frequently, and stored for at least 30 days. &#39;kAzureTierArchive&#39; indicates a tier type of Azure properties that is accessed rarely and stored for at least 180 days.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TierTypeEnum
        {
            /// <summary>
            /// Enum KAzureTierHot for value: kAzureTierHot
            /// </summary>
            [EnumMember(Value = "kAzureTierHot")]
            KAzureTierHot = 1,

            /// <summary>
            /// Enum KAzureTierCool for value: kAzureTierCool
            /// </summary>
            [EnumMember(Value = "kAzureTierCool")]
            KAzureTierCool = 2,

            /// <summary>
            /// Enum KAzureTierArchive for value: kAzureTierArchive
            /// </summary>
            [EnumMember(Value = "kAzureTierArchive")]
            KAzureTierArchive = 3

        }

        /// <summary>
        /// Specifies the storage class of Azure. AzureTierType specifies the storage class for Azure. &#39;kAzureTierHot&#39; indicates a tier type of Azure properties that is accessed frequently. &#39;kAzureTierCool&#39; indicates a tier type of Azure properties that is accessed less frequently, and stored for at least 30 days. &#39;kAzureTierArchive&#39; indicates a tier type of Azure properties that is accessed rarely and stored for at least 180 days.
        /// </summary>
        /// <value>Specifies the storage class of Azure. AzureTierType specifies the storage class for Azure. &#39;kAzureTierHot&#39; indicates a tier type of Azure properties that is accessed frequently. &#39;kAzureTierCool&#39; indicates a tier type of Azure properties that is accessed less frequently, and stored for at least 30 days. &#39;kAzureTierArchive&#39; indicates a tier type of Azure properties that is accessed rarely and stored for at least 180 days.</value>
        [DataMember(Name="tierType", EmitDefaultValue=false)]
        public TierTypeEnum? TierType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureCloudCredentials" /> class.
        /// </summary>
        /// <param name="storageAccessKey">Specifies the access key to use when accessing a storage tier in a Azure cloud service..</param>
        /// <param name="storageAccountName">Specifies the account name to use when accessing a storage tier in a Azure cloud service..</param>
        /// <param name="tierType">Specifies the storage class of Azure. AzureTierType specifies the storage class for Azure. &#39;kAzureTierHot&#39; indicates a tier type of Azure properties that is accessed frequently. &#39;kAzureTierCool&#39; indicates a tier type of Azure properties that is accessed less frequently, and stored for at least 30 days. &#39;kAzureTierArchive&#39; indicates a tier type of Azure properties that is accessed rarely and stored for at least 180 days..</param>
        /// <param name="tiers">Specifies the list of all tiers for Amazon account..</param>
        public AzureCloudCredentials(string storageAccessKey = default(string), string storageAccountName = default(string), TierTypeEnum? tierType = default(TierTypeEnum?), List<string> tiers = default(List<string>))
        {
            this.StorageAccessKey = storageAccessKey;
            this.StorageAccountName = storageAccountName;
            this.TierType = tierType;
            this.Tiers = tiers;
        }
        
        /// <summary>
        /// Specifies the access key to use when accessing a storage tier in a Azure cloud service.
        /// </summary>
        /// <value>Specifies the access key to use when accessing a storage tier in a Azure cloud service.</value>
        [DataMember(Name="storageAccessKey", EmitDefaultValue=false)]
        public string StorageAccessKey { get; set; }

        /// <summary>
        /// Specifies the account name to use when accessing a storage tier in a Azure cloud service.
        /// </summary>
        /// <value>Specifies the account name to use when accessing a storage tier in a Azure cloud service.</value>
        [DataMember(Name="storageAccountName", EmitDefaultValue=false)]
        public string StorageAccountName { get; set; }


        /// <summary>
        /// Specifies the list of all tiers for Amazon account.
        /// </summary>
        /// <value>Specifies the list of all tiers for Amazon account.</value>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<string> Tiers { get; set; }

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
            return this.Equals(input as AzureCloudCredentials);
        }

        /// <summary>
        /// Returns true if AzureCloudCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureCloudCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureCloudCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorageAccessKey == input.StorageAccessKey ||
                    (this.StorageAccessKey != null &&
                    this.StorageAccessKey.Equals(input.StorageAccessKey))
                ) && 
                (
                    this.StorageAccountName == input.StorageAccountName ||
                    (this.StorageAccountName != null &&
                    this.StorageAccountName.Equals(input.StorageAccountName))
                ) && 
                (
                    this.TierType == input.TierType ||
                    (this.TierType != null &&
                    this.TierType.Equals(input.TierType))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    this.Tiers.Equals(input.Tiers)
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
                if (this.StorageAccessKey != null)
                    hashCode = hashCode * 59 + this.StorageAccessKey.GetHashCode();
                if (this.StorageAccountName != null)
                    hashCode = hashCode * 59 + this.StorageAccountName.GetHashCode();
                if (this.TierType != null)
                    hashCode = hashCode * 59 + this.TierType.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
                return hashCode;
            }
        }

    }

}

