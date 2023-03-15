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
    /// Contains backup params at the job level applicable for uda environment. These are sent from iris to magneto.
    /// </summary>
    [DataContract]
    public partial class UdaBackupJobParams :  IEquatable<UdaBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaBackupJobParams" /> class.
        /// </summary>
        /// <param name="backupJobArgumentsMap">Map to store custom arguments which will be provided to the backup job scripts..</param>
        /// <param name="concurrency">Max concurrency for the backup job..</param>
        /// <param name="entitySupport">Indicates if backup job was created after source acquired entity support capability..</param>
        /// <param name="fullBackupArgs">Custom arguments for full backup scripts..</param>
        /// <param name="incrementalBackupArgs">Custom arguments for incremental backup scripts..</param>
        /// <param name="logBackupArgs">Custom arguments for log backup scripts..</param>
        /// <param name="mounts">Max number of view mounts per host..</param>
        /// <param name="sourceId">Id of the source to which the objects being protected belong to. This can be removed once entity hierarchy support is added to UDA and protected objects can be specified by their Ids instead of their names..</param>
        /// <param name="udaObjects">List of objects to be backed up..</param>
        /// <param name="udaS3ViewBackupProperties">udaS3ViewBackupProperties.</param>
        public UdaBackupJobParams(List<UdaBackupJobParamsBackupJobArgumentsMapEntry> backupJobArgumentsMap = default(List<UdaBackupJobParamsBackupJobArgumentsMapEntry>), int? concurrency = default(int?), bool? entitySupport = default(bool?), string fullBackupArgs = default(string), string incrementalBackupArgs = default(string), string logBackupArgs = default(string), int? mounts = default(int?), long? sourceId = default(long?), List<UdaObjects> udaObjects = default(List<UdaObjects>), UdaS3ViewBackupProperties udaS3ViewBackupProperties = default(UdaS3ViewBackupProperties))
        {
            this.BackupJobArgumentsMap = backupJobArgumentsMap;
            this.Concurrency = concurrency;
            this.EntitySupport = entitySupport;
            this.FullBackupArgs = fullBackupArgs;
            this.IncrementalBackupArgs = incrementalBackupArgs;
            this.LogBackupArgs = logBackupArgs;
            this.Mounts = mounts;
            this.SourceId = sourceId;
            this.UdaObjects = udaObjects;
            this.BackupJobArgumentsMap = backupJobArgumentsMap;
            this.Concurrency = concurrency;
            this.EntitySupport = entitySupport;
            this.FullBackupArgs = fullBackupArgs;
            this.IncrementalBackupArgs = incrementalBackupArgs;
            this.LogBackupArgs = logBackupArgs;
            this.Mounts = mounts;
            this.SourceId = sourceId;
            this.UdaObjects = udaObjects;
            this.UdaS3ViewBackupProperties = udaS3ViewBackupProperties;
        }
        
        /// <summary>
        /// Map to store custom arguments which will be provided to the backup job scripts.
        /// </summary>
        /// <value>Map to store custom arguments which will be provided to the backup job scripts.</value>
        [DataMember(Name="backupJobArgumentsMap", EmitDefaultValue=true)]
        public List<UdaBackupJobParamsBackupJobArgumentsMapEntry> BackupJobArgumentsMap { get; set; }

        /// <summary>
        /// Max concurrency for the backup job.
        /// </summary>
        /// <value>Max concurrency for the backup job.</value>
        [DataMember(Name="concurrency", EmitDefaultValue=true)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Indicates if backup job was created after source acquired entity support capability.
        /// </summary>
        /// <value>Indicates if backup job was created after source acquired entity support capability.</value>
        [DataMember(Name="entitySupport", EmitDefaultValue=true)]
        public bool? EntitySupport { get; set; }

        /// <summary>
        /// Custom arguments for full backup scripts.
        /// </summary>
        /// <value>Custom arguments for full backup scripts.</value>
        [DataMember(Name="fullBackupArgs", EmitDefaultValue=true)]
        public string FullBackupArgs { get; set; }

        /// <summary>
        /// Custom arguments for incremental backup scripts.
        /// </summary>
        /// <value>Custom arguments for incremental backup scripts.</value>
        [DataMember(Name="incrementalBackupArgs", EmitDefaultValue=true)]
        public string IncrementalBackupArgs { get; set; }

        /// <summary>
        /// Custom arguments for log backup scripts.
        /// </summary>
        /// <value>Custom arguments for log backup scripts.</value>
        [DataMember(Name="logBackupArgs", EmitDefaultValue=true)]
        public string LogBackupArgs { get; set; }

        /// <summary>
        /// Max number of view mounts per host.
        /// </summary>
        /// <value>Max number of view mounts per host.</value>
        [DataMember(Name="mounts", EmitDefaultValue=true)]
        public int? Mounts { get; set; }

        /// <summary>
        /// Id of the source to which the objects being protected belong to. This can be removed once entity hierarchy support is added to UDA and protected objects can be specified by their Ids instead of their names.
        /// </summary>
        /// <value>Id of the source to which the objects being protected belong to. This can be removed once entity hierarchy support is added to UDA and protected objects can be specified by their Ids instead of their names.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=true)]
        public long? SourceId { get; set; }

        /// <summary>
        /// List of objects to be backed up.
        /// </summary>
        /// <value>List of objects to be backed up.</value>
        [DataMember(Name="udaObjects", EmitDefaultValue=true)]
        public List<UdaObjects> UdaObjects { get; set; }

        /// <summary>
        /// Gets or Sets UdaS3ViewBackupProperties
        /// </summary>
        [DataMember(Name="udaS3ViewBackupProperties", EmitDefaultValue=false)]
        public UdaS3ViewBackupProperties UdaS3ViewBackupProperties { get; set; }

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
            return this.Equals(input as UdaBackupJobParams);
        }

        /// <summary>
        /// Returns true if UdaBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupJobArgumentsMap == input.BackupJobArgumentsMap ||
                    this.BackupJobArgumentsMap != null &&
                    input.BackupJobArgumentsMap != null &&
                    this.BackupJobArgumentsMap.SequenceEqual(input.BackupJobArgumentsMap)
                ) && 
                (
                    this.Concurrency == input.Concurrency ||
                    (this.Concurrency != null &&
                    this.Concurrency.Equals(input.Concurrency))
                ) && 
                (
                    this.EntitySupport == input.EntitySupport ||
                    (this.EntitySupport != null &&
                    this.EntitySupport.Equals(input.EntitySupport))
                ) && 
                (
                    this.FullBackupArgs == input.FullBackupArgs ||
                    (this.FullBackupArgs != null &&
                    this.FullBackupArgs.Equals(input.FullBackupArgs))
                ) && 
                (
                    this.IncrementalBackupArgs == input.IncrementalBackupArgs ||
                    (this.IncrementalBackupArgs != null &&
                    this.IncrementalBackupArgs.Equals(input.IncrementalBackupArgs))
                ) && 
                (
                    this.LogBackupArgs == input.LogBackupArgs ||
                    (this.LogBackupArgs != null &&
                    this.LogBackupArgs.Equals(input.LogBackupArgs))
                ) && 
                (
                    this.Mounts == input.Mounts ||
                    (this.Mounts != null &&
                    this.Mounts.Equals(input.Mounts))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.UdaObjects == input.UdaObjects ||
                    this.UdaObjects != null &&
                    input.UdaObjects != null &&
                    this.UdaObjects.SequenceEqual(input.UdaObjects)
                ) && 
                (
                    this.UdaS3ViewBackupProperties == input.UdaS3ViewBackupProperties ||
                    (this.UdaS3ViewBackupProperties != null &&
                    this.UdaS3ViewBackupProperties.Equals(input.UdaS3ViewBackupProperties))
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
                if (this.BackupJobArgumentsMap != null)
                    hashCode = hashCode * 59 + this.BackupJobArgumentsMap.GetHashCode();
                if (this.Concurrency != null)
                    hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.EntitySupport != null)
                    hashCode = hashCode * 59 + this.EntitySupport.GetHashCode();
                if (this.FullBackupArgs != null)
                    hashCode = hashCode * 59 + this.FullBackupArgs.GetHashCode();
                if (this.IncrementalBackupArgs != null)
                    hashCode = hashCode * 59 + this.IncrementalBackupArgs.GetHashCode();
                if (this.LogBackupArgs != null)
                    hashCode = hashCode * 59 + this.LogBackupArgs.GetHashCode();
                if (this.Mounts != null)
                    hashCode = hashCode * 59 + this.Mounts.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.UdaObjects != null)
                    hashCode = hashCode * 59 + this.UdaObjects.GetHashCode();
                if (this.UdaS3ViewBackupProperties != null)
                    hashCode = hashCode * 59 + this.UdaS3ViewBackupProperties.GetHashCode();
                return hashCode;
            }
        }

    }

}

