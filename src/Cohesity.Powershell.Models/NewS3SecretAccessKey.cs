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
    /// NewS3SecretAccessKey
    /// </summary>
    [DataContract]
    public partial class NewS3SecretAccessKey :  IEquatable<NewS3SecretAccessKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewS3SecretAccessKey" /> class.
        /// </summary>
        /// <param name="newKey">Specifies the new S3 Secret Access key..</param>
        public NewS3SecretAccessKey(string newKey = default(string))
        {
            this.NewKey = newKey;
            this.NewKey = newKey;
        }
        
        /// <summary>
        /// Specifies the new S3 Secret Access key.
        /// </summary>
        /// <value>Specifies the new S3 Secret Access key.</value>
        [DataMember(Name="newKey", EmitDefaultValue=true)]
        public string NewKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewS3SecretAccessKey {\n");
            sb.Append("  NewKey: ").Append(NewKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as NewS3SecretAccessKey);
        }

        /// <summary>
        /// Returns true if NewS3SecretAccessKey instances are equal
        /// </summary>
        /// <param name="input">Instance of NewS3SecretAccessKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewS3SecretAccessKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewKey == input.NewKey ||
                    (this.NewKey != null &&
                    this.NewKey.Equals(input.NewKey))
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
                if (this.NewKey != null)
                    hashCode = hashCode * 59 + this.NewKey.GetHashCode();
                return hashCode;
            }
        }

    }

}
