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
    /// UdaRecoverJobParams
    /// </summary>
    [DataContract]
    public partial class UdaRecoverJobParams :  IEquatable<UdaRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaRecoverJobParams" /> class.
        /// </summary>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="concurrency">Number of parallel streams to use for the restore..</param>
        /// <param name="deploymentType">Deployment type for the UDA agent..</param>
        /// <param name="externalDiskSku">If using external disks, this parameter will contain the user-requested disk SKU for the slave to consume when requesting a disk from heimdall..</param>
        /// <param name="hostType">The agent host environment type..</param>
        /// <param name="hosts">List of hosts forming the UDA cluster..</param>
        /// <param name="localMountDir">Directory on the host where views will be mounted. (This is deprecated now and the value is derived from a gflag in agent.).</param>
        /// <param name="mountView">Whether to mount a view during restore..</param>
        /// <param name="mounts">Max number of view mounts to use for the restore..</param>
        /// <param name="postRestoreJobScriptFailureTolerance">Enum to indicate next state if post restore source call fails on one or more node..</param>
        /// <param name="preRestoreJobScriptFailureTolerance">Enum to indicate next state if pre restore source call fails on one or more node..</param>
        /// <param name="preferredControlNodes">Control nodes to connect for control path ops..</param>
        /// <param name="restoreArgs">Custom arguments which are applicable to the objects to be restored..</param>
        /// <param name="restoreJobArgumentsMap">Map to store custom arguments which will be provided to the recovery job scripts..</param>
        /// <param name="restoreTargetEntity">restoreTargetEntity.</param>
        /// <param name="restoreTargetEntityParents">Includes UdaRecoverJobParams::restore_target_entity and its parents. Passed so slave can take lock on these..</param>
        /// <param name="runStartTimeUsecs">The time when the corresponding backup run was started..</param>
        /// <param name="scriptDir">Path where the source scripts will be located..</param>
        /// <param name="sourceArgs">Custom arguments which will be provided to the source registration scripts..</param>
        /// <param name="sourceArgumentsMap">Map to store custom arguments which will be provided to the source registration scripts..</param>
        /// <param name="sourceType">Universal Data Adapter source type for which recovery is being performed..</param>
        /// <param name="udaS3ViewBackupProperties">udaS3ViewBackupProperties.</param>
        /// <param name="useS3View">Whether S3 views should be used for restore..</param>
        public UdaRecoverJobParams(UdaSourceCapabilities capabilities = default(UdaSourceCapabilities), int? concurrency = default(int?), int? deploymentType = default(int?), string externalDiskSku = default(string), int? hostType = default(int?), List<string> hosts = default(List<string>), string localMountDir = default(string), bool? mountView = default(bool?), int? mounts = default(int?), int? postRestoreJobScriptFailureTolerance = default(int?), int? preRestoreJobScriptFailureTolerance = default(int?), List<string> preferredControlNodes = default(List<string>), string restoreArgs = default(string), Dictionary<string, UdaCustomArgument> restoreJobArgumentsMap = default(Dictionary<string, UdaCustomArgument>), EntityProto restoreTargetEntity = default(EntityProto), List<EntityProto> restoreTargetEntityParents = default(List<EntityProto>), long? runStartTimeUsecs = default(long?), string scriptDir = default(string), string sourceArgs = default(string), Dictionary<string, UdaCustomArgument> sourceArgumentsMap = default(Dictionary<string, UdaCustomArgument>), string sourceType = default(string), UdaS3ViewBackupProperties udaS3ViewBackupProperties = default(UdaS3ViewBackupProperties), bool? useS3View = default(bool?))
        {
            this.Concurrency = concurrency;
            this.DeploymentType = deploymentType;
            this.ExternalDiskSku = externalDiskSku;
            this.HostType = hostType;
            this.Hosts = hosts;
            this.LocalMountDir = localMountDir;
            this.MountView = mountView;
            this.Mounts = mounts;
            this.PostRestoreJobScriptFailureTolerance = postRestoreJobScriptFailureTolerance;
            this.PreRestoreJobScriptFailureTolerance = preRestoreJobScriptFailureTolerance;
            this.PreferredControlNodes = preferredControlNodes;
            this.RestoreArgs = restoreArgs;
            this.RestoreJobArgumentsMap = restoreJobArgumentsMap;
            this.RestoreTargetEntityParents = restoreTargetEntityParents;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.ScriptDir = scriptDir;
            this.SourceArgs = sourceArgs;
            this.SourceArgumentsMap = sourceArgumentsMap;
            this.SourceType = sourceType;
            this.UseS3View = useS3View;
            this.Capabilities = capabilities;
            this.Concurrency = concurrency;
            this.DeploymentType = deploymentType;
            this.ExternalDiskSku = externalDiskSku;
            this.HostType = hostType;
            this.Hosts = hosts;
            this.LocalMountDir = localMountDir;
            this.MountView = mountView;
            this.Mounts = mounts;
            this.PostRestoreJobScriptFailureTolerance = postRestoreJobScriptFailureTolerance;
            this.PreRestoreJobScriptFailureTolerance = preRestoreJobScriptFailureTolerance;
            this.PreferredControlNodes = preferredControlNodes;
            this.RestoreArgs = restoreArgs;
            this.RestoreJobArgumentsMap = restoreJobArgumentsMap;
            this.RestoreTargetEntity = restoreTargetEntity;
            this.RestoreTargetEntityParents = restoreTargetEntityParents;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.ScriptDir = scriptDir;
            this.SourceArgs = sourceArgs;
            this.SourceArgumentsMap = sourceArgumentsMap;
            this.SourceType = sourceType;
            this.UdaS3ViewBackupProperties = udaS3ViewBackupProperties;
            this.UseS3View = useS3View;
        }
        
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public UdaSourceCapabilities Capabilities { get; set; }

        /// <summary>
        /// Number of parallel streams to use for the restore.
        /// </summary>
        /// <value>Number of parallel streams to use for the restore.</value>
        [DataMember(Name="concurrency", EmitDefaultValue=true)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Deployment type for the UDA agent.
        /// </summary>
        /// <value>Deployment type for the UDA agent.</value>
        [DataMember(Name="deploymentType", EmitDefaultValue=true)]
        public int? DeploymentType { get; set; }

        /// <summary>
        /// If using external disks, this parameter will contain the user-requested disk SKU for the slave to consume when requesting a disk from heimdall.
        /// </summary>
        /// <value>If using external disks, this parameter will contain the user-requested disk SKU for the slave to consume when requesting a disk from heimdall.</value>
        [DataMember(Name="externalDiskSku", EmitDefaultValue=true)]
        public string ExternalDiskSku { get; set; }

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
        /// Directory on the host where views will be mounted. (This is deprecated now and the value is derived from a gflag in agent.)
        /// </summary>
        /// <value>Directory on the host where views will be mounted. (This is deprecated now and the value is derived from a gflag in agent.)</value>
        [DataMember(Name="localMountDir", EmitDefaultValue=true)]
        public string LocalMountDir { get; set; }

        /// <summary>
        /// Whether to mount a view during restore.
        /// </summary>
        /// <value>Whether to mount a view during restore.</value>
        [DataMember(Name="mountView", EmitDefaultValue=true)]
        public bool? MountView { get; set; }

        /// <summary>
        /// Max number of view mounts to use for the restore.
        /// </summary>
        /// <value>Max number of view mounts to use for the restore.</value>
        [DataMember(Name="mounts", EmitDefaultValue=true)]
        public int? Mounts { get; set; }

        /// <summary>
        /// Enum to indicate next state if post restore source call fails on one or more node.
        /// </summary>
        /// <value>Enum to indicate next state if post restore source call fails on one or more node.</value>
        [DataMember(Name="postRestoreJobScriptFailureTolerance", EmitDefaultValue=true)]
        public int? PostRestoreJobScriptFailureTolerance { get; set; }

        /// <summary>
        /// Enum to indicate next state if pre restore source call fails on one or more node.
        /// </summary>
        /// <value>Enum to indicate next state if pre restore source call fails on one or more node.</value>
        [DataMember(Name="preRestoreJobScriptFailureTolerance", EmitDefaultValue=true)]
        public int? PreRestoreJobScriptFailureTolerance { get; set; }

        /// <summary>
        /// Control nodes to connect for control path ops.
        /// </summary>
        /// <value>Control nodes to connect for control path ops.</value>
        [DataMember(Name="preferredControlNodes", EmitDefaultValue=true)]
        public List<string> PreferredControlNodes { get; set; }

        /// <summary>
        /// Custom arguments which are applicable to the objects to be restored.
        /// </summary>
        /// <value>Custom arguments which are applicable to the objects to be restored.</value>
        [DataMember(Name="restoreArgs", EmitDefaultValue=true)]
        public string RestoreArgs { get; set; }

        /// <summary>
        /// Map to store custom arguments which will be provided to the recovery job scripts.
        /// </summary>
        /// <value>Map to store custom arguments which will be provided to the recovery job scripts.</value>
        [DataMember(Name="restoreJobArgumentsMap", EmitDefaultValue=true)]
        public Dictionary<string, UdaCustomArgument> RestoreJobArgumentsMap { get; set; }

        /// <summary>
        /// Gets or Sets RestoreTargetEntity
        /// </summary>
        [DataMember(Name="restoreTargetEntity", EmitDefaultValue=false)]
        public EntityProto RestoreTargetEntity { get; set; }

        /// <summary>
        /// Includes UdaRecoverJobParams::restore_target_entity and its parents. Passed so slave can take lock on these.
        /// </summary>
        /// <value>Includes UdaRecoverJobParams::restore_target_entity and its parents. Passed so slave can take lock on these.</value>
        [DataMember(Name="restoreTargetEntityParents", EmitDefaultValue=true)]
        public List<EntityProto> RestoreTargetEntityParents { get; set; }

        /// <summary>
        /// The time when the corresponding backup run was started.
        /// </summary>
        /// <value>The time when the corresponding backup run was started.</value>
        [DataMember(Name="runStartTimeUsecs", EmitDefaultValue=true)]
        public long? RunStartTimeUsecs { get; set; }

        /// <summary>
        /// Path where the source scripts will be located.
        /// </summary>
        /// <value>Path where the source scripts will be located.</value>
        [DataMember(Name="scriptDir", EmitDefaultValue=true)]
        public string ScriptDir { get; set; }

        /// <summary>
        /// Custom arguments which will be provided to the source registration scripts.
        /// </summary>
        /// <value>Custom arguments which will be provided to the source registration scripts.</value>
        [DataMember(Name="sourceArgs", EmitDefaultValue=true)]
        public string SourceArgs { get; set; }

        /// <summary>
        /// Map to store custom arguments which will be provided to the source registration scripts.
        /// </summary>
        /// <value>Map to store custom arguments which will be provided to the source registration scripts.</value>
        [DataMember(Name="sourceArgumentsMap", EmitDefaultValue=true)]
        public Dictionary<string, UdaCustomArgument> SourceArgumentsMap { get; set; }

        /// <summary>
        /// Universal Data Adapter source type for which recovery is being performed.
        /// </summary>
        /// <value>Universal Data Adapter source type for which recovery is being performed.</value>
        [DataMember(Name="sourceType", EmitDefaultValue=true)]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or Sets UdaS3ViewBackupProperties
        /// </summary>
        [DataMember(Name="udaS3ViewBackupProperties", EmitDefaultValue=false)]
        public UdaS3ViewBackupProperties UdaS3ViewBackupProperties { get; set; }

        /// <summary>
        /// Whether S3 views should be used for restore.
        /// </summary>
        /// <value>Whether S3 views should be used for restore.</value>
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
            return this.Equals(input as UdaRecoverJobParams);
        }

        /// <summary>
        /// Returns true if UdaRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaRecoverJobParams input)
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
                    this.Concurrency == input.Concurrency ||
                    (this.Concurrency != null &&
                    this.Concurrency.Equals(input.Concurrency))
                ) && 
                (
                    this.DeploymentType == input.DeploymentType ||
                    (this.DeploymentType != null &&
                    this.DeploymentType.Equals(input.DeploymentType))
                ) && 
                (
                    this.ExternalDiskSku == input.ExternalDiskSku ||
                    (this.ExternalDiskSku != null &&
                    this.ExternalDiskSku.Equals(input.ExternalDiskSku))
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
                    this.LocalMountDir == input.LocalMountDir ||
                    (this.LocalMountDir != null &&
                    this.LocalMountDir.Equals(input.LocalMountDir))
                ) && 
                (
                    this.MountView == input.MountView ||
                    (this.MountView != null &&
                    this.MountView.Equals(input.MountView))
                ) && 
                (
                    this.Mounts == input.Mounts ||
                    (this.Mounts != null &&
                    this.Mounts.Equals(input.Mounts))
                ) && 
                (
                    this.PostRestoreJobScriptFailureTolerance == input.PostRestoreJobScriptFailureTolerance ||
                    (this.PostRestoreJobScriptFailureTolerance != null &&
                    this.PostRestoreJobScriptFailureTolerance.Equals(input.PostRestoreJobScriptFailureTolerance))
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
                    this.RestoreArgs == input.RestoreArgs ||
                    (this.RestoreArgs != null &&
                    this.RestoreArgs.Equals(input.RestoreArgs))
                ) && 
                (
                    this.RestoreJobArgumentsMap == input.RestoreJobArgumentsMap ||
                    this.RestoreJobArgumentsMap != null &&
                    input.RestoreJobArgumentsMap != null &&
                    this.RestoreJobArgumentsMap.SequenceEqual(input.RestoreJobArgumentsMap)
                ) && 
                (
                    this.RestoreTargetEntity == input.RestoreTargetEntity ||
                    (this.RestoreTargetEntity != null &&
                    this.RestoreTargetEntity.Equals(input.RestoreTargetEntity))
                ) && 
                (
                    this.RestoreTargetEntityParents == input.RestoreTargetEntityParents ||
                    this.RestoreTargetEntityParents != null &&
                    input.RestoreTargetEntityParents != null &&
                    this.RestoreTargetEntityParents.SequenceEqual(input.RestoreTargetEntityParents)
                ) && 
                (
                    this.RunStartTimeUsecs == input.RunStartTimeUsecs ||
                    (this.RunStartTimeUsecs != null &&
                    this.RunStartTimeUsecs.Equals(input.RunStartTimeUsecs))
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
                    this.UdaS3ViewBackupProperties == input.UdaS3ViewBackupProperties ||
                    (this.UdaS3ViewBackupProperties != null &&
                    this.UdaS3ViewBackupProperties.Equals(input.UdaS3ViewBackupProperties))
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
                if (this.Concurrency != null)
                    hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.DeploymentType != null)
                    hashCode = hashCode * 59 + this.DeploymentType.GetHashCode();
                if (this.ExternalDiskSku != null)
                    hashCode = hashCode * 59 + this.ExternalDiskSku.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.LocalMountDir != null)
                    hashCode = hashCode * 59 + this.LocalMountDir.GetHashCode();
                if (this.MountView != null)
                    hashCode = hashCode * 59 + this.MountView.GetHashCode();
                if (this.Mounts != null)
                    hashCode = hashCode * 59 + this.Mounts.GetHashCode();
                if (this.PostRestoreJobScriptFailureTolerance != null)
                    hashCode = hashCode * 59 + this.PostRestoreJobScriptFailureTolerance.GetHashCode();
                if (this.PreRestoreJobScriptFailureTolerance != null)
                    hashCode = hashCode * 59 + this.PreRestoreJobScriptFailureTolerance.GetHashCode();
                if (this.PreferredControlNodes != null)
                    hashCode = hashCode * 59 + this.PreferredControlNodes.GetHashCode();
                if (this.RestoreArgs != null)
                    hashCode = hashCode * 59 + this.RestoreArgs.GetHashCode();
                if (this.RestoreJobArgumentsMap != null)
                    hashCode = hashCode * 59 + this.RestoreJobArgumentsMap.GetHashCode();
                if (this.RestoreTargetEntity != null)
                    hashCode = hashCode * 59 + this.RestoreTargetEntity.GetHashCode();
                if (this.RestoreTargetEntityParents != null)
                    hashCode = hashCode * 59 + this.RestoreTargetEntityParents.GetHashCode();
                if (this.RunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RunStartTimeUsecs.GetHashCode();
                if (this.ScriptDir != null)
                    hashCode = hashCode * 59 + this.ScriptDir.GetHashCode();
                if (this.SourceArgs != null)
                    hashCode = hashCode * 59 + this.SourceArgs.GetHashCode();
                if (this.SourceArgumentsMap != null)
                    hashCode = hashCode * 59 + this.SourceArgumentsMap.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.UdaS3ViewBackupProperties != null)
                    hashCode = hashCode * 59 + this.UdaS3ViewBackupProperties.GetHashCode();
                if (this.UseS3View != null)
                    hashCode = hashCode * 59 + this.UseS3View.GetHashCode();
                return hashCode;
            }
        }

    }

}

