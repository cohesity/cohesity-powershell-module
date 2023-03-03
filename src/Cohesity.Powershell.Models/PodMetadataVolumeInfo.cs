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
    /// PodMetadataVolumeInfo
    /// </summary>
    [DataContract]
    public partial class PodMetadataVolumeInfo :  IEquatable<PodMetadataVolumeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodMetadataVolumeInfo" /> class.
        /// </summary>
        /// <param name="pvName">The underlying PV name if this volume is a PVC. This will be used to identify name of the directory containing PVC data at the path /var/lib/kubelet/pods..</param>
        /// <param name="storageClass">Name of the storage class. This is only populated for PVCs..</param>
        /// <param name="volume">volume.</param>
        /// <param name="volumePath">Path in S3 view where the volume data will be stored..</param>
        public PodMetadataVolumeInfo(string pvName = default(string), string storageClass = default(string), PodInfoPodSpecVolumeInfo volume = default(PodInfoPodSpecVolumeInfo), string volumePath = default(string))
        {
            this.PvName = pvName;
            this.StorageClass = storageClass;
            this.VolumePath = volumePath;
            this.PvName = pvName;
            this.StorageClass = storageClass;
            this.Volume = volume;
            this.VolumePath = volumePath;
        }
        
        /// <summary>
        /// The underlying PV name if this volume is a PVC. This will be used to identify name of the directory containing PVC data at the path /var/lib/kubelet/pods.
        /// </summary>
        /// <value>The underlying PV name if this volume is a PVC. This will be used to identify name of the directory containing PVC data at the path /var/lib/kubelet/pods.</value>
        [DataMember(Name="pvName", EmitDefaultValue=true)]
        public string PvName { get; set; }

        /// <summary>
        /// Name of the storage class. This is only populated for PVCs.
        /// </summary>
        /// <value>Name of the storage class. This is only populated for PVCs.</value>
        [DataMember(Name="storageClass", EmitDefaultValue=true)]
        public string StorageClass { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfo Volume { get; set; }

        /// <summary>
        /// Path in S3 view where the volume data will be stored.
        /// </summary>
        /// <value>Path in S3 view where the volume data will be stored.</value>
        [DataMember(Name="volumePath", EmitDefaultValue=true)]
        public string VolumePath { get; set; }

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
            return this.Equals(input as PodMetadataVolumeInfo);
        }

        /// <summary>
        /// Returns true if PodMetadataVolumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PodMetadataVolumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodMetadataVolumeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PvName == input.PvName ||
                    (this.PvName != null &&
                    this.PvName.Equals(input.PvName))
                ) && 
                (
                    this.StorageClass == input.StorageClass ||
                    (this.StorageClass != null &&
                    this.StorageClass.Equals(input.StorageClass))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.VolumePath == input.VolumePath ||
                    (this.VolumePath != null &&
                    this.VolumePath.Equals(input.VolumePath))
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
                if (this.PvName != null)
                    hashCode = hashCode * 59 + this.PvName.GetHashCode();
                if (this.StorageClass != null)
                    hashCode = hashCode * 59 + this.StorageClass.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.VolumePath != null)
                    hashCode = hashCode * 59 + this.VolumePath.GetHashCode();
                return hashCode;
            }
        }

    }

}

