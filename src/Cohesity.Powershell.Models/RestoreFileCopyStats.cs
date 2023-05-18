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
    /// This message captures the progress information regarding restore of file/directory.
    /// </summary>
    [DataContract]
    public partial class RestoreFileCopyStats :  IEquatable<RestoreFileCopyStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFileCopyStats" /> class.
        /// </summary>
        /// <param name="estimationSkipped">This will be set to true if the estimation step was skipped. NOTE: If estimation is skipped, then progress info will not be available..</param>
        /// <param name="numBytesCopied">Number of bytes copied so far..</param>
        /// <param name="numDirectoriesCopied">Number of directories copied so far. NOTE: This just means the creation of directory (not the contents of the directory)..</param>
        /// <param name="numErrors">Number of errors encountered so far..</param>
        /// <param name="numFilesCopied">Number of files copied so far..</param>
        /// <param name="totalBytesToCopy">Total number of bytes to copy..</param>
        /// <param name="totalDirectoriesToCopy">Total number of directories to copy. NOTE: This just means the creation of directory (not the contents of the directory)..</param>
        /// <param name="totalFilesToCopy">Total number of files to copy..</param>
        public RestoreFileCopyStats(bool? estimationSkipped = default(bool?), long? numBytesCopied = default(long?), int? numDirectoriesCopied = default(int?), long? numErrors = default(long?), int? numFilesCopied = default(int?), long? totalBytesToCopy = default(long?), int? totalDirectoriesToCopy = default(int?), int? totalFilesToCopy = default(int?))
        {
            this.EstimationSkipped = estimationSkipped;
            this.NumBytesCopied = numBytesCopied;
            this.NumDirectoriesCopied = numDirectoriesCopied;
            this.NumErrors = numErrors;
            this.NumFilesCopied = numFilesCopied;
            this.TotalBytesToCopy = totalBytesToCopy;
            this.TotalDirectoriesToCopy = totalDirectoriesToCopy;
            this.TotalFilesToCopy = totalFilesToCopy;
            this.EstimationSkipped = estimationSkipped;
            this.NumBytesCopied = numBytesCopied;
            this.NumDirectoriesCopied = numDirectoriesCopied;
            this.NumErrors = numErrors;
            this.NumFilesCopied = numFilesCopied;
            this.TotalBytesToCopy = totalBytesToCopy;
            this.TotalDirectoriesToCopy = totalDirectoriesToCopy;
            this.TotalFilesToCopy = totalFilesToCopy;
        }
        
        /// <summary>
        /// This will be set to true if the estimation step was skipped. NOTE: If estimation is skipped, then progress info will not be available.
        /// </summary>
        /// <value>This will be set to true if the estimation step was skipped. NOTE: If estimation is skipped, then progress info will not be available.</value>
        [DataMember(Name="estimationSkipped", EmitDefaultValue=true)]
        public bool? EstimationSkipped { get; set; }

        /// <summary>
        /// Number of bytes copied so far.
        /// </summary>
        /// <value>Number of bytes copied so far.</value>
        [DataMember(Name="numBytesCopied", EmitDefaultValue=true)]
        public long? NumBytesCopied { get; set; }

        /// <summary>
        /// Number of directories copied so far. NOTE: This just means the creation of directory (not the contents of the directory).
        /// </summary>
        /// <value>Number of directories copied so far. NOTE: This just means the creation of directory (not the contents of the directory).</value>
        [DataMember(Name="numDirectoriesCopied", EmitDefaultValue=true)]
        public int? NumDirectoriesCopied { get; set; }

        /// <summary>
        /// Number of errors encountered so far.
        /// </summary>
        /// <value>Number of errors encountered so far.</value>
        [DataMember(Name="numErrors", EmitDefaultValue=true)]
        public long? NumErrors { get; set; }

        /// <summary>
        /// Number of files copied so far.
        /// </summary>
        /// <value>Number of files copied so far.</value>
        [DataMember(Name="numFilesCopied", EmitDefaultValue=true)]
        public int? NumFilesCopied { get; set; }

        /// <summary>
        /// Total number of bytes to copy.
        /// </summary>
        /// <value>Total number of bytes to copy.</value>
        [DataMember(Name="totalBytesToCopy", EmitDefaultValue=true)]
        public long? TotalBytesToCopy { get; set; }

        /// <summary>
        /// Total number of directories to copy. NOTE: This just means the creation of directory (not the contents of the directory).
        /// </summary>
        /// <value>Total number of directories to copy. NOTE: This just means the creation of directory (not the contents of the directory).</value>
        [DataMember(Name="totalDirectoriesToCopy", EmitDefaultValue=true)]
        public int? TotalDirectoriesToCopy { get; set; }

        /// <summary>
        /// Total number of files to copy.
        /// </summary>
        /// <value>Total number of files to copy.</value>
        [DataMember(Name="totalFilesToCopy", EmitDefaultValue=true)]
        public int? TotalFilesToCopy { get; set; }

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
            return this.Equals(input as RestoreFileCopyStats);
        }

        /// <summary>
        /// Returns true if RestoreFileCopyStats instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFileCopyStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFileCopyStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EstimationSkipped == input.EstimationSkipped ||
                    (this.EstimationSkipped != null &&
                    this.EstimationSkipped.Equals(input.EstimationSkipped))
                ) && 
                (
                    this.NumBytesCopied == input.NumBytesCopied ||
                    (this.NumBytesCopied != null &&
                    this.NumBytesCopied.Equals(input.NumBytesCopied))
                ) && 
                (
                    this.NumDirectoriesCopied == input.NumDirectoriesCopied ||
                    (this.NumDirectoriesCopied != null &&
                    this.NumDirectoriesCopied.Equals(input.NumDirectoriesCopied))
                ) && 
                (
                    this.NumErrors == input.NumErrors ||
                    (this.NumErrors != null &&
                    this.NumErrors.Equals(input.NumErrors))
                ) && 
                (
                    this.NumFilesCopied == input.NumFilesCopied ||
                    (this.NumFilesCopied != null &&
                    this.NumFilesCopied.Equals(input.NumFilesCopied))
                ) && 
                (
                    this.TotalBytesToCopy == input.TotalBytesToCopy ||
                    (this.TotalBytesToCopy != null &&
                    this.TotalBytesToCopy.Equals(input.TotalBytesToCopy))
                ) && 
                (
                    this.TotalDirectoriesToCopy == input.TotalDirectoriesToCopy ||
                    (this.TotalDirectoriesToCopy != null &&
                    this.TotalDirectoriesToCopy.Equals(input.TotalDirectoriesToCopy))
                ) && 
                (
                    this.TotalFilesToCopy == input.TotalFilesToCopy ||
                    (this.TotalFilesToCopy != null &&
                    this.TotalFilesToCopy.Equals(input.TotalFilesToCopy))
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
                if (this.EstimationSkipped != null)
                    hashCode = hashCode * 59 + this.EstimationSkipped.GetHashCode();
                if (this.NumBytesCopied != null)
                    hashCode = hashCode * 59 + this.NumBytesCopied.GetHashCode();
                if (this.NumDirectoriesCopied != null)
                    hashCode = hashCode * 59 + this.NumDirectoriesCopied.GetHashCode();
                if (this.NumErrors != null)
                    hashCode = hashCode * 59 + this.NumErrors.GetHashCode();
                if (this.NumFilesCopied != null)
                    hashCode = hashCode * 59 + this.NumFilesCopied.GetHashCode();
                if (this.TotalBytesToCopy != null)
                    hashCode = hashCode * 59 + this.TotalBytesToCopy.GetHashCode();
                if (this.TotalDirectoriesToCopy != null)
                    hashCode = hashCode * 59 + this.TotalDirectoriesToCopy.GetHashCode();
                if (this.TotalFilesToCopy != null)
                    hashCode = hashCode * 59 + this.TotalFilesToCopy.GetHashCode();
                return hashCode;
            }
        }

    }

}

