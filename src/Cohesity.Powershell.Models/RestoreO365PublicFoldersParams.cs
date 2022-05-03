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
    /// RestoreO365PublicFoldersParams
    /// </summary>
    [DataContract]
    public partial class RestoreO365PublicFoldersParams :  IEquatable<RestoreO365PublicFoldersParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365PublicFoldersParams" /> class.
        /// </summary>
        /// <param name="rootPublicFolderVec">In a RestoreJob , user will provide the list of Root Public Folders to be restored. Provision is there for restoring full and partial Public Folder recovery..</param>
        /// <param name="targetFolderPath">targetFolderPath.</param>
        /// <param name="targetRootPublicFolder">targetRootPublicFolder.</param>
        public RestoreO365PublicFoldersParams(List<RestoreO365PublicFoldersParamsRootPublicFolder> rootPublicFolderVec = default(List<RestoreO365PublicFoldersParamsRootPublicFolder>), string targetFolderPath = default(string), EntityProto targetRootPublicFolder = default(EntityProto))
        {
            this.RootPublicFolderVec = rootPublicFolderVec;
            this.TargetFolderPath = targetFolderPath;
            this.TargetRootPublicFolder = targetRootPublicFolder;
        }
        
        /// <summary>
        /// In a RestoreJob , user will provide the list of Root Public Folders to be restored. Provision is there for restoring full and partial Public Folder recovery.
        /// </summary>
        /// <value>In a RestoreJob , user will provide the list of Root Public Folders to be restored. Provision is there for restoring full and partial Public Folder recovery.</value>
        [DataMember(Name="rootPublicFolderVec", EmitDefaultValue=false)]
        public List<RestoreO365PublicFoldersParamsRootPublicFolder> RootPublicFolderVec { get; set; }

        /// <summary>
        /// Gets or Sets TargetFolderPath
        /// </summary>
        [DataMember(Name="targetFolderPath", EmitDefaultValue=false)]
        public string TargetFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets TargetRootPublicFolder
        /// </summary>
        [DataMember(Name="targetRootPublicFolder", EmitDefaultValue=false)]
        public EntityProto TargetRootPublicFolder { get; set; }

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
            return this.Equals(input as RestoreO365PublicFoldersParams);
        }

        /// <summary>
        /// Returns true if RestoreO365PublicFoldersParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365PublicFoldersParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365PublicFoldersParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RootPublicFolderVec == input.RootPublicFolderVec ||
                    this.RootPublicFolderVec != null &&
                    this.RootPublicFolderVec.Equals(input.RootPublicFolderVec)
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
                if (this.RootPublicFolderVec != null)
                    hashCode = hashCode * 59 + this.RootPublicFolderVec.GetHashCode();
                if (this.TargetFolderPath != null)
                    hashCode = hashCode * 59 + this.TargetFolderPath.GetHashCode();
                if (this.TargetRootPublicFolder != null)
                    hashCode = hashCode * 59 + this.TargetRootPublicFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}

