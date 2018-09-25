// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a Protection Source in a NetApp environment.
    /// </summary>
    [DataContract]
    public partial class NetappProtectionSource :  IEquatable<NetappProtectionSource>
    {
        /// <summary>
        /// Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;.
        /// </summary>
        /// <value>Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;.</value>
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
        /// Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;.
        /// </summary>
        /// <value>Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetappProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterInfo">Specifies information about a NetApp cluster and is only valid for a NetApp Object of type kCluster..</param>
        /// <param name="isTopLevel">Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type..</param>
        /// <param name="name">Specifies the name of the NetApp Object..</param>
        /// <param name="type">Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;..</param>
        /// <param name="uuid">Specifies the globally unique ID of this Object assigned by the NetApp server..</param>
        /// <param name="volumeInfo">Specifies information about a NetApp volume and is only valid for a NetApp Object of type kVolume..</param>
        /// <param name="vserverInfo">Specifies information about a NetApp Vserver and is only valid for a NetApp Object of type kVserver..</param>
        public NetappProtectionSource(NetappClusterInfo clusterInfo = default(NetappClusterInfo), bool? isTopLevel = default(bool?), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string), NetappVolumeInfo volumeInfo = default(NetappVolumeInfo), NetappVserverInfo vserverInfo = default(NetappVserverInfo))
        {
            this.ClusterInfo = clusterInfo;
            this.IsTopLevel = isTopLevel;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.VolumeInfo = volumeInfo;
            this.VserverInfo = vserverInfo;
        }
        
        /// <summary>
        /// Specifies information about a NetApp cluster and is only valid for a NetApp Object of type kCluster.
        /// </summary>
        /// <value>Specifies information about a NetApp cluster and is only valid for a NetApp Object of type kCluster.</value>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public NetappClusterInfo ClusterInfo { get; set; }

        /// <summary>
        /// Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type.
        /// </summary>
        /// <value>Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type.</value>
        [DataMember(Name="isTopLevel", EmitDefaultValue=false)]
        public bool? IsTopLevel { get; set; }

        /// <summary>
        /// Specifies the name of the NetApp Object.
        /// </summary>
        /// <value>Specifies the name of the NetApp Object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the globally unique ID of this Object assigned by the NetApp server.
        /// </summary>
        /// <value>Specifies the globally unique ID of this Object assigned by the NetApp server.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies information about a NetApp volume and is only valid for a NetApp Object of type kVolume.
        /// </summary>
        /// <value>Specifies information about a NetApp volume and is only valid for a NetApp Object of type kVolume.</value>
        [DataMember(Name="volumeInfo", EmitDefaultValue=false)]
        public NetappVolumeInfo VolumeInfo { get; set; }

        /// <summary>
        /// Specifies information about a NetApp Vserver and is only valid for a NetApp Object of type kVserver.
        /// </summary>
        /// <value>Specifies information about a NetApp Vserver and is only valid for a NetApp Object of type kVserver.</value>
        [DataMember(Name="vserverInfo", EmitDefaultValue=false)]
        public NetappVserverInfo VserverInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VolumeInfo != null)
                    hashCode = hashCode * 59 + this.VolumeInfo.GetHashCode();
                if (this.VserverInfo != null)
                    hashCode = hashCode * 59 + this.VserverInfo.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

