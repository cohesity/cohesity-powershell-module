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
    /// S3BucketConfigProtoS3EmbeddedCredentialConfig
    /// </summary>
    [DataContract]
    public partial class S3BucketConfigProtoS3EmbeddedCredentialConfig :  IEquatable<S3BucketConfigProtoS3EmbeddedCredentialConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BucketConfigProtoS3EmbeddedCredentialConfig" /> class.
        /// </summary>
        /// <param name="s3EmbeddedCreds">S3 Embedded credentials..</param>
        public S3BucketConfigProtoS3EmbeddedCredentialConfig(List<S3EmbeddedCredential> s3EmbeddedCreds = default(List<S3EmbeddedCredential>))
        {
            this.S3EmbeddedCreds = s3EmbeddedCreds;
            this.S3EmbeddedCreds = s3EmbeddedCreds;
        }
        
        /// <summary>
        /// S3 Embedded credentials.
        /// </summary>
        /// <value>S3 Embedded credentials.</value>
        [DataMember(Name="s3EmbeddedCreds", EmitDefaultValue=true)]
        public List<S3EmbeddedCredential> S3EmbeddedCreds { get; set; }

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
            return this.Equals(input as S3BucketConfigProtoS3EmbeddedCredentialConfig);
        }

        /// <summary>
        /// Returns true if S3BucketConfigProtoS3EmbeddedCredentialConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BucketConfigProtoS3EmbeddedCredentialConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BucketConfigProtoS3EmbeddedCredentialConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.S3EmbeddedCreds == input.S3EmbeddedCreds ||
                    this.S3EmbeddedCreds != null &&
                    input.S3EmbeddedCreds != null &&
                    this.S3EmbeddedCreds.SequenceEqual(input.S3EmbeddedCreds)
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
                if (this.S3EmbeddedCreds != null)
                    hashCode = hashCode * 59 + this.S3EmbeddedCreds.GetHashCode();
                return hashCode;
            }
        }

    }

}

