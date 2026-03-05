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
    /// Proto that stores all the metadata for migration of bucket from S3 1.0 to 2.0.
    /// </summary>
    [DataContract]
    public partial class ObjectIdMigrationProto :  IEquatable<ObjectIdMigrationProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectIdMigrationProto" /> class.
        /// </summary>
        /// <param name="migrationState">migrationState.</param>
        /// <param name="oldS3KeyMappingConfig">oldS3KeyMappingConfig.</param>
        /// <param name="oldS3ObjectCount">Number of S3 1.0 objects in the bucket..</param>
        public ObjectIdMigrationProto(int? migrationState = default(int?), S3KeyMappingConfigProto oldS3KeyMappingConfig = default(S3KeyMappingConfigProto), long? oldS3ObjectCount = default(long?))
        {
            this.MigrationState = migrationState;
            this.OldS3ObjectCount = oldS3ObjectCount;
            this.MigrationState = migrationState;
            this.OldS3KeyMappingConfig = oldS3KeyMappingConfig;
            this.OldS3ObjectCount = oldS3ObjectCount;
        }
        
        /// <summary>
        /// Gets or Sets MigrationState
        /// </summary>
        [DataMember(Name="migrationState", EmitDefaultValue=true)]
        public int? MigrationState { get; set; }

        /// <summary>
        /// Gets or Sets OldS3KeyMappingConfig
        /// </summary>
        [DataMember(Name="oldS3KeyMappingConfig", EmitDefaultValue=false)]
        public S3KeyMappingConfigProto OldS3KeyMappingConfig { get; set; }

        /// <summary>
        /// Number of S3 1.0 objects in the bucket.
        /// </summary>
        /// <value>Number of S3 1.0 objects in the bucket.</value>
        [DataMember(Name="oldS3ObjectCount", EmitDefaultValue=true)]
        public long? OldS3ObjectCount { get; set; }

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
            return this.Equals(input as ObjectIdMigrationProto);
        }

        /// <summary>
        /// Returns true if ObjectIdMigrationProto instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectIdMigrationProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectIdMigrationProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigrationState == input.MigrationState ||
                    (this.MigrationState != null &&
                    this.MigrationState.Equals(input.MigrationState))
                ) && 
                (
                    this.OldS3KeyMappingConfig == input.OldS3KeyMappingConfig ||
                    (this.OldS3KeyMappingConfig != null &&
                    this.OldS3KeyMappingConfig.Equals(input.OldS3KeyMappingConfig))
                ) && 
                (
                    this.OldS3ObjectCount == input.OldS3ObjectCount ||
                    (this.OldS3ObjectCount != null &&
                    this.OldS3ObjectCount.Equals(input.OldS3ObjectCount))
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
                if (this.MigrationState != null)
                    hashCode = hashCode * 59 + this.MigrationState.GetHashCode();
                if (this.OldS3KeyMappingConfig != null)
                    hashCode = hashCode * 59 + this.OldS3KeyMappingConfig.GetHashCode();
                if (this.OldS3ObjectCount != null)
                    hashCode = hashCode * 59 + this.OldS3ObjectCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

