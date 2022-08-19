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
    /// Specifies the O365 PublicFolder details.
    /// </summary>
    [DataContract]
    public partial class PublicFolder :  IEquatable<PublicFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicFolder" /> class.
        /// </summary>
        /// <param name="folderId">Specifies the unique ID of the folder..</param>
        /// <param name="publicFolderItemIdList">Specifies the PublicFolder items within the folder to be restored incase the user wishes not to restore the entire folder..</param>
        /// <param name="restoreEntireFolder">Specifies whether the entire folder is to be restored..</param>
        public PublicFolder(string folderId = default(string), List<string> publicFolderItemIdList = default(List<string>), bool? restoreEntireFolder = default(bool?))
        {
            this.FolderId = folderId;
            this.PublicFolderItemIdList = publicFolderItemIdList;
            this.RestoreEntireFolder = restoreEntireFolder;
            this.FolderId = folderId;
            this.PublicFolderItemIdList = publicFolderItemIdList;
            this.RestoreEntireFolder = restoreEntireFolder;
        }
        
        /// <summary>
        /// Specifies the unique ID of the folder.
        /// </summary>
        /// <value>Specifies the unique ID of the folder.</value>
        [DataMember(Name="folderId", EmitDefaultValue=true)]
        public string FolderId { get; set; }

        /// <summary>
        /// Specifies the PublicFolder items within the folder to be restored incase the user wishes not to restore the entire folder.
        /// </summary>
        /// <value>Specifies the PublicFolder items within the folder to be restored incase the user wishes not to restore the entire folder.</value>
        [DataMember(Name="publicFolderItemIdList", EmitDefaultValue=true)]
        public List<string> PublicFolderItemIdList { get; set; }

        /// <summary>
        /// Specifies whether the entire folder is to be restored.
        /// </summary>
        /// <value>Specifies whether the entire folder is to be restored.</value>
        [DataMember(Name="restoreEntireFolder", EmitDefaultValue=true)]
        public bool? RestoreEntireFolder { get; set; }

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
            return this.Equals(input as PublicFolder);
        }

        /// <summary>
        /// Returns true if PublicFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
                ) && 
                (
                    this.PublicFolderItemIdList == input.PublicFolderItemIdList ||
                    this.PublicFolderItemIdList != null &&
                    input.PublicFolderItemIdList != null &&
                    this.PublicFolderItemIdList.Equals(input.PublicFolderItemIdList)
                ) && 
                (
                    this.RestoreEntireFolder == input.RestoreEntireFolder ||
                    (this.RestoreEntireFolder != null &&
                    this.RestoreEntireFolder.Equals(input.RestoreEntireFolder))
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
                if (this.FolderId != null)
                    hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                if (this.PublicFolderItemIdList != null)
                    hashCode = hashCode * 59 + this.PublicFolderItemIdList.GetHashCode();
                if (this.RestoreEntireFolder != null)
                    hashCode = hashCode * 59 + this.RestoreEntireFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}

