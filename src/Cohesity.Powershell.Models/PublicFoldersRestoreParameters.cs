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
    /// Specifies information needed for recovering O365 Public Folders in O365Publicfolders environment.
    /// </summary>
    [DataContract]
    public partial class PublicFoldersRestoreParameters :  IEquatable<PublicFoldersRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicFoldersRestoreParameters" /> class.
        /// </summary>
        /// <param name="rootPublicFolderList">Specifies the list of Public Folders to be restored..</param>
        /// <param name="targetFolderPath">Specifies the target folder path to restore the Public Folders..</param>
        /// <param name="targetRootPublicFolder">targetRootPublicFolder.</param>
        public PublicFoldersRestoreParameters(List<RootPublicFolder> rootPublicFolderList = default(List<RootPublicFolder>), string targetFolderPath = default(string), ProtectionSource targetRootPublicFolder = default(ProtectionSource))
        {
            this.RootPublicFolderList = rootPublicFolderList;
            this.TargetFolderPath = targetFolderPath;
            this.RootPublicFolderList = rootPublicFolderList;
            this.TargetFolderPath = targetFolderPath;
            this.TargetRootPublicFolder = targetRootPublicFolder;
        }
        
        /// <summary>
        /// Specifies the list of Public Folders to be restored.
        /// </summary>
        /// <value>Specifies the list of Public Folders to be restored.</value>
        [DataMember(Name="rootPublicFolderList", EmitDefaultValue=true)]
        public List<RootPublicFolder> RootPublicFolderList { get; set; }

        /// <summary>
        /// Specifies the target folder path to restore the Public Folders.
        /// </summary>
        /// <value>Specifies the target folder path to restore the Public Folders.</value>
        [DataMember(Name="targetFolderPath", EmitDefaultValue=true)]
        public string TargetFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets TargetRootPublicFolder
        /// </summary>
        [DataMember(Name="targetRootPublicFolder", EmitDefaultValue=false)]
        public ProtectionSource TargetRootPublicFolder { get; set; }

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
            return this.Equals(input as PublicFoldersRestoreParameters);
        }

        /// <summary>
        /// Returns true if PublicFoldersRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicFoldersRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicFoldersRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RootPublicFolderList == input.RootPublicFolderList ||
                    this.RootPublicFolderList != null &&
                    input.RootPublicFolderList != null &&
                    this.RootPublicFolderList.SequenceEqual(input.RootPublicFolderList)
                ) && 
                (
                    this.TargetFolderPath == input.TargetFolderPath ||
                    (this.TargetFolderPath != null &&
                    this.TargetFolderPath.Equals(input.TargetFolderPath))
                ) && 
                (
                    this.TargetRootPublicFolder == input.TargetRootPublicFolder ||
                    (this.TargetRootPublicFolder != null &&
                    this.TargetRootPublicFolder.Equals(input.TargetRootPublicFolder))
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
                if (this.RootPublicFolderList != null)
                    hashCode = hashCode * 59 + this.RootPublicFolderList.GetHashCode();
                if (this.TargetFolderPath != null)
                    hashCode = hashCode * 59 + this.TargetFolderPath.GetHashCode();
                if (this.TargetRootPublicFolder != null)
                    hashCode = hashCode * 59 + this.TargetRootPublicFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}

