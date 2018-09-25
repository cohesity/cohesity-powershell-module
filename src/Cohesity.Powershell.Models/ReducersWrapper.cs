// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// ReducersWrapper
    /// </summary>
    [DataContract]
    public partial class ReducersWrapper :  IEquatable<ReducersWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReducersWrapper" /> class.
        /// </summary>
        /// <param name="reducers">reducers.</param>
        public ReducersWrapper(List<ReducerInfo> reducers = default(List<ReducerInfo>))
        {
            this.Reducers = reducers;
        }
        
        /// <summary>
        /// Gets or Sets Reducers
        /// </summary>
        [DataMember(Name="reducers", EmitDefaultValue=false)]
        public List<ReducerInfo> Reducers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as ReducersWrapper);
        }

        /// <summary>
        /// Returns true if ReducersWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of ReducersWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReducersWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reducers == input.Reducers ||
                    this.Reducers != null &&
                    this.Reducers.SequenceEqual(input.Reducers)
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
                if (this.Reducers != null)
                    hashCode = hashCode * 59 + this.Reducers.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

