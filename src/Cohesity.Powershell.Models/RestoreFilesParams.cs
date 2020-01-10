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
    /// This message captures all the necessary arguments specified by the user to restore files to the source.
    /// </summary>
    [DataContract]
    public partial class RestoreFilesParams :  IEquatable<RestoreFilesParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFilesParams" /> class.
        /// </summary>
        /// <param name="directoryNameSecurityStyleMap">Directory name security style map contains mapping of the directory name to security style it supports.  This is needed to restore the same permission for the given directory for Qtrees..</param>
        /// <param name="isArchiveFlr">Whether this is a file restore operation from an archive..</param>
        /// <param name="isFileVolumeRestore">Whether this is a file based volume restore..</param>
        /// <param name="isMountBasedFlr">Whether this is a mount based file restore operation.</param>
        /// <param name="nasProtocolTypeVec">The NAS protocol type(s) of this restore task. Currently we only support a single restore type. This field is only populated for NAS restore tasks..</param>
        /// <param name="proxyEntity">proxyEntity.</param>
        /// <param name="proxyEntityParentSource">proxyEntityParentSource.</param>
        /// <param name="restoreFilesPreferences">restoreFilesPreferences.</param>
        /// <param name="restoredFileInfoVec">Information regarding files and directories..</param>
        /// <param name="targetEntity">targetEntity.</param>
        /// <param name="targetEntityCredentials">targetEntityCredentials.</param>
        /// <param name="targetEntityParentSource">targetEntityParentSource.</param>
        /// <param name="targetHostEntity">targetHostEntity.</param>
        /// <param name="targetHostType">The host environment type. This is set in VMware environment to indicate the OS type of the target entity. NOTE: This is expected to be set since magneto does not know the host type for VMware entities..</param>
        /// <param name="vpcConnectorEntity">vpcConnectorEntity.</param>
        public RestoreFilesParams(List<RestoreFilesParamsDirectoryNameSecurityStyleMapEntry> directoryNameSecurityStyleMap = default(List<RestoreFilesParamsDirectoryNameSecurityStyleMapEntry>), bool? isArchiveFlr = default(bool?), bool? isFileVolumeRestore = default(bool?), bool? isMountBasedFlr = default(bool?), List<int> nasProtocolTypeVec = default(List<int>), EntityProto proxyEntity = default(EntityProto), EntityProto proxyEntityParentSource = default(EntityProto), RestoreFilesPreferences restoreFilesPreferences = default(RestoreFilesPreferences), List<RestoredFileInfo> restoredFileInfoVec = default(List<RestoredFileInfo>), EntityProto targetEntity = default(EntityProto), Credentials targetEntityCredentials = default(Credentials), EntityProto targetEntityParentSource = default(EntityProto), EntityProto targetHostEntity = default(EntityProto), int? targetHostType = default(int?), EntityProto vpcConnectorEntity = default(EntityProto))
        {
            this.DirectoryNameSecurityStyleMap = directoryNameSecurityStyleMap;
            this.IsArchiveFlr = isArchiveFlr;
            this.IsFileVolumeRestore = isFileVolumeRestore;
            this.IsMountBasedFlr = isMountBasedFlr;
            this.NasProtocolTypeVec = nasProtocolTypeVec;
            this.RestoredFileInfoVec = restoredFileInfoVec;
            this.TargetHostType = targetHostType;
            this.DirectoryNameSecurityStyleMap = directoryNameSecurityStyleMap;
            this.IsArchiveFlr = isArchiveFlr;
            this.IsFileVolumeRestore = isFileVolumeRestore;
            this.IsMountBasedFlr = isMountBasedFlr;
            this.NasProtocolTypeVec = nasProtocolTypeVec;
            this.ProxyEntity = proxyEntity;
            this.ProxyEntityParentSource = proxyEntityParentSource;
            this.RestoreFilesPreferences = restoreFilesPreferences;
            this.RestoredFileInfoVec = restoredFileInfoVec;
            this.TargetEntity = targetEntity;
            this.TargetEntityCredentials = targetEntityCredentials;
            this.TargetEntityParentSource = targetEntityParentSource;
            this.TargetHostEntity = targetHostEntity;
            this.TargetHostType = targetHostType;
            this.VpcConnectorEntity = vpcConnectorEntity;
        }
        
        /// <summary>
        /// Directory name security style map contains mapping of the directory name to security style it supports.  This is needed to restore the same permission for the given directory for Qtrees.
        /// </summary>
        /// <value>Directory name security style map contains mapping of the directory name to security style it supports.  This is needed to restore the same permission for the given directory for Qtrees.</value>
        [DataMember(Name="directoryNameSecurityStyleMap", EmitDefaultValue=true)]
        public List<RestoreFilesParamsDirectoryNameSecurityStyleMapEntry> DirectoryNameSecurityStyleMap { get; set; }

        /// <summary>
        /// Whether this is a file restore operation from an archive.
        /// </summary>
        /// <value>Whether this is a file restore operation from an archive.</value>
        [DataMember(Name="isArchiveFlr", EmitDefaultValue=true)]
        public bool? IsArchiveFlr { get; set; }

        /// <summary>
        /// Whether this is a file based volume restore.
        /// </summary>
        /// <value>Whether this is a file based volume restore.</value>
        [DataMember(Name="isFileVolumeRestore", EmitDefaultValue=true)]
        public bool? IsFileVolumeRestore { get; set; }

        /// <summary>
        /// Whether this is a mount based file restore operation
        /// </summary>
        /// <value>Whether this is a mount based file restore operation</value>
        [DataMember(Name="isMountBasedFlr", EmitDefaultValue=true)]
        public bool? IsMountBasedFlr { get; set; }

        /// <summary>
        /// The NAS protocol type(s) of this restore task. Currently we only support a single restore type. This field is only populated for NAS restore tasks.
        /// </summary>
        /// <value>The NAS protocol type(s) of this restore task. Currently we only support a single restore type. This field is only populated for NAS restore tasks.</value>
        [DataMember(Name="nasProtocolTypeVec", EmitDefaultValue=true)]
        public List<int> NasProtocolTypeVec { get; set; }

        /// <summary>
        /// Gets or Sets ProxyEntity
        /// </summary>
        [DataMember(Name="proxyEntity", EmitDefaultValue=false)]
        public EntityProto ProxyEntity { get; set; }

        /// <summary>
        /// Gets or Sets ProxyEntityParentSource
        /// </summary>
        [DataMember(Name="proxyEntityParentSource", EmitDefaultValue=false)]
        public EntityProto ProxyEntityParentSource { get; set; }

        /// <summary>
        /// Gets or Sets RestoreFilesPreferences
        /// </summary>
        [DataMember(Name="restoreFilesPreferences", EmitDefaultValue=false)]
        public RestoreFilesPreferences RestoreFilesPreferences { get; set; }

        /// <summary>
        /// Information regarding files and directories.
        /// </summary>
        /// <value>Information regarding files and directories.</value>
        [DataMember(Name="restoredFileInfoVec", EmitDefaultValue=true)]
        public List<RestoredFileInfo> RestoredFileInfoVec { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntityCredentials
        /// </summary>
        [DataMember(Name="targetEntityCredentials", EmitDefaultValue=false)]
        public Credentials TargetEntityCredentials { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntityParentSource
        /// </summary>
        [DataMember(Name="targetEntityParentSource", EmitDefaultValue=false)]
        public EntityProto TargetEntityParentSource { get; set; }

        /// <summary>
        /// Gets or Sets TargetHostEntity
        /// </summary>
        [DataMember(Name="targetHostEntity", EmitDefaultValue=false)]
        public EntityProto TargetHostEntity { get; set; }

        /// <summary>
        /// The host environment type. This is set in VMware environment to indicate the OS type of the target entity. NOTE: This is expected to be set since magneto does not know the host type for VMware entities.
        /// </summary>
        /// <value>The host environment type. This is set in VMware environment to indicate the OS type of the target entity. NOTE: This is expected to be set since magneto does not know the host type for VMware entities.</value>
        [DataMember(Name="targetHostType", EmitDefaultValue=true)]
        public int? TargetHostType { get; set; }

        /// <summary>
        /// Gets or Sets VpcConnectorEntity
        /// </summary>
        [DataMember(Name="vpcConnectorEntity", EmitDefaultValue=false)]
        public EntityProto VpcConnectorEntity { get; set; }

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
            return this.Equals(input as RestoreFilesParams);
        }

        /// <summary>
        /// Returns true if RestoreFilesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFilesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFilesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirectoryNameSecurityStyleMap == input.DirectoryNameSecurityStyleMap ||
                    this.DirectoryNameSecurityStyleMap != null &&
                    input.DirectoryNameSecurityStyleMap != null &&
                    this.DirectoryNameSecurityStyleMap.SequenceEqual(input.DirectoryNameSecurityStyleMap)
                ) && 
                (
                    this.IsArchiveFlr == input.IsArchiveFlr ||
                    (this.IsArchiveFlr != null &&
                    this.IsArchiveFlr.Equals(input.IsArchiveFlr))
                ) && 
                (
                    this.IsFileVolumeRestore == input.IsFileVolumeRestore ||
                    (this.IsFileVolumeRestore != null &&
                    this.IsFileVolumeRestore.Equals(input.IsFileVolumeRestore))
                ) && 
                (
                    this.IsMountBasedFlr == input.IsMountBasedFlr ||
                    (this.IsMountBasedFlr != null &&
                    this.IsMountBasedFlr.Equals(input.IsMountBasedFlr))
                ) && 
                (
                    this.NasProtocolTypeVec == input.NasProtocolTypeVec ||
                    this.NasProtocolTypeVec != null &&
                    input.NasProtocolTypeVec != null &&
                    this.NasProtocolTypeVec.SequenceEqual(input.NasProtocolTypeVec)
                ) && 
                (
                    this.ProxyEntity == input.ProxyEntity ||
                    (this.ProxyEntity != null &&
                    this.ProxyEntity.Equals(input.ProxyEntity))
                ) && 
                (
                    this.ProxyEntityParentSource == input.ProxyEntityParentSource ||
                    (this.ProxyEntityParentSource != null &&
                    this.ProxyEntityParentSource.Equals(input.ProxyEntityParentSource))
                ) && 
                (
                    this.RestoreFilesPreferences == input.RestoreFilesPreferences ||
                    (this.RestoreFilesPreferences != null &&
                    this.RestoreFilesPreferences.Equals(input.RestoreFilesPreferences))
                ) && 
                (
                    this.RestoredFileInfoVec == input.RestoredFileInfoVec ||
                    this.RestoredFileInfoVec != null &&
                    input.RestoredFileInfoVec != null &&
                    this.RestoredFileInfoVec.SequenceEqual(input.RestoredFileInfoVec)
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
                ) && 
                (
                    this.TargetEntityCredentials == input.TargetEntityCredentials ||
                    (this.TargetEntityCredentials != null &&
                    this.TargetEntityCredentials.Equals(input.TargetEntityCredentials))
                ) && 
                (
                    this.TargetEntityParentSource == input.TargetEntityParentSource ||
                    (this.TargetEntityParentSource != null &&
                    this.TargetEntityParentSource.Equals(input.TargetEntityParentSource))
                ) && 
                (
                    this.TargetHostEntity == input.TargetHostEntity ||
                    (this.TargetHostEntity != null &&
                    this.TargetHostEntity.Equals(input.TargetHostEntity))
                ) && 
                (
                    this.TargetHostType == input.TargetHostType ||
                    (this.TargetHostType != null &&
                    this.TargetHostType.Equals(input.TargetHostType))
                ) && 
                (
                    this.VpcConnectorEntity == input.VpcConnectorEntity ||
                    (this.VpcConnectorEntity != null &&
                    this.VpcConnectorEntity.Equals(input.VpcConnectorEntity))
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
                if (this.DirectoryNameSecurityStyleMap != null)
                    hashCode = hashCode * 59 + this.DirectoryNameSecurityStyleMap.GetHashCode();
                if (this.IsArchiveFlr != null)
                    hashCode = hashCode * 59 + this.IsArchiveFlr.GetHashCode();
                if (this.IsFileVolumeRestore != null)
                    hashCode = hashCode * 59 + this.IsFileVolumeRestore.GetHashCode();
                if (this.IsMountBasedFlr != null)
                    hashCode = hashCode * 59 + this.IsMountBasedFlr.GetHashCode();
                if (this.NasProtocolTypeVec != null)
                    hashCode = hashCode * 59 + this.NasProtocolTypeVec.GetHashCode();
                if (this.ProxyEntity != null)
                    hashCode = hashCode * 59 + this.ProxyEntity.GetHashCode();
                if (this.ProxyEntityParentSource != null)
                    hashCode = hashCode * 59 + this.ProxyEntityParentSource.GetHashCode();
                if (this.RestoreFilesPreferences != null)
                    hashCode = hashCode * 59 + this.RestoreFilesPreferences.GetHashCode();
                if (this.RestoredFileInfoVec != null)
                    hashCode = hashCode * 59 + this.RestoredFileInfoVec.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.TargetEntityCredentials != null)
                    hashCode = hashCode * 59 + this.TargetEntityCredentials.GetHashCode();
                if (this.TargetEntityParentSource != null)
                    hashCode = hashCode * 59 + this.TargetEntityParentSource.GetHashCode();
                if (this.TargetHostEntity != null)
                    hashCode = hashCode * 59 + this.TargetHostEntity.GetHashCode();
                if (this.TargetHostType != null)
                    hashCode = hashCode * 59 + this.TargetHostType.GetHashCode();
                if (this.VpcConnectorEntity != null)
                    hashCode = hashCode * 59 + this.VpcConnectorEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

