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
    /// Specifies the status of one Job Run. A Job Run can have one Backup Run and zero or more Copy Runs.
    /// </summary>
    [DataContract]
    public partial class ProtectionRunInstance :  IEquatable<ProtectionRunInstance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionRunInstance" /> class.
        /// </summary>
        /// <param name="backupRun">backupRun.</param>
        /// <param name="copyRun">Array of Copy Run Tasks.  Specifies details about the Copy tasks of this Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster..</param>
        /// <param name="jobId">Specifies the id of the Protection Job that was run..</param>
        /// <param name="jobName">Specifies the name of the Protection Job name that was run..</param>
        /// <param name="jobUid">Specifies the globally unique id of the Protection Job that was run..</param>
        /// <param name="protectionShellInfo">protectionShellInfo.</param>
        /// <param name="viewBoxId">Specifies the Storage Domain (View Box) to store the backed up data. Specify the id of the Storage Domain (View Box)..</param>
        public ProtectionRunInstance(BackupRun backupRun = default(BackupRun), List<CopyRun> copyRun = default(List<CopyRun>), long? jobId = default(long?), string jobName = default(string), UniversalId jobUid = default(UniversalId), ProtectionShellInfo protectionShellInfo = default(ProtectionShellInfo), long? viewBoxId = default(long?))
        {
            this.CopyRun = copyRun;
            this.JobId = jobId;
            this.JobName = jobName;
            this.JobUid = jobUid;
            this.ViewBoxId = viewBoxId;
            this.BackupRun = backupRun;
            this.CopyRun = copyRun;
            this.JobId = jobId;
            this.JobName = jobName;
            this.JobUid = jobUid;
            this.ProtectionShellInfo = protectionShellInfo;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// Gets or Sets BackupRun
        /// </summary>
        [DataMember(Name="backupRun", EmitDefaultValue=false)]
        public BackupRun BackupRun { get; set; }

        /// <summary>
        /// Array of Copy Run Tasks.  Specifies details about the Copy tasks of this Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster.
        /// </summary>
        /// <value>Array of Copy Run Tasks.  Specifies details about the Copy tasks of this Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster.</value>
        [DataMember(Name="copyRun", EmitDefaultValue=true)]
        public List<CopyRun> CopyRun { get; set; }

        /// <summary>
        /// Specifies the id of the Protection Job that was run.
        /// </summary>
        /// <value>Specifies the id of the Protection Job that was run.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Job name that was run.
        /// </summary>
        /// <value>Specifies the name of the Protection Job name that was run.</value>
        [DataMember(Name="jobName", EmitDefaultValue=true)]
        public string JobName { get; set; }

        /// <summary>
        /// Specifies the globally unique id of the Protection Job that was run.
        /// </summary>
        /// <value>Specifies the globally unique id of the Protection Job that was run.</value>
        [DataMember(Name="jobUid", EmitDefaultValue=true)]
        public UniversalId JobUid { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionShellInfo
        /// </summary>
        [DataMember(Name="protectionShellInfo", EmitDefaultValue=false)]
        public ProtectionShellInfo ProtectionShellInfo { get; set; }

        /// <summary>
        /// Specifies the Storage Domain (View Box) to store the backed up data. Specify the id of the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the Storage Domain (View Box) to store the backed up data. Specify the id of the Storage Domain (View Box).</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

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
            return this.Equals(input as ProtectionRunInstance);
        }

        /// <summary>
        /// Returns true if ProtectionRunInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionRunInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionRunInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupRun == input.BackupRun ||
                    (this.BackupRun != null &&
                    this.BackupRun.Equals(input.BackupRun))
                ) && 
                (
                    this.CopyRun == input.CopyRun ||
                    this.CopyRun != null &&
                    input.CopyRun != null &&
                    this.CopyRun.SequenceEqual(input.CopyRun)
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.ProtectionShellInfo == input.ProtectionShellInfo ||
                    (this.ProtectionShellInfo != null &&
                    this.ProtectionShellInfo.Equals(input.ProtectionShellInfo))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
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
                if (this.BackupRun != null)
                    hashCode = hashCode * 59 + this.BackupRun.GetHashCode();
                if (this.CopyRun != null)
                    hashCode = hashCode * 59 + this.CopyRun.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.ProtectionShellInfo != null)
                    hashCode = hashCode * 59 + this.ProtectionShellInfo.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

    }

}

