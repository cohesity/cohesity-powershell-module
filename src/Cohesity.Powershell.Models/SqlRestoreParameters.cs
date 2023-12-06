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
    /// Specifies the parameters specific the Application Server instance.
    /// </summary>
    [DataContract]
    public partial class SqlRestoreParameters :  IEquatable<SqlRestoreParameters>
    {
        /// <summary>
        /// Overwrite Policy specifies a policy to be used while recovering existing databases. Specifies the policy to be used while recovering existing databases. &#39;kFailIfExists&#39; refers to a policy to fail if DB exists already. &#39;kOverwrite&#39; refres to the policy to overwrite existing DB.
        /// </summary>
        /// <value>Overwrite Policy specifies a policy to be used while recovering existing databases. Specifies the policy to be used while recovering existing databases. &#39;kFailIfExists&#39; refers to a policy to fail if DB exists already. &#39;kOverwrite&#39; refres to the policy to overwrite existing DB.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OverwritePolicyEnum
        {
            /// <summary>
            /// Enum KFailIfExists for value: kFailIfExists
            /// </summary>
            [EnumMember(Value = "kFailIfExists")]
            KFailIfExists = 1,

            /// <summary>
            /// Enum KOverwrite for value: kOverwrite
            /// </summary>
            [EnumMember(Value = "kOverwrite")]
            KOverwrite = 2

        }

        /// <summary>
        /// Overwrite Policy specifies a policy to be used while recovering existing databases. Specifies the policy to be used while recovering existing databases. &#39;kFailIfExists&#39; refers to a policy to fail if DB exists already. &#39;kOverwrite&#39; refres to the policy to overwrite existing DB.
        /// </summary>
        /// <value>Overwrite Policy specifies a policy to be used while recovering existing databases. Specifies the policy to be used while recovering existing databases. &#39;kFailIfExists&#39; refers to a policy to fail if DB exists already. &#39;kOverwrite&#39; refres to the policy to overwrite existing DB.</value>
        [DataMember(Name="overwritePolicy", EmitDefaultValue=true)]
        public OverwritePolicyEnum? OverwritePolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlRestoreParameters" /> class.
        /// </summary>
        /// <param name="captureTailLogs">Set this to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its hosting Protection Source, and the database is not being renamed..</param>
        /// <param name="isAutoSyncEnabled">This field determines if Auto Sync enabled/disabled for SQL Multi-stage Restore task.</param>
        /// <param name="keepCdc">This field prevents \&quot;change data capture\&quot; settings from being reomved when a database or log backup is restored on another server and database is recovered..</param>
        /// <param name="keepOffline">Set this to true if we want to restore the database and do not want to bring it online after restore.  This is only applicable if we are restoring the database back to its original location..</param>
        /// <param name="newDatabaseName">Specifies optionally a new name for the restored database..</param>
        /// <param name="newInstanceName">Specifies an instance name of the SQL Server that should be restored. SQL application has many instances. Each instance has a unique name. One of the instances that should be restored must be set in this field..</param>
        /// <param name="overwritePolicy">Overwrite Policy specifies a policy to be used while recovering existing databases. Specifies the policy to be used while recovering existing databases. &#39;kFailIfExists&#39; refers to a policy to fail if DB exists already. &#39;kOverwrite&#39; refres to the policy to overwrite existing DB..</param>
        /// <param name="restoreTimeSecs">Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be restored from the full/incremental snapshot..</param>
        /// <param name="targetDataFilesDirectory">Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host..</param>
        /// <param name="targetLogFilesDirectory">Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host..</param>
        /// <param name="targetSecondaryDataFilesDirectoryList">Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data files are optional and are user defined. The recommended file extension for secondary files is \&quot;.ndf\&quot;.  If this option is specified and the destination folders do not exist they will be automatically created..</param>
        /// <param name="withClause">WithClause allows you to specify clauses to be used in native sql restore task..</param>
        public SqlRestoreParameters(bool? captureTailLogs = default(bool?), bool? isAutoSyncEnabled = default(bool?), bool? keepCdc = default(bool?), bool? keepOffline = default(bool?), string newDatabaseName = default(string), string newInstanceName = default(string), OverwritePolicyEnum? overwritePolicy = default(OverwritePolicyEnum?), long? restoreTimeSecs = default(long?), string targetDataFilesDirectory = default(string), string targetLogFilesDirectory = default(string), List<FilenamePatternToDirectory> targetSecondaryDataFilesDirectoryList = default(List<FilenamePatternToDirectory>), string withClause = default(string))
        {
            this.CaptureTailLogs = captureTailLogs;
            this.IsAutoSyncEnabled = isAutoSyncEnabled;
            this.KeepCdc = keepCdc;
            this.KeepOffline = keepOffline;
            this.NewDatabaseName = newDatabaseName;
            this.NewInstanceName = newInstanceName;
            this.OverwritePolicy = overwritePolicy;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.TargetDataFilesDirectory = targetDataFilesDirectory;
            this.TargetLogFilesDirectory = targetLogFilesDirectory;
            this.TargetSecondaryDataFilesDirectoryList = targetSecondaryDataFilesDirectoryList;
            this.WithClause = withClause;
            this.CaptureTailLogs = captureTailLogs;
            this.IsAutoSyncEnabled = isAutoSyncEnabled;
            this.KeepCdc = keepCdc;
            this.KeepOffline = keepOffline;
            this.NewDatabaseName = newDatabaseName;
            this.NewInstanceName = newInstanceName;
            this.OverwritePolicy = overwritePolicy;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.TargetDataFilesDirectory = targetDataFilesDirectory;
            this.TargetLogFilesDirectory = targetLogFilesDirectory;
            this.TargetSecondaryDataFilesDirectoryList = targetSecondaryDataFilesDirectoryList;
            this.WithClause = withClause;
        }
        
        /// <summary>
        /// Set this to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its hosting Protection Source, and the database is not being renamed.
        /// </summary>
        /// <value>Set this to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its hosting Protection Source, and the database is not being renamed.</value>
        [DataMember(Name="captureTailLogs", EmitDefaultValue=true)]
        public bool? CaptureTailLogs { get; set; }

        /// <summary>
        /// This field determines if Auto Sync enabled/disabled for SQL Multi-stage Restore task
        /// </summary>
        /// <value>This field determines if Auto Sync enabled/disabled for SQL Multi-stage Restore task</value>
        [DataMember(Name="isAutoSyncEnabled", EmitDefaultValue=true)]
        public bool? IsAutoSyncEnabled { get; set; }

        /// <summary>
        /// This field prevents \&quot;change data capture\&quot; settings from being reomved when a database or log backup is restored on another server and database is recovered.
        /// </summary>
        /// <value>This field prevents \&quot;change data capture\&quot; settings from being reomved when a database or log backup is restored on another server and database is recovered.</value>
        [DataMember(Name="keepCdc", EmitDefaultValue=true)]
        public bool? KeepCdc { get; set; }

        /// <summary>
        /// Set this to true if we want to restore the database and do not want to bring it online after restore.  This is only applicable if we are restoring the database back to its original location.
        /// </summary>
        /// <value>Set this to true if we want to restore the database and do not want to bring it online after restore.  This is only applicable if we are restoring the database back to its original location.</value>
        [DataMember(Name="keepOffline", EmitDefaultValue=true)]
        public bool? KeepOffline { get; set; }

        /// <summary>
        /// Specifies optionally a new name for the restored database.
        /// </summary>
        /// <value>Specifies optionally a new name for the restored database.</value>
        [DataMember(Name="newDatabaseName", EmitDefaultValue=true)]
        public string NewDatabaseName { get; set; }

        /// <summary>
        /// Specifies an instance name of the SQL Server that should be restored. SQL application has many instances. Each instance has a unique name. One of the instances that should be restored must be set in this field.
        /// </summary>
        /// <value>Specifies an instance name of the SQL Server that should be restored. SQL application has many instances. Each instance has a unique name. One of the instances that should be restored must be set in this field.</value>
        [DataMember(Name="newInstanceName", EmitDefaultValue=true)]
        public string NewInstanceName { get; set; }

        /// <summary>
        /// Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be restored from the full/incremental snapshot.
        /// </summary>
        /// <value>Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be restored from the full/incremental snapshot.</value>
        [DataMember(Name="restoreTimeSecs", EmitDefaultValue=true)]
        public long? RestoreTimeSecs { get; set; }

        /// <summary>
        /// Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host.
        /// </summary>
        /// <value>Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host.</value>
        [DataMember(Name="targetDataFilesDirectory", EmitDefaultValue=true)]
        public string TargetDataFilesDirectory { get; set; }

        /// <summary>
        /// Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host.
        /// </summary>
        /// <value>Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host.</value>
        [DataMember(Name="targetLogFilesDirectory", EmitDefaultValue=true)]
        public string TargetLogFilesDirectory { get; set; }

        /// <summary>
        /// Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data files are optional and are user defined. The recommended file extension for secondary files is \&quot;.ndf\&quot;.  If this option is specified and the destination folders do not exist they will be automatically created.
        /// </summary>
        /// <value>Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data files are optional and are user defined. The recommended file extension for secondary files is \&quot;.ndf\&quot;.  If this option is specified and the destination folders do not exist they will be automatically created.</value>
        [DataMember(Name="targetSecondaryDataFilesDirectoryList", EmitDefaultValue=true)]
        public List<FilenamePatternToDirectory> TargetSecondaryDataFilesDirectoryList { get; set; }

        /// <summary>
        /// WithClause allows you to specify clauses to be used in native sql restore task.
        /// </summary>
        /// <value>WithClause allows you to specify clauses to be used in native sql restore task.</value>
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
            return this.Equals(input as SqlRestoreParameters);
        }

        /// <summary>
        /// Returns true if SqlRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlRestoreParameters input)
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
                    this.IsAutoSyncEnabled == input.IsAutoSyncEnabled ||
                    (this.IsAutoSyncEnabled != null &&
                    this.IsAutoSyncEnabled.Equals(input.IsAutoSyncEnabled))
                ) && 
                (
                    this.KeepCdc == input.KeepCdc ||
                    (this.KeepCdc != null &&
                    this.KeepCdc.Equals(input.KeepCdc))
                ) && 
                (
                    this.KeepOffline == input.KeepOffline ||
                    (this.KeepOffline != null &&
                    this.KeepOffline.Equals(input.KeepOffline))
                ) && 
                (
                    this.NewDatabaseName == input.NewDatabaseName ||
                    (this.NewDatabaseName != null &&
                    this.NewDatabaseName.Equals(input.NewDatabaseName))
                ) && 
                (
                    this.NewInstanceName == input.NewInstanceName ||
                    (this.NewInstanceName != null &&
                    this.NewInstanceName.Equals(input.NewInstanceName))
                ) && 
                (
                    this.OverwritePolicy == input.OverwritePolicy ||
                    this.OverwritePolicy.Equals(input.OverwritePolicy)
                ) && 
                (
                    this.RestoreTimeSecs == input.RestoreTimeSecs ||
                    (this.RestoreTimeSecs != null &&
                    this.RestoreTimeSecs.Equals(input.RestoreTimeSecs))
                ) && 
                (
                    this.TargetDataFilesDirectory == input.TargetDataFilesDirectory ||
                    (this.TargetDataFilesDirectory != null &&
                    this.TargetDataFilesDirectory.Equals(input.TargetDataFilesDirectory))
                ) && 
                (
                    this.TargetLogFilesDirectory == input.TargetLogFilesDirectory ||
                    (this.TargetLogFilesDirectory != null &&
                    this.TargetLogFilesDirectory.Equals(input.TargetLogFilesDirectory))
                ) && 
                (
                    this.TargetSecondaryDataFilesDirectoryList == input.TargetSecondaryDataFilesDirectoryList ||
                    this.TargetSecondaryDataFilesDirectoryList != null &&
                    input.TargetSecondaryDataFilesDirectoryList != null &&
                    this.TargetSecondaryDataFilesDirectoryList.SequenceEqual(input.TargetSecondaryDataFilesDirectoryList)
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
                if (this.CaptureTailLogs != null)
                    hashCode = hashCode * 59 + this.CaptureTailLogs.GetHashCode();
                if (this.IsAutoSyncEnabled != null)
                    hashCode = hashCode * 59 + this.IsAutoSyncEnabled.GetHashCode();
                if (this.KeepCdc != null)
                    hashCode = hashCode * 59 + this.KeepCdc.GetHashCode();
                if (this.KeepOffline != null)
                    hashCode = hashCode * 59 + this.KeepOffline.GetHashCode();
                if (this.NewDatabaseName != null)
                    hashCode = hashCode * 59 + this.NewDatabaseName.GetHashCode();
                if (this.NewInstanceName != null)
                    hashCode = hashCode * 59 + this.NewInstanceName.GetHashCode();
                hashCode = hashCode * 59 + this.OverwritePolicy.GetHashCode();
                if (this.RestoreTimeSecs != null)
                    hashCode = hashCode * 59 + this.RestoreTimeSecs.GetHashCode();
                if (this.TargetDataFilesDirectory != null)
                    hashCode = hashCode * 59 + this.TargetDataFilesDirectory.GetHashCode();
                if (this.TargetLogFilesDirectory != null)
                    hashCode = hashCode * 59 + this.TargetLogFilesDirectory.GetHashCode();
                if (this.TargetSecondaryDataFilesDirectoryList != null)
                    hashCode = hashCode * 59 + this.TargetSecondaryDataFilesDirectoryList.GetHashCode();
                if (this.WithClause != null)
                    hashCode = hashCode * 59 + this.WithClause.GetHashCode();
                return hashCode;
            }
        }

    }

}

