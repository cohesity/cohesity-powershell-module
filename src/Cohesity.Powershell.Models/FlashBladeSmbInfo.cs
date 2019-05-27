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
    /// Specifies information specific to SMB shares exposed by Pure Flash Blade file system.
    /// </summary>
    [DataContract]
    public partial class FlashBladeSmbInfo :  IEquatable<FlashBladeSmbInfo>
    {
        /// <summary>
        /// ACL mode for this SMB share. &#39;kNative&#39; specifies native ACL mode supports UNIX-like ACLs and Windows ACLs. In native mode, because SMB natively supports both ACLs while NFS only supports UNIX ACLs, ACLs will not be shared between SMB and NFS. &#39;kShared&#39; shares UNIX-like ACL permissions with the NFS protocol. In shared mode both protocol ACL permissions are required to match. When one protocol creates files or modifies permissions, they must comply with the permission settings of the other protocol.
        /// </summary>
        /// <value>ACL mode for this SMB share. &#39;kNative&#39; specifies native ACL mode supports UNIX-like ACLs and Windows ACLs. In native mode, because SMB natively supports both ACLs while NFS only supports UNIX ACLs, ACLs will not be shared between SMB and NFS. &#39;kShared&#39; shares UNIX-like ACL permissions with the NFS protocol. In shared mode both protocol ACL permissions are required to match. When one protocol creates files or modifies permissions, they must comply with the permission settings of the other protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AclModeEnum
        {
            /// <summary>
            /// Enum KShared for value: kShared
            /// </summary>
            [EnumMember(Value = "kShared")]
            KShared = 1,

            /// <summary>
            /// Enum KNative for value: kNative
            /// </summary>
            [EnumMember(Value = "kNative")]
            KNative = 2

        }

        /// <summary>
        /// ACL mode for this SMB share. &#39;kNative&#39; specifies native ACL mode supports UNIX-like ACLs and Windows ACLs. In native mode, because SMB natively supports both ACLs while NFS only supports UNIX ACLs, ACLs will not be shared between SMB and NFS. &#39;kShared&#39; shares UNIX-like ACL permissions with the NFS protocol. In shared mode both protocol ACL permissions are required to match. When one protocol creates files or modifies permissions, they must comply with the permission settings of the other protocol.
        /// </summary>
        /// <value>ACL mode for this SMB share. &#39;kNative&#39; specifies native ACL mode supports UNIX-like ACLs and Windows ACLs. In native mode, because SMB natively supports both ACLs while NFS only supports UNIX ACLs, ACLs will not be shared between SMB and NFS. &#39;kShared&#39; shares UNIX-like ACL permissions with the NFS protocol. In shared mode both protocol ACL permissions are required to match. When one protocol creates files or modifies permissions, they must comply with the permission settings of the other protocol.</value>
        [DataMember(Name="aclMode", EmitDefaultValue=true)]
        public AclModeEnum? AclMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashBladeSmbInfo" /> class.
        /// </summary>
        /// <param name="aclMode">ACL mode for this SMB share. &#39;kNative&#39; specifies native ACL mode supports UNIX-like ACLs and Windows ACLs. In native mode, because SMB natively supports both ACLs while NFS only supports UNIX ACLs, ACLs will not be shared between SMB and NFS. &#39;kShared&#39; shares UNIX-like ACL permissions with the NFS protocol. In shared mode both protocol ACL permissions are required to match. When one protocol creates files or modifies permissions, they must comply with the permission settings of the other protocol..</param>
        public FlashBladeSmbInfo(AclModeEnum? aclMode = default(AclModeEnum?))
        {
            this.AclMode = aclMode;
            this.AclMode = aclMode;
        }
        
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
            return this.Equals(input as FlashBladeSmbInfo);
        }

        /// <summary>
        /// Returns true if FlashBladeSmbInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashBladeSmbInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashBladeSmbInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AclMode == input.AclMode ||
                    this.AclMode.Equals(input.AclMode)
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
                hashCode = hashCode * 59 + this.AclMode.GetHashCode();
                return hashCode;
            }
        }

    }

}

