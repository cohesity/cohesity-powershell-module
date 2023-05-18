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
    /// FilesAndFolders specifies the metadata information about the files and(or) folders for creating a download task.
    /// </summary>
    [DataContract]
    public partial class FilesAndFoldersInfo :  IEquatable<FilesAndFoldersInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesAndFoldersInfo" /> class.
        /// </summary>
        /// <param name="absolutePath">AbsolutePath specifies the absolute path of the specified file or folder..</param>
        /// <param name="isDirectory">IsDirectory specifies if specified object is a directory or not..</param>
        public FilesAndFoldersInfo(string absolutePath = default(string), bool? isDirectory = default(bool?))
        {
            this.AbsolutePath = absolutePath;
            this.IsDirectory = isDirectory;
            this.AbsolutePath = absolutePath;
            this.IsDirectory = isDirectory;
        }
        
        /// <summary>
        /// AbsolutePath specifies the absolute path of the specified file or folder.
        /// </summary>
        /// <value>AbsolutePath specifies the absolute path of the specified file or folder.</value>
        [DataMember(Name="absolutePath", EmitDefaultValue=true)]
        public string AbsolutePath { get; set; }

        /// <summary>
        /// IsDirectory specifies if specified object is a directory or not.
        /// </summary>
        /// <value>IsDirectory specifies if specified object is a directory or not.</value>
        [DataMember(Name="isDirectory", EmitDefaultValue=true)]
        public bool? IsDirectory { get; set; }

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
            return this.Equals(input as FilesAndFoldersInfo);
        }

        /// <summary>
        /// Returns true if FilesAndFoldersInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FilesAndFoldersInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesAndFoldersInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbsolutePath == input.AbsolutePath ||
                    (this.AbsolutePath != null &&
                    this.AbsolutePath.Equals(input.AbsolutePath))
                ) && 
                (
                    this.IsDirectory == input.IsDirectory ||
                    (this.IsDirectory != null &&
                    this.IsDirectory.Equals(input.IsDirectory))
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
                if (this.AbsolutePath != null)
                    hashCode = hashCode * 59 + this.AbsolutePath.GetHashCode();
                if (this.IsDirectory != null)
                    hashCode = hashCode * 59 + this.IsDirectory.GetHashCode();
                return hashCode;
            }
        }

    }

}

