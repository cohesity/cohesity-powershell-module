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
    /// This message encapsulates auxillary data for a MapReduce. One example of such data is saved patterns for Pattern finder app.
    /// </summary>
    [DataContract]
    public partial class MapReduceAuxData :  IEquatable<MapReduceAuxData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceAuxData" /> class.
        /// </summary>
        /// <param name="patternVec">Pattern auxiliary data for a MapReduce..</param>
        public MapReduceAuxData(List<Pattern> patternVec = default(List<Pattern>))
        {
            this.PatternVec = patternVec;
            this.PatternVec = patternVec;
        }
        
        /// <summary>
        /// Pattern auxiliary data for a MapReduce.
        /// </summary>
        /// <value>Pattern auxiliary data for a MapReduce.</value>
        [DataMember(Name="patternVec", EmitDefaultValue=true)]
        public List<Pattern> PatternVec { get; set; }

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
            return this.Equals(input as MapReduceAuxData);
        }

        /// <summary>
        /// Returns true if MapReduceAuxData instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceAuxData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceAuxData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PatternVec == input.PatternVec ||
                    this.PatternVec != null &&
                    input.PatternVec != null &&
                    this.PatternVec.SequenceEqual(input.PatternVec)
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
                if (this.PatternVec != null)
                    hashCode = hashCode * 59 + this.PatternVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

