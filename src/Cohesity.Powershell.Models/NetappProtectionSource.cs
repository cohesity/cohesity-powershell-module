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
    /// Specifies a Protection Source in a NetApp environment.
    /// </summary>
    [DataContract]
    public partial class NetappProtectionSource :  IEquatable<NetappProtectionSource>
    {
        /// <summary>
        /// Defines LicenseTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LicenseTypesEnum
        {
            /// <summary>
            /// Enum KSnapmirrorCloud for value: kSnapmirrorCloud
            /// </summary>
            [EnumMember(Value = "kSnapmirrorCloud")]
            KSnapmirrorCloud = 1

        }


        /// <summary>
        /// Specifies the type of license available on Netapp Cluster &#39;kSnapmirrorCloud&#39; indicates a SnapMirror license on Netapp.
        /// </summary>
        /// <value>Specifies the type of license available on Netapp Cluster &#39;kSnapmirrorCloud&#39; indicates a SnapMirror license on Netapp.</value>
        [DataMember(Name="licenseTypes", EmitDefaultValue=true)]
        public List<LicenseTypesEnum> LicenseTypes { get; set; }
        /// <summary>
        /// Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.
        /// </summary>
        /// <value>Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KVserver for value: kVserver
            /// </summary>
            [EnumMember(Value = "kVserver")]
            KVserver = 2,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 3

        }

        /// <summary>
        /// Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.
        /// </summary>
        /// <value>Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetappProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterInfo">clusterInfo.</param>
        /// <param name="isTopLevel">Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type..</param>
        /// <param name="licenseTypes">Specifies the type of license available on Netapp Cluster &#39;kSnapmirrorCloud&#39; indicates a SnapMirror license on Netapp..</param>
        /// <param name="name">Specifies the name of the NetApp Object..</param>
        /// <param name="type">Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;. &#39;kCluster&#39; indicates a Netapp cluster as a protection source. &#39;kVserver&#39; indicates a Netapp vserver in a cluster as a protection source. &#39;kVolume&#39; indicates  a volume in Netapp vserver as a protection source..</param>
        /// <param name="uuid">Specifies the globally unique ID of this Object assigned by the NetApp server..</param>
        /// <param name="versionTuple">versionTuple.</param>
        /// <param name="volumeInfo">volumeInfo.</param>
        /// <param name="vserverInfo">vserverInfo.</param>
        public NetappProtectionSource(NetappClusterInfo clusterInfo = default(NetappClusterInfo), bool? isTopLevel = default(bool?), List<LicenseTypesEnum> licenseTypes = default(List<LicenseTypesEnum>), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string), NetappVersionTuple versionTuple = default(NetappVersionTuple), NetappVolumeInfo volumeInfo = default(NetappVolumeInfo), NetappVserverInfo vserverInfo = default(NetappVserverInfo))
        {
            this.ClusterInfo = clusterInfo;
            this.IsTopLevel = isTopLevel;
            this.LicenseTypes = licenseTypes;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.VersionTuple = versionTuple;
            this.VolumeInfo = volumeInfo;
            this.VserverInfo = vserverInfo;
        }
        
        /// <summary>
        /// Gets or Sets ClusterInfo
        /// </summary>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public NetappClusterInfo ClusterInfo { get; set; }

        /// <summary>
        /// Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type.
        /// </summary>
        /// <value>Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type.</value>
        [DataMember(Name="isTopLevel", EmitDefaultValue=true)]
        public bool? IsTopLevel { get; set; }

        /// <summary>
        /// Specifies the name of the NetApp Object.
        /// </summary>
        /// <value>Specifies the name of the NetApp Object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the globally unique ID of this Object assigned by the NetApp server.
        /// </summary>
        /// <value>Specifies the globally unique ID of this Object assigned by the NetApp server.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets VersionTuple
        /// </summary>
        [DataMember(Name="versionTuple", EmitDefaultValue=false)]
        public NetappVersionTuple VersionTuple { get; set; }

        /// <summary>
        /// Gets or Sets VolumeInfo
        /// </summary>
        [DataMember(Name="volumeInfo", EmitDefaultValue=false)]
        public NetappVolumeInfo VolumeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VserverInfo
        /// </summary>
        [DataMember(Name="vserverInfo", EmitDefaultValue=false)]
        public NetappVserverInfo VserverInfo { get; set; }

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
            return this.Equals(input as NetappProtectionSource);
        }

        /// <summary>
        /// Returns true if NetappProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of NetappProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetappProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterInfo == input.ClusterInfo ||
                    (this.ClusterInfo != null &&
                    this.ClusterInfo.Equals(input.ClusterInfo))
                ) && 
                (
                    this.IsTopLevel == input.IsTopLevel ||
                    (this.IsTopLevel != null &&
                    this.IsTopLevel.Equals(input.IsTopLevel))
                ) && 
                (
                    this.LicenseTypes == input.LicenseTypes ||
                    this.LicenseTypes.Equals(input.LicenseTypes)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.VersionTuple == input.VersionTuple ||
                    (this.VersionTuple != null &&
                    this.VersionTuple.Equals(input.VersionTuple))
                ) && 
                (
                    this.VolumeInfo == input.VolumeInfo ||
                    (this.VolumeInfo != null &&
                    this.VolumeInfo.Equals(input.VolumeInfo))
                ) && 
                (
                    this.VserverInfo == input.VserverInfo ||
                    (this.VserverInfo != null &&
                    this.VserverInfo.Equals(input.VserverInfo))
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
                if (this.ClusterInfo != null)
                    hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.IsTopLevel != null)
                    hashCode = hashCode * 59 + this.IsTopLevel.GetHashCode();
                if (this.LicenseTypes != null)
					hashCode = hashCode * 59 + this.LicenseTypes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
					hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VersionTuple != null)
                    hashCode = hashCode * 59 + this.VersionTuple.GetHashCode();
                if (this.VolumeInfo != null)
                    hashCode = hashCode * 59 + this.VolumeInfo.GetHashCode();
                if (this.VserverInfo != null)
                    hashCode = hashCode * 59 + this.VserverInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

