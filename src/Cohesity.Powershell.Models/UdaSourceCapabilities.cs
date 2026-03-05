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
    /// UdaSourceCapabilities
    /// </summary>
    [DataContract]
    public partial class UdaSourceCapabilities :  IEquatable<UdaSourceCapabilities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaSourceCapabilities" /> class.
        /// </summary>
        /// <param name="autoLogBackup">autoLogBackup.</param>
        /// <param name="dynamicConfig">Specifies whether the source supports the &#39;Dynamic Configuration&#39; capability..</param>
        /// <param name="entitySupport">Indicates if source has entity capability..</param>
        /// <param name="etLogBackup">Specifies whether the source supports externally triggered log backups..</param>
        /// <param name="externalDisks">Only for sources in the cloud. A temporary external disk is provisoned in the cloud and mounted on the control node selected during backup / recovery for dump-sweep workflows that need a local disk to dump data. Prereq - non-mount, AGENT_ON_RIGEL..</param>
        /// <param name="fullBackup">fullBackup.</param>
        /// <param name="incrBackup">incrBackup.</param>
        /// <param name="logBackup">logBackup.</param>
        /// <param name="multiObjectRestore">Whether the source supports restore of multiple objects..</param>
        /// <param name="pauseResumeBackup">pauseResumeBackup.</param>
        /// <param name="postBackupJobScript">Triggers a post backup script on all nodes..</param>
        /// <param name="postRestoreJobScript">Triggers a post restore script on all nodes..</param>
        /// <param name="preBackupJobScript">Make a source call before actual start backup call..</param>
        /// <param name="preRestoreJobScript">Triggers a pre restore script on all nodes..</param>
        /// <param name="resourceThrottling">resourceThrottling.</param>
        /// <param name="snapfsCert">snapfsCert.</param>
        public UdaSourceCapabilities(bool? autoLogBackup = default(bool?), bool? dynamicConfig = default(bool?), bool? entitySupport = default(bool?), bool? etLogBackup = default(bool?), bool? externalDisks = default(bool?), bool? fullBackup = default(bool?), bool? incrBackup = default(bool?), bool? logBackup = default(bool?), bool? multiObjectRestore = default(bool?), bool? pauseResumeBackup = default(bool?), bool? postBackupJobScript = default(bool?), bool? postRestoreJobScript = default(bool?), bool? preBackupJobScript = default(bool?), bool? preRestoreJobScript = default(bool?), bool? resourceThrottling = default(bool?), bool? snapfsCert = default(bool?))
        {
            this.AutoLogBackup = autoLogBackup;
            this.DynamicConfig = dynamicConfig;
            this.EntitySupport = entitySupport;
            this.EtLogBackup = etLogBackup;
            this.ExternalDisks = externalDisks;
            this.FullBackup = fullBackup;
            this.IncrBackup = incrBackup;
            this.LogBackup = logBackup;
            this.MultiObjectRestore = multiObjectRestore;
            this.PauseResumeBackup = pauseResumeBackup;
            this.PostBackupJobScript = postBackupJobScript;
            this.PostRestoreJobScript = postRestoreJobScript;
            this.PreBackupJobScript = preBackupJobScript;
            this.PreRestoreJobScript = preRestoreJobScript;
            this.ResourceThrottling = resourceThrottling;
            this.SnapfsCert = snapfsCert;
            this.AutoLogBackup = autoLogBackup;
            this.DynamicConfig = dynamicConfig;
            this.EntitySupport = entitySupport;
            this.EtLogBackup = etLogBackup;
            this.ExternalDisks = externalDisks;
            this.FullBackup = fullBackup;
            this.IncrBackup = incrBackup;
            this.LogBackup = logBackup;
            this.MultiObjectRestore = multiObjectRestore;
            this.PauseResumeBackup = pauseResumeBackup;
            this.PostBackupJobScript = postBackupJobScript;
            this.PostRestoreJobScript = postRestoreJobScript;
            this.PreBackupJobScript = preBackupJobScript;
            this.PreRestoreJobScript = preRestoreJobScript;
            this.ResourceThrottling = resourceThrottling;
            this.SnapfsCert = snapfsCert;
        }
        
        /// <summary>
        /// Gets or Sets AutoLogBackup
        /// </summary>
        [DataMember(Name="autoLogBackup", EmitDefaultValue=true)]
        public bool? AutoLogBackup { get; set; }

        /// <summary>
        /// Specifies whether the source supports the &#39;Dynamic Configuration&#39; capability.
        /// </summary>
        /// <value>Specifies whether the source supports the &#39;Dynamic Configuration&#39; capability.</value>
        [DataMember(Name="dynamicConfig", EmitDefaultValue=true)]
        public bool? DynamicConfig { get; set; }

        /// <summary>
        /// Indicates if source has entity capability.
        /// </summary>
        /// <value>Indicates if source has entity capability.</value>
        [DataMember(Name="entitySupport", EmitDefaultValue=true)]
        public bool? EntitySupport { get; set; }

        /// <summary>
        /// Specifies whether the source supports externally triggered log backups.
        /// </summary>
        /// <value>Specifies whether the source supports externally triggered log backups.</value>
        [DataMember(Name="etLogBackup", EmitDefaultValue=true)]
        public bool? EtLogBackup { get; set; }

        /// <summary>
        /// Only for sources in the cloud. A temporary external disk is provisoned in the cloud and mounted on the control node selected during backup / recovery for dump-sweep workflows that need a local disk to dump data. Prereq - non-mount, AGENT_ON_RIGEL.
        /// </summary>
        /// <value>Only for sources in the cloud. A temporary external disk is provisoned in the cloud and mounted on the control node selected during backup / recovery for dump-sweep workflows that need a local disk to dump data. Prereq - non-mount, AGENT_ON_RIGEL.</value>
        [DataMember(Name="externalDisks", EmitDefaultValue=true)]
        public bool? ExternalDisks { get; set; }

        /// <summary>
        /// Gets or Sets FullBackup
        /// </summary>
        [DataMember(Name="fullBackup", EmitDefaultValue=true)]
        public bool? FullBackup { get; set; }

        /// <summary>
        /// Gets or Sets IncrBackup
        /// </summary>
        [DataMember(Name="incrBackup", EmitDefaultValue=true)]
        public bool? IncrBackup { get; set; }

        /// <summary>
        /// Gets or Sets LogBackup
        /// </summary>
        [DataMember(Name="logBackup", EmitDefaultValue=true)]
        public bool? LogBackup { get; set; }

        /// <summary>
        /// Whether the source supports restore of multiple objects.
        /// </summary>
        /// <value>Whether the source supports restore of multiple objects.</value>
        [DataMember(Name="multiObjectRestore", EmitDefaultValue=true)]
        public bool? MultiObjectRestore { get; set; }

        /// <summary>
        /// Gets or Sets PauseResumeBackup
        /// </summary>
        [DataMember(Name="pauseResumeBackup", EmitDefaultValue=true)]
        public bool? PauseResumeBackup { get; set; }

        /// <summary>
        /// Triggers a post backup script on all nodes.
        /// </summary>
        /// <value>Triggers a post backup script on all nodes.</value>
        [DataMember(Name="postBackupJobScript", EmitDefaultValue=true)]
        public bool? PostBackupJobScript { get; set; }

        /// <summary>
        /// Triggers a post restore script on all nodes.
        /// </summary>
        /// <value>Triggers a post restore script on all nodes.</value>
        [DataMember(Name="postRestoreJobScript", EmitDefaultValue=true)]
        public bool? PostRestoreJobScript { get; set; }

        /// <summary>
        /// Make a source call before actual start backup call.
        /// </summary>
        /// <value>Make a source call before actual start backup call.</value>
        [DataMember(Name="preBackupJobScript", EmitDefaultValue=true)]
        public bool? PreBackupJobScript { get; set; }

        /// <summary>
        /// Triggers a pre restore script on all nodes.
        /// </summary>
        /// <value>Triggers a pre restore script on all nodes.</value>
        [DataMember(Name="preRestoreJobScript", EmitDefaultValue=true)]
        public bool? PreRestoreJobScript { get; set; }

        /// <summary>
        /// Gets or Sets ResourceThrottling
        /// </summary>
        [DataMember(Name="resourceThrottling", EmitDefaultValue=true)]
        public bool? ResourceThrottling { get; set; }

        /// <summary>
        /// Gets or Sets SnapfsCert
        /// </summary>
        [DataMember(Name="snapfsCert", EmitDefaultValue=true)]
        public bool? SnapfsCert { get; set; }

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
            return this.Equals(input as UdaSourceCapabilities);
        }

        /// <summary>
        /// Returns true if UdaSourceCapabilities instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaSourceCapabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaSourceCapabilities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoLogBackup == input.AutoLogBackup ||
                    (this.AutoLogBackup != null &&
                    this.AutoLogBackup.Equals(input.AutoLogBackup))
                ) && 
                (
                    this.DynamicConfig == input.DynamicConfig ||
                    (this.DynamicConfig != null &&
                    this.DynamicConfig.Equals(input.DynamicConfig))
                ) && 
                (
                    this.EntitySupport == input.EntitySupport ||
                    (this.EntitySupport != null &&
                    this.EntitySupport.Equals(input.EntitySupport))
                ) && 
                (
                    this.EtLogBackup == input.EtLogBackup ||
                    (this.EtLogBackup != null &&
                    this.EtLogBackup.Equals(input.EtLogBackup))
                ) && 
                (
                    this.ExternalDisks == input.ExternalDisks ||
                    (this.ExternalDisks != null &&
                    this.ExternalDisks.Equals(input.ExternalDisks))
                ) && 
                (
                    this.FullBackup == input.FullBackup ||
                    (this.FullBackup != null &&
                    this.FullBackup.Equals(input.FullBackup))
                ) && 
                (
                    this.IncrBackup == input.IncrBackup ||
                    (this.IncrBackup != null &&
                    this.IncrBackup.Equals(input.IncrBackup))
                ) && 
                (
                    this.LogBackup == input.LogBackup ||
                    (this.LogBackup != null &&
                    this.LogBackup.Equals(input.LogBackup))
                ) && 
                (
                    this.MultiObjectRestore == input.MultiObjectRestore ||
                    (this.MultiObjectRestore != null &&
                    this.MultiObjectRestore.Equals(input.MultiObjectRestore))
                ) && 
                (
                    this.PauseResumeBackup == input.PauseResumeBackup ||
                    (this.PauseResumeBackup != null &&
                    this.PauseResumeBackup.Equals(input.PauseResumeBackup))
                ) && 
                (
                    this.PostBackupJobScript == input.PostBackupJobScript ||
                    (this.PostBackupJobScript != null &&
                    this.PostBackupJobScript.Equals(input.PostBackupJobScript))
                ) && 
                (
                    this.PostRestoreJobScript == input.PostRestoreJobScript ||
                    (this.PostRestoreJobScript != null &&
                    this.PostRestoreJobScript.Equals(input.PostRestoreJobScript))
                ) && 
                (
                    this.PreBackupJobScript == input.PreBackupJobScript ||
                    (this.PreBackupJobScript != null &&
                    this.PreBackupJobScript.Equals(input.PreBackupJobScript))
                ) && 
                (
                    this.PreRestoreJobScript == input.PreRestoreJobScript ||
                    (this.PreRestoreJobScript != null &&
                    this.PreRestoreJobScript.Equals(input.PreRestoreJobScript))
                ) && 
                (
                    this.ResourceThrottling == input.ResourceThrottling ||
                    (this.ResourceThrottling != null &&
                    this.ResourceThrottling.Equals(input.ResourceThrottling))
                ) && 
                (
                    this.SnapfsCert == input.SnapfsCert ||
                    (this.SnapfsCert != null &&
                    this.SnapfsCert.Equals(input.SnapfsCert))
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
                if (this.AutoLogBackup != null)
                    hashCode = hashCode * 59 + this.AutoLogBackup.GetHashCode();
                if (this.DynamicConfig != null)
                    hashCode = hashCode * 59 + this.DynamicConfig.GetHashCode();
                if (this.EntitySupport != null)
                    hashCode = hashCode * 59 + this.EntitySupport.GetHashCode();
                if (this.EtLogBackup != null)
                    hashCode = hashCode * 59 + this.EtLogBackup.GetHashCode();
                if (this.ExternalDisks != null)
                    hashCode = hashCode * 59 + this.ExternalDisks.GetHashCode();
                if (this.FullBackup != null)
                    hashCode = hashCode * 59 + this.FullBackup.GetHashCode();
                if (this.IncrBackup != null)
                    hashCode = hashCode * 59 + this.IncrBackup.GetHashCode();
                if (this.LogBackup != null)
                    hashCode = hashCode * 59 + this.LogBackup.GetHashCode();
                if (this.MultiObjectRestore != null)
                    hashCode = hashCode * 59 + this.MultiObjectRestore.GetHashCode();
                if (this.PauseResumeBackup != null)
                    hashCode = hashCode * 59 + this.PauseResumeBackup.GetHashCode();
                if (this.PostBackupJobScript != null)
                    hashCode = hashCode * 59 + this.PostBackupJobScript.GetHashCode();
                if (this.PostRestoreJobScript != null)
                    hashCode = hashCode * 59 + this.PostRestoreJobScript.GetHashCode();
                if (this.PreBackupJobScript != null)
                    hashCode = hashCode * 59 + this.PreBackupJobScript.GetHashCode();
                if (this.PreRestoreJobScript != null)
                    hashCode = hashCode * 59 + this.PreRestoreJobScript.GetHashCode();
                if (this.ResourceThrottling != null)
                    hashCode = hashCode * 59 + this.ResourceThrottling.GetHashCode();
                if (this.SnapfsCert != null)
                    hashCode = hashCode * 59 + this.SnapfsCert.GetHashCode();
                return hashCode;
            }
        }

    }

}

