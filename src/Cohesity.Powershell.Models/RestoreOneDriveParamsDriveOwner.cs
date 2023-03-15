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
    /// RestoreOneDriveParamsDriveOwner
    /// </summary>
    [DataContract]
    public partial class RestoreOneDriveParamsDriveOwner :  IEquatable<RestoreOneDriveParamsDriveOwner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOneDriveParamsDriveOwner" /> class.
        /// </summary>
        /// <param name="driveVec">The list of drives that are being restored..</param>
        /// <param name="_object">_object.</param>
        public RestoreOneDriveParamsDriveOwner(List<RestoreOneDriveParamsDriveOwnerDrive> driveVec = default(List<RestoreOneDriveParamsDriveOwnerDrive>), RestoreObject _object = default(RestoreObject))
        {
            this.DriveVec = driveVec;
            this.DriveVec = driveVec;
            this.Object = _object;
        }
        
        /// <summary>
        /// The list of drives that are being restored.
        /// </summary>
        /// <value>The list of drives that are being restored.</value>
        [DataMember(Name="driveVec", EmitDefaultValue=true)]
        public List<RestoreOneDriveParamsDriveOwnerDrive> DriveVec { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public RestoreObject Object { get; set; }

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
            return this.Equals(input as RestoreOneDriveParamsDriveOwner);
        }

        /// <summary>
        /// Returns true if RestoreOneDriveParamsDriveOwner instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOneDriveParamsDriveOwner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOneDriveParamsDriveOwner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriveVec == input.DriveVec ||
                    this.DriveVec != null &&
                    input.DriveVec != null &&
                    this.DriveVec.SequenceEqual(input.DriveVec)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                return hashCode;
            }
        }

    }

}

