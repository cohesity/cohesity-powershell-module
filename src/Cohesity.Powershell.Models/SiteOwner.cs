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
    /// Specifies the details about a SharePoint Site owner.
    /// </summary>
    [DataContract]
    public partial class SiteOwner :  IEquatable<SiteOwner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteOwner" /> class.
        /// </summary>
        /// <param name="driveInfoList">Specifies the Document Libraries within a Site which are to be restored..</param>
        /// <param name="siteDetailObject">siteDetailObject.</param>
        public SiteOwner(List<SiteDriveInfo> driveInfoList = default(List<SiteDriveInfo>), RestoreObjectDetails siteDetailObject = default(RestoreObjectDetails))
        {
            this.DriveInfoList = driveInfoList;
            this.DriveInfoList = driveInfoList;
            this.SiteDetailObject = siteDetailObject;
        }
        
        /// <summary>
        /// Specifies the Document Libraries within a Site which are to be restored.
        /// </summary>
        /// <value>Specifies the Document Libraries within a Site which are to be restored.</value>
        [DataMember(Name="driveInfoList", EmitDefaultValue=true)]
        public List<SiteDriveInfo> DriveInfoList { get; set; }

        /// <summary>
        /// Gets or Sets SiteDetailObject
        /// </summary>
        [DataMember(Name="siteDetailObject", EmitDefaultValue=false)]
        public RestoreObjectDetails SiteDetailObject { get; set; }

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
            return this.Equals(input as SiteOwner);
        }

        /// <summary>
        /// Returns true if SiteOwner instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteOwner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteOwner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveInfoList == input.DriveInfoList ||
                    this.DriveInfoList != null &&
                    input.DriveInfoList != null &&
                    this.DriveInfoList.SequenceEqual(input.DriveInfoList)
                ) && 
                (
                    this.SiteDetailObject == input.SiteDetailObject ||
                    (this.SiteDetailObject != null &&
                    this.SiteDetailObject.Equals(input.SiteDetailObject))
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
                if (this.SiteDetailObject != null)
                    hashCode = hashCode * 59 + this.SiteDetailObject.GetHashCode();
                return hashCode;
            }
        }

    }

}

