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
    /// Specifies OneDrive details with the items which need to be restored.
    /// </summary>
    [DataContract]
    public partial class OneDriveInfo :  IEquatable<OneDriveInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveInfo" /> class.
        /// </summary>
        /// <param name="driveId">Specifies the Id of the Drive..</param>
        /// <param name="driveItemList">Specifies the Drive items such as files/folders..</param>
        /// <param name="restoreEntireDrive">Specifies whether entire drive is to be restored. This should be set to false if specific drive items are to be restored within &#39;DriveItemList&#39;..</param>
        public OneDriveInfo(string driveId = default(string), List<OneDriveItem> driveItemList = default(List<OneDriveItem>), bool? restoreEntireDrive = default(bool?))
        {
            this.DriveId = driveId;
            this.DriveItemList = driveItemList;
            this.RestoreEntireDrive = restoreEntireDrive;
            this.DriveId = driveId;
            this.DriveItemList = driveItemList;
            this.RestoreEntireDrive = restoreEntireDrive;
        }
        
        /// <summary>
        /// Specifies the Id of the Drive.
        /// </summary>
        /// <value>Specifies the Id of the Drive.</value>
        [DataMember(Name="driveId", EmitDefaultValue=true)]
        public string DriveId { get; set; }

        /// <summary>
        /// Specifies the Drive items such as files/folders.
        /// </summary>
        /// <value>Specifies the Drive items such as files/folders.</value>
        [DataMember(Name="driveItemList", EmitDefaultValue=true)]
        public List<OneDriveItem> DriveItemList { get; set; }

        /// <summary>
        /// Specifies whether entire drive is to be restored. This should be set to false if specific drive items are to be restored within &#39;DriveItemList&#39;.
        /// </summary>
        /// <value>Specifies whether entire drive is to be restored. This should be set to false if specific drive items are to be restored within &#39;DriveItemList&#39;.</value>
        [DataMember(Name="restoreEntireDrive", EmitDefaultValue=true)]
        public bool? RestoreEntireDrive { get; set; }

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
            return this.Equals(input as OneDriveInfo);
        }

        /// <summary>
        /// Returns true if OneDriveInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OneDriveInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneDriveInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveId == input.DriveId ||
                    (this.DriveId != null &&
                    this.DriveId.Equals(input.DriveId))
                ) && 
                (
                    this.DriveItemList == input.DriveItemList ||
                    this.DriveItemList != null &&
                    input.DriveItemList != null &&
                    this.DriveItemList.SequenceEqual(input.DriveItemList)
                ) && 
                (
                    this.RestoreEntireDrive == input.RestoreEntireDrive ||
                    (this.RestoreEntireDrive != null &&
                    this.RestoreEntireDrive.Equals(input.RestoreEntireDrive))
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
                if (this.DriveId != null)
                    hashCode = hashCode * 59 + this.DriveId.GetHashCode();
                if (this.DriveItemList != null)
                    hashCode = hashCode * 59 + this.DriveItemList.GetHashCode();
                if (this.RestoreEntireDrive != null)
                    hashCode = hashCode * 59 + this.RestoreEntireDrive.GetHashCode();
                return hashCode;
            }
        }

    }

}

