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
    /// Proto to capture the restore details of a Public Folder
    /// </summary>
    [DataContract]
    public partial class RestoreO365PublicFoldersParamsPublicFolder :  IEquatable<RestoreO365PublicFoldersParamsPublicFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365PublicFoldersParamsPublicFolder" /> class.
        /// </summary>
        /// <param name="absoluteFolderPath">The absolute path of the folder..</param>
        /// <param name="folderId">The Unique ID of the folder..</param>
        /// <param name="isEntireFolderRequired">Specify if the entire Public Folder is to be restored..</param>
        /// <param name="itemIdVec">If is_entire_folder_required is set to false, users will then specify which particular items are to be restored..</param>
        public RestoreO365PublicFoldersParamsPublicFolder(string absoluteFolderPath = default(string), string folderId = default(string), bool? isEntireFolderRequired = default(bool?), List<string> itemIdVec = default(List<string>))
        {
            this.AbsoluteFolderPath = absoluteFolderPath;
            this.FolderId = folderId;
            this.IsEntireFolderRequired = isEntireFolderRequired;
            this.ItemIdVec = itemIdVec;
        }
        
        /// <summary>
        /// The absolute path of the folder.
        /// </summary>
        /// <value>The absolute path of the folder.</value>
        [DataMember(Name="absoluteFolderPath", EmitDefaultValue=false)]
        public string AbsoluteFolderPath { get; set; }

        /// <summary>
        /// The Unique ID of the folder.
        /// </summary>
        /// <value>The Unique ID of the folder.</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// Specify if the entire Public Folder is to be restored.
        /// </summary>
        /// <value>Specify if the entire Public Folder is to be restored.</value>
        [DataMember(Name="isEntireFolderRequired", EmitDefaultValue=false)]
        public bool? IsEntireFolderRequired { get; set; }

        /// <summary>
        /// If is_entire_folder_required is set to false, users will then specify which particular items are to be restored.
        /// </summary>
        /// <value>If is_entire_folder_required is set to false, users will then specify which particular items are to be restored.</value>
        [DataMember(Name="itemIdVec", EmitDefaultValue=false)]
        public List<string> ItemIdVec { get; set; }

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
            return this.Equals(input as RestoreO365PublicFoldersParamsPublicFolder);
        }

        /// <summary>
        /// Returns true if RestoreO365PublicFoldersParamsPublicFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365PublicFoldersParamsPublicFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365PublicFoldersParamsPublicFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbsoluteFolderPath == input.AbsoluteFolderPath ||
                    (this.AbsoluteFolderPath != null &&
                    this.AbsoluteFolderPath.Equals(input.AbsoluteFolderPath))
                ) && 
                (
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
                ) && 
                (
                    this.IsEntireFolderRequired == input.IsEntireFolderRequired ||
                    (this.IsEntireFolderRequired != null &&
                    this.IsEntireFolderRequired.Equals(input.IsEntireFolderRequired))
                ) && 
                (
                    this.ItemIdVec == input.ItemIdVec ||
                    this.ItemIdVec != null &&
                    this.ItemIdVec.Equals(input.ItemIdVec)
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
                if (this.AbsoluteFolderPath != null)
                    hashCode = hashCode * 59 + this.AbsoluteFolderPath.GetHashCode();
                if (this.FolderId != null)
                    hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                if (this.IsEntireFolderRequired != null)
                    hashCode = hashCode * 59 + this.IsEntireFolderRequired.GetHashCode();
                if (this.ItemIdVec != null)
                    hashCode = hashCode * 59 + this.ItemIdVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

