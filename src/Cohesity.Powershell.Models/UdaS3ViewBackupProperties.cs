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
    /// // - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    /// </summary>
    [DataContract]
    public partial class UdaS3ViewBackupProperties :  IEquatable<UdaS3ViewBackupProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaS3ViewBackupProperties" /> class.
        /// </summary>
        /// <param name="accessKey">Access key for the buckets which will be created for the source initiated jobs. This needs to be passed to UDA for doing all s3 communications..</param>
        /// <param name="s3Config">s3Config.</param>
        /// <param name="secretKey">Secret key for the buckets will be created for the source initiated jobs. This secret key needed to be sent to UDA for writing data to our S3 views..</param>
        public UdaS3ViewBackupProperties(string accessKey = default(string), S3BucketConfigProto s3Config = default(S3BucketConfigProto), string secretKey = default(string))
        {
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.AccessKey = accessKey;
            this.S3Config = s3Config;
            this.SecretKey = secretKey;
        }
        
        /// <summary>
        /// Access key for the buckets which will be created for the source initiated jobs. This needs to be passed to UDA for doing all s3 communications.
        /// </summary>
        /// <value>Access key for the buckets which will be created for the source initiated jobs. This needs to be passed to UDA for doing all s3 communications.</value>
        [DataMember(Name="accessKey", EmitDefaultValue=true)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets S3Config
        /// </summary>
        [DataMember(Name="s3Config", EmitDefaultValue=false)]
        public S3BucketConfigProto S3Config { get; set; }

        /// <summary>
        /// Secret key for the buckets will be created for the source initiated jobs. This secret key needed to be sent to UDA for writing data to our S3 views.
        /// </summary>
        /// <value>Secret key for the buckets will be created for the source initiated jobs. This secret key needed to be sent to UDA for writing data to our S3 views.</value>
        [DataMember(Name="secretKey", EmitDefaultValue=true)]
        public string SecretKey { get; set; }

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
            return this.Equals(input as UdaS3ViewBackupProperties);
        }

        /// <summary>
        /// Returns true if UdaS3ViewBackupProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaS3ViewBackupProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaS3ViewBackupProperties input)
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
                return hashCode;
            }
        }

    }

}

