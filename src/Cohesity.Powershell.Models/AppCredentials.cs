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
    /// AppCredentials
    /// </summary>
    [DataContract]
    public partial class AppCredentials :  IEquatable<AppCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCredentials" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="envType">Specifies the Application type for which the credentials apply..</param>
        public AppCredentials(Credentials credentials = default(Credentials), int? envType = default(int?))
        {
            this.EnvType = envType;
            this.Credentials = credentials;
            this.EnvType = envType;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Specifies the Application type for which the credentials apply.
        /// </summary>
        /// <value>Specifies the Application type for which the credentials apply.</value>
        [DataMember(Name="envType", EmitDefaultValue=true)]
        public int? EnvType { get; set; }

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
            return this.Equals(input as AppCredentials);
        }

        /// <summary>
        /// Returns true if AppCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCredentials input)
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
                    this.EnvType == input.EnvType ||
                    (this.EnvType != null &&
                    this.EnvType.Equals(input.EnvType))
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
                if (this.EnvType != null)
                    hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                return hashCode;
            }
        }

    }

}

