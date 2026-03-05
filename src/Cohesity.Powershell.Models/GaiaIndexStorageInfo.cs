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
    /// GaiaIndexStorageInfo holds information about the Gaia index storage (Data insights) subscription such as if it is active or not.
    /// </summary>
    [DataContract]
    public partial class GaiaIndexStorageInfo :  IEquatable<GaiaIndexStorageInfo>
    {
        /// <summary>
        /// Specifies the cloud provider for the index storage in dataplane.
        /// </summary>
        /// <value>Specifies the cloud provider for the index storage in dataplane.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProviderTypeEnum
        {
            /// <summary>
            /// Enum Aws for value: Aws
            /// </summary>
            [EnumMember(Value = "Aws")]
            Aws = 1,

            /// <summary>
            /// Enum Azure for value: Azure
            /// </summary>
            [EnumMember(Value = "Azure")]
            Azure = 2

        }

        /// <summary>
        /// Specifies the cloud provider for the index storage in dataplane.
        /// </summary>
        /// <value>Specifies the cloud provider for the index storage in dataplane.</value>
        [DataMember(Name="providerType", EmitDefaultValue=true)]
        public ProviderTypeEnum? ProviderType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GaiaIndexStorageInfo" /> class.
        /// </summary>
        /// <param name="banner">banner.</param>
        /// <param name="endDate">Specifies the end date of the subscription..</param>
        /// <param name="isActive">Specifies whether the gaia index storage subscription is active..</param>
        /// <param name="isFreeTrial">Specifies whether the subscription is free trial..</param>
        /// <param name="maxIndexingSizeBytes">Specifies the max indexing size in bytes..</param>
        /// <param name="productDisplayName">Display name of the Product.</param>
        /// <param name="providerType">Specifies the cloud provider for the index storage in dataplane..</param>
        /// <param name="startDate">Specifies the start date of the subscription..</param>
        public GaiaIndexStorageInfo(EntitlementBannerInfo banner = default(EntitlementBannerInfo), string endDate = default(string), bool? isActive = default(bool?), bool? isFreeTrial = default(bool?), long? maxIndexingSizeBytes = default(long?), string productDisplayName = default(string), ProviderTypeEnum? providerType = default(ProviderTypeEnum?), string startDate = default(string))
        {
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsFreeTrial = isFreeTrial;
            this.MaxIndexingSizeBytes = maxIndexingSizeBytes;
            this.ProductDisplayName = productDisplayName;
            this.ProviderType = providerType;
            this.StartDate = startDate;
            this.Banner = banner;
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsFreeTrial = isFreeTrial;
            this.MaxIndexingSizeBytes = maxIndexingSizeBytes;
            this.ProductDisplayName = productDisplayName;
            this.ProviderType = providerType;
            this.StartDate = startDate;
        }
        
        /// <summary>
        /// Gets or Sets Banner
        /// </summary>
        [DataMember(Name="banner", EmitDefaultValue=false)]
        public EntitlementBannerInfo Banner { get; set; }

        /// <summary>
        /// Specifies the end date of the subscription.
        /// </summary>
        /// <value>Specifies the end date of the subscription.</value>
        [DataMember(Name="endDate", EmitDefaultValue=true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Specifies whether the gaia index storage subscription is active.
        /// </summary>
        /// <value>Specifies whether the gaia index storage subscription is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies whether the subscription is free trial.
        /// </summary>
        /// <value>Specifies whether the subscription is free trial.</value>
        [DataMember(Name="isFreeTrial", EmitDefaultValue=true)]
        public bool? IsFreeTrial { get; set; }

        /// <summary>
        /// Specifies the max indexing size in bytes.
        /// </summary>
        /// <value>Specifies the max indexing size in bytes.</value>
        [DataMember(Name="maxIndexingSizeBytes", EmitDefaultValue=true)]
        public long? MaxIndexingSizeBytes { get; set; }

        /// <summary>
        /// Display name of the Product
        /// </summary>
        /// <value>Display name of the Product</value>
        [DataMember(Name="productDisplayName", EmitDefaultValue=true)]
        public string ProductDisplayName { get; set; }

        /// <summary>
        /// Specifies the start date of the subscription.
        /// </summary>
        /// <value>Specifies the start date of the subscription.</value>
        [DataMember(Name="startDate", EmitDefaultValue=true)]
        public string StartDate { get; set; }

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
            return this.Equals(input as GaiaIndexStorageInfo);
        }

        /// <summary>
        /// Returns true if GaiaIndexStorageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GaiaIndexStorageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GaiaIndexStorageInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Banner == input.Banner ||
                    (this.Banner != null &&
                    this.Banner.Equals(input.Banner))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsFreeTrial == input.IsFreeTrial ||
                    (this.IsFreeTrial != null &&
                    this.IsFreeTrial.Equals(input.IsFreeTrial))
                ) && 
                (
                    this.MaxIndexingSizeBytes == input.MaxIndexingSizeBytes ||
                    (this.MaxIndexingSizeBytes != null &&
                    this.MaxIndexingSizeBytes.Equals(input.MaxIndexingSizeBytes))
                ) && 
                (
                    this.ProductDisplayName == input.ProductDisplayName ||
                    (this.ProductDisplayName != null &&
                    this.ProductDisplayName.Equals(input.ProductDisplayName))
                ) && 
                (
                    this.ProviderType == input.ProviderType ||
                    this.ProviderType.Equals(input.ProviderType)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.Banner != null)
                    hashCode = hashCode * 59 + this.Banner.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsFreeTrial != null)
                    hashCode = hashCode * 59 + this.IsFreeTrial.GetHashCode();
                if (this.MaxIndexingSizeBytes != null)
                    hashCode = hashCode * 59 + this.MaxIndexingSizeBytes.GetHashCode();
                if (this.ProductDisplayName != null)
                    hashCode = hashCode * 59 + this.ProductDisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.ProviderType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                return hashCode;
            }
        }

    }

}

