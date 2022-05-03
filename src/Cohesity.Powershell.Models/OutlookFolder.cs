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
    /// Specifies the Outlook folder details.
    /// </summary>
    [DataContract]
    public partial class OutlookFolder :  IEquatable<OutlookFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookFolder" /> class.
        /// </summary>
        /// <param name="folderId">Specifies the unique ID of the folder..</param>
        /// <param name="folderKey">Specifies the key unique within the mailbox of the folder..</param>
        /// <param name="outlookItemIdList">Specifies the outlook items within the folder to be restored incase the user wishes not to restore the entire folder..</param>
        /// <param name="restoreEntireFolder">Specifies whether the entire folder is to be restored..</param>
        public OutlookFolder(string folderId = default(string), long? folderKey = default(long?), List<string> outlookItemIdList = default(List<string>), bool? restoreEntireFolder = default(bool?))
        {
            this.FolderId = folderId;
            this.FolderKey = folderKey;
            this.OutlookItemIdList = outlookItemIdList;
            this.RestoreEntireFolder = restoreEntireFolder;
        }
        
        /// <summary>
        /// Specifies the unique ID of the folder.
        /// </summary>
        /// <value>Specifies the unique ID of the folder.</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// Specifies the key unique within the mailbox of the folder.
        /// </summary>
        /// <value>Specifies the key unique within the mailbox of the folder.</value>
        [DataMember(Name="folderKey", EmitDefaultValue=false)]
        public long? FolderKey { get; set; }

        /// <summary>
        /// Specifies the outlook items within the folder to be restored incase the user wishes not to restore the entire folder.
        /// </summary>
        /// <value>Specifies the outlook items within the folder to be restored incase the user wishes not to restore the entire folder.</value>
        [DataMember(Name="outlookItemIdList", EmitDefaultValue=false)]
        public List<string> OutlookItemIdList { get; set; }

        /// <summary>
        /// Specifies whether the entire folder is to be restored.
        /// </summary>
        /// <value>Specifies whether the entire folder is to be restored.</value>
        [DataMember(Name="restoreEntireFolder", EmitDefaultValue=false)]
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
            return this.Equals(input as OutlookFolder);
        }

        /// <summary>
        /// Returns true if OutlookFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of OutlookFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlookFolder input)
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
                    this.OutlookItemIdList == input.OutlookItemIdList ||
                    this.OutlookItemIdList != null &&
                    this.OutlookItemIdList.Equals(input.OutlookItemIdList)
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
                if (this.FolderKey != null)
                    hashCode = hashCode * 59 + this.FolderKey.GetHashCode();
                if (this.OutlookItemIdList != null)
                    hashCode = hashCode * 59 + this.OutlookItemIdList.GetHashCode();
                if (this.RestoreEntireFolder != null)
                    hashCode = hashCode * 59 + this.RestoreEntireFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}

