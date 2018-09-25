// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// UserQuotaSummaryForUser
    /// </summary>
    [DataContract]
    public partial class UserQuotaSummaryForUser :  IEquatable<UserQuotaSummaryForUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserQuotaSummaryForUser" /> class.
        /// </summary>
        /// <param name="numViewsAboveAlertThreshold">Number of views in which user has exceeded alert threshold limit..</param>
        /// <param name="numViewsAboveHardLimit">Number of views in which the user has exceeded hard limit..</param>
        /// <param name="totalNumViews">Total number of views in which the user has a quota policy specified or has non-zero usage..</param>
        public UserQuotaSummaryForUser(int? numViewsAboveAlertThreshold = default(int?), int? numViewsAboveHardLimit = default(int?), int? totalNumViews = default(int?))
        {
            this.NumViewsAboveAlertThreshold = numViewsAboveAlertThreshold;
            this.NumViewsAboveHardLimit = numViewsAboveHardLimit;
            this.TotalNumViews = totalNumViews;
        }
        
        /// <summary>
        /// Number of views in which user has exceeded alert threshold limit.
        /// </summary>
        /// <value>Number of views in which user has exceeded alert threshold limit.</value>
        [DataMember(Name="numViewsAboveAlertThreshold", EmitDefaultValue=false)]
        public int? NumViewsAboveAlertThreshold { get; set; }

        /// <summary>
        /// Number of views in which the user has exceeded hard limit.
        /// </summary>
        /// <value>Number of views in which the user has exceeded hard limit.</value>
        [DataMember(Name="numViewsAboveHardLimit", EmitDefaultValue=false)]
        public int? NumViewsAboveHardLimit { get; set; }

        /// <summary>
        /// Total number of views in which the user has a quota policy specified or has non-zero usage.
        /// </summary>
        /// <value>Total number of views in which the user has a quota policy specified or has non-zero usage.</value>
        [DataMember(Name="totalNumViews", EmitDefaultValue=false)]
        public int? TotalNumViews { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as UserQuotaSummaryForUser);
        }

        /// <summary>
        /// Returns true if UserQuotaSummaryForUser instances are equal
        /// </summary>
        /// <param name="input">Instance of UserQuotaSummaryForUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserQuotaSummaryForUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumViewsAboveAlertThreshold == input.NumViewsAboveAlertThreshold ||
                    (this.NumViewsAboveAlertThreshold != null &&
                    this.NumViewsAboveAlertThreshold.Equals(input.NumViewsAboveAlertThreshold))
                ) && 
                (
                    this.NumViewsAboveHardLimit == input.NumViewsAboveHardLimit ||
                    (this.NumViewsAboveHardLimit != null &&
                    this.NumViewsAboveHardLimit.Equals(input.NumViewsAboveHardLimit))
                ) && 
                (
                    this.TotalNumViews == input.TotalNumViews ||
                    (this.TotalNumViews != null &&
                    this.TotalNumViews.Equals(input.TotalNumViews))
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
                if (this.NumViewsAboveAlertThreshold != null)
                    hashCode = hashCode * 59 + this.NumViewsAboveAlertThreshold.GetHashCode();
                if (this.NumViewsAboveHardLimit != null)
                    hashCode = hashCode * 59 + this.NumViewsAboveHardLimit.GetHashCode();
                if (this.TotalNumViews != null)
                    hashCode = hashCode * 59 + this.TotalNumViews.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

