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
    /// AnalyseJarResult
    /// </summary>
    [DataContract]
    public partial class AnalyseJarResult :  IEquatable<AnalyseJarResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyseJarResult" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="mappers">Name of all mapper classes found in jar file..</param>
        /// <param name="reducers">Name of all reducers classes found in jar file..</param>
        public AnalyseJarResult(ErrorProto error = default(ErrorProto), List<string> mappers = default(List<string>), List<string> reducers = default(List<string>))
        {
            this.Mappers = mappers;
            this.Reducers = reducers;
            this.Error = error;
            this.Mappers = mappers;
            this.Reducers = reducers;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Name of all mapper classes found in jar file.
        /// </summary>
        /// <value>Name of all mapper classes found in jar file.</value>
        [DataMember(Name="mappers", EmitDefaultValue=true)]
        public List<string> Mappers { get; set; }

        /// <summary>
        /// Name of all reducers classes found in jar file.
        /// </summary>
        /// <value>Name of all reducers classes found in jar file.</value>
        [DataMember(Name="reducers", EmitDefaultValue=true)]
        public List<string> Reducers { get; set; }

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
                    input.Mappers != null &&
                    this.Mappers.SequenceEqual(input.Mappers)
                ) && 
                (
                    this.Reducers == input.Reducers ||
                    this.Reducers != null &&
                    input.Reducers != null &&
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

