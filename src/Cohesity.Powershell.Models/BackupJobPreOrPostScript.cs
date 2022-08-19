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
    /// A message to encapsulate the pre and post scripts associated with a backup job. Pre script is executed before backup run of a job starts. Post script is executed after backup run of a job finishes. Currently, pre and post script is only supported for backup job of type &#39;kPuppeteer&#39; and agent-based backup jobs.
    /// </summary>
    [DataContract]
    public partial class BackupJobPreOrPostScript :  IEquatable<BackupJobPreOrPostScript>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobPreOrPostScript" /> class.
        /// </summary>
        /// <param name="backupScript">backupScript.</param>
        /// <param name="fullBackupScript">fullBackupScript.</param>
        /// <param name="logBackupScript">logBackupScript.</param>
        /// <param name="remoteHostParams">remoteHostParams.</param>
        public BackupJobPreOrPostScript(ScriptPathAndParams backupScript = default(ScriptPathAndParams), ScriptPathAndParams fullBackupScript = default(ScriptPathAndParams), ScriptPathAndParams logBackupScript = default(ScriptPathAndParams), RemoteHostConnectorParams remoteHostParams = default(RemoteHostConnectorParams))
        {
            this.BackupScript = backupScript;
            this.FullBackupScript = fullBackupScript;
            this.LogBackupScript = logBackupScript;
            this.RemoteHostParams = remoteHostParams;
        }
        
        /// <summary>
        /// Gets or Sets BackupScript
        /// </summary>
        [DataMember(Name="backupScript", EmitDefaultValue=false)]
        public ScriptPathAndParams BackupScript { get; set; }

        /// <summary>
        /// Gets or Sets FullBackupScript
        /// </summary>
        [DataMember(Name="fullBackupScript", EmitDefaultValue=false)]
        public ScriptPathAndParams FullBackupScript { get; set; }

        /// <summary>
        /// Gets or Sets LogBackupScript
        /// </summary>
        [DataMember(Name="logBackupScript", EmitDefaultValue=false)]
        public ScriptPathAndParams LogBackupScript { get; set; }

        /// <summary>
        /// Gets or Sets RemoteHostParams
        /// </summary>
        [DataMember(Name="remoteHostParams", EmitDefaultValue=false)]
        public RemoteHostConnectorParams RemoteHostParams { get; set; }

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
            return this.Equals(input as BackupJobPreOrPostScript);
        }

        /// <summary>
        /// Returns true if BackupJobPreOrPostScript instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobPreOrPostScript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobPreOrPostScript input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupScript == input.BackupScript ||
                    (this.BackupScript != null &&
                    this.BackupScript.Equals(input.BackupScript))
                ) && 
                (
                    this.FullBackupScript == input.FullBackupScript ||
                    (this.FullBackupScript != null &&
                    this.FullBackupScript.Equals(input.FullBackupScript))
                ) && 
                (
                    this.LogBackupScript == input.LogBackupScript ||
                    (this.LogBackupScript != null &&
                    this.LogBackupScript.Equals(input.LogBackupScript))
                ) && 
                (
                    this.RemoteHostParams == input.RemoteHostParams ||
                    (this.RemoteHostParams != null &&
                    this.RemoteHostParams.Equals(input.RemoteHostParams))
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
                if (this.BackupScript != null)
                    hashCode = hashCode * 59 + this.BackupScript.GetHashCode();
                if (this.FullBackupScript != null)
                    hashCode = hashCode * 59 + this.FullBackupScript.GetHashCode();
                if (this.LogBackupScript != null)
                    hashCode = hashCode * 59 + this.LogBackupScript.GetHashCode();
                if (this.RemoteHostParams != null)
                    hashCode = hashCode * 59 + this.RemoteHostParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

