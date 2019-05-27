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
    /// Specifies the info regarding a full SQL snapshot.
    /// </summary>
    [DataContract]
    public partial class RestoreInfo :  IEquatable<RestoreInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreInfo" /> class.
        /// </summary>
        /// <param name="archivalTarget">archivalTarget.</param>
        /// <param name="attemptNumber">Specifies the attempt number..</param>
        /// <param name="cloudDeployTarget">cloudDeployTarget.</param>
        /// <param name="jobRunId">Specifies the id of the job run..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="parentSource">parentSource.</param>
        /// <param name="snapshotRelativeDirPath">Specifies the relative path of the snapshot directory..</param>
        /// <param name="source">source.</param>
        /// <param name="startTimeUsecs">Specifies the start time specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="viewName">Specifies the name of the view..</param>
        /// <param name="vmHadIndependentDisks">Specifies if the VM had independent disks..</param>
        public RestoreInfo(ArchivalExternalTarget archivalTarget = default(ArchivalExternalTarget), int? attemptNumber = default(int?), CloudDeployTargetDetails cloudDeployTarget = default(CloudDeployTargetDetails), long? jobRunId = default(long?), UniversalId jobUid = default(UniversalId), ProtectionSource parentSource = default(ProtectionSource), string snapshotRelativeDirPath = default(string), ProtectionSource source = default(ProtectionSource), long? startTimeUsecs = default(long?), string viewName = default(string), bool? vmHadIndependentDisks = default(bool?))
        {
            this.AttemptNumber = attemptNumber;
            this.JobRunId = jobRunId;
            this.SnapshotRelativeDirPath = snapshotRelativeDirPath;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewName = viewName;
            this.VmHadIndependentDisks = vmHadIndependentDisks;
            this.ArchivalTarget = archivalTarget;
            this.AttemptNumber = attemptNumber;
            this.CloudDeployTarget = cloudDeployTarget;
            this.JobRunId = jobRunId;
            this.JobUid = jobUid;
            this.ParentSource = parentSource;
            this.SnapshotRelativeDirPath = snapshotRelativeDirPath;
            this.Source = source;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewName = viewName;
            this.VmHadIndependentDisks = vmHadIndependentDisks;
        }
        
        /// <summary>
        /// Gets or Sets ArchivalTarget
        /// </summary>
        [DataMember(Name="archivalTarget", EmitDefaultValue=false)]
        public ArchivalExternalTarget ArchivalTarget { get; set; }

        /// <summary>
        /// Specifies the attempt number.
        /// </summary>
        /// <value>Specifies the attempt number.</value>
        [DataMember(Name="attemptNumber", EmitDefaultValue=true)]
        public int? AttemptNumber { get; set; }

        /// <summary>
        /// Gets or Sets CloudDeployTarget
        /// </summary>
        [DataMember(Name="cloudDeployTarget", EmitDefaultValue=false)]
        public CloudDeployTargetDetails CloudDeployTarget { get; set; }

        /// <summary>
        /// Specifies the id of the job run.
        /// </summary>
        /// <value>Specifies the id of the job run.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=true)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalId JobUid { get; set; }

        /// <summary>
        /// Gets or Sets ParentSource
        /// </summary>
        [DataMember(Name="parentSource", EmitDefaultValue=false)]
        public ProtectionSource ParentSource { get; set; }

        /// <summary>
        /// Specifies the relative path of the snapshot directory.
        /// </summary>
        /// <value>Specifies the relative path of the snapshot directory.</value>
        [DataMember(Name="snapshotRelativeDirPath", EmitDefaultValue=true)]
        public string SnapshotRelativeDirPath { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public ProtectionSource Source { get; set; }

        /// <summary>
        /// Specifies the start time specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the name of the view.
        /// </summary>
        /// <value>Specifies the name of the view.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// Specifies if the VM had independent disks.
        /// </summary>
        /// <value>Specifies if the VM had independent disks.</value>
        [DataMember(Name="vmHadIndependentDisks", EmitDefaultValue=true)]
        public bool? VmHadIndependentDisks { get; set; }

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
            return this.Equals(input as RestoreInfo);
        }

        /// <summary>
        /// Returns true if RestoreInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivalTarget == input.ArchivalTarget ||
                    (this.ArchivalTarget != null &&
                    this.ArchivalTarget.Equals(input.ArchivalTarget))
                ) && 
                (
                    this.AttemptNumber == input.AttemptNumber ||
                    (this.AttemptNumber != null &&
                    this.AttemptNumber.Equals(input.AttemptNumber))
                ) && 
                (
                    this.CloudDeployTarget == input.CloudDeployTarget ||
                    (this.CloudDeployTarget != null &&
                    this.CloudDeployTarget.Equals(input.CloudDeployTarget))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.ParentSource == input.ParentSource ||
                    (this.ParentSource != null &&
                    this.ParentSource.Equals(input.ParentSource))
                ) && 
                (
                    this.SnapshotRelativeDirPath == input.SnapshotRelativeDirPath ||
                    (this.SnapshotRelativeDirPath != null &&
                    this.SnapshotRelativeDirPath.Equals(input.SnapshotRelativeDirPath))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.VmHadIndependentDisks == input.VmHadIndependentDisks ||
                    (this.VmHadIndependentDisks != null &&
                    this.VmHadIndependentDisks.Equals(input.VmHadIndependentDisks))
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
                if (this.ArchivalTarget != null)
                    hashCode = hashCode * 59 + this.ArchivalTarget.GetHashCode();
                if (this.AttemptNumber != null)
                    hashCode = hashCode * 59 + this.AttemptNumber.GetHashCode();
                if (this.CloudDeployTarget != null)
                    hashCode = hashCode * 59 + this.CloudDeployTarget.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.ParentSource != null)
                    hashCode = hashCode * 59 + this.ParentSource.GetHashCode();
                if (this.SnapshotRelativeDirPath != null)
                    hashCode = hashCode * 59 + this.SnapshotRelativeDirPath.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.VmHadIndependentDisks != null)
                    hashCode = hashCode * 59 + this.VmHadIndependentDisks.GetHashCode();
                return hashCode;
            }
        }

    }

}

