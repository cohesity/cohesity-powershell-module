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
    /// Specifies the params to create and edit a user quota policy in a view.
    /// </summary>
    [DataContract]
    public partial class ViewUserQuotaParameters :  IEquatable<ViewUserQuotaParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewUserQuotaParameters" /> class.
        /// </summary>
        /// <param name="userQuotaPolicy">The user quota policies that need to be updated..</param>
        /// <param name="viewName">View name of input view..</param>
        public ViewUserQuotaParameters(UserQuota userQuotaPolicy = default(UserQuota), string viewName = default(string))
        {
            this.UserQuotaPolicy = userQuotaPolicy;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// The user quota policies that need to be updated.
        /// </summary>
        /// <value>The user quota policies that need to be updated.</value>
        [DataMember(Name="userQuotaPolicy", EmitDefaultValue=false)]
        public UserQuota UserQuotaPolicy { get; set; }

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
            return this.Equals(input as ViewUserQuotaParameters);
        }

        /// <summary>
        /// Returns true if ViewUserQuotaParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewUserQuotaParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewUserQuotaParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserQuotaPolicy == input.UserQuotaPolicy ||
                    (this.UserQuotaPolicy != null &&
                    this.UserQuotaPolicy.Equals(input.UserQuotaPolicy))
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
                if (this.UserQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.UserQuotaPolicy.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

