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
    /// OracleDBChannelInfoDgRoleBasedBackup
    /// </summary>
    [DataContract]
    public partial class OracleDBChannelInfoDgRoleBasedBackup :  IEquatable<OracleDBChannelInfoDgRoleBasedBackup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDBChannelInfoDgRoleBasedBackup" /> class.
        /// </summary>
        /// <param name="allowBackupArchivelogOnAnyRole">If set to true, the archivelog can be run regardless the dg role..</param>
        /// <param name="backupOnDgRole">The dataguard role which allows backup run..</param>
        public OracleDBChannelInfoDgRoleBasedBackup(bool? allowBackupArchivelogOnAnyRole = default(bool?), int? backupOnDgRole = default(int?))
        {
            this.AllowBackupArchivelogOnAnyRole = allowBackupArchivelogOnAnyRole;
            this.BackupOnDgRole = backupOnDgRole;
            this.AllowBackupArchivelogOnAnyRole = allowBackupArchivelogOnAnyRole;
            this.BackupOnDgRole = backupOnDgRole;
        }
        
        /// <summary>
        /// If set to true, the archivelog can be run regardless the dg role.
        /// </summary>
        /// <value>If set to true, the archivelog can be run regardless the dg role.</value>
        [DataMember(Name="allowBackupArchivelogOnAnyRole", EmitDefaultValue=true)]
        public bool? AllowBackupArchivelogOnAnyRole { get; set; }

        /// <summary>
        /// The dataguard role which allows backup run.
        /// </summary>
        /// <value>The dataguard role which allows backup run.</value>
        [DataMember(Name="backupOnDgRole", EmitDefaultValue=true)]
        public int? BackupOnDgRole { get; set; }

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
            return this.Equals(input as OracleDBChannelInfoDgRoleBasedBackup);
        }

        /// <summary>
        /// Returns true if OracleDBChannelInfoDgRoleBasedBackup instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDBChannelInfoDgRoleBasedBackup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDBChannelInfoDgRoleBasedBackup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowBackupArchivelogOnAnyRole == input.AllowBackupArchivelogOnAnyRole ||
                    (this.AllowBackupArchivelogOnAnyRole != null &&
                    this.AllowBackupArchivelogOnAnyRole.Equals(input.AllowBackupArchivelogOnAnyRole))
                ) && 
                (
                    this.BackupOnDgRole == input.BackupOnDgRole ||
                    (this.BackupOnDgRole != null &&
                    this.BackupOnDgRole.Equals(input.BackupOnDgRole))
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
                if (this.AllowBackupArchivelogOnAnyRole != null)
                    hashCode = hashCode * 59 + this.AllowBackupArchivelogOnAnyRole.GetHashCode();
                if (this.BackupOnDgRole != null)
                    hashCode = hashCode * 59 + this.BackupOnDgRole.GetHashCode();
                return hashCode;
            }
        }

    }

}

