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
    /// FileExtensionFilter
    /// </summary>
    [DataContract]
    public partial class FileExtensionFilter :  IEquatable<FileExtensionFilter>
    {

        /// <summary>
        /// The mode applied to the list of file extensions
        /// </summary>
        /// <value>The mode applied to the list of file extensions</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileExtensionFilter" /> class.
        /// </summary>
        /// <param name="fileExtensionsList">The list of file extensions to apply.</param>
        /// <param name="isEnabled">If set, it enables the file extension filter.</param>
        /// <param name="mode">The mode applied to the list of file extensions.</param>
        public FileExtensionFilter(List<string> fileExtensionsList = default(List<string>), bool? isEnabled = default(bool?), string mode = default(string))
        {
            this.FileExtensionsList = fileExtensionsList;
            this.IsEnabled = isEnabled;
            this.Mode = mode;
        }
        
        /// <summary>
        /// The list of file extensions to apply
        /// </summary>
        /// <value>The list of file extensions to apply</value>
        [DataMember(Name="fileExtensionsList", EmitDefaultValue=false)]
        public List<string> FileExtensionsList { get; set; }

        /// <summary>
        /// If set, it enables the file extension filter
        /// </summary>
        /// <value>If set, it enables the file extension filter</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }


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
            return this.Equals(input as FileExtensionFilter);
        }

        /// <summary>
        /// Returns true if FileExtensionFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of FileExtensionFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileExtensionFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileExtensionsList == input.FileExtensionsList ||
                    this.FileExtensionsList != null &&
                    this.FileExtensionsList.SequenceEqual(input.FileExtensionsList)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.FileExtensionsList != null)
                    hashCode = hashCode * 59 + this.FileExtensionsList.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

