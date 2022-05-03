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
    /// Message to capture additional NAS analysis job params.
    /// </summary>
    [DataContract]
    public partial class NasAnalysisJobParams :  IEquatable<NasAnalysisJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasAnalysisJobParams" /> class.
        /// </summary>
        /// <param name="accessTimeBuckets">File access time buckets..</param>
        /// <param name="fileSizeBuckets">File size buckets..</param>
        /// <param name="fileTypeBuckets">File type buckets..</param>
        /// <param name="modTimeBuckets">File modification time buckets..</param>
        public NasAnalysisJobParams(List<NasAnalysisJobParamsAccessTimeBucket> accessTimeBuckets = default(List<NasAnalysisJobParamsAccessTimeBucket>), List<NasAnalysisJobParamsFileSizeBucket> fileSizeBuckets = default(List<NasAnalysisJobParamsFileSizeBucket>), List<NasAnalysisJobParamsFileTypeBucket> fileTypeBuckets = default(List<NasAnalysisJobParamsFileTypeBucket>), List<NasAnalysisJobParamsModTimeBucket> modTimeBuckets = default(List<NasAnalysisJobParamsModTimeBucket>))
        {
            this.AccessTimeBuckets = accessTimeBuckets;
            this.FileSizeBuckets = fileSizeBuckets;
            this.FileTypeBuckets = fileTypeBuckets;
            this.ModTimeBuckets = modTimeBuckets;
        }
        
        /// <summary>
        /// File access time buckets.
        /// </summary>
        /// <value>File access time buckets.</value>
        [DataMember(Name="accessTimeBuckets", EmitDefaultValue=false)]
        public List<NasAnalysisJobParamsAccessTimeBucket> AccessTimeBuckets { get; set; }

        /// <summary>
        /// File size buckets.
        /// </summary>
        /// <value>File size buckets.</value>
        [DataMember(Name="fileSizeBuckets", EmitDefaultValue=false)]
        public List<NasAnalysisJobParamsFileSizeBucket> FileSizeBuckets { get; set; }

        /// <summary>
        /// File type buckets.
        /// </summary>
        /// <value>File type buckets.</value>
        [DataMember(Name="fileTypeBuckets", EmitDefaultValue=false)]
        public List<NasAnalysisJobParamsFileTypeBucket> FileTypeBuckets { get; set; }

        /// <summary>
        /// File modification time buckets.
        /// </summary>
        /// <value>File modification time buckets.</value>
        [DataMember(Name="modTimeBuckets", EmitDefaultValue=false)]
        public List<NasAnalysisJobParamsModTimeBucket> ModTimeBuckets { get; set; }

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
            return this.Equals(input as NasAnalysisJobParams);
        }

        /// <summary>
        /// Returns true if NasAnalysisJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NasAnalysisJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasAnalysisJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessTimeBuckets == input.AccessTimeBuckets ||
                    this.AccessTimeBuckets != null &&
                    this.AccessTimeBuckets.Equals(input.AccessTimeBuckets)
                ) && 
                (
                    this.FileSizeBuckets == input.FileSizeBuckets ||
                    this.FileSizeBuckets != null &&
                    this.FileSizeBuckets.Equals(input.FileSizeBuckets)
                ) && 
                (
                    this.FileTypeBuckets == input.FileTypeBuckets ||
                    this.FileTypeBuckets != null &&
                    this.FileTypeBuckets.Equals(input.FileTypeBuckets)
                ) && 
                (
                    this.ModTimeBuckets == input.ModTimeBuckets ||
                    this.ModTimeBuckets != null &&
                    this.ModTimeBuckets.Equals(input.ModTimeBuckets)
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
                if (this.AccessTimeBuckets != null)
                    hashCode = hashCode * 59 + this.AccessTimeBuckets.GetHashCode();
                if (this.FileSizeBuckets != null)
                    hashCode = hashCode * 59 + this.FileSizeBuckets.GetHashCode();
                if (this.FileTypeBuckets != null)
                    hashCode = hashCode * 59 + this.FileTypeBuckets.GetHashCode();
                if (this.ModTimeBuckets != null)
                    hashCode = hashCode * 59 + this.ModTimeBuckets.GetHashCode();
                return hashCode;
            }
        }

    }

}

