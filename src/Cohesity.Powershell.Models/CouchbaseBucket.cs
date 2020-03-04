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
    /// Specifies an Object containing information about a couchbase Bucket.
    /// </summary>
    [DataContract]
    public partial class CouchbaseBucket :  IEquatable<CouchbaseBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouchbaseBucket" /> class.
        /// </summary>
        /// <param name="bucketType">Type of this bucket..</param>
        /// <param name="documentCount">Number of documents in this bucket..</param>
        public CouchbaseBucket(string bucketType = default(string), long? documentCount = default(long?))
        {
            this.BucketType = bucketType;
            this.DocumentCount = documentCount;
            this.BucketType = bucketType;
            this.DocumentCount = documentCount;
        }
        
        /// <summary>
        /// Type of this bucket.
        /// </summary>
        /// <value>Type of this bucket.</value>
        [DataMember(Name="bucketType", EmitDefaultValue=true)]
        public string BucketType { get; set; }

        /// <summary>
        /// Number of documents in this bucket.
        /// </summary>
        /// <value>Number of documents in this bucket.</value>
        [DataMember(Name="documentCount", EmitDefaultValue=true)]
        public long? DocumentCount { get; set; }

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
            return this.Equals(input as CouchbaseBucket);
        }

        /// <summary>
        /// Returns true if CouchbaseBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of CouchbaseBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouchbaseBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BucketType == input.BucketType ||
                    (this.BucketType != null &&
                    this.BucketType.Equals(input.BucketType))
                ) && 
                (
                    this.DocumentCount == input.DocumentCount ||
                    (this.DocumentCount != null &&
                    this.DocumentCount.Equals(input.DocumentCount))
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
                if (this.BucketType != null)
                    hashCode = hashCode * 59 + this.BucketType.GetHashCode();
                if (this.DocumentCount != null)
                    hashCode = hashCode * 59 + this.DocumentCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

