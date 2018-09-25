// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the parameters specific the Application Server instance.
    /// </summary>
    [DataContract]
    public partial class SqlRestoreParameters :  IEquatable<SqlRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlRestoreParameters" /> class.
        /// </summary>
        /// <param name="captureTailLogs">Set this to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its hosting Protection Source, and the database is not being renamed..</param>
        /// <param name="keepOffline">Set this to true if we want to restore the database and do not want to bring it online after restore.  This is only applicable if we are restoring the database back to its original location..</param>
        /// <param name="newDatabaseName">Specifies optionally a new name for the restored database..</param>
        /// <param name="newInstanceName">Specifies an instance name of the SQL Server that should be restored. SQL application has many instances. Each instance has a unique name. One of the instances that should be restored must be set in this field..</param>
        /// <param name="restoreTimeSecs">Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be restored from the full/incremental snapshot..</param>
        /// <param name="targetDataFilesDirectory">Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host..</param>
        /// <param name="targetLogFilesDirectory">Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host..</param>
        /// <param name="targetSecondaryDataFilesDirectoryList">If this option is specified and the destination folders do not exist they will be automatically created..</param>
        public SqlRestoreParameters(bool? captureTailLogs = default(bool?), bool? keepOffline = default(bool?), string newDatabaseName = default(string), string newInstanceName = default(string), long? restoreTimeSecs = default(long?), string targetDataFilesDirectory = default(string), string targetLogFilesDirectory = default(string), List<FilenamePatternToDirectory> targetSecondaryDataFilesDirectoryList = default(List<FilenamePatternToDirectory>))
        {
            this.CaptureTailLogs = captureTailLogs;
            this.KeepOffline = keepOffline;
            this.NewDatabaseName = newDatabaseName;
            this.NewInstanceName = newInstanceName;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.TargetDataFilesDirectory = targetDataFilesDirectory;
            this.TargetLogFilesDirectory = targetLogFilesDirectory;
            this.TargetSecondaryDataFilesDirectoryList = targetSecondaryDataFilesDirectoryList;
        }
        
        /// <summary>
        /// Set this to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its hosting Protection Source, and the database is not being renamed.
        /// </summary>
        /// <value>Set this to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its hosting Protection Source, and the database is not being renamed.</value>
        [DataMember(Name="captureTailLogs", EmitDefaultValue=false)]
        public bool? CaptureTailLogs { get; set; }

        /// <summary>
        /// Set this to true if we want to restore the database and do not want to bring it online after restore.  This is only applicable if we are restoring the database back to its original location.
        /// </summary>
        /// <value>Set this to true if we want to restore the database and do not want to bring it online after restore.  This is only applicable if we are restoring the database back to its original location.</value>
        [DataMember(Name="keepOffline", EmitDefaultValue=false)]
        public bool? KeepOffline { get; set; }

        /// <summary>
        /// Specifies optionally a new name for the restored database.
        /// </summary>
        /// <value>Specifies optionally a new name for the restored database.</value>
        [DataMember(Name="newDatabaseName", EmitDefaultValue=false)]
        public string NewDatabaseName { get; set; }

        /// <summary>
        /// Specifies an instance name of the SQL Server that should be restored. SQL application has many instances. Each instance has a unique name. One of the instances that should be restored must be set in this field.
        /// </summary>
        /// <value>Specifies an instance name of the SQL Server that should be restored. SQL application has many instances. Each instance has a unique name. One of the instances that should be restored must be set in this field.</value>
        [DataMember(Name="newInstanceName", EmitDefaultValue=false)]
        public string NewInstanceName { get; set; }

        /// <summary>
        /// Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be restored from the full/incremental snapshot.
        /// </summary>
        /// <value>Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be restored from the full/incremental snapshot.</value>
        [DataMember(Name="restoreTimeSecs", EmitDefaultValue=false)]
        public long? RestoreTimeSecs { get; set; }

        /// <summary>
        /// Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host.
        /// </summary>
        /// <value>Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host.</value>
        [DataMember(Name="targetDataFilesDirectory", EmitDefaultValue=false)]
        public string TargetDataFilesDirectory { get; set; }

        /// <summary>
        /// Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host.
        /// </summary>
        /// <value>Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host.</value>
        [DataMember(Name="targetLogFilesDirectory", EmitDefaultValue=false)]
        public string TargetLogFilesDirectory { get; set; }

        /// <summary>
        /// If this option is specified and the destination folders do not exist they will be automatically created.
        /// </summary>
        /// <value>If this option is specified and the destination folders do not exist they will be automatically created.</value>
        [DataMember(Name="targetSecondaryDataFilesDirectoryList", EmitDefaultValue=false)]
        public List<FilenamePatternToDirectory> TargetSecondaryDataFilesDirectoryList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
                    this.TargetSecondaryDataFilesDirectoryList.SequenceEqual(input.TargetSecondaryDataFilesDirectoryList)
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
                if (this.KeepOffline != null)
                    hashCode = hashCode * 59 + this.KeepOffline.GetHashCode();
                if (this.NewDatabaseName != null)
                    hashCode = hashCode * 59 + this.NewDatabaseName.GetHashCode();
                if (this.NewInstanceName != null)
                    hashCode = hashCode * 59 + this.NewInstanceName.GetHashCode();
                if (this.RestoreTimeSecs != null)
                    hashCode = hashCode * 59 + this.RestoreTimeSecs.GetHashCode();
                if (this.TargetDataFilesDirectory != null)
                    hashCode = hashCode * 59 + this.TargetDataFilesDirectory.GetHashCode();
                if (this.TargetLogFilesDirectory != null)
                    hashCode = hashCode * 59 + this.TargetLogFilesDirectory.GetHashCode();
                if (this.TargetSecondaryDataFilesDirectoryList != null)
                    hashCode = hashCode * 59 + this.TargetSecondaryDataFilesDirectoryList.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

