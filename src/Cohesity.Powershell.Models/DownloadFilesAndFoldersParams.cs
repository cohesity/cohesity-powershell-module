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
    /// DownloadFilesAndFoldersParams holds the information to create a task for downloading list of files or folders
    /// </summary>
    [DataContract]
    public partial class DownloadFilesAndFoldersParams :  IEquatable<DownloadFilesAndFoldersParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFilesAndFoldersParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadFilesAndFoldersParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFilesAndFoldersParams" /> class.
        /// </summary>
        /// <param name="filesAndFoldersInfo">Specifies the absolute paths for list of files and folders to download..</param>
        /// <param name="name">Specifies the name of the Download Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="sourceObjectInfo">sourceObjectInfo.</param>
        public DownloadFilesAndFoldersParams(List<FilesAndFoldersInfo> filesAndFoldersInfo = default(List<FilesAndFoldersInfo>), string name = default(string), RestoreObjectDetails sourceObjectInfo = default(RestoreObjectDetails))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DownloadFilesAndFoldersParams and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.FilesAndFoldersInfo = filesAndFoldersInfo;
            this.SourceObjectInfo = sourceObjectInfo;
        }
        
        /// <summary>
        /// Specifies the absolute paths for list of files and folders to download.
        /// </summary>
        /// <value>Specifies the absolute paths for list of files and folders to download.</value>
        [DataMember(Name="filesAndFoldersInfo", EmitDefaultValue=false)]
        public List<FilesAndFoldersInfo> FilesAndFoldersInfo { get; set; }

        /// <summary>
        /// Specifies the name of the Download Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Download Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SourceObjectInfo
        /// </summary>
        [DataMember(Name="sourceObjectInfo", EmitDefaultValue=false)]
        public RestoreObjectDetails SourceObjectInfo { get; set; }

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
            return this.Equals(input as DownloadFilesAndFoldersParams);
        }

        /// <summary>
        /// Returns true if DownloadFilesAndFoldersParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadFilesAndFoldersParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadFilesAndFoldersParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilesAndFoldersInfo == input.FilesAndFoldersInfo ||
                    this.FilesAndFoldersInfo != null &&
                    this.FilesAndFoldersInfo.Equals(input.FilesAndFoldersInfo)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SourceObjectInfo == input.SourceObjectInfo ||
                    (this.SourceObjectInfo != null &&
                    this.SourceObjectInfo.Equals(input.SourceObjectInfo))
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
                if (this.FilesAndFoldersInfo != null)
                    hashCode = hashCode * 59 + this.FilesAndFoldersInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceObjectInfo != null)
                    hashCode = hashCode * 59 + this.SourceObjectInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

