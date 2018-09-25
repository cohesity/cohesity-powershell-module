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
    /// UserQuotaSettings
    /// </summary>
    [DataContract]
    public partial class UserQuotaSettings :  IEquatable<UserQuotaSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserQuotaSettings" /> class.
        /// </summary>
        /// <param name="defaultUserQuotaPolicy">The default user quota policy for this view..</param>
        /// <param name="enableUserQuota">If set, it enables/disables the user quota overrides for a view. Otherwise, it leaves it at it&#39;s previous state..</param>
        public UserQuotaSettings(QuotaPolicy defaultUserQuotaPolicy = default(QuotaPolicy), bool? enableUserQuota = default(bool?))
        {
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.EnableUserQuota = enableUserQuota;
        }
        
        /// <summary>
        /// The default user quota policy for this view.
        /// </summary>
        /// <value>The default user quota policy for this view.</value>
        [DataMember(Name="defaultUserQuotaPolicy", EmitDefaultValue=false)]
        public QuotaPolicy DefaultUserQuotaPolicy { get; set; }

        /// <summary>
        /// If set, it enables/disables the user quota overrides for a view. Otherwise, it leaves it at it&#39;s previous state.
        /// </summary>
        /// <value>If set, it enables/disables the user quota overrides for a view. Otherwise, it leaves it at it&#39;s previous state.</value>
        [DataMember(Name="enableUserQuota", EmitDefaultValue=false)]
        public bool? EnableUserQuota { get; set; }

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
            return this.Equals(input as UserQuotaSettings);
        }

        /// <summary>
        /// Returns true if UserQuotaSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UserQuotaSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserQuotaSettings input)
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
                    this.EnableUserQuota == input.EnableUserQuota ||
                    (this.EnableUserQuota != null &&
                    this.EnableUserQuota.Equals(input.EnableUserQuota))
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
                if (this.EnableUserQuota != null)
                    hashCode = hashCode * 59 + this.EnableUserQuota.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

