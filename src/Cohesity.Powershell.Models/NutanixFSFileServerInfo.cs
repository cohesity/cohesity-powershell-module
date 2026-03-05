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
    /// Specifies information about a NutanixFS Prism File Server Protection Source.
    /// </summary>
    [DataContract]
    public partial class NutanixFSFileServerInfo :  IEquatable<NutanixFSFileServerInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NutanixFSFileServerInfo" /> class.
        /// </summary>
        /// <param name="extId">Specifies information globally unique ID of this Object assigned by the NutanixFS file server..</param>
        /// <param name="fsvmInfo">fsvmInfo.</param>
        /// <param name="name">Specifies the name of the NutanixFS File Server..</param>
        /// <param name="sizeInGib">Specifies the size of the NutanixFS File Server in GiB..</param>
        /// <param name="smbKrb5Hostname">Specifies the Krb5 hostname information of the NutanixFS File Server..</param>
        /// <param name="version">Specifies the version of the NutanixFS File Server.</param>
        public NutanixFSFileServerInfo(string extId = default(string), NutanixFSFsvmInfo fsvmInfo = default(NutanixFSFsvmInfo), string name = default(string), long? sizeInGib = default(long?), string smbKrb5Hostname = default(string), string version = default(string))
        {
            this.ExtId = extId;
            this.Name = name;
            this.SizeInGib = sizeInGib;
            this.SmbKrb5Hostname = smbKrb5Hostname;
            this.Version = version;
            this.ExtId = extId;
            this.FsvmInfo = fsvmInfo;
            this.Name = name;
            this.SizeInGib = sizeInGib;
            this.SmbKrb5Hostname = smbKrb5Hostname;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies information globally unique ID of this Object assigned by the NutanixFS file server.
        /// </summary>
        /// <value>Specifies information globally unique ID of this Object assigned by the NutanixFS file server.</value>
        [DataMember(Name="extId", EmitDefaultValue=true)]
        public string ExtId { get; set; }

        /// <summary>
        /// Gets or Sets FsvmInfo
        /// </summary>
        [DataMember(Name="fsvmInfo", EmitDefaultValue=false)]
        public NutanixFSFsvmInfo FsvmInfo { get; set; }

        /// <summary>
        /// Specifies the name of the NutanixFS File Server.
        /// </summary>
        /// <value>Specifies the name of the NutanixFS File Server.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the size of the NutanixFS File Server in GiB.
        /// </summary>
        /// <value>Specifies the size of the NutanixFS File Server in GiB.</value>
        [DataMember(Name="sizeInGib", EmitDefaultValue=true)]
        public long? SizeInGib { get; set; }

        /// <summary>
        /// Specifies the Krb5 hostname information of the NutanixFS File Server.
        /// </summary>
        /// <value>Specifies the Krb5 hostname information of the NutanixFS File Server.</value>
        [DataMember(Name="smbKrb5Hostname", EmitDefaultValue=true)]
        public string SmbKrb5Hostname { get; set; }

        /// <summary>
        /// Specifies the version of the NutanixFS File Server
        /// </summary>
        /// <value>Specifies the version of the NutanixFS File Server</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as NutanixFSFileServerInfo);
        }

        /// <summary>
        /// Returns true if NutanixFSFileServerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NutanixFSFileServerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutanixFSFileServerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtId == input.ExtId ||
                    (this.ExtId != null &&
                    this.ExtId.Equals(input.ExtId))
                ) && 
                (
                    this.FsvmInfo == input.FsvmInfo ||
                    (this.FsvmInfo != null &&
                    this.FsvmInfo.Equals(input.FsvmInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SizeInGib == input.SizeInGib ||
                    (this.SizeInGib != null &&
                    this.SizeInGib.Equals(input.SizeInGib))
                ) && 
                (
                    this.SmbKrb5Hostname == input.SmbKrb5Hostname ||
                    (this.SmbKrb5Hostname != null &&
                    this.SmbKrb5Hostname.Equals(input.SmbKrb5Hostname))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ExtId != null)
                    hashCode = hashCode * 59 + this.ExtId.GetHashCode();
                if (this.FsvmInfo != null)
                    hashCode = hashCode * 59 + this.FsvmInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SizeInGib != null)
                    hashCode = hashCode * 59 + this.SizeInGib.GetHashCode();
                if (this.SmbKrb5Hostname != null)
                    hashCode = hashCode * 59 + this.SmbKrb5Hostname.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

