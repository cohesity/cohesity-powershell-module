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
    /// Specifies statistics about a Backup task in a Protection Job Run. Specifies statistics for one backup task. One backup task is used to backup on Protection Source. This structure is also used to aggregate stats of a Backup tasks in a Protection Job Run.
    /// </summary>
    [DataContract]
    public partial class BackupSourceStats :  IEquatable<BackupSourceStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupSourceStats" /> class.
        /// </summary>
        /// <param name="totalBytesTiered">Specifies the total amount of data successfully tiered from the source..</param>
        /// <param name="admittedTimeUsecs">Specifies the time the task was unqueued from the queue to start running. This field can be used to determine the following times: initial-wait-time &#x3D; admittedTimeUsecs - startTimeUsecs run-time &#x3D; endTimeUsecs - admittedTimeUsecs If the task ends up waiting in other queues, then actual run-time will be smaller than the run-time computed this way. This field is only populated for Backup tasks currently..</param>
        /// <param name="endTimeUsecs">Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="permitGrantTimeUsecs">Specifies the time when gatekeeper permit is granted to the backup task. If the backup task is rescheduled due to errors, the field is updated to the time when permit is granted again..</param>
        /// <param name="queueDurationUsecs">\&quot;Specifies the duration between the startTime and when gatekeeper permit is granted to the backup task. If the backup task is rescheduled due to errors, the field is updated considering the time when permit is granted again. Queue duration &#x3D; PermitGrantTimeUsecs - StartTimeUsecs\&quot;.</param>
        /// <param name="startTimeUsecs">Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run..</param>
        /// <param name="timeTakenUsecs">Specifies the actual execution time for the protection run to complete the backup task and the copy tasks. This time will not include the time waited in various internal queues. This field is only populated for Backup tasks currently..</param>
        /// <param name="totalBytesReadFromSource">Specifies the total amount of data read from the source (so far)..</param>
        /// <param name="totalBytesToReadFromSource">Specifies the total amount of data expected to be read from the source..</param>
        /// <param name="totalLogicalBackupSizeBytes">Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="totalPhysicalBackupSizeBytes">Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB..</param>
        /// <param name="totalSourceSizeBytes">Specifies the size of the source object (such as a VM) protected by this task on the primary storage before the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication..</param>
        public BackupSourceStats(long? totalBytesTiered = default(long?), long? admittedTimeUsecs = default(long?), long? endTimeUsecs = default(long?), long? permitGrantTimeUsecs = default(long?), long? queueDurationUsecs = default(long?), long? startTimeUsecs = default(long?), long? timeTakenUsecs = default(long?), long? totalBytesReadFromSource = default(long?), long? totalBytesToReadFromSource = default(long?), long? totalLogicalBackupSizeBytes = default(long?), long? totalPhysicalBackupSizeBytes = default(long?), long? totalSourceSizeBytes = default(long?))
        {
            this.AdmittedTimeUsecs = admittedTimeUsecs;
            this.EndTimeUsecs = endTimeUsecs;
            this.PermitGrantTimeUsecs = permitGrantTimeUsecs;
            this.QueueDurationUsecs = queueDurationUsecs;
            this.StartTimeUsecs = startTimeUsecs;
            this.TimeTakenUsecs = timeTakenUsecs;
            this.TotalBytesReadFromSource = totalBytesReadFromSource;
            this.TotalBytesToReadFromSource = totalBytesToReadFromSource;
            this.TotalLogicalBackupSizeBytes = totalLogicalBackupSizeBytes;
            this.TotalPhysicalBackupSizeBytes = totalPhysicalBackupSizeBytes;
            this.TotalSourceSizeBytes = totalSourceSizeBytes;
            this.TotalBytesTiered = totalBytesTiered;
        }
        
        /// <summary>
        /// Specifies the total amount of data successfully tiered from the source.
        /// </summary>
        /// <value>Specifies the total amount of data successfully tiered from the source.</value>
        [DataMember(Name="TotalBytesTiered", EmitDefaultValue=true)]
        public long? TotalBytesTiered { get; set; }

        /// <summary>
        /// Specifies the time the task was unqueued from the queue to start running. This field can be used to determine the following times: initial-wait-time &#x3D; admittedTimeUsecs - startTimeUsecs run-time &#x3D; endTimeUsecs - admittedTimeUsecs If the task ends up waiting in other queues, then actual run-time will be smaller than the run-time computed this way. This field is only populated for Backup tasks currently.
        /// </summary>
        /// <value>Specifies the time the task was unqueued from the queue to start running. This field can be used to determine the following times: initial-wait-time &#x3D; admittedTimeUsecs - startTimeUsecs run-time &#x3D; endTimeUsecs - admittedTimeUsecs If the task ends up waiting in other queues, then actual run-time will be smaller than the run-time computed this way. This field is only populated for Backup tasks currently.</value>
        [DataMember(Name="admittedTimeUsecs", EmitDefaultValue=true)]
        public long? AdmittedTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the time when gatekeeper permit is granted to the backup task. If the backup task is rescheduled due to errors, the field is updated to the time when permit is granted again.
        /// </summary>
        /// <value>Specifies the time when gatekeeper permit is granted to the backup task. If the backup task is rescheduled due to errors, the field is updated to the time when permit is granted again.</value>
        [DataMember(Name="permitGrantTimeUsecs", EmitDefaultValue=true)]
        public long? PermitGrantTimeUsecs { get; set; }

        /// <summary>
        /// \&quot;Specifies the duration between the startTime and when gatekeeper permit is granted to the backup task. If the backup task is rescheduled due to errors, the field is updated considering the time when permit is granted again. Queue duration &#x3D; PermitGrantTimeUsecs - StartTimeUsecs\&quot;
        /// </summary>
        /// <value>\&quot;Specifies the duration between the startTime and when gatekeeper permit is granted to the backup task. If the backup task is rescheduled due to errors, the field is updated considering the time when permit is granted again. Queue duration &#x3D; PermitGrantTimeUsecs - StartTimeUsecs\&quot;</value>
        [DataMember(Name="queueDurationUsecs", EmitDefaultValue=true)]
        public long? QueueDurationUsecs { get; set; }

        /// <summary>
        /// Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run.
        /// </summary>
        /// <value>Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the actual execution time for the protection run to complete the backup task and the copy tasks. This time will not include the time waited in various internal queues. This field is only populated for Backup tasks currently.
        /// </summary>
        /// <value>Specifies the actual execution time for the protection run to complete the backup task and the copy tasks. This time will not include the time waited in various internal queues. This field is only populated for Backup tasks currently.</value>
        [DataMember(Name="timeTakenUsecs", EmitDefaultValue=true)]
        public long? TimeTakenUsecs { get; set; }

        /// <summary>
        /// Specifies the total amount of data read from the source (so far).
        /// </summary>
        /// <value>Specifies the total amount of data read from the source (so far).</value>
        [DataMember(Name="totalBytesReadFromSource", EmitDefaultValue=true)]
        public long? TotalBytesReadFromSource { get; set; }

        /// <summary>
        /// Specifies the total amount of data expected to be read from the source.
        /// </summary>
        /// <value>Specifies the total amount of data expected to be read from the source.</value>
        [DataMember(Name="totalBytesToReadFromSource", EmitDefaultValue=true)]
        public long? TotalBytesToReadFromSource { get; set; }

        /// <summary>
        /// Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalLogicalBackupSizeBytes", EmitDefaultValue=true)]
        public long? TotalLogicalBackupSizeBytes { get; set; }

        /// <summary>
        /// Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB.
        /// </summary>
        /// <value>Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB.</value>
        [DataMember(Name="totalPhysicalBackupSizeBytes", EmitDefaultValue=true)]
        public long? TotalPhysicalBackupSizeBytes { get; set; }

        /// <summary>
        /// Specifies the size of the source object (such as a VM) protected by this task on the primary storage before the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the size of the source object (such as a VM) protected by this task on the primary storage before the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalSourceSizeBytes", EmitDefaultValue=true)]
        public long? TotalSourceSizeBytes { get; set; }

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
            return this.Equals(input as BackupSourceStats);
        }

        /// <summary>
        /// Returns true if BackupSourceStats instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupSourceStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupSourceStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalBytesTiered == input.TotalBytesTiered ||
                    (this.TotalBytesTiered != null &&
                    this.TotalBytesTiered.Equals(input.TotalBytesTiered))
                ) && 
                (
                    this.AdmittedTimeUsecs == input.AdmittedTimeUsecs ||
                    (this.AdmittedTimeUsecs != null &&
                    this.AdmittedTimeUsecs.Equals(input.AdmittedTimeUsecs))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.PermitGrantTimeUsecs == input.PermitGrantTimeUsecs ||
                    (this.PermitGrantTimeUsecs != null &&
                    this.PermitGrantTimeUsecs.Equals(input.PermitGrantTimeUsecs))
                ) && 
                (
                    this.QueueDurationUsecs == input.QueueDurationUsecs ||
                    (this.QueueDurationUsecs != null &&
                    this.QueueDurationUsecs.Equals(input.QueueDurationUsecs))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.TimeTakenUsecs == input.TimeTakenUsecs ||
                    (this.TimeTakenUsecs != null &&
                    this.TimeTakenUsecs.Equals(input.TimeTakenUsecs))
                ) && 
                (
                    this.TotalBytesReadFromSource == input.TotalBytesReadFromSource ||
                    (this.TotalBytesReadFromSource != null &&
                    this.TotalBytesReadFromSource.Equals(input.TotalBytesReadFromSource))
                ) && 
                (
                    this.TotalBytesToReadFromSource == input.TotalBytesToReadFromSource ||
                    (this.TotalBytesToReadFromSource != null &&
                    this.TotalBytesToReadFromSource.Equals(input.TotalBytesToReadFromSource))
                ) && 
                (
                    this.TotalLogicalBackupSizeBytes == input.TotalLogicalBackupSizeBytes ||
                    (this.TotalLogicalBackupSizeBytes != null &&
                    this.TotalLogicalBackupSizeBytes.Equals(input.TotalLogicalBackupSizeBytes))
                ) && 
                (
                    this.TotalPhysicalBackupSizeBytes == input.TotalPhysicalBackupSizeBytes ||
                    (this.TotalPhysicalBackupSizeBytes != null &&
                    this.TotalPhysicalBackupSizeBytes.Equals(input.TotalPhysicalBackupSizeBytes))
                ) && 
                (
                    this.TotalSourceSizeBytes == input.TotalSourceSizeBytes ||
                    (this.TotalSourceSizeBytes != null &&
                    this.TotalSourceSizeBytes.Equals(input.TotalSourceSizeBytes))
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
                if (this.TotalBytesTiered != null)
                    hashCode = hashCode * 59 + this.TotalBytesTiered.GetHashCode();
                if (this.AdmittedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.AdmittedTimeUsecs.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.PermitGrantTimeUsecs != null)
                    hashCode = hashCode * 59 + this.PermitGrantTimeUsecs.GetHashCode();
                if (this.QueueDurationUsecs != null)
                    hashCode = hashCode * 59 + this.QueueDurationUsecs.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.TimeTakenUsecs != null)
                    hashCode = hashCode * 59 + this.TimeTakenUsecs.GetHashCode();
                if (this.TotalBytesReadFromSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesReadFromSource.GetHashCode();
                if (this.TotalBytesToReadFromSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesToReadFromSource.GetHashCode();
                if (this.TotalLogicalBackupSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalBackupSizeBytes.GetHashCode();
                if (this.TotalPhysicalBackupSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalPhysicalBackupSizeBytes.GetHashCode();
                if (this.TotalSourceSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalSourceSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

