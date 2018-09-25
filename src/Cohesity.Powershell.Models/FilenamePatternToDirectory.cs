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
    /// Specifies a filename pattern and the directory path where to keep files matching that pattern.
    /// </summary>
    [DataContract]
    public partial class FilenamePatternToDirectory :  IEquatable<FilenamePatternToDirectory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilenamePatternToDirectory" /> class.
        /// </summary>
        /// <param name="directory">Specifies the directory where to keep the files matching the pattern..</param>
        /// <param name="filenamePattern">Specifies a pattern to be matched with filenames. This can be a regex expression..</param>
        public FilenamePatternToDirectory(string directory = default(string), string filenamePattern = default(string))
        {
            this.Directory = directory;
            this.FilenamePattern = filenamePattern;
        }
        
        /// <summary>
        /// Specifies the directory where to keep the files matching the pattern.
        /// </summary>
        /// <value>Specifies the directory where to keep the files matching the pattern.</value>
        [DataMember(Name="directory", EmitDefaultValue=false)]
        public string Directory { get; set; }

        /// <summary>
        /// Specifies a pattern to be matched with filenames. This can be a regex expression.
        /// </summary>
        /// <value>Specifies a pattern to be matched with filenames. This can be a regex expression.</value>
        [DataMember(Name="filenamePattern", EmitDefaultValue=false)]
        public string FilenamePattern { get; set; }

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
            return this.Equals(input as FilenamePatternToDirectory);
        }

        /// <summary>
        /// Returns true if FilenamePatternToDirectory instances are equal
        /// </summary>
        /// <param name="input">Instance of FilenamePatternToDirectory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilenamePatternToDirectory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Directory == input.Directory ||
                    (this.Directory != null &&
                    this.Directory.Equals(input.Directory))
                ) && 
                (
                    this.FilenamePattern == input.FilenamePattern ||
                    (this.FilenamePattern != null &&
                    this.FilenamePattern.Equals(input.FilenamePattern))
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
                if (this.Directory != null)
                    hashCode = hashCode * 59 + this.Directory.GetHashCode();
                if (this.FilenamePattern != null)
                    hashCode = hashCode * 59 + this.FilenamePattern.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

