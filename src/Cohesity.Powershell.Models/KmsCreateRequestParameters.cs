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
    /// KmsCreateRequestParameters
    /// </summary>
    [DataContract]
    public partial class KmsCreateRequestParameters :  IEquatable<KmsCreateRequestParameters>
    {
        /// <summary>
        /// Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.
        /// </summary>
        /// <value>Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServerTypeEnum
        {
            /// <summary>
            /// Enum KInternalKms for value: kInternalKms
            /// </summary>
            [EnumMember(Value = "kInternalKms")]
            KInternalKms = 1,

            /// <summary>
            /// Enum KAwsKms for value: kAwsKms
            /// </summary>
            [EnumMember(Value = "kAwsKms")]
            KAwsKms = 2,

            /// <summary>
            /// Enum KCryptsoftKms for value: kCryptsoftKms
            /// </summary>
            [EnumMember(Value = "kCryptsoftKms")]
            KCryptsoftKms = 3

        }

        /// <summary>
        /// Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.
        /// </summary>
        /// <value>Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.</value>
        [DataMember(Name="serverType", EmitDefaultValue=true)]
        public ServerTypeEnum? ServerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsCreateRequestParameters" /> class.
        /// </summary>
        /// <param name="awsKms">awsKms.</param>
        /// <param name="cryptsoftKms">cryptsoftKms.</param>
        /// <param name="id">The Id of a KMS server..</param>
        /// <param name="serverName">Specifies the name given to the KMS Server..</param>
        /// <param name="serverType">Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object..</param>
        public KmsCreateRequestParameters(AwsKmsConfiguration awsKms = default(AwsKmsConfiguration), CryptsoftKmsConfiguration cryptsoftKms = default(CryptsoftKmsConfiguration), long? id = default(long?), string serverName = default(string), ServerTypeEnum? serverType = default(ServerTypeEnum?))
        {
            this.Id = id;
            this.ServerName = serverName;
            this.ServerType = serverType;
            this.AwsKms = awsKms;
            this.CryptsoftKms = cryptsoftKms;
            this.Id = id;
            this.ServerName = serverName;
            this.ServerType = serverType;
        }
        
        /// <summary>
        /// Gets or Sets AwsKms
        /// </summary>
        [DataMember(Name="awsKms", EmitDefaultValue=false)]
        public AwsKmsConfiguration AwsKms { get; set; }

        /// <summary>
        /// Gets or Sets CryptsoftKms
        /// </summary>
        [DataMember(Name="cryptsoftKms", EmitDefaultValue=false)]
        public CryptsoftKmsConfiguration CryptsoftKms { get; set; }

        /// <summary>
        /// The Id of a KMS server.
        /// </summary>
        /// <value>The Id of a KMS server.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name given to the KMS Server.
        /// </summary>
        /// <value>Specifies the name given to the KMS Server.</value>
        [DataMember(Name="serverName", EmitDefaultValue=true)]
        public string ServerName { get; set; }

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
            return this.Equals(input as KmsCreateRequestParameters);
        }

        /// <summary>
        /// Returns true if KmsCreateRequestParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of KmsCreateRequestParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsCreateRequestParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsKms == input.AwsKms ||
                    (this.AwsKms != null &&
                    this.AwsKms.Equals(input.AwsKms))
                ) && 
                (
                    this.CryptsoftKms == input.CryptsoftKms ||
                    (this.CryptsoftKms != null &&
                    this.CryptsoftKms.Equals(input.CryptsoftKms))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.ServerType == input.ServerType ||
                    this.ServerType.Equals(input.ServerType)
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
                if (this.AwsKms != null)
                    hashCode = hashCode * 59 + this.AwsKms.GetHashCode();
                if (this.CryptsoftKms != null)
                    hashCode = hashCode * 59 + this.CryptsoftKms.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                return hashCode;
            }
        }

    }

}

