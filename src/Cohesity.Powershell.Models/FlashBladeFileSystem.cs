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
    /// Specifies information about a Flash Blade File System in a Storage Array.
    /// </summary>
    [DataContract]
    public partial class FlashBladeFileSystem :  IEquatable<FlashBladeFileSystem>
    {
        /// <summary>
        /// Defines Protocols
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolsEnum
        {
            /// <summary>
            /// Enum KNfs for value: kNfs
            /// </summary>
            [EnumMember(Value = "kNfs")]
            KNfs = 1,

            /// <summary>
            /// Enum KCifs2 for value: kCifs2
            /// </summary>
            [EnumMember(Value = "kCifs2")]
            KCifs2 = 2,

            /// <summary>
            /// Enum KHttp for value: kHttp
            /// </summary>
            [EnumMember(Value = "kHttp")]
            KHttp = 3

        }


        /// <summary>
        /// List of Protocols.  Specifies the list of protocols enabled on the file system. &#39;kNfs&#39; indicates NFS exports are supported on Pure FlashBlade File System. &#39;kCifs2&#39; indicates CIFS/SMB Shares are supported on Pure FlashBlade File System. &#39;kHttp&#39; indicates object protocol over HTTP and HTTPS are supported.
        /// </summary>
        /// <value>List of Protocols.  Specifies the list of protocols enabled on the file system. &#39;kNfs&#39; indicates NFS exports are supported on Pure FlashBlade File System. &#39;kCifs2&#39; indicates CIFS/SMB Shares are supported on Pure FlashBlade File System. &#39;kHttp&#39; indicates object protocol over HTTP and HTTPS are supported.</value>
        [DataMember(Name="protocols", EmitDefaultValue=true)]
        public List<ProtocolsEnum> Protocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashBladeFileSystem" /> class.
        /// </summary>
        /// <param name="backupEnabled">Specifies whether the .snapshot directory exists on the file system. Backup is enabled only if the directory exists..</param>
        /// <param name="createdTimeMsecs">Specifies the time when the filesystem was created in Unix epoch time in milliseconds..</param>
        /// <param name="logicalCapacityBytes">Specifies the total capacity in bytes of the file system..</param>
        /// <param name="logicalUsedBytes">Specifies the size of logical data currently represented on the file system in bytes..</param>
        /// <param name="nfsInfo">nfsInfo.</param>
        /// <param name="physicalUsedBytes">Specifies the size of physical data currently consumed by the file system. This includes the space used for the snapshots..</param>
        /// <param name="protocols">List of Protocols.  Specifies the list of protocols enabled on the file system. &#39;kNfs&#39; indicates NFS exports are supported on Pure FlashBlade File System. &#39;kCifs2&#39; indicates CIFS/SMB Shares are supported on Pure FlashBlade File System. &#39;kHttp&#39; indicates object protocol over HTTP and HTTPS are supported..</param>
        /// <param name="smbInfo">smbInfo.</param>
        /// <param name="uniqueUsedBytes">Specifies the size of physical data cconsumed by the file system itself not including the size of the snapshots..</param>
        public FlashBladeFileSystem(bool? backupEnabled = default(bool?), long? createdTimeMsecs = default(long?), long? logicalCapacityBytes = default(long?), long? logicalUsedBytes = default(long?), FlashBladeNfsInfo nfsInfo = default(FlashBladeNfsInfo), long? physicalUsedBytes = default(long?), List<ProtocolsEnum> protocols = default(List<ProtocolsEnum>), FlashBladeSmbInfo smbInfo = default(FlashBladeSmbInfo), long? uniqueUsedBytes = default(long?))
        {
            this.BackupEnabled = backupEnabled;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.LogicalCapacityBytes = logicalCapacityBytes;
            this.LogicalUsedBytes = logicalUsedBytes;
            this.PhysicalUsedBytes = physicalUsedBytes;
            this.Protocols = protocols;
            this.UniqueUsedBytes = uniqueUsedBytes;
            this.BackupEnabled = backupEnabled;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.LogicalCapacityBytes = logicalCapacityBytes;
            this.LogicalUsedBytes = logicalUsedBytes;
            this.NfsInfo = nfsInfo;
            this.PhysicalUsedBytes = physicalUsedBytes;
            this.Protocols = protocols;
            this.SmbInfo = smbInfo;
            this.UniqueUsedBytes = uniqueUsedBytes;
        }
        
        /// <summary>
        /// Specifies whether the .snapshot directory exists on the file system. Backup is enabled only if the directory exists.
        /// </summary>
        /// <value>Specifies whether the .snapshot directory exists on the file system. Backup is enabled only if the directory exists.</value>
        [DataMember(Name="backupEnabled", EmitDefaultValue=true)]
        public bool? BackupEnabled { get; set; }

        /// <summary>
        /// Specifies the time when the filesystem was created in Unix epoch time in milliseconds.
        /// </summary>
        /// <value>Specifies the time when the filesystem was created in Unix epoch time in milliseconds.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the total capacity in bytes of the file system.
        /// </summary>
        /// <value>Specifies the total capacity in bytes of the file system.</value>
        [DataMember(Name="logicalCapacityBytes", EmitDefaultValue=true)]
        public long? LogicalCapacityBytes { get; set; }

        /// <summary>
        /// Specifies the size of logical data currently represented on the file system in bytes.
        /// </summary>
        /// <value>Specifies the size of logical data currently represented on the file system in bytes.</value>
        [DataMember(Name="logicalUsedBytes", EmitDefaultValue=true)]
        public long? LogicalUsedBytes { get; set; }

        /// <summary>
        /// Gets or Sets NfsInfo
        /// </summary>
        [DataMember(Name="nfsInfo", EmitDefaultValue=false)]
        public FlashBladeNfsInfo NfsInfo { get; set; }

        /// <summary>
        /// Specifies the size of physical data currently consumed by the file system. This includes the space used for the snapshots.
        /// </summary>
        /// <value>Specifies the size of physical data currently consumed by the file system. This includes the space used for the snapshots.</value>
        [DataMember(Name="physicalUsedBytes", EmitDefaultValue=true)]
        public long? PhysicalUsedBytes { get; set; }

        /// <summary>
        /// Gets or Sets SmbInfo
        /// </summary>
        [DataMember(Name="smbInfo", EmitDefaultValue=false)]
        public FlashBladeSmbInfo SmbInfo { get; set; }

        /// <summary>
        /// Specifies the size of physical data cconsumed by the file system itself not including the size of the snapshots.
        /// </summary>
        /// <value>Specifies the size of physical data cconsumed by the file system itself not including the size of the snapshots.</value>
        [DataMember(Name="uniqueUsedBytes", EmitDefaultValue=true)]
        public long? UniqueUsedBytes { get; set; }

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
            return this.Equals(input as FlashBladeFileSystem);
        }

        /// <summary>
        /// Returns true if FlashBladeFileSystem instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashBladeFileSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashBladeFileSystem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupEnabled == input.BackupEnabled ||
                    (this.BackupEnabled != null &&
                    this.BackupEnabled.Equals(input.BackupEnabled))
                ) && 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.LogicalCapacityBytes == input.LogicalCapacityBytes ||
                    (this.LogicalCapacityBytes != null &&
                    this.LogicalCapacityBytes.Equals(input.LogicalCapacityBytes))
                ) && 
                (
                    this.LogicalUsedBytes == input.LogicalUsedBytes ||
                    (this.LogicalUsedBytes != null &&
                    this.LogicalUsedBytes.Equals(input.LogicalUsedBytes))
                ) && 
                (
                    this.NfsInfo == input.NfsInfo ||
                    (this.NfsInfo != null &&
                    this.NfsInfo.Equals(input.NfsInfo))
                ) && 
                (
                    this.PhysicalUsedBytes == input.PhysicalUsedBytes ||
                    (this.PhysicalUsedBytes != null &&
                    this.PhysicalUsedBytes.Equals(input.PhysicalUsedBytes))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    this.Protocols.SequenceEqual(input.Protocols)
                ) && 
                (
                    this.SmbInfo == input.SmbInfo ||
                    (this.SmbInfo != null &&
                    this.SmbInfo.Equals(input.SmbInfo))
                ) && 
                (
                    this.UniqueUsedBytes == input.UniqueUsedBytes ||
                    (this.UniqueUsedBytes != null &&
                    this.UniqueUsedBytes.Equals(input.UniqueUsedBytes))
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
                if (this.BackupEnabled != null)
                    hashCode = hashCode * 59 + this.BackupEnabled.GetHashCode();
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.LogicalCapacityBytes != null)
                    hashCode = hashCode * 59 + this.LogicalCapacityBytes.GetHashCode();
                if (this.LogicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.LogicalUsedBytes.GetHashCode();
                if (this.NfsInfo != null)
                    hashCode = hashCode * 59 + this.NfsInfo.GetHashCode();
                if (this.PhysicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.PhysicalUsedBytes.GetHashCode();
                hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.SmbInfo != null)
                    hashCode = hashCode * 59 + this.SmbInfo.GetHashCode();
                if (this.UniqueUsedBytes != null)
                    hashCode = hashCode * 59 + this.UniqueUsedBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

