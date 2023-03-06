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
    /// Information required for Icebox when downloading files from an archived entity. This proto is specifically just for the current temporary solution for downloading a single from an archive, where we let icebox download the file for us. In the future once the new Yoda APIs for downloading files from archive stub views are ready, we will just discard this proto and make field 20 reserved.
    /// </summary>
    [DataContract]
    public partial class RetrieveArchiveTaskStateProtoDownloadFilesInfo :  IEquatable<RetrieveArchiveTaskStateProtoDownloadFilesInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveArchiveTaskStateProtoDownloadFilesInfo" /> class.
        /// </summary>
        /// <param name="filePathVec">The file paths to be retrieved from the archive. For example, if the file paths are /foo/bar and /foo2/bar and target_dir_path is \&quot;downloaded_files\&quot;. The retrieved files will have the full path structure maintained in target_dir_path such as downloaded_files/foo/bar and /downloaded_files/foo2/bar..</param>
        /// <param name="magnetoInstanceId">magnetoInstanceId.</param>
        /// <param name="objectId">objectId.</param>
        /// <param name="skipRestoreInStubView">Ask Icebox to only create the stub view and skip restoring files in the stub view..</param>
        /// <param name="targetDirPath">Path to the directory under which the downloaded files will be placed..</param>
        /// <param name="targetViewName">Target view name where the downloaded files will be placed..</param>
        public RetrieveArchiveTaskStateProtoDownloadFilesInfo(List<string> filePathVec = default(List<string>), MagnetoInstanceId magnetoInstanceId = default(MagnetoInstanceId), MagnetoObjectId objectId = default(MagnetoObjectId), bool? skipRestoreInStubView = default(bool?), string targetDirPath = default(string), string targetViewName = default(string))
        {
            this.FilePathVec = filePathVec;
            this.SkipRestoreInStubView = skipRestoreInStubView;
            this.TargetDirPath = targetDirPath;
            this.TargetViewName = targetViewName;
            this.FilePathVec = filePathVec;
            this.MagnetoInstanceId = magnetoInstanceId;
            this.ObjectId = objectId;
            this.SkipRestoreInStubView = skipRestoreInStubView;
            this.TargetDirPath = targetDirPath;
            this.TargetViewName = targetViewName;
        }
        
        /// <summary>
        /// The file paths to be retrieved from the archive. For example, if the file paths are /foo/bar and /foo2/bar and target_dir_path is \&quot;downloaded_files\&quot;. The retrieved files will have the full path structure maintained in target_dir_path such as downloaded_files/foo/bar and /downloaded_files/foo2/bar.
        /// </summary>
        /// <value>The file paths to be retrieved from the archive. For example, if the file paths are /foo/bar and /foo2/bar and target_dir_path is \&quot;downloaded_files\&quot;. The retrieved files will have the full path structure maintained in target_dir_path such as downloaded_files/foo/bar and /downloaded_files/foo2/bar.</value>
        [DataMember(Name="filePathVec", EmitDefaultValue=true)]
        public List<string> FilePathVec { get; set; }

        /// <summary>
        /// Gets or Sets MagnetoInstanceId
        /// </summary>
        [DataMember(Name="magnetoInstanceId", EmitDefaultValue=false)]
        public MagnetoInstanceId MagnetoInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public MagnetoObjectId ObjectId { get; set; }

        /// <summary>
        /// Ask Icebox to only create the stub view and skip restoring files in the stub view.
        /// </summary>
        /// <value>Ask Icebox to only create the stub view and skip restoring files in the stub view.</value>
        [DataMember(Name="skipRestoreInStubView", EmitDefaultValue=true)]
        public bool? SkipRestoreInStubView { get; set; }

        /// <summary>
        /// Path to the directory under which the downloaded files will be placed.
        /// </summary>
        /// <value>Path to the directory under which the downloaded files will be placed.</value>
        [DataMember(Name="targetDirPath", EmitDefaultValue=true)]
        public string TargetDirPath { get; set; }

        /// <summary>
        /// Target view name where the downloaded files will be placed.
        /// </summary>
        /// <value>Target view name where the downloaded files will be placed.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=true)]
        public string TargetViewName { get; set; }

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
            return this.Equals(input as RetrieveArchiveTaskStateProtoDownloadFilesInfo);
        }

        /// <summary>
        /// Returns true if RetrieveArchiveTaskStateProtoDownloadFilesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveArchiveTaskStateProtoDownloadFilesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveArchiveTaskStateProtoDownloadFilesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilePathVec == input.FilePathVec ||
                    this.FilePathVec != null &&
                    input.FilePathVec != null &&
                    this.FilePathVec.SequenceEqual(input.FilePathVec)
                ) && 
                (
                    this.MagnetoInstanceId == input.MagnetoInstanceId ||
                    (this.MagnetoInstanceId != null &&
                    this.MagnetoInstanceId.Equals(input.MagnetoInstanceId))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.SkipRestoreInStubView == input.SkipRestoreInStubView ||
                    (this.SkipRestoreInStubView != null &&
                    this.SkipRestoreInStubView.Equals(input.SkipRestoreInStubView))
                ) && 
                (
                    this.TargetDirPath == input.TargetDirPath ||
                    (this.TargetDirPath != null &&
                    this.TargetDirPath.Equals(input.TargetDirPath))
                ) && 
                (
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
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
                if (this.FilePathVec != null)
                    hashCode = hashCode * 59 + this.FilePathVec.GetHashCode();
                if (this.MagnetoInstanceId != null)
                    hashCode = hashCode * 59 + this.MagnetoInstanceId.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.SkipRestoreInStubView != null)
                    hashCode = hashCode * 59 + this.SkipRestoreInStubView.GetHashCode();
                if (this.TargetDirPath != null)
                    hashCode = hashCode * 59 + this.TargetDirPath.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

