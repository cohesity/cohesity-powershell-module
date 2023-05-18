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
    /// AppProperty message encapsulates properties that are same across all run instances of an app.
    /// </summary>
    [DataContract]
    public partial class MapReduceInfoAppProperty :  IEquatable<MapReduceInfoAppProperty>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceInfoAppProperty" /> class.
        /// </summary>
        /// <param name="csvHeader">csv_header should be tab separated column names..</param>
        public MapReduceInfoAppProperty(string csvHeader = default(string))
        {
            this.CsvHeader = csvHeader;
            this.CsvHeader = csvHeader;
        }
        
        /// <summary>
        /// csv_header should be tab separated column names.
        /// </summary>
        /// <value>csv_header should be tab separated column names.</value>
        [DataMember(Name="csvHeader", EmitDefaultValue=true)]
        public string CsvHeader { get; set; }

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
            return this.Equals(input as MapReduceInfoAppProperty);
        }

        /// <summary>
        /// Returns true if MapReduceInfoAppProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceInfoAppProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceInfoAppProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CsvHeader == input.CsvHeader ||
                    (this.CsvHeader != null &&
                    this.CsvHeader.Equals(input.CsvHeader))
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
                if (this.CsvHeader != null)
                    hashCode = hashCode * 59 + this.CsvHeader.GetHashCode();
                return hashCode;
            }
        }

    }

}

