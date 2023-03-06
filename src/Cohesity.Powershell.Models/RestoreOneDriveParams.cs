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
    /// RestoreOneDriveParams
    /// </summary>
    [DataContract]
    public partial class RestoreOneDriveParams :  IEquatable<RestoreOneDriveParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOneDriveParams" /> class.
        /// </summary>
        /// <param name="driveOwnerVec">The list of users/groups whose drives are being restored..</param>
        /// <param name="restoreToOriginal">Whether or not all drive items are restored to original location..</param>
        /// <param name="targetDriveId">The id of the drive in which items will be restored..</param>
        /// <param name="targetFolderPath">All drives part of various users listed in drive_owner_vec will be restored to the drive belonging to target_user having id target_drive_id. Let&#39;s say drive_owner_vec is A and B; drive_vec of A and B is 111 and 222 respectively; target_user is C; target_drive_id is 333. The final folder-hierarchy after restore job is finished will look like this : C:333: {target_folder_path}/| |A/111/{whatever is there in restore_item_vec of 111} |B/222/{whatever is there in restore_item_vec of 222}.</param>
        /// <param name="targetUser">targetUser.</param>
        public RestoreOneDriveParams(List<RestoreOneDriveParamsDriveOwner> driveOwnerVec = default(List<RestoreOneDriveParamsDriveOwner>), bool? restoreToOriginal = default(bool?), string targetDriveId = default(string), string targetFolderPath = default(string), EntityProto targetUser = default(EntityProto))
        {
            this.DriveOwnerVec = driveOwnerVec;
            this.RestoreToOriginal = restoreToOriginal;
            this.TargetDriveId = targetDriveId;
            this.TargetFolderPath = targetFolderPath;
            this.DriveOwnerVec = driveOwnerVec;
            this.RestoreToOriginal = restoreToOriginal;
            this.TargetDriveId = targetDriveId;
            this.TargetFolderPath = targetFolderPath;
            this.TargetUser = targetUser;
        }
        
        /// <summary>
        /// The list of users/groups whose drives are being restored.
        /// </summary>
        /// <value>The list of users/groups whose drives are being restored.</value>
        [DataMember(Name="driveOwnerVec", EmitDefaultValue=true)]
        public List<RestoreOneDriveParamsDriveOwner> DriveOwnerVec { get; set; }

        /// <summary>
        /// Whether or not all drive items are restored to original location.
        /// </summary>
        /// <value>Whether or not all drive items are restored to original location.</value>
        [DataMember(Name="restoreToOriginal", EmitDefaultValue=true)]
        public bool? RestoreToOriginal { get; set; }

        /// <summary>
        /// The id of the drive in which items will be restored.
        /// </summary>
        /// <value>The id of the drive in which items will be restored.</value>
        [DataMember(Name="targetDriveId", EmitDefaultValue=true)]
        public string TargetDriveId { get; set; }

        /// <summary>
        /// All drives part of various users listed in drive_owner_vec will be restored to the drive belonging to target_user having id target_drive_id. Let&#39;s say drive_owner_vec is A and B; drive_vec of A and B is 111 and 222 respectively; target_user is C; target_drive_id is 333. The final folder-hierarchy after restore job is finished will look like this : C:333: {target_folder_path}/| |A/111/{whatever is there in restore_item_vec of 111} |B/222/{whatever is there in restore_item_vec of 222}
        /// </summary>
        /// <value>All drives part of various users listed in drive_owner_vec will be restored to the drive belonging to target_user having id target_drive_id. Let&#39;s say drive_owner_vec is A and B; drive_vec of A and B is 111 and 222 respectively; target_user is C; target_drive_id is 333. The final folder-hierarchy after restore job is finished will look like this : C:333: {target_folder_path}/| |A/111/{whatever is there in restore_item_vec of 111} |B/222/{whatever is there in restore_item_vec of 222}</value>
        [DataMember(Name="targetFolderPath", EmitDefaultValue=true)]
        public string TargetFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets TargetUser
        /// </summary>
        [DataMember(Name="targetUser", EmitDefaultValue=false)]
        public EntityProto TargetUser { get; set; }

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
            return this.Equals(input as RestoreOneDriveParams);
        }

        /// <summary>
        /// Returns true if RestoreOneDriveParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOneDriveParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOneDriveParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveOwnerVec == input.DriveOwnerVec ||
                    this.DriveOwnerVec != null &&
                    input.DriveOwnerVec != null &&
                    this.DriveOwnerVec.SequenceEqual(input.DriveOwnerVec)
                ) && 
                (
                    this.RestoreToOriginal == input.RestoreToOriginal ||
                    (this.RestoreToOriginal != null &&
                    this.RestoreToOriginal.Equals(input.RestoreToOriginal))
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
                if (this.DriveOwnerVec != null)
                    hashCode = hashCode * 59 + this.DriveOwnerVec.GetHashCode();
                if (this.RestoreToOriginal != null)
                    hashCode = hashCode * 59 + this.RestoreToOriginal.GetHashCode();
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

