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
    /// Message specifying new location details, should be set only when is_original_location is false.
    /// </summary>
    [DataContract]
    public partial class RestoreS3ParamsNewLocationParams :  IEquatable<RestoreS3ParamsNewLocationParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreS3ParamsNewLocationParams" /> class.
        /// </summary>
        /// <param name="region">region.</param>
        /// <param name="s3Bucket">s3Bucket.</param>
        public RestoreS3ParamsNewLocationParams(EntityProto region = default(EntityProto), EntityProto s3Bucket = default(EntityProto))
        {
            this.Region = region;
            this.S3Bucket = s3Bucket;
        }
        
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public EntityProto Region { get; set; }

        /// <summary>
        /// Gets or Sets S3Bucket
        /// </summary>
        [DataMember(Name="s3Bucket", EmitDefaultValue=false)]
        public EntityProto S3Bucket { get; set; }

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
            return this.Equals(input as RestoreS3ParamsNewLocationParams);
        }

        /// <summary>
        /// Returns true if RestoreS3ParamsNewLocationParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreS3ParamsNewLocationParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreS3ParamsNewLocationParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.S3Bucket == input.S3Bucket ||
                    (this.S3Bucket != null &&
                    this.S3Bucket.Equals(input.S3Bucket))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.S3Bucket != null)
                    hashCode = hashCode * 59 + this.S3Bucket.GetHashCode();
                return hashCode;
            }
        }

    }

}

