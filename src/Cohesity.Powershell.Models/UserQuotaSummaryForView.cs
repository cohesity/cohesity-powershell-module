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
    /// Specifies the user quota summary information/result for a view.
    /// </summary>
    [DataContract]
    public partial class UserQuotaSummaryForView :  IEquatable<UserQuotaSummaryForView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserQuotaSummaryForView" /> class.
        /// </summary>
        /// <param name="defaultUserQuotaPolicy">defaultUserQuotaPolicy.</param>
        /// <param name="numUsersAboveAlertThreshold">Number of users who has exceeded their specified alert limit..</param>
        /// <param name="numUsersAboveHardLimit">Number of users who has exceeded their specified quota hard limit..</param>
        /// <param name="totalNumUsers">Total number of users who has either a user quota policy override specified or has non-zero logical usage..</param>
        public UserQuotaSummaryForView(QuotaPolicy defaultUserQuotaPolicy = default(QuotaPolicy), long? numUsersAboveAlertThreshold = default(long?), long? numUsersAboveHardLimit = default(long?), long? totalNumUsers = default(long?))
        {
            this.NumUsersAboveAlertThreshold = numUsersAboveAlertThreshold;
            this.NumUsersAboveHardLimit = numUsersAboveHardLimit;
            this.TotalNumUsers = totalNumUsers;
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.NumUsersAboveAlertThreshold = numUsersAboveAlertThreshold;
            this.NumUsersAboveHardLimit = numUsersAboveHardLimit;
            this.TotalNumUsers = totalNumUsers;
        }
        
        /// <summary>
        /// Gets or Sets DefaultUserQuotaPolicy
        /// </summary>
        [DataMember(Name="defaultUserQuotaPolicy", EmitDefaultValue=false)]
        public QuotaPolicy DefaultUserQuotaPolicy { get; set; }

        /// <summary>
        /// Number of users who has exceeded their specified alert limit.
        /// </summary>
        /// <value>Number of users who has exceeded their specified alert limit.</value>
        [DataMember(Name="numUsersAboveAlertThreshold", EmitDefaultValue=true)]
        public long? NumUsersAboveAlertThreshold { get; set; }

        /// <summary>
        /// Number of users who has exceeded their specified quota hard limit.
        /// </summary>
        /// <value>Number of users who has exceeded their specified quota hard limit.</value>
        [DataMember(Name="numUsersAboveHardLimit", EmitDefaultValue=true)]
        public long? NumUsersAboveHardLimit { get; set; }

        /// <summary>
        /// Total number of users who has either a user quota policy override specified or has non-zero logical usage.
        /// </summary>
        /// <value>Total number of users who has either a user quota policy override specified or has non-zero logical usage.</value>
        [DataMember(Name="totalNumUsers", EmitDefaultValue=true)]
        public long? TotalNumUsers { get; set; }

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
            return this.Equals(input as UserQuotaSummaryForView);
        }

        /// <summary>
        /// Returns true if UserQuotaSummaryForView instances are equal
        /// </summary>
        /// <param name="input">Instance of UserQuotaSummaryForView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserQuotaSummaryForView input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultUserQuotaPolicy == input.DefaultUserQuotaPolicy ||
                    (this.DefaultUserQuotaPolicy != null &&
                    this.DefaultUserQuotaPolicy.Equals(input.DefaultUserQuotaPolicy))
                ) && 
                (
                    this.NumUsersAboveAlertThreshold == input.NumUsersAboveAlertThreshold ||
                    (this.NumUsersAboveAlertThreshold != null &&
                    this.NumUsersAboveAlertThreshold.Equals(input.NumUsersAboveAlertThreshold))
                ) && 
                (
                    this.NumUsersAboveHardLimit == input.NumUsersAboveHardLimit ||
                    (this.NumUsersAboveHardLimit != null &&
                    this.NumUsersAboveHardLimit.Equals(input.NumUsersAboveHardLimit))
                ) && 
                (
                    this.TotalNumUsers == input.TotalNumUsers ||
                    (this.TotalNumUsers != null &&
                    this.TotalNumUsers.Equals(input.TotalNumUsers))
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
                if (this.DefaultUserQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultUserQuotaPolicy.GetHashCode();
                if (this.NumUsersAboveAlertThreshold != null)
                    hashCode = hashCode * 59 + this.NumUsersAboveAlertThreshold.GetHashCode();
                if (this.NumUsersAboveHardLimit != null)
                    hashCode = hashCode * 59 + this.NumUsersAboveHardLimit.GetHashCode();
                if (this.TotalNumUsers != null)
                    hashCode = hashCode * 59 + this.TotalNumUsers.GetHashCode();
                return hashCode;
            }
        }

    }

}

