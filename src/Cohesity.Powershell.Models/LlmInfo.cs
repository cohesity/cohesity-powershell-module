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
    /// LlmInfo holds information about the llm model subscription such as if it is active or not.
    /// </summary>
    [DataContract]
    public partial class LlmInfo :  IEquatable<LlmInfo>
    {
        /// <summary>
        /// Specifies the id of LLM that was purchased.
        /// </summary>
        /// <value>Specifies the id of LLM that was purchased.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LlmIdEnum
        {
            /// <summary>
            /// Enum Std for value: Std
            /// </summary>
            [EnumMember(Value = "Std")]
            Std = 1,

            /// <summary>
            /// Enum Adv for value: Adv
            /// </summary>
            [EnumMember(Value = "Adv")]
            Adv = 2

        }

        /// <summary>
        /// Specifies the id of LLM that was purchased.
        /// </summary>
        /// <value>Specifies the id of LLM that was purchased.</value>
        [DataMember(Name="llmId", EmitDefaultValue=true)]
        public LlmIdEnum? LlmId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LlmInfo" /> class.
        /// </summary>
        /// <param name="banner">banner.</param>
        /// <param name="endDate">Specifies the end date of the subscription..</param>
        /// <param name="isActive">Specifies whether the llm subscription is active..</param>
        /// <param name="isFreeTrial">Specifies whether the subscription is free trial..</param>
        /// <param name="llmId">Specifies the id of LLM that was purchased..</param>
        /// <param name="maxNumQueries">Specifies the max number of queries..</param>
        /// <param name="productDisplayName">Display name of the Product.</param>
        /// <param name="startDate">Specifies the start date of the subscription..</param>
        /// <param name="tokenSize">Specifies the token size for the LLM type..</param>
        public LlmInfo(EntitlementBannerInfo banner = default(EntitlementBannerInfo), string endDate = default(string), bool? isActive = default(bool?), bool? isFreeTrial = default(bool?), LlmIdEnum? llmId = default(LlmIdEnum?), long? maxNumQueries = default(long?), string productDisplayName = default(string), string startDate = default(string), long? tokenSize = default(long?))
        {
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsFreeTrial = isFreeTrial;
            this.LlmId = llmId;
            this.MaxNumQueries = maxNumQueries;
            this.ProductDisplayName = productDisplayName;
            this.StartDate = startDate;
            this.TokenSize = tokenSize;
            this.Banner = banner;
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsFreeTrial = isFreeTrial;
            this.LlmId = llmId;
            this.MaxNumQueries = maxNumQueries;
            this.ProductDisplayName = productDisplayName;
            this.StartDate = startDate;
            this.TokenSize = tokenSize;
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
        /// Specifies whether the llm subscription is active.
        /// </summary>
        /// <value>Specifies whether the llm subscription is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies whether the subscription is free trial.
        /// </summary>
        /// <value>Specifies whether the subscription is free trial.</value>
        [DataMember(Name="isFreeTrial", EmitDefaultValue=true)]
        public bool? IsFreeTrial { get; set; }

        /// <summary>
        /// Specifies the max number of queries.
        /// </summary>
        /// <value>Specifies the max number of queries.</value>
        [DataMember(Name="maxNumQueries", EmitDefaultValue=true)]
        public long? MaxNumQueries { get; set; }

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
        /// Specifies the token size for the LLM type.
        /// </summary>
        /// <value>Specifies the token size for the LLM type.</value>
        [DataMember(Name="tokenSize", EmitDefaultValue=true)]
        public long? TokenSize { get; set; }

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
            return this.Equals(input as LlmInfo);
        }

        /// <summary>
        /// Returns true if LlmInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LlmInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LlmInfo input)
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
                    this.LlmId == input.LlmId ||
                    this.LlmId.Equals(input.LlmId)
                ) && 
                (
                    this.MaxNumQueries == input.MaxNumQueries ||
                    (this.MaxNumQueries != null &&
                    this.MaxNumQueries.Equals(input.MaxNumQueries))
                ) && 
                (
                    this.ProductDisplayName == input.ProductDisplayName ||
                    (this.ProductDisplayName != null &&
                    this.ProductDisplayName.Equals(input.ProductDisplayName))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TokenSize == input.TokenSize ||
                    (this.TokenSize != null &&
                    this.TokenSize.Equals(input.TokenSize))
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
                hashCode = hashCode * 59 + this.LlmId.GetHashCode();
                if (this.MaxNumQueries != null)
                    hashCode = hashCode * 59 + this.MaxNumQueries.GetHashCode();
                if (this.ProductDisplayName != null)
                    hashCode = hashCode * 59 + this.ProductDisplayName.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.TokenSize != null)
                    hashCode = hashCode * 59 + this.TokenSize.GetHashCode();
                return hashCode;
            }
        }

    }

}

