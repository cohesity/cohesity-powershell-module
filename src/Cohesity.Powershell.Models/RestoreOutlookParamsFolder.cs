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
    /// This will be set in case of partial mailbox recovery.
    /// </summary>
    [DataContract]
    public partial class RestoreOutlookParamsFolder :  IEquatable<RestoreOutlookParamsFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOutlookParamsFolder" /> class.
        /// </summary>
        /// <param name="folderId">The Unique ID of the folder..</param>
        /// <param name="folderKey">The Unique key of the folder..</param>
        /// <param name="isEntireFolderRequired">Specify if the entire folder is to be restored..</param>
        /// <param name="itemIdVec">If is_entire_folder_required is set to false, user will then specify which particular items are to be restored..</param>
        public RestoreOutlookParamsFolder(string folderId = default(string), long? folderKey = default(long?), bool? isEntireFolderRequired = default(bool?), List<string> itemIdVec = default(List<string>))
        {
            this.FolderId = folderId;
            this.FolderKey = folderKey;
            this.IsEntireFolderRequired = isEntireFolderRequired;
            this.ItemIdVec = itemIdVec;
            this.FolderId = folderId;
            this.FolderKey = folderKey;
            this.IsEntireFolderRequired = isEntireFolderRequired;
            this.ItemIdVec = itemIdVec;
        }
        
        /// <summary>
        /// The Unique ID of the folder.
        /// </summary>
        /// <value>The Unique ID of the folder.</value>
        [DataMember(Name="folderId", EmitDefaultValue=true)]
        public string FolderId { get; set; }

        /// <summary>
        /// The Unique key of the folder.
        /// </summary>
        /// <value>The Unique key of the folder.</value>
        [DataMember(Name="folderKey", EmitDefaultValue=true)]
        public long? FolderKey { get; set; }

        /// <summary>
        /// Specify if the entire folder is to be restored.
        /// </summary>
        /// <value>Specify if the entire folder is to be restored.</value>
        [DataMember(Name="isEntireFolderRequired", EmitDefaultValue=true)]
        public bool? IsEntireFolderRequired { get; set; }

        /// <summary>
        /// If is_entire_folder_required is set to false, user will then specify which particular items are to be restored.
        /// </summary>
        /// <value>If is_entire_folder_required is set to false, user will then specify which particular items are to be restored.</value>
        [DataMember(Name="itemIdVec", EmitDefaultValue=true)]
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
            return this.Equals(input as RestoreOutlookParamsFolder);
        }

        /// <summary>
        /// Returns true if RestoreOutlookParamsFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOutlookParamsFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOutlookParamsFolder input)
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
                    this.FolderKey == input.FolderKey ||
                    (this.FolderKey != null &&
                    this.FolderKey.Equals(input.FolderKey))
                ) && 
                (
                    this.IsEntireFolderRequired == input.IsEntireFolderRequired ||
                    (this.IsEntireFolderRequired != null &&
                    this.IsEntireFolderRequired.Equals(input.IsEntireFolderRequired))
                ) && 
                (
                    this.ItemIdVec == input.ItemIdVec ||
                    this.ItemIdVec != null &&
                    input.ItemIdVec != null &&
                    this.ItemIdVec.SequenceEqual(input.ItemIdVec)
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
                if (this.FolderKey != null)
                    hashCode = hashCode * 59 + this.FolderKey.GetHashCode();
                if (this.IsEntireFolderRequired != null)
                    hashCode = hashCode * 59 + this.IsEntireFolderRequired.GetHashCode();
                if (this.ItemIdVec != null)
                    hashCode = hashCode * 59 + this.ItemIdVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

