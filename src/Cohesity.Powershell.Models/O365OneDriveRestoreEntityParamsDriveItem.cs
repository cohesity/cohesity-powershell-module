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
    /// O365OneDriveRestoreEntityParamsDriveItem
    /// </summary>
    [DataContract]
    public partial class O365OneDriveRestoreEntityParamsDriveItem :  IEquatable<O365OneDriveRestoreEntityParamsDriveItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365OneDriveRestoreEntityParamsDriveItem" /> class.
        /// </summary>
        /// <param name="driveItemId">The unique identifier of the item within the Drive..</param>
        /// <param name="driveItemPath">The path of the drive item relative to root..</param>
        /// <param name="isFileItem">Specify if the item is a file or not..</param>
        public O365OneDriveRestoreEntityParamsDriveItem(string driveItemId = default(string), string driveItemPath = default(string), bool? isFileItem = default(bool?))
        {
            this.DriveItemId = driveItemId;
            this.DriveItemPath = driveItemPath;
            this.IsFileItem = isFileItem;
            this.DriveItemId = driveItemId;
            this.DriveItemPath = driveItemPath;
            this.IsFileItem = isFileItem;
        }
        
        /// <summary>
        /// The unique identifier of the item within the Drive.
        /// </summary>
        /// <value>The unique identifier of the item within the Drive.</value>
        [DataMember(Name="driveItemId", EmitDefaultValue=true)]
        public string DriveItemId { get; set; }

        /// <summary>
        /// The path of the drive item relative to root.
        /// </summary>
        /// <value>The path of the drive item relative to root.</value>
        [DataMember(Name="driveItemPath", EmitDefaultValue=true)]
        public string DriveItemPath { get; set; }

        /// <summary>
        /// Specify if the item is a file or not.
        /// </summary>
        /// <value>Specify if the item is a file or not.</value>
        [DataMember(Name="isFileItem", EmitDefaultValue=true)]
        public bool? IsFileItem { get; set; }

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
            return this.Equals(input as O365OneDriveRestoreEntityParamsDriveItem);
        }

        /// <summary>
        /// Returns true if O365OneDriveRestoreEntityParamsDriveItem instances are equal
        /// </summary>
        /// <param name="input">Instance of O365OneDriveRestoreEntityParamsDriveItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365OneDriveRestoreEntityParamsDriveItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveItemId == input.DriveItemId ||
                    (this.DriveItemId != null &&
                    this.DriveItemId.Equals(input.DriveItemId))
                ) && 
                (
                    this.DriveItemPath == input.DriveItemPath ||
                    (this.DriveItemPath != null &&
                    this.DriveItemPath.Equals(input.DriveItemPath))
                ) && 
                (
                    this.IsFileItem == input.IsFileItem ||
                    (this.IsFileItem != null &&
                    this.IsFileItem.Equals(input.IsFileItem))
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
                if (this.DriveItemId != null)
                    hashCode = hashCode * 59 + this.DriveItemId.GetHashCode();
                if (this.DriveItemPath != null)
                    hashCode = hashCode * 59 + this.DriveItemPath.GetHashCode();
                if (this.IsFileItem != null)
                    hashCode = hashCode * 59 + this.IsFileItem.GetHashCode();
                return hashCode;
            }
        }

    }

}

