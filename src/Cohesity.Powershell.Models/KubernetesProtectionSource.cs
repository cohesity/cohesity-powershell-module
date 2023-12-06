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
    /// Specifies a Protection Source in Kubernetes environment.
    /// </summary>
    [DataContract]
    public partial class KubernetesProtectionSource :  IEquatable<KubernetesProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the entity in a Kubernetes environment. Determines the K8s distribution.
        /// </summary>
        /// <value>Specifies the type of the entity in a Kubernetes environment. Determines the K8s distribution.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DistributionEnum
        {
            /// <summary>
            /// Enum KMainline for value: kMainline
            /// </summary>
            [EnumMember(Value = "kMainline")]
            KMainline = 1,

            /// <summary>
            /// Enum KOpenshift for value: kOpenshift
            /// </summary>
            [EnumMember(Value = "kOpenshift")]
            KOpenshift = 2,

            /// <summary>
            /// Enum KRancher for value: kRancher
            /// </summary>
            [EnumMember(Value = "kRancher")]
            KRancher = 3,

            /// <summary>
            /// Enum KEKS for value: kEKS
            /// </summary>
            [EnumMember(Value = "kEKS")]
            KEKS = 4,

            /// <summary>
            /// Enum KGKE for value: kGKE
            /// </summary>
            [EnumMember(Value = "kGKE")]
            KGKE = 5,

            /// <summary>
            /// Enum KAKS for value: kAKS
            /// </summary>
            [EnumMember(Value = "kAKS")]
            KAKS = 6,

            /// <summary>
            /// Enum KVMwareTanzu for value: kVMwareTanzu
            /// </summary>
            [EnumMember(Value = "kVMwareTanzu")]
            KVMwareTanzu = 7

        }

        /// <summary>
        /// Specifies the type of the entity in a Kubernetes environment. Determines the K8s distribution.
        /// </summary>
        /// <value>Specifies the type of the entity in a Kubernetes environment. Determines the K8s distribution.</value>
        [DataMember(Name="distribution", EmitDefaultValue=true)]
        public DistributionEnum? Distribution { get; set; }
        /// <summary>
        /// Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KNamespace for value: kNamespace
            /// </summary>
            [EnumMember(Value = "kNamespace")]
            KNamespace = 2,

            /// <summary>
            /// Enum KService for value: kService
            /// </summary>
            [EnumMember(Value = "kService")]
            KService = 3

        }

        /// <summary>
        /// Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.
        /// </summary>
        /// <value>Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesProtectionSource" /> class.
        /// </summary>
        /// <param name="datamoverImageLocation">Specifies the location of Datamover image in private registry..</param>
        /// <param name="datamoverServiceType">Specifies Type of service to be deployed for communication with DataMover pods. Currently, LoadBalancer and NodePort are supported. [default &#x3D; kNodePort]..</param>
        /// <param name="datamoverUpgradability">Specifies if the deployed Datamover image needs to be upgraded for this kubernetes entity.</param>
        /// <param name="defaultVlanParams">defaultVlanParams.</param>
        /// <param name="description">Specifies an optional description of the object..</param>
        /// <param name="distribution">Specifies the type of the entity in a Kubernetes environment. Determines the K8s distribution..</param>
        /// <param name="initContainerImageLocation">Specifies the location of the image for init containers..</param>
        /// <param name="labelAttributes">Specifies the list of label attributes of this source..</param>
        /// <param name="name">Specifies a unique name of the Protection Source..</param>
        /// <param name="serviceAnnotations">Specifies annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer..</param>
        /// <param name="type">Specifies the type of the entity in a Kubernetes environment. Specifies the type of a Kubernetes Protection Source. &#39;kCluster&#39; indicates a Kubernetes Cluster. &#39;kNamespace&#39; indicates a namespace in a Kubernetes Cluster. &#39;kService&#39; indicates a service running on a Kubernetes Cluster..</param>
        /// <param name="uuid">Specifies the UUID of the object..</param>
        /// <param name="veleroAwsPluginImageLocation">Specifies the location of Velero AWS plugin image in private registry..</param>
        /// <param name="veleroImageLocation">Specifies the location of Velero image in private registry..</param>
        /// <param name="veleroOpenshiftPluginImageLocation">Specifies the location of the image for openshift plugin container..</param>
        /// <param name="veleroUpgradability">Specifies if the deployed Velero image needs to be upgraded for this kubernetes entity..</param>
        /// <param name="vlanInfoVec">Specifies VLAN information provided during registration..</param>
        public KubernetesProtectionSource(string datamoverImageLocation = default(string), int? datamoverServiceType = default(int?), int? datamoverUpgradability = default(int?), VlanParameters defaultVlanParams = default(VlanParameters), string description = default(string), DistributionEnum? distribution = default(DistributionEnum?), string initContainerImageLocation = default(string), List<KubernetesLabelAttribute> labelAttributes = default(List<KubernetesLabelAttribute>), string name = default(string), List<VlanInfoServiceAnnotationsEntry> serviceAnnotations = default(List<VlanInfoServiceAnnotationsEntry>), TypeEnum? type = default(TypeEnum?), string uuid = default(string), string veleroAwsPluginImageLocation = default(string), string veleroImageLocation = default(string), string veleroOpenshiftPluginImageLocation = default(string), int? veleroUpgradability = default(int?), List<KubernetesVlanInfo> vlanInfoVec = default(List<KubernetesVlanInfo>))
        {
            this.DatamoverImageLocation = datamoverImageLocation;
            this.DatamoverServiceType = datamoverServiceType;
            this.DatamoverUpgradability = datamoverUpgradability;
            this.Description = description;
            this.Distribution = distribution;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.LabelAttributes = labelAttributes;
            this.Name = name;
            this.ServiceAnnotations = serviceAnnotations;
            this.Type = type;
            this.Uuid = uuid;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.VeleroUpgradability = veleroUpgradability;
            this.VlanInfoVec = vlanInfoVec;
            this.DatamoverImageLocation = datamoverImageLocation;
            this.DatamoverServiceType = datamoverServiceType;
            this.DatamoverUpgradability = datamoverUpgradability;
            this.DefaultVlanParams = defaultVlanParams;
            this.Description = description;
            this.Distribution = distribution;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.LabelAttributes = labelAttributes;
            this.Name = name;
            this.ServiceAnnotations = serviceAnnotations;
            this.Type = type;
            this.Uuid = uuid;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.VeleroUpgradability = veleroUpgradability;
            this.VlanInfoVec = vlanInfoVec;
        }
        
        /// <summary>
        /// Specifies the location of Datamover image in private registry.
        /// </summary>
        /// <value>Specifies the location of Datamover image in private registry.</value>
        [DataMember(Name="datamoverImageLocation", EmitDefaultValue=true)]
        public string DatamoverImageLocation { get; set; }

        /// <summary>
        /// Specifies Type of service to be deployed for communication with DataMover pods. Currently, LoadBalancer and NodePort are supported. [default &#x3D; kNodePort].
        /// </summary>
        /// <value>Specifies Type of service to be deployed for communication with DataMover pods. Currently, LoadBalancer and NodePort are supported. [default &#x3D; kNodePort].</value>
        [DataMember(Name="datamoverServiceType", EmitDefaultValue=true)]
        public int? DatamoverServiceType { get; set; }

        /// <summary>
        /// Specifies if the deployed Datamover image needs to be upgraded for this kubernetes entity
        /// </summary>
        /// <value>Specifies if the deployed Datamover image needs to be upgraded for this kubernetes entity</value>
        [DataMember(Name="datamoverUpgradability", EmitDefaultValue=true)]
        public int? DatamoverUpgradability { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVlanParams
        /// </summary>
        [DataMember(Name="defaultVlanParams", EmitDefaultValue=false)]
        public VlanParameters DefaultVlanParams { get; set; }

        /// <summary>
        /// Specifies an optional description of the object.
        /// </summary>
        /// <value>Specifies an optional description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the location of the image for init containers.
        /// </summary>
        /// <value>Specifies the location of the image for init containers.</value>
        [DataMember(Name="initContainerImageLocation", EmitDefaultValue=true)]
        public string InitContainerImageLocation { get; set; }

        /// <summary>
        /// Specifies the list of label attributes of this source.
        /// </summary>
        /// <value>Specifies the list of label attributes of this source.</value>
        [DataMember(Name="labelAttributes", EmitDefaultValue=true)]
        public List<KubernetesLabelAttribute> LabelAttributes { get; set; }

        /// <summary>
        /// Specifies a unique name of the Protection Source.
        /// </summary>
        /// <value>Specifies a unique name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer.
        /// </summary>
        /// <value>Specifies annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer.</value>
        [DataMember(Name="serviceAnnotations", EmitDefaultValue=true)]
        public List<VlanInfoServiceAnnotationsEntry> ServiceAnnotations { get; set; }

        /// <summary>
        /// Specifies the UUID of the object.
        /// </summary>
        /// <value>Specifies the UUID of the object.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies the location of Velero AWS plugin image in private registry.
        /// </summary>
        /// <value>Specifies the location of Velero AWS plugin image in private registry.</value>
        [DataMember(Name="veleroAwsPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroAwsPluginImageLocation { get; set; }

        /// <summary>
        /// Specifies the location of Velero image in private registry.
        /// </summary>
        /// <value>Specifies the location of Velero image in private registry.</value>
        [DataMember(Name="veleroImageLocation", EmitDefaultValue=true)]
        public string VeleroImageLocation { get; set; }

        /// <summary>
        /// Specifies the location of the image for openshift plugin container.
        /// </summary>
        /// <value>Specifies the location of the image for openshift plugin container.</value>
        [DataMember(Name="veleroOpenshiftPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroOpenshiftPluginImageLocation { get; set; }

        /// <summary>
        /// Specifies if the deployed Velero image needs to be upgraded for this kubernetes entity.
        /// </summary>
        /// <value>Specifies if the deployed Velero image needs to be upgraded for this kubernetes entity.</value>
        [DataMember(Name="veleroUpgradability", EmitDefaultValue=true)]
        public int? VeleroUpgradability { get; set; }

        /// <summary>
        /// Specifies VLAN information provided during registration.
        /// </summary>
        /// <value>Specifies VLAN information provided during registration.</value>
        [DataMember(Name="vlanInfoVec", EmitDefaultValue=true)]
        public List<KubernetesVlanInfo> VlanInfoVec { get; set; }

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
            return this.Equals(input as KubernetesProtectionSource);
        }

        /// <summary>
        /// Returns true if KubernetesProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatamoverImageLocation == input.DatamoverImageLocation ||
                    (this.DatamoverImageLocation != null &&
                    this.DatamoverImageLocation.Equals(input.DatamoverImageLocation))
                ) && 
                (
                    this.DatamoverServiceType == input.DatamoverServiceType ||
                    (this.DatamoverServiceType != null &&
                    this.DatamoverServiceType.Equals(input.DatamoverServiceType))
                ) && 
                (
                    this.DatamoverUpgradability == input.DatamoverUpgradability ||
                    (this.DatamoverUpgradability != null &&
                    this.DatamoverUpgradability.Equals(input.DatamoverUpgradability))
                ) && 
                (
                    this.DefaultVlanParams == input.DefaultVlanParams ||
                    (this.DefaultVlanParams != null &&
                    this.DefaultVlanParams.Equals(input.DefaultVlanParams))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Distribution == input.Distribution ||
                    this.Distribution.Equals(input.Distribution)
                ) && 
                (
                    this.InitContainerImageLocation == input.InitContainerImageLocation ||
                    (this.InitContainerImageLocation != null &&
                    this.InitContainerImageLocation.Equals(input.InitContainerImageLocation))
                ) && 
                (
                    this.LabelAttributes == input.LabelAttributes ||
                    this.LabelAttributes != null &&
                    input.LabelAttributes != null &&
                    this.LabelAttributes.SequenceEqual(input.LabelAttributes)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ServiceAnnotations == input.ServiceAnnotations ||
                    this.ServiceAnnotations != null &&
                    input.ServiceAnnotations != null &&
                    this.ServiceAnnotations.SequenceEqual(input.ServiceAnnotations)
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
                    this.VeleroAwsPluginImageLocation == input.VeleroAwsPluginImageLocation ||
                    (this.VeleroAwsPluginImageLocation != null &&
                    this.VeleroAwsPluginImageLocation.Equals(input.VeleroAwsPluginImageLocation))
                ) && 
                (
                    this.VeleroImageLocation == input.VeleroImageLocation ||
                    (this.VeleroImageLocation != null &&
                    this.VeleroImageLocation.Equals(input.VeleroImageLocation))
                ) && 
                (
                    this.VeleroOpenshiftPluginImageLocation == input.VeleroOpenshiftPluginImageLocation ||
                    (this.VeleroOpenshiftPluginImageLocation != null &&
                    this.VeleroOpenshiftPluginImageLocation.Equals(input.VeleroOpenshiftPluginImageLocation))
                ) && 
                (
                    this.VeleroUpgradability == input.VeleroUpgradability ||
                    (this.VeleroUpgradability != null &&
                    this.VeleroUpgradability.Equals(input.VeleroUpgradability))
                ) && 
                (
                    this.VlanInfoVec == input.VlanInfoVec ||
                    this.VlanInfoVec != null &&
                    input.VlanInfoVec != null &&
                    this.VlanInfoVec.SequenceEqual(input.VlanInfoVec)
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
                if (this.DatamoverImageLocation != null)
                    hashCode = hashCode * 59 + this.DatamoverImageLocation.GetHashCode();
                if (this.DatamoverServiceType != null)
                    hashCode = hashCode * 59 + this.DatamoverServiceType.GetHashCode();
                if (this.DatamoverUpgradability != null)
                    hashCode = hashCode * 59 + this.DatamoverUpgradability.GetHashCode();
                if (this.DefaultVlanParams != null)
                    hashCode = hashCode * 59 + this.DefaultVlanParams.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Distribution.GetHashCode();
                if (this.InitContainerImageLocation != null)
                    hashCode = hashCode * 59 + this.InitContainerImageLocation.GetHashCode();
                if (this.LabelAttributes != null)
                    hashCode = hashCode * 59 + this.LabelAttributes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ServiceAnnotations != null)
                    hashCode = hashCode * 59 + this.ServiceAnnotations.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VeleroAwsPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroAwsPluginImageLocation.GetHashCode();
                if (this.VeleroImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroImageLocation.GetHashCode();
                if (this.VeleroOpenshiftPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroOpenshiftPluginImageLocation.GetHashCode();
                if (this.VeleroUpgradability != null)
                    hashCode = hashCode * 59 + this.VeleroUpgradability.GetHashCode();
                if (this.VlanInfoVec != null)
                    hashCode = hashCode * 59 + this.VlanInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

