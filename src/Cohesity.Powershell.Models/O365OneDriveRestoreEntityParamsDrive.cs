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
    /// O365OneDriveRestoreEntityParamsDrive
    /// </summary>
    [DataContract]
    public partial class O365OneDriveRestoreEntityParamsDrive :  IEquatable<O365OneDriveRestoreEntityParamsDrive>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365OneDriveRestoreEntityParamsDrive" /> class.
        /// </summary>
        /// <param name="driveType">Type of OneDrive drive being stored..</param>
        /// <param name="isEntireDriveRequired">Specify if the entire drive is to be restored. This field should be false if restore_item_vec size &gt; 0..</param>
        /// <param name="restoreDriveId">Id of the drive whose items are being restored..</param>
        /// <param name="restoreItemVec">List of drive paths that need to be restored. Used for partial drive recovery..</param>
        public O365OneDriveRestoreEntityParamsDrive(int? driveType = default(int?), bool? isEntireDriveRequired = default(bool?), string restoreDriveId = default(string), List<O365OneDriveRestoreEntityParamsDriveItem> restoreItemVec = default(List<O365OneDriveRestoreEntityParamsDriveItem>))
        {
            this.DriveType = driveType;
            this.IsEntireDriveRequired = isEntireDriveRequired;
            this.RestoreDriveId = restoreDriveId;
            this.RestoreItemVec = restoreItemVec;
            this.DriveType = driveType;
            this.IsEntireDriveRequired = isEntireDriveRequired;
            this.RestoreDriveId = restoreDriveId;
            this.RestoreItemVec = restoreItemVec;
        }
        
        /// <summary>
        /// Type of OneDrive drive being stored.
        /// </summary>
        /// <value>Type of OneDrive drive being stored.</value>
        [DataMember(Name="driveType", EmitDefaultValue=true)]
        public int? DriveType { get; set; }

        /// <summary>
        /// Specify if the entire drive is to be restored. This field should be false if restore_item_vec size &gt; 0.
        /// </summary>
        /// <value>Specify if the entire drive is to be restored. This field should be false if restore_item_vec size &gt; 0.</value>
        [DataMember(Name="isEntireDriveRequired", EmitDefaultValue=true)]
        public bool? IsEntireDriveRequired { get; set; }

        /// <summary>
        /// Id of the drive whose items are being restored.
        /// </summary>
        /// <value>Id of the drive whose items are being restored.</value>
        [DataMember(Name="restoreDriveId", EmitDefaultValue=true)]
        public string RestoreDriveId { get; set; }

        /// <summary>
        /// List of drive paths that need to be restored. Used for partial drive recovery.
        /// </summary>
        /// <value>List of drive paths that need to be restored. Used for partial drive recovery.</value>
        [DataMember(Name="restoreItemVec", EmitDefaultValue=true)]
        public List<O365OneDriveRestoreEntityParamsDriveItem> RestoreItemVec { get; set; }

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
            return this.Equals(input as O365OneDriveRestoreEntityParamsDrive);
        }

        /// <summary>
        /// Returns true if O365OneDriveRestoreEntityParamsDrive instances are equal
        /// </summary>
        /// <param name="input">Instance of O365OneDriveRestoreEntityParamsDrive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365OneDriveRestoreEntityParamsDrive input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveType == input.DriveType ||
                    (this.DriveType != null &&
                    this.DriveType.Equals(input.DriveType))
                ) && 
                (
                    this.IsEntireDriveRequired == input.IsEntireDriveRequired ||
                    (this.IsEntireDriveRequired != null &&
                    this.IsEntireDriveRequired.Equals(input.IsEntireDriveRequired))
                ) && 
                (
                    this.RestoreDriveId == input.RestoreDriveId ||
                    (this.RestoreDriveId != null &&
                    this.RestoreDriveId.Equals(input.RestoreDriveId))
                ) && 
                (
                    this.RestoreItemVec == input.RestoreItemVec ||
                    this.RestoreItemVec != null &&
                    input.RestoreItemVec != null &&
                    this.RestoreItemVec.SequenceEqual(input.RestoreItemVec)
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
                if (this.DriveType != null)
                    hashCode = hashCode * 59 + this.DriveType.GetHashCode();
                if (this.IsEntireDriveRequired != null)
                    hashCode = hashCode * 59 + this.IsEntireDriveRequired.GetHashCode();
                if (this.RestoreDriveId != null)
                    hashCode = hashCode * 59 + this.RestoreDriveId.GetHashCode();
                if (this.RestoreItemVec != null)
                    hashCode = hashCode * 59 + this.RestoreItemVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

