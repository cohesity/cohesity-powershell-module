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
    /// Specifies the fields to store data of a given type. Specify data in the appropriate field for the current data type.
    /// </summary>
    [DataContract]
    public partial class ValueData :  IEquatable<ValueData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueData" /> class.
        /// </summary>
        /// <param name="oneofData">oneofData.</param>
        public ValueData(Object oneofData = default(Object))
        {
            this.OneofData = oneofData;
        }
        
        /// <summary>
        /// Gets or Sets OneofData
        /// </summary>
        [DataMember(Name="OneofData", EmitDefaultValue=false)]
        public Object OneofData { get; set; }

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
            return this.Equals(input as ValueData);
        }

        /// <summary>
        /// Returns true if ValueData instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OneofData == input.OneofData ||
                    (this.OneofData != null &&
                    this.OneofData.Equals(input.OneofData))
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
                if (this.OneofData != null)
                    hashCode = hashCode * 59 + this.OneofData.GetHashCode();
                return hashCode;
            }
        }

    }

}

