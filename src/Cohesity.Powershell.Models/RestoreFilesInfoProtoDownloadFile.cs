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
    /// RestoreFilesInfoProtoDownloadFile
    /// </summary>
    [DataContract]
    public partial class RestoreFilesInfoProtoDownloadFile :  IEquatable<RestoreFilesInfoProtoDownloadFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFilesInfoProtoDownloadFile" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="filePath">The path of the file to be downloaded..</param>
        /// <param name="identifier">The identifier used for uniquely identifying file_path to be download. This is optional and can be left empty. For teams chat download, identifier would be channel_id of teams channel whose chats can be downloaded with file_path..</param>
        /// <param name="progressMonitorPath">Progress monitor path for individual file download..</param>
        /// <param name="status">Status of download..</param>
        public RestoreFilesInfoProtoDownloadFile(ErrorProto error = default(ErrorProto), string filePath = default(string), string identifier = default(string), string progressMonitorPath = default(string), int? status = default(int?))
        {
            this.FilePath = filePath;
            this.Identifier = identifier;
            this.ProgressMonitorPath = progressMonitorPath;
            this.Status = status;
            this.Error = error;
            this.FilePath = filePath;
            this.Identifier = identifier;
            this.ProgressMonitorPath = progressMonitorPath;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// The path of the file to be downloaded.
        /// </summary>
        /// <value>The path of the file to be downloaded.</value>
        [DataMember(Name="filePath", EmitDefaultValue=true)]
        public string FilePath { get; set; }

        /// <summary>
        /// The identifier used for uniquely identifying file_path to be download. This is optional and can be left empty. For teams chat download, identifier would be channel_id of teams channel whose chats can be downloaded with file_path.
        /// </summary>
        /// <value>The identifier used for uniquely identifying file_path to be download. This is optional and can be left empty. For teams chat download, identifier would be channel_id of teams channel whose chats can be downloaded with file_path.</value>
        [DataMember(Name="identifier", EmitDefaultValue=true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Progress monitor path for individual file download.
        /// </summary>
        /// <value>Progress monitor path for individual file download.</value>
        [DataMember(Name="progressMonitorPath", EmitDefaultValue=true)]
        public string ProgressMonitorPath { get; set; }

        /// <summary>
        /// Status of download.
        /// </summary>
        /// <value>Status of download.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int? Status { get; set; }

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
            return this.Equals(input as RestoreFilesInfoProtoDownloadFile);
        }

        /// <summary>
        /// Returns true if RestoreFilesInfoProtoDownloadFile instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFilesInfoProtoDownloadFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFilesInfoProtoDownloadFile input)
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
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.ProgressMonitorPath == input.ProgressMonitorPath ||
                    (this.ProgressMonitorPath != null &&
                    this.ProgressMonitorPath.Equals(input.ProgressMonitorPath))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.ProgressMonitorPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorPath.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

