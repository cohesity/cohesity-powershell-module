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
    /// Proto to describe information about the retrieval of an archive task as provided by Icebox.
    /// </summary>
    [DataContract]
    public partial class RetrieveArchiveInfo :  IEquatable<RetrieveArchiveInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveArchiveInfo" /> class.
        /// </summary>
        /// <param name="avgLogicalTransferRateBps">Average logical bytes transfer rate in bytes per second as seen by Icebox..</param>
        /// <param name="bytesTransferred">Number of physical bytes transferred for this retrieval task so far..</param>
        /// <param name="endTimeUsecs">Time when this retrieval task ended at Icebox side. If not set, then the retrieval has not ended yet..</param>
        /// <param name="error">error.</param>
        /// <param name="logicalBytesTransferred">Number of logical bytes transferred so far..</param>
        /// <param name="logicalSizeBytes">Total logical size of the retrieval task..</param>
        /// <param name="progressMonitorTaskPath">The root path of the progress monitor for this task..</param>
        /// <param name="retrievedEntityVec">Contains info about all retrieved entities..</param>
        /// <param name="skipCloningView">If true, we will use the view directly without cloning it and delete it when the restore is complete..</param>
        /// <param name="startTimeUsecs">Time when this retrieval task was started by Icebox. If not set, then retrieval has not been started yet..</param>
        /// <param name="stubViewName">The stub view that Icebox created. Stub view can be used for selectively restoring or accessing files from an archive location..</param>
        /// <param name="stubViewRelativeDirName">Relative directory inside the stub view that corresponds with the archive..</param>
        /// <param name="targetViewName">The name of the target view where Icebox has retrieved and staged the requested entities..</param>
        /// <param name="userActionRequiredMsg">Message to display in the UI if any manual intervention is needed to make forward progress for the retrieve from archive task. This message is mainly relevant for tape based retrieve from archive tasks where a backup admin might be asked to load new media when the tape library does not have the relevant media to retrieve the archive from..</param>
        public RetrieveArchiveInfo(long? avgLogicalTransferRateBps = default(long?), long? bytesTransferred = default(long?), long? endTimeUsecs = default(long?), ErrorProto error = default(ErrorProto), long? logicalBytesTransferred = default(long?), long? logicalSizeBytes = default(long?), string progressMonitorTaskPath = default(string), List<RetrieveArchiveInfoRetrievedEntity> retrievedEntityVec = default(List<RetrieveArchiveInfoRetrievedEntity>), bool? skipCloningView = default(bool?), long? startTimeUsecs = default(long?), string stubViewName = default(string), string stubViewRelativeDirName = default(string), string targetViewName = default(string), string userActionRequiredMsg = default(string))
        {
            this.AvgLogicalTransferRateBps = avgLogicalTransferRateBps;
            this.BytesTransferred = bytesTransferred;
            this.EndTimeUsecs = endTimeUsecs;
            this.LogicalBytesTransferred = logicalBytesTransferred;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RetrievedEntityVec = retrievedEntityVec;
            this.SkipCloningView = skipCloningView;
            this.StartTimeUsecs = startTimeUsecs;
            this.StubViewName = stubViewName;
            this.StubViewRelativeDirName = stubViewRelativeDirName;
            this.TargetViewName = targetViewName;
            this.UserActionRequiredMsg = userActionRequiredMsg;
            this.AvgLogicalTransferRateBps = avgLogicalTransferRateBps;
            this.BytesTransferred = bytesTransferred;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.LogicalBytesTransferred = logicalBytesTransferred;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RetrievedEntityVec = retrievedEntityVec;
            this.SkipCloningView = skipCloningView;
            this.StartTimeUsecs = startTimeUsecs;
            this.StubViewName = stubViewName;
            this.StubViewRelativeDirName = stubViewRelativeDirName;
            this.TargetViewName = targetViewName;
            this.UserActionRequiredMsg = userActionRequiredMsg;
        }
        
        /// <summary>
        /// Average logical bytes transfer rate in bytes per second as seen by Icebox.
        /// </summary>
        /// <value>Average logical bytes transfer rate in bytes per second as seen by Icebox.</value>
        [DataMember(Name="avgLogicalTransferRateBps", EmitDefaultValue=true)]
        public long? AvgLogicalTransferRateBps { get; set; }

        /// <summary>
        /// Number of physical bytes transferred for this retrieval task so far.
        /// </summary>
        /// <value>Number of physical bytes transferred for this retrieval task so far.</value>
        [DataMember(Name="bytesTransferred", EmitDefaultValue=true)]
        public long? BytesTransferred { get; set; }

        /// <summary>
        /// Time when this retrieval task ended at Icebox side. If not set, then the retrieval has not ended yet.
        /// </summary>
        /// <value>Time when this retrieval task ended at Icebox side. If not set, then the retrieval has not ended yet.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Number of logical bytes transferred so far.
        /// </summary>
        /// <value>Number of logical bytes transferred so far.</value>
        [DataMember(Name="logicalBytesTransferred", EmitDefaultValue=true)]
        public long? LogicalBytesTransferred { get; set; }

        /// <summary>
        /// Total logical size of the retrieval task.
        /// </summary>
        /// <value>Total logical size of the retrieval task.</value>
        [DataMember(Name="logicalSizeBytes", EmitDefaultValue=true)]
        public long? LogicalSizeBytes { get; set; }

        /// <summary>
        /// The root path of the progress monitor for this task.
        /// </summary>
        /// <value>The root path of the progress monitor for this task.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=true)]
        public string ProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Contains info about all retrieved entities.
        /// </summary>
        /// <value>Contains info about all retrieved entities.</value>
        [DataMember(Name="retrievedEntityVec", EmitDefaultValue=true)]
        public List<RetrieveArchiveInfoRetrievedEntity> RetrievedEntityVec { get; set; }

        /// <summary>
        /// If true, we will use the view directly without cloning it and delete it when the restore is complete.
        /// </summary>
        /// <value>If true, we will use the view directly without cloning it and delete it when the restore is complete.</value>
        [DataMember(Name="skipCloningView", EmitDefaultValue=true)]
        public bool? SkipCloningView { get; set; }

        /// <summary>
        /// Time when this retrieval task was started by Icebox. If not set, then retrieval has not been started yet.
        /// </summary>
        /// <value>Time when this retrieval task was started by Icebox. If not set, then retrieval has not been started yet.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// The stub view that Icebox created. Stub view can be used for selectively restoring or accessing files from an archive location.
        /// </summary>
        /// <value>The stub view that Icebox created. Stub view can be used for selectively restoring or accessing files from an archive location.</value>
        [DataMember(Name="stubViewName", EmitDefaultValue=true)]
        public string StubViewName { get; set; }

        /// <summary>
        /// Relative directory inside the stub view that corresponds with the archive.
        /// </summary>
        /// <value>Relative directory inside the stub view that corresponds with the archive.</value>
        [DataMember(Name="stubViewRelativeDirName", EmitDefaultValue=true)]
        public string StubViewRelativeDirName { get; set; }

        /// <summary>
        /// The name of the target view where Icebox has retrieved and staged the requested entities.
        /// </summary>
        /// <value>The name of the target view where Icebox has retrieved and staged the requested entities.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=true)]
        public string TargetViewName { get; set; }

        /// <summary>
        /// Message to display in the UI if any manual intervention is needed to make forward progress for the retrieve from archive task. This message is mainly relevant for tape based retrieve from archive tasks where a backup admin might be asked to load new media when the tape library does not have the relevant media to retrieve the archive from.
        /// </summary>
        /// <value>Message to display in the UI if any manual intervention is needed to make forward progress for the retrieve from archive task. This message is mainly relevant for tape based retrieve from archive tasks where a backup admin might be asked to load new media when the tape library does not have the relevant media to retrieve the archive from.</value>
        [DataMember(Name="userActionRequiredMsg", EmitDefaultValue=true)]
        public string UserActionRequiredMsg { get; set; }

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
            return this.Equals(input as RetrieveArchiveInfo);
        }

        /// <summary>
        /// Returns true if RetrieveArchiveInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveArchiveInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveArchiveInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvgLogicalTransferRateBps == input.AvgLogicalTransferRateBps ||
                    (this.AvgLogicalTransferRateBps != null &&
                    this.AvgLogicalTransferRateBps.Equals(input.AvgLogicalTransferRateBps))
                ) && 
                (
                    this.BytesTransferred == input.BytesTransferred ||
                    (this.BytesTransferred != null &&
                    this.BytesTransferred.Equals(input.BytesTransferred))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.LogicalBytesTransferred == input.LogicalBytesTransferred ||
                    (this.LogicalBytesTransferred != null &&
                    this.LogicalBytesTransferred.Equals(input.LogicalBytesTransferred))
                ) && 
                (
                    this.LogicalSizeBytes == input.LogicalSizeBytes ||
                    (this.LogicalSizeBytes != null &&
                    this.LogicalSizeBytes.Equals(input.LogicalSizeBytes))
                ) && 
                (
                    this.ProgressMonitorTaskPath == input.ProgressMonitorTaskPath ||
                    (this.ProgressMonitorTaskPath != null &&
                    this.ProgressMonitorTaskPath.Equals(input.ProgressMonitorTaskPath))
                ) && 
                (
                    this.RetrievedEntityVec == input.RetrievedEntityVec ||
                    this.RetrievedEntityVec != null &&
                    input.RetrievedEntityVec != null &&
                    this.RetrievedEntityVec.SequenceEqual(input.RetrievedEntityVec)
                ) && 
                (
                    this.SkipCloningView == input.SkipCloningView ||
                    (this.SkipCloningView != null &&
                    this.SkipCloningView.Equals(input.SkipCloningView))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.StubViewName == input.StubViewName ||
                    (this.StubViewName != null &&
                    this.StubViewName.Equals(input.StubViewName))
                ) && 
                (
                    this.StubViewRelativeDirName == input.StubViewRelativeDirName ||
                    (this.StubViewRelativeDirName != null &&
                    this.StubViewRelativeDirName.Equals(input.StubViewRelativeDirName))
                ) && 
                (
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
                ) && 
                (
                    this.UserActionRequiredMsg == input.UserActionRequiredMsg ||
                    (this.UserActionRequiredMsg != null &&
                    this.UserActionRequiredMsg.Equals(input.UserActionRequiredMsg))
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
                if (this.AvgLogicalTransferRateBps != null)
                    hashCode = hashCode * 59 + this.AvgLogicalTransferRateBps.GetHashCode();
                if (this.BytesTransferred != null)
                    hashCode = hashCode * 59 + this.BytesTransferred.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.LogicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.LogicalBytesTransferred.GetHashCode();
                if (this.LogicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.LogicalSizeBytes.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.RetrievedEntityVec != null)
                    hashCode = hashCode * 59 + this.RetrievedEntityVec.GetHashCode();
                if (this.SkipCloningView != null)
                    hashCode = hashCode * 59 + this.SkipCloningView.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.StubViewName != null)
                    hashCode = hashCode * 59 + this.StubViewName.GetHashCode();
                if (this.StubViewRelativeDirName != null)
                    hashCode = hashCode * 59 + this.StubViewRelativeDirName.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                if (this.UserActionRequiredMsg != null)
                    hashCode = hashCode * 59 + this.UserActionRequiredMsg.GetHashCode();
                return hashCode;
            }
        }

    }

}

