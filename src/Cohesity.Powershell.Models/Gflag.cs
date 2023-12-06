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
    /// Specifies the attributes of a service gflag.
    /// </summary>
    [DataContract]
    public partial class Gflag :  IEquatable<Gflag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gflag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Gflag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Gflag" /> class.
        /// </summary>
        /// <param name="name">Specifies name of the gflag. (required).</param>
        /// <param name="productModel">Specifies product model this gflag set on..</param>
        /// <param name="reason">Specifies reason for setting the gflag..</param>
        /// <param name="value">Specifies value of the gflag..</param>
        public Gflag(string name = default(string), string productModel = default(string), string reason = default(string), string value = default(string))
        {
            this.Name = name;
            this.ProductModel = productModel;
            this.Reason = reason;
            this.Value = value;
            this.ProductModel = productModel;
            this.Reason = reason;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies name of the gflag.
        /// </summary>
        /// <value>Specifies name of the gflag.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies product model this gflag set on.
        /// </summary>
        /// <value>Specifies product model this gflag set on.</value>
        [DataMember(Name="productModel", EmitDefaultValue=true)]
        public string ProductModel { get; set; }

        /// <summary>
        /// Specifies reason for setting the gflag.
        /// </summary>
        /// <value>Specifies reason for setting the gflag.</value>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public string Reason { get; set; }

        /// <summary>
        /// Specifies timestamp when gflag was set.
        /// </summary>
        /// <value>Specifies timestamp when gflag was set.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=true)]
        public long? Timestamp { get; private set; }

        /// <summary>
        /// Specifies value of the gflag.
        /// </summary>
        /// <value>Specifies value of the gflag.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

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
            return this.Equals(input as Gflag);
        }

        /// <summary>
        /// Returns true if Gflag instances are equal
        /// </summary>
        /// <param name="input">Instance of Gflag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Gflag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductModel == input.ProductModel ||
                    (this.ProductModel != null &&
                    this.ProductModel.Equals(input.ProductModel))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProductModel != null)
                    hashCode = hashCode * 59 + this.ProductModel.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

