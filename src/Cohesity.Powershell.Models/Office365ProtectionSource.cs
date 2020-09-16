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
    /// Specifies a Protection Source in Office 365 environment.
    /// </summary>
    [DataContract]
    public partial class Office365ProtectionSource :  IEquatable<Office365ProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the Office 365 entity. Specifies the type of Office 365 entity &#39;kDomain&#39; indicates the O365 domain through which authentication occurs. &#39;kOutlook&#39; indicates the Exchange online entities. &#39;kMailbox&#39; indicates the user&#39;s mailbox account.
        /// </summary>
        /// <value>Specifies the type of the Office 365 entity. Specifies the type of Office 365 entity &#39;kDomain&#39; indicates the O365 domain through which authentication occurs. &#39;kOutlook&#39; indicates the Exchange online entities. &#39;kMailbox&#39; indicates the user&#39;s mailbox account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KDomain for value: kDomain
            /// </summary>
            [EnumMember(Value = "kDomain")]
            KDomain = 1,

            /// <summary>
            /// Enum KOutlook for value: kOutlook
            /// </summary>
            [EnumMember(Value = "kOutlook")]
            KOutlook = 2,

            /// <summary>
            /// Enum KMailbox for value: kMailbox
            /// </summary>
            [EnumMember(Value = "kMailbox")]
            KMailbox = 3,

            /// <summary>
            /// Enum KUser for value: kUser
            /// </summary>
            [EnumMember(Value = "kUser")]
            KUser = 4

        }

        /// <summary>
        /// Specifies the type of the Office 365 entity. Specifies the type of Office 365 entity &#39;kDomain&#39; indicates the O365 domain through which authentication occurs. &#39;kOutlook&#39; indicates the Exchange online entities. &#39;kMailbox&#39; indicates the user&#39;s mailbox account.
        /// </summary>
        /// <value>Specifies the type of the Office 365 entity. Specifies the type of Office 365 entity &#39;kDomain&#39; indicates the O365 domain through which authentication occurs. &#39;kOutlook&#39; indicates the Exchange online entities. &#39;kMailbox&#39; indicates the user&#39;s mailbox account.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ProtectionSource" /> class.
        /// </summary>
        /// <param name="description">Specifies the description of the Office 365 entity..</param>
        /// <param name="name">Specifies the name of the office 365 entity..</param>
        /// <param name="primarySMTPAddress">Specifies the SMTP address for the Outlook source..</param>
        /// <param name="type">Specifies the type of the Office 365 entity. Specifies the type of Office 365 entity &#39;kDomain&#39; indicates the O365 domain through which authentication occurs. &#39;kOutlook&#39; indicates the Exchange online entities. &#39;kMailbox&#39; indicates the user&#39;s mailbox account..</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="uuid">Specifies the UUID of the Office 365 entity..</param>
        public Office365ProtectionSource(string description = default(string), string name = default(string), string primarySMTPAddress = default(string), TypeEnum? type = default(TypeEnum?), Office365UserInfo userInfo = default(Office365UserInfo), string uuid = default(string))
        {
            this.Description = description;
            this.Name = name;
            this.PrimarySMTPAddress = primarySMTPAddress;
            this.Type = type;
            this.Uuid = uuid;
            this.Description = description;
            this.Name = name;
            this.PrimarySMTPAddress = primarySMTPAddress;
            this.Type = type;
            this.UserInfo = userInfo;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the description of the Office 365 entity.
        /// </summary>
        /// <value>Specifies the description of the Office 365 entity.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the name of the office 365 entity.
        /// </summary>
        /// <value>Specifies the name of the office 365 entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the SMTP address for the Outlook source.
        /// </summary>
        /// <value>Specifies the SMTP address for the Outlook source.</value>
        [DataMember(Name="primarySMTPAddress", EmitDefaultValue=true)]
        public string PrimarySMTPAddress { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public Office365UserInfo UserInfo { get; set; }

        /// <summary>
        /// Specifies the UUID of the Office 365 entity.
        /// </summary>
        /// <value>Specifies the UUID of the Office 365 entity.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as Office365ProtectionSource);
        }

        /// <summary>
        /// Returns true if Office365ProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365ProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365ProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrimarySMTPAddress == input.PrimarySMTPAddress ||
                    (this.PrimarySMTPAddress != null &&
                    this.PrimarySMTPAddress.Equals(input.PrimarySMTPAddress))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PrimarySMTPAddress != null)
                    hashCode = hashCode * 59 + this.PrimarySMTPAddress.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

