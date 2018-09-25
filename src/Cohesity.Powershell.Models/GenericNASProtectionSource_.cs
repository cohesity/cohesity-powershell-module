// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about a Generic NAS Protection Source when the environment is set to &#39;kGenericNas&#39;.
    /// </summary>
    [DataContract]
    public partial class GenericNASProtectionSource_ :  IEquatable<GenericNASProtectionSource_>
    {
        /// <summary>
        /// Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.
        /// </summary>
        /// <value>Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
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
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public ProtocolEnum? Protocol { get; set; }
        /// <summary>
        /// Specifies the type of a Protection Source Object in a generic NAS Source such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted.
        /// </summary>
        /// <value>Specifies the type of a Protection Source Object in a generic NAS Source such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
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
            KHost = 2
        }

        /// <summary>
        /// Specifies the type of a Protection Source Object in a generic NAS Source such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted.
        /// </summary>
        /// <value>Specifies the type of a Protection Source Object in a generic NAS Source such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericNASProtectionSource_" /> class.
        /// </summary>
        /// <param name="description">Specifies a description about the Protection Source..</param>
        /// <param name="mountPath">Specifies the mount path of this NAS. For example, for a NFS mount point, this should be in the format of IP or hostname:/foo/bar..</param>
        /// <param name="name">Specifies the name of the NetApp Object..</param>
        /// <param name="protocol">Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol..</param>
        /// <param name="type">Specifies the type of a Protection Source Object in a generic NAS Source such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted..</param>
        public GenericNASProtectionSource_(string description = default(string), string mountPath = default(string), string name = default(string), ProtocolEnum? protocol = default(ProtocolEnum?), TypeEnum? type = default(TypeEnum?))
        {
            this.Description = description;
            this.MountPath = mountPath;
            this.Name = name;
            this.Protocol = protocol;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies a description about the Protection Source.
        /// </summary>
        /// <value>Specifies a description about the Protection Source.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the mount path of this NAS. For example, for a NFS mount point, this should be in the format of IP or hostname:/foo/bar.
        /// </summary>
        /// <value>Specifies the mount path of this NAS. For example, for a NFS mount point, this should be in the format of IP or hostname:/foo/bar.</value>
        [DataMember(Name="mountPath", EmitDefaultValue=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// Specifies the name of the NetApp Object.
        /// </summary>
        /// <value>Specifies the name of the NetApp Object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



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
            return this.Equals(input as GenericNASProtectionSource_);
        }

        /// <summary>
        /// Returns true if GenericNASProtectionSource_ instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericNASProtectionSource_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericNASProtectionSource_ input)
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
                    this.MountPath == input.MountPath ||
                    (this.MountPath != null &&
                    this.MountPath.Equals(input.MountPath))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.MountPath != null)
                    hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

