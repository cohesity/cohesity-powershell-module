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
    /// S3EmbeddedCredential
    /// </summary>
    [DataContract]
    public partial class S3EmbeddedCredential :  IEquatable<S3EmbeddedCredential>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3EmbeddedCredential" /> class.
        /// </summary>
        /// <param name="accessKeyId">Access key of the user/account. Once access key is assigned, it cannot be updated by the end user. Will be prefixed with CEMB..</param>
        /// <param name="expiredTimestampMsec">Absolute timestamp at which the keys will be expired..</param>
        /// <param name="secretAccessKey">Secret key of the user/account..</param>
        public S3EmbeddedCredential(List<int> accessKeyId = default(List<int>), long? expiredTimestampMsec = default(long?), List<int> secretAccessKey = default(List<int>))
        {
            this.AccessKeyId = accessKeyId;
            this.ExpiredTimestampMsec = expiredTimestampMsec;
            this.SecretAccessKey = secretAccessKey;
            this.AccessKeyId = accessKeyId;
            this.ExpiredTimestampMsec = expiredTimestampMsec;
            this.SecretAccessKey = secretAccessKey;
        }
        
        /// <summary>
        /// Access key of the user/account. Once access key is assigned, it cannot be updated by the end user. Will be prefixed with CEMB.
        /// </summary>
        /// <value>Access key of the user/account. Once access key is assigned, it cannot be updated by the end user. Will be prefixed with CEMB.</value>
        [DataMember(Name="accessKeyId", EmitDefaultValue=true)]
        public List<int> AccessKeyId { get; set; }

        /// <summary>
        /// Absolute timestamp at which the keys will be expired.
        /// </summary>
        /// <value>Absolute timestamp at which the keys will be expired.</value>
        [DataMember(Name="expiredTimestampMsec", EmitDefaultValue=true)]
        public long? ExpiredTimestampMsec { get; set; }

        /// <summary>
        /// Secret key of the user/account.
        /// </summary>
        /// <value>Secret key of the user/account.</value>
        [DataMember(Name="secretAccessKey", EmitDefaultValue=true)]
        public List<int> SecretAccessKey { get; set; }

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
            return this.Equals(input as S3EmbeddedCredential);
        }

        /// <summary>
        /// Returns true if S3EmbeddedCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of S3EmbeddedCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3EmbeddedCredential input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKeyId == input.AccessKeyId ||
                    this.AccessKeyId != null &&
                    input.AccessKeyId != null &&
                    this.AccessKeyId.SequenceEqual(input.AccessKeyId)
                ) && 
                (
                    this.ExpiredTimestampMsec == input.ExpiredTimestampMsec ||
                    (this.ExpiredTimestampMsec != null &&
                    this.ExpiredTimestampMsec.Equals(input.ExpiredTimestampMsec))
                ) && 
                (
                    this.SecretAccessKey == input.SecretAccessKey ||
                    this.SecretAccessKey != null &&
                    input.SecretAccessKey != null &&
                    this.SecretAccessKey.SequenceEqual(input.SecretAccessKey)
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
                if (this.AccessKeyId != null)
                    hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.ExpiredTimestampMsec != null)
                    hashCode = hashCode * 59 + this.ExpiredTimestampMsec.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                return hashCode;
            }
        }

    }

}

