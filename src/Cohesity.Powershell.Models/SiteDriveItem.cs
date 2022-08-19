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
    /// Specifies details about a Site&#39;s Drive item.
    /// </summary>
    [DataContract]
    public partial class SiteDriveItem :  IEquatable<SiteDriveItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteDriveItem" /> class.
        /// </summary>
        /// <param name="isFileItem">Specifies whether the current item is a file or not..</param>
        /// <param name="itemId">Specifies the Id of the Drive item..</param>
        /// <param name="itemPath">Specifies the path of the Drive item within the drive..</param>
        public SiteDriveItem(bool? isFileItem = default(bool?), string itemId = default(string), string itemPath = default(string))
        {
            this.IsFileItem = isFileItem;
            this.ItemId = itemId;
            this.ItemPath = itemPath;
            this.IsFileItem = isFileItem;
            this.ItemId = itemId;
            this.ItemPath = itemPath;
        }
        
        /// <summary>
        /// Specifies whether the current item is a file or not.
        /// </summary>
        /// <value>Specifies whether the current item is a file or not.</value>
        [DataMember(Name="isFileItem", EmitDefaultValue=true)]
        public bool? IsFileItem { get; set; }

        /// <summary>
        /// Specifies the Id of the Drive item.
        /// </summary>
        /// <value>Specifies the Id of the Drive item.</value>
        [DataMember(Name="itemId", EmitDefaultValue=true)]
        public string ItemId { get; set; }

        /// <summary>
        /// Specifies the path of the Drive item within the drive.
        /// </summary>
        /// <value>Specifies the path of the Drive item within the drive.</value>
        [DataMember(Name="itemPath", EmitDefaultValue=true)]
        public string ItemPath { get; set; }

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
            return this.Equals(input as SiteDriveItem);
        }

        /// <summary>
        /// Returns true if SiteDriveItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteDriveItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteDriveItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsFileItem == input.IsFileItem ||
                    (this.IsFileItem != null &&
                    this.IsFileItem.Equals(input.IsFileItem))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemPath == input.ItemPath ||
                    (this.ItemPath != null &&
                    this.ItemPath.Equals(input.ItemPath))
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
                if (this.IsFileItem != null)
                    hashCode = hashCode * 59 + this.IsFileItem.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ItemPath != null)
                    hashCode = hashCode * 59 + this.ItemPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

