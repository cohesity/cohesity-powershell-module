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
    /// DMaaSSubscriptionInfo holds information about the Data Protect subscription such as if it is active or not.
    /// </summary>
    [DataContract]
    public partial class DataProtectInfo :  IEquatable<DataProtectInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataProtectInfo" /> class.
        /// </summary>
        /// <param name="endDate">Specifies the end date of the subscription..</param>
        /// <param name="isActive">Specifies whether the dmaas subscription is active..</param>
        /// <param name="isAwsSubscription">Specifies whether the subscription is AWS Subscription..</param>
        /// <param name="isCohesitySubscription">Specifies whether the subscription is a Cohesity Paid subscription..</param>
        /// <param name="isFreeTrial">Specifies whether the subscription is free trial..</param>
        /// <param name="quantity">Specifies the quantity of the subscription..</param>
        /// <param name="startDate">Specifies the start date of the subscription..</param>
        /// <param name="tiering">tiering.</param>
        public DataProtectInfo(string endDate = default(string), bool? isActive = default(bool?), bool? isAwsSubscription = default(bool?), bool? isCohesitySubscription = default(bool?), bool? isFreeTrial = default(bool?), long? quantity = default(long?), string startDate = default(string), TieringInfo tiering = default(TieringInfo))
        {
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsAwsSubscription = isAwsSubscription;
            this.IsCohesitySubscription = isCohesitySubscription;
            this.IsFreeTrial = isFreeTrial;
            this.Quantity = quantity;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsAwsSubscription = isAwsSubscription;
            this.IsCohesitySubscription = isCohesitySubscription;
            this.IsFreeTrial = isFreeTrial;
            this.Quantity = quantity;
            this.StartDate = startDate;
            this.Tiering = tiering;
        }
        
        /// <summary>
        /// Specifies the end date of the subscription.
        /// </summary>
        /// <value>Specifies the end date of the subscription.</value>
        [DataMember(Name="endDate", EmitDefaultValue=true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Specifies whether the dmaas subscription is active.
        /// </summary>
        /// <value>Specifies whether the dmaas subscription is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies whether the subscription is AWS Subscription.
        /// </summary>
        /// <value>Specifies whether the subscription is AWS Subscription.</value>
        [DataMember(Name="isAwsSubscription", EmitDefaultValue=true)]
        public bool? IsAwsSubscription { get; set; }

        /// <summary>
        /// Specifies whether the subscription is a Cohesity Paid subscription.
        /// </summary>
        /// <value>Specifies whether the subscription is a Cohesity Paid subscription.</value>
        [DataMember(Name="isCohesitySubscription", EmitDefaultValue=true)]
        public bool? IsCohesitySubscription { get; set; }

        /// <summary>
        /// Specifies whether the subscription is free trial.
        /// </summary>
        /// <value>Specifies whether the subscription is free trial.</value>
        [DataMember(Name="isFreeTrial", EmitDefaultValue=true)]
        public bool? IsFreeTrial { get; set; }

        /// <summary>
        /// Specifies the quantity of the subscription.
        /// </summary>
        /// <value>Specifies the quantity of the subscription.</value>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public long? Quantity { get; set; }

        /// <summary>
        /// Specifies the start date of the subscription.
        /// </summary>
        /// <value>Specifies the start date of the subscription.</value>
        [DataMember(Name="startDate", EmitDefaultValue=true)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Tiering
        /// </summary>
        [DataMember(Name="tiering", EmitDefaultValue=false)]
        public TieringInfo Tiering { get; set; }

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
            return this.Equals(input as DataProtectInfo);
        }

        /// <summary>
        /// Returns true if DataProtectInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DataProtectInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataProtectInfo input)
        {
            if (input == null)
                return false;

            return 
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
                    this.IsAwsSubscription == input.IsAwsSubscription ||
                    (this.IsAwsSubscription != null &&
                    this.IsAwsSubscription.Equals(input.IsAwsSubscription))
                ) && 
                (
                    this.IsCohesitySubscription == input.IsCohesitySubscription ||
                    (this.IsCohesitySubscription != null &&
                    this.IsCohesitySubscription.Equals(input.IsCohesitySubscription))
                ) && 
                (
                    this.IsFreeTrial == input.IsFreeTrial ||
                    (this.IsFreeTrial != null &&
                    this.IsFreeTrial.Equals(input.IsFreeTrial))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Tiering == input.Tiering ||
                    (this.Tiering != null &&
                    this.Tiering.Equals(input.Tiering))
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsAwsSubscription != null)
                    hashCode = hashCode * 59 + this.IsAwsSubscription.GetHashCode();
                if (this.IsCohesitySubscription != null)
                    hashCode = hashCode * 59 + this.IsCohesitySubscription.GetHashCode();
                if (this.IsFreeTrial != null)
                    hashCode = hashCode * 59 + this.IsFreeTrial.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Tiering != null)
                    hashCode = hashCode * 59 + this.Tiering.GetHashCode();
                return hashCode;
            }
        }

    }

}

