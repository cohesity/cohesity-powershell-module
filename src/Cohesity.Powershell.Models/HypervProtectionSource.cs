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
    /// Specifies a Protection Source in HyperV environment.
    /// </summary>
    [DataContract]
    public partial class HypervProtectionSource :  IEquatable<HypervProtectionSource>
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
        [DataMember(Name="backupType", EmitDefaultValue=true)]
        public BackupTypeEnum? BackupType { get; set; }
        /// <summary>
        /// Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
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
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KSapOracle for value: kSapOracle
            /// </summary>
            [EnumMember(Value = "kSapOracle")]
            KSapOracle = 6,

            /// <summary>
            /// Enum KCockroachDB for value: kCockroachDB
            /// </summary>
            [EnumMember(Value = "kCockroachDB")]
            KCockroachDB = 7,

            /// <summary>
            /// Enum KMySQL for value: kMySQL
            /// </summary>
            [EnumMember(Value = "kMySQL")]
            KMySQL = 8,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 9

        }

        /// <summary>
        /// Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kHypervHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object. &#39;kTag&#39; indicates a tag type object. &#39;kCustomProperty&#39; indicates a custom property including tag type.
        /// </summary>
        /// <value>Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kHypervHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object. &#39;kTag&#39; indicates a tag type object. &#39;kCustomProperty&#39; indicates a custom property including tag type.</value>
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
            /// Enum KHypervHost for value: kHypervHost
            /// </summary>
            [EnumMember(Value = "kHypervHost")]
            KHypervHost = 5,

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
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 10,

            /// <summary>
            /// Enum KCustomProperty for value: kCustomProperty
            /// </summary>
            [EnumMember(Value = "kCustomProperty")]
            KCustomProperty = 11,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 12
        }

        /// <summary>
        /// Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kHypervHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object. &#39;kTag&#39; indicates a tag type object. &#39;kCustomProperty&#39; indicates a custom property including tag type.
        /// </summary>
        /// <value>Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kHypervHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object. &#39;kTag&#39; indicates a tag type object. &#39;kCustomProperty&#39; indicates a custom property including tag type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HypervProtectionSource" /> class.
        /// </summary>
        /// <param name="agents">Array of Agents on the Physical Protection Source.  Specifiles the agents running on the HyperV Protection Source and the status information..</param>
        /// <param name="backupType">Specifies the type of backup supported by the VM. &#39;kRctBackup&#39;, &#39;kVssBackup&#39; Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS..</param>
        /// <param name="buildNumber">Specifies the build number for HyperV SCVMM Servers..</param>
        /// <param name="clusterName">Specifies the cluster name for &#39;kHostCluster&#39; objects..</param>
        /// <param name="datastoreInfo">datastoreInfo.</param>
        /// <param name="description">Specifies a description about the Protection Source..</param>
        /// <param name="hostType">Specifies host OS type for &#39;kVirtualMachine&#39; objects. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="hypervUuid">Specifies the UUID for &#39;kVirtualMachine&#39; HyperV objects..</param>
        /// <param name="name">Specifies the name of the HyperV Object..</param>
        /// <param name="tagAttributes">Specifies the list of VM Tag attributes associated with this Object..</param>
        /// <param name="type">Specifies the type of an HyperV Protection Source Object such as &#39;kSCVMMServer&#39;, &#39;kStandaloneHost&#39;, &#39;kNetwork&#39;, etc. overrideDescription: true Specifies the type of an HyperV Protection Source. &#39;kSCVMMServer&#39; indicates a collection of root folders clusters. &#39;kStandaloneHost&#39; indicates a single Nutanix cluster. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kHostGroup&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kHypervHost&#39; indicates an HyperV host. &#39;kHostCluster&#39; indicates a Nutanix cluster managed by a Prism Central. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kDatastore&#39; represents a storage container object. &#39;kTag&#39; indicates a tag type object. &#39;kCustomProperty&#39; indicates a custom property including tag type..</param>
        /// <param name="uuid">Specifies the UUID of the Object. This is unique within the HyperV environment..</param>
        /// <param name="vmInfo">vmInfo.</param>
        /// <param name="windowsVersion">Specifies the windows version for HyperV hosts..</param>
        public HypervProtectionSource(List<AgentInformation> agents = default(List<AgentInformation>), BackupTypeEnum? backupType = default(BackupTypeEnum?), string buildNumber = default(string), string clusterName = default(string), HypervDatastore datastoreInfo = default(HypervDatastore), string description = default(string), HostTypeEnum? hostType = default(HostTypeEnum?), string hypervUuid = default(string), string name = default(string), List<TagAttribute> tagAttributes = default(List<TagAttribute>), TypeEnum? type = default(TypeEnum?), string uuid = default(string), HypervVirtualMachine vmInfo = default(HypervVirtualMachine), string windowsVersion = default(string))
        {
            this.Agents = agents;
            this.BackupType = backupType;
            this.BuildNumber = buildNumber;
            this.ClusterName = clusterName;
            this.DatastoreInfo = datastoreInfo;
            this.Description = description;
            this.HostType = hostType;
            this.HypervUuid = hypervUuid;
            this.Name = name;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.Uuid = uuid;
            this.WindowsVersion = windowsVersion;
            this.Agents = agents;
            this.BackupType = backupType;
            this.BuildNumber = buildNumber;
            this.ClusterName = clusterName;
            this.DatastoreInfo = datastoreInfo;
            this.Description = description;
            this.HostType = hostType;
            this.HypervUuid = hypervUuid;
            this.Name = name;
            this.TagAttributes = tagAttributes;
            this.Type = type;
            this.Uuid = uuid;
            this.VmInfo = vmInfo;
            this.WindowsVersion = windowsVersion;
        }
        
        /// <summary>
        /// Array of Agents on the Physical Protection Source.  Specifiles the agents running on the HyperV Protection Source and the status information.
        /// </summary>
        /// <value>Array of Agents on the Physical Protection Source.  Specifiles the agents running on the HyperV Protection Source and the status information.</value>
        [DataMember(Name="agents", EmitDefaultValue=true)]
        public List<AgentInformation> Agents { get; set; }

        /// <summary>
        /// Specifies the build number for HyperV SCVMM Servers.
        /// </summary>
        /// <value>Specifies the build number for HyperV SCVMM Servers.</value>
        [DataMember(Name="buildNumber", EmitDefaultValue=true)]
        public string BuildNumber { get; set; }

        /// <summary>
        /// Specifies the cluster name for &#39;kHostCluster&#39; objects.
        /// </summary>
        /// <value>Specifies the cluster name for &#39;kHostCluster&#39; objects.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or Sets DatastoreInfo
        /// </summary>
        [DataMember(Name="datastoreInfo", EmitDefaultValue=false)]
        public HypervDatastore DatastoreInfo { get; set; }

        /// <summary>
        /// Specifies a description about the Protection Source.
        /// </summary>
        /// <value>Specifies a description about the Protection Source.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the UUID for &#39;kVirtualMachine&#39; HyperV objects.
        /// </summary>
        /// <value>Specifies the UUID for &#39;kVirtualMachine&#39; HyperV objects.</value>
        [DataMember(Name="hypervUuid", EmitDefaultValue=true)]
        public string HypervUuid { get; set; }

        /// <summary>
        /// Specifies the name of the HyperV Object.
        /// </summary>
        /// <value>Specifies the name of the HyperV Object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the list of VM Tag attributes associated with this Object.
        /// </summary>
        /// <value>Specifies the list of VM Tag attributes associated with this Object.</value>
        [DataMember(Name="tagAttributes", EmitDefaultValue=true)]
        public List<TagAttribute> TagAttributes { get; set; }

        /// <summary>
        /// Specifies the UUID of the Object. This is unique within the HyperV environment.
        /// </summary>
        /// <value>Specifies the UUID of the Object. This is unique within the HyperV environment.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets VmInfo
        /// </summary>
        [DataMember(Name="vmInfo", EmitDefaultValue=false)]
        public HypervVirtualMachine VmInfo { get; set; }

        /// <summary>
        /// Specifies the windows version for HyperV hosts.
        /// </summary>
        /// <value>Specifies the windows version for HyperV hosts.</value>
        [DataMember(Name="windowsVersion", EmitDefaultValue=true)]
        public string WindowsVersion { get; set; }

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
            return this.Equals(input as HypervProtectionSource);
        }

        /// <summary>
        /// Returns true if HypervProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of HypervProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HypervProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Agents == input.Agents ||
                    this.Agents != null &&
                    input.Agents != null &&
                    this.Agents.Equals(input.Agents)
                ) && 
                (
                    this.BackupType == input.BackupType ||
                    this.BackupType.Equals(input.BackupType)
                ) && 
                (
                    this.BuildNumber == input.BuildNumber ||
                    (this.BuildNumber != null &&
                    this.BuildNumber.Equals(input.BuildNumber))
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
                    this.HostType.Equals(input.HostType)
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
                    this.TagAttributes == input.TagAttributes ||
                    this.TagAttributes != null &&
                    input.TagAttributes != null &&
                    this.TagAttributes.Equals(input.TagAttributes)
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
                    this.VmInfo == input.VmInfo ||
                    (this.VmInfo != null &&
                    this.VmInfo.Equals(input.VmInfo))
                ) && 
                (
                    this.WindowsVersion == input.WindowsVersion ||
                    (this.WindowsVersion != null &&
                    this.WindowsVersion.Equals(input.WindowsVersion))
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
                hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.BuildNumber != null)
                    hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.DatastoreInfo != null)
                    hashCode = hashCode * 59 + this.DatastoreInfo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.HypervUuid != null)
                    hashCode = hashCode * 59 + this.HypervUuid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TagAttributes != null)
                    hashCode = hashCode * 59 + this.TagAttributes.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VmInfo != null)
                    hashCode = hashCode * 59 + this.VmInfo.GetHashCode();
                if (this.WindowsVersion != null)
                    hashCode = hashCode * 59 + this.WindowsVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}

