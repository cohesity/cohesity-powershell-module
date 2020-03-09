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
    /// Create a Restore Task Request for recovering VMs or mounting volumes to mount points.
    /// </summary>
    [DataContract]
    public partial class RecoverTaskRequest :  IEquatable<RecoverTaskRequest>
    {
        /// <summary>
        /// Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// </summary>
        /// <value>Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GlacierRetrievalTypeEnum
        {
            /// <summary>
            /// Enum KStandard for value: kStandard
            /// </summary>
            [EnumMember(Value = "kStandard")]
            KStandard = 1,

            /// <summary>
            /// Enum KBulk for value: kBulk
            /// </summary>
            [EnumMember(Value = "kBulk")]
            KBulk = 2,

            /// <summary>
            /// Enum KExpedited for value: kExpedited
            /// </summary>
            [EnumMember(Value = "kExpedited")]
            KExpedited = 3

        }

        /// <summary>
        /// Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// </summary>
        /// <value>Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.</value>
        [DataMember(Name="glacierRetrievalType", EmitDefaultValue=true)]
        public GlacierRetrievalTypeEnum? GlacierRetrievalType { get; set; }
        /// <summary>
        /// Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points. &#39;kRecoverNamespaces&#39; specifies a Restore Task that recovers Kubernetes namespaces. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume.
        /// </summary>
        /// <value>Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points. &#39;kRecoverNamespaces&#39; specifies a Restore Task that recovers Kubernetes namespaces. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KRecoverVMs for value: kRecoverVMs
            /// </summary>
            [EnumMember(Value = "kRecoverVMs")]
            KRecoverVMs = 1,

            /// <summary>
            /// Enum KMountVolumes for value: kMountVolumes
            /// </summary>
            [EnumMember(Value = "kMountVolumes")]
            KMountVolumes = 2,

            /// <summary>
            /// Enum KRecoverNamespaces for value: kRecoverNamespaces
            /// </summary>
            [EnumMember(Value = "kRecoverNamespaces")]
            KRecoverNamespaces = 3,

            /// <summary>
            /// Enum KMountFileVolume for value: kMountFileVolume
            /// </summary>
            [EnumMember(Value = "kMountFileVolume")]
            KMountFileVolume = 4

        }

        /// <summary>
        /// Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points. &#39;kRecoverNamespaces&#39; specifies a Restore Task that recovers Kubernetes namespaces. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume.
        /// </summary>
        /// <value>Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points. &#39;kRecoverNamespaces&#39; specifies a Restore Task that recovers Kubernetes namespaces. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverTaskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecoverTaskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverTaskRequest" /> class.
        /// </summary>
        /// <param name="acropolisParameters">acropolisParameters.</param>
        /// <param name="continueOnError">Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible..</param>
        /// <param name="deployVmsToCloud">deployVmsToCloud.</param>
        /// <param name="glacierRetrievalType">Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes..</param>
        /// <param name="hypervParameters">hypervParameters.</param>
        /// <param name="kubernetesParameters">kubernetesParameters.</param>
        /// <param name="mountParameters">mountParameters.</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="newParentId">Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them..</param>
        /// <param name="objects">Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="oneDriveParameters">oneDriveParameters.</param>
        /// <param name="outlookParameters">outlookParameters.</param>
        /// <param name="restoreViewParameters">restoreViewParameters.</param>
        /// <param name="type">Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points. &#39;kRecoverNamespaces&#39; specifies a Restore Task that recovers Kubernetes namespaces. &#39;kMountFileVolume&#39; specifies a Restore Task that mounts a file volume. (required).</param>
        /// <param name="viewName">Specifie target view into which the objects are to be cloned when doing recovery for NAS..</param>
        /// <param name="virtualDiskRestoreParameters">virtualDiskRestoreParameters.</param>
        /// <param name="vlanParameters">vlanParameters.</param>
        /// <param name="vmwareParameters">vmwareParameters.</param>
        public RecoverTaskRequest(AcropolisRestoreParameters acropolisParameters = default(AcropolisRestoreParameters), bool? continueOnError = default(bool?), DeployVmsToCloud deployVmsToCloud = default(DeployVmsToCloud), GlacierRetrievalTypeEnum? glacierRetrievalType = default(GlacierRetrievalTypeEnum?), HypervRestoreParameters hypervParameters = default(HypervRestoreParameters), KubernetesRestoreParameters kubernetesParameters = default(KubernetesRestoreParameters), MountVolumesParameters mountParameters = default(MountVolumesParameters), string name = default(string), long? newParentId = default(long?), List<RestoreObjectDetails> objects = default(List<RestoreObjectDetails>), OneDriveRestoreParameters oneDriveParameters = default(OneDriveRestoreParameters), OutlookRestoreParameters outlookParameters = default(OutlookRestoreParameters), UpdateViewParam restoreViewParameters = default(UpdateViewParam), TypeEnum type = default(TypeEnum), string viewName = default(string), VirtualDiskRestoreParameters virtualDiskRestoreParameters = default(VirtualDiskRestoreParameters), VlanParameters vlanParameters = default(VlanParameters), VmwareRestoreParameters vmwareParameters = default(VmwareRestoreParameters))
        {
            this.ContinueOnError = continueOnError;
            this.GlacierRetrievalType = glacierRetrievalType;
            this.Name = name;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.Type = type;
            this.ViewName = viewName;
            this.AcropolisParameters = acropolisParameters;
            this.ContinueOnError = continueOnError;
            this.DeployVmsToCloud = deployVmsToCloud;
            this.GlacierRetrievalType = glacierRetrievalType;
            this.HypervParameters = hypervParameters;
            this.KubernetesParameters = kubernetesParameters;
            this.MountParameters = mountParameters;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.OneDriveParameters = oneDriveParameters;
            this.OutlookParameters = outlookParameters;
            this.RestoreViewParameters = restoreViewParameters;
            this.ViewName = viewName;
            this.VirtualDiskRestoreParameters = virtualDiskRestoreParameters;
            this.VlanParameters = vlanParameters;
            this.VmwareParameters = vmwareParameters;
        }
        
        /// <summary>
        /// Gets or Sets AcropolisParameters
        /// </summary>
        [DataMember(Name="acropolisParameters", EmitDefaultValue=false)]
        public AcropolisRestoreParameters AcropolisParameters { get; set; }

        /// <summary>
        /// Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.
        /// </summary>
        /// <value>Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Gets or Sets DeployVmsToCloud
        /// </summary>
        [DataMember(Name="deployVmsToCloud", EmitDefaultValue=false)]
        public DeployVmsToCloud DeployVmsToCloud { get; set; }

        /// <summary>
        /// Gets or Sets HypervParameters
        /// </summary>
        [DataMember(Name="hypervParameters", EmitDefaultValue=false)]
        public HypervRestoreParameters HypervParameters { get; set; }

        /// <summary>
        /// Gets or Sets KubernetesParameters
        /// </summary>
        [DataMember(Name="kubernetesParameters", EmitDefaultValue=false)]
        public KubernetesRestoreParameters KubernetesParameters { get; set; }

        /// <summary>
        /// Gets or Sets MountParameters
        /// </summary>
        [DataMember(Name="mountParameters", EmitDefaultValue=false)]
        public MountVolumesParameters MountParameters { get; set; }

        /// <summary>
        /// Specifies the name of the Restore Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Restore Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.
        /// </summary>
        /// <value>Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.</value>
        [DataMember(Name="newParentId", EmitDefaultValue=true)]
        public long? NewParentId { get; set; }

        /// <summary>
        /// Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).
        /// </summary>
        /// <value>Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).</value>
        [DataMember(Name="objects", EmitDefaultValue=true)]
        public List<RestoreObjectDetails> Objects { get; set; }

        /// <summary>
        /// Gets or Sets OneDriveParameters
        /// </summary>
        [DataMember(Name="oneDriveParameters", EmitDefaultValue=false)]
        public OneDriveRestoreParameters OneDriveParameters { get; set; }

        /// <summary>
        /// Gets or Sets OutlookParameters
        /// </summary>
        [DataMember(Name="outlookParameters", EmitDefaultValue=false)]
        public OutlookRestoreParameters OutlookParameters { get; set; }

        /// <summary>
        /// Gets or Sets RestoreViewParameters
        /// </summary>
        [DataMember(Name="restoreViewParameters", EmitDefaultValue=false)]
        public UpdateViewParam RestoreViewParameters { get; set; }

        /// <summary>
        /// Specifie target view into which the objects are to be cloned when doing recovery for NAS.
        /// </summary>
        /// <value>Specifie target view into which the objects are to be cloned when doing recovery for NAS.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// Gets or Sets VirtualDiskRestoreParameters
        /// </summary>
        [DataMember(Name="virtualDiskRestoreParameters", EmitDefaultValue=false)]
        public VirtualDiskRestoreParameters VirtualDiskRestoreParameters { get; set; }

        /// <summary>
        /// Gets or Sets VlanParameters
        /// </summary>
        [DataMember(Name="vlanParameters", EmitDefaultValue=false)]
        public VlanParameters VlanParameters { get; set; }

        /// <summary>
        /// Gets or Sets VmwareParameters
        /// </summary>
        [DataMember(Name="vmwareParameters", EmitDefaultValue=false)]
        public VmwareRestoreParameters VmwareParameters { get; set; }

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
            return this.Equals(input as RecoverTaskRequest);
        }

        /// <summary>
        /// Returns true if RecoverTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisParameters == input.AcropolisParameters ||
                    (this.AcropolisParameters != null &&
                    this.AcropolisParameters.Equals(input.AcropolisParameters))
                ) && 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.DeployVmsToCloud == input.DeployVmsToCloud ||
                    (this.DeployVmsToCloud != null &&
                    this.DeployVmsToCloud.Equals(input.DeployVmsToCloud))
                ) && 
                (
                    this.GlacierRetrievalType == input.GlacierRetrievalType ||
                    this.GlacierRetrievalType.Equals(input.GlacierRetrievalType)
                ) && 
                (
                    this.HypervParameters == input.HypervParameters ||
                    (this.HypervParameters != null &&
                    this.HypervParameters.Equals(input.HypervParameters))
                ) && 
                (
                    this.KubernetesParameters == input.KubernetesParameters ||
                    (this.KubernetesParameters != null &&
                    this.KubernetesParameters.Equals(input.KubernetesParameters))
                ) && 
                (
                    this.MountParameters == input.MountParameters ||
                    (this.MountParameters != null &&
                    this.MountParameters.Equals(input.MountParameters))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewParentId == input.NewParentId ||
                    (this.NewParentId != null &&
                    this.NewParentId.Equals(input.NewParentId))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                ) && 
                (
                    this.OneDriveParameters == input.OneDriveParameters ||
                    (this.OneDriveParameters != null &&
                    this.OneDriveParameters.Equals(input.OneDriveParameters))
                ) && 
                (
                    this.OutlookParameters == input.OutlookParameters ||
                    (this.OutlookParameters != null &&
                    this.OutlookParameters.Equals(input.OutlookParameters))
                ) && 
                (
                    this.RestoreViewParameters == input.RestoreViewParameters ||
                    (this.RestoreViewParameters != null &&
                    this.RestoreViewParameters.Equals(input.RestoreViewParameters))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.VirtualDiskRestoreParameters == input.VirtualDiskRestoreParameters ||
                    (this.VirtualDiskRestoreParameters != null &&
                    this.VirtualDiskRestoreParameters.Equals(input.VirtualDiskRestoreParameters))
                ) && 
                (
                    this.VlanParameters == input.VlanParameters ||
                    (this.VlanParameters != null &&
                    this.VlanParameters.Equals(input.VlanParameters))
                ) && 
                (
                    this.VmwareParameters == input.VmwareParameters ||
                    (this.VmwareParameters != null &&
                    this.VmwareParameters.Equals(input.VmwareParameters))
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
                if (this.AcropolisParameters != null)
                    hashCode = hashCode * 59 + this.AcropolisParameters.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.DeployVmsToCloud != null)
                    hashCode = hashCode * 59 + this.DeployVmsToCloud.GetHashCode();
                hashCode = hashCode * 59 + this.GlacierRetrievalType.GetHashCode();
                if (this.HypervParameters != null)
                    hashCode = hashCode * 59 + this.HypervParameters.GetHashCode();
                if (this.KubernetesParameters != null)
                    hashCode = hashCode * 59 + this.KubernetesParameters.GetHashCode();
                if (this.MountParameters != null)
                    hashCode = hashCode * 59 + this.MountParameters.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewParentId != null)
                    hashCode = hashCode * 59 + this.NewParentId.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.OneDriveParameters != null)
                    hashCode = hashCode * 59 + this.OneDriveParameters.GetHashCode();
                if (this.OutlookParameters != null)
                    hashCode = hashCode * 59 + this.OutlookParameters.GetHashCode();
                if (this.RestoreViewParameters != null)
                    hashCode = hashCode * 59 + this.RestoreViewParameters.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.VirtualDiskRestoreParameters != null)
                    hashCode = hashCode * 59 + this.VirtualDiskRestoreParameters.GetHashCode();
                if (this.VlanParameters != null)
                    hashCode = hashCode * 59 + this.VlanParameters.GetHashCode();
                if (this.VmwareParameters != null)
                    hashCode = hashCode * 59 + this.VmwareParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}

