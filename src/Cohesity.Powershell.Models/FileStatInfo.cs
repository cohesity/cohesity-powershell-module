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
    /// FileStatInfo
    /// </summary>
    [DataContract]
    public partial class FileStatInfo :  IEquatable<FileStatInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileStatInfo" /> class.
        /// </summary>
        /// <param name="backupSourceInodeId">Source inode id metadata for certain adapters e.g. Netapp..</param>
        /// <param name="mtimeUsecs">If this is a file, the mtime as returned by stat..</param>
        /// <param name="size">If this is a file, the size of the file as returned by stat..</param>
        /// <param name="type">The type of this entity. This field will not be populated for ReadDir results, since the DirEntry already contains the type information..</param>
        public FileStatInfo(long? backupSourceInodeId = default(long?), long? mtimeUsecs = default(long?), long? size = default(long?), int? type = default(int?))
        {
            this.BackupSourceInodeId = backupSourceInodeId;
            this.MtimeUsecs = mtimeUsecs;
            this.Size = size;
            this.Type = type;
            this.BackupSourceInodeId = backupSourceInodeId;
            this.MtimeUsecs = mtimeUsecs;
            this.Size = size;
            this.Type = type;
        }
        
        /// <summary>
        /// Source inode id metadata for certain adapters e.g. Netapp.
        /// </summary>
        /// <value>Source inode id metadata for certain adapters e.g. Netapp.</value>
        [DataMember(Name="backupSourceInodeId", EmitDefaultValue=true)]
        public long? BackupSourceInodeId { get; set; }

        /// <summary>
        /// If this is a file, the mtime as returned by stat.
        /// </summary>
        /// <value>If this is a file, the mtime as returned by stat.</value>
        [DataMember(Name="mtimeUsecs", EmitDefaultValue=true)]
        public long? MtimeUsecs { get; set; }

        /// <summary>
        /// If this is a file, the size of the file as returned by stat.
        /// </summary>
        /// <value>If this is a file, the size of the file as returned by stat.</value>
        [DataMember(Name="size", EmitDefaultValue=true)]
        public long? Size { get; set; }

        /// <summary>
        /// The type of this entity. This field will not be populated for ReadDir results, since the DirEntry already contains the type information.
        /// </summary>
        /// <value>The type of this entity. This field will not be populated for ReadDir results, since the DirEntry already contains the type information.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as FileStatInfo);
        }

        /// <summary>
        /// Returns true if FileStatInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FileStatInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileStatInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupSourceInodeId == input.BackupSourceInodeId ||
                    (this.BackupSourceInodeId != null &&
                    this.BackupSourceInodeId.Equals(input.BackupSourceInodeId))
                ) && 
                (
                    this.MtimeUsecs == input.MtimeUsecs ||
                    (this.MtimeUsecs != null &&
                    this.MtimeUsecs.Equals(input.MtimeUsecs))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.BackupSourceInodeId != null)
                    hashCode = hashCode * 59 + this.BackupSourceInodeId.GetHashCode();
                if (this.MtimeUsecs != null)
                    hashCode = hashCode * 59 + this.MtimeUsecs.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

