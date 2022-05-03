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
    /// LifecycleRule
    /// </summary>
    [DataContract]
    public partial class LifecycleRule :  IEquatable<LifecycleRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleRule" /> class.
        /// </summary>
        /// <param name="abortIncompleteMultipartUpload">abortIncompleteMultipartUpload.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="filter">filter.</param>
        /// <param name="id">Unique identifier for the rule. The value cannot be longer than 255 characters..</param>
        /// <param name="noncurrentVersionExpiration">noncurrentVersionExpiration.</param>
        /// <param name="prefix">The prefix is used to identify objects that a lifecycle rule applies to..</param>
        /// <param name="status">If set, the rule is currently being applied. If &#39;Disabled&#39;, the rule is not currently being applied..</param>
        public LifecycleRule(AbortIncompleteMultipartUploadAction abortIncompleteMultipartUpload = default(AbortIncompleteMultipartUploadAction), ExpirationAction expiration = default(ExpirationAction), LifecycleRuleFilter filter = default(LifecycleRuleFilter), string id = default(string), NoncurrentVersionExpirationAction noncurrentVersionExpiration = default(NoncurrentVersionExpirationAction), string prefix = default(string), bool? status = default(bool?))
        {
            this.AbortIncompleteMultipartUpload = abortIncompleteMultipartUpload;
            this.Expiration = expiration;
            this.Filter = filter;
            this.Id = id;
            this.NoncurrentVersionExpiration = noncurrentVersionExpiration;
            this.Prefix = prefix;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets AbortIncompleteMultipartUpload
        /// </summary>
        [DataMember(Name="abortIncompleteMultipartUpload", EmitDefaultValue=false)]
        public AbortIncompleteMultipartUploadAction AbortIncompleteMultipartUpload { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public ExpirationAction Expiration { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public LifecycleRuleFilter Filter { get; set; }

        /// <summary>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </summary>
        /// <value>Unique identifier for the rule. The value cannot be longer than 255 characters.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets NoncurrentVersionExpiration
        /// </summary>
        [DataMember(Name="noncurrentVersionExpiration", EmitDefaultValue=false)]
        public NoncurrentVersionExpirationAction NoncurrentVersionExpiration { get; set; }

        /// <summary>
        /// The prefix is used to identify objects that a lifecycle rule applies to.
        /// </summary>
        /// <value>The prefix is used to identify objects that a lifecycle rule applies to.</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// If set, the rule is currently being applied. If &#39;Disabled&#39;, the rule is not currently being applied.
        /// </summary>
        /// <value>If set, the rule is currently being applied. If &#39;Disabled&#39;, the rule is not currently being applied.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool? Status { get; set; }

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
            return this.Equals(input as LifecycleRule);
        }

        /// <summary>
        /// Returns true if LifecycleRule instances are equal
        /// </summary>
        /// <param name="input">Instance of LifecycleRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbortIncompleteMultipartUpload == input.AbortIncompleteMultipartUpload ||
                    (this.AbortIncompleteMultipartUpload != null &&
                    this.AbortIncompleteMultipartUpload.Equals(input.AbortIncompleteMultipartUpload))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NoncurrentVersionExpiration == input.NoncurrentVersionExpiration ||
                    (this.NoncurrentVersionExpiration != null &&
                    this.NoncurrentVersionExpiration.Equals(input.NoncurrentVersionExpiration))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AbortIncompleteMultipartUpload != null)
                    hashCode = hashCode * 59 + this.AbortIncompleteMultipartUpload.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NoncurrentVersionExpiration != null)
                    hashCode = hashCode * 59 + this.NoncurrentVersionExpiration.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

