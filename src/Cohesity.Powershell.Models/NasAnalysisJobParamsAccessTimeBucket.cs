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
    /// NasAnalysisJobParamsAccessTimeBucket
    /// </summary>
    [DataContract]
    public partial class NasAnalysisJobParamsAccessTimeBucket :  IEquatable<NasAnalysisJobParamsAccessTimeBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasAnalysisJobParamsAccessTimeBucket" /> class.
        /// </summary>
        /// <param name="accessTimeBucketName">Tag representing the bucket for access time of file. e.g. \&quot;1mo-3mo\&quot; represents 1 month to 3 month..</param>
        /// <param name="accessTimeEndDays">End time e.g. 1 year. Stored in days precision..</param>
        /// <param name="accessTimeStartDays">Start time e.g. 6 months. Stored in days precision..</param>
        public NasAnalysisJobParamsAccessTimeBucket(string accessTimeBucketName = default(string), long? accessTimeEndDays = default(long?), long? accessTimeStartDays = default(long?))
        {
            this.AccessTimeBucketName = accessTimeBucketName;
            this.AccessTimeEndDays = accessTimeEndDays;
            this.AccessTimeStartDays = accessTimeStartDays;
            this.AccessTimeBucketName = accessTimeBucketName;
            this.AccessTimeEndDays = accessTimeEndDays;
            this.AccessTimeStartDays = accessTimeStartDays;
        }
        
        /// <summary>
        /// Tag representing the bucket for access time of file. e.g. \&quot;1mo-3mo\&quot; represents 1 month to 3 month.
        /// </summary>
        /// <value>Tag representing the bucket for access time of file. e.g. \&quot;1mo-3mo\&quot; represents 1 month to 3 month.</value>
        [DataMember(Name="accessTimeBucketName", EmitDefaultValue=true)]
        public string AccessTimeBucketName { get; set; }

        /// <summary>
        /// End time e.g. 1 year. Stored in days precision.
        /// </summary>
        /// <value>End time e.g. 1 year. Stored in days precision.</value>
        [DataMember(Name="accessTimeEndDays", EmitDefaultValue=true)]
        public long? AccessTimeEndDays { get; set; }

        /// <summary>
        /// Start time e.g. 6 months. Stored in days precision.
        /// </summary>
        /// <value>Start time e.g. 6 months. Stored in days precision.</value>
        [DataMember(Name="accessTimeStartDays", EmitDefaultValue=true)]
        public long? AccessTimeStartDays { get; set; }

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
            return this.Equals(input as NasAnalysisJobParamsAccessTimeBucket);
        }

        /// <summary>
        /// Returns true if NasAnalysisJobParamsAccessTimeBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of NasAnalysisJobParamsAccessTimeBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasAnalysisJobParamsAccessTimeBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessTimeBucketName == input.AccessTimeBucketName ||
                    (this.AccessTimeBucketName != null &&
                    this.AccessTimeBucketName.Equals(input.AccessTimeBucketName))
                ) && 
                (
                    this.AccessTimeEndDays == input.AccessTimeEndDays ||
                    (this.AccessTimeEndDays != null &&
                    this.AccessTimeEndDays.Equals(input.AccessTimeEndDays))
                ) && 
                (
                    this.AccessTimeStartDays == input.AccessTimeStartDays ||
                    (this.AccessTimeStartDays != null &&
                    this.AccessTimeStartDays.Equals(input.AccessTimeStartDays))
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
                if (this.AccessTimeBucketName != null)
                    hashCode = hashCode * 59 + this.AccessTimeBucketName.GetHashCode();
                if (this.AccessTimeEndDays != null)
                    hashCode = hashCode * 59 + this.AccessTimeEndDays.GetHashCode();
                if (this.AccessTimeStartDays != null)
                    hashCode = hashCode * 59 + this.AccessTimeStartDays.GetHashCode();
                return hashCode;
            }
        }

    }

}

