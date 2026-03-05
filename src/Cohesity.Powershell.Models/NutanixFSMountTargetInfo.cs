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
    /// Specifies information about a NutanixFS Prism Mount Target Protection Source.
    /// </summary>
    [DataContract]
    public partial class NutanixFSMountTargetInfo :  IEquatable<NutanixFSMountTargetInfo>
    {
        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. Specifies the NutanixFS share types supported in NutanixFS environment &#39;kStandard&#39; indicates a standard share type. &#39;kDistributed&#39; indicates a distributed share type.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. Specifies the NutanixFS share types supported in NutanixFS environment &#39;kStandard&#39; indicates a standard share type. &#39;kDistributed&#39; indicates a distributed share type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShareTypeEnum
        {
            /// <summary>
            /// Enum KStandard for value: kStandard
            /// </summary>
            [EnumMember(Value = "kStandard")]
            KStandard = 1,

            /// <summary>
            /// Enum KDistributed for value: kDistributed
            /// </summary>
            [EnumMember(Value = "kDistributed")]
            KDistributed = 2

        }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. Specifies the NutanixFS share types supported in NutanixFS environment &#39;kStandard&#39; indicates a standard share type. &#39;kDistributed&#39; indicates a distributed share type.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. Specifies the NutanixFS share types supported in NutanixFS environment &#39;kStandard&#39; indicates a standard share type. &#39;kDistributed&#39; indicates a distributed share type.</value>
        [DataMember(Name="shareType", EmitDefaultValue=true)]
        public ShareTypeEnum? ShareType { get; set; }
        /// <summary>
        /// Defines SupportedProtocols
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SupportedProtocolsEnum
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
            KSmb = 2,

            /// <summary>
            /// Enum KNfs41 for value: kNfs4_1
            /// </summary>
            [EnumMember(Value = "kNfs4_1")]
            KNfs41 = 3

        }


        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. &#39;kNfs&#39; indicates NFS connections. &#39;kSmb&#39; indicates SMB connections. &#39;kNfs4_1&#39; indicates NFSv4.1 connections.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. &#39;kNfs&#39; indicates NFS connections. &#39;kSmb&#39; indicates SMB connections. &#39;kNfs4_1&#39; indicates NFSv4.1 connections.</value>
        [DataMember(Name="supportedProtocols", EmitDefaultValue=true)]
        public List<SupportedProtocolsEnum> SupportedProtocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NutanixFSMountTargetInfo" /> class.
        /// </summary>
        /// <param name="description">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="extId">Specifies information about the contact for the NutanixFS Prism Mount Target such as a name, phone number, and email address..</param>
        /// <param name="isLongNameEnabled">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="isNfs41Enabled">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="maxSizeInGib">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="name">Specifies where this NutanixFS Prism Mount Target is located. This location identification string is configured by the NutanixFS system administrator. This field does not contain the NutanixFS Prism Mount Target hostname or IP address..</param>
        /// <param name="nfsProperties">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="path">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="shareType">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. Specifies the NutanixFS share types supported in NutanixFS environment &#39;kStandard&#39; indicates a standard share type. &#39;kDistributed&#39; indicates a distributed share type..</param>
        /// <param name="smbProperties">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="state">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="statusType">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx..</param>
        /// <param name="supportedProtocols">Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx. &#39;kNfs&#39; indicates NFS connections. &#39;kSmb&#39; indicates SMB connections. &#39;kNfs4_1&#39; indicates NFSv4.1 connections..</param>
        public NutanixFSMountTargetInfo(string description = default(string), string extId = default(string), string isLongNameEnabled = default(string), string isNfs41Enabled = default(string), string maxSizeInGib = default(string), string name = default(string), string nfsProperties = default(string), string path = default(string), ShareTypeEnum? shareType = default(ShareTypeEnum?), string smbProperties = default(string), string state = default(string), string statusType = default(string), List<SupportedProtocolsEnum> supportedProtocols = default(List<SupportedProtocolsEnum>))
        {
            this.Description = description;
            this.ExtId = extId;
            this.IsLongNameEnabled = isLongNameEnabled;
            this.IsNfs41Enabled = isNfs41Enabled;
            this.MaxSizeInGib = maxSizeInGib;
            this.Name = name;
            this.NfsProperties = nfsProperties;
            this.Path = path;
            this.ShareType = shareType;
            this.SmbProperties = smbProperties;
            this.State = state;
            this.StatusType = statusType;
            this.SupportedProtocols = supportedProtocols;
            this.Description = description;
            this.ExtId = extId;
            this.IsLongNameEnabled = isLongNameEnabled;
            this.IsNfs41Enabled = isNfs41Enabled;
            this.MaxSizeInGib = maxSizeInGib;
            this.Name = name;
            this.NfsProperties = nfsProperties;
            this.Path = path;
            this.ShareType = shareType;
            this.SmbProperties = smbProperties;
            this.State = state;
            this.StatusType = statusType;
            this.SupportedProtocols = supportedProtocols;
        }
        
        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies information about the contact for the NutanixFS Prism Mount Target such as a name, phone number, and email address.
        /// </summary>
        /// <value>Specifies information about the contact for the NutanixFS Prism Mount Target such as a name, phone number, and email address.</value>
        [DataMember(Name="extId", EmitDefaultValue=true)]
        public string ExtId { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="isLongNameEnabled", EmitDefaultValue=true)]
        public string IsLongNameEnabled { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="isNfs41Enabled", EmitDefaultValue=true)]
        public string IsNfs41Enabled { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="maxSizeInGib", EmitDefaultValue=true)]
        public string MaxSizeInGib { get; set; }

        /// <summary>
        /// Specifies where this NutanixFS Prism Mount Target is located. This location identification string is configured by the NutanixFS system administrator. This field does not contain the NutanixFS Prism Mount Target hostname or IP address.
        /// </summary>
        /// <value>Specifies where this NutanixFS Prism Mount Target is located. This location identification string is configured by the NutanixFS system administrator. This field does not contain the NutanixFS Prism Mount Target hostname or IP address.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="nfsProperties", EmitDefaultValue=true)]
        public string NfsProperties { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="smbProperties", EmitDefaultValue=true)]
        public string SmbProperties { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public string State { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Mount Target in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="statusType", EmitDefaultValue=true)]
        public string StatusType { get; set; }

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
            return this.Equals(input as NutanixFSMountTargetInfo);
        }

        /// <summary>
        /// Returns true if NutanixFSMountTargetInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NutanixFSMountTargetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutanixFSMountTargetInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtId == input.ExtId ||
                    (this.ExtId != null &&
                    this.ExtId.Equals(input.ExtId))
                ) && 
                (
                    this.IsLongNameEnabled == input.IsLongNameEnabled ||
                    (this.IsLongNameEnabled != null &&
                    this.IsLongNameEnabled.Equals(input.IsLongNameEnabled))
                ) && 
                (
                    this.IsNfs41Enabled == input.IsNfs41Enabled ||
                    (this.IsNfs41Enabled != null &&
                    this.IsNfs41Enabled.Equals(input.IsNfs41Enabled))
                ) && 
                (
                    this.MaxSizeInGib == input.MaxSizeInGib ||
                    (this.MaxSizeInGib != null &&
                    this.MaxSizeInGib.Equals(input.MaxSizeInGib))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NfsProperties == input.NfsProperties ||
                    (this.NfsProperties != null &&
                    this.NfsProperties.Equals(input.NfsProperties))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ShareType == input.ShareType ||
                    this.ShareType.Equals(input.ShareType)
                ) && 
                (
                    this.SmbProperties == input.SmbProperties ||
                    (this.SmbProperties != null &&
                    this.SmbProperties.Equals(input.SmbProperties))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StatusType == input.StatusType ||
                    (this.StatusType != null &&
                    this.StatusType.Equals(input.StatusType))
                ) && 
                (
                    this.SupportedProtocols == input.SupportedProtocols ||
                    this.SupportedProtocols.SequenceEqual(input.SupportedProtocols)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtId != null)
                    hashCode = hashCode * 59 + this.ExtId.GetHashCode();
                if (this.IsLongNameEnabled != null)
                    hashCode = hashCode * 59 + this.IsLongNameEnabled.GetHashCode();
                if (this.IsNfs41Enabled != null)
                    hashCode = hashCode * 59 + this.IsNfs41Enabled.GetHashCode();
                if (this.MaxSizeInGib != null)
                    hashCode = hashCode * 59 + this.MaxSizeInGib.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NfsProperties != null)
                    hashCode = hashCode * 59 + this.NfsProperties.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.SmbProperties != null)
                    hashCode = hashCode * 59 + this.SmbProperties.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StatusType != null)
                    hashCode = hashCode * 59 + this.StatusType.GetHashCode();
                hashCode = hashCode * 59 + this.SupportedProtocols.GetHashCode();
                return hashCode;
            }
        }

    }

}

