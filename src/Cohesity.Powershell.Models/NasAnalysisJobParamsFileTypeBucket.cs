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
    /// NasAnalysisJobParamsFileTypeBucket
    /// </summary>
    [DataContract]
    public partial class NasAnalysisJobParamsFileTypeBucket :  IEquatable<NasAnalysisJobParamsFileTypeBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasAnalysisJobParamsFileTypeBucket" /> class.
        /// </summary>
        /// <param name="fileTypeBucketExtensions">File extensions e.g. &lt;vmdk, ova&gt;..</param>
        /// <param name="fileTypeBucketName">File type bucket name, e.g. VMs..</param>
        public NasAnalysisJobParamsFileTypeBucket(List<string> fileTypeBucketExtensions = default(List<string>), string fileTypeBucketName = default(string))
        {
            this.FileTypeBucketExtensions = fileTypeBucketExtensions;
            this.FileTypeBucketName = fileTypeBucketName;
            this.FileTypeBucketExtensions = fileTypeBucketExtensions;
            this.FileTypeBucketName = fileTypeBucketName;
        }
        
        /// <summary>
        /// File extensions e.g. &lt;vmdk, ova&gt;.
        /// </summary>
        /// <value>File extensions e.g. &lt;vmdk, ova&gt;.</value>
        [DataMember(Name="fileTypeBucketExtensions", EmitDefaultValue=true)]
        public List<string> FileTypeBucketExtensions { get; set; }

        /// <summary>
        /// File type bucket name, e.g. VMs.
        /// </summary>
        /// <value>File type bucket name, e.g. VMs.</value>
        [DataMember(Name="fileTypeBucketName", EmitDefaultValue=true)]
        public string FileTypeBucketName { get; set; }

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
            return this.Equals(input as NasAnalysisJobParamsFileTypeBucket);
        }

        /// <summary>
        /// Returns true if NasAnalysisJobParamsFileTypeBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of NasAnalysisJobParamsFileTypeBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasAnalysisJobParamsFileTypeBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileTypeBucketExtensions == input.FileTypeBucketExtensions ||
                    this.FileTypeBucketExtensions != null &&
                    input.FileTypeBucketExtensions != null &&
                    this.FileTypeBucketExtensions.SequenceEqual(input.FileTypeBucketExtensions)
                ) && 
                (
                    this.FileTypeBucketName == input.FileTypeBucketName ||
                    (this.FileTypeBucketName != null &&
                    this.FileTypeBucketName.Equals(input.FileTypeBucketName))
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
                if (this.FileTypeBucketExtensions != null)
                    hashCode = hashCode * 59 + this.FileTypeBucketExtensions.GetHashCode();
                if (this.FileTypeBucketName != null)
                    hashCode = hashCode * 59 + this.FileTypeBucketName.GetHashCode();
                return hashCode;
            }
        }

    }

}

