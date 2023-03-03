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
    /// Message to capture any additional backup params specific to Oracle.
    /// </summary>
    [DataContract]
    public partial class OracleBackupJobParams :  IEquatable<OracleBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleBackupJobParams" /> class.
        /// </summary>
        /// <param name="fullAutoKillTimeoutSecs">Time in seconds after which the full backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion..</param>
        /// <param name="incrAutoKillTimeoutSecs">Time in seconds after which the incremental backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion..</param>
        /// <param name="logAutoKillTimeoutSecs">Time in seconds after which the log backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion..</param>
        /// <param name="persistMountpoints">Indicates whether the mountpoints created while backing up Oracle DBs should be persisted. If this is set to &#39;false&#39; all Oracle views mounted to the hosts will be unmounted at the end. Note: This parameter is for the entire Job. For overriding persistence of mountpoints for a subset of Oracle hosts within the job, refer OracleSourceParams..</param>
        /// <param name="vlanParams">vlanParams.</param>
        public OracleBackupJobParams(long? fullAutoKillTimeoutSecs = default(long?), long? incrAutoKillTimeoutSecs = default(long?), long? logAutoKillTimeoutSecs = default(long?), bool? persistMountpoints = default(bool?), VlanParams vlanParams = default(VlanParams))
        {
            this.FullAutoKillTimeoutSecs = fullAutoKillTimeoutSecs;
            this.IncrAutoKillTimeoutSecs = incrAutoKillTimeoutSecs;
            this.LogAutoKillTimeoutSecs = logAutoKillTimeoutSecs;
            this.PersistMountpoints = persistMountpoints;
            this.FullAutoKillTimeoutSecs = fullAutoKillTimeoutSecs;
            this.IncrAutoKillTimeoutSecs = incrAutoKillTimeoutSecs;
            this.LogAutoKillTimeoutSecs = logAutoKillTimeoutSecs;
            this.PersistMountpoints = persistMountpoints;
            this.VlanParams = vlanParams;
        }
        
        /// <summary>
        /// Time in seconds after which the full backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion.
        /// </summary>
        /// <value>Time in seconds after which the full backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion.</value>
        [DataMember(Name="fullAutoKillTimeoutSecs", EmitDefaultValue=true)]
        public long? FullAutoKillTimeoutSecs { get; set; }

        /// <summary>
        /// Time in seconds after which the incremental backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion.
        /// </summary>
        /// <value>Time in seconds after which the incremental backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion.</value>
        [DataMember(Name="incrAutoKillTimeoutSecs", EmitDefaultValue=true)]
        public long? IncrAutoKillTimeoutSecs { get; set; }

        /// <summary>
        /// Time in seconds after which the log backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion.
        /// </summary>
        /// <value>Time in seconds after which the log backup of the database in given backup job should be auto-killed. If set to -1, then the backup will run until completion.</value>
        [DataMember(Name="logAutoKillTimeoutSecs", EmitDefaultValue=true)]
        public long? LogAutoKillTimeoutSecs { get; set; }

        /// <summary>
        /// Indicates whether the mountpoints created while backing up Oracle DBs should be persisted. If this is set to &#39;false&#39; all Oracle views mounted to the hosts will be unmounted at the end. Note: This parameter is for the entire Job. For overriding persistence of mountpoints for a subset of Oracle hosts within the job, refer OracleSourceParams.
        /// </summary>
        /// <value>Indicates whether the mountpoints created while backing up Oracle DBs should be persisted. If this is set to &#39;false&#39; all Oracle views mounted to the hosts will be unmounted at the end. Note: This parameter is for the entire Job. For overriding persistence of mountpoints for a subset of Oracle hosts within the job, refer OracleSourceParams.</value>
        [DataMember(Name="persistMountpoints", EmitDefaultValue=true)]
        public bool? PersistMountpoints { get; set; }

        /// <summary>
        /// Gets or Sets VlanParams
        /// </summary>
        [DataMember(Name="vlanParams", EmitDefaultValue=false)]
        public VlanParams VlanParams { get; set; }

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
            return this.Equals(input as OracleBackupJobParams);
        }

        /// <summary>
        /// Returns true if OracleBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullAutoKillTimeoutSecs == input.FullAutoKillTimeoutSecs ||
                    (this.FullAutoKillTimeoutSecs != null &&
                    this.FullAutoKillTimeoutSecs.Equals(input.FullAutoKillTimeoutSecs))
                ) && 
                (
                    this.IncrAutoKillTimeoutSecs == input.IncrAutoKillTimeoutSecs ||
                    (this.IncrAutoKillTimeoutSecs != null &&
                    this.IncrAutoKillTimeoutSecs.Equals(input.IncrAutoKillTimeoutSecs))
                ) && 
                (
                    this.LogAutoKillTimeoutSecs == input.LogAutoKillTimeoutSecs ||
                    (this.LogAutoKillTimeoutSecs != null &&
                    this.LogAutoKillTimeoutSecs.Equals(input.LogAutoKillTimeoutSecs))
                ) && 
                (
                    this.PersistMountpoints == input.PersistMountpoints ||
                    (this.PersistMountpoints != null &&
                    this.PersistMountpoints.Equals(input.PersistMountpoints))
                ) && 
                (
                    this.VlanParams == input.VlanParams ||
                    (this.VlanParams != null &&
                    this.VlanParams.Equals(input.VlanParams))
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
                if (this.FullAutoKillTimeoutSecs != null)
                    hashCode = hashCode * 59 + this.FullAutoKillTimeoutSecs.GetHashCode();
                if (this.IncrAutoKillTimeoutSecs != null)
                    hashCode = hashCode * 59 + this.IncrAutoKillTimeoutSecs.GetHashCode();
                if (this.LogAutoKillTimeoutSecs != null)
                    hashCode = hashCode * 59 + this.LogAutoKillTimeoutSecs.GetHashCode();
                if (this.PersistMountpoints != null)
                    hashCode = hashCode * 59 + this.PersistMountpoints.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

