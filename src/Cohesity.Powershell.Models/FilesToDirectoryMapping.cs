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
    /// FilesToDirectoryMapping
    /// </summary>
    [DataContract]
    public partial class FilesToDirectoryMapping :  IEquatable<FilesToDirectoryMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesToDirectoryMapping" /> class.
        /// </summary>
        /// <param name="filePattern">Source file name. The file name can be a regex matching source files..</param>
        /// <param name="targetDirectory">Target directtory for the source file pattern..</param>
        public FilesToDirectoryMapping(string filePattern = default(string), string targetDirectory = default(string))
        {
            this.FilePattern = filePattern;
            this.TargetDirectory = targetDirectory;
            this.FilePattern = filePattern;
            this.TargetDirectory = targetDirectory;
        }
        
        /// <summary>
        /// Source file name. The file name can be a regex matching source files.
        /// </summary>
        /// <value>Source file name. The file name can be a regex matching source files.</value>
        [DataMember(Name="filePattern", EmitDefaultValue=true)]
        public string FilePattern { get; set; }

        /// <summary>
        /// Target directtory for the source file pattern.
        /// </summary>
        /// <value>Target directtory for the source file pattern.</value>
        [DataMember(Name="targetDirectory", EmitDefaultValue=true)]
        public string TargetDirectory { get; set; }

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
            return this.Equals(input as FilesToDirectoryMapping);
        }

        /// <summary>
        /// Returns true if FilesToDirectoryMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of FilesToDirectoryMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesToDirectoryMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilePattern == input.FilePattern ||
                    (this.FilePattern != null &&
                    this.FilePattern.Equals(input.FilePattern))
                ) && 
                (
                    this.TargetDirectory == input.TargetDirectory ||
                    (this.TargetDirectory != null &&
                    this.TargetDirectory.Equals(input.TargetDirectory))
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
                if (this.FilePattern != null)
                    hashCode = hashCode * 59 + this.FilePattern.GetHashCode();
                if (this.TargetDirectory != null)
                    hashCode = hashCode * 59 + this.TargetDirectory.GetHashCode();
                return hashCode;
            }
        }

    }

}

