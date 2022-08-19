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
    /// RestoreO365PublicFoldersParamsRootPublicFolder
    /// </summary>
    [DataContract]
    public partial class RestoreO365PublicFoldersParamsRootPublicFolder :  IEquatable<RestoreO365PublicFoldersParamsRootPublicFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365PublicFoldersParamsRootPublicFolder" /> class.
        /// </summary>
        /// <param name="folderVec">If is_entire_folder_required is set to false, user will then specify which particular sub-folders are to be restored..</param>
        /// <param name="isEntireRootFolderRequired">Specify if the entire Root Public Folder including the sub-folders is to be restored..</param>
        /// <param name="_object">_object.</param>
        public RestoreO365PublicFoldersParamsRootPublicFolder(List<RestoreO365PublicFoldersParamsPublicFolder> folderVec = default(List<RestoreO365PublicFoldersParamsPublicFolder>), bool? isEntireRootFolderRequired = default(bool?), RestoreObject _object = default(RestoreObject))
        {
            this.FolderVec = folderVec;
            this.IsEntireRootFolderRequired = isEntireRootFolderRequired;
            this.FolderVec = folderVec;
            this.IsEntireRootFolderRequired = isEntireRootFolderRequired;
            this.Object = _object;
        }
        
        /// <summary>
        /// If is_entire_folder_required is set to false, user will then specify which particular sub-folders are to be restored.
        /// </summary>
        /// <value>If is_entire_folder_required is set to false, user will then specify which particular sub-folders are to be restored.</value>
        [DataMember(Name="folderVec", EmitDefaultValue=true)]
        public List<RestoreO365PublicFoldersParamsPublicFolder> FolderVec { get; set; }

        /// <summary>
        /// Specify if the entire Root Public Folder including the sub-folders is to be restored.
        /// </summary>
        /// <value>Specify if the entire Root Public Folder including the sub-folders is to be restored.</value>
        [DataMember(Name="isEntireRootFolderRequired", EmitDefaultValue=true)]
        public bool? IsEntireRootFolderRequired { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public RestoreObject Object { get; set; }

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
            return this.Equals(input as RestoreO365PublicFoldersParamsRootPublicFolder);
        }

        /// <summary>
        /// Returns true if RestoreO365PublicFoldersParamsRootPublicFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365PublicFoldersParamsRootPublicFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365PublicFoldersParamsRootPublicFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FolderVec == input.FolderVec ||
                    this.FolderVec != null &&
                    input.FolderVec != null &&
                    this.FolderVec.Equals(input.FolderVec)
                ) && 
                (
                    this.IsEntireRootFolderRequired == input.IsEntireRootFolderRequired ||
                    (this.IsEntireRootFolderRequired != null &&
                    this.IsEntireRootFolderRequired.Equals(input.IsEntireRootFolderRequired))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.FolderVec != null)
                    hashCode = hashCode * 59 + this.FolderVec.GetHashCode();
                if (this.IsEntireRootFolderRequired != null)
                    hashCode = hashCode * 59 + this.IsEntireRootFolderRequired.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                return hashCode;
            }
        }

    }

}

