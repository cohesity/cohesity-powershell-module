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
    /// Message defining SMB config for IRIS. SMB config contains SMB encryption flags, SMB discoverable flag and Share level permissions.
    /// </summary>
    [DataContract]
    public partial class AliasSmbConfig :  IEquatable<AliasSmbConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AliasSmbConfig" /> class.
        /// </summary>
        /// <param name="cachingEnabled">Indicate if offline file caching is supported.</param>
        /// <param name="discoveryEnabled">Whether the share is discoverable..</param>
        /// <param name="encryptionEnabled">Whether SMB encryption is enabled for this share. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format..</param>
        /// <param name="encryptionRequired">Whether to enforce encryption for all the sessions for this view. When enabled all unencrypted sessions are disallowed..</param>
        /// <param name="isShareLevelPermissionEmpty">Indicate if share level permission is cleared by user..</param>
        /// <param name="permissions">Share level permissions..</param>
        public AliasSmbConfig(bool? cachingEnabled = default(bool?), bool? discoveryEnabled = default(bool?), bool? encryptionEnabled = default(bool?), bool? encryptionRequired = default(bool?), bool? isShareLevelPermissionEmpty = default(bool?), List<SmbPermission> permissions = default(List<SmbPermission>))
        {
            this.CachingEnabled = cachingEnabled;
            this.DiscoveryEnabled = discoveryEnabled;
            this.EncryptionEnabled = encryptionEnabled;
            this.EncryptionRequired = encryptionRequired;
            this.IsShareLevelPermissionEmpty = isShareLevelPermissionEmpty;
            this.Permissions = permissions;
            this.CachingEnabled = cachingEnabled;
            this.DiscoveryEnabled = discoveryEnabled;
            this.EncryptionEnabled = encryptionEnabled;
            this.EncryptionRequired = encryptionRequired;
            this.IsShareLevelPermissionEmpty = isShareLevelPermissionEmpty;
            this.Permissions = permissions;
        }
        
        /// <summary>
        /// Indicate if offline file caching is supported
        /// </summary>
        /// <value>Indicate if offline file caching is supported</value>
        [DataMember(Name="cachingEnabled", EmitDefaultValue=true)]
        public bool? CachingEnabled { get; set; }

        /// <summary>
        /// Whether the share is discoverable.
        /// </summary>
        /// <value>Whether the share is discoverable.</value>
        [DataMember(Name="discoveryEnabled", EmitDefaultValue=true)]
        public bool? DiscoveryEnabled { get; set; }

        /// <summary>
        /// Whether SMB encryption is enabled for this share. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.
        /// </summary>
        /// <value>Whether SMB encryption is enabled for this share. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.</value>
        [DataMember(Name="encryptionEnabled", EmitDefaultValue=true)]
        public bool? EncryptionEnabled { get; set; }

        /// <summary>
        /// Whether to enforce encryption for all the sessions for this view. When enabled all unencrypted sessions are disallowed.
        /// </summary>
        /// <value>Whether to enforce encryption for all the sessions for this view. When enabled all unencrypted sessions are disallowed.</value>
        [DataMember(Name="encryptionRequired", EmitDefaultValue=true)]
        public bool? EncryptionRequired { get; set; }

        /// <summary>
        /// Indicate if share level permission is cleared by user.
        /// </summary>
        /// <value>Indicate if share level permission is cleared by user.</value>
        [DataMember(Name="isShareLevelPermissionEmpty", EmitDefaultValue=true)]
        public bool? IsShareLevelPermissionEmpty { get; set; }

        /// <summary>
        /// Share level permissions.
        /// </summary>
        /// <value>Share level permissions.</value>
        [DataMember(Name="permissions", EmitDefaultValue=true)]
        public List<SmbPermission> Permissions { get; set; }

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
            return this.Equals(input as AliasSmbConfig);
        }

        /// <summary>
        /// Returns true if AliasSmbConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AliasSmbConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliasSmbConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CachingEnabled == input.CachingEnabled ||
                    (this.CachingEnabled != null &&
                    this.CachingEnabled.Equals(input.CachingEnabled))
                ) && 
                (
                    this.DiscoveryEnabled == input.DiscoveryEnabled ||
                    (this.DiscoveryEnabled != null &&
                    this.DiscoveryEnabled.Equals(input.DiscoveryEnabled))
                ) && 
                (
                    this.EncryptionEnabled == input.EncryptionEnabled ||
                    (this.EncryptionEnabled != null &&
                    this.EncryptionEnabled.Equals(input.EncryptionEnabled))
                ) && 
                (
                    this.EncryptionRequired == input.EncryptionRequired ||
                    (this.EncryptionRequired != null &&
                    this.EncryptionRequired.Equals(input.EncryptionRequired))
                ) && 
                (
                    this.IsShareLevelPermissionEmpty == input.IsShareLevelPermissionEmpty ||
                    (this.IsShareLevelPermissionEmpty != null &&
                    this.IsShareLevelPermissionEmpty.Equals(input.IsShareLevelPermissionEmpty))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.CachingEnabled != null)
                    hashCode = hashCode * 59 + this.CachingEnabled.GetHashCode();
                if (this.DiscoveryEnabled != null)
                    hashCode = hashCode * 59 + this.DiscoveryEnabled.GetHashCode();
                if (this.EncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.EncryptionEnabled.GetHashCode();
                if (this.EncryptionRequired != null)
                    hashCode = hashCode * 59 + this.EncryptionRequired.GetHashCode();
                if (this.IsShareLevelPermissionEmpty != null)
                    hashCode = hashCode * 59 + this.IsShareLevelPermissionEmpty.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                return hashCode;
            }
        }

    }

}

