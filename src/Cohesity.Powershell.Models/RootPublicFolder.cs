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
    /// Specifies the RootPublicFolder with restore details to support full or partial recovery.
    /// </summary>
    [DataContract]
    public partial class RootPublicFolder :  IEquatable<RootPublicFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootPublicFolder" /> class.
        /// </summary>
        /// <param name="publicFolderList">Specifies the list of Public Folders to be restored incase user wishes not to restore entire RootPublicFolder..</param>
        /// <param name="restoreEntireRootPublicFolder">Specifies whether the entire RootPublicFolder is to be restored..</param>
        /// <param name="rootPublicFolderObject">rootPublicFolderObject.</param>
        public RootPublicFolder(List<PublicFolder> publicFolderList = default(List<PublicFolder>), bool? restoreEntireRootPublicFolder = default(bool?), RestoreObjectDetails rootPublicFolderObject = default(RestoreObjectDetails))
        {
            this.PublicFolderList = publicFolderList;
            this.RestoreEntireRootPublicFolder = restoreEntireRootPublicFolder;
            this.PublicFolderList = publicFolderList;
            this.RestoreEntireRootPublicFolder = restoreEntireRootPublicFolder;
            this.RootPublicFolderObject = rootPublicFolderObject;
        }
        
        /// <summary>
        /// Specifies the list of Public Folders to be restored incase user wishes not to restore entire RootPublicFolder.
        /// </summary>
        /// <value>Specifies the list of Public Folders to be restored incase user wishes not to restore entire RootPublicFolder.</value>
        [DataMember(Name="publicFolderList", EmitDefaultValue=true)]
        public List<PublicFolder> PublicFolderList { get; set; }

        /// <summary>
        /// Specifies whether the entire RootPublicFolder is to be restored.
        /// </summary>
        /// <value>Specifies whether the entire RootPublicFolder is to be restored.</value>
        [DataMember(Name="restoreEntireRootPublicFolder", EmitDefaultValue=true)]
        public bool? RestoreEntireRootPublicFolder { get; set; }

        /// <summary>
        /// Gets or Sets RootPublicFolderObject
        /// </summary>
        [DataMember(Name="rootPublicFolderObject", EmitDefaultValue=false)]
        public RestoreObjectDetails RootPublicFolderObject { get; set; }

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
            return this.Equals(input as RootPublicFolder);
        }

        /// <summary>
        /// Returns true if RootPublicFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of RootPublicFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RootPublicFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicFolderList == input.PublicFolderList ||
                    this.PublicFolderList != null &&
                    input.PublicFolderList != null &&
                    this.PublicFolderList.SequenceEqual(input.PublicFolderList)
                ) && 
                (
                    this.RestoreEntireRootPublicFolder == input.RestoreEntireRootPublicFolder ||
                    (this.RestoreEntireRootPublicFolder != null &&
                    this.RestoreEntireRootPublicFolder.Equals(input.RestoreEntireRootPublicFolder))
                ) && 
                (
                    this.RootPublicFolderObject == input.RootPublicFolderObject ||
                    (this.RootPublicFolderObject != null &&
                    this.RootPublicFolderObject.Equals(input.RootPublicFolderObject))
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
                if (this.PublicFolderList != null)
                    hashCode = hashCode * 59 + this.PublicFolderList.GetHashCode();
                if (this.RestoreEntireRootPublicFolder != null)
                    hashCode = hashCode * 59 + this.RestoreEntireRootPublicFolder.GetHashCode();
                if (this.RootPublicFolderObject != null)
                    hashCode = hashCode * 59 + this.RootPublicFolderObject.GetHashCode();
                return hashCode;
            }
        }

    }

}

