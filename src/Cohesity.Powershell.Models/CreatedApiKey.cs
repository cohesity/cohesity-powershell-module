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
    /// Specifies a created API key.
    /// </summary>
    [DataContract]
    public partial class CreatedApiKey :  IEquatable<CreatedApiKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedApiKey" /> class.
        /// </summary>
        /// <param name="createdTimeMsecs">Specifies the API key created time in milli seconds..</param>
        /// <param name="createdUserSid">Specifies the user sid who created this API key..</param>
        /// <param name="createdUsername">Specifies the username who created this API key..</param>
        /// <param name="expiringTimeMsecs">Specifies a time stamp when the API key will expire in milli seconds..</param>
        /// <param name="id">Specifies the API key id..</param>
        /// <param name="isActive">Specifies if the API key is active. Only an active and not expired API key can be used for authentication..</param>
        /// <param name="isExpired">Specifies if the API key is expired. Expired API keys cannot be used for authentication..</param>
        /// <param name="key">Specifies the created key..</param>
        /// <param name="name">Specifies the API key name..</param>
        /// <param name="ownerUserSid">Specifies the user sid who owns this API key..</param>
        /// <param name="ownerUsername">Specifies the username who owns this API key..</param>
        public CreatedApiKey(long? createdTimeMsecs = default(long?), string createdUserSid = default(string), string createdUsername = default(string), long? expiringTimeMsecs = default(long?), string id = default(string), bool? isActive = default(bool?), bool? isExpired = default(bool?), string key = default(string), string name = default(string), string ownerUserSid = default(string), string ownerUsername = default(string))
        {
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.CreatedUserSid = createdUserSid;
            this.CreatedUsername = createdUsername;
            this.ExpiringTimeMsecs = expiringTimeMsecs;
            this.Id = id;
            this.IsActive = isActive;
            this.IsExpired = isExpired;
            this.Key = key;
            this.Name = name;
            this.OwnerUserSid = ownerUserSid;
            this.OwnerUsername = ownerUsername;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.CreatedUserSid = createdUserSid;
            this.CreatedUsername = createdUsername;
            this.ExpiringTimeMsecs = expiringTimeMsecs;
            this.Id = id;
            this.IsActive = isActive;
            this.IsExpired = isExpired;
            this.Key = key;
            this.Name = name;
            this.OwnerUserSid = ownerUserSid;
            this.OwnerUsername = ownerUsername;
        }
        
        /// <summary>
        /// Specifies the API key created time in milli seconds.
        /// </summary>
        /// <value>Specifies the API key created time in milli seconds.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the user sid who created this API key.
        /// </summary>
        /// <value>Specifies the user sid who created this API key.</value>
        [DataMember(Name="createdUserSid", EmitDefaultValue=true)]
        public string CreatedUserSid { get; set; }

        /// <summary>
        /// Specifies the username who created this API key.
        /// </summary>
        /// <value>Specifies the username who created this API key.</value>
        [DataMember(Name="createdUsername", EmitDefaultValue=true)]
        public string CreatedUsername { get; set; }

        /// <summary>
        /// Specifies a time stamp when the API key will expire in milli seconds.
        /// </summary>
        /// <value>Specifies a time stamp when the API key will expire in milli seconds.</value>
        [DataMember(Name="expiringTimeMsecs", EmitDefaultValue=true)]
        public long? ExpiringTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the API key id.
        /// </summary>
        /// <value>Specifies the API key id.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies if the API key is active. Only an active and not expired API key can be used for authentication.
        /// </summary>
        /// <value>Specifies if the API key is active. Only an active and not expired API key can be used for authentication.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies if the API key is expired. Expired API keys cannot be used for authentication.
        /// </summary>
        /// <value>Specifies if the API key is expired. Expired API keys cannot be used for authentication.</value>
        [DataMember(Name="isExpired", EmitDefaultValue=true)]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Specifies the created key.
        /// </summary>
        /// <value>Specifies the created key.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies the API key name.
        /// </summary>
        /// <value>Specifies the API key name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the user sid who owns this API key.
        /// </summary>
        /// <value>Specifies the user sid who owns this API key.</value>
        [DataMember(Name="ownerUserSid", EmitDefaultValue=true)]
        public string OwnerUserSid { get; set; }

        /// <summary>
        /// Specifies the username who owns this API key.
        /// </summary>
        /// <value>Specifies the username who owns this API key.</value>
        [DataMember(Name="ownerUsername", EmitDefaultValue=true)]
        public string OwnerUsername { get; set; }

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
            return this.Equals(input as CreatedApiKey);
        }

        /// <summary>
        /// Returns true if CreatedApiKey instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatedApiKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatedApiKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.CreatedUserSid == input.CreatedUserSid ||
                    (this.CreatedUserSid != null &&
                    this.CreatedUserSid.Equals(input.CreatedUserSid))
                ) && 
                (
                    this.CreatedUsername == input.CreatedUsername ||
                    (this.CreatedUsername != null &&
                    this.CreatedUsername.Equals(input.CreatedUsername))
                ) && 
                (
                    this.ExpiringTimeMsecs == input.ExpiringTimeMsecs ||
                    (this.ExpiringTimeMsecs != null &&
                    this.ExpiringTimeMsecs.Equals(input.ExpiringTimeMsecs))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsExpired == input.IsExpired ||
                    (this.IsExpired != null &&
                    this.IsExpired.Equals(input.IsExpired))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerUserSid == input.OwnerUserSid ||
                    (this.OwnerUserSid != null &&
                    this.OwnerUserSid.Equals(input.OwnerUserSid))
                ) && 
                (
                    this.OwnerUsername == input.OwnerUsername ||
                    (this.OwnerUsername != null &&
                    this.OwnerUsername.Equals(input.OwnerUsername))
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
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.CreatedUserSid != null)
                    hashCode = hashCode * 59 + this.CreatedUserSid.GetHashCode();
                if (this.CreatedUsername != null)
                    hashCode = hashCode * 59 + this.CreatedUsername.GetHashCode();
                if (this.ExpiringTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiringTimeMsecs.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsExpired != null)
                    hashCode = hashCode * 59 + this.IsExpired.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerUserSid != null)
                    hashCode = hashCode * 59 + this.OwnerUserSid.GetHashCode();
                if (this.OwnerUsername != null)
                    hashCode = hashCode * 59 + this.OwnerUsername.GetHashCode();
                return hashCode;
            }
        }

    }

}

