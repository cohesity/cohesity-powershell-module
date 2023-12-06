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
    /// A message to encapsulate the pre-backup and post-backup and post-snapshot scripts for Cloud Adapter (AWS, Azure, GCP) based backups.
    /// </summary>
    [DataContract]
    public partial class CloudBackupJobPreOrPostScript :  IEquatable<CloudBackupJobPreOrPostScript>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudBackupJobPreOrPostScript" /> class.
        /// </summary>
        /// <param name="linuxScript">linuxScript.</param>
        /// <param name="windowsScript">windowsScript.</param>
        public CloudBackupJobPreOrPostScript(ScriptPathAndParams linuxScript = default(ScriptPathAndParams), ScriptPathAndParams windowsScript = default(ScriptPathAndParams))
        {
            this.LinuxScript = linuxScript;
            this.WindowsScript = windowsScript;
        }
        
        /// <summary>
        /// Gets or Sets LinuxScript
        /// </summary>
        [DataMember(Name="linuxScript", EmitDefaultValue=false)]
        public ScriptPathAndParams LinuxScript { get; set; }

        /// <summary>
        /// Gets or Sets WindowsScript
        /// </summary>
        [DataMember(Name="windowsScript", EmitDefaultValue=false)]
        public ScriptPathAndParams WindowsScript { get; set; }

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
            return this.Equals(input as CloudBackupJobPreOrPostScript);
        }

        /// <summary>
        /// Returns true if CloudBackupJobPreOrPostScript instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudBackupJobPreOrPostScript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudBackupJobPreOrPostScript input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinuxScript == input.LinuxScript ||
                    (this.LinuxScript != null &&
                    this.LinuxScript.Equals(input.LinuxScript))
                ) && 
                (
                    this.WindowsScript == input.WindowsScript ||
                    (this.WindowsScript != null &&
                    this.WindowsScript.Equals(input.WindowsScript))
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
                if (this.LinuxScript != null)
                    hashCode = hashCode * 59 + this.LinuxScript.GetHashCode();
                if (this.WindowsScript != null)
                    hashCode = hashCode * 59 + this.WindowsScript.GetHashCode();
                return hashCode;
            }
        }

    }

}

