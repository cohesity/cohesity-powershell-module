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
    /// NasAnalysisJobParamsFileSizeBucket
    /// </summary>
    [DataContract]
    public partial class NasAnalysisJobParamsFileSizeBucket :  IEquatable<NasAnalysisJobParamsFileSizeBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasAnalysisJobParamsFileSizeBucket" /> class.
        /// </summary>
        /// <param name="fileSizeBucketName">Tag representing the bucket for size of file. e.g. \&quot;1M-10M\&quot; represents 1 MB to 10 MB..</param>
        /// <param name="fileSizeEndBytes">End size for the bucket e.g. 500MB..</param>
        /// <param name="fileSizeStartBytes">Start size for the bucket e.g. 50MB..</param>
        public NasAnalysisJobParamsFileSizeBucket(string fileSizeBucketName = default(string), long? fileSizeEndBytes = default(long?), long? fileSizeStartBytes = default(long?))
        {
            this.FileSizeBucketName = fileSizeBucketName;
            this.FileSizeEndBytes = fileSizeEndBytes;
            this.FileSizeStartBytes = fileSizeStartBytes;
            this.FileSizeBucketName = fileSizeBucketName;
            this.FileSizeEndBytes = fileSizeEndBytes;
            this.FileSizeStartBytes = fileSizeStartBytes;
        }
        
        /// <summary>
        /// Tag representing the bucket for size of file. e.g. \&quot;1M-10M\&quot; represents 1 MB to 10 MB.
        /// </summary>
        /// <value>Tag representing the bucket for size of file. e.g. \&quot;1M-10M\&quot; represents 1 MB to 10 MB.</value>
        [DataMember(Name="fileSizeBucketName", EmitDefaultValue=true)]
        public string FileSizeBucketName { get; set; }

        /// <summary>
        /// End size for the bucket e.g. 500MB.
        /// </summary>
        /// <value>End size for the bucket e.g. 500MB.</value>
        [DataMember(Name="fileSizeEndBytes", EmitDefaultValue=true)]
        public long? FileSizeEndBytes { get; set; }

        /// <summary>
        /// Start size for the bucket e.g. 50MB.
        /// </summary>
        /// <value>Start size for the bucket e.g. 50MB.</value>
        [DataMember(Name="fileSizeStartBytes", EmitDefaultValue=true)]
        public long? FileSizeStartBytes { get; set; }

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
            return this.Equals(input as NasAnalysisJobParamsFileSizeBucket);
        }

        /// <summary>
        /// Returns true if NasAnalysisJobParamsFileSizeBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of NasAnalysisJobParamsFileSizeBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasAnalysisJobParamsFileSizeBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileSizeBucketName == input.FileSizeBucketName ||
                    (this.FileSizeBucketName != null &&
                    this.FileSizeBucketName.Equals(input.FileSizeBucketName))
                ) && 
                (
                    this.FileSizeEndBytes == input.FileSizeEndBytes ||
                    (this.FileSizeEndBytes != null &&
                    this.FileSizeEndBytes.Equals(input.FileSizeEndBytes))
                ) && 
                (
                    this.FileSizeStartBytes == input.FileSizeStartBytes ||
                    (this.FileSizeStartBytes != null &&
                    this.FileSizeStartBytes.Equals(input.FileSizeStartBytes))
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
                if (this.FileSizeBucketName != null)
                    hashCode = hashCode * 59 + this.FileSizeBucketName.GetHashCode();
                if (this.FileSizeEndBytes != null)
                    hashCode = hashCode * 59 + this.FileSizeEndBytes.GetHashCode();
                if (this.FileSizeStartBytes != null)
                    hashCode = hashCode * 59 + this.FileSizeStartBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

