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
    /// Specifies information needed for recovering Drive(s) &amp; Drive items.
    /// </summary>
    [DataContract]
    public partial class OneDriveRestoreParameters :  IEquatable<OneDriveRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveRestoreParameters" /> class.
        /// </summary>
        /// <param name="driveOwnerList">Specifies the list of Drive owners which are to be restored along with the details of their drives..</param>
        /// <param name="restoreToOriginalDrive">Specifies whether the objects are to be restored to the original drive..</param>
        /// <param name="targetDriveId">Specifies the Drive Id of the target user where the OneDrive items are to be recovered..</param>
        /// <param name="targetFolderPath">Specifies the target folder path within the drive where recovery has to be done..</param>
        /// <param name="targetUser">targetUser.</param>
        public OneDriveRestoreParameters(List<OneDriveOwner> driveOwnerList = default(List<OneDriveOwner>), bool? restoreToOriginalDrive = default(bool?), string targetDriveId = default(string), string targetFolderPath = default(string), ProtectionSource targetUser = default(ProtectionSource))
        {
            this.DriveOwnerList = driveOwnerList;
            this.RestoreToOriginalDrive = restoreToOriginalDrive;
            this.TargetDriveId = targetDriveId;
            this.TargetFolderPath = targetFolderPath;
            this.TargetUser = targetUser;
        }
        
        /// <summary>
        /// Specifies the list of Drive owners which are to be restored along with the details of their drives.
        /// </summary>
        /// <value>Specifies the list of Drive owners which are to be restored along with the details of their drives.</value>
        [DataMember(Name="driveOwnerList", EmitDefaultValue=false)]
        public List<OneDriveOwner> DriveOwnerList { get; set; }

        /// <summary>
        /// Specifies whether the objects are to be restored to the original drive.
        /// </summary>
        /// <value>Specifies whether the objects are to be restored to the original drive.</value>
        [DataMember(Name="restoreToOriginalDrive", EmitDefaultValue=false)]
        public bool? RestoreToOriginalDrive { get; set; }

        /// <summary>
        /// Specifies the Drive Id of the target user where the OneDrive items are to be recovered.
        /// </summary>
        /// <value>Specifies the Drive Id of the target user where the OneDrive items are to be recovered.</value>
        [DataMember(Name="targetDriveId", EmitDefaultValue=false)]
        public string TargetDriveId { get; set; }

        /// <summary>
        /// Specifies the target folder path within the drive where recovery has to be done.
        /// </summary>
        /// <value>Specifies the target folder path within the drive where recovery has to be done.</value>
        [DataMember(Name="targetFolderPath", EmitDefaultValue=false)]
        public string TargetFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets TargetUser
        /// </summary>
        [DataMember(Name="targetUser", EmitDefaultValue=false)]
        public ProtectionSource TargetUser { get; set; }

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
            return this.Equals(input as OneDriveRestoreParameters);
        }

        /// <summary>
        /// Returns true if OneDriveRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of OneDriveRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneDriveRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveOwnerList == input.DriveOwnerList ||
                    this.DriveOwnerList != null &&
                    this.DriveOwnerList.Equals(input.DriveOwnerList)
                ) && 
                (
                    this.RestoreToOriginalDrive == input.RestoreToOriginalDrive ||
                    (this.RestoreToOriginalDrive != null &&
                    this.RestoreToOriginalDrive.Equals(input.RestoreToOriginalDrive))
                ) && 
                (
                    this.TargetDriveId == input.TargetDriveId ||
                    (this.TargetDriveId != null &&
                    this.TargetDriveId.Equals(input.TargetDriveId))
                ) && 
                (
                    this.TargetFolderPath == input.TargetFolderPath ||
                    (this.TargetFolderPath != null &&
                    this.TargetFolderPath.Equals(input.TargetFolderPath))
                ) && 
                (
                    this.TargetUser == input.TargetUser ||
                    (this.TargetUser != null &&
                    this.TargetUser.Equals(input.TargetUser))
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
                if (this.DriveOwnerList != null)
                    hashCode = hashCode * 59 + this.DriveOwnerList.GetHashCode();
                if (this.RestoreToOriginalDrive != null)
                    hashCode = hashCode * 59 + this.RestoreToOriginalDrive.GetHashCode();
                if (this.TargetDriveId != null)
                    hashCode = hashCode * 59 + this.TargetDriveId.GetHashCode();
                if (this.TargetFolderPath != null)
                    hashCode = hashCode * 59 + this.TargetFolderPath.GetHashCode();
                if (this.TargetUser != null)
                    hashCode = hashCode * 59 + this.TargetUser.GetHashCode();
                return hashCode;
            }
        }

    }

}

