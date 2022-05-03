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
    /// Specifies OneDrive owner details.
    /// </summary>
    [DataContract]
    public partial class OneDriveOwner :  IEquatable<OneDriveOwner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveOwner" /> class.
        /// </summary>
        /// <param name="driveInfoList">Specifies the Drives that a user owns which are to be restored..</param>
        /// <param name="userDetailObject">userDetailObject.</param>
        public OneDriveOwner(List<OneDriveInfo> driveInfoList = default(List<OneDriveInfo>), RestoreObjectDetails userDetailObject = default(RestoreObjectDetails))
        {
            this.DriveInfoList = driveInfoList;
            this.UserDetailObject = userDetailObject;
        }
        
        /// <summary>
        /// Specifies the Drives that a user owns which are to be restored.
        /// </summary>
        /// <value>Specifies the Drives that a user owns which are to be restored.</value>
        [DataMember(Name="driveInfoList", EmitDefaultValue=false)]
        public List<OneDriveInfo> DriveInfoList { get; set; }

        /// <summary>
        /// Gets or Sets UserDetailObject
        /// </summary>
        [DataMember(Name="userDetailObject", EmitDefaultValue=false)]
        public RestoreObjectDetails UserDetailObject { get; set; }

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
            return this.Equals(input as OneDriveOwner);
        }

        /// <summary>
        /// Returns true if OneDriveOwner instances are equal
        /// </summary>
        /// <param name="input">Instance of OneDriveOwner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneDriveOwner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveInfoList == input.DriveInfoList ||
                    this.DriveInfoList != null &&
                    this.DriveInfoList.Equals(input.DriveInfoList)
                ) && 
                (
                    this.UserDetailObject == input.UserDetailObject ||
                    (this.UserDetailObject != null &&
                    this.UserDetailObject.Equals(input.UserDetailObject))
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
                if (this.DriveInfoList != null)
                    hashCode = hashCode * 59 + this.DriveInfoList.GetHashCode();
                if (this.UserDetailObject != null)
                    hashCode = hashCode * 59 + this.UserDetailObject.GetHashCode();
                return hashCode;
            }
        }

    }

}

