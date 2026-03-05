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
    /// Specifies a Protection Source in a NutanixFS environment.
    /// </summary>
    [DataContract]
    public partial class NutanixFSProtectionSource :  IEquatable<NutanixFSProtectionSource>
    {
        /// <summary>
        /// Specifies the type of managed NutanixFS Object in a NutanixFS Protection Source such as &#39;kPrismCentral&#39;, &#39;kPrismElement&#39;, &#39;kFileServer&#39; or &#39;kMountTarget&#39;. &#39;kPrismCentral&#39; indicates a NutanixFS prism central as a protection source. &#39;kPrismElement&#39; indicates a NutanixFS prism element in a cluster as a protection source. &#39;kFileServer&#39; indicates a volume in NutanixFS file server as a protection source. &#39;kMountTarget&#39; indicates a volume in NutanixFS mount target as a protection source.
        /// </summary>
        /// <value>Specifies the type of managed NutanixFS Object in a NutanixFS Protection Source such as &#39;kPrismCentral&#39;, &#39;kPrismElement&#39;, &#39;kFileServer&#39; or &#39;kMountTarget&#39;. &#39;kPrismCentral&#39; indicates a NutanixFS prism central as a protection source. &#39;kPrismElement&#39; indicates a NutanixFS prism element in a cluster as a protection source. &#39;kFileServer&#39; indicates a volume in NutanixFS file server as a protection source. &#39;kMountTarget&#39; indicates a volume in NutanixFS mount target as a protection source.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KPrismCentral for value: kPrismCentral
            /// </summary>
            [EnumMember(Value = "kPrismCentral")]
            KPrismCentral = 1,

            /// <summary>
            /// Enum KPrismElement for value: kPrismElement
            /// </summary>
            [EnumMember(Value = "kPrismElement")]
            KPrismElement = 2,

            /// <summary>
            /// Enum KFileServer for value: kFileServer
            /// </summary>
            [EnumMember(Value = "kFileServer")]
            KFileServer = 3,

            /// <summary>
            /// Enum KMountTarget for value: kMountTarget
            /// </summary>
            [EnumMember(Value = "kMountTarget")]
            KMountTarget = 4

        }

        /// <summary>
        /// Specifies the type of managed NutanixFS Object in a NutanixFS Protection Source such as &#39;kPrismCentral&#39;, &#39;kPrismElement&#39;, &#39;kFileServer&#39; or &#39;kMountTarget&#39;. &#39;kPrismCentral&#39; indicates a NutanixFS prism central as a protection source. &#39;kPrismElement&#39; indicates a NutanixFS prism element in a cluster as a protection source. &#39;kFileServer&#39; indicates a volume in NutanixFS file server as a protection source. &#39;kMountTarget&#39; indicates a volume in NutanixFS mount target as a protection source.
        /// </summary>
        /// <value>Specifies the type of managed NutanixFS Object in a NutanixFS Protection Source such as &#39;kPrismCentral&#39;, &#39;kPrismElement&#39;, &#39;kFileServer&#39; or &#39;kMountTarget&#39;. &#39;kPrismCentral&#39; indicates a NutanixFS prism central as a protection source. &#39;kPrismElement&#39; indicates a NutanixFS prism element in a cluster as a protection source. &#39;kFileServer&#39; indicates a volume in NutanixFS file server as a protection source. &#39;kMountTarget&#39; indicates a volume in NutanixFS mount target as a protection source.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NutanixFSProtectionSource" /> class.
        /// </summary>
        /// <param name="extId">Specifies the globally unique ID of this Object assigned by the NutanixFS server..</param>
        /// <param name="fileServerInfo">fileServerInfo.</param>
        /// <param name="isTopLevel">Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type..</param>
        /// <param name="mountTargetInfo">mountTargetInfo.</param>
        /// <param name="name">Specifies the name of the NutanixFS Object..</param>
        /// <param name="prismCentralInfo">prismCentralInfo.</param>
        /// <param name="prismElementInfo">prismElementInfo.</param>
        /// <param name="type">Specifies the type of managed NutanixFS Object in a NutanixFS Protection Source such as &#39;kPrismCentral&#39;, &#39;kPrismElement&#39;, &#39;kFileServer&#39; or &#39;kMountTarget&#39;. &#39;kPrismCentral&#39; indicates a NutanixFS prism central as a protection source. &#39;kPrismElement&#39; indicates a NutanixFS prism element in a cluster as a protection source. &#39;kFileServer&#39; indicates a volume in NutanixFS file server as a protection source. &#39;kMountTarget&#39; indicates a volume in NutanixFS mount target as a protection source..</param>
        public NutanixFSProtectionSource(string extId = default(string), NutanixFSFileServerInfo fileServerInfo = default(NutanixFSFileServerInfo), bool? isTopLevel = default(bool?), NutanixFSMountTargetInfo mountTargetInfo = default(NutanixFSMountTargetInfo), string name = default(string), NutanixFSPrismCentralInfo prismCentralInfo = default(NutanixFSPrismCentralInfo), NutanixFSPrismElementInfo prismElementInfo = default(NutanixFSPrismElementInfo), TypeEnum? type = default(TypeEnum?))
        {
            this.ExtId = extId;
            this.IsTopLevel = isTopLevel;
            this.Name = name;
            this.Type = type;
            this.ExtId = extId;
            this.FileServerInfo = fileServerInfo;
            this.IsTopLevel = isTopLevel;
            this.MountTargetInfo = mountTargetInfo;
            this.Name = name;
            this.PrismCentralInfo = prismCentralInfo;
            this.PrismElementInfo = prismElementInfo;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the globally unique ID of this Object assigned by the NutanixFS server.
        /// </summary>
        /// <value>Specifies the globally unique ID of this Object assigned by the NutanixFS server.</value>
        [DataMember(Name="extId", EmitDefaultValue=true)]
        public string ExtId { get; set; }

        /// <summary>
        /// Gets or Sets FileServerInfo
        /// </summary>
        [DataMember(Name="fileServerInfo", EmitDefaultValue=false)]
        public NutanixFSFileServerInfo FileServerInfo { get; set; }

        /// <summary>
        /// Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type.
        /// </summary>
        /// <value>Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type.</value>
        [DataMember(Name="isTopLevel", EmitDefaultValue=true)]
        public bool? IsTopLevel { get; set; }

        /// <summary>
        /// Gets or Sets MountTargetInfo
        /// </summary>
        [DataMember(Name="mountTargetInfo", EmitDefaultValue=false)]
        public NutanixFSMountTargetInfo MountTargetInfo { get; set; }

        /// <summary>
        /// Specifies the name of the NutanixFS Object.
        /// </summary>
        /// <value>Specifies the name of the NutanixFS Object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PrismCentralInfo
        /// </summary>
        [DataMember(Name="prismCentralInfo", EmitDefaultValue=false)]
        public NutanixFSPrismCentralInfo PrismCentralInfo { get; set; }

        /// <summary>
        /// Gets or Sets PrismElementInfo
        /// </summary>
        [DataMember(Name="prismElementInfo", EmitDefaultValue=false)]
        public NutanixFSPrismElementInfo PrismElementInfo { get; set; }

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
            return this.Equals(input as NutanixFSProtectionSource);
        }

        /// <summary>
        /// Returns true if NutanixFSProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of NutanixFSProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutanixFSProtectionSource input)
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
                    this.FileServerInfo == input.FileServerInfo ||
                    (this.FileServerInfo != null &&
                    this.FileServerInfo.Equals(input.FileServerInfo))
                ) && 
                (
                    this.IsTopLevel == input.IsTopLevel ||
                    (this.IsTopLevel != null &&
                    this.IsTopLevel.Equals(input.IsTopLevel))
                ) && 
                (
                    this.MountTargetInfo == input.MountTargetInfo ||
                    (this.MountTargetInfo != null &&
                    this.MountTargetInfo.Equals(input.MountTargetInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrismCentralInfo == input.PrismCentralInfo ||
                    (this.PrismCentralInfo != null &&
                    this.PrismCentralInfo.Equals(input.PrismCentralInfo))
                ) && 
                (
                    this.PrismElementInfo == input.PrismElementInfo ||
                    (this.PrismElementInfo != null &&
                    this.PrismElementInfo.Equals(input.PrismElementInfo))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.FileServerInfo != null)
                    hashCode = hashCode * 59 + this.FileServerInfo.GetHashCode();
                if (this.IsTopLevel != null)
                    hashCode = hashCode * 59 + this.IsTopLevel.GetHashCode();
                if (this.MountTargetInfo != null)
                    hashCode = hashCode * 59 + this.MountTargetInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PrismCentralInfo != null)
                    hashCode = hashCode * 59 + this.PrismCentralInfo.GetHashCode();
                if (this.PrismElementInfo != null)
                    hashCode = hashCode * 59 + this.PrismElementInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

