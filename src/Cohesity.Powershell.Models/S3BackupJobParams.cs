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
    /// S3BackupJobParams
    /// </summary>
    [DataContract]
    public partial class S3BackupJobParams :  IEquatable<S3BackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BackupJobParams" /> class.
        /// </summary>
        /// <param name="backupObjectAcls">If true, we will also backup object level acls if they are enabled..</param>
        /// <param name="backupVersion">Version number of the backup associated with the job version &#x3D; 1 -&gt; ENG-321027 version &#x3D; 2 -&gt; ENG-313025.</param>
        /// <param name="inventoryReportFrequency">The Amazon S3 Inventory report configuration.</param>
        /// <param name="s3InventoryReportDestinationBucket">ARN of the inventory report destination bucket for S3 backups..</param>
        /// <param name="s3InventoryReportDestinationBucketPrefix">The prefix in the S3 destination bucket where inventory reports will be stored. This field should be in the format &lt;destination-bucket-arn&gt;/prefix..</param>
        /// <param name="scheduledBaselineFreqDays">scheduledBaselineFreqDays.</param>
        /// <param name="skipFilesOnError">If true then backup job will skip the S3 objects whose backup get failed. Basically, won&#39;t fail the backup job if some of the objects gets failed..</param>
        /// <param name="storageClasses">Objects whose storage class is not in the selected storage classes will be skipped..</param>
        public S3BackupJobParams(bool? backupObjectAcls = default(bool?), long? backupVersion = default(long?), int? inventoryReportFrequency = default(int?), string s3InventoryReportDestinationBucket = default(string), string s3InventoryReportDestinationBucketPrefix = default(string), int? scheduledBaselineFreqDays = default(int?), bool? skipFilesOnError = default(bool?), List<int> storageClasses = default(List<int>))
        {
            this.BackupObjectAcls = backupObjectAcls;
            this.BackupVersion = backupVersion;
            this.InventoryReportFrequency = inventoryReportFrequency;
            this.S3InventoryReportDestinationBucket = s3InventoryReportDestinationBucket;
            this.S3InventoryReportDestinationBucketPrefix = s3InventoryReportDestinationBucketPrefix;
            this.ScheduledBaselineFreqDays = scheduledBaselineFreqDays;
            this.SkipFilesOnError = skipFilesOnError;
            this.StorageClasses = storageClasses;
            this.BackupObjectAcls = backupObjectAcls;
            this.BackupVersion = backupVersion;
            this.InventoryReportFrequency = inventoryReportFrequency;
            this.S3InventoryReportDestinationBucket = s3InventoryReportDestinationBucket;
            this.S3InventoryReportDestinationBucketPrefix = s3InventoryReportDestinationBucketPrefix;
            this.ScheduledBaselineFreqDays = scheduledBaselineFreqDays;
            this.SkipFilesOnError = skipFilesOnError;
            this.StorageClasses = storageClasses;
        }
        
        /// <summary>
        /// If true, we will also backup object level acls if they are enabled.
        /// </summary>
        /// <value>If true, we will also backup object level acls if they are enabled.</value>
        [DataMember(Name="backupObjectAcls", EmitDefaultValue=true)]
        public bool? BackupObjectAcls { get; set; }

        /// <summary>
        /// Version number of the backup associated with the job version &#x3D; 1 -&gt; ENG-321027 version &#x3D; 2 -&gt; ENG-313025
        /// </summary>
        /// <value>Version number of the backup associated with the job version &#x3D; 1 -&gt; ENG-321027 version &#x3D; 2 -&gt; ENG-313025</value>
        [DataMember(Name="backupVersion", EmitDefaultValue=true)]
        public long? BackupVersion { get; set; }

        /// <summary>
        /// The Amazon S3 Inventory report configuration
        /// </summary>
        /// <value>The Amazon S3 Inventory report configuration</value>
        [DataMember(Name="inventoryReportFrequency", EmitDefaultValue=true)]
        public int? InventoryReportFrequency { get; set; }

        /// <summary>
        /// ARN of the inventory report destination bucket for S3 backups.
        /// </summary>
        /// <value>ARN of the inventory report destination bucket for S3 backups.</value>
        [DataMember(Name="s3InventoryReportDestinationBucket", EmitDefaultValue=true)]
        public string S3InventoryReportDestinationBucket { get; set; }

        /// <summary>
        /// The prefix in the S3 destination bucket where inventory reports will be stored. This field should be in the format &lt;destination-bucket-arn&gt;/prefix.
        /// </summary>
        /// <value>The prefix in the S3 destination bucket where inventory reports will be stored. This field should be in the format &lt;destination-bucket-arn&gt;/prefix.</value>
        [DataMember(Name="s3InventoryReportDestinationBucketPrefix", EmitDefaultValue=true)]
        public string S3InventoryReportDestinationBucketPrefix { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledBaselineFreqDays
        /// </summary>
        [DataMember(Name="scheduledBaselineFreqDays", EmitDefaultValue=true)]
        public int? ScheduledBaselineFreqDays { get; set; }

        /// <summary>
        /// If true then backup job will skip the S3 objects whose backup get failed. Basically, won&#39;t fail the backup job if some of the objects gets failed.
        /// </summary>
        /// <value>If true then backup job will skip the S3 objects whose backup get failed. Basically, won&#39;t fail the backup job if some of the objects gets failed.</value>
        [DataMember(Name="skipFilesOnError", EmitDefaultValue=true)]
        public bool? SkipFilesOnError { get; set; }

        /// <summary>
        /// Objects whose storage class is not in the selected storage classes will be skipped.
        /// </summary>
        /// <value>Objects whose storage class is not in the selected storage classes will be skipped.</value>
        [DataMember(Name="storageClasses", EmitDefaultValue=true)]
        public List<int> StorageClasses { get; set; }

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
            return this.Equals(input as S3BackupJobParams);
        }

        /// <summary>
        /// Returns true if S3BackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupObjectAcls == input.BackupObjectAcls ||
                    (this.BackupObjectAcls != null &&
                    this.BackupObjectAcls.Equals(input.BackupObjectAcls))
                ) && 
                (
                    this.BackupVersion == input.BackupVersion ||
                    (this.BackupVersion != null &&
                    this.BackupVersion.Equals(input.BackupVersion))
                ) && 
                (
                    this.InventoryReportFrequency == input.InventoryReportFrequency ||
                    (this.InventoryReportFrequency != null &&
                    this.InventoryReportFrequency.Equals(input.InventoryReportFrequency))
                ) && 
                (
                    this.S3InventoryReportDestinationBucket == input.S3InventoryReportDestinationBucket ||
                    (this.S3InventoryReportDestinationBucket != null &&
                    this.S3InventoryReportDestinationBucket.Equals(input.S3InventoryReportDestinationBucket))
                ) && 
                (
                    this.S3InventoryReportDestinationBucketPrefix == input.S3InventoryReportDestinationBucketPrefix ||
                    (this.S3InventoryReportDestinationBucketPrefix != null &&
                    this.S3InventoryReportDestinationBucketPrefix.Equals(input.S3InventoryReportDestinationBucketPrefix))
                ) && 
                (
                    this.ScheduledBaselineFreqDays == input.ScheduledBaselineFreqDays ||
                    (this.ScheduledBaselineFreqDays != null &&
                    this.ScheduledBaselineFreqDays.Equals(input.ScheduledBaselineFreqDays))
                ) && 
                (
                    this.SkipFilesOnError == input.SkipFilesOnError ||
                    (this.SkipFilesOnError != null &&
                    this.SkipFilesOnError.Equals(input.SkipFilesOnError))
                ) && 
                (
                    this.StorageClasses == input.StorageClasses ||
                    this.StorageClasses != null &&
                    input.StorageClasses != null &&
                    this.StorageClasses.SequenceEqual(input.StorageClasses)
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
                if (this.BackupObjectAcls != null)
                    hashCode = hashCode * 59 + this.BackupObjectAcls.GetHashCode();
                if (this.BackupVersion != null)
                    hashCode = hashCode * 59 + this.BackupVersion.GetHashCode();
                if (this.InventoryReportFrequency != null)
                    hashCode = hashCode * 59 + this.InventoryReportFrequency.GetHashCode();
                if (this.S3InventoryReportDestinationBucket != null)
                    hashCode = hashCode * 59 + this.S3InventoryReportDestinationBucket.GetHashCode();
                if (this.S3InventoryReportDestinationBucketPrefix != null)
                    hashCode = hashCode * 59 + this.S3InventoryReportDestinationBucketPrefix.GetHashCode();
                if (this.ScheduledBaselineFreqDays != null)
                    hashCode = hashCode * 59 + this.ScheduledBaselineFreqDays.GetHashCode();
                if (this.SkipFilesOnError != null)
                    hashCode = hashCode * 59 + this.SkipFilesOnError.GetHashCode();
                if (this.StorageClasses != null)
                    hashCode = hashCode * 59 + this.StorageClasses.GetHashCode();
                return hashCode;
            }
        }

    }

}

