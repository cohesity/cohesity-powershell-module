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
    /// Message to capture SQL gflags.
    /// </summary>
    [DataContract]
    public partial class AdvancedSettings :  IEquatable<AdvancedSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSettings" /> class.
        /// </summary>
        /// <param name="clonedDbBackupStatus">Whether to report error if SQL database is cloned..</param>
        /// <param name="dbBackupIfNotOnlineStatus">Whether to report error if SQL database is not online, it includes states such as offline, restoring as well as any other state for which db is not online..</param>
        /// <param name="missingDbBackupStatus">Fail the backup job when the database is missing. The database may be missing if it is deleted or corrupted..</param>
        /// <param name="offlineRestoringDbBackupStatus">Fail the backup job when database is offline or restoring..</param>
        /// <param name="readOnlyDbBackupStatus">Whether to skip backup for read-only SQL databases.</param>
        /// <param name="reportAllNonAutoprotectDbErrors">Whether to report error for all faulty dbs in non-autoprotect jobs. This will fail backup job if any db is offline/restoring/cloned etc..</param>
        public AdvancedSettings(int? clonedDbBackupStatus = default(int?), int? dbBackupIfNotOnlineStatus = default(int?), int? missingDbBackupStatus = default(int?), int? offlineRestoringDbBackupStatus = default(int?), int? readOnlyDbBackupStatus = default(int?), int? reportAllNonAutoprotectDbErrors = default(int?))
        {
            this.ClonedDbBackupStatus = clonedDbBackupStatus;
            this.DbBackupIfNotOnlineStatus = dbBackupIfNotOnlineStatus;
            this.MissingDbBackupStatus = missingDbBackupStatus;
            this.OfflineRestoringDbBackupStatus = offlineRestoringDbBackupStatus;
            this.ReadOnlyDbBackupStatus = readOnlyDbBackupStatus;
            this.ReportAllNonAutoprotectDbErrors = reportAllNonAutoprotectDbErrors;
            this.ClonedDbBackupStatus = clonedDbBackupStatus;
            this.DbBackupIfNotOnlineStatus = dbBackupIfNotOnlineStatus;
            this.MissingDbBackupStatus = missingDbBackupStatus;
            this.OfflineRestoringDbBackupStatus = offlineRestoringDbBackupStatus;
            this.ReadOnlyDbBackupStatus = readOnlyDbBackupStatus;
            this.ReportAllNonAutoprotectDbErrors = reportAllNonAutoprotectDbErrors;
        }
        
        /// <summary>
        /// Whether to report error if SQL database is cloned.
        /// </summary>
        /// <value>Whether to report error if SQL database is cloned.</value>
        [DataMember(Name="clonedDbBackupStatus", EmitDefaultValue=true)]
        public int? ClonedDbBackupStatus { get; set; }

        /// <summary>
        /// Whether to report error if SQL database is not online, it includes states such as offline, restoring as well as any other state for which db is not online.
        /// </summary>
        /// <value>Whether to report error if SQL database is not online, it includes states such as offline, restoring as well as any other state for which db is not online.</value>
        [DataMember(Name="dbBackupIfNotOnlineStatus", EmitDefaultValue=true)]
        public int? DbBackupIfNotOnlineStatus { get; set; }

        /// <summary>
        /// Fail the backup job when the database is missing. The database may be missing if it is deleted or corrupted.
        /// </summary>
        /// <value>Fail the backup job when the database is missing. The database may be missing if it is deleted or corrupted.</value>
        [DataMember(Name="missingDbBackupStatus", EmitDefaultValue=true)]
        public int? MissingDbBackupStatus { get; set; }

        /// <summary>
        /// Fail the backup job when database is offline or restoring.
        /// </summary>
        /// <value>Fail the backup job when database is offline or restoring.</value>
        [DataMember(Name="offlineRestoringDbBackupStatus", EmitDefaultValue=true)]
        public int? OfflineRestoringDbBackupStatus { get; set; }

        /// <summary>
        /// Whether to skip backup for read-only SQL databases
        /// </summary>
        /// <value>Whether to skip backup for read-only SQL databases</value>
        [DataMember(Name="readOnlyDbBackupStatus", EmitDefaultValue=true)]
        public int? ReadOnlyDbBackupStatus { get; set; }

        /// <summary>
        /// Whether to report error for all faulty dbs in non-autoprotect jobs. This will fail backup job if any db is offline/restoring/cloned etc.
        /// </summary>
        /// <value>Whether to report error for all faulty dbs in non-autoprotect jobs. This will fail backup job if any db is offline/restoring/cloned etc.</value>
        [DataMember(Name="reportAllNonAutoprotectDbErrors", EmitDefaultValue=true)]
        public int? ReportAllNonAutoprotectDbErrors { get; set; }

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
            return this.Equals(input as AdvancedSettings);
        }

        /// <summary>
        /// Returns true if AdvancedSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClonedDbBackupStatus == input.ClonedDbBackupStatus ||
                    (this.ClonedDbBackupStatus != null &&
                    this.ClonedDbBackupStatus.Equals(input.ClonedDbBackupStatus))
                ) && 
                (
                    this.DbBackupIfNotOnlineStatus == input.DbBackupIfNotOnlineStatus ||
                    (this.DbBackupIfNotOnlineStatus != null &&
                    this.DbBackupIfNotOnlineStatus.Equals(input.DbBackupIfNotOnlineStatus))
                ) && 
                (
                    this.MissingDbBackupStatus == input.MissingDbBackupStatus ||
                    (this.MissingDbBackupStatus != null &&
                    this.MissingDbBackupStatus.Equals(input.MissingDbBackupStatus))
                ) && 
                (
                    this.OfflineRestoringDbBackupStatus == input.OfflineRestoringDbBackupStatus ||
                    (this.OfflineRestoringDbBackupStatus != null &&
                    this.OfflineRestoringDbBackupStatus.Equals(input.OfflineRestoringDbBackupStatus))
                ) && 
                (
                    this.ReadOnlyDbBackupStatus == input.ReadOnlyDbBackupStatus ||
                    (this.ReadOnlyDbBackupStatus != null &&
                    this.ReadOnlyDbBackupStatus.Equals(input.ReadOnlyDbBackupStatus))
                ) && 
                (
                    this.ReportAllNonAutoprotectDbErrors == input.ReportAllNonAutoprotectDbErrors ||
                    (this.ReportAllNonAutoprotectDbErrors != null &&
                    this.ReportAllNonAutoprotectDbErrors.Equals(input.ReportAllNonAutoprotectDbErrors))
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
                if (this.ClonedDbBackupStatus != null)
                    hashCode = hashCode * 59 + this.ClonedDbBackupStatus.GetHashCode();
                if (this.DbBackupIfNotOnlineStatus != null)
                    hashCode = hashCode * 59 + this.DbBackupIfNotOnlineStatus.GetHashCode();
                if (this.MissingDbBackupStatus != null)
                    hashCode = hashCode * 59 + this.MissingDbBackupStatus.GetHashCode();
                if (this.OfflineRestoringDbBackupStatus != null)
                    hashCode = hashCode * 59 + this.OfflineRestoringDbBackupStatus.GetHashCode();
                if (this.ReadOnlyDbBackupStatus != null)
                    hashCode = hashCode * 59 + this.ReadOnlyDbBackupStatus.GetHashCode();
                if (this.ReportAllNonAutoprotectDbErrors != null)
                    hashCode = hashCode * 59 + this.ReportAllNonAutoprotectDbErrors.GetHashCode();
                return hashCode;
            }
        }

    }

}

