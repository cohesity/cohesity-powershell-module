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
    /// Specifies details about the found file or folder.
    /// </summary>
    [DataContract]
    public partial class FileSearchResult :  IEquatable<FileSearchResult>
    {
        /// <summary>
        /// Specifies the type of the file document such as KDirectory, kFile, etc.
        /// </summary>
        /// <value>Specifies the type of the file document such as KDirectory, kFile, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KDirectory for value: kDirectory
            /// </summary>
            [EnumMember(Value = "kDirectory")]
            KDirectory = 1,

            /// <summary>
            /// Enum KFile for value: kFile
            /// </summary>
            [EnumMember(Value = "kFile")]
            KFile = 2,

            /// <summary>
            /// Enum KEmail for value: kEmail
            /// </summary>
            [EnumMember(Value = "kEmail")]
            KEmail = 3,

            /// <summary>
            /// Enum KSymlink for value: kSymlink
            /// </summary>
            [EnumMember(Value = "kSymlink")]
            KSymlink = 4

        }

        /// <summary>
        /// Specifies the type of the file document such as KDirectory, kFile, etc.
        /// </summary>
        /// <value>Specifies the type of the file document such as KDirectory, kFile, etc.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchResult" /> class.
        /// </summary>
        /// <param name="adObjectMetaData">adObjectMetaData.</param>
        /// <param name="documentType">Specifies the inferred document type..</param>
        /// <param name="emailMetaData">emailMetaData.</param>
        /// <param name="fileVersions">Array of File Versions.  Specifies the different snapshot versions of a file or folder that were captured at different times..</param>
        /// <param name="filename">Specifies the name of the found file or folder..</param>
        /// <param name="isFolder">Specifies if the found item is a folder. If true, the found item is a folder..</param>
        /// <param name="jobId">Specifies the Job id for the Protection Job that is currently associated with object that contains the backed up file or folder. If the file or folder was backed up on current Cohesity Cluster, this field contains the id for the Job that captured the object that contains the file or folder. If the file or folder was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object that contains the file or folder is now associated with new Inactive Job, and this field contains the id of the new Inactive Job..</param>
        /// <param name="jobUid">Specifies the universal id of the Protection Job that backed up the object that contains the file or folder..</param>
        /// <param name="protectionSource">protectionSource.</param>
        /// <param name="registeredSourceId">Specifies the id of the top-level registered source (such as a vCenter Server) where the source object that contains the the file or folder is stored..</param>
        /// <param name="sourceId">Specifies the source id of the object that contains the file or folder..</param>
        /// <param name="type">Specifies the type of the file document such as KDirectory, kFile, etc..</param>
        /// <param name="viewBoxId">Specifies the id of the Domain (View Box) where the source object that contains the file or folder is stored..</param>
        public FileSearchResult(AdObjectMetaData adObjectMetaData = default(AdObjectMetaData), string documentType = default(string), EmailMetaData emailMetaData = default(EmailMetaData), List<FileVersion> fileVersions = default(List<FileVersion>), string filename = default(string), bool? isFolder = default(bool?), long? jobId = default(long?), UniversalId jobUid = default(UniversalId), ProtectionSource protectionSource = default(ProtectionSource), long? registeredSourceId = default(long?), long? sourceId = default(long?), TypeEnum? type = default(TypeEnum?), long? viewBoxId = default(long?))
        {
            this.DocumentType = documentType;
            this.FileVersions = fileVersions;
            this.Filename = filename;
            this.IsFolder = isFolder;
            this.JobId = jobId;
            this.JobUid = jobUid;
            this.RegisteredSourceId = registeredSourceId;
            this.SourceId = sourceId;
            this.Type = type;
            this.ViewBoxId = viewBoxId;
            this.AdObjectMetaData = adObjectMetaData;
            this.DocumentType = documentType;
            this.EmailMetaData = emailMetaData;
            this.FileVersions = fileVersions;
            this.Filename = filename;
            this.IsFolder = isFolder;
            this.JobId = jobId;
            this.JobUid = jobUid;
            this.ProtectionSource = protectionSource;
            this.RegisteredSourceId = registeredSourceId;
            this.SourceId = sourceId;
            this.Type = type;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// Gets or Sets AdObjectMetaData
        /// </summary>
        [DataMember(Name="adObjectMetaData", EmitDefaultValue=false)]
        public AdObjectMetaData AdObjectMetaData { get; set; }

        /// <summary>
        /// Specifies the inferred document type.
        /// </summary>
        /// <value>Specifies the inferred document type.</value>
        [DataMember(Name="documentType", EmitDefaultValue=true)]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets EmailMetaData
        /// </summary>
        [DataMember(Name="emailMetaData", EmitDefaultValue=false)]
        public EmailMetaData EmailMetaData { get; set; }

        /// <summary>
        /// Array of File Versions.  Specifies the different snapshot versions of a file or folder that were captured at different times.
        /// </summary>
        /// <value>Array of File Versions.  Specifies the different snapshot versions of a file or folder that were captured at different times.</value>
        [DataMember(Name="fileVersions", EmitDefaultValue=true)]
        public List<FileVersion> FileVersions { get; set; }

        /// <summary>
        /// Specifies the name of the found file or folder.
        /// </summary>
        /// <value>Specifies the name of the found file or folder.</value>
        [DataMember(Name="filename", EmitDefaultValue=true)]
        public string Filename { get; set; }

        /// <summary>
        /// Specifies if the found item is a folder. If true, the found item is a folder.
        /// </summary>
        /// <value>Specifies if the found item is a folder. If true, the found item is a folder.</value>
        [DataMember(Name="isFolder", EmitDefaultValue=true)]
        public bool? IsFolder { get; set; }

        /// <summary>
        /// Specifies the Job id for the Protection Job that is currently associated with object that contains the backed up file or folder. If the file or folder was backed up on current Cohesity Cluster, this field contains the id for the Job that captured the object that contains the file or folder. If the file or folder was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object that contains the file or folder is now associated with new Inactive Job, and this field contains the id of the new Inactive Job.
        /// </summary>
        /// <value>Specifies the Job id for the Protection Job that is currently associated with object that contains the backed up file or folder. If the file or folder was backed up on current Cohesity Cluster, this field contains the id for the Job that captured the object that contains the file or folder. If the file or folder was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object that contains the file or folder is now associated with new Inactive Job, and this field contains the id of the new Inactive Job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the universal id of the Protection Job that backed up the object that contains the file or folder.
        /// </summary>
        /// <value>Specifies the universal id of the Protection Job that backed up the object that contains the file or folder.</value>
        [DataMember(Name="jobUid", EmitDefaultValue=true)]
        public UniversalId JobUid { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionSource
        /// </summary>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Specifies the id of the top-level registered source (such as a vCenter Server) where the source object that contains the the file or folder is stored.
        /// </summary>
        /// <value>Specifies the id of the top-level registered source (such as a vCenter Server) where the source object that contains the the file or folder is stored.</value>
        [DataMember(Name="registeredSourceId", EmitDefaultValue=true)]
        public long? RegisteredSourceId { get; set; }

        /// <summary>
        /// Specifies the source id of the object that contains the file or folder.
        /// </summary>
        /// <value>Specifies the source id of the object that contains the file or folder.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=true)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Specifies the id of the Domain (View Box) where the source object that contains the file or folder is stored.
        /// </summary>
        /// <value>Specifies the id of the Domain (View Box) where the source object that contains the file or folder is stored.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

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
                    this.AdObjectMetaData == input.AdObjectMetaData ||
                    (this.AdObjectMetaData != null &&
                    this.AdObjectMetaData.Equals(input.AdObjectMetaData))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.EmailMetaData == input.EmailMetaData ||
                    (this.EmailMetaData != null &&
                    this.EmailMetaData.Equals(input.EmailMetaData))
                ) && 
                (
                    this.FileVersions == input.FileVersions ||
                    this.FileVersions != null &&
                    input.FileVersions != null &&
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
                    this.ProtectionSource == input.ProtectionSource ||
                    (this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource))
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.AdObjectMetaData != null)
                    hashCode = hashCode * 59 + this.AdObjectMetaData.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.EmailMetaData != null)
                    hashCode = hashCode * 59 + this.EmailMetaData.GetHashCode();
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
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.RegisteredSourceId != null)
                    hashCode = hashCode * 59 + this.RegisteredSourceId.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

    }

}

