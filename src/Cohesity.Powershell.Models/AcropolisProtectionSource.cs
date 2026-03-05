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
    /// Specifies a Protection Source in Acropolis environment.
    /// </summary>
    [DataContract]
    public partial class AcropolisProtectionSource :  IEquatable<AcropolisProtectionSource>
    {
        /// <summary>
        /// Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc.
        /// </summary>
        /// <value>Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KPrismCentral for value: kPrismCentral
            /// </summary>
            [EnumMember(Value = "kPrismCentral")]
            KPrismCentral = 1,

            /// <summary>
            /// Enum KStandaloneCluster for value: kStandaloneCluster
            /// </summary>
            [EnumMember(Value = "kStandaloneCluster")]
            KStandaloneCluster = 2,

            /// <summary>
            /// Enum KOtherHypervisorCluster for value: kOtherHypervisorCluster
            /// </summary>
            [EnumMember(Value = "kOtherHypervisorCluster")]
            KOtherHypervisorCluster = 3,

            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 4,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 5,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 6,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 7,

            /// <summary>
            /// Enum KStorageContainer for value: kStorageContainer
            /// </summary>
            [EnumMember(Value = "kStorageContainer")]
            KStorageContainer = 8

        }

        /// <summary>
        /// Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc.
        /// </summary>
        /// <value>Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcropolisProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterUuid">Specifies the UUID of the Acropolis cluster instance to which this entity belongs to..</param>
        /// <param name="description">Specifies a description about the Protection Source..</param>
        /// <param name="mountPath">Specifies whether the VM is an agent VM. This is applicable to acropolis entity of type kVirtualMachine..</param>
        /// <param name="name">Specifies the name of the Acropolis Object..</param>
        /// <param name="ngtCapabilities">Specifies enabled capabilities for NGT on the VM. This is applicable to acropolis entity of type kVirtualMachine..</param>
        /// <param name="ngtEnableStatus">Specifies if NGT is enabled on the VM. This is applicable to acropolis entity of type kVirtualMachine..</param>
        /// <param name="ngtInstallStatus">Specified if NGT is installed on the VM. This is applicable to acropolis entity of type kVirtualMachine..</param>
        /// <param name="ngtReachable">Specifies if NGT on the VM is reachable from Controller VM. This is applicable to acropolis entity of type kVirtualMachine..</param>
        /// <param name="ngtVersion">Specifies version of NGT installed on the VM. This is applicable to acropolis entity of type kVirtualMachine..</param>
        /// <param name="systemDefined">SystemDefined indicates whether the tag or capability is system-defined (true) or user-defined (false). System-defined tags are generally managed internally by the platform and not meant to be edited by users..</param>
        /// <param name="tagAttributes">TagAttributes holds a list of additional attributes associated with the tag. These could include metadata like UUIDs, display names, and values for more detailed tag descriptions..</param>
        /// <param name="type">Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc..</param>
        /// <param name="uuid">Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment..</param>
        /// <param name="value">Value represents the actual value of the tag assigned to the entity. For example, if the tag is \&quot;Environment\&quot;, the value could be \&quot;Production\&quot;..</param>
        /// <param name="version">Specifies the version of an Acropolis cluster or standalone cluster..</param>
        /// <param name="virtualDisks">Specifies an array of virtual disks that are part of the Virtual Machine. This is populated for entities of type &#39;kVirtualMachine&#39;..</param>
        public AcropolisProtectionSource(string clusterUuid = default(string), string description = default(string), bool? mountPath = default(bool?), string name = default(string), List<int> ngtCapabilities = default(List<int>), int? ngtEnableStatus = default(int?), int? ngtInstallStatus = default(int?), bool? ngtReachable = default(bool?), string ngtVersion = default(string), bool? systemDefined = default(bool?), List<TagAttribute> tagAttributes = default(List<TagAttribute>), TypeEnum? type = default(TypeEnum?), string uuid = default(string), string value = default(string), string version = default(string), List<VirtualDiskConfig> virtualDisks = default(List<VirtualDiskConfig>))
        {
            this.ClusterUuid = clusterUuid;
            this.Description = description;
            this.MountPath = mountPath;
            this.Name = name;
            this.NgtCapabilities = ngtCapabilities;
            this.NgtEnableStatus = ngtEnableStatus;
            this.NgtInstallStatus = ngtInstallStatus;
            this.NgtReachable = ngtReachable;
            this.NgtVersion = ngtVersion;
            this.SystemDefined = systemDefined;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.Uuid = uuid;
            this.Value = value;
            this.Version = version;
            this.VirtualDisks = virtualDisks;
            this.ClusterUuid = clusterUuid;
            this.Description = description;
            this.MountPath = mountPath;
            this.Name = name;
            this.NgtCapabilities = ngtCapabilities;
            this.NgtEnableStatus = ngtEnableStatus;
            this.NgtInstallStatus = ngtInstallStatus;
            this.NgtReachable = ngtReachable;
            this.NgtVersion = ngtVersion;
            this.SystemDefined = systemDefined;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.Uuid = uuid;
            this.Value = value;
            this.Version = version;
            this.VirtualDisks = virtualDisks;
        }
        
        /// <summary>
        /// Specifies the UUID of the Acropolis cluster instance to which this entity belongs to.
        /// </summary>
        /// <value>Specifies the UUID of the Acropolis cluster instance to which this entity belongs to.</value>
        [DataMember(Name="clusterUuid", EmitDefaultValue=true)]
        public string ClusterUuid { get; set; }

        /// <summary>
        /// Specifies a description about the Protection Source.
        /// </summary>
        /// <value>Specifies a description about the Protection Source.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether the VM is an agent VM. This is applicable to acropolis entity of type kVirtualMachine.
        /// </summary>
        /// <value>Specifies whether the VM is an agent VM. This is applicable to acropolis entity of type kVirtualMachine.</value>
        [DataMember(Name="mountPath", EmitDefaultValue=true)]
        public bool? MountPath { get; set; }

        /// <summary>
        /// Specifies the name of the Acropolis Object.
        /// </summary>
        /// <value>Specifies the name of the Acropolis Object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies enabled capabilities for NGT on the VM. This is applicable to acropolis entity of type kVirtualMachine.
        /// </summary>
        /// <value>Specifies enabled capabilities for NGT on the VM. This is applicable to acropolis entity of type kVirtualMachine.</value>
        [DataMember(Name="ngtCapabilities", EmitDefaultValue=true)]
        public List<int> NgtCapabilities { get; set; }

        /// <summary>
        /// Specifies if NGT is enabled on the VM. This is applicable to acropolis entity of type kVirtualMachine.
        /// </summary>
        /// <value>Specifies if NGT is enabled on the VM. This is applicable to acropolis entity of type kVirtualMachine.</value>
        [DataMember(Name="ngtEnableStatus", EmitDefaultValue=true)]
        public int? NgtEnableStatus { get; set; }

        /// <summary>
        /// Specified if NGT is installed on the VM. This is applicable to acropolis entity of type kVirtualMachine.
        /// </summary>
        /// <value>Specified if NGT is installed on the VM. This is applicable to acropolis entity of type kVirtualMachine.</value>
        [DataMember(Name="ngtInstallStatus", EmitDefaultValue=true)]
        public int? NgtInstallStatus { get; set; }

        /// <summary>
        /// Specifies if NGT on the VM is reachable from Controller VM. This is applicable to acropolis entity of type kVirtualMachine.
        /// </summary>
        /// <value>Specifies if NGT on the VM is reachable from Controller VM. This is applicable to acropolis entity of type kVirtualMachine.</value>
        [DataMember(Name="ngtReachable", EmitDefaultValue=true)]
        public bool? NgtReachable { get; set; }

        /// <summary>
        /// Specifies version of NGT installed on the VM. This is applicable to acropolis entity of type kVirtualMachine.
        /// </summary>
        /// <value>Specifies version of NGT installed on the VM. This is applicable to acropolis entity of type kVirtualMachine.</value>
        [DataMember(Name="ngtVersion", EmitDefaultValue=true)]
        public string NgtVersion { get; set; }

        /// <summary>
        /// SystemDefined indicates whether the tag or capability is system-defined (true) or user-defined (false). System-defined tags are generally managed internally by the platform and not meant to be edited by users.
        /// </summary>
        /// <value>SystemDefined indicates whether the tag or capability is system-defined (true) or user-defined (false). System-defined tags are generally managed internally by the platform and not meant to be edited by users.</value>
        [DataMember(Name="systemDefined", EmitDefaultValue=true)]
        public bool? SystemDefined { get; set; }

        /// <summary>
        /// TagAttributes holds a list of additional attributes associated with the tag. These could include metadata like UUIDs, display names, and values for more detailed tag descriptions.
        /// </summary>
        /// <value>TagAttributes holds a list of additional attributes associated with the tag. These could include metadata like UUIDs, display names, and values for more detailed tag descriptions.</value>
        [DataMember(Name="tagAttributes", EmitDefaultValue=true)]
        public List<TagAttribute> TagAttributes { get; set; }

        /// <summary>
        /// Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment.
        /// </summary>
        /// <value>Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Value represents the actual value of the tag assigned to the entity. For example, if the tag is \&quot;Environment\&quot;, the value could be \&quot;Production\&quot;.
        /// </summary>
        /// <value>Value represents the actual value of the tag assigned to the entity. For example, if the tag is \&quot;Environment\&quot;, the value could be \&quot;Production\&quot;.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

        /// <summary>
        /// Specifies the version of an Acropolis cluster or standalone cluster.
        /// </summary>
        /// <value>Specifies the version of an Acropolis cluster or standalone cluster.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// Specifies an array of virtual disks that are part of the Virtual Machine. This is populated for entities of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>Specifies an array of virtual disks that are part of the Virtual Machine. This is populated for entities of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="virtualDisks", EmitDefaultValue=true)]
        public List<VirtualDiskConfig> VirtualDisks { get; set; }

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
            return this.Equals(input as AcropolisProtectionSource);
        }

        /// <summary>
        /// Returns true if AcropolisProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of AcropolisProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcropolisProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterUuid == input.ClusterUuid ||
                    (this.ClusterUuid != null &&
                    this.ClusterUuid.Equals(input.ClusterUuid))
                ) && 
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
                    this.NgtCapabilities == input.NgtCapabilities ||
                    this.NgtCapabilities != null &&
                    input.NgtCapabilities != null &&
                    this.NgtCapabilities.SequenceEqual(input.NgtCapabilities)
                ) && 
                (
                    this.NgtEnableStatus == input.NgtEnableStatus ||
                    (this.NgtEnableStatus != null &&
                    this.NgtEnableStatus.Equals(input.NgtEnableStatus))
                ) && 
                (
                    this.NgtInstallStatus == input.NgtInstallStatus ||
                    (this.NgtInstallStatus != null &&
                    this.NgtInstallStatus.Equals(input.NgtInstallStatus))
                ) && 
                (
                    this.NgtReachable == input.NgtReachable ||
                    (this.NgtReachable != null &&
                    this.NgtReachable.Equals(input.NgtReachable))
                ) && 
                (
                    this.NgtVersion == input.NgtVersion ||
                    (this.NgtVersion != null &&
                    this.NgtVersion.Equals(input.NgtVersion))
                ) && 
                (
                    this.SystemDefined == input.SystemDefined ||
                    (this.SystemDefined != null &&
                    this.SystemDefined.Equals(input.SystemDefined))
                ) && 
                (
                    this.TagAttributes == input.TagAttributes ||
                    this.TagAttributes != null &&
                    input.TagAttributes != null &&
                    this.TagAttributes.SequenceEqual(input.TagAttributes)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VirtualDisks == input.VirtualDisks ||
                    this.VirtualDisks != null &&
                    input.VirtualDisks != null &&
                    this.VirtualDisks.SequenceEqual(input.VirtualDisks)
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
                if (this.ClusterUuid != null)
                    hashCode = hashCode * 59 + this.ClusterUuid.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MountPath != null)
                    hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NgtCapabilities != null)
                    hashCode = hashCode * 59 + this.NgtCapabilities.GetHashCode();
                if (this.NgtEnableStatus != null)
                    hashCode = hashCode * 59 + this.NgtEnableStatus.GetHashCode();
                if (this.NgtInstallStatus != null)
                    hashCode = hashCode * 59 + this.NgtInstallStatus.GetHashCode();
                if (this.NgtReachable != null)
                    hashCode = hashCode * 59 + this.NgtReachable.GetHashCode();
                if (this.NgtVersion != null)
                    hashCode = hashCode * 59 + this.NgtVersion.GetHashCode();
                if (this.SystemDefined != null)
                    hashCode = hashCode * 59 + this.SystemDefined.GetHashCode();
                if (this.TagAttributes != null)
                    hashCode = hashCode * 59 + this.TagAttributes.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VirtualDisks != null)
                    hashCode = hashCode * 59 + this.VirtualDisks.GetHashCode();
                return hashCode;
            }
        }

    }

}

