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
    /// DestroyMountVolumesTaskInfoProto
    /// </summary>
    [DataContract]
    public partial class DestroyMountVolumesTaskInfoProto :  IEquatable<DestroyMountVolumesTaskInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestroyMountVolumesTaskInfoProto" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="finished">This will be set to true if the task is complete on the slave..</param>
        /// <param name="hostName">This is the host name of the ESXi host. It is used if magneto_vmware_use_fqdn_for_guest_file_operations is set..</param>
        /// <param name="mountVolumesInfoProto">mountVolumesInfoProto.</param>
        /// <param name="slaveTaskStartTimeUsecs">This is the timestamp at which the slave task started..</param>
        /// <param name="targetEntity">targetEntity.</param>
        /// <param name="useExistingAgent">This will be set to true in two cases: 1. If persistent agent was used for IVM. 2. If user chose ephemeral agent during IVM but the host already had persistent agent installed..</param>
        public DestroyMountVolumesTaskInfoProto(ErrorProto error = default(ErrorProto), bool? finished = default(bool?), string hostName = default(string), MountVolumesInfoProto mountVolumesInfoProto = default(MountVolumesInfoProto), long? slaveTaskStartTimeUsecs = default(long?), EntityProto targetEntity = default(EntityProto), bool? useExistingAgent = default(bool?))
        {
            this.Finished = finished;
            this.HostName = hostName;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.UseExistingAgent = useExistingAgent;
            this.Error = error;
            this.Finished = finished;
            this.HostName = hostName;
            this.MountVolumesInfoProto = mountVolumesInfoProto;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.TargetEntity = targetEntity;
            this.UseExistingAgent = useExistingAgent;
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
        /// This is the host name of the ESXi host. It is used if magneto_vmware_use_fqdn_for_guest_file_operations is set.
        /// </summary>
        /// <value>This is the host name of the ESXi host. It is used if magneto_vmware_use_fqdn_for_guest_file_operations is set.</value>
        [DataMember(Name="hostName", EmitDefaultValue=true)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets MountVolumesInfoProto
        /// </summary>
        [DataMember(Name="mountVolumesInfoProto", EmitDefaultValue=false)]
        public MountVolumesInfoProto MountVolumesInfoProto { get; set; }

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
        /// This will be set to true in two cases: 1. If persistent agent was used for IVM. 2. If user chose ephemeral agent during IVM but the host already had persistent agent installed.
        /// </summary>
        /// <value>This will be set to true in two cases: 1. If persistent agent was used for IVM. 2. If user chose ephemeral agent during IVM but the host already had persistent agent installed.</value>
        [DataMember(Name="useExistingAgent", EmitDefaultValue=true)]
        public bool? UseExistingAgent { get; set; }

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
            return this.Equals(input as DestroyMountVolumesTaskInfoProto);
        }

        /// <summary>
        /// Returns true if DestroyMountVolumesTaskInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of DestroyMountVolumesTaskInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestroyMountVolumesTaskInfoProto input)
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
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.MountVolumesInfoProto == input.MountVolumesInfoProto ||
                    (this.MountVolumesInfoProto != null &&
                    this.MountVolumesInfoProto.Equals(input.MountVolumesInfoProto))
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
                ) && 
                (
                    this.UseExistingAgent == input.UseExistingAgent ||
                    (this.UseExistingAgent != null &&
                    this.UseExistingAgent.Equals(input.UseExistingAgent))
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
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.MountVolumesInfoProto != null)
                    hashCode = hashCode * 59 + this.MountVolumesInfoProto.GetHashCode();
                if (this.SlaveTaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SlaveTaskStartTimeUsecs.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.UseExistingAgent != null)
                    hashCode = hashCode * 59 + this.UseExistingAgent.GetHashCode();
                return hashCode;
            }
        }

    }

}

