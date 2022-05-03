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
    /// FileId
    /// </summary>
    [DataContract]
    public partial class FileId :  IEquatable<FileId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileId" /> class.
        /// </summary>
        /// <param name="entityId">Specifies the entity id of the file..</param>
        /// <param name="rootInodeId">Specifies the root inode id of the file system that file belongs to..</param>
        /// <param name="viewId">Specifies the id of the View the file belongs to..</param>
        public FileId(long? entityId = default(long?), long? rootInodeId = default(long?), long? viewId = default(long?))
        {
            this.EntityId = entityId;
            this.RootInodeId = rootInodeId;
            this.ViewId = viewId;
        }
        
        /// <summary>
        /// Specifies the entity id of the file.
        /// </summary>
        /// <value>Specifies the entity id of the file.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies the root inode id of the file system that file belongs to.
        /// </summary>
        /// <value>Specifies the root inode id of the file system that file belongs to.</value>
        [DataMember(Name="rootInodeId", EmitDefaultValue=false)]
        public long? RootInodeId { get; set; }

        /// <summary>
        /// Specifies the id of the View the file belongs to.
        /// </summary>
        /// <value>Specifies the id of the View the file belongs to.</value>
        [DataMember(Name="viewId", EmitDefaultValue=false)]
        public long? ViewId { get; set; }

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
            return this.Equals(input as FileId);
        }

        /// <summary>
        /// Returns true if FileId instances are equal
        /// </summary>
        /// <param name="input">Instance of FileId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.RootInodeId == input.RootInodeId ||
                    (this.RootInodeId != null &&
                    this.RootInodeId.Equals(input.RootInodeId))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.RootInodeId != null)
                    hashCode = hashCode * 59 + this.RootInodeId.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                return hashCode;
            }
        }

    }

}

