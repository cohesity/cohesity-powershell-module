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
    /// EncryptionParams
    /// </summary>
    [DataContract]
    public partial class EncryptionParams :  IEquatable<EncryptionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionParams" /> class.
        /// </summary>
        /// <param name="customKmsKeyArn">String containing kms key arn in case of custom key option. Example: arn:aws:kms:&lt;region&gt;:&lt;account_id&gt;:key/&lt;key_id&gt;.</param>
        /// <param name="kmsKey">kmsKey.</param>
        /// <param name="shouldEncrypt">Whether to encrypt the restored instance&#39;s volumes or not. For recovery to new location, this will be true by default..</param>
        public EncryptionParams(string customKmsKeyArn = default(string), EntityProto kmsKey = default(EntityProto), bool? shouldEncrypt = default(bool?))
        {
            this.CustomKmsKeyArn = customKmsKeyArn;
            this.ShouldEncrypt = shouldEncrypt;
            this.CustomKmsKeyArn = customKmsKeyArn;
            this.KmsKey = kmsKey;
            this.ShouldEncrypt = shouldEncrypt;
        }
        
        /// <summary>
        /// String containing kms key arn in case of custom key option. Example: arn:aws:kms:&lt;region&gt;:&lt;account_id&gt;:key/&lt;key_id&gt;
        /// </summary>
        /// <value>String containing kms key arn in case of custom key option. Example: arn:aws:kms:&lt;region&gt;:&lt;account_id&gt;:key/&lt;key_id&gt;</value>
        [DataMember(Name="customKmsKeyArn", EmitDefaultValue=true)]
        public string CustomKmsKeyArn { get; set; }

        /// <summary>
        /// Gets or Sets KmsKey
        /// </summary>
        [DataMember(Name="kmsKey", EmitDefaultValue=false)]
        public EntityProto KmsKey { get; set; }

        /// <summary>
        /// Whether to encrypt the restored instance&#39;s volumes or not. For recovery to new location, this will be true by default.
        /// </summary>
        /// <value>Whether to encrypt the restored instance&#39;s volumes or not. For recovery to new location, this will be true by default.</value>
        [DataMember(Name="shouldEncrypt", EmitDefaultValue=true)]
        public bool? ShouldEncrypt { get; set; }

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
            return this.Equals(input as EncryptionParams);
        }

        /// <summary>
        /// Returns true if EncryptionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomKmsKeyArn == input.CustomKmsKeyArn ||
                    (this.CustomKmsKeyArn != null &&
                    this.CustomKmsKeyArn.Equals(input.CustomKmsKeyArn))
                ) && 
                (
                    this.KmsKey == input.KmsKey ||
                    (this.KmsKey != null &&
                    this.KmsKey.Equals(input.KmsKey))
                ) && 
                (
                    this.ShouldEncrypt == input.ShouldEncrypt ||
                    (this.ShouldEncrypt != null &&
                    this.ShouldEncrypt.Equals(input.ShouldEncrypt))
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
                if (this.CustomKmsKeyArn != null)
                    hashCode = hashCode * 59 + this.CustomKmsKeyArn.GetHashCode();
                if (this.KmsKey != null)
                    hashCode = hashCode * 59 + this.KmsKey.GetHashCode();
                if (this.ShouldEncrypt != null)
                    hashCode = hashCode * 59 + this.ShouldEncrypt.GetHashCode();
                return hashCode;
            }
        }

    }

}

