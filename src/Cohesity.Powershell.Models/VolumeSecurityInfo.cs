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
    /// Specifies information about NetApp volume security settings.
    /// </summary>
    [DataContract]
    public partial class VolumeSecurityInfo :  IEquatable<VolumeSecurityInfo>
    {
        /// <summary>
        /// Specifies the security style associated with this volume. Specifies the type of a NetApp Volume. &#39;kUnix&#39; indicates Unix-style security. &#39;kNtfs&#39; indicates Windows NTFS-style security. &#39;kMixed&#39; indicates mixed-style security. &#39;kUnified&#39; indicates Unified-style security.
        /// </summary>
        /// <value>Specifies the security style associated with this volume. Specifies the type of a NetApp Volume. &#39;kUnix&#39; indicates Unix-style security. &#39;kNtfs&#39; indicates Windows NTFS-style security. &#39;kMixed&#39; indicates mixed-style security. &#39;kUnified&#39; indicates Unified-style security.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleEnum
        {
            /// <summary>
            /// Enum KUnix for value: kUnix
            /// </summary>
            [EnumMember(Value = "kUnix")]
            KUnix = 1,

            /// <summary>
            /// Enum KNtfs for value: kNtfs
            /// </summary>
            [EnumMember(Value = "kNtfs")]
            KNtfs = 2,

            /// <summary>
            /// Enum KMixed for value: kMixed
            /// </summary>
            [EnumMember(Value = "kMixed")]
            KMixed = 3,

            /// <summary>
            /// Enum KUnified for value: kUnified
            /// </summary>
            [EnumMember(Value = "kUnified")]
            KUnified = 4,

            /// <summary>
            /// Enum kDataProtection for value: kDataProtection
            /// </summary>
            [EnumMember(Value = "kDataProtection")]
            kDataProtection = 5,

            /// <summary>
            /// Enum kDataCache for value: kDataCache
            /// </summary>
            [EnumMember(Value = "kDataCache")]
            kDataCache = 6,

            /// <summary>
            /// Enum kLoadSharing for value: kLoadSharing
            /// </summary>
            [EnumMember(Value = "kLoadSharing")]
            kLoadSharing = 7

        }

        /// <summary>
        /// Specifies the security style associated with this volume. Specifies the type of a NetApp Volume. &#39;kUnix&#39; indicates Unix-style security. &#39;kNtfs&#39; indicates Windows NTFS-style security. &#39;kMixed&#39; indicates mixed-style security. &#39;kUnified&#39; indicates Unified-style security.
        /// </summary>
        /// <value>Specifies the security style associated with this volume. Specifies the type of a NetApp Volume. &#39;kUnix&#39; indicates Unix-style security. &#39;kNtfs&#39; indicates Windows NTFS-style security. &#39;kMixed&#39; indicates mixed-style security. &#39;kUnified&#39; indicates Unified-style security.</value>
        [DataMember(Name="style", EmitDefaultValue=true)]
        public StyleEnum? Style { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSecurityInfo" /> class.
        /// </summary>
        /// <param name="groupId">Specifies the Unix group ID for this volume. 0 indicates the root id..</param>
        /// <param name="permissions">Specifies the Unix permission bits in octal string format..</param>
        /// <param name="style">Specifies the security style associated with this volume. Specifies the type of a NetApp Volume. &#39;kUnix&#39; indicates Unix-style security. &#39;kNtfs&#39; indicates Windows NTFS-style security. &#39;kMixed&#39; indicates mixed-style security. &#39;kUnified&#39; indicates Unified-style security..</param>
        /// <param name="userId">Specifies the Unix user id for this volume. 0 indicates the root id..</param>
        public VolumeSecurityInfo(int? groupId = default(int?), string permissions = default(string), StyleEnum? style = default(StyleEnum?), int? userId = default(int?))
        {
            this.GroupId = groupId;
            this.Permissions = permissions;
            this.Style = style;
            this.UserId = userId;
            this.GroupId = groupId;
            this.Permissions = permissions;
            this.Style = style;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Specifies the Unix group ID for this volume. 0 indicates the root id.
        /// </summary>
        /// <value>Specifies the Unix group ID for this volume. 0 indicates the root id.</value>
        [DataMember(Name="groupId", EmitDefaultValue=true)]
        public int? GroupId { get; set; }

        /// <summary>
        /// Specifies the Unix permission bits in octal string format.
        /// </summary>
        /// <value>Specifies the Unix permission bits in octal string format.</value>
        [DataMember(Name="permissions", EmitDefaultValue=true)]
        public string Permissions { get; set; }

        /// <summary>
        /// Specifies the Unix user id for this volume. 0 indicates the root id.
        /// </summary>
        /// <value>Specifies the Unix user id for this volume. 0 indicates the root id.</value>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public int? UserId { get; set; }

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
            return this.Equals(input as VolumeSecurityInfo);
        }

        /// <summary>
        /// Returns true if VolumeSecurityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeSecurityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeSecurityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.Style == input.Style ||
                    this.Style.Equals(input.Style)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                hashCode = hashCode * 59 + this.Style.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}

