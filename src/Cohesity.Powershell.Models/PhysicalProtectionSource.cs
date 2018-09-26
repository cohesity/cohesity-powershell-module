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
    /// Specifies a Protection Source in a Physical environment.
    /// </summary>
    [DataContract]
    public partial class PhysicalProtectionSource :  IEquatable<PhysicalProtectionSource>
    {
        /// <summary>
        /// Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
        {
            
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,
            
            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 5
        }

        /// <summary>
        /// Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the type of managed Object in a Physical Protection Source. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.
        /// </summary>
        /// <value>Specifies the type of managed Object in a Physical Protection Source. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 1,
            
            /// <summary>
            /// Enum KWindowsCluster for value: kWindowsCluster
            /// </summary>
            [EnumMember(Value = "kWindowsCluster")]
            KWindowsCluster = 2,

            [EnumMember(Value = "kGroup")]
            kGroup = 3

        }

        /// <summary>
        /// Specifies the type of managed Object in a Physical Protection Source. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.
        /// </summary>
        /// <value>Specifies the type of managed Object in a Physical Protection Source. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalProtectionSource" /> class.
        /// </summary>
        /// <param name="agents">Specifiles the agents running on the Physical Protection Source and the status information..</param>
        /// <param name="hostType">Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system..</param>
        /// <param name="id">id.</param>
        /// <param name="name">Specifies a human readable name of the Protection Source..</param>
        /// <param name="type">Specifies the type of managed Object in a Physical Protection Source. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster..</param>
        /// <param name="volumes">Specifies the volumes available on the physical host. These fields are populated only for the kPhysicalHost type..</param>
        public PhysicalProtectionSource(List<AgentInformation> agents = default(List<AgentInformation>), HostTypeEnum? hostType = default(HostTypeEnum?), UniqueGlobalId4 id = default(UniqueGlobalId4), string name = default(string), TypeEnum? type = default(TypeEnum?), List<PhysicalVolume> volumes = default(List<PhysicalVolume>))
        {
            this.Agents = agents;
            this.HostType = hostType;
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Volumes = volumes;
        }
        
        /// <summary>
        /// Specifiles the agents running on the Physical Protection Source and the status information.
        /// </summary>
        /// <value>Specifiles the agents running on the Physical Protection Source and the status information.</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<AgentInformation> Agents { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public UniqueGlobalId4 Id { get; set; }

        /// <summary>
        /// Specifies a human readable name of the Protection Source.
        /// </summary>
        /// <value>Specifies a human readable name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the volumes available on the physical host. These fields are populated only for the kPhysicalHost type.
        /// </summary>
        /// <value>Specifies the volumes available on the physical host. These fields are populated only for the kPhysicalHost type.</value>
        [DataMember(Name="volumes", EmitDefaultValue=false)]
        public List<PhysicalVolume> Volumes { get; set; }

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
            return this.Equals(input as PhysicalProtectionSource);
        }

        /// <summary>
        /// Returns true if PhysicalProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Agents == input.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(input.Agents)
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Volumes == input.Volumes ||
                    this.Volumes != null &&
                    this.Volumes.SequenceEqual(input.Volumes)
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
                if (this.Agents != null)
                    hashCode = hashCode * 59 + this.Agents.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Volumes != null)
                    hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

