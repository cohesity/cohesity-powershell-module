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
    /// BucketLoggingProto
    /// </summary>
    [DataContract]
    public partial class BucketLoggingProto :  IEquatable<BucketLoggingProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketLoggingProto" /> class.
        /// </summary>
        /// <param name="targetBucket">The target bucket to write access log to..</param>
        /// <param name="targetLogObjGrants">This field defines the users/groups who will have access to the access log objects..</param>
        /// <param name="targetObjectKeyFormat">targetObjectKeyFormat.</param>
        /// <param name="targetPrefix">The target prefix for the object to be created. Format of the target file created is TargetPrefixYYYY-mm-DD-HH-MM-SS-UniqueString..</param>
        public BucketLoggingProto(string targetBucket = default(string), List<ACLProtoGrant> targetLogObjGrants = default(List<ACLProtoGrant>), BucketLoggingProtoTargetObjectKeyFormat targetObjectKeyFormat = default(BucketLoggingProtoTargetObjectKeyFormat), string targetPrefix = default(string))
        {
            this.TargetBucket = targetBucket;
            this.TargetLogObjGrants = targetLogObjGrants;
            this.TargetPrefix = targetPrefix;
            this.TargetBucket = targetBucket;
            this.TargetLogObjGrants = targetLogObjGrants;
            this.TargetObjectKeyFormat = targetObjectKeyFormat;
            this.TargetPrefix = targetPrefix;
        }
        
        /// <summary>
        /// The target bucket to write access log to.
        /// </summary>
        /// <value>The target bucket to write access log to.</value>
        [DataMember(Name="targetBucket", EmitDefaultValue=true)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// This field defines the users/groups who will have access to the access log objects.
        /// </summary>
        /// <value>This field defines the users/groups who will have access to the access log objects.</value>
        [DataMember(Name="targetLogObjGrants", EmitDefaultValue=true)]
        public List<ACLProtoGrant> TargetLogObjGrants { get; set; }

        /// <summary>
        /// Gets or Sets TargetObjectKeyFormat
        /// </summary>
        [DataMember(Name="targetObjectKeyFormat", EmitDefaultValue=false)]
        public BucketLoggingProtoTargetObjectKeyFormat TargetObjectKeyFormat { get; set; }

        /// <summary>
        /// The target prefix for the object to be created. Format of the target file created is TargetPrefixYYYY-mm-DD-HH-MM-SS-UniqueString.
        /// </summary>
        /// <value>The target prefix for the object to be created. Format of the target file created is TargetPrefixYYYY-mm-DD-HH-MM-SS-UniqueString.</value>
        [DataMember(Name="targetPrefix", EmitDefaultValue=true)]
        public string TargetPrefix { get; set; }

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
            return this.Equals(input as BucketLoggingProto);
        }

        /// <summary>
        /// Returns true if BucketLoggingProto instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketLoggingProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketLoggingProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetBucket == input.TargetBucket ||
                    (this.TargetBucket != null &&
                    this.TargetBucket.Equals(input.TargetBucket))
                ) && 
                (
                    this.TargetLogObjGrants == input.TargetLogObjGrants ||
                    this.TargetLogObjGrants != null &&
                    input.TargetLogObjGrants != null &&
                    this.TargetLogObjGrants.SequenceEqual(input.TargetLogObjGrants)
                ) && 
                (
                    this.TargetObjectKeyFormat == input.TargetObjectKeyFormat ||
                    (this.TargetObjectKeyFormat != null &&
                    this.TargetObjectKeyFormat.Equals(input.TargetObjectKeyFormat))
                ) && 
                (
                    this.TargetPrefix == input.TargetPrefix ||
                    (this.TargetPrefix != null &&
                    this.TargetPrefix.Equals(input.TargetPrefix))
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
                if (this.TargetBucket != null)
                    hashCode = hashCode * 59 + this.TargetBucket.GetHashCode();
                if (this.TargetLogObjGrants != null)
                    hashCode = hashCode * 59 + this.TargetLogObjGrants.GetHashCode();
                if (this.TargetObjectKeyFormat != null)
                    hashCode = hashCode * 59 + this.TargetObjectKeyFormat.GetHashCode();
                if (this.TargetPrefix != null)
                    hashCode = hashCode * 59 + this.TargetPrefix.GetHashCode();
                return hashCode;
            }
        }

    }

}

