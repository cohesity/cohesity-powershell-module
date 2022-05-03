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
    /// This message defines the pod metadata which will be stored in SnapshotInfoProto for Kubernetes backup and restore with Datamover.
    /// </summary>
    [DataContract]
    public partial class PodMetadata :  IEquatable<PodMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodMetadata" /> class.
        /// </summary>
        /// <param name="name">Name of the pod..</param>
        /// <param name="nodeName">Name of the node where pod is running..</param>
        /// <param name="uid">Uid of the pod..</param>
        /// <param name="volumeVec">Metadata of the volumes that are attached to this pod..</param>
        public PodMetadata(string name = default(string), string nodeName = default(string), string uid = default(string), List<PodMetadataVolumeInfo> volumeVec = default(List<PodMetadataVolumeInfo>))
        {
            this.Name = name;
            this.NodeName = nodeName;
            this.Uid = uid;
            this.VolumeVec = volumeVec;
        }
        
        /// <summary>
        /// Name of the pod.
        /// </summary>
        /// <value>Name of the pod.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the node where pod is running.
        /// </summary>
        /// <value>Name of the node where pod is running.</value>
        [DataMember(Name="nodeName", EmitDefaultValue=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// Uid of the pod.
        /// </summary>
        /// <value>Uid of the pod.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }

        /// <summary>
        /// Metadata of the volumes that are attached to this pod.
        /// </summary>
        /// <value>Metadata of the volumes that are attached to this pod.</value>
        [DataMember(Name="volumeVec", EmitDefaultValue=false)]
        public List<PodMetadataVolumeInfo> VolumeVec { get; set; }

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
            return this.Equals(input as PodMetadata);
        }

        /// <summary>
        /// Returns true if PodMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of PodMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.VolumeVec == input.VolumeVec ||
                    this.VolumeVec != null &&
                    this.VolumeVec.Equals(input.VolumeVec)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.VolumeVec != null)
                    hashCode = hashCode * 59 + this.VolumeVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

