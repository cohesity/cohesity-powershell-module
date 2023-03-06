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
    /// Specifies a group of product model and interface set.
    /// </summary>
    [DataContract]
    public partial class ProductModelInterfaceTuple :  IEquatable<ProductModelInterfaceTuple>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModelInterfaceTuple" /> class.
        /// </summary>
        /// <param name="ifaceName">Specifies the name of the interface..</param>
        /// <param name="productModelName">Specifies the product model name..</param>
        public ProductModelInterfaceTuple(string ifaceName = default(string), string productModelName = default(string))
        {
            this.IfaceName = ifaceName;
            this.ProductModelName = productModelName;
            this.IfaceName = ifaceName;
            this.ProductModelName = productModelName;
        }
        
        /// <summary>
        /// Specifies the name of the interface.
        /// </summary>
        /// <value>Specifies the name of the interface.</value>
        [DataMember(Name="ifaceName", EmitDefaultValue=true)]
        public string IfaceName { get; set; }

        /// <summary>
        /// Specifies the product model name.
        /// </summary>
        /// <value>Specifies the product model name.</value>
        [DataMember(Name="productModelName", EmitDefaultValue=true)]
        public string ProductModelName { get; set; }

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
            return this.Equals(input as ProductModelInterfaceTuple);
        }

        /// <summary>
        /// Returns true if ProductModelInterfaceTuple instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductModelInterfaceTuple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductModelInterfaceTuple input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IfaceName == input.IfaceName ||
                    (this.IfaceName != null &&
                    this.IfaceName.Equals(input.IfaceName))
                ) && 
                (
                    this.ProductModelName == input.ProductModelName ||
                    (this.ProductModelName != null &&
                    this.ProductModelName.Equals(input.ProductModelName))
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
                if (this.IfaceName != null)
                    hashCode = hashCode * 59 + this.IfaceName.GetHashCode();
                if (this.ProductModelName != null)
                    hashCode = hashCode * 59 + this.ProductModelName.GetHashCode();
                return hashCode;
            }
        }

    }

}

