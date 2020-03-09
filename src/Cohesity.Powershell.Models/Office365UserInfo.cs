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
        /// Initializes a new instance of the <see cref="Office365UserInfo" /> class.
        /// </summary>
        /// <param name="department">Specifies the department within the enterprise of the Office365 user..</param>
        /// <param name="graphUuid">Specifies the MS Graph UUID for the given user entity..</param>
        /// <param name="mailboxSize">Specifies the size of the Outlook Mailbox associated with this Office365 entity..</param>
        /// <param name="oneDriveId">Specifies the Id of the OneDrive associated with the this Office 365 entity..</param>
        /// <param name="oneDriveSize">Specifies the size of the OneDrive associated with this Office365 entity..</param>
        public Office365UserInfo(string department = default(string), string graphUuid = default(string), long? mailboxSize = default(long?), string oneDriveId = default(string), long? oneDriveSize = default(long?))
        {
            this.Department = department;
            this.GraphUuid = graphUuid;
            this.MailboxSize = mailboxSize;
            this.OneDriveId = oneDriveId;
            this.OneDriveSize = oneDriveSize;
            this.Department = department;
            this.GraphUuid = graphUuid;
            this.MailboxSize = mailboxSize;
            this.OneDriveId = oneDriveId;
            this.OneDriveSize = oneDriveSize;
        }
        
        /// <summary>
        /// Specifies the department within the enterprise of the Office365 user.
        /// </summary>
        /// <value>Specifies the department within the enterprise of the Office365 user.</value>
        [DataMember(Name="department", EmitDefaultValue=true)]
        public string Department { get; set; }

        /// <summary>
        /// Specifies the MS Graph UUID for the given user entity.
        /// </summary>
        /// <value>Specifies the MS Graph UUID for the given user entity.</value>
        [DataMember(Name="graphUuid", EmitDefaultValue=true)]
        public string GraphUuid { get; set; }

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
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.GraphUuid == input.GraphUuid ||
                    (this.GraphUuid != null &&
                    this.GraphUuid.Equals(input.GraphUuid))
                ) && 
                (
                    this.MailboxSize == input.MailboxSize ||
                    (this.MailboxSize != null &&
                    this.MailboxSize.Equals(input.MailboxSize))
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
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.GraphUuid != null)
                    hashCode = hashCode * 59 + this.GraphUuid.GetHashCode();
                if (this.MailboxSize != null)
                    hashCode = hashCode * 59 + this.MailboxSize.GetHashCode();
                if (this.OneDriveId != null)
                    hashCode = hashCode * 59 + this.OneDriveId.GetHashCode();
                if (this.OneDriveSize != null)
                    hashCode = hashCode * 59 + this.OneDriveSize.GetHashCode();
                return hashCode;
            }
        }

    }

}

