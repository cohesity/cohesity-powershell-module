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
    /// Specifies information specific to SMB shares exposed by Isilon file system.
    /// </summary>
    [DataContract]
    public partial class IsilonSmbMountPoint :  IEquatable<IsilonSmbMountPoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonSmbMountPoint" /> class.
        /// </summary>
        /// <param name="accessZoneId">Specifies the Access Zone Id..</param>
        /// <param name="description">Specifies the description of the NFS mount point..</param>
        /// <param name="shareName">Specifies the name of the SMB/CIFS share..</param>
        public IsilonSmbMountPoint(long? accessZoneId = default(long?), string description = default(string), string shareName = default(string))
        {
            this.AccessZoneId = accessZoneId;
            this.Description = description;
            this.ShareName = shareName;
            this.AccessZoneId = accessZoneId;
            this.Description = description;
            this.ShareName = shareName;
        }
        
        /// <summary>
        /// Specifies the Access Zone Id.
        /// </summary>
        /// <value>Specifies the Access Zone Id.</value>
        [DataMember(Name="accessZoneId", EmitDefaultValue=true)]
        public long? AccessZoneId { get; set; }

        /// <summary>
        /// Specifies the description of the NFS mount point.
        /// </summary>
        /// <value>Specifies the description of the NFS mount point.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the name of the SMB/CIFS share.
        /// </summary>
        /// <value>Specifies the name of the SMB/CIFS share.</value>
        [DataMember(Name="shareName", EmitDefaultValue=true)]
        public string ShareName { get; set; }

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
            return this.Equals(input as IsilonSmbMountPoint);
        }

        /// <summary>
        /// Returns true if IsilonSmbMountPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonSmbMountPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonSmbMountPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessZoneId == input.AccessZoneId ||
                    (this.AccessZoneId != null &&
                    this.AccessZoneId.Equals(input.AccessZoneId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ShareName == input.ShareName ||
                    (this.ShareName != null &&
                    this.ShareName.Equals(input.ShareName))
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
                if (this.AccessZoneId != null)
                    hashCode = hashCode * 59 + this.AccessZoneId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ShareName != null)
                    hashCode = hashCode * 59 + this.ShareName.GetHashCode();
                return hashCode;
            }
        }

    }

}

