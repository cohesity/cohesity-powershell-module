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
    /// MountVolumesParams
    /// </summary>
    [DataContract]
    public partial class MountVolumesParams :  IEquatable<MountVolumesParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumesParams" /> class.
        /// </summary>
        /// <param name="hypervParams">hypervParams.</param>
        /// <param name="readonlyMount">Allows the caller to force the Agent to perform a read-only mount. This is not usually required and we want to give customers the ability to mutate this mount for test/dev purposes..</param>
        /// <param name="targetEntity">targetEntity.</param>
        /// <param name="useExistingAgent">Whether this will use an existing agent on the target vm to do a restore operation..</param>
        /// <param name="vmwareParams">vmwareParams.</param>
        /// <param name="volumeNameVec">Optional names of volumes that need to be mounted. The names here correspond to the volume names obtained by Iris from Yoda as part of VMVolumeInfo call. NOTE: If this is not specified then all volumes that are part of the server will be mounted on the target entity..</param>
        public MountVolumesParams(MountVolumesHyperVParams hypervParams = default(MountVolumesHyperVParams), bool? readonlyMount = default(bool?), EntityProto targetEntity = default(EntityProto), bool? useExistingAgent = default(bool?), MountVolumesVMwareParams vmwareParams = default(MountVolumesVMwareParams), List<string> volumeNameVec = default(List<string>))
        {
            this.ReadonlyMount = readonlyMount;
            this.UseExistingAgent = useExistingAgent;
            this.VolumeNameVec = volumeNameVec;
            this.HypervParams = hypervParams;
            this.ReadonlyMount = readonlyMount;
            this.TargetEntity = targetEntity;
            this.UseExistingAgent = useExistingAgent;
            this.VmwareParams = vmwareParams;
            this.VolumeNameVec = volumeNameVec;
        }
        
        /// <summary>
        /// Gets or Sets HypervParams
        /// </summary>
        [DataMember(Name="hypervParams", EmitDefaultValue=false)]
        public MountVolumesHyperVParams HypervParams { get; set; }

        /// <summary>
        /// Allows the caller to force the Agent to perform a read-only mount. This is not usually required and we want to give customers the ability to mutate this mount for test/dev purposes.
        /// </summary>
        /// <value>Allows the caller to force the Agent to perform a read-only mount. This is not usually required and we want to give customers the ability to mutate this mount for test/dev purposes.</value>
        [DataMember(Name="readonlyMount", EmitDefaultValue=true)]
        public bool? ReadonlyMount { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

        /// <summary>
        /// Whether this will use an existing agent on the target vm to do a restore operation.
        /// </summary>
        /// <value>Whether this will use an existing agent on the target vm to do a restore operation.</value>
        [DataMember(Name="useExistingAgent", EmitDefaultValue=true)]
        public bool? UseExistingAgent { get; set; }

        /// <summary>
        /// Gets or Sets VmwareParams
        /// </summary>
        [DataMember(Name="vmwareParams", EmitDefaultValue=false)]
        public MountVolumesVMwareParams VmwareParams { get; set; }

        /// <summary>
        /// Optional names of volumes that need to be mounted. The names here correspond to the volume names obtained by Iris from Yoda as part of VMVolumeInfo call. NOTE: If this is not specified then all volumes that are part of the server will be mounted on the target entity.
        /// </summary>
        /// <value>Optional names of volumes that need to be mounted. The names here correspond to the volume names obtained by Iris from Yoda as part of VMVolumeInfo call. NOTE: If this is not specified then all volumes that are part of the server will be mounted on the target entity.</value>
        [DataMember(Name="volumeNameVec", EmitDefaultValue=true)]
        public List<string> VolumeNameVec { get; set; }

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
            return this.Equals(input as MountVolumesParams);
        }

        /// <summary>
        /// Returns true if MountVolumesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HypervParams == input.HypervParams ||
                    (this.HypervParams != null &&
                    this.HypervParams.Equals(input.HypervParams))
                ) && 
                (
                    this.ReadonlyMount == input.ReadonlyMount ||
                    (this.ReadonlyMount != null &&
                    this.ReadonlyMount.Equals(input.ReadonlyMount))
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
                ) && 
                (
                    this.UseExistingAgent == input.UseExistingAgent ||
                    (this.UseExistingAgent != null &&
                    this.UseExistingAgent.Equals(input.UseExistingAgent))
                ) && 
                (
                    this.VmwareParams == input.VmwareParams ||
                    (this.VmwareParams != null &&
                    this.VmwareParams.Equals(input.VmwareParams))
                ) && 
                (
                    this.VolumeNameVec == input.VolumeNameVec ||
                    this.VolumeNameVec != null &&
                    input.VolumeNameVec != null &&
                    this.VolumeNameVec.SequenceEqual(input.VolumeNameVec)
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
                if (this.HypervParams != null)
                    hashCode = hashCode * 59 + this.HypervParams.GetHashCode();
                if (this.ReadonlyMount != null)
                    hashCode = hashCode * 59 + this.ReadonlyMount.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.UseExistingAgent != null)
                    hashCode = hashCode * 59 + this.UseExistingAgent.GetHashCode();
                if (this.VmwareParams != null)
                    hashCode = hashCode * 59 + this.VmwareParams.GetHashCode();
                if (this.VolumeNameVec != null)
                    hashCode = hashCode * 59 + this.VolumeNameVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

