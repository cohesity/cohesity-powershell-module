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
    /// Specifies the parameters required to register Application Servers running in a Protection Source.
    /// </summary>
    [DataContract]
    public partial class KubernetesParams :  IEquatable<KubernetesParams>
    {
        /// <summary>
        /// Specifies the distribution if the environment is kKubernetes. overrideDescription: true kIKS, kROKS
        /// </summary>
        /// <value>Specifies the distribution if the environment is kKubernetes. overrideDescription: true kIKS, kROKS</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KubernetesDistributionEnum
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
        /// Specifies the distribution if the environment is kKubernetes. overrideDescription: true kIKS, kROKS
        /// </summary>
        /// <value>Specifies the distribution if the environment is kKubernetes. overrideDescription: true kIKS, kROKS</value>
        [DataMember(Name="kubernetesDistribution", EmitDefaultValue=true)]
        public KubernetesDistributionEnum? KubernetesDistribution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesParams" /> class.
        /// </summary>
        /// <param name="cohesityDataprotectPluginImageLocation">Specifies the location of custom Cohesity DataProtect plugin image in private registry..</param>
        /// <param name="datamoverImageLocation">Specifies the location of Datamover image in private registry..</param>
        /// <param name="datamoverServiceType">Specifies Type of service to be deployed for communication with DataMover pods. Currently, LoadBalancer and NodePort are supported. [default &#x3D; kNodePort]..</param>
        /// <param name="defaultVlanParams">defaultVlanParams.</param>
        /// <param name="initContainerImageLocation">Specifies the location of the image for init containers..</param>
        /// <param name="kubernetesDistribution">Specifies the distribution if the environment is kKubernetes. overrideDescription: true kIKS, kROKS.</param>
        /// <param name="priorityClassName">Specifies the pritority class name during registration..</param>
        /// <param name="resourceAnnotationList">Specifies resource Annotations information provided during registration..</param>
        /// <param name="resourceLabelList">Specifies resource labels information provided during registration..</param>
        /// <param name="sanField">Specifies the SAN field for agent certificate.</param>
        /// <param name="serviceAnnotations">Specifies annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer..</param>
        /// <param name="veleroAwsPluginImageLocation">Specifies the location of Velero AWS plugin image in private registry..</param>
        /// <param name="veleroImageLocation">Specifies the location of Velero image in private registry..</param>
        /// <param name="veleroKubevirtPluginImageLocation">Specifies the location of Velero Kubevirt plugin image in private registry..</param>
        /// <param name="veleroOpenshiftPluginImageLocation">Specifies the location of the image for openshift plugin container..</param>
        /// <param name="vlanInfoVec">Specifies VLAN information provided during registration..</param>
        public KubernetesParams(string cohesityDataprotectPluginImageLocation = default(string), string datamoverImageLocation = default(string), int? datamoverServiceType = default(int?), VlanParameters defaultVlanParams = default(VlanParameters), string initContainerImageLocation = default(string), KubernetesDistributionEnum? kubernetesDistribution = default(KubernetesDistributionEnum?), string priorityClassName = default(string), List<K8sLabel> resourceAnnotationList = default(List<K8sLabel>), List<K8sLabel> resourceLabelList = default(List<K8sLabel>), List<string> sanField = default(List<string>), List<VlanInfoServiceAnnotationsEntry> serviceAnnotations = default(List<VlanInfoServiceAnnotationsEntry>), string veleroAwsPluginImageLocation = default(string), string veleroImageLocation = default(string), string veleroKubevirtPluginImageLocation = default(string), string veleroOpenshiftPluginImageLocation = default(string), List<KubernetesVlanInfo> vlanInfoVec = default(List<KubernetesVlanInfo>))
        {
            this.CohesityDataprotectPluginImageLocation = cohesityDataprotectPluginImageLocation;
            this.DatamoverImageLocation = datamoverImageLocation;
            this.DatamoverServiceType = datamoverServiceType;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.KubernetesDistribution = kubernetesDistribution;
            this.PriorityClassName = priorityClassName;
            this.ResourceAnnotationList = resourceAnnotationList;
            this.ResourceLabelList = resourceLabelList;
            this.SanField = sanField;
            this.ServiceAnnotations = serviceAnnotations;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroKubevirtPluginImageLocation = veleroKubevirtPluginImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.VlanInfoVec = vlanInfoVec;
            this.CohesityDataprotectPluginImageLocation = cohesityDataprotectPluginImageLocation;
            this.DatamoverImageLocation = datamoverImageLocation;
            this.DatamoverServiceType = datamoverServiceType;
            this.DefaultVlanParams = defaultVlanParams;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.KubernetesDistribution = kubernetesDistribution;
            this.PriorityClassName = priorityClassName;
            this.ResourceAnnotationList = resourceAnnotationList;
            this.ResourceLabelList = resourceLabelList;
            this.SanField = sanField;
            this.ServiceAnnotations = serviceAnnotations;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroKubevirtPluginImageLocation = veleroKubevirtPluginImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.VlanInfoVec = vlanInfoVec;
        }
        
        /// <summary>
        /// Specifies the location of custom Cohesity DataProtect plugin image in private registry.
        /// </summary>
        /// <value>Specifies the location of custom Cohesity DataProtect plugin image in private registry.</value>
        [DataMember(Name="cohesityDataprotectPluginImageLocation", EmitDefaultValue=true)]
        public string CohesityDataprotectPluginImageLocation { get; set; }

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
        /// Gets or Sets DefaultVlanParams
        /// </summary>
        [DataMember(Name="defaultVlanParams", EmitDefaultValue=false)]
        public VlanParameters DefaultVlanParams { get; set; }

        /// <summary>
        /// Specifies the location of the image for init containers.
        /// </summary>
        /// <value>Specifies the location of the image for init containers.</value>
        [DataMember(Name="initContainerImageLocation", EmitDefaultValue=true)]
        public string InitContainerImageLocation { get; set; }

        /// <summary>
        /// Specifies the pritority class name during registration.
        /// </summary>
        /// <value>Specifies the pritority class name during registration.</value>
        [DataMember(Name="priorityClassName", EmitDefaultValue=true)]
        public string PriorityClassName { get; set; }

        /// <summary>
        /// Specifies resource Annotations information provided during registration.
        /// </summary>
        /// <value>Specifies resource Annotations information provided during registration.</value>
        [DataMember(Name="resourceAnnotationList", EmitDefaultValue=true)]
        public List<K8sLabel> ResourceAnnotationList { get; set; }

        /// <summary>
        /// Specifies resource labels information provided during registration.
        /// </summary>
        /// <value>Specifies resource labels information provided during registration.</value>
        [DataMember(Name="resourceLabelList", EmitDefaultValue=true)]
        public List<K8sLabel> ResourceLabelList { get; set; }

        /// <summary>
        /// Specifies the SAN field for agent certificate
        /// </summary>
        /// <value>Specifies the SAN field for agent certificate</value>
        [DataMember(Name="sanField", EmitDefaultValue=true)]
        public List<string> SanField { get; set; }

        /// <summary>
        /// Specifies annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer.
        /// </summary>
        /// <value>Specifies annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer.</value>
        [DataMember(Name="serviceAnnotations", EmitDefaultValue=true)]
        public List<VlanInfoServiceAnnotationsEntry> ServiceAnnotations { get; set; }

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
        /// Specifies the location of Velero Kubevirt plugin image in private registry.
        /// </summary>
        /// <value>Specifies the location of Velero Kubevirt plugin image in private registry.</value>
        [DataMember(Name="veleroKubevirtPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroKubevirtPluginImageLocation { get; set; }

        /// <summary>
        /// Specifies the location of the image for openshift plugin container.
        /// </summary>
        /// <value>Specifies the location of the image for openshift plugin container.</value>
        [DataMember(Name="veleroOpenshiftPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroOpenshiftPluginImageLocation { get; set; }

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
            return this.Equals(input as KubernetesParams);
        }

        /// <summary>
        /// Returns true if KubernetesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CohesityDataprotectPluginImageLocation == input.CohesityDataprotectPluginImageLocation ||
                    (this.CohesityDataprotectPluginImageLocation != null &&
                    this.CohesityDataprotectPluginImageLocation.Equals(input.CohesityDataprotectPluginImageLocation))
                ) && 
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
                    this.DefaultVlanParams == input.DefaultVlanParams ||
                    (this.DefaultVlanParams != null &&
                    this.DefaultVlanParams.Equals(input.DefaultVlanParams))
                ) && 
                (
                    this.InitContainerImageLocation == input.InitContainerImageLocation ||
                    (this.InitContainerImageLocation != null &&
                    this.InitContainerImageLocation.Equals(input.InitContainerImageLocation))
                ) && 
                (
                    this.KubernetesDistribution == input.KubernetesDistribution ||
                    this.KubernetesDistribution.Equals(input.KubernetesDistribution)
                ) && 
                (
                    this.PriorityClassName == input.PriorityClassName ||
                    (this.PriorityClassName != null &&
                    this.PriorityClassName.Equals(input.PriorityClassName))
                ) && 
                (
                    this.ResourceAnnotationList == input.ResourceAnnotationList ||
                    this.ResourceAnnotationList != null &&
                    input.ResourceAnnotationList != null &&
                    this.ResourceAnnotationList.SequenceEqual(input.ResourceAnnotationList)
                ) && 
                (
                    this.ResourceLabelList == input.ResourceLabelList ||
                    this.ResourceLabelList != null &&
                    input.ResourceLabelList != null &&
                    this.ResourceLabelList.SequenceEqual(input.ResourceLabelList)
                ) && 
                (
                    this.SanField == input.SanField ||
                    this.SanField != null &&
                    input.SanField != null &&
                    this.SanField.SequenceEqual(input.SanField)
                ) && 
                (
                    this.ServiceAnnotations == input.ServiceAnnotations ||
                    this.ServiceAnnotations != null &&
                    input.ServiceAnnotations != null &&
                    this.ServiceAnnotations.SequenceEqual(input.ServiceAnnotations)
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
                    this.VeleroKubevirtPluginImageLocation == input.VeleroKubevirtPluginImageLocation ||
                    (this.VeleroKubevirtPluginImageLocation != null &&
                    this.VeleroKubevirtPluginImageLocation.Equals(input.VeleroKubevirtPluginImageLocation))
                ) && 
                (
                    this.VeleroOpenshiftPluginImageLocation == input.VeleroOpenshiftPluginImageLocation ||
                    (this.VeleroOpenshiftPluginImageLocation != null &&
                    this.VeleroOpenshiftPluginImageLocation.Equals(input.VeleroOpenshiftPluginImageLocation))
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
                if (this.CohesityDataprotectPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.CohesityDataprotectPluginImageLocation.GetHashCode();
                if (this.DatamoverImageLocation != null)
                    hashCode = hashCode * 59 + this.DatamoverImageLocation.GetHashCode();
                if (this.DatamoverServiceType != null)
                    hashCode = hashCode * 59 + this.DatamoverServiceType.GetHashCode();
                if (this.DefaultVlanParams != null)
                    hashCode = hashCode * 59 + this.DefaultVlanParams.GetHashCode();
                if (this.InitContainerImageLocation != null)
                    hashCode = hashCode * 59 + this.InitContainerImageLocation.GetHashCode();
                hashCode = hashCode * 59 + this.KubernetesDistribution.GetHashCode();
                if (this.PriorityClassName != null)
                    hashCode = hashCode * 59 + this.PriorityClassName.GetHashCode();
                if (this.ResourceAnnotationList != null)
                    hashCode = hashCode * 59 + this.ResourceAnnotationList.GetHashCode();
                if (this.ResourceLabelList != null)
                    hashCode = hashCode * 59 + this.ResourceLabelList.GetHashCode();
                if (this.SanField != null)
                    hashCode = hashCode * 59 + this.SanField.GetHashCode();
                if (this.ServiceAnnotations != null)
                    hashCode = hashCode * 59 + this.ServiceAnnotations.GetHashCode();
                if (this.VeleroAwsPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroAwsPluginImageLocation.GetHashCode();
                if (this.VeleroImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroImageLocation.GetHashCode();
                if (this.VeleroKubevirtPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroKubevirtPluginImageLocation.GetHashCode();
                if (this.VeleroOpenshiftPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroOpenshiftPluginImageLocation.GetHashCode();
                if (this.VlanInfoVec != null)
                    hashCode = hashCode * 59 + this.VlanInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

