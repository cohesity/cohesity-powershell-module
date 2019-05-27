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
    /// Specifies the complete information about a recover virtual disk task state.
    /// </summary>
    [DataContract]
    public partial class VirtualDiskRecoverTaskState :  IEquatable<VirtualDiskRecoverTaskState>
    {
        /// <summary>
        /// Specifies the current state of the restore virtual disks task. Specifies the current state of the restore virtual disks task. &#39;kDetachDisksDone&#39; indicates the detached state of disks. &#39;kSetupDisksDone&#39; indicates that disks setup is completed. &#39;kMigrateDisksStarted&#39; indicates that disks are being migrated. &#39;kMigrateDisksDone&#39; indicates that disk migration is completed. &#39;kUnMountDatastoreDone&#39; indicates that disk has unmounted the datastore.
        /// </summary>
        /// <value>Specifies the current state of the restore virtual disks task. Specifies the current state of the restore virtual disks task. &#39;kDetachDisksDone&#39; indicates the detached state of disks. &#39;kSetupDisksDone&#39; indicates that disks setup is completed. &#39;kMigrateDisksStarted&#39; indicates that disks are being migrated. &#39;kMigrateDisksDone&#39; indicates that disk migration is completed. &#39;kUnMountDatastoreDone&#39; indicates that disk has unmounted the datastore.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaskStateEnum
        {
            /// <summary>
            /// Enum KDetachDisksDone for value: kDetachDisksDone
            /// </summary>
            [EnumMember(Value = "kDetachDisksDone")]
            KDetachDisksDone = 1,

            /// <summary>
            /// Enum KSetupDisksDone for value: kSetupDisksDone
            /// </summary>
            [EnumMember(Value = "kSetupDisksDone")]
            KSetupDisksDone = 2,

            /// <summary>
            /// Enum KMigrateDisksStarted for value: kMigrateDisksStarted
            /// </summary>
            [EnumMember(Value = "kMigrateDisksStarted")]
            KMigrateDisksStarted = 3,

            /// <summary>
            /// Enum KMigrateDisksDone for value: kMigrateDisksDone
            /// </summary>
            [EnumMember(Value = "kMigrateDisksDone")]
            KMigrateDisksDone = 4,

            /// <summary>
            /// Enum KUnMountDatastoreDone for value: kUnMountDatastoreDone
            /// </summary>
            [EnumMember(Value = "kUnMountDatastoreDone")]
            KUnMountDatastoreDone = 5

        }

        /// <summary>
        /// Specifies the current state of the restore virtual disks task. Specifies the current state of the restore virtual disks task. &#39;kDetachDisksDone&#39; indicates the detached state of disks. &#39;kSetupDisksDone&#39; indicates that disks setup is completed. &#39;kMigrateDisksStarted&#39; indicates that disks are being migrated. &#39;kMigrateDisksDone&#39; indicates that disk migration is completed. &#39;kUnMountDatastoreDone&#39; indicates that disk has unmounted the datastore.
        /// </summary>
        /// <value>Specifies the current state of the restore virtual disks task. Specifies the current state of the restore virtual disks task. &#39;kDetachDisksDone&#39; indicates the detached state of disks. &#39;kSetupDisksDone&#39; indicates that disks setup is completed. &#39;kMigrateDisksStarted&#39; indicates that disks are being migrated. &#39;kMigrateDisksDone&#39; indicates that disk migration is completed. &#39;kUnMountDatastoreDone&#39; indicates that disk has unmounted the datastore.</value>
        [DataMember(Name="taskState", EmitDefaultValue=true)]
        public TaskStateEnum? TaskState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskRecoverTaskState" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="isInstantRecoveryFinished">Specifies if instant recovery of the virtual disk is complete..</param>
        /// <param name="taskState">Specifies the current state of the restore virtual disks task. Specifies the current state of the restore virtual disks task. &#39;kDetachDisksDone&#39; indicates the detached state of disks. &#39;kSetupDisksDone&#39; indicates that disks setup is completed. &#39;kMigrateDisksStarted&#39; indicates that disks are being migrated. &#39;kMigrateDisksDone&#39; indicates that disk migration is completed. &#39;kUnMountDatastoreDone&#39; indicates that disk has unmounted the datastore..</param>
        /// <param name="virtualDiskRestoreResponse">virtualDiskRestoreResponse.</param>
        public VirtualDiskRecoverTaskState(RequestError error = default(RequestError), bool? isInstantRecoveryFinished = default(bool?), TaskStateEnum? taskState = default(TaskStateEnum?), VirtualDiskRestoreResponse virtualDiskRestoreResponse = default(VirtualDiskRestoreResponse))
        {
            this.IsInstantRecoveryFinished = isInstantRecoveryFinished;
            this.TaskState = taskState;
            this.Error = error;
            this.IsInstantRecoveryFinished = isInstantRecoveryFinished;
            this.TaskState = taskState;
            this.VirtualDiskRestoreResponse = virtualDiskRestoreResponse;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public RequestError Error { get; set; }

        /// <summary>
        /// Specifies if instant recovery of the virtual disk is complete.
        /// </summary>
        /// <value>Specifies if instant recovery of the virtual disk is complete.</value>
        [DataMember(Name="isInstantRecoveryFinished", EmitDefaultValue=true)]
        public bool? IsInstantRecoveryFinished { get; set; }

        /// <summary>
        /// Gets or Sets VirtualDiskRestoreResponse
        /// </summary>
        [DataMember(Name="virtualDiskRestoreResponse", EmitDefaultValue=false)]
        public VirtualDiskRestoreResponse VirtualDiskRestoreResponse { get; set; }

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
            return this.Equals(input as VirtualDiskRecoverTaskState);
        }

        /// <summary>
        /// Returns true if VirtualDiskRecoverTaskState instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskRecoverTaskState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskRecoverTaskState input)
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
                    this.IsInstantRecoveryFinished == input.IsInstantRecoveryFinished ||
                    (this.IsInstantRecoveryFinished != null &&
                    this.IsInstantRecoveryFinished.Equals(input.IsInstantRecoveryFinished))
                ) && 
                (
                    this.TaskState == input.TaskState ||
                    this.TaskState.Equals(input.TaskState)
                ) && 
                (
                    this.VirtualDiskRestoreResponse == input.VirtualDiskRestoreResponse ||
                    (this.VirtualDiskRestoreResponse != null &&
                    this.VirtualDiskRestoreResponse.Equals(input.VirtualDiskRestoreResponse))
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
                if (this.IsInstantRecoveryFinished != null)
                    hashCode = hashCode * 59 + this.IsInstantRecoveryFinished.GetHashCode();
                hashCode = hashCode * 59 + this.TaskState.GetHashCode();
                if (this.VirtualDiskRestoreResponse != null)
                    hashCode = hashCode * 59 + this.VirtualDiskRestoreResponse.GetHashCode();
                return hashCode;
            }
        }

    }

}

