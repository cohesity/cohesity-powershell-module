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
    /// Specifies information about file formats produced by a mapo reduce instance.
    /// </summary>
    [DataContract]
    public partial class MapReduceFileFormats :  IEquatable<MapReduceFileFormats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceFileFormats" /> class.
        /// </summary>
        /// <param name="supportedFormats">Specifies the list of formats supported with integer enum mapping to file format..</param>
        public MapReduceFileFormats(List<string> supportedFormats = default(List<string>))
        {
            this.SupportedFormats = supportedFormats;
        }
        
        /// <summary>
        /// Specifies the list of formats supported with integer enum mapping to file format.
        /// </summary>
        /// <value>Specifies the list of formats supported with integer enum mapping to file format.</value>
        [DataMember(Name="supportedFormats", EmitDefaultValue=false)]
        public List<string> SupportedFormats { get; set; }

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
            return this.Equals(input as MapReduceFileFormats);
        }

        /// <summary>
        /// Returns true if MapReduceFileFormats instances are equal
        /// </summary>
        /// <param name="input">Instance of MapReduceFileFormats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapReduceFileFormats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportedFormats == input.SupportedFormats ||
                    this.SupportedFormats != null &&
                    this.SupportedFormats.Equals(input.SupportedFormats)
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
                if (this.SupportedFormats != null)
                    hashCode = hashCode * 59 + this.SupportedFormats.GetHashCode();
                return hashCode;
            }
        }

    }

}

