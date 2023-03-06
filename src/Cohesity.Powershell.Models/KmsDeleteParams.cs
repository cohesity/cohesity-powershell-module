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
    /// KmsDeleteParams
    /// </summary>
    [DataContract]
    public partial class KmsDeleteParams :  IEquatable<KmsDeleteParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsDeleteParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KmsDeleteParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsDeleteParams" /> class.
        /// </summary>
        /// <param name="id">Specifies a unique id of the KMS config. in: path (required).</param>
        public KmsDeleteParams(long? id = default(long?))
        {
            this.Id = id;
        }
        
        /// <summary>
        /// Specifies a unique id of the KMS config. in: path
        /// </summary>
        /// <value>Specifies a unique id of the KMS config. in: path</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

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
            return this.Equals(input as KmsDeleteParams);
        }

        /// <summary>
        /// Returns true if KmsDeleteParams instances are equal
        /// </summary>
        /// <param name="input">Instance of KmsDeleteParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsDeleteParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

    }

}

