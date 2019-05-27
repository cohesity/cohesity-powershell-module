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
    /// Specifies the credentials to mount a volume on a NetApp server.
    /// </summary>
    [DataContract]
    public partial class NasMountCredentialParams :  IEquatable<NasMountCredentialParams>
    {
        /// <summary>
        /// Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.
        /// </summary>
        /// <value>Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NasProtocolEnum
        {
            /// <summary>
            /// Enum KNfs3 for value: kNfs3
            /// </summary>
            [EnumMember(Value = "kNfs3")]
            KNfs3 = 1,

            /// <summary>
            /// Enum KCifs1 for value: kCifs1
            /// </summary>
            [EnumMember(Value = "kCifs1")]
            KCifs1 = 2

        }

        /// <summary>
        /// Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.
        /// </summary>
        /// <value>Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.</value>
        [DataMember(Name="nasProtocol", EmitDefaultValue=true)]
        public NasProtocolEnum? NasProtocol { get; set; }
        /// <summary>
        /// Specifies the type of a NAS Object such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted. &#39;kDfsGroup&#39; indicates a DFS group containing top level directories mapped to different servers. &#39;kDfsTopDir&#39; indicates a top level directory inside a DFS group, discovered when registering a DFS group.
        /// </summary>
        /// <value>Specifies the type of a NAS Object such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted. &#39;kDfsGroup&#39; indicates a DFS group containing top level directories mapped to different servers. &#39;kDfsTopDir&#39; indicates a top level directory inside a DFS group, discovered when registering a DFS group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NasTypeEnum
        {
            /// <summary>
            /// Enum KGroup for value: kGroup
            /// </summary>
            [EnumMember(Value = "kGroup")]
            KGroup = 1,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 2,

            /// <summary>
            /// Enum KDfsGroup for value: kDfsGroup
            /// </summary>
            [EnumMember(Value = "kDfsGroup")]
            KDfsGroup = 3,

            /// <summary>
            /// Enum KDfsTopDir for value: kDfsTopDir
            /// </summary>
            [EnumMember(Value = "kDfsTopDir")]
            KDfsTopDir = 4

        }

        /// <summary>
        /// Specifies the type of a NAS Object such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted. &#39;kDfsGroup&#39; indicates a DFS group containing top level directories mapped to different servers. &#39;kDfsTopDir&#39; indicates a top level directory inside a DFS group, discovered when registering a DFS group.
        /// </summary>
        /// <value>Specifies the type of a NAS Object such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted. &#39;kDfsGroup&#39; indicates a DFS group containing top level directories mapped to different servers. &#39;kDfsTopDir&#39; indicates a top level directory inside a DFS group, discovered when registering a DFS group.</value>
        [DataMember(Name="nasType", EmitDefaultValue=true)]
        public NasTypeEnum? NasType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NasMountCredentialParams" /> class.
        /// </summary>
        /// <param name="domain">Specifies the domain in which this credential is valid..</param>
        /// <param name="nasProtocol">Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol..</param>
        /// <param name="nasType">Specifies the type of a NAS Object such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted. &#39;kDfsGroup&#39; indicates a DFS group containing top level directories mapped to different servers. &#39;kDfsTopDir&#39; indicates a top level directory inside a DFS group, discovered when registering a DFS group..</param>
        /// <param name="password">Specifies the password for the username to use for mounting the NAS..</param>
        /// <param name="skipValidation">Specifies the flag to disable mount point validation during registration process..</param>
        /// <param name="username">Specifies a username to use for mounting the NAS..</param>
        public NasMountCredentialParams(string domain = default(string), NasProtocolEnum? nasProtocol = default(NasProtocolEnum?), NasTypeEnum? nasType = default(NasTypeEnum?), string password = default(string), bool? skipValidation = default(bool?), string username = default(string))
        {
            this.Domain = domain;
            this.NasProtocol = nasProtocol;
            this.NasType = nasType;
            this.Password = password;
            this.SkipValidation = skipValidation;
            this.Username = username;
            this.Domain = domain;
            this.NasProtocol = nasProtocol;
            this.NasType = nasType;
            this.Password = password;
            this.SkipValidation = skipValidation;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the domain in which this credential is valid.
        /// </summary>
        /// <value>Specifies the domain in which this credential is valid.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the password for the username to use for mounting the NAS.
        /// </summary>
        /// <value>Specifies the password for the username to use for mounting the NAS.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the flag to disable mount point validation during registration process.
        /// </summary>
        /// <value>Specifies the flag to disable mount point validation during registration process.</value>
        [DataMember(Name="skipValidation", EmitDefaultValue=true)]
        public bool? SkipValidation { get; set; }

        /// <summary>
        /// Specifies a username to use for mounting the NAS.
        /// </summary>
        /// <value>Specifies a username to use for mounting the NAS.</value>
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
            return this.Equals(input as NasMountCredentialParams);
        }

        /// <summary>
        /// Returns true if NasMountCredentialParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NasMountCredentialParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasMountCredentialParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.NasProtocol == input.NasProtocol ||
                    this.NasProtocol.Equals(input.NasProtocol)
                ) && 
                (
                    this.NasType == input.NasType ||
                    this.NasType.Equals(input.NasType)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SkipValidation == input.SkipValidation ||
                    (this.SkipValidation != null &&
                    this.SkipValidation.Equals(input.SkipValidation))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                hashCode = hashCode * 59 + this.NasProtocol.GetHashCode();
                hashCode = hashCode * 59 + this.NasType.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SkipValidation != null)
                    hashCode = hashCode * 59 + this.SkipValidation.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

