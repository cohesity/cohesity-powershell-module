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
    /// AnalyseJarResult
    /// </summary>
    [DataContract]
    public partial class AnalyseJarResult :  IEquatable<AnalyseJarResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyseJarResult" /> class.
        /// </summary>
        /// <param name="error">Status code of http rpc..</param>
        /// <param name="mappers">mappers.</param>
        /// <param name="reducers">reducers.</param>
        public AnalyseJarResult(ErrorProto error = default(ErrorProto), List<string> mappers = default(List<string>), List<string> reducers = default(List<string>))
        {
            this.Error = error;
            this.Mappers = mappers;
            this.Reducers = reducers;
        }
        
        /// <summary>
        /// Status code of http rpc.
        /// </summary>
        /// <value>Status code of http rpc.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Gets or Sets Mappers
        /// </summary>
        [DataMember(Name="mappers", EmitDefaultValue=false)]
        public List<string> Mappers { get; set; }

        /// <summary>
        /// Gets or Sets Reducers
        /// </summary>
        [DataMember(Name="reducers", EmitDefaultValue=false)]
        public List<string> Reducers { get; set; }

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
            return this.Equals(input as AnalyseJarResult);
        }

        /// <summary>
        /// Returns true if AnalyseJarResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyseJarResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyseJarResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Mappers == input.Mappers ||
                    this.Mappers != null &&
                    this.Mappers.SequenceEqual(input.Mappers)
                ) && 
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Mappers != null)
                    hashCode = hashCode * 59 + this.Mappers.GetHashCode();
                if (this.Reducers != null)
                    hashCode = hashCode * 59 + this.Reducers.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

