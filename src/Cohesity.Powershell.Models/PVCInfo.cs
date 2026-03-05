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
    /// PvcInfo
    /// </summary>
    [DataContract]
    public partial class PvcInfo :  IEquatable<PvcInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PvcInfo" /> class.
        /// </summary>
        /// <param name="accessModes">Access modes of the PVC..</param>
        /// <param name="annotations">A set of key-value pairs, capturing the annotations of a k8s object..</param>
        /// <param name="creationTimestamp">Time of creation of the PVC..</param>
        /// <param name="deletionTimestamp">Time of deletion of the PVC..</param>
        /// <param name="isStatic">\&quot;Whether the underlying PV was statically (manually) provisioned.\&quot;.</param>
        /// <param name="labels">A set of key-value pairs, capturing the labels of a k8s object..</param>
        /// <param name="name">Name of the pvc..</param>
        /// <param name="phase">Status of pod. Eg: \&quot;Bound\&quot;, \&quot;Pending\&quot;..</param>
        /// <param name="request">Size of request as in the PVC spec..</param>
        /// <param name="scWaitForFirstConsumer">If the PVC has not been provisioned as it waiting for first consumer. This property is controlled by the volumeBindingMode of the storage class..</param>
        /// <param name="sizeInBytes">Size of the PVC. Specifically the capacity of the underlying PV..</param>
        /// <param name="storageClass">Storage class of the PVC..</param>
        /// <param name="uuid">UUID of the PVC.</param>
        /// <param name="volumeMode">Volume mode of the PVC. Value could be Block, Filesystem, or empty (implying Filesystem)..</param>
        /// <param name="volumeName">Name of the volume that is used by this PVC..</param>
        public PvcInfo(List<string> accessModes = default(List<string>), Dictionary<string, string> annotations = default(Dictionary<string, string>), string creationTimestamp = default(string), string deletionTimestamp = default(string), bool? isStatic = default(bool?), Dictionary<string, string> labels = default(Dictionary<string, string>), string name = default(string), string phase = default(string), long? request = default(long?), bool? scWaitForFirstConsumer = default(bool?), long? sizeInBytes = default(long?), string storageClass = default(string), string uuid = default(string), string volumeMode = default(string), string volumeName = default(string))
        {
            this.AccessModes = accessModes;
            this.Annotations = annotations;
            this.CreationTimestamp = creationTimestamp;
            this.DeletionTimestamp = deletionTimestamp;
            this.IsStatic = isStatic;
            this.Labels = labels;
            this.Name = name;
            this.Phase = phase;
            this.Request = request;
            this.ScWaitForFirstConsumer = scWaitForFirstConsumer;
            this.SizeInBytes = sizeInBytes;
            this.StorageClass = storageClass;
            this.Uuid = uuid;
            this.VolumeMode = volumeMode;
            this.VolumeName = volumeName;
            this.AccessModes = accessModes;
            this.Annotations = annotations;
            this.CreationTimestamp = creationTimestamp;
            this.DeletionTimestamp = deletionTimestamp;
            this.IsStatic = isStatic;
            this.Labels = labels;
            this.Name = name;
            this.Phase = phase;
            this.Request = request;
            this.ScWaitForFirstConsumer = scWaitForFirstConsumer;
            this.SizeInBytes = sizeInBytes;
            this.StorageClass = storageClass;
            this.Uuid = uuid;
            this.VolumeMode = volumeMode;
            this.VolumeName = volumeName;
        }
        
        /// <summary>
        /// Access modes of the PVC.
        /// </summary>
        /// <value>Access modes of the PVC.</value>
        [DataMember(Name="accessModes", EmitDefaultValue=true)]
        public List<string> AccessModes { get; set; }

        /// <summary>
        /// A set of key-value pairs, capturing the annotations of a k8s object.
        /// </summary>
        /// <value>A set of key-value pairs, capturing the annotations of a k8s object.</value>
        [DataMember(Name="annotations", EmitDefaultValue=true)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Time of creation of the PVC.
        /// </summary>
        /// <value>Time of creation of the PVC.</value>
        [DataMember(Name="creationTimestamp", EmitDefaultValue=true)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// Time of deletion of the PVC.
        /// </summary>
        /// <value>Time of deletion of the PVC.</value>
        [DataMember(Name="deletionTimestamp", EmitDefaultValue=true)]
        public string DeletionTimestamp { get; set; }

        /// <summary>
        /// \&quot;Whether the underlying PV was statically (manually) provisioned.\&quot;
        /// </summary>
        /// <value>\&quot;Whether the underlying PV was statically (manually) provisioned.\&quot;</value>
        [DataMember(Name="isStatic", EmitDefaultValue=true)]
        public bool? IsStatic { get; set; }

        /// <summary>
        /// A set of key-value pairs, capturing the labels of a k8s object.
        /// </summary>
        /// <value>A set of key-value pairs, capturing the labels of a k8s object.</value>
        [DataMember(Name="labels", EmitDefaultValue=true)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Name of the pvc.
        /// </summary>
        /// <value>Name of the pvc.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Status of pod. Eg: \&quot;Bound\&quot;, \&quot;Pending\&quot;.
        /// </summary>
        /// <value>Status of pod. Eg: \&quot;Bound\&quot;, \&quot;Pending\&quot;.</value>
        [DataMember(Name="phase", EmitDefaultValue=true)]
        public string Phase { get; set; }

        /// <summary>
        /// Size of request as in the PVC spec.
        /// </summary>
        /// <value>Size of request as in the PVC spec.</value>
        [DataMember(Name="request", EmitDefaultValue=true)]
        public long? Request { get; set; }

        /// <summary>
        /// If the PVC has not been provisioned as it waiting for first consumer. This property is controlled by the volumeBindingMode of the storage class.
        /// </summary>
        /// <value>If the PVC has not been provisioned as it waiting for first consumer. This property is controlled by the volumeBindingMode of the storage class.</value>
        [DataMember(Name="scWaitForFirstConsumer", EmitDefaultValue=true)]
        public bool? ScWaitForFirstConsumer { get; set; }

        /// <summary>
        /// Size of the PVC. Specifically the capacity of the underlying PV.
        /// </summary>
        /// <value>Size of the PVC. Specifically the capacity of the underlying PV.</value>
        [DataMember(Name="sizeInBytes", EmitDefaultValue=true)]
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Storage class of the PVC.
        /// </summary>
        /// <value>Storage class of the PVC.</value>
        [DataMember(Name="storageClass", EmitDefaultValue=true)]
        public string StorageClass { get; set; }

        /// <summary>
        /// UUID of the PVC
        /// </summary>
        /// <value>UUID of the PVC</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Volume mode of the PVC. Value could be Block, Filesystem, or empty (implying Filesystem).
        /// </summary>
        /// <value>Volume mode of the PVC. Value could be Block, Filesystem, or empty (implying Filesystem).</value>
        [DataMember(Name="volumeMode", EmitDefaultValue=true)]
        public string VolumeMode { get; set; }

        /// <summary>
        /// Name of the volume that is used by this PVC.
        /// </summary>
        /// <value>Name of the volume that is used by this PVC.</value>
        [DataMember(Name="volumeName", EmitDefaultValue=true)]
        public string VolumeName { get; set; }

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
            return this.Equals(input as PvcInfo);
        }

        /// <summary>
        /// Returns true if PvcInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PvcInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PvcInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessModes == input.AccessModes ||
                    this.AccessModes != null &&
                    input.AccessModes != null &&
                    this.AccessModes.SequenceEqual(input.AccessModes)
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                ) && 
                (
                    this.DeletionTimestamp == input.DeletionTimestamp ||
                    (this.DeletionTimestamp != null &&
                    this.DeletionTimestamp.Equals(input.DeletionTimestamp))
                ) && 
                (
                    this.IsStatic == input.IsStatic ||
                    (this.IsStatic != null &&
                    this.IsStatic.Equals(input.IsStatic))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.ScWaitForFirstConsumer == input.ScWaitForFirstConsumer ||
                    (this.ScWaitForFirstConsumer != null &&
                    this.ScWaitForFirstConsumer.Equals(input.ScWaitForFirstConsumer))
                ) && 
                (
                    this.SizeInBytes == input.SizeInBytes ||
                    (this.SizeInBytes != null &&
                    this.SizeInBytes.Equals(input.SizeInBytes))
                ) && 
                (
                    this.StorageClass == input.StorageClass ||
                    (this.StorageClass != null &&
                    this.StorageClass.Equals(input.StorageClass))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.VolumeMode == input.VolumeMode ||
                    (this.VolumeMode != null &&
                    this.VolumeMode.Equals(input.VolumeMode))
                ) && 
                (
                    this.VolumeName == input.VolumeName ||
                    (this.VolumeName != null &&
                    this.VolumeName.Equals(input.VolumeName))
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
                if (this.AccessModes != null)
                    hashCode = hashCode * 59 + this.AccessModes.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.DeletionTimestamp != null)
                    hashCode = hashCode * 59 + this.DeletionTimestamp.GetHashCode();
                if (this.IsStatic != null)
                    hashCode = hashCode * 59 + this.IsStatic.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.ScWaitForFirstConsumer != null)
                    hashCode = hashCode * 59 + this.ScWaitForFirstConsumer.GetHashCode();
                if (this.SizeInBytes != null)
                    hashCode = hashCode * 59 + this.SizeInBytes.GetHashCode();
                if (this.StorageClass != null)
                    hashCode = hashCode * 59 + this.StorageClass.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VolumeMode != null)
                    hashCode = hashCode * 59 + this.VolumeMode.GetHashCode();
                if (this.VolumeName != null)
                    hashCode = hashCode * 59 + this.VolumeName.GetHashCode();
                return hashCode;
            }
        }

    }

}

