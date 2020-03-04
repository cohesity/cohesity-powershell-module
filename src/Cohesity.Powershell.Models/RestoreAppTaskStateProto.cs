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
    /// RestoreAppTaskStateProto
    /// </summary>
    [DataContract]
    public partial class RestoreAppTaskStateProto :  IEquatable<RestoreAppTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAppTaskStateProto" /> class.
        /// </summary>
        /// <param name="appRestoreProgressMonitorSubtaskPath">The Pulse task path to the application restore task sub tree. If the application restore has to wait on other tasks (for example, a SQL db restore may wait for a tail log backup or a VM restore), then this would represent a sub-tree of &#39;progress_monitor_task_path&#39; in PerformRestoreTaskStateProto..</param>
        /// <param name="childRestoreAppParamsVec">This has list of the restore app params for all the child restore tasks. This is populated iff the &#39;is_parent_task&#39; is set to true..</param>
        /// <param name="lastFinishedLogBackupStartTimeUsecs">The start time of the last finished log backup run. For SQL application, this is set iff we need to take a tail log backup..</param>
        /// <param name="restoreAppParams">restoreAppParams.</param>
        public RestoreAppTaskStateProto(string appRestoreProgressMonitorSubtaskPath = default(string), List<RestoreAppParams> childRestoreAppParamsVec = default(List<RestoreAppParams>), long? lastFinishedLogBackupStartTimeUsecs = default(long?), RestoreAppParams restoreAppParams = default(RestoreAppParams))
        {
            this.AppRestoreProgressMonitorSubtaskPath = appRestoreProgressMonitorSubtaskPath;
            this.ChildRestoreAppParamsVec = childRestoreAppParamsVec;
            this.LastFinishedLogBackupStartTimeUsecs = lastFinishedLogBackupStartTimeUsecs;
            this.AppRestoreProgressMonitorSubtaskPath = appRestoreProgressMonitorSubtaskPath;
            this.ChildRestoreAppParamsVec = childRestoreAppParamsVec;
            this.LastFinishedLogBackupStartTimeUsecs = lastFinishedLogBackupStartTimeUsecs;
            this.RestoreAppParams = restoreAppParams;
        }
        
        /// <summary>
        /// The Pulse task path to the application restore task sub tree. If the application restore has to wait on other tasks (for example, a SQL db restore may wait for a tail log backup or a VM restore), then this would represent a sub-tree of &#39;progress_monitor_task_path&#39; in PerformRestoreTaskStateProto.
        /// </summary>
        /// <value>The Pulse task path to the application restore task sub tree. If the application restore has to wait on other tasks (for example, a SQL db restore may wait for a tail log backup or a VM restore), then this would represent a sub-tree of &#39;progress_monitor_task_path&#39; in PerformRestoreTaskStateProto.</value>
        [DataMember(Name="appRestoreProgressMonitorSubtaskPath", EmitDefaultValue=true)]
        public string AppRestoreProgressMonitorSubtaskPath { get; set; }

        /// <summary>
        /// This has list of the restore app params for all the child restore tasks. This is populated iff the &#39;is_parent_task&#39; is set to true.
        /// </summary>
        /// <value>This has list of the restore app params for all the child restore tasks. This is populated iff the &#39;is_parent_task&#39; is set to true.</value>
        [DataMember(Name="childRestoreAppParamsVec", EmitDefaultValue=true)]
        public List<RestoreAppParams> ChildRestoreAppParamsVec { get; set; }

        /// <summary>
        /// The start time of the last finished log backup run. For SQL application, this is set iff we need to take a tail log backup.
        /// </summary>
        /// <value>The start time of the last finished log backup run. For SQL application, this is set iff we need to take a tail log backup.</value>
        [DataMember(Name="lastFinishedLogBackupStartTimeUsecs", EmitDefaultValue=true)]
        public long? LastFinishedLogBackupStartTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets RestoreAppParams
        /// </summary>
        [DataMember(Name="restoreAppParams", EmitDefaultValue=false)]
        public RestoreAppParams RestoreAppParams { get; set; }

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
            return this.Equals(input as RestoreAppTaskStateProto);
        }

        /// <summary>
        /// Returns true if RestoreAppTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAppTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAppTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppRestoreProgressMonitorSubtaskPath == input.AppRestoreProgressMonitorSubtaskPath ||
                    (this.AppRestoreProgressMonitorSubtaskPath != null &&
                    this.AppRestoreProgressMonitorSubtaskPath.Equals(input.AppRestoreProgressMonitorSubtaskPath))
                ) && 
                (
                    this.ChildRestoreAppParamsVec == input.ChildRestoreAppParamsVec ||
                    this.ChildRestoreAppParamsVec != null &&
                    input.ChildRestoreAppParamsVec != null &&
                    this.ChildRestoreAppParamsVec.SequenceEqual(input.ChildRestoreAppParamsVec)
                ) && 
                (
                    this.LastFinishedLogBackupStartTimeUsecs == input.LastFinishedLogBackupStartTimeUsecs ||
                    (this.LastFinishedLogBackupStartTimeUsecs != null &&
                    this.LastFinishedLogBackupStartTimeUsecs.Equals(input.LastFinishedLogBackupStartTimeUsecs))
                ) && 
                (
                    this.RestoreAppParams == input.RestoreAppParams ||
                    (this.RestoreAppParams != null &&
                    this.RestoreAppParams.Equals(input.RestoreAppParams))
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
                if (this.AppRestoreProgressMonitorSubtaskPath != null)
                    hashCode = hashCode * 59 + this.AppRestoreProgressMonitorSubtaskPath.GetHashCode();
                if (this.ChildRestoreAppParamsVec != null)
                    hashCode = hashCode * 59 + this.ChildRestoreAppParamsVec.GetHashCode();
                if (this.LastFinishedLogBackupStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastFinishedLogBackupStartTimeUsecs.GetHashCode();
                if (this.RestoreAppParams != null)
                    hashCode = hashCode * 59 + this.RestoreAppParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

