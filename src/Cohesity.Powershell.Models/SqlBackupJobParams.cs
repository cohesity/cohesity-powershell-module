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
    /// Message to capture additional backup job params specific to SQL.
    /// </summary>
    [DataContract]
    public partial class SqlBackupJobParams :  IEquatable<SqlBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBackupJobParams" /> class.
        /// </summary>
        /// <param name="aagBackupPreferenceType">Preference type for backing up databases that are part of an AAG. Only applicable if &#39;use_aag_preferences_from_sql_server&#39; is set to false..</param>
        /// <param name="backupDatabaseVolumesOnly">If set to true, only the volumes associated with databases should be backed up. The user cannot select additional volumes at host level for backup.  If set to false, all the volumes on the host machine will be backed up. In this case, the user can further select the exact set of volumes using host level params.  Note that the volumes associated with selected databases will always be included in the backup..</param>
        /// <param name="backupSystemDbs">Set to true if system databases should be backed up..</param>
        /// <param name="continueAfterError">Whether backup should continue after encountering a page checksum error..</param>
        /// <param name="enableChecksum">Whether backup checksums are enabled..</param>
        /// <param name="enableIncrementalBackupAfterRestart">If this is set to true, then incremental backup will be performed after the server restarts, otherwise a full-backup will be done..</param>
        /// <param name="fullBackupType">The type of SQL full backup to be used for this job..</param>
        /// <param name="isCopyOnlyFull">Whether full backups should be copy-only..</param>
        /// <param name="isCopyOnlyLog">Whether log backups should be copy-only..</param>
        /// <param name="logBackupNumStreams">The number of streams to be used for log backups in native sql backup command. This is only applicable for native sql log backups. If this is not specified, we use the value specified in magneto_sql_num_streams_for_each_db_backup gflag..</param>
        /// <param name="logBackupWithClause">&#39;with_clause&#39; contains &#39;with clause&#39; to be used for log backups in native sql backup command. This is only applicable for native sql log backup. Here user can specify multiple backup options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_backup_with_clause gflag..</param>
        /// <param name="numDbsPerBatch">The number of databases to be backed up per batch. This is only applicable for file based sql backup. If this is not specified, we use the value specified in magneto_vss_sql_app_file_batch_size gflag..</param>
        /// <param name="numStreams">The number of streams to be used in native sql backup command. This is only applicable for native sql backup. If this is not specified, we use the value specified in magneto_sql_num_streams_for_each_db_backup gflag..</param>
        /// <param name="useAagPreferencesFromSqlServer">Set to true if we should use AAG preferences specified at the SQL server host..</param>
        /// <param name="userDbPreferenceType">Preference type for backing up user databases on the host..</param>
        /// <param name="withClause">&#39;with_clause&#39; contains &#39;with clause&#39; to be used in native sql backup command. This is only applicable for native sql backup. Here user can specify multiple backup options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_backup_with_clause gflag..</param>
        public SqlBackupJobParams(int? aagBackupPreferenceType = default(int?), bool? backupDatabaseVolumesOnly = default(bool?), bool? backupSystemDbs = default(bool?), bool? continueAfterError = default(bool?), bool? enableChecksum = default(bool?), bool? enableIncrementalBackupAfterRestart = default(bool?), int? fullBackupType = default(int?), bool? isCopyOnlyFull = default(bool?), bool? isCopyOnlyLog = default(bool?), int? logBackupNumStreams = default(int?), string logBackupWithClause = default(string), int? numDbsPerBatch = default(int?), int? numStreams = default(int?), bool? useAagPreferencesFromSqlServer = default(bool?), int? userDbPreferenceType = default(int?), string withClause = default(string))
        {
            this.AagBackupPreferenceType = aagBackupPreferenceType;
            this.BackupDatabaseVolumesOnly = backupDatabaseVolumesOnly;
            this.BackupSystemDbs = backupSystemDbs;
            this.ContinueAfterError = continueAfterError;
            this.EnableChecksum = enableChecksum;
            this.EnableIncrementalBackupAfterRestart = enableIncrementalBackupAfterRestart;
            this.FullBackupType = fullBackupType;
            this.IsCopyOnlyFull = isCopyOnlyFull;
            this.IsCopyOnlyLog = isCopyOnlyLog;
            this.LogBackupNumStreams = logBackupNumStreams;
            this.LogBackupWithClause = logBackupWithClause;
            this.NumDbsPerBatch = numDbsPerBatch;
            this.NumStreams = numStreams;
            this.UseAagPreferencesFromSqlServer = useAagPreferencesFromSqlServer;
            this.UserDbPreferenceType = userDbPreferenceType;
            this.WithClause = withClause;
        }
        
        /// <summary>
        /// Preference type for backing up databases that are part of an AAG. Only applicable if &#39;use_aag_preferences_from_sql_server&#39; is set to false.
        /// </summary>
        /// <value>Preference type for backing up databases that are part of an AAG. Only applicable if &#39;use_aag_preferences_from_sql_server&#39; is set to false.</value>
        [DataMember(Name="aagBackupPreferenceType", EmitDefaultValue=true)]
        public int? AagBackupPreferenceType { get; set; }

        /// <summary>
        /// If set to true, only the volumes associated with databases should be backed up. The user cannot select additional volumes at host level for backup.  If set to false, all the volumes on the host machine will be backed up. In this case, the user can further select the exact set of volumes using host level params.  Note that the volumes associated with selected databases will always be included in the backup.
        /// </summary>
        /// <value>If set to true, only the volumes associated with databases should be backed up. The user cannot select additional volumes at host level for backup.  If set to false, all the volumes on the host machine will be backed up. In this case, the user can further select the exact set of volumes using host level params.  Note that the volumes associated with selected databases will always be included in the backup.</value>
        [DataMember(Name="backupDatabaseVolumesOnly", EmitDefaultValue=true)]
        public bool? BackupDatabaseVolumesOnly { get; set; }

        /// <summary>
        /// Set to true if system databases should be backed up.
        /// </summary>
        /// <value>Set to true if system databases should be backed up.</value>
        [DataMember(Name="backupSystemDbs", EmitDefaultValue=true)]
        public bool? BackupSystemDbs { get; set; }

        /// <summary>
        /// Whether backup should continue after encountering a page checksum error.
        /// </summary>
        /// <value>Whether backup should continue after encountering a page checksum error.</value>
        [DataMember(Name="continueAfterError", EmitDefaultValue=true)]
        public bool? ContinueAfterError { get; set; }

        /// <summary>
        /// Whether backup checksums are enabled.
        /// </summary>
        /// <value>Whether backup checksums are enabled.</value>
        [DataMember(Name="enableChecksum", EmitDefaultValue=true)]
        public bool? EnableChecksum { get; set; }

        /// <summary>
        /// If this is set to true, then incremental backup will be performed after the server restarts, otherwise a full-backup will be done.
        /// </summary>
        /// <value>If this is set to true, then incremental backup will be performed after the server restarts, otherwise a full-backup will be done.</value>
        [DataMember(Name="enableIncrementalBackupAfterRestart", EmitDefaultValue=true)]
        public bool? EnableIncrementalBackupAfterRestart { get; set; }

        /// <summary>
        /// The type of SQL full backup to be used for this job.
        /// </summary>
        /// <value>The type of SQL full backup to be used for this job.</value>
        [DataMember(Name="fullBackupType", EmitDefaultValue=true)]
        public int? FullBackupType { get; set; }

        /// <summary>
        /// Whether full backups should be copy-only.
        /// </summary>
        /// <value>Whether full backups should be copy-only.</value>
        [DataMember(Name="isCopyOnlyFull", EmitDefaultValue=true)]
        public bool? IsCopyOnlyFull { get; set; }

        /// <summary>
        /// Whether log backups should be copy-only.
        /// </summary>
        /// <value>Whether log backups should be copy-only.</value>
        [DataMember(Name="isCopyOnlyLog", EmitDefaultValue=true)]
        public bool? IsCopyOnlyLog { get; set; }

        /// <summary>
        /// The number of streams to be used for log backups in native sql backup command. This is only applicable for native sql log backups. If this is not specified, we use the value specified in magneto_sql_num_streams_for_each_db_backup gflag.
        /// </summary>
        /// <value>The number of streams to be used for log backups in native sql backup command. This is only applicable for native sql log backups. If this is not specified, we use the value specified in magneto_sql_num_streams_for_each_db_backup gflag.</value>
        [DataMember(Name="logBackupNumStreams", EmitDefaultValue=true)]
        public int? LogBackupNumStreams { get; set; }

        /// <summary>
        /// &#39;with_clause&#39; contains &#39;with clause&#39; to be used for log backups in native sql backup command. This is only applicable for native sql log backup. Here user can specify multiple backup options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_backup_with_clause gflag.
        /// </summary>
        /// <value>&#39;with_clause&#39; contains &#39;with clause&#39; to be used for log backups in native sql backup command. This is only applicable for native sql log backup. Here user can specify multiple backup options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_backup_with_clause gflag.</value>
        [DataMember(Name="logBackupWithClause", EmitDefaultValue=true)]
        public string LogBackupWithClause { get; set; }

        /// <summary>
        /// The number of databases to be backed up per batch. This is only applicable for file based sql backup. If this is not specified, we use the value specified in magneto_vss_sql_app_file_batch_size gflag.
        /// </summary>
        /// <value>The number of databases to be backed up per batch. This is only applicable for file based sql backup. If this is not specified, we use the value specified in magneto_vss_sql_app_file_batch_size gflag.</value>
        [DataMember(Name="numDbsPerBatch", EmitDefaultValue=true)]
        public int? NumDbsPerBatch { get; set; }

        /// <summary>
        /// The number of streams to be used in native sql backup command. This is only applicable for native sql backup. If this is not specified, we use the value specified in magneto_sql_num_streams_for_each_db_backup gflag.
        /// </summary>
        /// <value>The number of streams to be used in native sql backup command. This is only applicable for native sql backup. If this is not specified, we use the value specified in magneto_sql_num_streams_for_each_db_backup gflag.</value>
        [DataMember(Name="numStreams", EmitDefaultValue=true)]
        public int? NumStreams { get; set; }

        /// <summary>
        /// Set to true if we should use AAG preferences specified at the SQL server host.
        /// </summary>
        /// <value>Set to true if we should use AAG preferences specified at the SQL server host.</value>
        [DataMember(Name="useAagPreferencesFromSqlServer", EmitDefaultValue=true)]
        public bool? UseAagPreferencesFromSqlServer { get; set; }

        /// <summary>
        /// Preference type for backing up user databases on the host.
        /// </summary>
        /// <value>Preference type for backing up user databases on the host.</value>
        [DataMember(Name="userDbPreferenceType", EmitDefaultValue=true)]
        public int? UserDbPreferenceType { get; set; }

        /// <summary>
        /// &#39;with_clause&#39; contains &#39;with clause&#39; to be used in native sql backup command. This is only applicable for native sql backup. Here user can specify multiple backup options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_backup_with_clause gflag.
        /// </summary>
        /// <value>&#39;with_clause&#39; contains &#39;with clause&#39; to be used in native sql backup command. This is only applicable for native sql backup. Here user can specify multiple backup options. Example: \&quot;WITH BUFFERCOUNT &#x3D; 575, MAXTRANSFERSIZE &#x3D; 2097152\&quot;. If this is not specified, we use the value specified in magneto_sql_native_backup_with_clause gflag.</value>
        [DataMember(Name="withClause", EmitDefaultValue=true)]
        public string WithClause { get; set; }

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
            return this.Equals(input as SqlBackupJobParams);
        }

        /// <summary>
        /// Returns true if SqlBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AagBackupPreferenceType == input.AagBackupPreferenceType ||
                    (this.AagBackupPreferenceType != null &&
                    this.AagBackupPreferenceType.Equals(input.AagBackupPreferenceType))
                ) && 
                (
                    this.BackupDatabaseVolumesOnly == input.BackupDatabaseVolumesOnly ||
                    (this.BackupDatabaseVolumesOnly != null &&
                    this.BackupDatabaseVolumesOnly.Equals(input.BackupDatabaseVolumesOnly))
                ) && 
                (
                    this.BackupSystemDbs == input.BackupSystemDbs ||
                    (this.BackupSystemDbs != null &&
                    this.BackupSystemDbs.Equals(input.BackupSystemDbs))
                ) && 
                (
                    this.ContinueAfterError == input.ContinueAfterError ||
                    (this.ContinueAfterError != null &&
                    this.ContinueAfterError.Equals(input.ContinueAfterError))
                ) && 
                (
                    this.EnableChecksum == input.EnableChecksum ||
                    (this.EnableChecksum != null &&
                    this.EnableChecksum.Equals(input.EnableChecksum))
                ) && 
                (
                    this.EnableIncrementalBackupAfterRestart == input.EnableIncrementalBackupAfterRestart ||
                    (this.EnableIncrementalBackupAfterRestart != null &&
                    this.EnableIncrementalBackupAfterRestart.Equals(input.EnableIncrementalBackupAfterRestart))
                ) && 
                (
                    this.FullBackupType == input.FullBackupType ||
                    (this.FullBackupType != null &&
                    this.FullBackupType.Equals(input.FullBackupType))
                ) && 
                (
                    this.IsCopyOnlyFull == input.IsCopyOnlyFull ||
                    (this.IsCopyOnlyFull != null &&
                    this.IsCopyOnlyFull.Equals(input.IsCopyOnlyFull))
                ) && 
                (
                    this.IsCopyOnlyLog == input.IsCopyOnlyLog ||
                    (this.IsCopyOnlyLog != null &&
                    this.IsCopyOnlyLog.Equals(input.IsCopyOnlyLog))
                ) && 
                (
                    this.LogBackupNumStreams == input.LogBackupNumStreams ||
                    (this.LogBackupNumStreams != null &&
                    this.LogBackupNumStreams.Equals(input.LogBackupNumStreams))
                ) && 
                (
                    this.LogBackupWithClause == input.LogBackupWithClause ||
                    (this.LogBackupWithClause != null &&
                    this.LogBackupWithClause.Equals(input.LogBackupWithClause))
                ) && 
                (
                    this.NumDbsPerBatch == input.NumDbsPerBatch ||
                    (this.NumDbsPerBatch != null &&
                    this.NumDbsPerBatch.Equals(input.NumDbsPerBatch))
                ) && 
                (
                    this.NumStreams == input.NumStreams ||
                    (this.NumStreams != null &&
                    this.NumStreams.Equals(input.NumStreams))
                ) && 
                (
                    this.UseAagPreferencesFromSqlServer == input.UseAagPreferencesFromSqlServer ||
                    (this.UseAagPreferencesFromSqlServer != null &&
                    this.UseAagPreferencesFromSqlServer.Equals(input.UseAagPreferencesFromSqlServer))
                ) && 
                (
                    this.UserDbPreferenceType == input.UserDbPreferenceType ||
                    (this.UserDbPreferenceType != null &&
                    this.UserDbPreferenceType.Equals(input.UserDbPreferenceType))
                ) && 
                (
                    this.WithClause == input.WithClause ||
                    (this.WithClause != null &&
                    this.WithClause.Equals(input.WithClause))
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
                if (this.AagBackupPreferenceType != null)
                    hashCode = hashCode * 59 + this.AagBackupPreferenceType.GetHashCode();
                if (this.BackupDatabaseVolumesOnly != null)
                    hashCode = hashCode * 59 + this.BackupDatabaseVolumesOnly.GetHashCode();
                if (this.BackupSystemDbs != null)
                    hashCode = hashCode * 59 + this.BackupSystemDbs.GetHashCode();
                if (this.ContinueAfterError != null)
                    hashCode = hashCode * 59 + this.ContinueAfterError.GetHashCode();
                if (this.EnableChecksum != null)
                    hashCode = hashCode * 59 + this.EnableChecksum.GetHashCode();
                if (this.EnableIncrementalBackupAfterRestart != null)
                    hashCode = hashCode * 59 + this.EnableIncrementalBackupAfterRestart.GetHashCode();
                if (this.FullBackupType != null)
                    hashCode = hashCode * 59 + this.FullBackupType.GetHashCode();
                if (this.IsCopyOnlyFull != null)
                    hashCode = hashCode * 59 + this.IsCopyOnlyFull.GetHashCode();
                if (this.IsCopyOnlyLog != null)
                    hashCode = hashCode * 59 + this.IsCopyOnlyLog.GetHashCode();
                if (this.LogBackupNumStreams != null)
                    hashCode = hashCode * 59 + this.LogBackupNumStreams.GetHashCode();
                if (this.LogBackupWithClause != null)
                    hashCode = hashCode * 59 + this.LogBackupWithClause.GetHashCode();
                if (this.NumDbsPerBatch != null)
                    hashCode = hashCode * 59 + this.NumDbsPerBatch.GetHashCode();
                if (this.NumStreams != null)
                    hashCode = hashCode * 59 + this.NumStreams.GetHashCode();
                if (this.UseAagPreferencesFromSqlServer != null)
                    hashCode = hashCode * 59 + this.UseAagPreferencesFromSqlServer.GetHashCode();
                if (this.UserDbPreferenceType != null)
                    hashCode = hashCode * 59 + this.UserDbPreferenceType.GetHashCode();
                if (this.WithClause != null)
                    hashCode = hashCode * 59 + this.WithClause.GetHashCode();
                return hashCode;
            }
        }

    }

}

