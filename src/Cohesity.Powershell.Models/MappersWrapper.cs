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
    /// MappersWrapper
    /// </summary>
    [DataContract]
    public partial class MappersWrapper :  IEquatable<MappersWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappersWrapper" /> class.
        /// </summary>
        /// <param name="mappers">mappers.</param>
        public MappersWrapper(List<MapperInfo> mappers = default(List<MapperInfo>))
        {
            this.Mappers = mappers;
        }
        
        /// <summary>
        /// Gets or Sets Mappers
        /// </summary>
        [DataMember(Name="mappers", EmitDefaultValue=false)]
        public List<MapperInfo> Mappers { get; set; }

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
            return this.Equals(input as MappersWrapper);
        }

        /// <summary>
        /// Returns true if MappersWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of MappersWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MappersWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mappers == input.Mappers ||
                    this.Mappers != null &&
                    this.Mappers.SequenceEqual(input.Mappers)
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
                if (this.Mappers != null)
                    hashCode = hashCode * 59 + this.Mappers.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

