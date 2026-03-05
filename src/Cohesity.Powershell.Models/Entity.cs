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
    /// Message encapsulating a Kubernetes entity
    /// </summary>
    [DataContract]
    public partial class Entity :  IEquatable<Entity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="cohesityResourceAnnotations">List of annotations to apply to resources created/deployed by cohesity at the source..</param>
        /// <param name="cohesityResourceLabels">List of labels to apply to resources created/deployed by cohesity at the source..</param>
        /// <param name="cohesityVeleroPluginImageLocation">Location of Cohesity Velero plugin image on a private registry..</param>
        /// <param name="datamoverAgentVersion">Software version of the agent running in the DataMover pod..</param>
        /// <param name="datamoverImageLocation">Location of the datamover image specified by the user..</param>
        /// <param name="datamoverServiceType">Type of service to be deployed for communication with DataMover pods. Currently, LoadBalancer and NodePort are supported..</param>
        /// <param name="datamoverUpgradability">Indicates if deployed datamover needs to be upgraded for this kubernetes entity..</param>
        /// <param name="defaultVlanParams">defaultVlanParams.</param>
        /// <param name="description">This is a general description that could be set for some entities..</param>
        /// <param name="distribution">K8s distribution. This will only be applicable to kCluster entities..</param>
        /// <param name="frontEndSizeInfo">frontEndSizeInfo.</param>
        /// <param name="hosts">List of hosts to be populated as SAN fields in the agent certificate..</param>
        /// <param name="initContainerImageLocation">Location of the init container image specified by the user..</param>
        /// <param name="ipMode">ipMode.</param>
        /// <param name="isAwsPluginInstalled">Denotes if item actions of aws plugin are present on the deployed velero server..</param>
        /// <param name="isCohesityPluginInstalled">Denotes if item actions of cohesity plugin are present on the deployed velero server..</param>
        /// <param name="isKubevirtEnabled">Boolean to denote if kubevirt is enabled on cluster. Only to be set if kubevirt api group is present in GetApiResourcesOp. This field is only set for root proto..</param>
        /// <param name="isKubevirtPluginInstalled">Denotes if item actions of kubevirt plugin are present on the deployed velero server..</param>
        /// <param name="isManagedCluster">Set if this Entity is a managed cluster and hence not a top level entity. If the Kubernetes cluster is discovered as part of a cloud source it is not a top level entity..</param>
        /// <param name="isOadpInstalled">Flag to indicate where Redhat OADP operator is installed.</param>
        /// <param name="isOpenshiftPluginInstalled">Denotes if item actions of openshift plugin are present on the deployed velero server..</param>
        /// <param name="labelAttributesVec">Label attributes vector contains info about the label nodes corresponding to the current entity&#39;s labels. TODO(jhwang): Make it applicable to non-kNamespace type entities also..</param>
        /// <param name="labelVec">List of labels associated with this entity in the form \&quot;key:value\&quot;. Currently, only populated for PVCs to be used for label based include/exclude filters..</param>
        /// <param name="name">A human readable name for the object..</param>
        /// <param name="_namespace">Namespace of object, if applicable. For a PV, this field stores the namespace of the PVC which is bound to the PV..</param>
        /// <param name="priorityClassName">Pods deployed by cohesity at the K8s source directly (temp pods for example) or through workloads (deployments, daemonsets, jobs, replicaset etc) shall have priorityClassName in its spec set to specified value below..</param>
        /// <param name="pvcName">Name of the PVC which is bound to the PV. Applicable only to &#39;kPersistentVolume&#39; type entity..</param>
        /// <param name="refreshError">Refresh error encountered for managed clusters..</param>
        /// <param name="serviceAnnotations">Contains generic annotations to be put on services..</param>
        /// <param name="servicesToConnectorIdsMap">A mapping from datamover services to corresponding unique connector_params IDs. This will be generated during registration and updated during refresh. Applicable only for &#39;kCluster&#39; type entities..</param>
        /// <param name="sourceId">Identifier to be used while deploying resources on the kubernetes cluster. This will be set to a randomly generated guid for DMaaS clusters and Cohesity cluster id for on prem clusters..</param>
        /// <param name="storageClassVec">This is populated for the root entity only (type kCluster)..</param>
        /// <param name="tolerationsVec">Custom tolerations for Datamover pods..</param>
        /// <param name="type">The type of entity this proto refers to..</param>
        /// <param name="uuid">The UUID of the object..</param>
        /// <param name="veleroAwsPluginImageLocation">Location of the Velero AWS plugin image specified by the user..</param>
        /// <param name="veleroBslChecksumAlgoAvailable">Whether checksumAlgorithm field is supported in the velero BSL config..</param>
        /// <param name="veleroImageLocation">Location of the Velero image specified by the user..</param>
        /// <param name="veleroKubevirtPluginImageLocation">Location of Velero Kubevirt plugin image on a private registry..</param>
        /// <param name="veleroOpenshiftPluginImageLocation">Location of the Velero Openshift plugin image specified by the user..</param>
        /// <param name="veleroUpgradability">Indicates if deployed Velero image needs to be upgraded for this kubernetes entity..</param>
        /// <param name="veleroVersion">Velero version deployed..</param>
        /// <param name="version">Kubernetes cluster version..</param>
        /// <param name="vlanInfoVec">VLAN information provided during registration..</param>
        public Entity(Dictionary<string, string> cohesityResourceAnnotations = default(Dictionary<string, string>), Dictionary<string, string> cohesityResourceLabels = default(Dictionary<string, string>), string cohesityVeleroPluginImageLocation = default(string), string datamoverAgentVersion = default(string), string datamoverImageLocation = default(string), int? datamoverServiceType = default(int?), int? datamoverUpgradability = default(int?), VlanParams defaultVlanParams = default(VlanParams), string description = default(string), int? distribution = default(int?), SizeInfo frontEndSizeInfo = default(SizeInfo), List<string> hosts = default(List<string>), string initContainerImageLocation = default(string), IPMode ipMode = default(IPMode), bool? isAwsPluginInstalled = default(bool?), bool? isCohesityPluginInstalled = default(bool?), bool? isKubevirtEnabled = default(bool?), bool? isKubevirtPluginInstalled = default(bool?), bool? isManagedCluster = default(bool?), bool? isOadpInstalled = default(bool?), bool? isOpenshiftPluginInstalled = default(bool?), List<LabelAttributesInfo> labelAttributesVec = default(List<LabelAttributesInfo>), List<string> labelVec = default(List<string>), string name = default(string), string _namespace = default(string), string priorityClassName = default(string), string pvcName = default(string), string refreshError = default(string), Dictionary<string, string> serviceAnnotations = default(Dictionary<string, string>), Dictionary<string, long> servicesToConnectorIdsMap = default(Dictionary<string, long>), string sourceId = default(string), List<EntityStorageClassInfo> storageClassVec = default(List<EntityStorageClassInfo>), List<PodInfoPodSpecToleration> tolerationsVec = default(List<PodInfoPodSpecToleration>), int? type = default(int?), string uuid = default(string), string veleroAwsPluginImageLocation = default(string), bool? veleroBslChecksumAlgoAvailable = default(bool?), string veleroImageLocation = default(string), string veleroKubevirtPluginImageLocation = default(string), string veleroOpenshiftPluginImageLocation = default(string), int? veleroUpgradability = default(int?), string veleroVersion = default(string), string version = default(string), List<VlanInfo> vlanInfoVec = default(List<VlanInfo>))
        {
            this.CohesityResourceAnnotations = cohesityResourceAnnotations;
            this.CohesityResourceLabels = cohesityResourceLabels;
            this.CohesityVeleroPluginImageLocation = cohesityVeleroPluginImageLocation;
            this.DatamoverAgentVersion = datamoverAgentVersion;
            this.DatamoverImageLocation = datamoverImageLocation;
            this.DatamoverServiceType = datamoverServiceType;
            this.DatamoverUpgradability = datamoverUpgradability;
            this.Description = description;
            this.Distribution = distribution;
            this.Hosts = hosts;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.IsAwsPluginInstalled = isAwsPluginInstalled;
            this.IsCohesityPluginInstalled = isCohesityPluginInstalled;
            this.IsKubevirtEnabled = isKubevirtEnabled;
            this.IsKubevirtPluginInstalled = isKubevirtPluginInstalled;
            this.IsManagedCluster = isManagedCluster;
            this.IsOadpInstalled = isOadpInstalled;
            this.IsOpenshiftPluginInstalled = isOpenshiftPluginInstalled;
            this.LabelAttributesVec = labelAttributesVec;
            this.LabelVec = labelVec;
            this.Name = name;
            this.Namespace = _namespace;
            this.PriorityClassName = priorityClassName;
            this.PvcName = pvcName;
            this.RefreshError = refreshError;
            this.ServiceAnnotations = serviceAnnotations;
            this.ServicesToConnectorIdsMap = servicesToConnectorIdsMap;
            this.SourceId = sourceId;
            this.StorageClassVec = storageClassVec;
            this.TolerationsVec = tolerationsVec;
            this.Type = type;
            this.Uuid = uuid;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroBslChecksumAlgoAvailable = veleroBslChecksumAlgoAvailable;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroKubevirtPluginImageLocation = veleroKubevirtPluginImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.VeleroUpgradability = veleroUpgradability;
            this.VeleroVersion = veleroVersion;
            this.Version = version;
            this.VlanInfoVec = vlanInfoVec;
            this.CohesityResourceAnnotations = cohesityResourceAnnotations;
            this.CohesityResourceLabels = cohesityResourceLabels;
            this.CohesityVeleroPluginImageLocation = cohesityVeleroPluginImageLocation;
            this.DatamoverAgentVersion = datamoverAgentVersion;
            this.DatamoverImageLocation = datamoverImageLocation;
            this.DatamoverServiceType = datamoverServiceType;
            this.DatamoverUpgradability = datamoverUpgradability;
            this.DefaultVlanParams = defaultVlanParams;
            this.Description = description;
            this.Distribution = distribution;
            this.FrontEndSizeInfo = frontEndSizeInfo;
            this.Hosts = hosts;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.IpMode = ipMode;
            this.IsAwsPluginInstalled = isAwsPluginInstalled;
            this.IsCohesityPluginInstalled = isCohesityPluginInstalled;
            this.IsKubevirtEnabled = isKubevirtEnabled;
            this.IsKubevirtPluginInstalled = isKubevirtPluginInstalled;
            this.IsManagedCluster = isManagedCluster;
            this.IsOadpInstalled = isOadpInstalled;
            this.IsOpenshiftPluginInstalled = isOpenshiftPluginInstalled;
            this.LabelAttributesVec = labelAttributesVec;
            this.LabelVec = labelVec;
            this.Name = name;
            this.Namespace = _namespace;
            this.PriorityClassName = priorityClassName;
            this.PvcName = pvcName;
            this.RefreshError = refreshError;
            this.ServiceAnnotations = serviceAnnotations;
            this.ServicesToConnectorIdsMap = servicesToConnectorIdsMap;
            this.SourceId = sourceId;
            this.StorageClassVec = storageClassVec;
            this.TolerationsVec = tolerationsVec;
            this.Type = type;
            this.Uuid = uuid;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroBslChecksumAlgoAvailable = veleroBslChecksumAlgoAvailable;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroKubevirtPluginImageLocation = veleroKubevirtPluginImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.VeleroUpgradability = veleroUpgradability;
            this.VeleroVersion = veleroVersion;
            this.Version = version;
            this.VlanInfoVec = vlanInfoVec;
        }
        
        /// <summary>
        /// List of annotations to apply to resources created/deployed by cohesity at the source.
        /// </summary>
        /// <value>List of annotations to apply to resources created/deployed by cohesity at the source.</value>
        [DataMember(Name="cohesityResourceAnnotations", EmitDefaultValue=true)]
        public Dictionary<string, string> CohesityResourceAnnotations { get; set; }

        /// <summary>
        /// List of labels to apply to resources created/deployed by cohesity at the source.
        /// </summary>
        /// <value>List of labels to apply to resources created/deployed by cohesity at the source.</value>
        [DataMember(Name="cohesityResourceLabels", EmitDefaultValue=true)]
        public Dictionary<string, string> CohesityResourceLabels { get; set; }

        /// <summary>
        /// Location of Cohesity Velero plugin image on a private registry.
        /// </summary>
        /// <value>Location of Cohesity Velero plugin image on a private registry.</value>
        [DataMember(Name="cohesityVeleroPluginImageLocation", EmitDefaultValue=true)]
        public string CohesityVeleroPluginImageLocation { get; set; }

        /// <summary>
        /// Software version of the agent running in the DataMover pod.
        /// </summary>
        /// <value>Software version of the agent running in the DataMover pod.</value>
        [DataMember(Name="datamoverAgentVersion", EmitDefaultValue=true)]
        public string DatamoverAgentVersion { get; set; }

        /// <summary>
        /// Location of the datamover image specified by the user.
        /// </summary>
        /// <value>Location of the datamover image specified by the user.</value>
        [DataMember(Name="datamoverImageLocation", EmitDefaultValue=true)]
        public string DatamoverImageLocation { get; set; }

        /// <summary>
        /// Type of service to be deployed for communication with DataMover pods. Currently, LoadBalancer and NodePort are supported.
        /// </summary>
        /// <value>Type of service to be deployed for communication with DataMover pods. Currently, LoadBalancer and NodePort are supported.</value>
        [DataMember(Name="datamoverServiceType", EmitDefaultValue=true)]
        public int? DatamoverServiceType { get; set; }

        /// <summary>
        /// Indicates if deployed datamover needs to be upgraded for this kubernetes entity.
        /// </summary>
        /// <value>Indicates if deployed datamover needs to be upgraded for this kubernetes entity.</value>
        [DataMember(Name="datamoverUpgradability", EmitDefaultValue=true)]
        public int? DatamoverUpgradability { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVlanParams
        /// </summary>
        [DataMember(Name="defaultVlanParams", EmitDefaultValue=false)]
        public VlanParams DefaultVlanParams { get; set; }

        /// <summary>
        /// This is a general description that could be set for some entities.
        /// </summary>
        /// <value>This is a general description that could be set for some entities.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// K8s distribution. This will only be applicable to kCluster entities.
        /// </summary>
        /// <value>K8s distribution. This will only be applicable to kCluster entities.</value>
        [DataMember(Name="distribution", EmitDefaultValue=true)]
        public int? Distribution { get; set; }

        /// <summary>
        /// Gets or Sets FrontEndSizeInfo
        /// </summary>
        [DataMember(Name="frontEndSizeInfo", EmitDefaultValue=false)]
        public SizeInfo FrontEndSizeInfo { get; set; }

        /// <summary>
        /// List of hosts to be populated as SAN fields in the agent certificate.
        /// </summary>
        /// <value>List of hosts to be populated as SAN fields in the agent certificate.</value>
        [DataMember(Name="hosts", EmitDefaultValue=true)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// Location of the init container image specified by the user.
        /// </summary>
        /// <value>Location of the init container image specified by the user.</value>
        [DataMember(Name="initContainerImageLocation", EmitDefaultValue=true)]
        public string InitContainerImageLocation { get; set; }

        /// <summary>
        /// Gets or Sets IpMode
        /// </summary>
        [DataMember(Name="ipMode", EmitDefaultValue=false)]
        public IPMode IpMode { get; set; }

        /// <summary>
        /// Denotes if item actions of aws plugin are present on the deployed velero server.
        /// </summary>
        /// <value>Denotes if item actions of aws plugin are present on the deployed velero server.</value>
        [DataMember(Name="isAwsPluginInstalled", EmitDefaultValue=true)]
        public bool? IsAwsPluginInstalled { get; set; }

        /// <summary>
        /// Denotes if item actions of cohesity plugin are present on the deployed velero server.
        /// </summary>
        /// <value>Denotes if item actions of cohesity plugin are present on the deployed velero server.</value>
        [DataMember(Name="isCohesityPluginInstalled", EmitDefaultValue=true)]
        public bool? IsCohesityPluginInstalled { get; set; }

        /// <summary>
        /// Boolean to denote if kubevirt is enabled on cluster. Only to be set if kubevirt api group is present in GetApiResourcesOp. This field is only set for root proto.
        /// </summary>
        /// <value>Boolean to denote if kubevirt is enabled on cluster. Only to be set if kubevirt api group is present in GetApiResourcesOp. This field is only set for root proto.</value>
        [DataMember(Name="isKubevirtEnabled", EmitDefaultValue=true)]
        public bool? IsKubevirtEnabled { get; set; }

        /// <summary>
        /// Denotes if item actions of kubevirt plugin are present on the deployed velero server.
        /// </summary>
        /// <value>Denotes if item actions of kubevirt plugin are present on the deployed velero server.</value>
        [DataMember(Name="isKubevirtPluginInstalled", EmitDefaultValue=true)]
        public bool? IsKubevirtPluginInstalled { get; set; }

        /// <summary>
        /// Set if this Entity is a managed cluster and hence not a top level entity. If the Kubernetes cluster is discovered as part of a cloud source it is not a top level entity.
        /// </summary>
        /// <value>Set if this Entity is a managed cluster and hence not a top level entity. If the Kubernetes cluster is discovered as part of a cloud source it is not a top level entity.</value>
        [DataMember(Name="isManagedCluster", EmitDefaultValue=true)]
        public bool? IsManagedCluster { get; set; }

        /// <summary>
        /// Flag to indicate where Redhat OADP operator is installed
        /// </summary>
        /// <value>Flag to indicate where Redhat OADP operator is installed</value>
        [DataMember(Name="isOadpInstalled", EmitDefaultValue=true)]
        public bool? IsOadpInstalled { get; set; }

        /// <summary>
        /// Denotes if item actions of openshift plugin are present on the deployed velero server.
        /// </summary>
        /// <value>Denotes if item actions of openshift plugin are present on the deployed velero server.</value>
        [DataMember(Name="isOpenshiftPluginInstalled", EmitDefaultValue=true)]
        public bool? IsOpenshiftPluginInstalled { get; set; }

        /// <summary>
        /// Label attributes vector contains info about the label nodes corresponding to the current entity&#39;s labels. TODO(jhwang): Make it applicable to non-kNamespace type entities also.
        /// </summary>
        /// <value>Label attributes vector contains info about the label nodes corresponding to the current entity&#39;s labels. TODO(jhwang): Make it applicable to non-kNamespace type entities also.</value>
        [DataMember(Name="labelAttributesVec", EmitDefaultValue=true)]
        public List<LabelAttributesInfo> LabelAttributesVec { get; set; }

        /// <summary>
        /// List of labels associated with this entity in the form \&quot;key:value\&quot;. Currently, only populated for PVCs to be used for label based include/exclude filters.
        /// </summary>
        /// <value>List of labels associated with this entity in the form \&quot;key:value\&quot;. Currently, only populated for PVCs to be used for label based include/exclude filters.</value>
        [DataMember(Name="labelVec", EmitDefaultValue=true)]
        public List<string> LabelVec { get; set; }

        /// <summary>
        /// A human readable name for the object.
        /// </summary>
        /// <value>A human readable name for the object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Namespace of object, if applicable. For a PV, this field stores the namespace of the PVC which is bound to the PV.
        /// </summary>
        /// <value>Namespace of object, if applicable. For a PV, this field stores the namespace of the PVC which is bound to the PV.</value>
        [DataMember(Name="namespace", EmitDefaultValue=true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Pods deployed by cohesity at the K8s source directly (temp pods for example) or through workloads (deployments, daemonsets, jobs, replicaset etc) shall have priorityClassName in its spec set to specified value below.
        /// </summary>
        /// <value>Pods deployed by cohesity at the K8s source directly (temp pods for example) or through workloads (deployments, daemonsets, jobs, replicaset etc) shall have priorityClassName in its spec set to specified value below.</value>
        [DataMember(Name="priorityClassName", EmitDefaultValue=true)]
        public string PriorityClassName { get; set; }

        /// <summary>
        /// Name of the PVC which is bound to the PV. Applicable only to &#39;kPersistentVolume&#39; type entity.
        /// </summary>
        /// <value>Name of the PVC which is bound to the PV. Applicable only to &#39;kPersistentVolume&#39; type entity.</value>
        [DataMember(Name="pvcName", EmitDefaultValue=true)]
        public string PvcName { get; set; }

        /// <summary>
        /// Refresh error encountered for managed clusters.
        /// </summary>
        /// <value>Refresh error encountered for managed clusters.</value>
        [DataMember(Name="refreshError", EmitDefaultValue=true)]
        public string RefreshError { get; set; }

        /// <summary>
        /// Contains generic annotations to be put on services.
        /// </summary>
        /// <value>Contains generic annotations to be put on services.</value>
        [DataMember(Name="serviceAnnotations", EmitDefaultValue=true)]
        public Dictionary<string, string> ServiceAnnotations { get; set; }

        /// <summary>
        /// A mapping from datamover services to corresponding unique connector_params IDs. This will be generated during registration and updated during refresh. Applicable only for &#39;kCluster&#39; type entities.
        /// </summary>
        /// <value>A mapping from datamover services to corresponding unique connector_params IDs. This will be generated during registration and updated during refresh. Applicable only for &#39;kCluster&#39; type entities.</value>
        [DataMember(Name="servicesToConnectorIdsMap", EmitDefaultValue=true)]
        public Dictionary<string, long> ServicesToConnectorIdsMap { get; set; }

        /// <summary>
        /// Identifier to be used while deploying resources on the kubernetes cluster. This will be set to a randomly generated guid for DMaaS clusters and Cohesity cluster id for on prem clusters.
        /// </summary>
        /// <value>Identifier to be used while deploying resources on the kubernetes cluster. This will be set to a randomly generated guid for DMaaS clusters and Cohesity cluster id for on prem clusters.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=true)]
        public string SourceId { get; set; }

        /// <summary>
        /// This is populated for the root entity only (type kCluster).
        /// </summary>
        /// <value>This is populated for the root entity only (type kCluster).</value>
        [DataMember(Name="storageClassVec", EmitDefaultValue=true)]
        public List<EntityStorageClassInfo> StorageClassVec { get; set; }

        /// <summary>
        /// Custom tolerations for Datamover pods.
        /// </summary>
        /// <value>Custom tolerations for Datamover pods.</value>
        [DataMember(Name="tolerationsVec", EmitDefaultValue=true)]
        public List<PodInfoPodSpecToleration> TolerationsVec { get; set; }

        /// <summary>
        /// The type of entity this proto refers to.
        /// </summary>
        /// <value>The type of entity this proto refers to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// The UUID of the object.
        /// </summary>
        /// <value>The UUID of the object.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Location of the Velero AWS plugin image specified by the user.
        /// </summary>
        /// <value>Location of the Velero AWS plugin image specified by the user.</value>
        [DataMember(Name="veleroAwsPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroAwsPluginImageLocation { get; set; }

        /// <summary>
        /// Whether checksumAlgorithm field is supported in the velero BSL config.
        /// </summary>
        /// <value>Whether checksumAlgorithm field is supported in the velero BSL config.</value>
        [DataMember(Name="veleroBslChecksumAlgoAvailable", EmitDefaultValue=true)]
        public bool? VeleroBslChecksumAlgoAvailable { get; set; }

        /// <summary>
        /// Location of the Velero image specified by the user.
        /// </summary>
        /// <value>Location of the Velero image specified by the user.</value>
        [DataMember(Name="veleroImageLocation", EmitDefaultValue=true)]
        public string VeleroImageLocation { get; set; }

        /// <summary>
        /// Location of Velero Kubevirt plugin image on a private registry.
        /// </summary>
        /// <value>Location of Velero Kubevirt plugin image on a private registry.</value>
        [DataMember(Name="veleroKubevirtPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroKubevirtPluginImageLocation { get; set; }

        /// <summary>
        /// Location of the Velero Openshift plugin image specified by the user.
        /// </summary>
        /// <value>Location of the Velero Openshift plugin image specified by the user.</value>
        [DataMember(Name="veleroOpenshiftPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroOpenshiftPluginImageLocation { get; set; }

        /// <summary>
        /// Indicates if deployed Velero image needs to be upgraded for this kubernetes entity.
        /// </summary>
        /// <value>Indicates if deployed Velero image needs to be upgraded for this kubernetes entity.</value>
        [DataMember(Name="veleroUpgradability", EmitDefaultValue=true)]
        public int? VeleroUpgradability { get; set; }

        /// <summary>
        /// Velero version deployed.
        /// </summary>
        /// <value>Velero version deployed.</value>
        [DataMember(Name="veleroVersion", EmitDefaultValue=true)]
        public string VeleroVersion { get; set; }

        /// <summary>
        /// Kubernetes cluster version.
        /// </summary>
        /// <value>Kubernetes cluster version.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// VLAN information provided during registration.
        /// </summary>
        /// <value>VLAN information provided during registration.</value>
        [DataMember(Name="vlanInfoVec", EmitDefaultValue=true)]
        public List<VlanInfo> VlanInfoVec { get; set; }

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
            return this.Equals(input as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="input">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CohesityResourceAnnotations == input.CohesityResourceAnnotations ||
                    this.CohesityResourceAnnotations != null &&
                    input.CohesityResourceAnnotations != null &&
                    this.CohesityResourceAnnotations.SequenceEqual(input.CohesityResourceAnnotations)
                ) && 
                (
                    this.CohesityResourceLabels == input.CohesityResourceLabels ||
                    this.CohesityResourceLabels != null &&
                    input.CohesityResourceLabels != null &&
                    this.CohesityResourceLabels.SequenceEqual(input.CohesityResourceLabels)
                ) && 
                (
                    this.CohesityVeleroPluginImageLocation == input.CohesityVeleroPluginImageLocation ||
                    (this.CohesityVeleroPluginImageLocation != null &&
                    this.CohesityVeleroPluginImageLocation.Equals(input.CohesityVeleroPluginImageLocation))
                ) && 
                (
                    this.DatamoverAgentVersion == input.DatamoverAgentVersion ||
                    (this.DatamoverAgentVersion != null &&
                    this.DatamoverAgentVersion.Equals(input.DatamoverAgentVersion))
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
                    (this.Distribution != null &&
                    this.Distribution.Equals(input.Distribution))
                ) && 
                (
                    this.FrontEndSizeInfo == input.FrontEndSizeInfo ||
                    (this.FrontEndSizeInfo != null &&
                    this.FrontEndSizeInfo.Equals(input.FrontEndSizeInfo))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
                ) && 
                (
                    this.InitContainerImageLocation == input.InitContainerImageLocation ||
                    (this.InitContainerImageLocation != null &&
                    this.InitContainerImageLocation.Equals(input.InitContainerImageLocation))
                ) && 
                (
                    this.IpMode == input.IpMode ||
                    (this.IpMode != null &&
                    this.IpMode.Equals(input.IpMode))
                ) && 
                (
                    this.IsAwsPluginInstalled == input.IsAwsPluginInstalled ||
                    (this.IsAwsPluginInstalled != null &&
                    this.IsAwsPluginInstalled.Equals(input.IsAwsPluginInstalled))
                ) && 
                (
                    this.IsCohesityPluginInstalled == input.IsCohesityPluginInstalled ||
                    (this.IsCohesityPluginInstalled != null &&
                    this.IsCohesityPluginInstalled.Equals(input.IsCohesityPluginInstalled))
                ) && 
                (
                    this.IsKubevirtEnabled == input.IsKubevirtEnabled ||
                    (this.IsKubevirtEnabled != null &&
                    this.IsKubevirtEnabled.Equals(input.IsKubevirtEnabled))
                ) && 
                (
                    this.IsKubevirtPluginInstalled == input.IsKubevirtPluginInstalled ||
                    (this.IsKubevirtPluginInstalled != null &&
                    this.IsKubevirtPluginInstalled.Equals(input.IsKubevirtPluginInstalled))
                ) && 
                (
                    this.IsManagedCluster == input.IsManagedCluster ||
                    (this.IsManagedCluster != null &&
                    this.IsManagedCluster.Equals(input.IsManagedCluster))
                ) && 
                (
                    this.IsOadpInstalled == input.IsOadpInstalled ||
                    (this.IsOadpInstalled != null &&
                    this.IsOadpInstalled.Equals(input.IsOadpInstalled))
                ) && 
                (
                    this.IsOpenshiftPluginInstalled == input.IsOpenshiftPluginInstalled ||
                    (this.IsOpenshiftPluginInstalled != null &&
                    this.IsOpenshiftPluginInstalled.Equals(input.IsOpenshiftPluginInstalled))
                ) && 
                (
                    this.LabelAttributesVec == input.LabelAttributesVec ||
                    this.LabelAttributesVec != null &&
                    input.LabelAttributesVec != null &&
                    this.LabelAttributesVec.SequenceEqual(input.LabelAttributesVec)
                ) && 
                (
                    this.LabelVec == input.LabelVec ||
                    this.LabelVec != null &&
                    input.LabelVec != null &&
                    this.LabelVec.SequenceEqual(input.LabelVec)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PriorityClassName == input.PriorityClassName ||
                    (this.PriorityClassName != null &&
                    this.PriorityClassName.Equals(input.PriorityClassName))
                ) && 
                (
                    this.PvcName == input.PvcName ||
                    (this.PvcName != null &&
                    this.PvcName.Equals(input.PvcName))
                ) && 
                (
                    this.RefreshError == input.RefreshError ||
                    (this.RefreshError != null &&
                    this.RefreshError.Equals(input.RefreshError))
                ) && 
                (
                    this.ServiceAnnotations == input.ServiceAnnotations ||
                    this.ServiceAnnotations != null &&
                    input.ServiceAnnotations != null &&
                    this.ServiceAnnotations.SequenceEqual(input.ServiceAnnotations)
                ) && 
                (
                    this.ServicesToConnectorIdsMap == input.ServicesToConnectorIdsMap ||
                    this.ServicesToConnectorIdsMap != null &&
                    input.ServicesToConnectorIdsMap != null &&
                    this.ServicesToConnectorIdsMap.SequenceEqual(input.ServicesToConnectorIdsMap)
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.StorageClassVec == input.StorageClassVec ||
                    this.StorageClassVec != null &&
                    input.StorageClassVec != null &&
                    this.StorageClassVec.SequenceEqual(input.StorageClassVec)
                ) && 
                (
                    this.TolerationsVec == input.TolerationsVec ||
                    this.TolerationsVec != null &&
                    input.TolerationsVec != null &&
                    this.TolerationsVec.SequenceEqual(input.TolerationsVec)
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
                    this.VeleroAwsPluginImageLocation == input.VeleroAwsPluginImageLocation ||
                    (this.VeleroAwsPluginImageLocation != null &&
                    this.VeleroAwsPluginImageLocation.Equals(input.VeleroAwsPluginImageLocation))
                ) && 
                (
                    this.VeleroBslChecksumAlgoAvailable == input.VeleroBslChecksumAlgoAvailable ||
                    (this.VeleroBslChecksumAlgoAvailable != null &&
                    this.VeleroBslChecksumAlgoAvailable.Equals(input.VeleroBslChecksumAlgoAvailable))
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
                    this.VeleroUpgradability == input.VeleroUpgradability ||
                    (this.VeleroUpgradability != null &&
                    this.VeleroUpgradability.Equals(input.VeleroUpgradability))
                ) && 
                (
                    this.VeleroVersion == input.VeleroVersion ||
                    (this.VeleroVersion != null &&
                    this.VeleroVersion.Equals(input.VeleroVersion))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.CohesityResourceAnnotations != null)
                    hashCode = hashCode * 59 + this.CohesityResourceAnnotations.GetHashCode();
                if (this.CohesityResourceLabels != null)
                    hashCode = hashCode * 59 + this.CohesityResourceLabels.GetHashCode();
                if (this.CohesityVeleroPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.CohesityVeleroPluginImageLocation.GetHashCode();
                if (this.DatamoverAgentVersion != null)
                    hashCode = hashCode * 59 + this.DatamoverAgentVersion.GetHashCode();
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
                if (this.Distribution != null)
                    hashCode = hashCode * 59 + this.Distribution.GetHashCode();
                if (this.FrontEndSizeInfo != null)
                    hashCode = hashCode * 59 + this.FrontEndSizeInfo.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.InitContainerImageLocation != null)
                    hashCode = hashCode * 59 + this.InitContainerImageLocation.GetHashCode();
                if (this.IpMode != null)
                    hashCode = hashCode * 59 + this.IpMode.GetHashCode();
                if (this.IsAwsPluginInstalled != null)
                    hashCode = hashCode * 59 + this.IsAwsPluginInstalled.GetHashCode();
                if (this.IsCohesityPluginInstalled != null)
                    hashCode = hashCode * 59 + this.IsCohesityPluginInstalled.GetHashCode();
                if (this.IsKubevirtEnabled != null)
                    hashCode = hashCode * 59 + this.IsKubevirtEnabled.GetHashCode();
                if (this.IsKubevirtPluginInstalled != null)
                    hashCode = hashCode * 59 + this.IsKubevirtPluginInstalled.GetHashCode();
                if (this.IsManagedCluster != null)
                    hashCode = hashCode * 59 + this.IsManagedCluster.GetHashCode();
                if (this.IsOadpInstalled != null)
                    hashCode = hashCode * 59 + this.IsOadpInstalled.GetHashCode();
                if (this.IsOpenshiftPluginInstalled != null)
                    hashCode = hashCode * 59 + this.IsOpenshiftPluginInstalled.GetHashCode();
                if (this.LabelAttributesVec != null)
                    hashCode = hashCode * 59 + this.LabelAttributesVec.GetHashCode();
                if (this.LabelVec != null)
                    hashCode = hashCode * 59 + this.LabelVec.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.PriorityClassName != null)
                    hashCode = hashCode * 59 + this.PriorityClassName.GetHashCode();
                if (this.PvcName != null)
                    hashCode = hashCode * 59 + this.PvcName.GetHashCode();
                if (this.RefreshError != null)
                    hashCode = hashCode * 59 + this.RefreshError.GetHashCode();
                if (this.ServiceAnnotations != null)
                    hashCode = hashCode * 59 + this.ServiceAnnotations.GetHashCode();
                if (this.ServicesToConnectorIdsMap != null)
                    hashCode = hashCode * 59 + this.ServicesToConnectorIdsMap.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.StorageClassVec != null)
                    hashCode = hashCode * 59 + this.StorageClassVec.GetHashCode();
                if (this.TolerationsVec != null)
                    hashCode = hashCode * 59 + this.TolerationsVec.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VeleroAwsPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroAwsPluginImageLocation.GetHashCode();
                if (this.VeleroBslChecksumAlgoAvailable != null)
                    hashCode = hashCode * 59 + this.VeleroBslChecksumAlgoAvailable.GetHashCode();
                if (this.VeleroImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroImageLocation.GetHashCode();
                if (this.VeleroKubevirtPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroKubevirtPluginImageLocation.GetHashCode();
                if (this.VeleroOpenshiftPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroOpenshiftPluginImageLocation.GetHashCode();
                if (this.VeleroUpgradability != null)
                    hashCode = hashCode * 59 + this.VeleroUpgradability.GetHashCode();
                if (this.VeleroVersion != null)
                    hashCode = hashCode * 59 + this.VeleroVersion.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VlanInfoVec != null)
                    hashCode = hashCode * 59 + this.VlanInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

