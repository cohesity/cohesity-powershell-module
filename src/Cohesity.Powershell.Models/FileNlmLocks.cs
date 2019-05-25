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
    /// Specifies per-file NLM locks
    /// </summary>
    [DataContract]
    public partial class FileNlmLocks :  IEquatable<FileNlmLocks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileNlmLocks" /> class.
        /// </summary>
        /// <param name="fileId">fileId.</param>
        /// <param name="nlmLocks">Specifies the list of NLM locks in a view..</param>
        public FileNlmLocks(FileId fileId = default(FileId), List<NlmLock> nlmLocks = default(List<NlmLock>))
        {
            this.NlmLocks = nlmLocks;
            this.FileId = fileId;
            this.NlmLocks = nlmLocks;
        }
        
        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public FileId FileId { get; set; }

        /// <summary>
        /// Specifies the list of NLM locks in a view.
        /// </summary>
        /// <value>Specifies the list of NLM locks in a view.</value>
        [DataMember(Name="nlmLocks", EmitDefaultValue=true)]
        public List<NlmLock> NlmLocks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileNlmLocks {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  NlmLocks: ").Append(NlmLocks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as FileNlmLocks);
        }

        /// <summary>
        /// Returns true if FileNlmLocks instances are equal
        /// </summary>
        /// <param name="input">Instance of FileNlmLocks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileNlmLocks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.NlmLocks == input.NlmLocks ||
                    this.NlmLocks != null &&
                    input.NlmLocks != null &&
                    this.NlmLocks.SequenceEqual(input.NlmLocks)
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.NlmLocks != null)
                    hashCode = hashCode * 59 + this.NlmLocks.GetHashCode();
                return hashCode;
            }
        }

    }

}
