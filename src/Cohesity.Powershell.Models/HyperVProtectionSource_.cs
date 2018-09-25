// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about a HyperV Protection Source when the environment is set to &#39;kHyperV&#39;.
    /// </summary>
    [DataContract]
    public partial class HyperVProtectionSource_ :  IEquatable<HyperVProtectionSource_>
    {
        /// <summary>
        /// Specifies the type of backup supported by the VM. &#39;kRctBackup&#39;, &#39;kVssBackup&#39; Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.
        /// </summary>
        /// <value>Specifies the type of backup supported by the VM. &#39;kRctBackup&#39;, &#39;kVssBackup&#39; Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackupTypeEnum
        {
            
            /// <summary>
            /// Enum KRctBackup for value: kRctBackup
            /// </summary>
            [EnumMember(Value = "kRctBackup")]
            KRctBackup = 1,
            
            /// <summary>
            /// Enum KVssBackup for value: kVssBackup
            /// </summary>
            [EnumMember(Value = "kVssBackup")]
            KVssBackup = 2
        }

        /// <summary>
        /// Specifies the type of backup supported by the VM. &#39;kRctBackup&#39;, &#39;kVssBackup&#39; Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.
        /// </summary>
        /// <value>Specifies the type of backup supported by the VM. &#39;kRctBackup&#39;, &#39;kVssBackup&#39; Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.</value>
        [DataMember(Name="backupType", EmitDefaultValue=false)]
        public BackupTypeEnum? BackupType { get; set; }
        /// <summary>
        /// Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
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
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 3
        }

        /// <summary>
        /// Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object.
        /// </summary>
        /// <value>Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KSCVMMServer for value: kSCVMMServer
            /// </summary>
            [EnumMember(Value = "kSCVMMServer")]
            KSCVMMServer = 1,
            
            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 2,
            
            /// <summary>
            /// Enum KStandaloneCluster for value: kStandaloneCluster
            /// </summary>
            [EnumMember(Value = "kStandaloneCluster")]
            KStandaloneCluster = 3,
            
            /// <summary>
            /// Enum KHostGroup for value: kHostGroup
            /// </summary>
            [EnumMember(Value = "kHostGroup")]
            KHostGroup = 4,
            
            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 5,
            
            /// <summary>
            /// Enum KHostCluster for value: kHostCluster
            /// </summary>
            [EnumMember(Value = "kHostCluster")]
            KHostCluster = 6,
            
            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 7,
            
            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 8,
            
            /// <summary>
            /// Enum KDatastore for value: kDatastore
            /// </summary>
            [EnumMember(Value = "kDatastore")]
            KDatastore = 9,

            /// <summary>
            /// Enum KHypervHost for value: kHypervHost
            /// </summary>
            [EnumMember(Value = "kHypervHost")]
            KHypervHost = 10
        }

        /// <summary>
        /// Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object.
        /// </summary>
        /// <value>Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperVProtectionSource_" /> class.
        /// </summary>
        /// <param name="agentInfo">Specifies information about the agent running on the HyperV objects..</param>
        /// <param name="backupType">Specifies the type of backup supported by the VM. &#39;kRctBackup&#39;, &#39;kVssBackup&#39; Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS..</param>
        /// <param name="clusterName">Specifies the cluster name for &#39;kHostCluster&#39; objects..</param>
        /// <param name="datastoreInfo">Specifies additional information for &#39;kDatastore&#39; objects..</param>
        /// <param name="description">Specifies a description about the Protection Source..</param>
        /// <param name="hostType">Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system..</param>
        /// <param name="hypervUuid">Specifies the UUID for &#39;kVirtualMachine&#39; HyperV objects..</param>
        /// <param name="name">Specifies the name of the HyperV Object..</param>
        /// <param name="type">Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object..</param>
        /// <param name="uuid">Specifies the UUID of the Object. This is unique within the HyperV environment..</param>
        /// <param name="vmInfo">Specifies additional information for &#39;kVirtualMachine&#39; objects..</param>
        public HyperVProtectionSource_(AgentInformation agentInfo = default(AgentInformation), BackupTypeEnum? backupType = default(BackupTypeEnum?), string clusterName = default(string), HypervDatastore datastoreInfo = default(HypervDatastore), string description = default(string), HostTypeEnum? hostType = default(HostTypeEnum?), string hypervUuid = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string), HypervVirtualMachine vmInfo = default(HypervVirtualMachine))
        {
            this.AgentInfo = agentInfo;
            this.BackupType = backupType;
            this.ClusterName = clusterName;
            this.DatastoreInfo = datastoreInfo;
            this.Description = description;
            this.HostType = hostType;
            this.HypervUuid = hypervUuid;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.VmInfo = vmInfo;
        }
        
        /// <summary>
        /// Specifies information about the agent running on the HyperV objects.
        /// </summary>
        /// <value>Specifies information about the agent running on the HyperV objects.</value>
        [DataMember(Name="agentInfo", EmitDefaultValue=false)]
        public AgentInformation AgentInfo { get; set; }


        /// <summary>
        /// Specifies the cluster name for &#39;kHostCluster&#39; objects.
        /// </summary>
        /// <value>Specifies the cluster name for &#39;kHostCluster&#39; objects.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies additional information for &#39;kDatastore&#39; objects.
        /// </summary>
        /// <value>Specifies additional information for &#39;kDatastore&#39; objects.</value>
        [DataMember(Name="datastoreInfo", EmitDefaultValue=false)]
        public HypervDatastore DatastoreInfo { get; set; }

        /// <summary>
        /// Specifies a description about the Protection Source.
        /// </summary>
        /// <value>Specifies a description about the Protection Source.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Specifies the UUID for &#39;kVirtualMachine&#39; HyperV objects.
        /// </summary>
        /// <value>Specifies the UUID for &#39;kVirtualMachine&#39; HyperV objects.</value>
        [DataMember(Name="hypervUuid", EmitDefaultValue=false)]
        public string HypervUuid { get; set; }

        /// <summary>
        /// Specifies the name of the HyperV Object.
        /// </summary>
        /// <value>Specifies the name of the HyperV Object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the UUID of the Object. This is unique within the HyperV environment.
        /// </summary>
        /// <value>Specifies the UUID of the Object. This is unique within the HyperV environment.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies additional information for &#39;kVirtualMachine&#39; objects.
        /// </summary>
        /// <value>Specifies additional information for &#39;kVirtualMachine&#39; objects.</value>
        [DataMember(Name="vmInfo", EmitDefaultValue=false)]
        public HypervVirtualMachine VmInfo { get; set; }

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
            return this.Equals(input as HyperVProtectionSource_);
        }

        /// <summary>
        /// Returns true if HyperVProtectionSource_ instances are equal
        /// </summary>
        /// <param name="input">Instance of HyperVProtectionSource_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperVProtectionSource_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentInfo == input.AgentInfo ||
                    (this.AgentInfo != null &&
                    this.AgentInfo.Equals(input.AgentInfo))
                ) && 
                (
                    this.BackupType == input.BackupType ||
                    (this.BackupType != null &&
                    this.BackupType.Equals(input.BackupType))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.DatastoreInfo == input.DatastoreInfo ||
                    (this.DatastoreInfo != null &&
                    this.DatastoreInfo.Equals(input.DatastoreInfo))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.HypervUuid == input.HypervUuid ||
                    (this.HypervUuid != null &&
                    this.HypervUuid.Equals(input.HypervUuid))
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
                    this.VmInfo == input.VmInfo ||
                    (this.VmInfo != null &&
                    this.VmInfo.Equals(input.VmInfo))
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
                if (this.AgentInfo != null)
                    hashCode = hashCode * 59 + this.AgentInfo.GetHashCode();
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.DatastoreInfo != null)
                    hashCode = hashCode * 59 + this.DatastoreInfo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.HypervUuid != null)
                    hashCode = hashCode * 59 + this.HypervUuid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VmInfo != null)
                    hashCode = hashCode * 59 + this.VmInfo.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

