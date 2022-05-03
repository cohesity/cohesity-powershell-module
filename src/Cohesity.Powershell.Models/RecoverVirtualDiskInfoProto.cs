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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined.  RecoverVirtualDiskInfoProto extension                     Location &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class RecoverVirtualDiskInfoProto :  IEquatable<RecoverVirtualDiskInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverVirtualDiskInfoProto" /> class.
        /// </summary>
        /// <param name="cleanupError">cleanupError.</param>
        /// <param name="dataMigrationError">dataMigrationError.</param>
        /// <param name="error">error.</param>
        /// <param name="finished">This will be set to true if the task is complete on the slave..</param>
        /// <param name="instantRecoveryFinished">This will be set to true once the instant recovery of the virtual disk is complete..</param>
        /// <param name="migrateTaskMoref">migrateTaskMoref.</param>
        /// <param name="restoreDisksTaskInfoProto">restoreDisksTaskInfoProto.</param>
        /// <param name="slaveTaskStartTimeUsecs">This is the timestamp at which the slave task started..</param>
        /// <param name="taskState">The state of the task..</param>
        /// <param name="type">The type of environment this recover virtual disk info pertains to..</param>
        public RecoverVirtualDiskInfoProto(ErrorProto cleanupError = default(ErrorProto), ErrorProto dataMigrationError = default(ErrorProto), ErrorProto error = default(ErrorProto), bool? finished = default(bool?), bool? instantRecoveryFinished = default(bool?), MORef migrateTaskMoref = default(MORef), SetupRestoreDiskTaskInfoProto restoreDisksTaskInfoProto = default(SetupRestoreDiskTaskInfoProto), long? slaveTaskStartTimeUsecs = default(long?), int? taskState = default(int?), int? type = default(int?))
        {
            this.CleanupError = cleanupError;
            this.DataMigrationError = dataMigrationError;
            this.Error = error;
            this.Finished = finished;
            this.InstantRecoveryFinished = instantRecoveryFinished;
            this.MigrateTaskMoref = migrateTaskMoref;
            this.RestoreDisksTaskInfoProto = restoreDisksTaskInfoProto;
            this.SlaveTaskStartTimeUsecs = slaveTaskStartTimeUsecs;
            this.TaskState = taskState;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets CleanupError
        /// </summary>
        [DataMember(Name="cleanupError", EmitDefaultValue=false)]
        public ErrorProto CleanupError { get; set; }

        /// <summary>
        /// Gets or Sets DataMigrationError
        /// </summary>
        [DataMember(Name="dataMigrationError", EmitDefaultValue=false)]
        public ErrorProto DataMigrationError { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// This will be set to true if the task is complete on the slave.
        /// </summary>
        /// <value>This will be set to true if the task is complete on the slave.</value>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public bool? Finished { get; set; }

        /// <summary>
        /// This will be set to true once the instant recovery of the virtual disk is complete.
        /// </summary>
        /// <value>This will be set to true once the instant recovery of the virtual disk is complete.</value>
        [DataMember(Name="instantRecoveryFinished", EmitDefaultValue=false)]
        public bool? InstantRecoveryFinished { get; set; }

        /// <summary>
        /// Gets or Sets MigrateTaskMoref
        /// </summary>
        [DataMember(Name="migrateTaskMoref", EmitDefaultValue=false)]
        public MORef MigrateTaskMoref { get; set; }

        /// <summary>
        /// Gets or Sets RestoreDisksTaskInfoProto
        /// </summary>
        [DataMember(Name="restoreDisksTaskInfoProto", EmitDefaultValue=false)]
        public SetupRestoreDiskTaskInfoProto RestoreDisksTaskInfoProto { get; set; }

        /// <summary>
        /// This is the timestamp at which the slave task started.
        /// </summary>
        /// <value>This is the timestamp at which the slave task started.</value>
        [DataMember(Name="slaveTaskStartTimeUsecs", EmitDefaultValue=false)]
        public long? SlaveTaskStartTimeUsecs { get; set; }

        /// <summary>
        /// The state of the task.
        /// </summary>
        /// <value>The state of the task.</value>
        [DataMember(Name="taskState", EmitDefaultValue=false)]
        public int? TaskState { get; set; }

        /// <summary>
        /// The type of environment this recover virtual disk info pertains to.
        /// </summary>
        /// <value>The type of environment this recover virtual disk info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

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
            return this.Equals(input as RecoverVirtualDiskInfoProto);
        }

        /// <summary>
        /// Returns true if RecoverVirtualDiskInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverVirtualDiskInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverVirtualDiskInfoProto input)
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
                    this.DataMigrationError == input.DataMigrationError ||
                    (this.DataMigrationError != null &&
                    this.DataMigrationError.Equals(input.DataMigrationError))
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
                    this.InstantRecoveryFinished == input.InstantRecoveryFinished ||
                    (this.InstantRecoveryFinished != null &&
                    this.InstantRecoveryFinished.Equals(input.InstantRecoveryFinished))
                ) && 
                (
                    this.MigrateTaskMoref == input.MigrateTaskMoref ||
                    (this.MigrateTaskMoref != null &&
                    this.MigrateTaskMoref.Equals(input.MigrateTaskMoref))
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
                    this.TaskState == input.TaskState ||
                    (this.TaskState != null &&
                    this.TaskState.Equals(input.TaskState))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DataMigrationError != null)
                    hashCode = hashCode * 59 + this.DataMigrationError.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.InstantRecoveryFinished != null)
                    hashCode = hashCode * 59 + this.InstantRecoveryFinished.GetHashCode();
                if (this.MigrateTaskMoref != null)
                    hashCode = hashCode * 59 + this.MigrateTaskMoref.GetHashCode();
                if (this.RestoreDisksTaskInfoProto != null)
                    hashCode = hashCode * 59 + this.RestoreDisksTaskInfoProto.GetHashCode();
                if (this.SlaveTaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SlaveTaskStartTimeUsecs.GetHashCode();
                if (this.TaskState != null)
                    hashCode = hashCode * 59 + this.TaskState.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

