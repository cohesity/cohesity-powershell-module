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
    /// Specifies the server credentials to connect to a NetApp server.
    /// </summary>
    [DataContract]
    public partial class NasCredentials :  IEquatable<NasCredentials>
    {
        /// <summary>
        /// If applicable and specified, the NFS security type of the NFS share.
        /// </summary>
        /// <value>If applicable and specified, the NFS security type of the NFS share.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NfsSecurityTypeEnum
        {
            /// <summary>
            /// Enum Seeprotodefinition for value: see proto definition
            /// </summary>
            [EnumMember(Value = "see proto definition")]
            Seeprotodefinition = 1

        }

        /// <summary>
        /// If applicable and specified, the NFS security type of the NFS share.
        /// </summary>
        /// <value>If applicable and specified, the NFS security type of the NFS share.</value>
        [DataMember(Name="nfsSecurityType", EmitDefaultValue=true)]
        public NfsSecurityTypeEnum? NfsSecurityType { get; set; }
        /// <summary>
        /// If applicable and specified, the NFS version number of the NFS share.
        /// </summary>
        /// <value>If applicable and specified, the NFS version number of the NFS share.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NfsVersionNumberEnum
        {
            /// <summary>
            /// Enum Seeprotobufdefinition for value: see protobuf definition
            /// </summary>
            [EnumMember(Value = "see protobuf definition")]
            Seeprotobufdefinition = 1

        }

        /// <summary>
        /// If applicable and specified, the NFS version number of the NFS share.
        /// </summary>
        /// <value>If applicable and specified, the NFS version number of the NFS share.</value>
        [DataMember(Name="nfsVersionNumber", EmitDefaultValue=true)]
        public NfsVersionNumberEnum? NfsVersionNumber { get; set; }
        /// <summary>
        /// Specifies the sharing protocol type used to mount the file system. Currently, only NFS is supported. &#39;kNFS&#39; indicates use the NFS protocol to mount the file system. &#39;kCIFS&#39; indicates use the CIFS protocol to mount the file system.
        /// </summary>
        /// <value>Specifies the sharing protocol type used to mount the file system. Currently, only NFS is supported. &#39;kNFS&#39; indicates use the NFS protocol to mount the file system. &#39;kCIFS&#39; indicates use the CIFS protocol to mount the file system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShareTypeEnum
        {
            /// <summary>
            /// Enum KNFS for value: kNFS
            /// </summary>
            [EnumMember(Value = "kNFS")]
            KNFS = 1,

            /// <summary>
            /// Enum KCIFS for value: kCIFS
            /// </summary>
            [EnumMember(Value = "kCIFS")]
            KCIFS = 2

        }

        /// <summary>
        /// Specifies the sharing protocol type used to mount the file system. Currently, only NFS is supported. &#39;kNFS&#39; indicates use the NFS protocol to mount the file system. &#39;kCIFS&#39; indicates use the CIFS protocol to mount the file system.
        /// </summary>
        /// <value>Specifies the sharing protocol type used to mount the file system. Currently, only NFS is supported. &#39;kNFS&#39; indicates use the NFS protocol to mount the file system. &#39;kCIFS&#39; indicates use the CIFS protocol to mount the file system.</value>
        [DataMember(Name="shareType", EmitDefaultValue=true)]
        public ShareTypeEnum? ShareType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NasCredentials" /> class.
        /// </summary>
        /// <param name="host">Specifies the hostname or IP address of the NAS server..</param>
        /// <param name="kerberosRealmName">If applicable and specified, the realm name of the Kerberos provider security the NFS share..</param>
        /// <param name="mountPath">Specifies the mount path to the NAS server..</param>
        /// <param name="nfsSecurityType">If applicable and specified, the NFS security type of the NFS share..</param>
        /// <param name="nfsVersionNumber">If applicable and specified, the NFS version number of the NFS share..</param>
        /// <param name="password">If using the CIFS protocol and a Username was specified, specify the password for the username..</param>
        /// <param name="shareType">Specifies the sharing protocol type used to mount the file system. Currently, only NFS is supported. &#39;kNFS&#39; indicates use the NFS protocol to mount the file system. &#39;kCIFS&#39; indicates use the CIFS protocol to mount the file system..</param>
        /// <param name="username">If using the CIFS protocol, you can optional specify a username to use when mounting..</param>
        public NasCredentials(string host = default(string), string kerberosRealmName = default(string), string mountPath = default(string), NfsSecurityTypeEnum? nfsSecurityType = default(NfsSecurityTypeEnum?), NfsVersionNumberEnum? nfsVersionNumber = default(NfsVersionNumberEnum?), string password = default(string), ShareTypeEnum? shareType = default(ShareTypeEnum?), string username = default(string))
        {
            this.Host = host;
            this.KerberosRealmName = kerberosRealmName;
            this.MountPath = mountPath;
            this.NfsSecurityType = nfsSecurityType;
            this.NfsVersionNumber = nfsVersionNumber;
            this.Password = password;
            this.ShareType = shareType;
            this.Username = username;
            this.Host = host;
            this.KerberosRealmName = kerberosRealmName;
            this.MountPath = mountPath;
            this.NfsSecurityType = nfsSecurityType;
            this.NfsVersionNumber = nfsVersionNumber;
            this.Password = password;
            this.ShareType = shareType;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the hostname or IP address of the NAS server.
        /// </summary>
        /// <value>Specifies the hostname or IP address of the NAS server.</value>
        [DataMember(Name="host", EmitDefaultValue=true)]
        public string Host { get; set; }

        /// <summary>
        /// If applicable and specified, the realm name of the Kerberos provider security the NFS share.
        /// </summary>
        /// <value>If applicable and specified, the realm name of the Kerberos provider security the NFS share.</value>
        [DataMember(Name="kerberosRealmName", EmitDefaultValue=true)]
        public string KerberosRealmName { get; set; }

        /// <summary>
        /// Specifies the mount path to the NAS server.
        /// </summary>
        /// <value>Specifies the mount path to the NAS server.</value>
        [DataMember(Name="mountPath", EmitDefaultValue=true)]
        public string MountPath { get; set; }

        /// <summary>
        /// If using the CIFS protocol and a Username was specified, specify the password for the username.
        /// </summary>
        /// <value>If using the CIFS protocol and a Username was specified, specify the password for the username.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// If using the CIFS protocol, you can optional specify a username to use when mounting.
        /// </summary>
        /// <value>If using the CIFS protocol, you can optional specify a username to use when mounting.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

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
            return this.Equals(input as NasCredentials);
        }

        /// <summary>
        /// Returns true if NasCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of NasCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.KerberosRealmName == input.KerberosRealmName ||
                    (this.KerberosRealmName != null &&
                    this.KerberosRealmName.Equals(input.KerberosRealmName))
                ) && 
                (
                    this.MountPath == input.MountPath ||
                    (this.MountPath != null &&
                    this.MountPath.Equals(input.MountPath))
                ) && 
                (
                    this.NfsSecurityType == input.NfsSecurityType ||
                    this.NfsSecurityType.Equals(input.NfsSecurityType)
                ) && 
                (
                    this.NfsVersionNumber == input.NfsVersionNumber ||
                    this.NfsVersionNumber.Equals(input.NfsVersionNumber)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ShareType == input.ShareType ||
                    this.ShareType.Equals(input.ShareType)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.KerberosRealmName != null)
                    hashCode = hashCode * 59 + this.KerberosRealmName.GetHashCode();
                if (this.MountPath != null)
                    hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                hashCode = hashCode * 59 + this.NfsSecurityType.GetHashCode();
                hashCode = hashCode * 59 + this.NfsVersionNumber.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

