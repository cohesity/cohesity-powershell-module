// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a Protection Source in Acropolis environment.
    /// </summary>
    [DataContract]
    public partial class AcropolisProtectionSource :  IEquatable<AcropolisProtectionSource>
    {
        /// <summary>
        /// Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object.
        /// </summary>
        /// <value>Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object.</value>
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
        /// Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object.
        /// </summary>
        /// <value>Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcropolisProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterUuid">Specifies the UUID of the Acropolis cluster instance to which this entity belongs to..</param>
        /// <param name="description">Specifies a description about the Protection Source..</param>
        /// <param name="mountPath">Specifies whether the the VM is an agent VM. This is applicable to acropolis entity of type kVirtualMachine..</param>
        /// <param name="name">Specifies the name of the Acropolis Object..</param>
        /// <param name="type">Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object..</param>
        /// <param name="uuid">Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment..</param>
        public AcropolisProtectionSource(string clusterUuid = default(string), string description = default(string), bool? mountPath = default(bool?), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.ClusterUuid = clusterUuid;
            this.Description = description;
            this.MountPath = mountPath;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the UUID of the Acropolis cluster instance to which this entity belongs to.
        /// </summary>
        /// <value>Specifies the UUID of the Acropolis cluster instance to which this entity belongs to.</value>
        [DataMember(Name="clusterUuid", EmitDefaultValue=false)]
        public string ClusterUuid { get; set; }

        /// <summary>
        /// Specifies a description about the Protection Source.
        /// </summary>
        /// <value>Specifies a description about the Protection Source.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether the the VM is an agent VM. This is applicable to acropolis entity of type kVirtualMachine.
        /// </summary>
        /// <value>Specifies whether the the VM is an agent VM. This is applicable to acropolis entity of type kVirtualMachine.</value>
        [DataMember(Name="mountPath", EmitDefaultValue=false)]
        public bool? MountPath { get; set; }

        /// <summary>
        /// Specifies the name of the Acropolis Object.
        /// </summary>
        /// <value>Specifies the name of the Acropolis Object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment.
        /// </summary>
        /// <value>Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment.</value>
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
                if (this.ClusterUuid != null)
                    hashCode = hashCode * 59 + this.ClusterUuid.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MountPath != null)
                    hashCode = hashCode * 59 + this.MountPath.GetHashCode();
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

