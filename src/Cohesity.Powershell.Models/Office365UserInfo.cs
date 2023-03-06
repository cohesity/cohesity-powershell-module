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
    /// Specifies information about an Office365 user.
    /// </summary>
    [DataContract]
    public partial class Office365UserInfo :  IEquatable<Office365UserInfo>
    {
        /// <summary>
        /// Specifies the type of mailbox associated Specifies the type of user mailbox. &#39;kUserMailbox&#39; indicates that the user has been assigned an individual mailbox. &#39;kSharedMailbox&#39; indicates that the user has been assigned a shared mailbox.
        /// </summary>
        /// <value>Specifies the type of mailbox associated Specifies the type of user mailbox. &#39;kUserMailbox&#39; indicates that the user has been assigned an individual mailbox. &#39;kSharedMailbox&#39; indicates that the user has been assigned a shared mailbox.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MailboxTypeEnum
        {
            /// <summary>
            /// Enum KUserMailbox for value: kUserMailbox
            /// </summary>
            [EnumMember(Value = "kUserMailbox")]
            KUserMailbox = 1,

            /// <summary>
            /// Enum KSharedMailbox for value: kSharedMailbox
            /// </summary>
            [EnumMember(Value = "kSharedMailbox")]
            KSharedMailbox = 2

        }

        /// <summary>
        /// Specifies the type of mailbox associated Specifies the type of user mailbox. &#39;kUserMailbox&#39; indicates that the user has been assigned an individual mailbox. &#39;kSharedMailbox&#39; indicates that the user has been assigned a shared mailbox.
        /// </summary>
        /// <value>Specifies the type of mailbox associated Specifies the type of user mailbox. &#39;kUserMailbox&#39; indicates that the user has been assigned an individual mailbox. &#39;kSharedMailbox&#39; indicates that the user has been assigned a shared mailbox.</value>
        [DataMember(Name="mailboxType", EmitDefaultValue=true)]
        public MailboxTypeEnum? MailboxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365UserInfo" /> class.
        /// </summary>
        /// <param name="city">Specifies the city in which the Office365 user is located..</param>
        /// <param name="country">Specifies the country/region in which the Office365 user is located..</param>
        /// <param name="department">Specifies the department within the enterprise of the Office365 user..</param>
        /// <param name="designation">Specifies the designation of the Office365 user..</param>
        /// <param name="graphUuid">Specifies the MS Graph UUID for the given user entity..</param>
        /// <param name="isMailboxEnabled">Specifies whether the Office365 user has a mailbox associated..</param>
        /// <param name="isOneDriveEnabled">Specifies whether the Office365 user has a OneDrive associated..</param>
        /// <param name="mailboxSize">Specifies the size of the Outlook Mailbox associated with this Office365 entity..</param>
        /// <param name="mailboxType">Specifies the type of mailbox associated Specifies the type of user mailbox. &#39;kUserMailbox&#39; indicates that the user has been assigned an individual mailbox. &#39;kSharedMailbox&#39; indicates that the user has been assigned a shared mailbox..</param>
        /// <param name="oneDriveId">Specifies the Id of the OneDrive associated with the this Office 365 entity..</param>
        /// <param name="oneDriveSize">Specifies the size of the OneDrive associated with this Office365 entity..</param>
        public Office365UserInfo(string city = default(string), string country = default(string), string department = default(string), string designation = default(string), string graphUuid = default(string), bool? isMailboxEnabled = default(bool?), bool? isOneDriveEnabled = default(bool?), long? mailboxSize = default(long?), MailboxTypeEnum? mailboxType = default(MailboxTypeEnum?), string oneDriveId = default(string), long? oneDriveSize = default(long?))
        {
            this.City = city;
            this.Country = country;
            this.Department = department;
            this.Designation = designation;
            this.GraphUuid = graphUuid;
            this.IsMailboxEnabled = isMailboxEnabled;
            this.IsOneDriveEnabled = isOneDriveEnabled;
            this.MailboxSize = mailboxSize;
            this.MailboxType = mailboxType;
            this.OneDriveId = oneDriveId;
            this.OneDriveSize = oneDriveSize;
            this.City = city;
            this.Country = country;
            this.Department = department;
            this.Designation = designation;
            this.GraphUuid = graphUuid;
            this.IsMailboxEnabled = isMailboxEnabled;
            this.IsOneDriveEnabled = isOneDriveEnabled;
            this.MailboxSize = mailboxSize;
            this.MailboxType = mailboxType;
            this.OneDriveId = oneDriveId;
            this.OneDriveSize = oneDriveSize;
        }
        
        /// <summary>
        /// Specifies the city in which the Office365 user is located.
        /// </summary>
        /// <value>Specifies the city in which the Office365 user is located.</value>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }

        /// <summary>
        /// Specifies the country/region in which the Office365 user is located.
        /// </summary>
        /// <value>Specifies the country/region in which the Office365 user is located.</value>
        [DataMember(Name="country", EmitDefaultValue=true)]
        public string Country { get; set; }

        /// <summary>
        /// Specifies the department within the enterprise of the Office365 user.
        /// </summary>
        /// <value>Specifies the department within the enterprise of the Office365 user.</value>
        [DataMember(Name="department", EmitDefaultValue=true)]
        public string Department { get; set; }

        /// <summary>
        /// Specifies the designation of the Office365 user.
        /// </summary>
        /// <value>Specifies the designation of the Office365 user.</value>
        [DataMember(Name="designation", EmitDefaultValue=true)]
        public string Designation { get; set; }

        /// <summary>
        /// Specifies the MS Graph UUID for the given user entity.
        /// </summary>
        /// <value>Specifies the MS Graph UUID for the given user entity.</value>
        [DataMember(Name="graphUuid", EmitDefaultValue=true)]
        public string GraphUuid { get; set; }

        /// <summary>
        /// Specifies whether the Office365 user has a mailbox associated.
        /// </summary>
        /// <value>Specifies whether the Office365 user has a mailbox associated.</value>
        [DataMember(Name="isMailboxEnabled", EmitDefaultValue=true)]
        public bool? IsMailboxEnabled { get; set; }

        /// <summary>
        /// Specifies whether the Office365 user has a OneDrive associated.
        /// </summary>
        /// <value>Specifies whether the Office365 user has a OneDrive associated.</value>
        [DataMember(Name="isOneDriveEnabled", EmitDefaultValue=true)]
        public bool? IsOneDriveEnabled { get; set; }

        /// <summary>
        /// Specifies the size of the Outlook Mailbox associated with this Office365 entity.
        /// </summary>
        /// <value>Specifies the size of the Outlook Mailbox associated with this Office365 entity.</value>
        [DataMember(Name="mailboxSize", EmitDefaultValue=true)]
        public long? MailboxSize { get; set; }

        /// <summary>
        /// Specifies the Id of the OneDrive associated with the this Office 365 entity.
        /// </summary>
        /// <value>Specifies the Id of the OneDrive associated with the this Office 365 entity.</value>
        [DataMember(Name="oneDriveId", EmitDefaultValue=true)]
        public string OneDriveId { get; set; }

        /// <summary>
        /// Specifies the size of the OneDrive associated with this Office365 entity.
        /// </summary>
        /// <value>Specifies the size of the OneDrive associated with this Office365 entity.</value>
        [DataMember(Name="oneDriveSize", EmitDefaultValue=true)]
        public long? OneDriveSize { get; set; }

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
            return this.Equals(input as Office365UserInfo);
        }

        /// <summary>
        /// Returns true if Office365UserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365UserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365UserInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Designation == input.Designation ||
                    (this.Designation != null &&
                    this.Designation.Equals(input.Designation))
                ) && 
                (
                    this.GraphUuid == input.GraphUuid ||
                    (this.GraphUuid != null &&
                    this.GraphUuid.Equals(input.GraphUuid))
                ) && 
                (
                    this.IsMailboxEnabled == input.IsMailboxEnabled ||
                    (this.IsMailboxEnabled != null &&
                    this.IsMailboxEnabled.Equals(input.IsMailboxEnabled))
                ) && 
                (
                    this.IsOneDriveEnabled == input.IsOneDriveEnabled ||
                    (this.IsOneDriveEnabled != null &&
                    this.IsOneDriveEnabled.Equals(input.IsOneDriveEnabled))
                ) && 
                (
                    this.MailboxSize == input.MailboxSize ||
                    (this.MailboxSize != null &&
                    this.MailboxSize.Equals(input.MailboxSize))
                ) && 
                (
                    this.MailboxType == input.MailboxType ||
                    this.MailboxType.Equals(input.MailboxType)
                ) && 
                (
                    this.OneDriveId == input.OneDriveId ||
                    (this.OneDriveId != null &&
                    this.OneDriveId.Equals(input.OneDriveId))
                ) && 
                (
                    this.OneDriveSize == input.OneDriveSize ||
                    (this.OneDriveSize != null &&
                    this.OneDriveSize.Equals(input.OneDriveSize))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Designation != null)
                    hashCode = hashCode * 59 + this.Designation.GetHashCode();
                if (this.GraphUuid != null)
                    hashCode = hashCode * 59 + this.GraphUuid.GetHashCode();
                if (this.IsMailboxEnabled != null)
                    hashCode = hashCode * 59 + this.IsMailboxEnabled.GetHashCode();
                if (this.IsOneDriveEnabled != null)
                    hashCode = hashCode * 59 + this.IsOneDriveEnabled.GetHashCode();
                if (this.MailboxSize != null)
                    hashCode = hashCode * 59 + this.MailboxSize.GetHashCode();
                hashCode = hashCode * 59 + this.MailboxType.GetHashCode();
                if (this.OneDriveId != null)
                    hashCode = hashCode * 59 + this.OneDriveId.GetHashCode();
                if (this.OneDriveSize != null)
                    hashCode = hashCode * 59 + this.OneDriveSize.GetHashCode();
                return hashCode;
            }
        }

    }

}

