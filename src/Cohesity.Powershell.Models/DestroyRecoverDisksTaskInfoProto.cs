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
    /// DestroyRecoverDisksTaskInfoProto
    /// </summary>
    [DataContract]
    public partial class DestroyRecoverDisksTaskInfoProto :  IEquatable<DestroyRecoverDisksTaskInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestroyRecoverDisksTaskInfoProto" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="finished">This will be set to true if the task is complete on the slave..</param>
        /// <param name="recoverVirtualDiskInfo">recoverVirtualDiskInfo.</param>
        /// <param name="slaveTaskStartTimeUsecs">This is the timestamp at which the slave task started..</param>
        /// <param name="targetEntity">targetEntity.</param>
        public DestroyRecoverDisksTaskInfoProto(ErrorProto error = default(ErrorProto), bool? finished = default(bool?), RecoverVirtualDiskInfoProto recoverVirtualDiskInfo = default(RecoverVirtualDiskInfoProto), long? slaveTaskStartTimeUsecs = default(long?), EntityProto targetEntity = default(EntityProto))
        {
            this.Finished = finished;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.Error = error;
            this.Finished = finished;
            this.RecoverVirtualDiskInfo = recoverVirtualDiskInfo;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.TargetEntity = targetEntity;
        }
        
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
        /// Gets or Sets RecoverVirtualDiskInfo
        /// </summary>
        [DataMember(Name="recoverVirtualDiskInfo", EmitDefaultValue=false)]
        public RecoverVirtualDiskInfoProto RecoverVirtualDiskInfo { get; set; }

        /// <summary>
        /// This is the timestamp at which the slave task started.
        /// </summary>
        /// <value>This is the timestamp at which the slave task started.</value>
        [DataMember(Name="slaveTaskStartTimeUsecs", EmitDefaultValue=true)]
        public long? SlaveTaskStartTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

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
            return this.Equals(input as DestroyRecoverDisksTaskInfoProto);
        }

        /// <summary>
        /// Returns true if DestroyRecoverDisksTaskInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of DestroyRecoverDisksTaskInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestroyRecoverDisksTaskInfoProto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.RecoverVirtualDiskInfo == input.RecoverVirtualDiskInfo ||
                    (this.RecoverVirtualDiskInfo != null &&
                    this.RecoverVirtualDiskInfo.Equals(input.RecoverVirtualDiskInfo))
                ) && 
                (
                    this.SlaveTaskStartTimeUsecs == input.SlaveTaskStartTimeUsecs ||
                    (this.SlaveTaskStartTimeUsecs != null &&
                    this.SlaveTaskStartTimeUsecs.Equals(input.SlaveTaskStartTimeUsecs))
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.RecoverVirtualDiskInfo != null)
                    hashCode = hashCode * 59 + this.RecoverVirtualDiskInfo.GetHashCode();
                if (this.SlaveTaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SlaveTaskStartTimeUsecs.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

