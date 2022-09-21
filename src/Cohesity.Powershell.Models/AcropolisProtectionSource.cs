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
        /// Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object.
        /// </summary>
        /// <value>Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object.</value>
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
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 3,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 4,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 5,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 6,

            /// <summary>
            /// Enum KStorageContainer for value: kStorageContainer
            /// </summary>
            [EnumMember(Value = "kStorageContainer")]
            KStorageContainer = 7

        }


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
        /// <param name="type">Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc..</param>
        /// <param name="uuid">Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment..</param>
        /// <param name="version">Specifies the version of an Acropolis cluster or standalone cluster..</param>
        public AcropolisProtectionSource(string clusterUuid = default(string), string description = default(string), bool? mountPath = default(bool?), string name = default(string), List<int> ngtCapabilities = default(List<int>), int? ngtEnableStatus = default(int?), int? ngtInstallStatus = default(int?), bool? ngtReachable = default(bool?), string ngtVersion = default(string), int? type = default(int?), string uuid = default(string), string version = default(string))
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
            this.Type = type;
            this.Uuid = uuid;
            this.Version = version;
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
        /// Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc.
        /// </summary>
        /// <value>Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment.
        /// </summary>
        /// <value>Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies the version of an Acropolis cluster or standalone cluster.
        /// </summary>
        /// <value>Specifies the version of an Acropolis cluster or standalone cluster.</value>
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
                    this.NgtCapabilities.Equals(input.NgtCapabilities)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

