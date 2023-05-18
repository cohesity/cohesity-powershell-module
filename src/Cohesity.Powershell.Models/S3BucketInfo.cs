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
    /// S3BucketInfo
    /// </summary>
    [DataContract]
    public partial class S3BucketInfo :  IEquatable<S3BucketInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BucketInfo" /> class.
        /// </summary>
        /// <param name="awsRegion">AWS region of the S3 bucket..</param>
        /// <param name="bucketName">Name of the S3 bucket..</param>
        /// <param name="keyPrefix">Complete path of the sub folder in the s3 bucket. This job will create all keys within the given key prefix..</param>
        public S3BucketInfo(string awsRegion = default(string), string bucketName = default(string), string keyPrefix = default(string))
        {
            this.AwsRegion = awsRegion;
            this.BucketName = bucketName;
            this.KeyPrefix = keyPrefix;
            this.AwsRegion = awsRegion;
            this.BucketName = bucketName;
            this.KeyPrefix = keyPrefix;
        }
        
        /// <summary>
        /// AWS region of the S3 bucket.
        /// </summary>
        /// <value>AWS region of the S3 bucket.</value>
        [DataMember(Name="awsRegion", EmitDefaultValue=true)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Name of the S3 bucket.
        /// </summary>
        /// <value>Name of the S3 bucket.</value>
        [DataMember(Name="bucketName", EmitDefaultValue=true)]
        public string BucketName { get; set; }

        /// <summary>
        /// Complete path of the sub folder in the s3 bucket. This job will create all keys within the given key prefix.
        /// </summary>
        /// <value>Complete path of the sub folder in the s3 bucket. This job will create all keys within the given key prefix.</value>
        [DataMember(Name="keyPrefix", EmitDefaultValue=true)]
        public string KeyPrefix { get; set; }

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
            return this.Equals(input as S3BucketInfo);
        }

        /// <summary>
        /// Returns true if S3BucketInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BucketInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BucketInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsRegion == input.AwsRegion ||
                    (this.AwsRegion != null &&
                    this.AwsRegion.Equals(input.AwsRegion))
                ) && 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.KeyPrefix == input.KeyPrefix ||
                    (this.KeyPrefix != null &&
                    this.KeyPrefix.Equals(input.KeyPrefix))
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
                if (this.AwsRegion != null)
                    hashCode = hashCode * 59 + this.AwsRegion.GetHashCode();
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.KeyPrefix != null)
                    hashCode = hashCode * 59 + this.KeyPrefix.GetHashCode();
                return hashCode;
            }
        }

    }

}

