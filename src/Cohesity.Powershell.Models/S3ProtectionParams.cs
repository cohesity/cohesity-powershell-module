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
    /// Specifies the inventory report params required for s3 backups.
    /// </summary>
    [DataContract]
    public partial class S3ProtectionParams :  IEquatable<S3ProtectionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3ProtectionParams" /> class.
        /// </summary>
        /// <param name="s3InventoryReportBucket">ARN of the inventory report destination bucket for S3 backups. This is required for s3 backups..</param>
        /// <param name="s3InventoryReportBucketPrefix">Specifies the creation time of the entity..</param>
        public S3ProtectionParams(string s3InventoryReportBucket = default(string), string s3InventoryReportBucketPrefix = default(string))
        {
            this.S3InventoryReportBucket = s3InventoryReportBucket;
            this.S3InventoryReportBucketPrefix = s3InventoryReportBucketPrefix;
            this.S3InventoryReportBucket = s3InventoryReportBucket;
            this.S3InventoryReportBucketPrefix = s3InventoryReportBucketPrefix;
        }
        
        /// <summary>
        /// ARN of the inventory report destination bucket for S3 backups. This is required for s3 backups.
        /// </summary>
        /// <value>ARN of the inventory report destination bucket for S3 backups. This is required for s3 backups.</value>
        [DataMember(Name="s3InventoryReportBucket", EmitDefaultValue=true)]
        public string S3InventoryReportBucket { get; set; }

        /// <summary>
        /// Specifies the creation time of the entity.
        /// </summary>
        /// <value>Specifies the creation time of the entity.</value>
        [DataMember(Name="s3InventoryReportBucketPrefix", EmitDefaultValue=true)]
        public string S3InventoryReportBucketPrefix { get; set; }

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
            return this.Equals(input as S3ProtectionParams);
        }

        /// <summary>
        /// Returns true if S3ProtectionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of S3ProtectionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3ProtectionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.S3InventoryReportBucket == input.S3InventoryReportBucket ||
                    (this.S3InventoryReportBucket != null &&
                    this.S3InventoryReportBucket.Equals(input.S3InventoryReportBucket))
                ) && 
                (
                    this.S3InventoryReportBucketPrefix == input.S3InventoryReportBucketPrefix ||
                    (this.S3InventoryReportBucketPrefix != null &&
                    this.S3InventoryReportBucketPrefix.Equals(input.S3InventoryReportBucketPrefix))
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
                if (this.S3InventoryReportBucket != null)
                    hashCode = hashCode * 59 + this.S3InventoryReportBucket.GetHashCode();
                if (this.S3InventoryReportBucketPrefix != null)
                    hashCode = hashCode * 59 + this.S3InventoryReportBucketPrefix.GetHashCode();
                return hashCode;
            }
        }

    }

}

