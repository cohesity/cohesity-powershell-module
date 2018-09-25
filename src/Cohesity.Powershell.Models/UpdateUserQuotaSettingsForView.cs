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
    /// Specifies the parameters to update user quota metadata in a view.
    /// </summary>
    [DataContract]
    public partial class UpdateUserQuotaSettingsForView :  IEquatable<UpdateUserQuotaSettingsForView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserQuotaSettingsForView" /> class.
        /// </summary>
        /// <param name="defaultUserQuotaPolicy">The default user quota policy for this view..</param>
        /// <param name="enableUserQuota">If set, it enables/disables the user quota overrides for a view. Otherwise, it leaves it at it&#39;s previous state..</param>
        /// <param name="inheritDefaultPolicyFromViewbox">If set to true, the default_policy in view metadata will be cleared and the default policy from viewbox will take effect for all users in the view..</param>
        /// <param name="viewName">View name of input view..</param>
        public UpdateUserQuotaSettingsForView(QuotaPolicy defaultUserQuotaPolicy = default(QuotaPolicy), bool? enableUserQuota = default(bool?), bool? inheritDefaultPolicyFromViewbox = default(bool?), string viewName = default(string))
        {
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.EnableUserQuota = enableUserQuota;
            this.InheritDefaultPolicyFromViewbox = inheritDefaultPolicyFromViewbox;
            this.ViewName = viewName;
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
        /// If set to true, the default_policy in view metadata will be cleared and the default policy from viewbox will take effect for all users in the view.
        /// </summary>
        /// <value>If set to true, the default_policy in view metadata will be cleared and the default policy from viewbox will take effect for all users in the view.</value>
        [DataMember(Name="inheritDefaultPolicyFromViewbox", EmitDefaultValue=false)]
        public bool? InheritDefaultPolicyFromViewbox { get; set; }

        /// <summary>
        /// View name of input view.
        /// </summary>
        /// <value>View name of input view.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

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
            return this.Equals(input as UpdateUserQuotaSettingsForView);
        }

        /// <summary>
        /// Returns true if UpdateUserQuotaSettingsForView instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUserQuotaSettingsForView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUserQuotaSettingsForView input)
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
                ) && 
                (
                    this.InheritDefaultPolicyFromViewbox == input.InheritDefaultPolicyFromViewbox ||
                    (this.InheritDefaultPolicyFromViewbox != null &&
                    this.InheritDefaultPolicyFromViewbox.Equals(input.InheritDefaultPolicyFromViewbox))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.InheritDefaultPolicyFromViewbox != null)
                    hashCode = hashCode * 59 + this.InheritDefaultPolicyFromViewbox.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

