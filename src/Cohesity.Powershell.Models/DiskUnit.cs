// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a disk unit in a controller.
    /// </summary>
    [DataContract]
    public partial class DiskUnit :  IEquatable<DiskUnit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiskUnit" /> class.
        /// </summary>
        /// <param name="busNumber">Specifies the Id of the controller bus that controls the disk..</param>
        /// <param name="controllerType">Specifies the controller type like SCSI, or IDE etc..</param>
        /// <param name="unitNumber">Specifies the disk file name. This is the VMDK name and not the flat file name..</param>
        public DiskUnit(long? busNumber = default(long?), string controllerType = default(string), long? unitNumber = default(long?))
        {
            this.BusNumber = busNumber;
            this.ControllerType = controllerType;
            this.UnitNumber = unitNumber;
        }
        
        /// <summary>
        /// Specifies the Id of the controller bus that controls the disk.
        /// </summary>
        /// <value>Specifies the Id of the controller bus that controls the disk.</value>
        [DataMember(Name="busNumber", EmitDefaultValue=false)]
        public long? BusNumber { get; set; }

        /// <summary>
        /// Specifies the controller type like SCSI, or IDE etc.
        /// </summary>
        /// <value>Specifies the controller type like SCSI, or IDE etc.</value>
        [DataMember(Name="controllerType", EmitDefaultValue=false)]
        public string ControllerType { get; set; }

        /// <summary>
        /// Specifies the disk file name. This is the VMDK name and not the flat file name.
        /// </summary>
        /// <value>Specifies the disk file name. This is the VMDK name and not the flat file name.</value>
        [DataMember(Name="unitNumber", EmitDefaultValue=false)]
        public long? UnitNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as DiskUnit);
        }

        /// <summary>
        /// Returns true if DiskUnit instances are equal
        /// </summary>
        /// <param name="input">Instance of DiskUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiskUnit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusNumber == input.BusNumber ||
                    (this.BusNumber != null &&
                    this.BusNumber.Equals(input.BusNumber))
                ) && 
                (
                    this.ControllerType == input.ControllerType ||
                    (this.ControllerType != null &&
                    this.ControllerType.Equals(input.ControllerType))
                ) && 
                (
                    this.UnitNumber == input.UnitNumber ||
                    (this.UnitNumber != null &&
                    this.UnitNumber.Equals(input.UnitNumber))
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
                if (this.BusNumber != null)
                    hashCode = hashCode * 59 + this.BusNumber.GetHashCode();
                if (this.ControllerType != null)
                    hashCode = hashCode * 59 + this.ControllerType.GetHashCode();
                if (this.UnitNumber != null)
                    hashCode = hashCode * 59 + this.UnitNumber.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

