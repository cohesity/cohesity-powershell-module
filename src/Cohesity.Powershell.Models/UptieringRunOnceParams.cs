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
    /// UptieringRunOnceParams
    /// </summary>
    [DataContract]
    public partial class UptieringRunOnceParams :  IEquatable<UptieringRunOnceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UptieringRunOnceParams" /> class.
        /// </summary>
        /// <param name="uptierPath">Ignore the uptiering policy and uptier the directory pointed by the &#39;uptier_path&#39;. If path is &#39;/&#39;, then uptier everything..</param>
        public UptieringRunOnceParams(string uptierPath = default(string))
        {
            this.UptierPath = uptierPath;
            this.UptierPath = uptierPath;
        }
        
        /// <summary>
        /// Ignore the uptiering policy and uptier the directory pointed by the &#39;uptier_path&#39;. If path is &#39;/&#39;, then uptier everything.
        /// </summary>
        /// <value>Ignore the uptiering policy and uptier the directory pointed by the &#39;uptier_path&#39;. If path is &#39;/&#39;, then uptier everything.</value>
        [DataMember(Name="uptierPath", EmitDefaultValue=true)]
        public string UptierPath { get; set; }

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
            return this.Equals(input as UptieringRunOnceParams);
        }

        /// <summary>
        /// Returns true if UptieringRunOnceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UptieringRunOnceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UptieringRunOnceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UptierPath == input.UptierPath ||
                    (this.UptierPath != null &&
                    this.UptierPath.Equals(input.UptierPath))
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
                if (this.UptierPath != null)
                    hashCode = hashCode * 59 + this.UptierPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

