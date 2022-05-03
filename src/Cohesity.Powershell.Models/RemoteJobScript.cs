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
    /// Provides details about the Remote Adapter associated with a &#39;kPuppeteer&#39; Protection Job.
    /// </summary>
    [DataContract]
    public partial class RemoteJobScript :  IEquatable<RemoteJobScript>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteJobScript" /> class.
        /// </summary>
        /// <param name="fullBackupScript">Specifies the script that should run for the Full (no CBT) backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. This field is mandatory if the Policy associated with this Job has a Full (no CBT) backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job..</param>
        /// <param name="incrementalBackupScript">Specifies the script that should run for the CBT-based backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. A CBT-based backup schedule is utilizing Change Block Tracking when capturing Snapshots. This field is mandatory if the Policy associated with this Job has a CBT-based backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job..</param>
        /// <param name="logBackupScript">Specifies the script that should run for the Log backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. This field is mandatory if the Policy associated with this Job has a Log backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job..</param>
        /// <param name="remoteHost">Specifies the remote host where the remote scripts are executed. This field must be set for Remote Adapter Jobs..</param>
        /// <param name="username">Specifies the username that will be used to login to the remote host. For host type &#39;kLinux&#39;, it is expected that user has setup the password-less access. So only username field is required..</param>
        public RemoteJobScript(RemoteScriptPathAndParams fullBackupScript = default(RemoteScriptPathAndParams), RemoteScriptPathAndParams incrementalBackupScript = default(RemoteScriptPathAndParams), RemoteScriptPathAndParams logBackupScript = default(RemoteScriptPathAndParams), RemoteHost remoteHost = default(RemoteHost), string username = default(string))
        {
            this.FullBackupScript = fullBackupScript;
            this.IncrementalBackupScript = incrementalBackupScript;
            this.LogBackupScript = logBackupScript;
            this.RemoteHost = remoteHost;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the script that should run for the Full (no CBT) backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. This field is mandatory if the Policy associated with this Job has a Full (no CBT) backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job.
        /// </summary>
        /// <value>Specifies the script that should run for the Full (no CBT) backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. This field is mandatory if the Policy associated with this Job has a Full (no CBT) backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job.</value>
        [DataMember(Name="fullBackupScript", EmitDefaultValue=false)]
        public RemoteScriptPathAndParams FullBackupScript { get; set; }

        /// <summary>
        /// Specifies the script that should run for the CBT-based backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. A CBT-based backup schedule is utilizing Change Block Tracking when capturing Snapshots. This field is mandatory if the Policy associated with this Job has a CBT-based backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job.
        /// </summary>
        /// <value>Specifies the script that should run for the CBT-based backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. A CBT-based backup schedule is utilizing Change Block Tracking when capturing Snapshots. This field is mandatory if the Policy associated with this Job has a CBT-based backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job.</value>
        [DataMember(Name="incrementalBackupScript", EmitDefaultValue=false)]
        public RemoteScriptPathAndParams IncrementalBackupScript { get; set; }

        /// <summary>
        /// Specifies the script that should run for the Log backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. This field is mandatory if the Policy associated with this Job has a Log backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job.
        /// </summary>
        /// <value>Specifies the script that should run for the Log backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. This field is mandatory if the Policy associated with this Job has a Log backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job.</value>
        [DataMember(Name="logBackupScript", EmitDefaultValue=false)]
        public RemoteScriptPathAndParams LogBackupScript { get; set; }

        /// <summary>
        /// Specifies the remote host where the remote scripts are executed. This field must be set for Remote Adapter Jobs.
        /// </summary>
        /// <value>Specifies the remote host where the remote scripts are executed. This field must be set for Remote Adapter Jobs.</value>
        [DataMember(Name="remoteHost", EmitDefaultValue=false)]
        public RemoteHost RemoteHost { get; set; }

        /// <summary>
        /// Specifies the username that will be used to login to the remote host. For host type &#39;kLinux&#39;, it is expected that user has setup the password-less access. So only username field is required.
        /// </summary>
        /// <value>Specifies the username that will be used to login to the remote host. For host type &#39;kLinux&#39;, it is expected that user has setup the password-less access. So only username field is required.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

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
            return this.Equals(input as RemoteJobScript);
        }

        /// <summary>
        /// Returns true if RemoteJobScript instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteJobScript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteJobScript input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullBackupScript == input.FullBackupScript ||
                    this.FullBackupScript != null &&
                    this.FullBackupScript.Equals(input.FullBackupScript)
                ) && 
                (
                    this.IncrementalBackupScript == input.IncrementalBackupScript ||
                    this.IncrementalBackupScript != null &&
                    this.IncrementalBackupScript.Equals(input.IncrementalBackupScript)
                ) && 
                (
                    this.LogBackupScript == input.LogBackupScript ||
                    this.LogBackupScript != null &&
                    this.LogBackupScript.Equals(input.LogBackupScript)
                ) && 
                (
                    this.RemoteHost == input.RemoteHost ||
                    this.RemoteHost != null &&
                    this.RemoteHost.Equals(input.RemoteHost)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.FullBackupScript != null)
                    hashCode = hashCode * 59 + this.FullBackupScript.GetHashCode();
                if (this.IncrementalBackupScript != null)
                    hashCode = hashCode * 59 + this.IncrementalBackupScript.GetHashCode();
                if (this.LogBackupScript != null)
                    hashCode = hashCode * 59 + this.LogBackupScript.GetHashCode();
                if (this.RemoteHost != null)
                    hashCode = hashCode * 59 + this.RemoteHost.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

