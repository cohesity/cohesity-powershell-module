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
    /// QuotaAndUsageInView
    /// </summary>
    [DataContract]
    public partial class QuotaAndUsageInView :  IEquatable<QuotaAndUsageInView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaAndUsageInView" /> class.
        /// </summary>
        /// <param name="quota">User quota policy applied to this user..</param>
        /// <param name="usageBytes">Usage in bytes of this user in this view..</param>
        /// <param name="viewId">The usage and quota policy information of this user for this view..</param>
        /// <param name="viewName">View name..</param>
        public QuotaAndUsageInView(QuotaPolicy quota = default(QuotaPolicy), long? usageBytes = default(long?), long? viewId = default(long?), string viewName = default(string))
        {
            this.Quota = quota;
            this.UsageBytes = usageBytes;
            this.ViewId = viewId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// User quota policy applied to this user.
        /// </summary>
        /// <value>User quota policy applied to this user.</value>
        [DataMember(Name="quota", EmitDefaultValue=false)]
        public QuotaPolicy Quota { get; set; }

        /// <summary>
        /// Usage in bytes of this user in this view.
        /// </summary>
        /// <value>Usage in bytes of this user in this view.</value>
        [DataMember(Name="usageBytes", EmitDefaultValue=false)]
        public long? UsageBytes { get; set; }

        /// <summary>
        /// The usage and quota policy information of this user for this view.
        /// </summary>
        /// <value>The usage and quota policy information of this user for this view.</value>
        [DataMember(Name="viewId", EmitDefaultValue=false)]
        public long? ViewId { get; set; }

        /// <summary>
        /// View name.
        /// </summary>
        /// <value>View name.</value>
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
            return this.Equals(input as QuotaAndUsageInView);
        }

        /// <summary>
        /// Returns true if QuotaAndUsageInView instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaAndUsageInView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaAndUsageInView input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quota == input.Quota ||
                    (this.Quota != null &&
                    this.Quota.Equals(input.Quota))
                ) && 
                (
                    this.UsageBytes == input.UsageBytes ||
                    (this.UsageBytes != null &&
                    this.UsageBytes.Equals(input.UsageBytes))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
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
                if (this.Quota != null)
                    hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.UsageBytes != null)
                    hashCode = hashCode * 59 + this.UsageBytes.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

