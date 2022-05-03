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
    /// This will be set in case of partial drive recovery.
    /// </summary>
    [DataContract]
    public partial class RestoreOneDriveParamsDriveItem :  IEquatable<RestoreOneDriveParamsDriveItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOneDriveParamsDriveItem" /> class.
        /// </summary>
        /// <param name="driveItemPath">The path of the drive item relative to root..</param>
        /// <param name="id">The unique identifier of the item within the Drive..</param>
        /// <param name="isFileItem">Specify if the item is a file or not..</param>
        public RestoreOneDriveParamsDriveItem(string driveItemPath = default(string), string id = default(string), bool? isFileItem = default(bool?))
        {
            this.DriveItemPath = driveItemPath;
            this.Id = id;
            this.IsFileItem = isFileItem;
        }
        
        /// <summary>
        /// The path of the drive item relative to root.
        /// </summary>
        /// <value>The path of the drive item relative to root.</value>
        [DataMember(Name="driveItemPath", EmitDefaultValue=false)]
        public string DriveItemPath { get; set; }

        /// <summary>
        /// The unique identifier of the item within the Drive.
        /// </summary>
        /// <value>The unique identifier of the item within the Drive.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Specify if the item is a file or not.
        /// </summary>
        /// <value>Specify if the item is a file or not.</value>
        [DataMember(Name="isFileItem", EmitDefaultValue=false)]
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
            return this.Equals(input as RestoreOneDriveParamsDriveItem);
        }

        /// <summary>
        /// Returns true if RestoreOneDriveParamsDriveItem instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOneDriveParamsDriveItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOneDriveParamsDriveItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveItemPath == input.DriveItemPath ||
                    (this.DriveItemPath != null &&
                    this.DriveItemPath.Equals(input.DriveItemPath))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.DriveItemPath != null)
                    hashCode = hashCode * 59 + this.DriveItemPath.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsFileItem != null)
                    hashCode = hashCode * 59 + this.IsFileItem.GetHashCode();
                return hashCode;
            }
        }

    }

}

