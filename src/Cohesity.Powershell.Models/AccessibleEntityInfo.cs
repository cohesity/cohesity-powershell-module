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
    /// AccessibleEntityInfo
    /// </summary>
    [DataContract]
    public partial class AccessibleEntityInfo :  IEquatable<AccessibleEntityInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessibleEntityInfo" /> class.
        /// </summary>
        /// <param name="mailboxEntityInfo">mailboxEntityInfo.</param>
        /// <param name="oneDriveEntityInfo">oneDriveEntityInfo.</param>
        public AccessibleEntityInfo(ProtectionSourceUid mailboxEntityInfo = default(ProtectionSourceUid), ProtectionSourceUid oneDriveEntityInfo = default(ProtectionSourceUid))
        {
            this.MailboxEntityInfo = mailboxEntityInfo;
            this.OneDriveEntityInfo = oneDriveEntityInfo;
        }
        
        /// <summary>
        /// Gets or Sets MailboxEntityInfo
        /// </summary>
        [DataMember(Name="mailboxEntityInfo", EmitDefaultValue=false)]
        public ProtectionSourceUid MailboxEntityInfo { get; set; }

        /// <summary>
        /// Gets or Sets OneDriveEntityInfo
        /// </summary>
        [DataMember(Name="oneDriveEntityInfo", EmitDefaultValue=false)]
        public ProtectionSourceUid OneDriveEntityInfo { get; set; }

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
            return this.Equals(input as AccessibleEntityInfo);
        }

        /// <summary>
        /// Returns true if AccessibleEntityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessibleEntityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessibleEntityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MailboxEntityInfo == input.MailboxEntityInfo ||
                    (this.MailboxEntityInfo != null &&
                    this.MailboxEntityInfo.Equals(input.MailboxEntityInfo))
                ) && 
                (
                    this.OneDriveEntityInfo == input.OneDriveEntityInfo ||
                    (this.OneDriveEntityInfo != null &&
                    this.OneDriveEntityInfo.Equals(input.OneDriveEntityInfo))
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
                if (this.MailboxEntityInfo != null)
                    hashCode = hashCode * 59 + this.MailboxEntityInfo.GetHashCode();
                if (this.OneDriveEntityInfo != null)
                    hashCode = hashCode * 59 + this.OneDriveEntityInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

