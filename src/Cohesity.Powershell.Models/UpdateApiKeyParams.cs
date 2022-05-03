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
    /// Specifies the parameters to update an API key.
    /// </summary>
    [DataContract]
    public partial class UpdateApiKeyParams :  IEquatable<UpdateApiKeyParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateApiKeyParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyParams" /> class.
        /// </summary>
        /// <param name="expiringTimeMsecs">Specifies a time stamp when the API key will expire in milli seconds..</param>
        /// <param name="isActive">Specifies if the API key is active. Only an active and not expired API key can be used for authentication..</param>
        /// <param name="name">Specifies the name of API key. (required).</param>
        public UpdateApiKeyParams(long? expiringTimeMsecs = default(long?), bool? isActive = default(bool?), string name = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UpdateApiKeyParams and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.ExpiringTimeMsecs = expiringTimeMsecs;
            this.IsActive = isActive;
        }
        
        /// <summary>
        /// Specifies a time stamp when the API key will expire in milli seconds.
        /// </summary>
        /// <value>Specifies a time stamp when the API key will expire in milli seconds.</value>
        [DataMember(Name="expiringTimeMsecs", EmitDefaultValue=false)]
        public long? ExpiringTimeMsecs { get; set; }

        /// <summary>
        /// Specifies if the API key is active. Only an active and not expired API key can be used for authentication.
        /// </summary>
        /// <value>Specifies if the API key is active. Only an active and not expired API key can be used for authentication.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies the name of API key.
        /// </summary>
        /// <value>Specifies the name of API key.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            return this.Equals(input as UpdateApiKeyParams);
        }

        /// <summary>
        /// Returns true if UpdateApiKeyParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApiKeyParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApiKeyParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiringTimeMsecs == input.ExpiringTimeMsecs ||
                    (this.ExpiringTimeMsecs != null &&
                    this.ExpiringTimeMsecs.Equals(input.ExpiringTimeMsecs))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ExpiringTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiringTimeMsecs.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

