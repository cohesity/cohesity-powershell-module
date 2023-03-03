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
    /// KmsUpdateRequestParameters
    /// </summary>
    [DataContract]
    public partial class KmsUpdateRequestParameters :  IEquatable<KmsUpdateRequestParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsUpdateRequestParameters" /> class.
        /// </summary>
        /// <param name="awsKms">awsKms.</param>
        /// <param name="cryptsoftKms">cryptsoftKms.</param>
        /// <param name="id">The Id of a KMS server..</param>
        /// <param name="keyName">Specifies name of the key..</param>
        /// <param name="serverName">Specifies the name given to the KMS Server..</param>
        /// <param name="vaultIdList">Specifies the list of Vault Ids..</param>
        /// <param name="viewBoxIdList">Specifies the list of View Box Ids..</param>
        public KmsUpdateRequestParameters(AwsKmsUpdateParams awsKms = default(AwsKmsUpdateParams), CryptsoftKmsUpdateParams cryptsoftKms = default(CryptsoftKmsUpdateParams), long? id = default(long?), string keyName = default(string), string serverName = default(string), List<long> vaultIdList = default(List<long>), List<long> viewBoxIdList = default(List<long>))
        {
            this.Id = id;
            this.KeyName = keyName;
            this.ServerName = serverName;
            this.VaultIdList = vaultIdList;
            this.ViewBoxIdList = viewBoxIdList;
            this.AwsKms = awsKms;
            this.CryptsoftKms = cryptsoftKms;
            this.Id = id;
            this.KeyName = keyName;
            this.ServerName = serverName;
            this.VaultIdList = vaultIdList;
            this.ViewBoxIdList = viewBoxIdList;
        }
        
        /// <summary>
        /// Gets or Sets AwsKms
        /// </summary>
        [DataMember(Name="awsKms", EmitDefaultValue=false)]
        public AwsKmsUpdateParams AwsKms { get; set; }

        /// <summary>
        /// Gets or Sets CryptsoftKms
        /// </summary>
        [DataMember(Name="cryptsoftKms", EmitDefaultValue=false)]
        public CryptsoftKmsUpdateParams CryptsoftKms { get; set; }

        /// <summary>
        /// The Id of a KMS server.
        /// </summary>
        /// <value>The Id of a KMS server.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies name of the key.
        /// </summary>
        /// <value>Specifies name of the key.</value>
        [DataMember(Name="keyName", EmitDefaultValue=true)]
        public string KeyName { get; set; }

        /// <summary>
        /// Specifies the name given to the KMS Server.
        /// </summary>
        /// <value>Specifies the name given to the KMS Server.</value>
        [DataMember(Name="serverName", EmitDefaultValue=true)]
        public string ServerName { get; set; }

        /// <summary>
        /// Specifies the list of Vault Ids.
        /// </summary>
        /// <value>Specifies the list of Vault Ids.</value>
        [DataMember(Name="vaultIdList", EmitDefaultValue=true)]
        public List<long> VaultIdList { get; set; }

        /// <summary>
        /// Specifies the list of View Box Ids.
        /// </summary>
        /// <value>Specifies the list of View Box Ids.</value>
        [DataMember(Name="viewBoxIdList", EmitDefaultValue=true)]
        public List<long> ViewBoxIdList { get; set; }

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
            return this.Equals(input as KmsUpdateRequestParameters);
        }

        /// <summary>
        /// Returns true if KmsUpdateRequestParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of KmsUpdateRequestParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsUpdateRequestParameters input)
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
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.VaultIdList == input.VaultIdList ||
                    this.VaultIdList != null &&
                    input.VaultIdList != null &&
                    this.VaultIdList.SequenceEqual(input.VaultIdList)
                ) && 
                (
                    this.ViewBoxIdList == input.ViewBoxIdList ||
                    this.ViewBoxIdList != null &&
                    input.ViewBoxIdList != null &&
                    this.ViewBoxIdList.SequenceEqual(input.ViewBoxIdList)
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
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.VaultIdList != null)
                    hashCode = hashCode * 59 + this.VaultIdList.GetHashCode();
                if (this.ViewBoxIdList != null)
                    hashCode = hashCode * 59 + this.ViewBoxIdList.GetHashCode();
                return hashCode;
            }
        }

    }

}

