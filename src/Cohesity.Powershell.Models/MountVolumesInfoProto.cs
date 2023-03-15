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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined.  MountVolumesInfoProto extension                     Location &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; vmware::MountVolumesInfoProto::vmware_mount_volumes_info vmware/vmware.proto &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class MountVolumesInfoProto :  IEquatable<MountVolumesInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumesInfoProto" /> class.
        /// </summary>
        /// <param name="cleanupError">cleanupError.</param>
        /// <param name="error">error.</param>
        /// <param name="finished">This will be set to true if the task is complete on the slave..</param>
        /// <param name="mountVolumeResultVec">Contains the result information of the mounted volumes..</param>
        /// <param name="restoreDisksTaskInfoProto">restoreDisksTaskInfoProto.</param>
        /// <param name="slaveTaskStartTimeUsecs">This is the timestamp at which the slave task started..</param>
        /// <param name="type">The type of environment this mount volumes info pertains to..</param>
        /// <param name="vmOnlineDisksError">vmOnlineDisksError.</param>
        public MountVolumesInfoProto(ErrorProto cleanupError = default(ErrorProto), ErrorProto error = default(ErrorProto), bool? finished = default(bool?), List<MountVolumeResult> mountVolumeResultVec = default(List<MountVolumeResult>), SetupRestoreDiskTaskInfoProto restoreDisksTaskInfoProto = default(SetupRestoreDiskTaskInfoProto), long? slaveTaskStartTimeUsecs = default(long?), int? type = default(int?), ErrorProto vmOnlineDisksError = default(ErrorProto))
        {
            this.Finished = finished;
            this.MountVolumeResultVec = mountVolumeResultVec;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.Type = type;
            this.CleanupError = cleanupError;
            this.Error = error;
            this.Finished = finished;
            this.MountVolumeResultVec = mountVolumeResultVec;
            this.RestoreDisksTaskInfoProto = restoreDisksTaskInfoProto;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.Type = type;
            this.VmOnlineDisksError = vmOnlineDisksError;
        }
        
        /// <summary>
        /// Gets or Sets CleanupError
        /// </summary>
        [DataMember(Name="cleanupError", EmitDefaultValue=false)]
        public ErrorProto CleanupError { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// This will be set to true if the task is complete on the slave.
        /// </summary>
        /// <value>This will be set to true if the task is complete on the slave.</value>
        [DataMember(Name="finished", EmitDefaultValue=true)]
        public bool? Finished { get; set; }

        /// <summary>
        /// Contains the result information of the mounted volumes.
        /// </summary>
        /// <value>Contains the result information of the mounted volumes.</value>
        [DataMember(Name="mountVolumeResultVec", EmitDefaultValue=true)]
        public List<MountVolumeResult> MountVolumeResultVec { get; set; }

        /// <summary>
        /// Gets or Sets RestoreDisksTaskInfoProto
        /// </summary>
        [DataMember(Name="restoreDisksTaskInfoProto", EmitDefaultValue=false)]
        public SetupRestoreDiskTaskInfoProto RestoreDisksTaskInfoProto { get; set; }

        /// <summary>
        /// This is the timestamp at which the slave task started.
        /// </summary>
        /// <value>This is the timestamp at which the slave task started.</value>
        [DataMember(Name="slaveTaskStartTimeUsecs", EmitDefaultValue=true)]
        public long? SlaveTaskStartTimeUsecs { get; set; }

        /// <summary>
        /// The type of environment this mount volumes info pertains to.
        /// </summary>
        /// <value>The type of environment this mount volumes info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets VmOnlineDisksError
        /// </summary>
        [DataMember(Name="vmOnlineDisksError", EmitDefaultValue=false)]
        public ErrorProto VmOnlineDisksError { get; set; }

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
            return this.Equals(input as MountVolumesInfoProto);
        }

        /// <summary>
        /// Returns true if MountVolumesInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumesInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumesInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CleanupError == input.CleanupError ||
                    (this.CleanupError != null &&
                    this.CleanupError.Equals(input.CleanupError))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Finished == input.Finished ||
                    (this.Finished != null &&
                    this.Finished.Equals(input.Finished))
                ) && 
                (
                    this.MountVolumeResultVec == input.MountVolumeResultVec ||
                    this.MountVolumeResultVec != null &&
                    input.MountVolumeResultVec != null &&
                    this.MountVolumeResultVec.SequenceEqual(input.MountVolumeResultVec)
                ) && 
                (
                    this.RestoreDisksTaskInfoProto == input.RestoreDisksTaskInfoProto ||
                    (this.RestoreDisksTaskInfoProto != null &&
                    this.RestoreDisksTaskInfoProto.Equals(input.RestoreDisksTaskInfoProto))
                ) && 
                (
                    this.SlaveTaskStartTimeUsecs == input.SlaveTaskStartTimeUsecs ||
                    (this.SlaveTaskStartTimeUsecs != null &&
                    this.SlaveTaskStartTimeUsecs.Equals(input.SlaveTaskStartTimeUsecs))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VmOnlineDisksError == input.VmOnlineDisksError ||
                    (this.VmOnlineDisksError != null &&
                    this.VmOnlineDisksError.Equals(input.VmOnlineDisksError))
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
                if (this.CleanupError != null)
                    hashCode = hashCode * 59 + this.CleanupError.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.MountVolumeResultVec != null)
                    hashCode = hashCode * 59 + this.MountVolumeResultVec.GetHashCode();
                if (this.RestoreDisksTaskInfoProto != null)
                    hashCode = hashCode * 59 + this.RestoreDisksTaskInfoProto.GetHashCode();
                if (this.SlaveTaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SlaveTaskStartTimeUsecs.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VmOnlineDisksError != null)
                    hashCode = hashCode * 59 + this.VmOnlineDisksError.GetHashCode();
                return hashCode;
            }
        }

    }

}

