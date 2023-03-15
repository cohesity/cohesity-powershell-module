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
    /// PVCInfoPVCSpec
    /// </summary>
    [DataContract]
    public partial class PVCInfoPVCSpec :  IEquatable<PVCInfoPVCSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PVCInfoPVCSpec" /> class.
        /// </summary>
        /// <param name="accessModes">AccessModes contains the desired access modes the volume should have..</param>
        /// <param name="dataSource">dataSource.</param>
        /// <param name="resources">resources.</param>
        /// <param name="selector">selector.</param>
        /// <param name="storageClassName">Name of the StorageClass required by the claim..</param>
        /// <param name="volumeMode">volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec..</param>
        /// <param name="volumeName">Name of the volume that is using this PVC..</param>
        public PVCInfoPVCSpec(List<string> accessModes = default(List<string>), ObjectReference dataSource = default(ObjectReference), PVCInfoPVCSpecResources resources = default(PVCInfoPVCSpecResources), LabelSelector selector = default(LabelSelector), string storageClassName = default(string), string volumeMode = default(string), string volumeName = default(string))
        {
            this.AccessModes = accessModes;
            this.StorageClassName = storageClassName;
            this.VolumeMode = volumeMode;
            this.VolumeName = volumeName;
            this.AccessModes = accessModes;
            this.DataSource = dataSource;
            this.Resources = resources;
            this.Selector = selector;
            this.StorageClassName = storageClassName;
            this.VolumeMode = volumeMode;
            this.VolumeName = volumeName;
        }
        
        /// <summary>
        /// AccessModes contains the desired access modes the volume should have.
        /// </summary>
        /// <value>AccessModes contains the desired access modes the volume should have.</value>
        [DataMember(Name="accessModes", EmitDefaultValue=true)]
        public List<string> AccessModes { get; set; }

        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public ObjectReference DataSource { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public PVCInfoPVCSpecResources Resources { get; set; }

        /// <summary>
        /// Gets or Sets Selector
        /// </summary>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public LabelSelector Selector { get; set; }

        /// <summary>
        /// Name of the StorageClass required by the claim.
        /// </summary>
        /// <value>Name of the StorageClass required by the claim.</value>
        [DataMember(Name="storageClassName", EmitDefaultValue=true)]
        public string StorageClassName { get; set; }

        /// <summary>
        /// volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.
        /// </summary>
        /// <value>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.</value>
        [DataMember(Name="volumeMode", EmitDefaultValue=true)]
        public string VolumeMode { get; set; }

        /// <summary>
        /// Name of the volume that is using this PVC.
        /// </summary>
        /// <value>Name of the volume that is using this PVC.</value>
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
            return this.Equals(input as PVCInfoPVCSpec);
        }

        /// <summary>
        /// Returns true if PVCInfoPVCSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of PVCInfoPVCSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PVCInfoPVCSpec input)
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
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.Resources == input.Resources ||
                    (this.Resources != null &&
                    this.Resources.Equals(input.Resources))
                ) && 
                (
                    this.Selector == input.Selector ||
                    (this.Selector != null &&
                    this.Selector.Equals(input.Selector))
                ) && 
                (
                    this.StorageClassName == input.StorageClassName ||
                    (this.StorageClassName != null &&
                    this.StorageClassName.Equals(input.StorageClassName))
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
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Selector != null)
                    hashCode = hashCode * 59 + this.Selector.GetHashCode();
                if (this.StorageClassName != null)
                    hashCode = hashCode * 59 + this.StorageClassName.GetHashCode();
                if (this.VolumeMode != null)
                    hashCode = hashCode * 59 + this.VolumeMode.GetHashCode();
                if (this.VolumeName != null)
                    hashCode = hashCode * 59 + this.VolumeName.GetHashCode();
                return hashCode;
            }
        }

    }

}

