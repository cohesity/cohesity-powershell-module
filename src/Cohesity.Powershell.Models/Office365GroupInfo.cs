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
    /// Specifies information about a M365 Group.
    /// </summary>
    [DataContract]
    public partial class Office365GroupInfo :  IEquatable<Office365GroupInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365GroupInfo" /> class.
        /// </summary>
        /// <param name="isMailEnabled">Specifies whether the Group is mail enabled. Mail enabled groups are used within Microsoft to distribute messages..</param>
        /// <param name="isSecurityEnabled">Specifies whether the Group is security enabled. Security enabled groups are used to grant access permissions to resources in Exchange and Active Directory..</param>
        /// <param name="memberCount">Specifies the count of members within the Group..</param>
        /// <param name="visibility">Specifies the visibility of the Group..</param>
        public Office365GroupInfo(bool? isMailEnabled = default(bool?), bool? isSecurityEnabled = default(bool?), long? memberCount = default(long?), string visibility = default(string))
        {
            this.IsMailEnabled = isMailEnabled;
            this.IsSecurityEnabled = isSecurityEnabled;
            this.MemberCount = memberCount;
            this.Visibility = visibility;
            this.IsMailEnabled = isMailEnabled;
            this.IsSecurityEnabled = isSecurityEnabled;
            this.MemberCount = memberCount;
            this.Visibility = visibility;
        }
        
        /// <summary>
        /// Specifies whether the Group is mail enabled. Mail enabled groups are used within Microsoft to distribute messages.
        /// </summary>
        /// <value>Specifies whether the Group is mail enabled. Mail enabled groups are used within Microsoft to distribute messages.</value>
        [DataMember(Name="isMailEnabled", EmitDefaultValue=true)]
        public bool? IsMailEnabled { get; set; }

        /// <summary>
        /// Specifies whether the Group is security enabled. Security enabled groups are used to grant access permissions to resources in Exchange and Active Directory.
        /// </summary>
        /// <value>Specifies whether the Group is security enabled. Security enabled groups are used to grant access permissions to resources in Exchange and Active Directory.</value>
        [DataMember(Name="isSecurityEnabled", EmitDefaultValue=true)]
        public bool? IsSecurityEnabled { get; set; }

        /// <summary>
        /// Specifies the count of members within the Group.
        /// </summary>
        /// <value>Specifies the count of members within the Group.</value>
        [DataMember(Name="memberCount", EmitDefaultValue=true)]
        public long? MemberCount { get; set; }

        /// <summary>
        /// Specifies the visibility of the Group.
        /// </summary>
        /// <value>Specifies the visibility of the Group.</value>
        [DataMember(Name="visibility", EmitDefaultValue=true)]
        public string Visibility { get; set; }

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
            return this.Equals(input as Office365GroupInfo);
        }

        /// <summary>
        /// Returns true if Office365GroupInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365GroupInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365GroupInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMailEnabled == input.IsMailEnabled ||
                    (this.IsMailEnabled != null &&
                    this.IsMailEnabled.Equals(input.IsMailEnabled))
                ) && 
                (
                    this.IsSecurityEnabled == input.IsSecurityEnabled ||
                    (this.IsSecurityEnabled != null &&
                    this.IsSecurityEnabled.Equals(input.IsSecurityEnabled))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.IsMailEnabled != null)
                    hashCode = hashCode * 59 + this.IsMailEnabled.GetHashCode();
                if (this.IsSecurityEnabled != null)
                    hashCode = hashCode * 59 + this.IsSecurityEnabled.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                return hashCode;
            }
        }

    }

}

