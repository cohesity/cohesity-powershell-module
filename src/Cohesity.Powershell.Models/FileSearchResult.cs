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
    /// Specifies details about the found file or folder.
    /// </summary>
    [DataContract]
    public partial class FileSearchResult :  IEquatable<FileSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchResult" /> class.
        /// </summary>
        /// <param name="documentType">Specifies the inferred document type..</param>
        /// <param name="fileVersions">Specifies the different snapshot versions of a file or folder that were captured at different times..</param>
        /// <param name="filename">Specifies the name of the found file or folder..</param>
        /// <param name="isFolder">Specifies if the found item is a folder. If true, the found item is a folder..</param>
        /// <param name="jobId">Specifies the Job id for the Protection Job that is currently associated with object that contains the backed up file or folder. If the file or folder was backed up on current Cohesity Cluster, this field contains the id for the Job that captured the object that contains the file or folder. If the file or folder was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object that contains the file or folder is now associated with new Inactive Job, and this field contains the id of the new Inactive Job..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="registeredSourceId">Specifies the id of the top-level registered source (such as a vCenter Server) where the source object that contains the the file or folder is stored..</param>
        /// <param name="sourceId">Specifies the source id of the object that contains the file or folder..</param>
        /// <param name="viewBoxId">Specifies the id of the Domain (View Box) where the source object that contains the file or folder is stored..</param>
        public FileSearchResult(string documentType = default(string), List<FileVersion> fileVersions = default(List<FileVersion>), string filename = default(string), bool? isFolder = default(bool?), long? jobId = default(long?), UniqueGlobalId2 jobUid = default(UniqueGlobalId2), long? registeredSourceId = default(long?), long? sourceId = default(long?), long? viewBoxId = default(long?))
        {
            this.DocumentType = documentType;
            this.FileVersions = fileVersions;
            this.Filename = filename;
            this.IsFolder = isFolder;
            this.JobId = jobId;
            this.JobUid = jobUid;
            this.RegisteredSourceId = registeredSourceId;
            this.SourceId = sourceId;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// Specifies the inferred document type.
        /// </summary>
        /// <value>Specifies the inferred document type.</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// Specifies the different snapshot versions of a file or folder that were captured at different times.
        /// </summary>
        /// <value>Specifies the different snapshot versions of a file or folder that were captured at different times.</value>
        [DataMember(Name="fileVersions", EmitDefaultValue=false)]
        public List<FileVersion> FileVersions { get; set; }

        /// <summary>
        /// Specifies the name of the found file or folder.
        /// </summary>
        /// <value>Specifies the name of the found file or folder.</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Specifies if the found item is a folder. If true, the found item is a folder.
        /// </summary>
        /// <value>Specifies if the found item is a folder. If true, the found item is a folder.</value>
        [DataMember(Name="isFolder", EmitDefaultValue=false)]
        public bool? IsFolder { get; set; }

        /// <summary>
        /// Specifies the Job id for the Protection Job that is currently associated with object that contains the backed up file or folder. If the file or folder was backed up on current Cohesity Cluster, this field contains the id for the Job that captured the object that contains the file or folder. If the file or folder was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object that contains the file or folder is now associated with new Inactive Job, and this field contains the id of the new Inactive Job.
        /// </summary>
        /// <value>Specifies the Job id for the Protection Job that is currently associated with object that contains the backed up file or folder. If the file or folder was backed up on current Cohesity Cluster, this field contains the id for the Job that captured the object that contains the file or folder. If the file or folder was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object that contains the file or folder is now associated with new Inactive Job, and this field contains the id of the new Inactive Job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniqueGlobalId2 JobUid { get; set; }

        /// <summary>
        /// Specifies the id of the top-level registered source (such as a vCenter Server) where the source object that contains the the file or folder is stored.
        /// </summary>
        /// <value>Specifies the id of the top-level registered source (such as a vCenter Server) where the source object that contains the the file or folder is stored.</value>
        [DataMember(Name="registeredSourceId", EmitDefaultValue=false)]
        public long? RegisteredSourceId { get; set; }

        /// <summary>
        /// Specifies the source id of the object that contains the file or folder.
        /// </summary>
        /// <value>Specifies the source id of the object that contains the file or folder.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Specifies the id of the Domain (View Box) where the source object that contains the file or folder is stored.
        /// </summary>
        /// <value>Specifies the id of the Domain (View Box) where the source object that contains the file or folder is stored.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

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
            return this.Equals(input as FileSearchResult);
        }

        /// <summary>
        /// Returns true if FileSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FileSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.FileVersions == input.FileVersions ||
                    this.FileVersions != null &&
                    this.FileVersions.SequenceEqual(input.FileVersions)
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.IsFolder == input.IsFolder ||
                    (this.IsFolder != null &&
                    this.IsFolder.Equals(input.IsFolder))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.RegisteredSourceId == input.RegisteredSourceId ||
                    (this.RegisteredSourceId != null &&
                    this.RegisteredSourceId.Equals(input.RegisteredSourceId))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
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
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.FileVersions != null)
                    hashCode = hashCode * 59 + this.FileVersions.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.IsFolder != null)
                    hashCode = hashCode * 59 + this.IsFolder.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.RegisteredSourceId != null)
                    hashCode = hashCode * 59 + this.RegisteredSourceId.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

