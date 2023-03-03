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
    /// Specifies information about a mount point in an Isilon OneFs Cluster.
    /// </summary>
    [DataContract]
    public partial class IsilonMountPoint :  IEquatable<IsilonMountPoint>
    {
        /// <summary>
        /// Defines Protocols
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolsEnum
        {
            /// <summary>
            /// Enum KNfs for value: kNfs
            /// </summary>
            [EnumMember(Value = "kNfs")]
            KNfs = 1,

            /// <summary>
            /// Enum KSmb for value: kSmb
            /// </summary>
            [EnumMember(Value = "kSmb")]
            KSmb = 2

        }


        /// <summary>
        /// List of Protocols on Isilon.  Specifies the list of protocols enabled on Isilon OneFs file system. &#39;kNfs&#39; indicates NFS exports in an Isilon Cluster. &#39;kSmb&#39; indicates CIFS/SMB Shares in an Isilon Cluster.
        /// </summary>
        /// <value>List of Protocols on Isilon.  Specifies the list of protocols enabled on Isilon OneFs file system. &#39;kNfs&#39; indicates NFS exports in an Isilon Cluster. &#39;kSmb&#39; indicates CIFS/SMB Shares in an Isilon Cluster.</value>
        [DataMember(Name="protocols", EmitDefaultValue=true)]
        public List<ProtocolsEnum> Protocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonMountPoint" /> class.
        /// </summary>
        /// <param name="accessZoneName">Specifies the name of access zone..</param>
        /// <param name="nfsMountPoint">nfsMountPoint.</param>
        /// <param name="path">Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;..</param>
        /// <param name="protocols">List of Protocols on Isilon.  Specifies the list of protocols enabled on Isilon OneFs file system. &#39;kNfs&#39; indicates NFS exports in an Isilon Cluster. &#39;kSmb&#39; indicates CIFS/SMB Shares in an Isilon Cluster..</param>
        /// <param name="smbMountPoints">Specifies information about an SMB share. This field is set if the file system supports protocol type &#39;kSmb&#39;..</param>
        public IsilonMountPoint(string accessZoneName = default(string), IsilonNfsMountPoint nfsMountPoint = default(IsilonNfsMountPoint), string path = default(string), List<ProtocolsEnum> protocols = default(List<ProtocolsEnum>), List<IsilonSmbMountPoint> smbMountPoints = default(List<IsilonSmbMountPoint>))
        {
            this.AccessZoneName = accessZoneName;
            this.Path = path;
            this.Protocols = protocols;
            this.SmbMountPoints = smbMountPoints;
            this.AccessZoneName = accessZoneName;
            this.NfsMountPoint = nfsMountPoint;
            this.Path = path;
            this.Protocols = protocols;
            this.SmbMountPoints = smbMountPoints;
        }
        
        /// <summary>
        /// Specifies the name of access zone.
        /// </summary>
        /// <value>Specifies the name of access zone.</value>
        [DataMember(Name="accessZoneName", EmitDefaultValue=true)]
        public string AccessZoneName { get; set; }

        /// <summary>
        /// Gets or Sets NfsMountPoint
        /// </summary>
        [DataMember(Name="nfsMountPoint", EmitDefaultValue=false)]
        public IsilonNfsMountPoint NfsMountPoint { get; set; }

        /// <summary>
        /// Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;.
        /// </summary>
        /// <value>Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Specifies information about an SMB share. This field is set if the file system supports protocol type &#39;kSmb&#39;.
        /// </summary>
        /// <value>Specifies information about an SMB share. This field is set if the file system supports protocol type &#39;kSmb&#39;.</value>
        [DataMember(Name="smbMountPoints", EmitDefaultValue=true)]
        public List<IsilonSmbMountPoint> SmbMountPoints { get; set; }

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
            return this.Equals(input as IsilonMountPoint);
        }

        /// <summary>
        /// Returns true if IsilonMountPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonMountPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonMountPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessZoneName == input.AccessZoneName ||
                    (this.AccessZoneName != null &&
                    this.AccessZoneName.Equals(input.AccessZoneName))
                ) && 
                (
                    this.NfsMountPoint == input.NfsMountPoint ||
                    (this.NfsMountPoint != null &&
                    this.NfsMountPoint.Equals(input.NfsMountPoint))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    this.Protocols.SequenceEqual(input.Protocols)
                ) && 
                (
                    this.SmbMountPoints == input.SmbMountPoints ||
                    this.SmbMountPoints != null &&
                    input.SmbMountPoints != null &&
                    this.SmbMountPoints.SequenceEqual(input.SmbMountPoints)
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
                if (this.AccessZoneName != null)
                    hashCode = hashCode * 59 + this.AccessZoneName.GetHashCode();
                if (this.NfsMountPoint != null)
                    hashCode = hashCode * 59 + this.NfsMountPoint.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.SmbMountPoints != null)
                    hashCode = hashCode * 59 + this.SmbMountPoints.GetHashCode();
                return hashCode;
            }
        }

    }

}

