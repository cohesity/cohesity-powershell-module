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
        /// <param name="fullBackupType">The type of SQL full backup to be used for this job..</param>
        /// <param name="isCopyOnlyFull">Whether full backups should be copy-only..</param>
        /// <param name="useAagPreferencesFromSqlServer">Set to true if we should use AAG preferences specified at the SQL server host..</param>
        /// <param name="userDbPreferenceType">Preference type for backing up user databases on the host..</param>
        public SqlBackupJobParams(int? aagBackupPreferenceType = default(int?), bool? backupDatabaseVolumesOnly = default(bool?), bool? backupSystemDbs = default(bool?), int? fullBackupType = default(int?), bool? isCopyOnlyFull = default(bool?), bool? useAagPreferencesFromSqlServer = default(bool?), int? userDbPreferenceType = default(int?))
        {
            this.AagBackupPreferenceType = aagBackupPreferenceType;
            this.BackupDatabaseVolumesOnly = backupDatabaseVolumesOnly;
            this.BackupSystemDbs = backupSystemDbs;
            this.FullBackupType = fullBackupType;
            this.IsCopyOnlyFull = isCopyOnlyFull;
            this.UseAagPreferencesFromSqlServer = useAagPreferencesFromSqlServer;
            this.UserDbPreferenceType = userDbPreferenceType;
            this.AagBackupPreferenceType = aagBackupPreferenceType;
            this.BackupDatabaseVolumesOnly = backupDatabaseVolumesOnly;
            this.BackupSystemDbs = backupSystemDbs;
            this.FullBackupType = fullBackupType;
            this.IsCopyOnlyFull = isCopyOnlyFull;
            this.UseAagPreferencesFromSqlServer = useAagPreferencesFromSqlServer;
            this.UserDbPreferenceType = userDbPreferenceType;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlBackupJobParams {\n");
            sb.Append("  AagBackupPreferenceType: ").Append(AagBackupPreferenceType).Append("\n");
            sb.Append("  BackupDatabaseVolumesOnly: ").Append(BackupDatabaseVolumesOnly).Append("\n");
            sb.Append("  BackupSystemDbs: ").Append(BackupSystemDbs).Append("\n");
            sb.Append("  FullBackupType: ").Append(FullBackupType).Append("\n");
            sb.Append("  IsCopyOnlyFull: ").Append(IsCopyOnlyFull).Append("\n");
            sb.Append("  UseAagPreferencesFromSqlServer: ").Append(UseAagPreferencesFromSqlServer).Append("\n");
            sb.Append("  UserDbPreferenceType: ").Append(UserDbPreferenceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
                    this.UseAagPreferencesFromSqlServer == input.UseAagPreferencesFromSqlServer ||
                    (this.UseAagPreferencesFromSqlServer != null &&
                    this.UseAagPreferencesFromSqlServer.Equals(input.UseAagPreferencesFromSqlServer))
                ) && 
                (
                    this.UserDbPreferenceType == input.UserDbPreferenceType ||
                    (this.UserDbPreferenceType != null &&
                    this.UserDbPreferenceType.Equals(input.UserDbPreferenceType))
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
                if (this.FullBackupType != null)
                    hashCode = hashCode * 59 + this.FullBackupType.GetHashCode();
                if (this.IsCopyOnlyFull != null)
                    hashCode = hashCode * 59 + this.IsCopyOnlyFull.GetHashCode();
                if (this.UseAagPreferencesFromSqlServer != null)
                    hashCode = hashCode * 59 + this.UseAagPreferencesFromSqlServer.GetHashCode();
                if (this.UserDbPreferenceType != null)
                    hashCode = hashCode * 59 + this.UserDbPreferenceType.GetHashCode();
                return hashCode;
            }
        }

    }

}
