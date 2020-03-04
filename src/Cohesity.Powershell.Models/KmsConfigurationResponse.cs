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
    /// Specifies response parameters to a KMS request.
    /// </summary>
    [DataContract]
    public partial class KmsConfigurationResponse :  IEquatable<KmsConfigurationResponse>
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
        /// Initializes a new instance of the <see cref="KmsConfigurationResponse" /> class.
        /// </summary>
        /// <param name="awsKms">awsKms.</param>
        /// <param name="connectionStatus">Specifies if connection to this KMS exists..</param>
        /// <param name="cryptsoftKms">cryptsoftKms.</param>
        /// <param name="id">The Id of a KMS server..</param>
        /// <param name="serverName">Specifies the name given to the KMS Server..</param>
        /// <param name="serverType">Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object..</param>
        public KmsConfigurationResponse(AwsKmsConfiguration awsKms = default(AwsKmsConfiguration), bool? connectionStatus = default(bool?), CryptsoftKmsConfigResponse cryptsoftKms = default(CryptsoftKmsConfigResponse), long? id = default(long?), string serverName = default(string), ServerTypeEnum? serverType = default(ServerTypeEnum?))
        {
            this.ConnectionStatus = connectionStatus;
            this.Id = id;
            this.ServerName = serverName;
            this.ServerType = serverType;
            this.AwsKms = awsKms;
            this.ConnectionStatus = connectionStatus;
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
        /// Specifies if connection to this KMS exists.
        /// </summary>
        /// <value>Specifies if connection to this KMS exists.</value>
        [DataMember(Name="connectionStatus", EmitDefaultValue=true)]
        public bool? ConnectionStatus { get; set; }

        /// <summary>
        /// Gets or Sets CryptsoftKms
        /// </summary>
        [DataMember(Name="cryptsoftKms", EmitDefaultValue=false)]
        public CryptsoftKmsConfigResponse CryptsoftKms { get; set; }

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
            return this.Equals(input as KmsConfigurationResponse);
        }

        /// <summary>
        /// Returns true if KmsConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KmsConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsConfigurationResponse input)
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
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
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
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
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

