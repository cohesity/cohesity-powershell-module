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
    /// Specifies job parameters applicable for all &#39;kSQL&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class SqlEnvJobParameters :  IEquatable<SqlEnvJobParameters>
    {
        /// <summary>
        /// Specifies the preference for backing up databases that are part of an AAG. Only applicable if &#39;aagPreferenceFromSqlServer&#39; is set to false or not given. kPrimaryReplicaOnly implies backups should always occur on the primary replica. kSecondaryReplicaOnly implies backups should always occur on the secondary replica. kPreferSecondaryReplica implies secondary replica is preferred for backups. kAnyReplica implies no preference of about whether backups are performed on the primary replica or on a secondary replica. If no secondary replica is available, then performing backups on the primary replica is acceptable.
        /// </summary>
        /// <value>Specifies the preference for backing up databases that are part of an AAG. Only applicable if &#39;aagPreferenceFromSqlServer&#39; is set to false or not given. kPrimaryReplicaOnly implies backups should always occur on the primary replica. kSecondaryReplicaOnly implies backups should always occur on the secondary replica. kPreferSecondaryReplica implies secondary replica is preferred for backups. kAnyReplica implies no preference of about whether backups are performed on the primary replica or on a secondary replica. If no secondary replica is available, then performing backups on the primary replica is acceptable.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AagPreferenceEnum
        {
            /// <summary>
            /// Enum KPrimaryReplicaOnly for value: kPrimaryReplicaOnly
            /// </summary>
            [EnumMember(Value = "kPrimaryReplicaOnly")]
            KPrimaryReplicaOnly = 1,

            /// <summary>
            /// Enum KSecondaryReplicaOnly for value: kSecondaryReplicaOnly
            /// </summary>
            [EnumMember(Value = "kSecondaryReplicaOnly")]
            KSecondaryReplicaOnly = 2,

            /// <summary>
            /// Enum KPreferSecondaryReplica for value: kPreferSecondaryReplica
            /// </summary>
            [EnumMember(Value = "kPreferSecondaryReplica")]
            KPreferSecondaryReplica = 3,

            /// <summary>
            /// Enum KAnyReplica for value: kAnyReplica
            /// </summary>
            [EnumMember(Value = "kAnyReplica")]
            KAnyReplica = 4

        }

        /// <summary>
        /// Specifies the preference for backing up databases that are part of an AAG. Only applicable if &#39;aagPreferenceFromSqlServer&#39; is set to false or not given. kPrimaryReplicaOnly implies backups should always occur on the primary replica. kSecondaryReplicaOnly implies backups should always occur on the secondary replica. kPreferSecondaryReplica implies secondary replica is preferred for backups. kAnyReplica implies no preference of about whether backups are performed on the primary replica or on a secondary replica. If no secondary replica is available, then performing backups on the primary replica is acceptable.
        /// </summary>
        /// <value>Specifies the preference for backing up databases that are part of an AAG. Only applicable if &#39;aagPreferenceFromSqlServer&#39; is set to false or not given. kPrimaryReplicaOnly implies backups should always occur on the primary replica. kSecondaryReplicaOnly implies backups should always occur on the secondary replica. kPreferSecondaryReplica implies secondary replica is preferred for backups. kAnyReplica implies no preference of about whether backups are performed on the primary replica or on a secondary replica. If no secondary replica is available, then performing backups on the primary replica is acceptable.</value>
        [DataMember(Name="aagPreference", EmitDefaultValue=true)]
        public AagPreferenceEnum? AagPreference { get; set; }
        /// <summary>
        /// Specifies the type of the &#39;kFull&#39; backup job. Specifies whether it is Volume level backup or individual files level backup. kSqlVSSVolume implies volume based VSS full backup. kSqlVSSFile implies file based VSS full backup.
        /// </summary>
        /// <value>Specifies the type of the &#39;kFull&#39; backup job. Specifies whether it is Volume level backup or individual files level backup. kSqlVSSVolume implies volume based VSS full backup. kSqlVSSFile implies file based VSS full backup.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackupTypeEnum
        {
            /// <summary>
            /// Enum KSqlVSSVolume for value: kSqlVSSVolume
            /// </summary>
            [EnumMember(Value = "kSqlVSSVolume")]
            KSqlVSSVolume = 1,

            /// <summary>
            /// Enum KSqlVSSFile for value: kSqlVSSFile
            /// </summary>
            [EnumMember(Value = "kSqlVSSFile")]
            KSqlVSSFile = 2,

            /// <summary>
            /// Enum KSqlNative for value: kSqlNative
            /// </summary>
            [EnumMember(Value = "kSqlNative")]
            KSqlNative = 3

        }

        /// <summary>
        /// Specifies the type of the &#39;kFull&#39; backup job. Specifies whether it is Volume level backup or individual files level backup. kSqlVSSVolume implies volume based VSS full backup. kSqlVSSFile implies file based VSS full backup.
        /// </summary>
        /// <value>Specifies the type of the &#39;kFull&#39; backup job. Specifies whether it is Volume level backup or individual files level backup. kSqlVSSVolume implies volume based VSS full backup. kSqlVSSFile implies file based VSS full backup.</value>
        [DataMember(Name="backupType", EmitDefaultValue=true)]
        public BackupTypeEnum? BackupType { get; set; }
        /// <summary>
        /// Specifies the preference for backing up user databases on the host. kBackupAllDatabases implies to backup all databases. kBackupAllExceptAAGDatabases implies not to backup AAG databases. kBackupOnlyAAGDatabases implies to backup only AAG databases.
        /// </summary>
        /// <value>Specifies the preference for backing up user databases on the host. kBackupAllDatabases implies to backup all databases. kBackupAllExceptAAGDatabases implies not to backup AAG databases. kBackupOnlyAAGDatabases implies to backup only AAG databases.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UserDatabasePreferenceEnum
        {
            /// <summary>
            /// Enum KBackupAllDatabases for value: kBackupAllDatabases
            /// </summary>
            [EnumMember(Value = "kBackupAllDatabases")]
            KBackupAllDatabases = 1,

            /// <summary>
            /// Enum KBackupAllExceptAAGDatabases for value: kBackupAllExceptAAGDatabases
            /// </summary>
            [EnumMember(Value = "kBackupAllExceptAAGDatabases")]
            KBackupAllExceptAAGDatabases = 2,

            /// <summary>
            /// Enum KBackupOnlyAAGDatabases for value: kBackupOnlyAAGDatabases
            /// </summary>
            [EnumMember(Value = "kBackupOnlyAAGDatabases")]
            KBackupOnlyAAGDatabases = 3

        }

        /// <summary>
        /// Specifies the preference for backing up user databases on the host. kBackupAllDatabases implies to backup all databases. kBackupAllExceptAAGDatabases implies not to backup AAG databases. kBackupOnlyAAGDatabases implies to backup only AAG databases.
        /// </summary>
        /// <value>Specifies the preference for backing up user databases on the host. kBackupAllDatabases implies to backup all databases. kBackupAllExceptAAGDatabases implies not to backup AAG databases. kBackupOnlyAAGDatabases implies to backup only AAG databases.</value>
        [DataMember(Name="userDatabasePreference", EmitDefaultValue=true)]
        public UserDatabasePreferenceEnum? UserDatabasePreference { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEnvJobParameters" /> class.
        /// </summary>
        /// <param name="aagPreference">Specifies the preference for backing up databases that are part of an AAG. Only applicable if &#39;aagPreferenceFromSqlServer&#39; is set to false or not given. kPrimaryReplicaOnly implies backups should always occur on the primary replica. kSecondaryReplicaOnly implies backups should always occur on the secondary replica. kPreferSecondaryReplica implies secondary replica is preferred for backups. kAnyReplica implies no preference of about whether backups are performed on the primary replica or on a secondary replica. If no secondary replica is available, then performing backups on the primary replica is acceptable..</param>
        /// <param name="aagPreferenceFromSqlServer">If true, AAG preferences are taken from the SQL server host. If this is set to false or not given, preferences can be overridden by aagBackupPreference..</param>
        /// <param name="backupSystemDatabases">If true, system databases are backed up. If this is set to false, system databases are not backed up. If this field is not specified, default value is true..</param>
        /// <param name="backupType">Specifies the type of the &#39;kFull&#39; backup job. Specifies whether it is Volume level backup or individual files level backup. kSqlVSSVolume implies volume based VSS full backup. kSqlVSSFile implies file based VSS full backup..</param>
        /// <param name="backupVolumesOnly">If set to true, only the volumes associated with databases should be backed up. The user cannot select additional volumes at host level for backup.  If set to false, all the volumes on the host machine will be backed up. In this case, the user can further select the exact set of volumes using host level params.  Note that the volumes associated with selected databases will always be included in the backup..</param>
        /// <param name="incrementalSnapshotUponRestart">If true, the backup of type kSqlVssVolume will be incremental after restart.</param>
        /// <param name="isCopyOnlyFull">If true, the backup is a full backup with the copy-only option specified..</param>
        /// <param name="numStreams">Number of streams to be used in native sql backup..</param>
        /// <param name="userDatabasePreference">Specifies the preference for backing up user databases on the host. kBackupAllDatabases implies to backup all databases. kBackupAllExceptAAGDatabases implies not to backup AAG databases. kBackupOnlyAAGDatabases implies to backup only AAG databases..</param>
        /// <param name="withClause">With clause is used for setting clauese in native sql backup..</param>
        public SqlEnvJobParameters(AagPreferenceEnum? aagPreference = default(AagPreferenceEnum?), bool? aagPreferenceFromSqlServer = default(bool?), bool? backupSystemDatabases = default(bool?), BackupTypeEnum? backupType = default(BackupTypeEnum?), bool? backupVolumesOnly = default(bool?), bool? incrementalSnapshotUponRestart = default(bool?), bool? isCopyOnlyFull = default(bool?), int? numStreams = default(int?), UserDatabasePreferenceEnum? userDatabasePreference = default(UserDatabasePreferenceEnum?), string withClause = default(string))
        {
            this.AagPreference = aagPreference;
            this.AagPreferenceFromSqlServer = aagPreferenceFromSqlServer;
            this.BackupSystemDatabases = backupSystemDatabases;
            this.BackupType = backupType;
            this.BackupVolumesOnly = backupVolumesOnly;
            this.IncrementalSnapshotUponRestart = incrementalSnapshotUponRestart;
            this.IsCopyOnlyFull = isCopyOnlyFull;
            this.NumStreams = numStreams;
            this.UserDatabasePreference = userDatabasePreference;
            this.WithClause = withClause;
            this.AagPreference = aagPreference;
            this.AagPreferenceFromSqlServer = aagPreferenceFromSqlServer;
            this.BackupSystemDatabases = backupSystemDatabases;
            this.BackupType = backupType;
            this.BackupVolumesOnly = backupVolumesOnly;
            this.IncrementalSnapshotUponRestart = incrementalSnapshotUponRestart;
            this.IsCopyOnlyFull = isCopyOnlyFull;
            this.NumStreams = numStreams;
            this.UserDatabasePreference = userDatabasePreference;
            this.WithClause = withClause;
        }
        
        /// <summary>
        /// If true, AAG preferences are taken from the SQL server host. If this is set to false or not given, preferences can be overridden by aagBackupPreference.
        /// </summary>
        /// <value>If true, AAG preferences are taken from the SQL server host. If this is set to false or not given, preferences can be overridden by aagBackupPreference.</value>
        [DataMember(Name="aagPreferenceFromSqlServer", EmitDefaultValue=true)]
        public bool? AagPreferenceFromSqlServer { get; set; }

        /// <summary>
        /// If true, system databases are backed up. If this is set to false, system databases are not backed up. If this field is not specified, default value is true.
        /// </summary>
        /// <value>If true, system databases are backed up. If this is set to false, system databases are not backed up. If this field is not specified, default value is true.</value>
        [DataMember(Name="backupSystemDatabases", EmitDefaultValue=true)]
        public bool? BackupSystemDatabases { get; set; }

        /// <summary>
        /// If set to true, only the volumes associated with databases should be backed up. The user cannot select additional volumes at host level for backup.  If set to false, all the volumes on the host machine will be backed up. In this case, the user can further select the exact set of volumes using host level params.  Note that the volumes associated with selected databases will always be included in the backup.
        /// </summary>
        /// <value>If set to true, only the volumes associated with databases should be backed up. The user cannot select additional volumes at host level for backup.  If set to false, all the volumes on the host machine will be backed up. In this case, the user can further select the exact set of volumes using host level params.  Note that the volumes associated with selected databases will always be included in the backup.</value>
        [DataMember(Name="backupVolumesOnly", EmitDefaultValue=true)]
        public bool? BackupVolumesOnly { get; set; }

        /// <summary>
        /// If true, the backup of type kSqlVssVolume will be incremental after restart
        /// </summary>
        /// <value>If true, the backup of type kSqlVssVolume will be incremental after restart</value>
        [DataMember(Name="incrementalSnapshotUponRestart", EmitDefaultValue=true)]
        public bool? IncrementalSnapshotUponRestart { get; set; }

        /// <summary>
        /// If true, the backup is a full backup with the copy-only option specified.
        /// </summary>
        /// <value>If true, the backup is a full backup with the copy-only option specified.</value>
        [DataMember(Name="isCopyOnlyFull", EmitDefaultValue=true)]
        public bool? IsCopyOnlyFull { get; set; }

        /// <summary>
        /// Number of streams to be used in native sql backup.
        /// </summary>
        /// <value>Number of streams to be used in native sql backup.</value>
        [DataMember(Name="numStreams", EmitDefaultValue=true)]
        public int? NumStreams { get; set; }

        /// <summary>
        /// With clause is used for setting clauese in native sql backup.
        /// </summary>
        /// <value>With clause is used for setting clauese in native sql backup.</value>
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
            return this.Equals(input as SqlEnvJobParameters);
        }

        /// <summary>
        /// Returns true if SqlEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AagPreference == input.AagPreference ||
                    this.AagPreference.Equals(input.AagPreference)
                ) && 
                (
                    this.AagPreferenceFromSqlServer == input.AagPreferenceFromSqlServer ||
                    (this.AagPreferenceFromSqlServer != null &&
                    this.AagPreferenceFromSqlServer.Equals(input.AagPreferenceFromSqlServer))
                ) && 
                (
                    this.BackupSystemDatabases == input.BackupSystemDatabases ||
                    (this.BackupSystemDatabases != null &&
                    this.BackupSystemDatabases.Equals(input.BackupSystemDatabases))
                ) && 
                (
                    this.BackupType == input.BackupType ||
                    this.BackupType.Equals(input.BackupType)
                ) && 
                (
                    this.BackupVolumesOnly == input.BackupVolumesOnly ||
                    (this.BackupVolumesOnly != null &&
                    this.BackupVolumesOnly.Equals(input.BackupVolumesOnly))
                ) && 
                (
                    this.IncrementalSnapshotUponRestart == input.IncrementalSnapshotUponRestart ||
                    (this.IncrementalSnapshotUponRestart != null &&
                    this.IncrementalSnapshotUponRestart.Equals(input.IncrementalSnapshotUponRestart))
                ) && 
                (
                    this.IsCopyOnlyFull == input.IsCopyOnlyFull ||
                    (this.IsCopyOnlyFull != null &&
                    this.IsCopyOnlyFull.Equals(input.IsCopyOnlyFull))
                ) && 
                (
                    this.NumStreams == input.NumStreams ||
                    (this.NumStreams != null &&
                    this.NumStreams.Equals(input.NumStreams))
                ) && 
                (
                    this.UserDatabasePreference == input.UserDatabasePreference ||
                    this.UserDatabasePreference.Equals(input.UserDatabasePreference)
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
                hashCode = hashCode * 59 + this.AagPreference.GetHashCode();
                if (this.AagPreferenceFromSqlServer != null)
                    hashCode = hashCode * 59 + this.AagPreferenceFromSqlServer.GetHashCode();
                if (this.BackupSystemDatabases != null)
                    hashCode = hashCode * 59 + this.BackupSystemDatabases.GetHashCode();
                hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.BackupVolumesOnly != null)
                    hashCode = hashCode * 59 + this.BackupVolumesOnly.GetHashCode();
                if (this.IncrementalSnapshotUponRestart != null)
                    hashCode = hashCode * 59 + this.IncrementalSnapshotUponRestart.GetHashCode();
                if (this.IsCopyOnlyFull != null)
                    hashCode = hashCode * 59 + this.IsCopyOnlyFull.GetHashCode();
                if (this.NumStreams != null)
                    hashCode = hashCode * 59 + this.NumStreams.GetHashCode();
                hashCode = hashCode * 59 + this.UserDatabasePreference.GetHashCode();
                if (this.WithClause != null)
                    hashCode = hashCode * 59 + this.WithClause.GetHashCode();
                return hashCode;
            }
        }

    }

}

