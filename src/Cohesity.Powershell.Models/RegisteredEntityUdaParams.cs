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
    /// Contains all params specified by the user while registering a UDA entity.
    /// </summary>
    [DataContract]
    public partial class RegisteredEntityUdaParams :  IEquatable<RegisteredEntityUdaParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredEntityUdaParams" /> class.
        /// </summary>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="deploymentType">Deployment type for the UDA agent..</param>
        /// <param name="etEnableLogBackupPolicy">Specifies whether to enable cohesity policy triggered log backups along with externally triggered backups. Only applicable if externally_triggered_log_backup is true..</param>
        /// <param name="etEnableRunNow">Specifies if the user triggered (UI) runs are allowed along with externally triggered runs. Only applicable if externally_triggered_log_backup is true..</param>
        /// <param name="freshFullBackupView">Indicate if a new view is required for full backups..</param>
        /// <param name="hostType">The agent host environment type..</param>
        /// <param name="hosts">List of hosts forming the UDA cluster..</param>
        /// <param name="liveDataView">Should use live view for data backup..</param>
        /// <param name="liveLogView">Should use live view for log backup..</param>
        /// <param name="mountDir">Mount directory path to be used for writing the backup to..</param>
        /// <param name="mountView">Whether to mount a view during the source backup..</param>
        /// <param name="objectTypes">Object levels..</param>
        /// <param name="objectTypesExcludedFromExpansion">These object types would be excluded from entity hierarchy expansion while expanding entities as part of a backup job run. For instance, when an object of excluded object type is encountered during EH expansion for backup, it would be treated as a leaf entity. Behaviour of other EH expansion operations would remain as is such as EH expansion when a source is refreshed..</param>
        /// <param name="parallelLogBackups">Specifies whether the source supports parallel log backups. Must be used with a live log view..</param>
        /// <param name="postBackupJobScriptFailureTolerance">postBackupJobScriptFailureTolerance.</param>
        /// <param name="postRestoreJobScriptFailureTolerance">postRestoreJobScriptFailureTolerance.</param>
        /// <param name="preBackupJobScriptFailureTolerance">preBackupJobScriptFailureTolerance.</param>
        /// <param name="preRestoreJobScriptFailureTolerance">preRestoreJobScriptFailureTolerance.</param>
        /// <param name="preferredControlNodes">Control nodes to connect for control path ops..</param>
        /// <param name="restrictParallelDataLogBackups">Specifies whether the source disallows parallel data &amp; log backups..</param>
        /// <param name="scriptDir">Path where various source scripts will be located..</param>
        /// <param name="sourceArgs">Custom arguments which will be provided to the source registration scripts. This is deprecated. Use source_args_map instead..</param>
        /// <param name="sourceArgumentsMap">Map to store custom arguments which will be provided to the source registration scripts..</param>
        /// <param name="sourceType">Universal Data Adapter (UDA) source type..</param>
        /// <param name="staticLiveLogView">Should the live log view be created at the time of first full backup ? This will be passed to all data backups This is not the same as auto_log_backup, since this applies to scheduled log backups and has its limitations.</param>
        /// <param name="useS3View">Whether S3 views should be used for backup/retore..</param>
        public RegisteredEntityUdaParams(UdaSourceCapabilities capabilities = default(UdaSourceCapabilities), Credentials credentials = default(Credentials), int? deploymentType = default(int?), bool? etEnableLogBackupPolicy = default(bool?), bool? etEnableRunNow = default(bool?), bool? freshFullBackupView = default(bool?), int? hostType = default(int?), List<string> hosts = default(List<string>), bool? liveDataView = default(bool?), bool? liveLogView = default(bool?), string mountDir = default(string), bool? mountView = default(bool?), List<string> objectTypes = default(List<string>), List<string> objectTypesExcludedFromExpansion = default(List<string>), bool? parallelLogBackups = default(bool?), int? postBackupJobScriptFailureTolerance = default(int?), int? postRestoreJobScriptFailureTolerance = default(int?), int? preBackupJobScriptFailureTolerance = default(int?), int? preRestoreJobScriptFailureTolerance = default(int?), List<string> preferredControlNodes = default(List<string>), bool? restrictParallelDataLogBackups = default(bool?), string scriptDir = default(string), string sourceArgs = default(string), Dictionary<string, UdaCustomArgument> sourceArgumentsMap = default(Dictionary<string, UdaCustomArgument>), string sourceType = default(string), bool? staticLiveLogView = default(bool?), bool? useS3View = default(bool?))
        {
            this.DeploymentType = deploymentType;
            this.EtEnableLogBackupPolicy = etEnableLogBackupPolicy;
            this.EtEnableRunNow = etEnableRunNow;
            this.FreshFullBackupView = freshFullBackupView;
            this.HostType = hostType;
            this.Hosts = hosts;
            this.LiveDataView = liveDataView;
            this.LiveLogView = liveLogView;
            this.MountDir = mountDir;
            this.MountView = mountView;
            this.ObjectTypes = objectTypes;
            this.ObjectTypesExcludedFromExpansion = objectTypesExcludedFromExpansion;
            this.ParallelLogBackups = parallelLogBackups;
            this.PostBackupJobScriptFailureTolerance = postBackupJobScriptFailureTolerance;
            this.PostRestoreJobScriptFailureTolerance = postRestoreJobScriptFailureTolerance;
            this.PreBackupJobScriptFailureTolerance = preBackupJobScriptFailureTolerance;
            this.PreRestoreJobScriptFailureTolerance = preRestoreJobScriptFailureTolerance;
            this.PreferredControlNodes = preferredControlNodes;
            this.RestrictParallelDataLogBackups = restrictParallelDataLogBackups;
            this.ScriptDir = scriptDir;
            this.SourceArgs = sourceArgs;
            this.SourceArgumentsMap = sourceArgumentsMap;
            this.SourceType = sourceType;
            this.StaticLiveLogView = staticLiveLogView;
            this.UseS3View = useS3View;
            this.Capabilities = capabilities;
            this.Credentials = credentials;
            this.DeploymentType = deploymentType;
            this.EtEnableLogBackupPolicy = etEnableLogBackupPolicy;
            this.EtEnableRunNow = etEnableRunNow;
            this.FreshFullBackupView = freshFullBackupView;
            this.HostType = hostType;
            this.Hosts = hosts;
            this.LiveDataView = liveDataView;
            this.LiveLogView = liveLogView;
            this.MountDir = mountDir;
            this.MountView = mountView;
            this.ObjectTypes = objectTypes;
            this.ObjectTypesExcludedFromExpansion = objectTypesExcludedFromExpansion;
            this.ParallelLogBackups = parallelLogBackups;
            this.PostBackupJobScriptFailureTolerance = postBackupJobScriptFailureTolerance;
            this.PostRestoreJobScriptFailureTolerance = postRestoreJobScriptFailureTolerance;
            this.PreBackupJobScriptFailureTolerance = preBackupJobScriptFailureTolerance;
            this.PreRestoreJobScriptFailureTolerance = preRestoreJobScriptFailureTolerance;
            this.PreferredControlNodes = preferredControlNodes;
            this.RestrictParallelDataLogBackups = restrictParallelDataLogBackups;
            this.ScriptDir = scriptDir;
            this.SourceArgs = sourceArgs;
            this.SourceArgumentsMap = sourceArgumentsMap;
            this.SourceType = sourceType;
            this.StaticLiveLogView = staticLiveLogView;
            this.UseS3View = useS3View;
        }
        
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public UdaSourceCapabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Deployment type for the UDA agent.
        /// </summary>
        /// <value>Deployment type for the UDA agent.</value>
        [DataMember(Name="deploymentType", EmitDefaultValue=true)]
        public int? DeploymentType { get; set; }

        /// <summary>
        /// Specifies whether to enable cohesity policy triggered log backups along with externally triggered backups. Only applicable if externally_triggered_log_backup is true.
        /// </summary>
        /// <value>Specifies whether to enable cohesity policy triggered log backups along with externally triggered backups. Only applicable if externally_triggered_log_backup is true.</value>
        [DataMember(Name="etEnableLogBackupPolicy", EmitDefaultValue=true)]
        public bool? EtEnableLogBackupPolicy { get; set; }

        /// <summary>
        /// Specifies if the user triggered (UI) runs are allowed along with externally triggered runs. Only applicable if externally_triggered_log_backup is true.
        /// </summary>
        /// <value>Specifies if the user triggered (UI) runs are allowed along with externally triggered runs. Only applicable if externally_triggered_log_backup is true.</value>
        [DataMember(Name="etEnableRunNow", EmitDefaultValue=true)]
        public bool? EtEnableRunNow { get; set; }

        /// <summary>
        /// Indicate if a new view is required for full backups.
        /// </summary>
        /// <value>Indicate if a new view is required for full backups.</value>
        [DataMember(Name="freshFullBackupView", EmitDefaultValue=true)]
        public bool? FreshFullBackupView { get; set; }

        /// <summary>
        /// The agent host environment type.
        /// </summary>
        /// <value>The agent host environment type.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public int? HostType { get; set; }

        /// <summary>
        /// List of hosts forming the UDA cluster.
        /// </summary>
        /// <value>List of hosts forming the UDA cluster.</value>
        [DataMember(Name="hosts", EmitDefaultValue=true)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// Should use live view for data backup.
        /// </summary>
        /// <value>Should use live view for data backup.</value>
        [DataMember(Name="liveDataView", EmitDefaultValue=true)]
        public bool? LiveDataView { get; set; }

        /// <summary>
        /// Should use live view for log backup.
        /// </summary>
        /// <value>Should use live view for log backup.</value>
        [DataMember(Name="liveLogView", EmitDefaultValue=true)]
        public bool? LiveLogView { get; set; }

        /// <summary>
        /// Mount directory path to be used for writing the backup to.
        /// </summary>
        /// <value>Mount directory path to be used for writing the backup to.</value>
        [DataMember(Name="mountDir", EmitDefaultValue=true)]
        public string MountDir { get; set; }

        /// <summary>
        /// Whether to mount a view during the source backup.
        /// </summary>
        /// <value>Whether to mount a view during the source backup.</value>
        [DataMember(Name="mountView", EmitDefaultValue=true)]
        public bool? MountView { get; set; }

        /// <summary>
        /// Object levels.
        /// </summary>
        /// <value>Object levels.</value>
        [DataMember(Name="objectTypes", EmitDefaultValue=true)]
        public List<string> ObjectTypes { get; set; }

        /// <summary>
        /// These object types would be excluded from entity hierarchy expansion while expanding entities as part of a backup job run. For instance, when an object of excluded object type is encountered during EH expansion for backup, it would be treated as a leaf entity. Behaviour of other EH expansion operations would remain as is such as EH expansion when a source is refreshed.
        /// </summary>
        /// <value>These object types would be excluded from entity hierarchy expansion while expanding entities as part of a backup job run. For instance, when an object of excluded object type is encountered during EH expansion for backup, it would be treated as a leaf entity. Behaviour of other EH expansion operations would remain as is such as EH expansion when a source is refreshed.</value>
        [DataMember(Name="objectTypesExcludedFromExpansion", EmitDefaultValue=true)]
        public List<string> ObjectTypesExcludedFromExpansion { get; set; }

        /// <summary>
        /// Specifies whether the source supports parallel log backups. Must be used with a live log view.
        /// </summary>
        /// <value>Specifies whether the source supports parallel log backups. Must be used with a live log view.</value>
        [DataMember(Name="parallelLogBackups", EmitDefaultValue=true)]
        public bool? ParallelLogBackups { get; set; }

        /// <summary>
        /// Gets or Sets PostBackupJobScriptFailureTolerance
        /// </summary>
        [DataMember(Name="postBackupJobScriptFailureTolerance", EmitDefaultValue=true)]
        public int? PostBackupJobScriptFailureTolerance { get; set; }

        /// <summary>
        /// Gets or Sets PostRestoreJobScriptFailureTolerance
        /// </summary>
        [DataMember(Name="postRestoreJobScriptFailureTolerance", EmitDefaultValue=true)]
        public int? PostRestoreJobScriptFailureTolerance { get; set; }

        /// <summary>
        /// Gets or Sets PreBackupJobScriptFailureTolerance
        /// </summary>
        [DataMember(Name="preBackupJobScriptFailureTolerance", EmitDefaultValue=true)]
        public int? PreBackupJobScriptFailureTolerance { get; set; }

        /// <summary>
        /// Gets or Sets PreRestoreJobScriptFailureTolerance
        /// </summary>
        [DataMember(Name="preRestoreJobScriptFailureTolerance", EmitDefaultValue=true)]
        public int? PreRestoreJobScriptFailureTolerance { get; set; }

        /// <summary>
        /// Control nodes to connect for control path ops.
        /// </summary>
        /// <value>Control nodes to connect for control path ops.</value>
        [DataMember(Name="preferredControlNodes", EmitDefaultValue=true)]
        public List<string> PreferredControlNodes { get; set; }

        /// <summary>
        /// Specifies whether the source disallows parallel data &amp; log backups.
        /// </summary>
        /// <value>Specifies whether the source disallows parallel data &amp; log backups.</value>
        [DataMember(Name="restrictParallelDataLogBackups", EmitDefaultValue=true)]
        public bool? RestrictParallelDataLogBackups { get; set; }

        /// <summary>
        /// Path where various source scripts will be located.
        /// </summary>
        /// <value>Path where various source scripts will be located.</value>
        [DataMember(Name="scriptDir", EmitDefaultValue=true)]
        public string ScriptDir { get; set; }

        /// <summary>
        /// Custom arguments which will be provided to the source registration scripts. This is deprecated. Use source_args_map instead.
        /// </summary>
        /// <value>Custom arguments which will be provided to the source registration scripts. This is deprecated. Use source_args_map instead.</value>
        [DataMember(Name="sourceArgs", EmitDefaultValue=true)]
        public string SourceArgs { get; set; }

        /// <summary>
        /// Map to store custom arguments which will be provided to the source registration scripts.
        /// </summary>
        /// <value>Map to store custom arguments which will be provided to the source registration scripts.</value>
        [DataMember(Name="sourceArgumentsMap", EmitDefaultValue=true)]
        public Dictionary<string, UdaCustomArgument> SourceArgumentsMap { get; set; }

        /// <summary>
        /// Universal Data Adapter (UDA) source type.
        /// </summary>
        /// <value>Universal Data Adapter (UDA) source type.</value>
        [DataMember(Name="sourceType", EmitDefaultValue=true)]
        public string SourceType { get; set; }

        /// <summary>
        /// Should the live log view be created at the time of first full backup ? This will be passed to all data backups This is not the same as auto_log_backup, since this applies to scheduled log backups and has its limitations
        /// </summary>
        /// <value>Should the live log view be created at the time of first full backup ? This will be passed to all data backups This is not the same as auto_log_backup, since this applies to scheduled log backups and has its limitations</value>
        [DataMember(Name="staticLiveLogView", EmitDefaultValue=true)]
        public bool? StaticLiveLogView { get; set; }

        /// <summary>
        /// Whether S3 views should be used for backup/retore.
        /// </summary>
        /// <value>Whether S3 views should be used for backup/retore.</value>
        [DataMember(Name="useS3View", EmitDefaultValue=true)]
        public bool? UseS3View { get; set; }

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
            return this.Equals(input as RegisteredEntityUdaParams);
        }

        /// <summary>
        /// Returns true if RegisteredEntityUdaParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisteredEntityUdaParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisteredEntityUdaParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.DeploymentType == input.DeploymentType ||
                    (this.DeploymentType != null &&
                    this.DeploymentType.Equals(input.DeploymentType))
                ) && 
                (
                    this.EtEnableLogBackupPolicy == input.EtEnableLogBackupPolicy ||
                    (this.EtEnableLogBackupPolicy != null &&
                    this.EtEnableLogBackupPolicy.Equals(input.EtEnableLogBackupPolicy))
                ) && 
                (
                    this.EtEnableRunNow == input.EtEnableRunNow ||
                    (this.EtEnableRunNow != null &&
                    this.EtEnableRunNow.Equals(input.EtEnableRunNow))
                ) && 
                (
                    this.FreshFullBackupView == input.FreshFullBackupView ||
                    (this.FreshFullBackupView != null &&
                    this.FreshFullBackupView.Equals(input.FreshFullBackupView))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
                ) && 
                (
                    this.LiveDataView == input.LiveDataView ||
                    (this.LiveDataView != null &&
                    this.LiveDataView.Equals(input.LiveDataView))
                ) && 
                (
                    this.LiveLogView == input.LiveLogView ||
                    (this.LiveLogView != null &&
                    this.LiveLogView.Equals(input.LiveLogView))
                ) && 
                (
                    this.MountDir == input.MountDir ||
                    (this.MountDir != null &&
                    this.MountDir.Equals(input.MountDir))
                ) && 
                (
                    this.MountView == input.MountView ||
                    (this.MountView != null &&
                    this.MountView.Equals(input.MountView))
                ) && 
                (
                    this.ObjectTypes == input.ObjectTypes ||
                    this.ObjectTypes != null &&
                    input.ObjectTypes != null &&
                    this.ObjectTypes.SequenceEqual(input.ObjectTypes)
                ) && 
                (
                    this.ObjectTypesExcludedFromExpansion == input.ObjectTypesExcludedFromExpansion ||
                    this.ObjectTypesExcludedFromExpansion != null &&
                    input.ObjectTypesExcludedFromExpansion != null &&
                    this.ObjectTypesExcludedFromExpansion.SequenceEqual(input.ObjectTypesExcludedFromExpansion)
                ) && 
                (
                    this.ParallelLogBackups == input.ParallelLogBackups ||
                    (this.ParallelLogBackups != null &&
                    this.ParallelLogBackups.Equals(input.ParallelLogBackups))
                ) && 
                (
                    this.PostBackupJobScriptFailureTolerance == input.PostBackupJobScriptFailureTolerance ||
                    (this.PostBackupJobScriptFailureTolerance != null &&
                    this.PostBackupJobScriptFailureTolerance.Equals(input.PostBackupJobScriptFailureTolerance))
                ) && 
                (
                    this.PostRestoreJobScriptFailureTolerance == input.PostRestoreJobScriptFailureTolerance ||
                    (this.PostRestoreJobScriptFailureTolerance != null &&
                    this.PostRestoreJobScriptFailureTolerance.Equals(input.PostRestoreJobScriptFailureTolerance))
                ) && 
                (
                    this.PreBackupJobScriptFailureTolerance == input.PreBackupJobScriptFailureTolerance ||
                    (this.PreBackupJobScriptFailureTolerance != null &&
                    this.PreBackupJobScriptFailureTolerance.Equals(input.PreBackupJobScriptFailureTolerance))
                ) && 
                (
                    this.PreRestoreJobScriptFailureTolerance == input.PreRestoreJobScriptFailureTolerance ||
                    (this.PreRestoreJobScriptFailureTolerance != null &&
                    this.PreRestoreJobScriptFailureTolerance.Equals(input.PreRestoreJobScriptFailureTolerance))
                ) && 
                (
                    this.PreferredControlNodes == input.PreferredControlNodes ||
                    this.PreferredControlNodes != null &&
                    input.PreferredControlNodes != null &&
                    this.PreferredControlNodes.SequenceEqual(input.PreferredControlNodes)
                ) && 
                (
                    this.RestrictParallelDataLogBackups == input.RestrictParallelDataLogBackups ||
                    (this.RestrictParallelDataLogBackups != null &&
                    this.RestrictParallelDataLogBackups.Equals(input.RestrictParallelDataLogBackups))
                ) && 
                (
                    this.ScriptDir == input.ScriptDir ||
                    (this.ScriptDir != null &&
                    this.ScriptDir.Equals(input.ScriptDir))
                ) && 
                (
                    this.SourceArgs == input.SourceArgs ||
                    (this.SourceArgs != null &&
                    this.SourceArgs.Equals(input.SourceArgs))
                ) && 
                (
                    this.SourceArgumentsMap == input.SourceArgumentsMap ||
                    this.SourceArgumentsMap != null &&
                    input.SourceArgumentsMap != null &&
                    this.SourceArgumentsMap.SequenceEqual(input.SourceArgumentsMap)
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.StaticLiveLogView == input.StaticLiveLogView ||
                    (this.StaticLiveLogView != null &&
                    this.StaticLiveLogView.Equals(input.StaticLiveLogView))
                ) && 
                (
                    this.UseS3View == input.UseS3View ||
                    (this.UseS3View != null &&
                    this.UseS3View.Equals(input.UseS3View))
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
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.DeploymentType != null)
                    hashCode = hashCode * 59 + this.DeploymentType.GetHashCode();
                if (this.EtEnableLogBackupPolicy != null)
                    hashCode = hashCode * 59 + this.EtEnableLogBackupPolicy.GetHashCode();
                if (this.EtEnableRunNow != null)
                    hashCode = hashCode * 59 + this.EtEnableRunNow.GetHashCode();
                if (this.FreshFullBackupView != null)
                    hashCode = hashCode * 59 + this.FreshFullBackupView.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.LiveDataView != null)
                    hashCode = hashCode * 59 + this.LiveDataView.GetHashCode();
                if (this.LiveLogView != null)
                    hashCode = hashCode * 59 + this.LiveLogView.GetHashCode();
                if (this.MountDir != null)
                    hashCode = hashCode * 59 + this.MountDir.GetHashCode();
                if (this.MountView != null)
                    hashCode = hashCode * 59 + this.MountView.GetHashCode();
                if (this.ObjectTypes != null)
                    hashCode = hashCode * 59 + this.ObjectTypes.GetHashCode();
                if (this.ObjectTypesExcludedFromExpansion != null)
                    hashCode = hashCode * 59 + this.ObjectTypesExcludedFromExpansion.GetHashCode();
                if (this.ParallelLogBackups != null)
                    hashCode = hashCode * 59 + this.ParallelLogBackups.GetHashCode();
                if (this.PostBackupJobScriptFailureTolerance != null)
                    hashCode = hashCode * 59 + this.PostBackupJobScriptFailureTolerance.GetHashCode();
                if (this.PostRestoreJobScriptFailureTolerance != null)
                    hashCode = hashCode * 59 + this.PostRestoreJobScriptFailureTolerance.GetHashCode();
                if (this.PreBackupJobScriptFailureTolerance != null)
                    hashCode = hashCode * 59 + this.PreBackupJobScriptFailureTolerance.GetHashCode();
                if (this.PreRestoreJobScriptFailureTolerance != null)
                    hashCode = hashCode * 59 + this.PreRestoreJobScriptFailureTolerance.GetHashCode();
                if (this.PreferredControlNodes != null)
                    hashCode = hashCode * 59 + this.PreferredControlNodes.GetHashCode();
                if (this.RestrictParallelDataLogBackups != null)
                    hashCode = hashCode * 59 + this.RestrictParallelDataLogBackups.GetHashCode();
                if (this.ScriptDir != null)
                    hashCode = hashCode * 59 + this.ScriptDir.GetHashCode();
                if (this.SourceArgs != null)
                    hashCode = hashCode * 59 + this.SourceArgs.GetHashCode();
                if (this.SourceArgumentsMap != null)
                    hashCode = hashCode * 59 + this.SourceArgumentsMap.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.StaticLiveLogView != null)
                    hashCode = hashCode * 59 + this.StaticLiveLogView.GetHashCode();
                if (this.UseS3View != null)
                    hashCode = hashCode * 59 + this.UseS3View.GetHashCode();
                return hashCode;
            }
        }

    }

}

