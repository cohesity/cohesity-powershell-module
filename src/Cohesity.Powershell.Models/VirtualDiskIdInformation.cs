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
    /// Specifies information about virtual disk which includes disk uuid, controller type, bus number and unit number.
    /// </summary>
    [DataContract]
    public partial class VirtualDiskIdInformation :  IEquatable<VirtualDiskIdInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskIdInformation" /> class.
        /// </summary>
        /// <param name="busNumber">Specifies the Id of the controller bus that controls the disk..</param>
        /// <param name="controllerType">Specifies the controller type like SCSI, or IDE etc..</param>
        /// <param name="diskId">Specifies the uuid of the virtual disk..</param>
        /// <param name="unitNumber">Specifies the disk file name. This is the VMDK name and not the flat file name..</param>
        public VirtualDiskIdInformation(long? busNumber = default(long?), string controllerType = default(string), string diskId = default(string), long? unitNumber = default(long?))
        {
            this.BusNumber = busNumber;
            this.ControllerType = controllerType;
            this.DiskId = diskId;
            this.UnitNumber = unitNumber;
            this.BusNumber = busNumber;
            this.ControllerType = controllerType;
            this.DiskId = diskId;
            this.UnitNumber = unitNumber;
        }
        
        /// <summary>
        /// Specifies the Id of the controller bus that controls the disk.
        /// </summary>
        /// <value>Specifies the Id of the controller bus that controls the disk.</value>
        [DataMember(Name="busNumber", EmitDefaultValue=true)]
        public long? BusNumber { get; set; }

        /// <summary>
        /// Specifies the controller type like SCSI, or IDE etc.
        /// </summary>
        /// <value>Specifies the controller type like SCSI, or IDE etc.</value>
        [DataMember(Name="controllerType", EmitDefaultValue=true)]
        public string ControllerType { get; set; }

        /// <summary>
        /// Specifies the uuid of the virtual disk.
        /// </summary>
        /// <value>Specifies the uuid of the virtual disk.</value>
        [DataMember(Name="diskId", EmitDefaultValue=true)]
        public string DiskId { get; set; }

        /// <summary>
        /// Specifies the disk file name. This is the VMDK name and not the flat file name.
        /// </summary>
        /// <value>Specifies the disk file name. This is the VMDK name and not the flat file name.</value>
        [DataMember(Name="unitNumber", EmitDefaultValue=true)]
        public long? UnitNumber { get; set; }

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
            return this.Equals(input as VirtualDiskIdInformation);
        }

        /// <summary>
        /// Returns true if VirtualDiskIdInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskIdInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskIdInformation input)
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
                    this.DiskId == input.DiskId ||
                    (this.DiskId != null &&
                    this.DiskId.Equals(input.DiskId))
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
                if (this.DiskId != null)
                    hashCode = hashCode * 59 + this.DiskId.GetHashCode();
                if (this.UnitNumber != null)
                    hashCode = hashCode * 59 + this.UnitNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}

