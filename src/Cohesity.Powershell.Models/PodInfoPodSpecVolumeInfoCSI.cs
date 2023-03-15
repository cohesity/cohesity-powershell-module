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
    /// PodInfoPodSpecVolumeInfoCSI
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoCSI :  IEquatable<PodInfoPodSpecVolumeInfoCSI>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoCSI" /> class.
        /// </summary>
        /// <param name="controllerExpandSecretRef">controllerExpandSecretRef.</param>
        /// <param name="controllerPublishSecretRef">controllerPublishSecretRef.</param>
        /// <param name="driver">driver.</param>
        /// <param name="fsType">fsType.</param>
        /// <param name="nodePublishSecretRef">nodePublishSecretRef.</param>
        /// <param name="nodeStageSecretRef">nodeStageSecretRef.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="volumeAttributes">volumeAttributes.</param>
        /// <param name="volumeHandle">volumeHandle.</param>
        public PodInfoPodSpecVolumeInfoCSI(ObjectReference controllerExpandSecretRef = default(ObjectReference), ObjectReference controllerPublishSecretRef = default(ObjectReference), string driver = default(string), string fsType = default(string), ObjectReference nodePublishSecretRef = default(ObjectReference), ObjectReference nodeStageSecretRef = default(ObjectReference), bool? readOnly = default(bool?), List<PodInfoPodSpecVolumeInfoCSIVolumeAttributesEntry> volumeAttributes = default(List<PodInfoPodSpecVolumeInfoCSIVolumeAttributesEntry>), string volumeHandle = default(string))
        {
            this.Driver = driver;
            this.FsType = fsType;
            this.ReadOnly = readOnly;
            this.VolumeAttributes = volumeAttributes;
            this.VolumeHandle = volumeHandle;
            this.ControllerExpandSecretRef = controllerExpandSecretRef;
            this.ControllerPublishSecretRef = controllerPublishSecretRef;
            this.Driver = driver;
            this.FsType = fsType;
            this.NodePublishSecretRef = nodePublishSecretRef;
            this.NodeStageSecretRef = nodeStageSecretRef;
            this.ReadOnly = readOnly;
            this.VolumeAttributes = volumeAttributes;
            this.VolumeHandle = volumeHandle;
        }
        
        /// <summary>
        /// Gets or Sets ControllerExpandSecretRef
        /// </summary>
        [DataMember(Name="controllerExpandSecretRef", EmitDefaultValue=false)]
        public ObjectReference ControllerExpandSecretRef { get; set; }

        /// <summary>
        /// Gets or Sets ControllerPublishSecretRef
        /// </summary>
        [DataMember(Name="controllerPublishSecretRef", EmitDefaultValue=false)]
        public ObjectReference ControllerPublishSecretRef { get; set; }

        /// <summary>
        /// Gets or Sets Driver
        /// </summary>
        [DataMember(Name="driver", EmitDefaultValue=true)]
        public string Driver { get; set; }

        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets NodePublishSecretRef
        /// </summary>
        [DataMember(Name="nodePublishSecretRef", EmitDefaultValue=false)]
        public ObjectReference NodePublishSecretRef { get; set; }

        /// <summary>
        /// Gets or Sets NodeStageSecretRef
        /// </summary>
        [DataMember(Name="nodeStageSecretRef", EmitDefaultValue=false)]
        public ObjectReference NodeStageSecretRef { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets VolumeAttributes
        /// </summary>
        [DataMember(Name="volumeAttributes", EmitDefaultValue=true)]
        public List<PodInfoPodSpecVolumeInfoCSIVolumeAttributesEntry> VolumeAttributes { get; set; }

        /// <summary>
        /// Gets or Sets VolumeHandle
        /// </summary>
        [DataMember(Name="volumeHandle", EmitDefaultValue=true)]
        public string VolumeHandle { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoCSI);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoCSI instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoCSI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoCSI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ControllerExpandSecretRef == input.ControllerExpandSecretRef ||
                    (this.ControllerExpandSecretRef != null &&
                    this.ControllerExpandSecretRef.Equals(input.ControllerExpandSecretRef))
                ) && 
                (
                    this.ControllerPublishSecretRef == input.ControllerPublishSecretRef ||
                    (this.ControllerPublishSecretRef != null &&
                    this.ControllerPublishSecretRef.Equals(input.ControllerPublishSecretRef))
                ) && 
                (
                    this.Driver == input.Driver ||
                    (this.Driver != null &&
                    this.Driver.Equals(input.Driver))
                ) && 
                (
                    this.FsType == input.FsType ||
                    (this.FsType != null &&
                    this.FsType.Equals(input.FsType))
                ) && 
                (
                    this.NodePublishSecretRef == input.NodePublishSecretRef ||
                    (this.NodePublishSecretRef != null &&
                    this.NodePublishSecretRef.Equals(input.NodePublishSecretRef))
                ) && 
                (
                    this.NodeStageSecretRef == input.NodeStageSecretRef ||
                    (this.NodeStageSecretRef != null &&
                    this.NodeStageSecretRef.Equals(input.NodeStageSecretRef))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.VolumeAttributes == input.VolumeAttributes ||
                    this.VolumeAttributes != null &&
                    input.VolumeAttributes != null &&
                    this.VolumeAttributes.SequenceEqual(input.VolumeAttributes)
                ) && 
                (
                    this.VolumeHandle == input.VolumeHandle ||
                    (this.VolumeHandle != null &&
                    this.VolumeHandle.Equals(input.VolumeHandle))
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
                if (this.ControllerExpandSecretRef != null)
                    hashCode = hashCode * 59 + this.ControllerExpandSecretRef.GetHashCode();
                if (this.ControllerPublishSecretRef != null)
                    hashCode = hashCode * 59 + this.ControllerPublishSecretRef.GetHashCode();
                if (this.Driver != null)
                    hashCode = hashCode * 59 + this.Driver.GetHashCode();
                if (this.FsType != null)
                    hashCode = hashCode * 59 + this.FsType.GetHashCode();
                if (this.NodePublishSecretRef != null)
                    hashCode = hashCode * 59 + this.NodePublishSecretRef.GetHashCode();
                if (this.NodeStageSecretRef != null)
                    hashCode = hashCode * 59 + this.NodeStageSecretRef.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.VolumeAttributes != null)
                    hashCode = hashCode * 59 + this.VolumeAttributes.GetHashCode();
                if (this.VolumeHandle != null)
                    hashCode = hashCode * 59 + this.VolumeHandle.GetHashCode();
                return hashCode;
            }
        }

    }

}

