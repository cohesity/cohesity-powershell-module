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
    /// Specify the list of paths to be excluded.
    /// </summary>
    [DataContract]
    public partial class FileRestoreExclusion :  IEquatable<FileRestoreExclusion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileRestoreExclusion" /> class.
        /// </summary>
        /// <param name="fileRestoreExclusions">Vector of string that contains the paths to be excluded from the restores..</param>
        public FileRestoreExclusion(List<string> fileRestoreExclusions = default(List<string>))
        {
            this.FileRestoreExclusions = fileRestoreExclusions;
            this.FileRestoreExclusions = fileRestoreExclusions;
        }
        
        /// <summary>
        /// Vector of string that contains the paths to be excluded from the restores.
        /// </summary>
        /// <value>Vector of string that contains the paths to be excluded from the restores.</value>
        [DataMember(Name="fileRestoreExclusions", EmitDefaultValue=true)]
        public List<string> FileRestoreExclusions { get; set; }

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
            return this.Equals(input as FileRestoreExclusion);
        }

        /// <summary>
        /// Returns true if FileRestoreExclusion instances are equal
        /// </summary>
        /// <param name="input">Instance of FileRestoreExclusion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileRestoreExclusion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileRestoreExclusions == input.FileRestoreExclusions ||
                    this.FileRestoreExclusions != null &&
                    input.FileRestoreExclusions != null &&
                    this.FileRestoreExclusions.SequenceEqual(input.FileRestoreExclusions)
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
                if (this.FileRestoreExclusions != null)
                    hashCode = hashCode * 59 + this.FileRestoreExclusions.GetHashCode();
                return hashCode;
            }
        }

    }

}

