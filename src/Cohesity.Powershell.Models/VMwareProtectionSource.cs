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
    /// Specifies a Protection Source in a VMware environment.
    /// </summary>
    [DataContract]
    public partial class VMwareProtectionSource :  IEquatable<VMwareProtectionSource>
    {
        /// <summary>
        /// Specifies the connection state of the Object and are only valid for ESXi hosts (&#39;kHostSystem&#39;) or Virtual Machines (&#39;kVirtualMachine&#39;). These enums are equivalent to the connection states documented in VMware&#39;s reference documentation. Examples of Cohesity connection states include &#39;kConnected&#39;, &#39;kDisconnected&#39;, &#39;kInacccessible&#39;, etc.
        /// </summary>
        /// <value>Specifies the connection state of the Object and are only valid for ESXi hosts (&#39;kHostSystem&#39;) or Virtual Machines (&#39;kVirtualMachine&#39;). These enums are equivalent to the connection states documented in VMware&#39;s reference documentation. Examples of Cohesity connection states include &#39;kConnected&#39;, &#39;kDisconnected&#39;, &#39;kInacccessible&#39;, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectionStateEnum
        {
            
            /// <summary>
            /// Enum KConnected for value: kConnected
            /// </summary>
            [EnumMember(Value = "kConnected")]
            KConnected = 1,
            
            /// <summary>
            /// Enum KDisconnected for value: kDisconnected
            /// </summary>
            [EnumMember(Value = "kDisconnected")]
            KDisconnected = 2,
            
            /// <summary>
            /// Enum KInacccessible for value: kInacccessible
            /// </summary>
            [EnumMember(Value = "kInacccessible")]
            KInacccessible = 3,
            
            /// <summary>
            /// Enum KInvalid for value: kInvalid
            /// </summary>
            [EnumMember(Value = "kInvalid")]
            KInvalid = 4,
            
            /// <summary>
            /// Enum KOrphaned for value: kOrphaned
            /// </summary>
            [EnumMember(Value = "kOrphaned")]
            KOrphaned = 5,
            
            /// <summary>
            /// Enum KNotResponding for value: kNotResponding
            /// </summary>
            [EnumMember(Value = "kNotResponding")]
            KNotResponding = 6
        }

        /// <summary>
        /// Specifies the connection state of the Object and are only valid for ESXi hosts (&#39;kHostSystem&#39;) or Virtual Machines (&#39;kVirtualMachine&#39;). These enums are equivalent to the connection states documented in VMware&#39;s reference documentation. Examples of Cohesity connection states include &#39;kConnected&#39;, &#39;kDisconnected&#39;, &#39;kInacccessible&#39;, etc.
        /// </summary>
        /// <value>Specifies the connection state of the Object and are only valid for ESXi hosts (&#39;kHostSystem&#39;) or Virtual Machines (&#39;kVirtualMachine&#39;). These enums are equivalent to the connection states documented in VMware&#39;s reference documentation. Examples of Cohesity connection states include &#39;kConnected&#39;, &#39;kDisconnected&#39;, &#39;kInacccessible&#39;, etc.</value>
        [DataMember(Name="connectionState", EmitDefaultValue=false)]
        public ConnectionStateEnum? ConnectionState { get; set; }
        /// <summary>
        /// Specifies the folder type for the &#39;kFolder&#39; Object. &#39;kVMFolder&#39; indicates folder can hold VMs or vApps. &#39;kHostFolder&#39; indicates folder can hold hosts and compute resources. &#39;kDatastoreFolder&#39; indicates folder can hold datastores and storage pods. &#39;kNetworkFolder&#39; indicates folder can hold networks and switches. &#39;kRootFolder&#39; indicates folder can hold datacenters.
        /// </summary>
        /// <value>Specifies the folder type for the &#39;kFolder&#39; Object. &#39;kVMFolder&#39; indicates folder can hold VMs or vApps. &#39;kHostFolder&#39; indicates folder can hold hosts and compute resources. &#39;kDatastoreFolder&#39; indicates folder can hold datastores and storage pods. &#39;kNetworkFolder&#39; indicates folder can hold networks and switches. &#39;kRootFolder&#39; indicates folder can hold datacenters.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FolderTypeEnum
        {
            
            /// <summary>
            /// Enum KVMFolder for value: kVMFolder
            /// </summary>
            [EnumMember(Value = "kVMFolder")]
            KVMFolder = 1,
            
            /// <summary>
            /// Enum KHostFolder for value: kHostFolder
            /// </summary>
            [EnumMember(Value = "kHostFolder")]
            KHostFolder = 2,
            
            /// <summary>
            /// Enum KDatastoreFolder for value: kDatastoreFolder
            /// </summary>
            [EnumMember(Value = "kDatastoreFolder")]
            KDatastoreFolder = 3,
            
            /// <summary>
            /// Enum KNetworkFolder for value: kNetworkFolder
            /// </summary>
            [EnumMember(Value = "kNetworkFolder")]
            KNetworkFolder = 4,
            
            /// <summary>
            /// Enum KRootFolder for value: kRootFolder
            /// </summary>
            [EnumMember(Value = "kRootFolder")]
            KRootFolder = 5
        }

        /// <summary>
        /// Specifies the folder type for the &#39;kFolder&#39; Object. &#39;kVMFolder&#39; indicates folder can hold VMs or vApps. &#39;kHostFolder&#39; indicates folder can hold hosts and compute resources. &#39;kDatastoreFolder&#39; indicates folder can hold datastores and storage pods. &#39;kNetworkFolder&#39; indicates folder can hold networks and switches. &#39;kRootFolder&#39; indicates folder can hold datacenters.
        /// </summary>
        /// <value>Specifies the folder type for the &#39;kFolder&#39; Object. &#39;kVMFolder&#39; indicates folder can hold VMs or vApps. &#39;kHostFolder&#39; indicates folder can hold hosts and compute resources. &#39;kDatastoreFolder&#39; indicates folder can hold datastores and storage pods. &#39;kNetworkFolder&#39; indicates folder can hold networks and switches. &#39;kRootFolder&#39; indicates folder can hold datacenters.</value>
        [DataMember(Name="folderType", EmitDefaultValue=false)]
        public FolderTypeEnum? FolderType { get; set; }
        /// <summary>
        /// Specifies the host type for the &#39;kVirtualMachine&#39; Object. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the host type for the &#39;kVirtualMachine&#39; Object. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
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
            KWindows = 2
        }

        /// <summary>
        /// Specifies the host type for the &#39;kVirtualMachine&#39; Object. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the host type for the &#39;kVirtualMachine&#39; Object. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the status of VMware Tools for the guest OS on the VM. This is only valid for the &#39;kVirtualMachine&#39; type. &#39;kGuestToolsRunning&#39; means the VMware tools are running on the guest OS. &#39;kGuestToolsNotRunning&#39; means the VMware tools are not running on the guest OS. &#39;kUnknown&#39; means the state of the VMware tools on the guest OS is not known. &#39;kGuestToolsExecutingScripts&#39; means the guest OS is currently executing scripts using VMware tools.
        /// </summary>
        /// <value>Specifies the status of VMware Tools for the guest OS on the VM. This is only valid for the &#39;kVirtualMachine&#39; type. &#39;kGuestToolsRunning&#39; means the VMware tools are running on the guest OS. &#39;kGuestToolsNotRunning&#39; means the VMware tools are not running on the guest OS. &#39;kUnknown&#39; means the state of the VMware tools on the guest OS is not known. &#39;kGuestToolsExecutingScripts&#39; means the guest OS is currently executing scripts using VMware tools.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ToolsRunningStatusEnum
        {
            
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 1,
            
            /// <summary>
            /// Enum KGuestToolsExecutingScripts for value: kGuestToolsExecutingScripts
            /// </summary>
            [EnumMember(Value = "kGuestToolsExecutingScripts")]
            KGuestToolsExecutingScripts = 2,
            
            /// <summary>
            /// Enum KGuestToolsNotRunning for value: kGuestToolsNotRunning
            /// </summary>
            [EnumMember(Value = "kGuestToolsNotRunning")]
            KGuestToolsNotRunning = 3,
            
            /// <summary>
            /// Enum KGuestToolsRunning for value: kGuestToolsRunning
            /// </summary>
            [EnumMember(Value = "kGuestToolsRunning")]
            KGuestToolsRunning = 4
        }

        /// <summary>
        /// Specifies the status of VMware Tools for the guest OS on the VM. This is only valid for the &#39;kVirtualMachine&#39; type. &#39;kGuestToolsRunning&#39; means the VMware tools are running on the guest OS. &#39;kGuestToolsNotRunning&#39; means the VMware tools are not running on the guest OS. &#39;kUnknown&#39; means the state of the VMware tools on the guest OS is not known. &#39;kGuestToolsExecutingScripts&#39; means the guest OS is currently executing scripts using VMware tools.
        /// </summary>
        /// <value>Specifies the status of VMware Tools for the guest OS on the VM. This is only valid for the &#39;kVirtualMachine&#39; type. &#39;kGuestToolsRunning&#39; means the VMware tools are running on the guest OS. &#39;kGuestToolsNotRunning&#39; means the VMware tools are not running on the guest OS. &#39;kUnknown&#39; means the state of the VMware tools on the guest OS is not known. &#39;kGuestToolsExecutingScripts&#39; means the guest OS is currently executing scripts using VMware tools.</value>
        [DataMember(Name="toolsRunningStatus", EmitDefaultValue=false)]
        public ToolsRunningStatusEnum? ToolsRunningStatus { get; set; }
        /// <summary>
        /// Specifies the type of managed Object in a VMware Protection Source. Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.
        /// </summary>
        /// <value>Specifies the type of managed Object in a VMware Protection Source. Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KVCenter for value: kVCenter
            /// </summary>
            [EnumMember(Value = "kVCenter")]
            KVCenter = 1,
            
            /// <summary>
            /// Enum KFolder for value: kFolder
            /// </summary>
            [EnumMember(Value = "kFolder")]
            KFolder = 2,
            
            /// <summary>
            /// Enum KDatacenter for value: kDatacenter
            /// </summary>
            [EnumMember(Value = "kDatacenter")]
            KDatacenter = 3,
            
            /// <summary>
            /// Enum KComputeResource for value: kComputeResource
            /// </summary>
            [EnumMember(Value = "kComputeResource")]
            KComputeResource = 4,
            
            /// <summary>
            /// Enum KClusterComputeResource for value: kClusterComputeResource
            /// </summary>
            [EnumMember(Value = "kClusterComputeResource")]
            KClusterComputeResource = 5,
            
            /// <summary>
            /// Enum KResourcePool for value: kResourcePool
            /// </summary>
            [EnumMember(Value = "kResourcePool")]
            KResourcePool = 6,
            
            /// <summary>
            /// Enum KDatastore for value: kDatastore
            /// </summary>
            [EnumMember(Value = "kDatastore")]
            KDatastore = 7,
            
            /// <summary>
            /// Enum KHostSystem for value: kHostSystem
            /// </summary>
            [EnumMember(Value = "kHostSystem")]
            KHostSystem = 8,
            
            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 9,
            
            /// <summary>
            /// Enum KVirtualApp for value: kVirtualApp
            /// </summary>
            [EnumMember(Value = "kVirtualApp")]
            KVirtualApp = 10,
            
            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 11,
            
            /// <summary>
            /// Enum KStoragePod for value: kStoragePod
            /// </summary>
            [EnumMember(Value = "kStoragePod")]
            KStoragePod = 12,
            
            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 13,
            
            /// <summary>
            /// Enum KDistributedVirtualPortgroup for value: kDistributedVirtualPortgroup
            /// </summary>
            [EnumMember(Value = "kDistributedVirtualPortgroup")]
            KDistributedVirtualPortgroup = 14,
            
            /// <summary>
            /// Enum KTagCategory for value: kTagCategory
            /// </summary>
            [EnumMember(Value = "kTagCategory")]
            KTagCategory = 15,
            
            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 16
        }

        /// <summary>
        /// Specifies the type of managed Object in a VMware Protection Source. Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.
        /// </summary>
        /// <value>Specifies the type of managed Object in a VMware Protection Source. Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareProtectionSource" /> class.
        /// </summary>
        /// <param name="agentId">Specifies the id of the persistent agent..</param>
        /// <param name="agents">This is set only if the Virtual Machine has persistent agent..</param>
        /// <param name="connectionState">Specifies the connection state of the Object and are only valid for ESXi hosts (&#39;kHostSystem&#39;) or Virtual Machines (&#39;kVirtualMachine&#39;). These enums are equivalent to the connection states documented in VMware&#39;s reference documentation. Examples of Cohesity connection states include &#39;kConnected&#39;, &#39;kDisconnected&#39;, &#39;kInacccessible&#39;, etc..</param>
        /// <param name="datastoreInfo">Specifies additional information of entities of type &#39;kDatastore&#39;..</param>
        /// <param name="folderType">Specifies the folder type for the &#39;kFolder&#39; Object. &#39;kVMFolder&#39; indicates folder can hold VMs or vApps. &#39;kHostFolder&#39; indicates folder can hold hosts and compute resources. &#39;kDatastoreFolder&#39; indicates folder can hold datastores and storage pods. &#39;kNetworkFolder&#39; indicates folder can hold networks and switches. &#39;kRootFolder&#39; indicates folder can hold datacenters..</param>
        /// <param name="hasPersistentAgent">Set to true if a persistent agent is running on the Virtual Machine. This is populated for entities of type &#39;kVirtualMachine&#39;..</param>
        /// <param name="hostType">Specifies the host type for the &#39;kVirtualMachine&#39; Object. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system..</param>
        /// <param name="id">Specifies the UUID of the VMware Protection Source..</param>
        /// <param name="name">Specifies a human readable name of the Protection Source..</param>
        /// <param name="tagAttributes">Specifies the optional list of VM Tag attributes associated with this Object..</param>
        /// <param name="toolsRunningStatus">Specifies the status of VMware Tools for the guest OS on the VM. This is only valid for the &#39;kVirtualMachine&#39; type. &#39;kGuestToolsRunning&#39; means the VMware tools are running on the guest OS. &#39;kGuestToolsNotRunning&#39; means the VMware tools are not running on the guest OS. &#39;kUnknown&#39; means the state of the VMware tools on the guest OS is not known. &#39;kGuestToolsExecutingScripts&#39; means the guest OS is currently executing scripts using VMware tools..</param>
        /// <param name="type">Specifies the type of managed Object in a VMware Protection Source. Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc..</param>
        /// <param name="virtualDisks">This is populated for entities of type &#39;kVirtualMachine&#39;..</param>
        public VMwareProtectionSource(long? agentId = default(long?), List<AgentInformation> agents = default(List<AgentInformation>), ConnectionStateEnum? connectionState = default(ConnectionStateEnum?), DatastoreInfo datastoreInfo = default(DatastoreInfo), FolderTypeEnum? folderType = default(FolderTypeEnum?), bool? hasPersistentAgent = default(bool?), HostTypeEnum? hostType = default(HostTypeEnum?), VMwareObjectId id = default(VMwareObjectId), string name = default(string), List<TagAttribute> tagAttributes = default(List<TagAttribute>), ToolsRunningStatusEnum? toolsRunningStatus = default(ToolsRunningStatusEnum?), TypeEnum? type = default(TypeEnum?), List<VirtualDiskInfo> virtualDisks = default(List<VirtualDiskInfo>))
        {
            this.AgentId = agentId;
            this.Agents = agents;
            this.ConnectionState = connectionState;
            this.DatastoreInfo = datastoreInfo;
            this.FolderType = folderType;
            this.HasPersistentAgent = hasPersistentAgent;
            this.HostType = hostType;
            this.Id = id;
            this.Name = name;
            this.TagAttributes = tagAttributes;
            this.ToolsRunningStatus = toolsRunningStatus;
            this.Type = type;
            this.VirtualDisks = virtualDisks;
        }
        
        /// <summary>
        /// Specifies the id of the persistent agent.
        /// </summary>
        /// <value>Specifies the id of the persistent agent.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// This is set only if the Virtual Machine has persistent agent.
        /// </summary>
        /// <value>This is set only if the Virtual Machine has persistent agent.</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<AgentInformation> Agents { get; set; }


        /// <summary>
        /// Specifies additional information of entities of type &#39;kDatastore&#39;.
        /// </summary>
        /// <value>Specifies additional information of entities of type &#39;kDatastore&#39;.</value>
        [DataMember(Name="datastoreInfo", EmitDefaultValue=false)]
        public DatastoreInfo DatastoreInfo { get; set; }


        /// <summary>
        /// Set to true if a persistent agent is running on the Virtual Machine. This is populated for entities of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>Set to true if a persistent agent is running on the Virtual Machine. This is populated for entities of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="hasPersistentAgent", EmitDefaultValue=false)]
        public bool? HasPersistentAgent { get; set; }


        /// <summary>
        /// Specifies the UUID of the VMware Protection Source.
        /// </summary>
        /// <value>Specifies the UUID of the VMware Protection Source.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public VMwareObjectId Id { get; set; }

        /// <summary>
        /// Specifies a human readable name of the Protection Source.
        /// </summary>
        /// <value>Specifies a human readable name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the optional list of VM Tag attributes associated with this Object.
        /// </summary>
        /// <value>Specifies the optional list of VM Tag attributes associated with this Object.</value>
        [DataMember(Name="tagAttributes", EmitDefaultValue=false)]
        public List<TagAttribute> TagAttributes { get; set; }



        /// <summary>
        /// This is populated for entities of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>This is populated for entities of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="virtualDisks", EmitDefaultValue=false)]
        public List<VirtualDiskInfo> VirtualDisks { get; set; }

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
            return this.Equals(input as VMwareProtectionSource);
        }

        /// <summary>
        /// Returns true if VMwareProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.Agents == input.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(input.Agents)
                ) && 
                (
                    this.ConnectionState == input.ConnectionState ||
                    (this.ConnectionState != null &&
                    this.ConnectionState.Equals(input.ConnectionState))
                ) && 
                (
                    this.DatastoreInfo == input.DatastoreInfo ||
                    (this.DatastoreInfo != null &&
                    this.DatastoreInfo.Equals(input.DatastoreInfo))
                ) && 
                (
                    this.FolderType == input.FolderType ||
                    (this.FolderType != null &&
                    this.FolderType.Equals(input.FolderType))
                ) && 
                (
                    this.HasPersistentAgent == input.HasPersistentAgent ||
                    (this.HasPersistentAgent != null &&
                    this.HasPersistentAgent.Equals(input.HasPersistentAgent))
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
                    this.TagAttributes == input.TagAttributes ||
                    this.TagAttributes != null &&
                    this.TagAttributes.SequenceEqual(input.TagAttributes)
                ) && 
                (
                    this.ToolsRunningStatus == input.ToolsRunningStatus ||
                    (this.ToolsRunningStatus != null &&
                    this.ToolsRunningStatus.Equals(input.ToolsRunningStatus))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VirtualDisks == input.VirtualDisks ||
                    this.VirtualDisks != null &&
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
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.Agents != null)
                    hashCode = hashCode * 59 + this.Agents.GetHashCode();
                if (this.ConnectionState != null)
                    hashCode = hashCode * 59 + this.ConnectionState.GetHashCode();
                if (this.DatastoreInfo != null)
                    hashCode = hashCode * 59 + this.DatastoreInfo.GetHashCode();
                if (this.FolderType != null)
                    hashCode = hashCode * 59 + this.FolderType.GetHashCode();
                if (this.HasPersistentAgent != null)
                    hashCode = hashCode * 59 + this.HasPersistentAgent.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TagAttributes != null)
                    hashCode = hashCode * 59 + this.TagAttributes.GetHashCode();
                if (this.ToolsRunningStatus != null)
                    hashCode = hashCode * 59 + this.ToolsRunningStatus.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VirtualDisks != null)
                    hashCode = hashCode * 59 + this.VirtualDisks.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

