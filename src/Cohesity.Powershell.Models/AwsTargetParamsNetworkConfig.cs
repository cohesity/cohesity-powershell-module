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
    /// Proto to define the network configuration to be applied to the target restore.
    /// </summary>
    [DataContract]
    public partial class AwsTargetParamsNetworkConfig :  IEquatable<AwsTargetParamsNetworkConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsTargetParamsNetworkConfig" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="instance">instance.</param>
        /// <param name="ip">Ip in which to deploy the Rds Postgres database..</param>
        /// <param name="isNewSource">If set to true means we are recovering to the same destination where the backup is made from. We are not needed to fill any other config if this is set to true. Magneto itself will fetch the config in this case..</param>
        /// <param name="port">Port to use to connect to the RDS Postgres server..</param>
        /// <param name="region">region.</param>
        /// <param name="source">source.</param>
        public AwsTargetParamsNetworkConfig(CredentialsProto credentials = default(CredentialsProto), AwsEntity instance = default(AwsEntity), string ip = default(string), bool? isNewSource = default(bool?), int? port = default(int?), AwsEntity region = default(AwsEntity), AwsEntity source = default(AwsEntity))
        {
            this.Ip = ip;
            this.IsNewSource = isNewSource;
            this.Port = port;
            this.Credentials = credentials;
            this.Instance = instance;
            this.Ip = ip;
            this.IsNewSource = isNewSource;
            this.Port = port;
            this.Region = region;
            this.Source = source;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public CredentialsProto Credentials { get; set; }

        /// <summary>
        /// Gets or Sets Instance
        /// </summary>
        [DataMember(Name="instance", EmitDefaultValue=false)]
        public AwsEntity Instance { get; set; }

        /// <summary>
        /// Ip in which to deploy the Rds Postgres database.
        /// </summary>
        /// <value>Ip in which to deploy the Rds Postgres database.</value>
        [DataMember(Name="ip", EmitDefaultValue=true)]
        public string Ip { get; set; }

        /// <summary>
        /// If set to true means we are recovering to the same destination where the backup is made from. We are not needed to fill any other config if this is set to true. Magneto itself will fetch the config in this case.
        /// </summary>
        /// <value>If set to true means we are recovering to the same destination where the backup is made from. We are not needed to fill any other config if this is set to true. Magneto itself will fetch the config in this case.</value>
        [DataMember(Name="isNewSource", EmitDefaultValue=true)]
        public bool? IsNewSource { get; set; }

        /// <summary>
        /// Port to use to connect to the RDS Postgres server.
        /// </summary>
        /// <value>Port to use to connect to the RDS Postgres server.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public AwsEntity Region { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public AwsEntity Source { get; set; }

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
            return this.Equals(input as AwsTargetParamsNetworkConfig);
        }

        /// <summary>
        /// Returns true if AwsTargetParamsNetworkConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsTargetParamsNetworkConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsTargetParamsNetworkConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.IsNewSource == input.IsNewSource ||
                    (this.IsNewSource != null &&
                    this.IsNewSource.Equals(input.IsNewSource))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.IsNewSource != null)
                    hashCode = hashCode * 59 + this.IsNewSource.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }

    }

}

