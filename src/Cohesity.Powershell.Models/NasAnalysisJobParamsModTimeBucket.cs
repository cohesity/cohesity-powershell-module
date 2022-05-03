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
    /// NasAnalysisJobParamsModTimeBucket
    /// </summary>
    [DataContract]
    public partial class NasAnalysisJobParamsModTimeBucket :  IEquatable<NasAnalysisJobParamsModTimeBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasAnalysisJobParamsModTimeBucket" /> class.
        /// </summary>
        /// <param name="modTimeBucketName">Tag representing the bucket for modified time of file. e.g. \&quot;1mo-3mo\&quot; represents 1 month to 3 month..</param>
        /// <param name="modTimeEndDays">End time e.g. 1 year. Stored in days precision..</param>
        /// <param name="modTimeStartDays">Start time e.g. 6 months. Stored in days precision..</param>
        public NasAnalysisJobParamsModTimeBucket(string modTimeBucketName = default(string), long? modTimeEndDays = default(long?), long? modTimeStartDays = default(long?))
        {
            this.ModTimeBucketName = modTimeBucketName;
            this.ModTimeEndDays = modTimeEndDays;
            this.ModTimeStartDays = modTimeStartDays;
        }
        
        /// <summary>
        /// Tag representing the bucket for modified time of file. e.g. \&quot;1mo-3mo\&quot; represents 1 month to 3 month.
        /// </summary>
        /// <value>Tag representing the bucket for modified time of file. e.g. \&quot;1mo-3mo\&quot; represents 1 month to 3 month.</value>
        [DataMember(Name="modTimeBucketName", EmitDefaultValue=false)]
        public string ModTimeBucketName { get; set; }

        /// <summary>
        /// End time e.g. 1 year. Stored in days precision.
        /// </summary>
        /// <value>End time e.g. 1 year. Stored in days precision.</value>
        [DataMember(Name="modTimeEndDays", EmitDefaultValue=false)]
        public long? ModTimeEndDays { get; set; }

        /// <summary>
        /// Start time e.g. 6 months. Stored in days precision.
        /// </summary>
        /// <value>Start time e.g. 6 months. Stored in days precision.</value>
        [DataMember(Name="modTimeStartDays", EmitDefaultValue=false)]
        public long? ModTimeStartDays { get; set; }

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
            return this.Equals(input as NasAnalysisJobParamsModTimeBucket);
        }

        /// <summary>
        /// Returns true if NasAnalysisJobParamsModTimeBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of NasAnalysisJobParamsModTimeBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasAnalysisJobParamsModTimeBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModTimeBucketName == input.ModTimeBucketName ||
                    (this.ModTimeBucketName != null &&
                    this.ModTimeBucketName.Equals(input.ModTimeBucketName))
                ) && 
                (
                    this.ModTimeEndDays == input.ModTimeEndDays ||
                    (this.ModTimeEndDays != null &&
                    this.ModTimeEndDays.Equals(input.ModTimeEndDays))
                ) && 
                (
                    this.ModTimeStartDays == input.ModTimeStartDays ||
                    (this.ModTimeStartDays != null &&
                    this.ModTimeStartDays.Equals(input.ModTimeStartDays))
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
                if (this.ModTimeBucketName != null)
                    hashCode = hashCode * 59 + this.ModTimeBucketName.GetHashCode();
                if (this.ModTimeEndDays != null)
                    hashCode = hashCode * 59 + this.ModTimeEndDays.GetHashCode();
                if (this.ModTimeStartDays != null)
                    hashCode = hashCode * 59 + this.ModTimeStartDays.GetHashCode();
                return hashCode;
            }
        }

    }

}

