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
    /// This message defines the per object restore parameters for restoring a SINGLE user&#39;s One Drive.
    /// </summary>
    [DataContract]
    public partial class O365OneDriveRestoreEntityParams :  IEquatable<O365OneDriveRestoreEntityParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365OneDriveRestoreEntityParams" /> class.
        /// </summary>
        /// <param name="driveVec">The list of drives that are being restored..</param>
        public O365OneDriveRestoreEntityParams(List<O365OneDriveRestoreEntityParamsDrive> driveVec = default(List<O365OneDriveRestoreEntityParamsDrive>))
        {
            this.DriveVec = driveVec;
            this.DriveVec = driveVec;
        }
        
        /// <summary>
        /// The list of drives that are being restored.
        /// </summary>
        /// <value>The list of drives that are being restored.</value>
        [DataMember(Name="driveVec", EmitDefaultValue=true)]
        public List<O365OneDriveRestoreEntityParamsDrive> DriveVec { get; set; }

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
            return this.Equals(input as O365OneDriveRestoreEntityParams);
        }

        /// <summary>
        /// Returns true if O365OneDriveRestoreEntityParams instances are equal
        /// </summary>
        /// <param name="input">Instance of O365OneDriveRestoreEntityParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365OneDriveRestoreEntityParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveVec == input.DriveVec ||
                    this.DriveVec != null &&
                    input.DriveVec != null &&
                    this.DriveVec.SequenceEqual(input.DriveVec)
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
                if (this.DriveVec != null)
                    hashCode = hashCode * 59 + this.DriveVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

