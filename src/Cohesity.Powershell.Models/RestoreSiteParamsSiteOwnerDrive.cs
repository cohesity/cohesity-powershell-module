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
    /// RestoreSiteParamsSiteOwnerDrive
    /// </summary>
    [DataContract]
    public partial class RestoreSiteParamsSiteOwnerDrive :  IEquatable<RestoreSiteParamsSiteOwnerDrive>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSiteParamsSiteOwnerDrive" /> class.
        /// </summary>
        /// <param name="isEntireDriveRequired">Specify if the entire drive is to be restored. This field should be false if restore_item_vec size &gt; 0..</param>
        /// <param name="restoreDriveId">Id of the drive whose items are being restored..</param>
        /// <param name="restoreDriveName">Specifies the name of the drive whos items are being restored. NOTE: For restore either the drive Id or the name must be populated..</param>
        /// <param name="restorePathVec">List of drive paths that need to be restored..</param>
        public RestoreSiteParamsSiteOwnerDrive(bool? isEntireDriveRequired = default(bool?), string restoreDriveId = default(string), string restoreDriveName = default(string), List<RestoreSiteParamsDriveItem> restorePathVec = default(List<RestoreSiteParamsDriveItem>))
        {
            this.IsEntireDriveRequired = isEntireDriveRequired;
            this.RestoreDriveId = restoreDriveId;
            this.RestoreDriveName = restoreDriveName;
            this.RestorePathVec = restorePathVec;
            this.IsEntireDriveRequired = isEntireDriveRequired;
            this.RestoreDriveId = restoreDriveId;
            this.RestoreDriveName = restoreDriveName;
            this.RestorePathVec = restorePathVec;
        }
        
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
        /// Specifies the name of the drive whos items are being restored. NOTE: For restore either the drive Id or the name must be populated.
        /// </summary>
        /// <value>Specifies the name of the drive whos items are being restored. NOTE: For restore either the drive Id or the name must be populated.</value>
        [DataMember(Name="restoreDriveName", EmitDefaultValue=true)]
        public string RestoreDriveName { get; set; }

        /// <summary>
        /// List of drive paths that need to be restored.
        /// </summary>
        /// <value>List of drive paths that need to be restored.</value>
        [DataMember(Name="restorePathVec", EmitDefaultValue=true)]
        public List<RestoreSiteParamsDriveItem> RestorePathVec { get; set; }

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
            return this.Equals(input as RestoreSiteParamsSiteOwnerDrive);
        }

        /// <summary>
        /// Returns true if RestoreSiteParamsSiteOwnerDrive instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreSiteParamsSiteOwnerDrive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreSiteParamsSiteOwnerDrive input)
        {
            if (input == null)
                return false;

            return 
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
                    this.RestoreDriveName == input.RestoreDriveName ||
                    (this.RestoreDriveName != null &&
                    this.RestoreDriveName.Equals(input.RestoreDriveName))
                ) && 
                (
                    this.RestorePathVec == input.RestorePathVec ||
                    this.RestorePathVec != null &&
                    input.RestorePathVec != null &&
                    this.RestorePathVec.Equals(input.RestorePathVec)
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
                if (this.IsEntireDriveRequired != null)
                    hashCode = hashCode * 59 + this.IsEntireDriveRequired.GetHashCode();
                if (this.RestoreDriveId != null)
                    hashCode = hashCode * 59 + this.RestoreDriveId.GetHashCode();
                if (this.RestoreDriveName != null)
                    hashCode = hashCode * 59 + this.RestoreDriveName.GetHashCode();
                if (this.RestorePathVec != null)
                    hashCode = hashCode * 59 + this.RestorePathVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

