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
    /// S3ViewBackupProperties
    /// </summary>
    [DataContract]
    public partial class S3ViewBackupProperties :  IEquatable<S3ViewBackupProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3ViewBackupProperties" /> class.
        /// </summary>
        /// <param name="accessKey">Access key for the buckets which will be created for the source initiated jobs. This needs to be passed to Netapp for it to for doing all s3 communications..</param>
        /// <param name="s3Config">s3Config.</param>
        /// <param name="secretKey">Secret key for the buckets will be created for the source initiated jobs. This secret key needed to be sent to Netapp for writing data to our S3 views..</param>
        /// <param name="snapshotPrefixName">The snapshot prefix which is needed at the time of incremental for backups. This is only needed for case of DP volume..</param>
        /// <param name="viewId">The id of the S3 view..</param>
        public S3ViewBackupProperties(string accessKey = default(string), S3BucketConfigProto s3Config = default(S3BucketConfigProto), string secretKey = default(string), string snapshotPrefixName = default(string), long? viewId = default(long?))
        {
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.SnapshotPrefixName = snapshotPrefixName;
            this.ViewId = viewId;
            this.AccessKey = accessKey;
            this.S3Config = s3Config;
            this.SecretKey = secretKey;
            this.SnapshotPrefixName = snapshotPrefixName;
            this.ViewId = viewId;
        }
        
        /// <summary>
        /// Access key for the buckets which will be created for the source initiated jobs. This needs to be passed to Netapp for it to for doing all s3 communications.
        /// </summary>
        /// <value>Access key for the buckets which will be created for the source initiated jobs. This needs to be passed to Netapp for it to for doing all s3 communications.</value>
        [DataMember(Name="accessKey", EmitDefaultValue=true)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets S3Config
        /// </summary>
        [DataMember(Name="s3Config", EmitDefaultValue=false)]
        public S3BucketConfigProto S3Config { get; set; }

        /// <summary>
        /// Secret key for the buckets will be created for the source initiated jobs. This secret key needed to be sent to Netapp for writing data to our S3 views.
        /// </summary>
        /// <value>Secret key for the buckets will be created for the source initiated jobs. This secret key needed to be sent to Netapp for writing data to our S3 views.</value>
        [DataMember(Name="secretKey", EmitDefaultValue=true)]
        public string SecretKey { get; set; }

        /// <summary>
        /// The snapshot prefix which is needed at the time of incremental for backups. This is only needed for case of DP volume.
        /// </summary>
        /// <value>The snapshot prefix which is needed at the time of incremental for backups. This is only needed for case of DP volume.</value>
        [DataMember(Name="snapshotPrefixName", EmitDefaultValue=true)]
        public string SnapshotPrefixName { get; set; }

        /// <summary>
        /// The id of the S3 view.
        /// </summary>
        /// <value>The id of the S3 view.</value>
        [DataMember(Name="viewId", EmitDefaultValue=true)]
        public long? ViewId { get; set; }

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
            return this.Equals(input as S3ViewBackupProperties);
        }

        /// <summary>
        /// Returns true if S3ViewBackupProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of S3ViewBackupProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3ViewBackupProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.S3Config == input.S3Config ||
                    (this.S3Config != null &&
                    this.S3Config.Equals(input.S3Config))
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
                ) && 
                (
                    this.SnapshotPrefixName == input.SnapshotPrefixName ||
                    (this.SnapshotPrefixName != null &&
                    this.SnapshotPrefixName.Equals(input.SnapshotPrefixName))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
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
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.S3Config != null)
                    hashCode = hashCode * 59 + this.S3Config.GetHashCode();
                if (this.SecretKey != null)
                    hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.SnapshotPrefixName != null)
                    hashCode = hashCode * 59 + this.SnapshotPrefixName.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                return hashCode;
            }
        }

    }

}

