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
    /// Provides details about the Remote Adapter associated with a &#39;kPuppeteer&#39; Protection Job.
    /// </summary>
    [DataContract]
    public partial class RemoteJobScript :  IEquatable<RemoteJobScript>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteJobScript" /> class.
        /// </summary>
        /// <param name="fullBackupScript">fullBackupScript.</param>
        /// <param name="incrementalBackupScript">incrementalBackupScript.</param>
        /// <param name="logBackupScript">logBackupScript.</param>
        /// <param name="remoteHost">remoteHost.</param>
        /// <param name="username">Specifies the username that will be used to login to the remote host. For host type &#39;kLinux&#39;, it is expected that user has setup the password-less access. So only username field is required..</param>
        public RemoteJobScript(FullNoCBTScript_ fullBackupScript = default(FullNoCBTScript_), CBTbasedScript_ incrementalBackupScript = default(CBTbasedScript_), LogScript_ logBackupScript = default(LogScript_), RemoteHost_ remoteHost = default(RemoteHost_), string username = default(string))
        {
            this.FullBackupScript = fullBackupScript;
            this.IncrementalBackupScript = incrementalBackupScript;
            this.LogBackupScript = logBackupScript;
            this.RemoteHost = remoteHost;
            this.Username = username;
        }
        
        /// <summary>
        /// Gets or Sets FullBackupScript
        /// </summary>
        [DataMember(Name="fullBackupScript", EmitDefaultValue=false)]
        public FullNoCBTScript_ FullBackupScript { get; set; }

        /// <summary>
        /// Gets or Sets IncrementalBackupScript
        /// </summary>
        [DataMember(Name="incrementalBackupScript", EmitDefaultValue=false)]
        public CBTbasedScript_ IncrementalBackupScript { get; set; }

        /// <summary>
        /// Gets or Sets LogBackupScript
        /// </summary>
        [DataMember(Name="logBackupScript", EmitDefaultValue=false)]
        public LogScript_ LogBackupScript { get; set; }

        /// <summary>
        /// Gets or Sets RemoteHost
        /// </summary>
        [DataMember(Name="remoteHost", EmitDefaultValue=false)]
        public RemoteHost_ RemoteHost { get; set; }

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
                    (this.FullBackupScript != null &&
                    this.FullBackupScript.Equals(input.FullBackupScript))
                ) && 
                (
                    this.IncrementalBackupScript == input.IncrementalBackupScript ||
                    (this.IncrementalBackupScript != null &&
                    this.IncrementalBackupScript.Equals(input.IncrementalBackupScript))
                ) && 
                (
                    this.LogBackupScript == input.LogBackupScript ||
                    (this.LogBackupScript != null &&
                    this.LogBackupScript.Equals(input.LogBackupScript))
                ) && 
                (
                    this.RemoteHost == input.RemoteHost ||
                    (this.RemoteHost != null &&
                    this.RemoteHost.Equals(input.RemoteHost))
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

