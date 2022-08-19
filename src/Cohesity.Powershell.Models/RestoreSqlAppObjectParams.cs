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
    /// RestoreSqlAppObjectParams
    /// </summary>
    [DataContract]
    public partial class RestoreSqlAppObjectParams :  IEquatable<RestoreSqlAppObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSqlAppObjectParams" /> class.
        /// </summary>
        /// <param name="captureTailLogs">Set to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its original source, and the database is not being renamed..</param>
        /// <param name="continueAfterError">Whether restore should continue after encountering a page checksum error..</param>
        /// <param name="dataFileDestination">Which directory to put the database data files. Missing directory will be automatically created. Cannot be empty if not restoring to the original SQL instance..</param>
        /// <param name="dbRestoreOverwritePolicy">Policy to overwrite an existing DB during a restore operation..</param>
        /// <param name="enableChecksum">Whether restore checksums are enabled..</param>
        /// <param name="instanceName">The name of the SQL instance that we restore database to. If target_host is not empty, this also cannot be empty..</param>
        /// <param name="isAutoSyncEnabled">The following field is set if auto_sync for multi-stage SQL restore task is enabled. This field is valid only if is_multi_state_restore is set to true..</param>
        /// <param name="isMultiStageRestore">The following field is set if we are creating a multi-stage SQL restore task needed for features such as Hot-Standby..</param>
        /// <param name="keepCdc">Set to true to keep cdc on restored database..</param>
        /// <param name="logFileDestination">Which directory to put the database log files. Missing directory will be automatically created. Cannot be empty if not restoring to the original SQL instance..</param>
        /// <param name="multiStageRestoreOptions">multiStageRestoreOptions.</param>
        /// <param name="newDatabaseName">The new name of the database, if it is going to be renamed. app_entity in RestoreAppObject has to be non-empty for the renaming, otherwise it does not make sense to rename all databases in the owner..</param>
        /// <param name="restoreTimeSecs">The time to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo)..</param>
        /// <param name="resumeRestore">Resume restore if sql instance/database exist in restore/recovering state. The database might be in restore/recovering state if previous restore failed or previous  restore was attempted  with norecovery option..</param>
        /// <param name="secondaryDataFileDestination">Which directory to put the secondary data files of the database. Secondary data files are optional and are user defined. The recommended file name extension for these is \&quot;.ndf\&quot;.  If this option is specified, the directory will be automatically created if its missing..</param>
        /// <param name="secondaryDataFileDestinationVec">Specify the secondary data files and corresponding direcories of the DB. Secondary data files are optional and are user defined. The recommended file extension for secondary files is \&quot;.ndf\&quot;.  If this option is specified and the destination folders do not exist they will be automatically created..</param>
        /// <param name="withClause">&#39;with_clause&#39; contains &#39;with clause&#39; to be used in native sql restore command. This is only applicable for db restore of native sql backup. Here user can specify multiple restore options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_restore_with_clause gflag..</param>
        /// <param name="withNoRecovery">Set to true if we want to recover the database in \&quot;NO_RECOVERY\&quot; mode which does not bring it online after restore..</param>
        public RestoreSqlAppObjectParams(bool? captureTailLogs = default(bool?), bool? continueAfterError = default(bool?), string dataFileDestination = default(string), int? dbRestoreOverwritePolicy = default(int?), bool? enableChecksum = default(bool?), string instanceName = default(string), bool? isAutoSyncEnabled = default(bool?), bool? isMultiStageRestore = default(bool?), bool? keepCdc = default(bool?), string logFileDestination = default(string), SqlUpdateRestoreTaskOptions multiStageRestoreOptions = default(SqlUpdateRestoreTaskOptions), string newDatabaseName = default(string), long? restoreTimeSecs = default(long?), bool? resumeRestore = default(bool?), string secondaryDataFileDestination = default(string), List<FilesToDirectoryMapping> secondaryDataFileDestinationVec = default(List<FilesToDirectoryMapping>), string withClause = default(string), bool? withNoRecovery = default(bool?))
        {
            this.CaptureTailLogs = captureTailLogs;
            this.ContinueAfterError = continueAfterError;
            this.DataFileDestination = dataFileDestination;
            this.DbRestoreOverwritePolicy = dbRestoreOverwritePolicy;
            this.EnableChecksum = enableChecksum;
            this.InstanceName = instanceName;
            this.IsAutoSyncEnabled = isAutoSyncEnabled;
            this.IsMultiStageRestore = isMultiStageRestore;
            this.KeepCdc = keepCdc;
            this.LogFileDestination = logFileDestination;
            this.NewDatabaseName = newDatabaseName;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.ResumeRestore = resumeRestore;
            this.SecondaryDataFileDestination = secondaryDataFileDestination;
            this.SecondaryDataFileDestinationVec = secondaryDataFileDestinationVec;
            this.WithClause = withClause;
            this.WithNoRecovery = withNoRecovery;
        }
        
        /// <summary>
        /// Set to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its original source, and the database is not being renamed.
        /// </summary>
        /// <value>Set to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its original source, and the database is not being renamed.</value>
        [DataMember(Name="captureTailLogs", EmitDefaultValue=true)]
        public bool? CaptureTailLogs { get; set; }

        /// <summary>
        /// Whether restore should continue after encountering a page checksum error.
        /// </summary>
        /// <value>Whether restore should continue after encountering a page checksum error.</value>
        [DataMember(Name="continueAfterError", EmitDefaultValue=true)]
        public bool? ContinueAfterError { get; set; }

        /// <summary>
        /// Which directory to put the database data files. Missing directory will be automatically created. Cannot be empty if not restoring to the original SQL instance.
        /// </summary>
        /// <value>Which directory to put the database data files. Missing directory will be automatically created. Cannot be empty if not restoring to the original SQL instance.</value>
        [DataMember(Name="dataFileDestination", EmitDefaultValue=true)]
        public string DataFileDestination { get; set; }

        /// <summary>
        /// Policy to overwrite an existing DB during a restore operation.
        /// </summary>
        /// <value>Policy to overwrite an existing DB during a restore operation.</value>
        [DataMember(Name="dbRestoreOverwritePolicy", EmitDefaultValue=true)]
        public int? DbRestoreOverwritePolicy { get; set; }

        /// <summary>
        /// Whether restore checksums are enabled.
        /// </summary>
        /// <value>Whether restore checksums are enabled.</value>
        [DataMember(Name="enableChecksum", EmitDefaultValue=true)]
        public bool? EnableChecksum { get; set; }

        /// <summary>
        /// The name of the SQL instance that we restore database to. If target_host is not empty, this also cannot be empty.
        /// </summary>
        /// <value>The name of the SQL instance that we restore database to. If target_host is not empty, this also cannot be empty.</value>
        [DataMember(Name="instanceName", EmitDefaultValue=true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The following field is set if auto_sync for multi-stage SQL restore task is enabled. This field is valid only if is_multi_state_restore is set to true.
        /// </summary>
        /// <value>The following field is set if auto_sync for multi-stage SQL restore task is enabled. This field is valid only if is_multi_state_restore is set to true.</value>
        [DataMember(Name="isAutoSyncEnabled", EmitDefaultValue=true)]
        public bool? IsAutoSyncEnabled { get; set; }

        /// <summary>
        /// The following field is set if we are creating a multi-stage SQL restore task needed for features such as Hot-Standby.
        /// </summary>
        /// <value>The following field is set if we are creating a multi-stage SQL restore task needed for features such as Hot-Standby.</value>
        [DataMember(Name="isMultiStageRestore", EmitDefaultValue=true)]
        public bool? IsMultiStageRestore { get; set; }

        /// <summary>
        /// Set to true to keep cdc on restored database.
        /// </summary>
        /// <value>Set to true to keep cdc on restored database.</value>
        [DataMember(Name="keepCdc", EmitDefaultValue=true)]
        public bool? KeepCdc { get; set; }

        /// <summary>
        /// Which directory to put the database log files. Missing directory will be automatically created. Cannot be empty if not restoring to the original SQL instance.
        /// </summary>
        /// <value>Which directory to put the database log files. Missing directory will be automatically created. Cannot be empty if not restoring to the original SQL instance.</value>
        [DataMember(Name="logFileDestination", EmitDefaultValue=true)]
        public string LogFileDestination { get; set; }

        /// <summary>
        /// Gets or Sets MultiStageRestoreOptions
        /// </summary>
        [DataMember(Name="multiStageRestoreOptions", EmitDefaultValue=false)]
        public SqlUpdateRestoreTaskOptions MultiStageRestoreOptions { get; set; }

        /// <summary>
        /// The new name of the database, if it is going to be renamed. app_entity in RestoreAppObject has to be non-empty for the renaming, otherwise it does not make sense to rename all databases in the owner.
        /// </summary>
        /// <value>The new name of the database, if it is going to be renamed. app_entity in RestoreAppObject has to be non-empty for the renaming, otherwise it does not make sense to rename all databases in the owner.</value>
        [DataMember(Name="newDatabaseName", EmitDefaultValue=true)]
        public string NewDatabaseName { get; set; }

        /// <summary>
        /// The time to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo).
        /// </summary>
        /// <value>The time to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo).</value>
        [DataMember(Name="restoreTimeSecs", EmitDefaultValue=true)]
        public long? RestoreTimeSecs { get; set; }

        /// <summary>
        /// Resume restore if sql instance/database exist in restore/recovering state. The database might be in restore/recovering state if previous restore failed or previous  restore was attempted  with norecovery option.
        /// </summary>
        /// <value>Resume restore if sql instance/database exist in restore/recovering state. The database might be in restore/recovering state if previous restore failed or previous  restore was attempted  with norecovery option.</value>
        [DataMember(Name="resumeRestore", EmitDefaultValue=true)]
        public bool? ResumeRestore { get; set; }

        /// <summary>
        /// Which directory to put the secondary data files of the database. Secondary data files are optional and are user defined. The recommended file name extension for these is \&quot;.ndf\&quot;.  If this option is specified, the directory will be automatically created if its missing.
        /// </summary>
        /// <value>Which directory to put the secondary data files of the database. Secondary data files are optional and are user defined. The recommended file name extension for these is \&quot;.ndf\&quot;.  If this option is specified, the directory will be automatically created if its missing.</value>
        [DataMember(Name="secondaryDataFileDestination", EmitDefaultValue=true)]
        public string SecondaryDataFileDestination { get; set; }

        /// <summary>
        /// Specify the secondary data files and corresponding direcories of the DB. Secondary data files are optional and are user defined. The recommended file extension for secondary files is \&quot;.ndf\&quot;.  If this option is specified and the destination folders do not exist they will be automatically created.
        /// </summary>
        /// <value>Specify the secondary data files and corresponding direcories of the DB. Secondary data files are optional and are user defined. The recommended file extension for secondary files is \&quot;.ndf\&quot;.  If this option is specified and the destination folders do not exist they will be automatically created.</value>
        [DataMember(Name="secondaryDataFileDestinationVec", EmitDefaultValue=true)]
        public List<FilesToDirectoryMapping> SecondaryDataFileDestinationVec { get; set; }

        /// <summary>
        /// &#39;with_clause&#39; contains &#39;with clause&#39; to be used in native sql restore command. This is only applicable for db restore of native sql backup. Here user can specify multiple restore options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_restore_with_clause gflag.
        /// </summary>
        /// <value>&#39;with_clause&#39; contains &#39;with clause&#39; to be used in native sql restore command. This is only applicable for db restore of native sql backup. Here user can specify multiple restore options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_restore_with_clause gflag.</value>
        [DataMember(Name="withClause", EmitDefaultValue=true)]
        public string WithClause { get; set; }

        /// <summary>
        /// Set to true if we want to recover the database in \&quot;NO_RECOVERY\&quot; mode which does not bring it online after restore.
        /// </summary>
        /// <value>Set to true if we want to recover the database in \&quot;NO_RECOVERY\&quot; mode which does not bring it online after restore.</value>
        [DataMember(Name="withNoRecovery", EmitDefaultValue=true)]
        public bool? WithNoRecovery { get; set; }

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
            return this.Equals(input as RestoreSqlAppObjectParams);
        }

        /// <summary>
        /// Returns true if RestoreSqlAppObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreSqlAppObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreSqlAppObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaptureTailLogs == input.CaptureTailLogs ||
                    (this.CaptureTailLogs != null &&
                    this.CaptureTailLogs.Equals(input.CaptureTailLogs))
                ) && 
                (
                    this.ContinueAfterError == input.ContinueAfterError ||
                    (this.ContinueAfterError != null &&
                    this.ContinueAfterError.Equals(input.ContinueAfterError))
                ) && 
                (
                    this.DataFileDestination == input.DataFileDestination ||
                    (this.DataFileDestination != null &&
                    this.DataFileDestination.Equals(input.DataFileDestination))
                ) && 
                (
                    this.DbRestoreOverwritePolicy == input.DbRestoreOverwritePolicy ||
                    (this.DbRestoreOverwritePolicy != null &&
                    this.DbRestoreOverwritePolicy.Equals(input.DbRestoreOverwritePolicy))
                ) && 
                (
                    this.EnableChecksum == input.EnableChecksum ||
                    (this.EnableChecksum != null &&
                    this.EnableChecksum.Equals(input.EnableChecksum))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.IsAutoSyncEnabled == input.IsAutoSyncEnabled ||
                    (this.IsAutoSyncEnabled != null &&
                    this.IsAutoSyncEnabled.Equals(input.IsAutoSyncEnabled))
                ) && 
                (
                    this.IsMultiStageRestore == input.IsMultiStageRestore ||
                    (this.IsMultiStageRestore != null &&
                    this.IsMultiStageRestore.Equals(input.IsMultiStageRestore))
                ) && 
                (
                    this.KeepCdc == input.KeepCdc ||
                    (this.KeepCdc != null &&
                    this.KeepCdc.Equals(input.KeepCdc))
                ) && 
                (
                    this.LogFileDestination == input.LogFileDestination ||
                    (this.LogFileDestination != null &&
                    this.LogFileDestination.Equals(input.LogFileDestination))
                ) && 
                (
                    this.MultiStageRestoreOptions == input.MultiStageRestoreOptions ||
                    (this.MultiStageRestoreOptions != null &&
                    this.MultiStageRestoreOptions.Equals(input.MultiStageRestoreOptions))
                ) && 
                (
                    this.NewDatabaseName == input.NewDatabaseName ||
                    (this.NewDatabaseName != null &&
                    this.NewDatabaseName.Equals(input.NewDatabaseName))
                ) && 
                (
                    this.RestoreTimeSecs == input.RestoreTimeSecs ||
                    (this.RestoreTimeSecs != null &&
                    this.RestoreTimeSecs.Equals(input.RestoreTimeSecs))
                ) && 
                (
                    this.ResumeRestore == input.ResumeRestore ||
                    (this.ResumeRestore != null &&
                    this.ResumeRestore.Equals(input.ResumeRestore))
                ) && 
                (
                    this.SecondaryDataFileDestination == input.SecondaryDataFileDestination ||
                    (this.SecondaryDataFileDestination != null &&
                    this.SecondaryDataFileDestination.Equals(input.SecondaryDataFileDestination))
                ) && 
                (
                    this.SecondaryDataFileDestinationVec == input.SecondaryDataFileDestinationVec ||
                    this.SecondaryDataFileDestinationVec != null &&
                    input.SecondaryDataFileDestinationVec != null &&
                    this.SecondaryDataFileDestinationVec.Equals(input.SecondaryDataFileDestinationVec)
                ) && 
                (
                    this.WithClause == input.WithClause ||
                    (this.WithClause != null &&
                    this.WithClause.Equals(input.WithClause))
                ) && 
                (
                    this.WithNoRecovery == input.WithNoRecovery ||
                    (this.WithNoRecovery != null &&
                    this.WithNoRecovery.Equals(input.WithNoRecovery))
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
                if (this.CaptureTailLogs != null)
                    hashCode = hashCode * 59 + this.CaptureTailLogs.GetHashCode();
                if (this.ContinueAfterError != null)
                    hashCode = hashCode * 59 + this.ContinueAfterError.GetHashCode();
                if (this.DataFileDestination != null)
                    hashCode = hashCode * 59 + this.DataFileDestination.GetHashCode();
                if (this.DbRestoreOverwritePolicy != null)
                    hashCode = hashCode * 59 + this.DbRestoreOverwritePolicy.GetHashCode();
                if (this.EnableChecksum != null)
                    hashCode = hashCode * 59 + this.EnableChecksum.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.IsAutoSyncEnabled != null)
                    hashCode = hashCode * 59 + this.IsAutoSyncEnabled.GetHashCode();
                if (this.IsMultiStageRestore != null)
                    hashCode = hashCode * 59 + this.IsMultiStageRestore.GetHashCode();
                if (this.KeepCdc != null)
                    hashCode = hashCode * 59 + this.KeepCdc.GetHashCode();
                if (this.LogFileDestination != null)
                    hashCode = hashCode * 59 + this.LogFileDestination.GetHashCode();
                if (this.MultiStageRestoreOptions != null)
                    hashCode = hashCode * 59 + this.MultiStageRestoreOptions.GetHashCode();
                if (this.NewDatabaseName != null)
                    hashCode = hashCode * 59 + this.NewDatabaseName.GetHashCode();
                if (this.RestoreTimeSecs != null)
                    hashCode = hashCode * 59 + this.RestoreTimeSecs.GetHashCode();
                if (this.ResumeRestore != null)
                    hashCode = hashCode * 59 + this.ResumeRestore.GetHashCode();
                if (this.SecondaryDataFileDestination != null)
                    hashCode = hashCode * 59 + this.SecondaryDataFileDestination.GetHashCode();
                if (this.SecondaryDataFileDestinationVec != null)
                    hashCode = hashCode * 59 + this.SecondaryDataFileDestinationVec.GetHashCode();
                if (this.WithClause != null)
                    hashCode = hashCode * 59 + this.WithClause.GetHashCode();
                if (this.WithNoRecovery != null)
                    hashCode = hashCode * 59 + this.WithNoRecovery.GetHashCode();
                return hashCode;
            }
        }

    }

}

