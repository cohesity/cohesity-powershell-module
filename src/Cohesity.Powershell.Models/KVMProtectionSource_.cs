// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about a KVM Protection Source when the environment is set to &#39;kKVM&#39;.
    /// </summary>
    [DataContract]
    public partial class KVMProtectionSource_ :  IEquatable<KVMProtectionSource_>
    {
        /// <summary>
        /// Specifies the type of KVM Protection Source entities such as &#39;kDatacenter&#39;, &#39;kCluster&#39;, &#39;kVirtualMachine&#39;, etc. Specifies the type of an KVM source entity. &#39;kOVirtManager&#39; indicates the root entity registerd with Cohesity cluster. &#39;kStandaloneHost&#39; indicates a host registered with Cohesity cluster. &#39;kDatacenter&#39; indicates a KVM datacenter managed by the OVirt manager. &#39;kCluster&#39; indicates a KVM cluster managed by the OVirt manager. &#39;kHost&#39; indicates a host within the KVM environment. &#39;kVirtualMachine&#39; indicates a virtual machine in the KVM enironment. &#39;kNetwork&#39; represents a network used by the virtual machine entity. &#39;kStorageDomain&#39; represents a storage domain in the KVM environment.
        /// </summary>
        /// <value>Specifies the type of KVM Protection Source entities such as &#39;kDatacenter&#39;, &#39;kCluster&#39;, &#39;kVirtualMachine&#39;, etc. Specifies the type of an KVM source entity. &#39;kOVirtManager&#39; indicates the root entity registerd with Cohesity cluster. &#39;kStandaloneHost&#39; indicates a host registered with Cohesity cluster. &#39;kDatacenter&#39; indicates a KVM datacenter managed by the OVirt manager. &#39;kCluster&#39; indicates a KVM cluster managed by the OVirt manager. &#39;kHost&#39; indicates a host within the KVM environment. &#39;kVirtualMachine&#39; indicates a virtual machine in the KVM enironment. &#39;kNetwork&#39; represents a network used by the virtual machine entity. &#39;kStorageDomain&#39; represents a storage domain in the KVM environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KOVirtManager for value: kOVirtManager
            /// </summary>
            [EnumMember(Value = "kOVirtManager")]
            KOVirtManager = 1,
            
            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 2,
            
            /// <summary>
            /// Enum KDatacenter for value: kDatacenter
            /// </summary>
            [EnumMember(Value = "kDatacenter")]
            KDatacenter = 3,
            
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
            /// Enum KStorageDomain for value: kStorageDomain
            /// </summary>
            [EnumMember(Value = "kStorageDomain")]
            KStorageDomain = 8,

            /// <summary>
            /// Enum KVNicProfile for value: kVNicProfile
            /// </summary>
            [EnumMember(Value = "kVNicProfile")]
            KVNicProfile = 9
        }

        /// <summary>
        /// Specifies the type of KVM Protection Source entities such as &#39;kDatacenter&#39;, &#39;kCluster&#39;, &#39;kVirtualMachine&#39;, etc. Specifies the type of an KVM source entity. &#39;kOVirtManager&#39; indicates the root entity registerd with Cohesity cluster. &#39;kStandaloneHost&#39; indicates a host registered with Cohesity cluster. &#39;kDatacenter&#39; indicates a KVM datacenter managed by the OVirt manager. &#39;kCluster&#39; indicates a KVM cluster managed by the OVirt manager. &#39;kHost&#39; indicates a host within the KVM environment. &#39;kVirtualMachine&#39; indicates a virtual machine in the KVM enironment. &#39;kNetwork&#39; represents a network used by the virtual machine entity. &#39;kStorageDomain&#39; represents a storage domain in the KVM environment.
        /// </summary>
        /// <value>Specifies the type of KVM Protection Source entities such as &#39;kDatacenter&#39;, &#39;kCluster&#39;, &#39;kVirtualMachine&#39;, etc. Specifies the type of an KVM source entity. &#39;kOVirtManager&#39; indicates the root entity registerd with Cohesity cluster. &#39;kStandaloneHost&#39; indicates a host registered with Cohesity cluster. &#39;kDatacenter&#39; indicates a KVM datacenter managed by the OVirt manager. &#39;kCluster&#39; indicates a KVM cluster managed by the OVirt manager. &#39;kHost&#39; indicates a host within the KVM environment. &#39;kVirtualMachine&#39; indicates a virtual machine in the KVM enironment. &#39;kNetwork&#39; represents a network used by the virtual machine entity. &#39;kStorageDomain&#39; represents a storage domain in the KVM environment.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KVMProtectionSource_" /> class.
        /// </summary>
        /// <param name="agentError">Specifies a message when the agent cannot be reached..</param>
        /// <param name="agentId">Specifies the ID of the Agent with which this KVM entity is associated when the entity represents a Delegate host or KVM host..</param>
        /// <param name="clusterId">Specifies the cluster ID for &#39;kCluster&#39; objects..</param>
        /// <param name="datacenterId">Specifies the ID of the &#39;kDatacenter&#39; objects..</param>
        /// <param name="description">Specifies a description about the Protection Source..</param>
        /// <param name="name">Specifies the name of the KVM entity..</param>
        /// <param name="type">Specifies the type of KVM Protection Source entities such as &#39;kDatacenter&#39;, &#39;kCluster&#39;, &#39;kVirtualMachine&#39;, etc. Specifies the type of an KVM source entity. &#39;kOVirtManager&#39; indicates the root entity registerd with Cohesity cluster. &#39;kStandaloneHost&#39; indicates a host registered with Cohesity cluster. &#39;kDatacenter&#39; indicates a KVM datacenter managed by the OVirt manager. &#39;kCluster&#39; indicates a KVM cluster managed by the OVirt manager. &#39;kHost&#39; indicates a host within the KVM environment. &#39;kVirtualMachine&#39; indicates a virtual machine in the KVM enironment. &#39;kNetwork&#39; represents a network used by the virtual machine entity. &#39;kStorageDomain&#39; represents a storage domain in the KVM environment..</param>
        /// <param name="uuid">Specifies the UUID of the Object. This is unique within the KVM environment..</param>
        public KVMProtectionSource_(string agentError = default(string), long? agentId = default(long?), string clusterId = default(string), string datacenterId = default(string), string description = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.AgentError = agentError;
            this.AgentId = agentId;
            this.ClusterId = clusterId;
            this.DatacenterId = datacenterId;
            this.Description = description;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies a message when the agent cannot be reached.
        /// </summary>
        /// <value>Specifies a message when the agent cannot be reached.</value>
        [DataMember(Name="agentError", EmitDefaultValue=false)]
        public string AgentError { get; set; }

        /// <summary>
        /// Specifies the ID of the Agent with which this KVM entity is associated when the entity represents a Delegate host or KVM host.
        /// </summary>
        /// <value>Specifies the ID of the Agent with which this KVM entity is associated when the entity represents a Delegate host or KVM host.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// Specifies the cluster ID for &#39;kCluster&#39; objects.
        /// </summary>
        /// <value>Specifies the cluster ID for &#39;kCluster&#39; objects.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies the ID of the &#39;kDatacenter&#39; objects.
        /// </summary>
        /// <value>Specifies the ID of the &#39;kDatacenter&#39; objects.</value>
        [DataMember(Name="datacenterId", EmitDefaultValue=false)]
        public string DatacenterId { get; set; }

        /// <summary>
        /// Specifies a description about the Protection Source.
        /// </summary>
        /// <value>Specifies a description about the Protection Source.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the name of the KVM entity.
        /// </summary>
        /// <value>Specifies the name of the KVM entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the UUID of the Object. This is unique within the KVM environment.
        /// </summary>
        /// <value>Specifies the UUID of the Object. This is unique within the KVM environment.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

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
            return this.Equals(input as KVMProtectionSource_);
        }

        /// <summary>
        /// Returns true if KVMProtectionSource_ instances are equal
        /// </summary>
        /// <param name="input">Instance of KVMProtectionSource_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KVMProtectionSource_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentError == input.AgentError ||
                    (this.AgentError != null &&
                    this.AgentError.Equals(input.AgentError))
                ) && 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.DatacenterId == input.DatacenterId ||
                    (this.DatacenterId != null &&
                    this.DatacenterId.Equals(input.DatacenterId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.AgentError != null)
                    hashCode = hashCode * 59 + this.AgentError.GetHashCode();
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.DatacenterId != null)
                    hashCode = hashCode * 59 + this.DatacenterId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

