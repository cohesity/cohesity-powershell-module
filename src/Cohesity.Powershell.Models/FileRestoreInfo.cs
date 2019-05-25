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
    /// Specifies restore information of a file or a folder.
    /// </summary>
    [DataContract]
    public partial class FileRestoreInfo :  IEquatable<FileRestoreInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileRestoreInfo" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="filename">Specifies the path of the file/directory..</param>
        /// <param name="filesystemVolume">filesystemVolume.</param>
        /// <param name="isFolder">Specifies whether the file path is a folder..</param>
        public FileRestoreInfo(RequestError error = default(RequestError), string filename = default(string), FilesystemVolume filesystemVolume = default(FilesystemVolume), bool? isFolder = default(bool?))
        {
            this.Filename = filename;
            this.IsFolder = isFolder;
            this.Error = error;
            this.Filename = filename;
            this.FilesystemVolume = filesystemVolume;
            this.IsFolder = isFolder;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public RequestError Error { get; set; }

        /// <summary>
        /// Specifies the path of the file/directory.
        /// </summary>
        /// <value>Specifies the path of the file/directory.</value>
        [DataMember(Name="filename", EmitDefaultValue=true)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets FilesystemVolume
        /// </summary>
        [DataMember(Name="filesystemVolume", EmitDefaultValue=false)]
        public FilesystemVolume FilesystemVolume { get; set; }

        /// <summary>
        /// Specifies whether the file path is a folder.
        /// </summary>
        /// <value>Specifies whether the file path is a folder.</value>
        [DataMember(Name="isFolder", EmitDefaultValue=true)]
        public bool? IsFolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileRestoreInfo {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  FilesystemVolume: ").Append(FilesystemVolume).Append("\n");
            sb.Append("  IsFolder: ").Append(IsFolder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as FileRestoreInfo);
        }

        /// <summary>
        /// Returns true if FileRestoreInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FileRestoreInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileRestoreInfo input)
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
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.FilesystemVolume == input.FilesystemVolume ||
                    (this.FilesystemVolume != null &&
                    this.FilesystemVolume.Equals(input.FilesystemVolume))
                ) && 
                (
                    this.IsFolder == input.IsFolder ||
                    (this.IsFolder != null &&
                    this.IsFolder.Equals(input.IsFolder))
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
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.FilesystemVolume != null)
                    hashCode = hashCode * 59 + this.FilesystemVolume.GetHashCode();
                if (this.IsFolder != null)
                    hashCode = hashCode * 59 + this.IsFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}
