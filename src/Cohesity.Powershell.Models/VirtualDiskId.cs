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
    /// This message defines the proto that can be used to identify the disks in different environments.
    /// </summary>
    [DataContract]
    public partial class VirtualDiskId :  IEquatable<VirtualDiskId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskId" /> class.
        /// </summary>
        /// <param name="controllerBusNumber">Controller&#39;s bus-id controlling the virtual disk in question..</param>
        /// <param name="controllerType">Controller&#39;s type (SCSI, IDE etc)..</param>
        /// <param name="diskId">Original disk id. This is sufficient to identify the disk information, but in some scenarios, user&#39;s may specify the controller option instead..</param>
        /// <param name="unitNumber">Disk unit number to identify the virtual disk within a controller..</param>
        public VirtualDiskId(long? controllerBusNumber = default(long?), string controllerType = default(string), string diskId = default(string), long? unitNumber = default(long?))
        {
            this.ControllerBusNumber = controllerBusNumber;
            this.ControllerType = controllerType;
            this.DiskId = diskId;
            this.UnitNumber = unitNumber;
        }
        
        /// <summary>
        /// Controller&#39;s bus-id controlling the virtual disk in question.
        /// </summary>
        /// <value>Controller&#39;s bus-id controlling the virtual disk in question.</value>
        [DataMember(Name="controllerBusNumber", EmitDefaultValue=false)]
        public long? ControllerBusNumber { get; set; }

        /// <summary>
        /// Controller&#39;s type (SCSI, IDE etc).
        /// </summary>
        /// <value>Controller&#39;s type (SCSI, IDE etc).</value>
        [DataMember(Name="controllerType", EmitDefaultValue=false)]
        public string ControllerType { get; set; }

        /// <summary>
        /// Original disk id. This is sufficient to identify the disk information, but in some scenarios, user&#39;s may specify the controller option instead.
        /// </summary>
        /// <value>Original disk id. This is sufficient to identify the disk information, but in some scenarios, user&#39;s may specify the controller option instead.</value>
        [DataMember(Name="diskId", EmitDefaultValue=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// Disk unit number to identify the virtual disk within a controller.
        /// </summary>
        /// <value>Disk unit number to identify the virtual disk within a controller.</value>
        [DataMember(Name="unitNumber", EmitDefaultValue=false)]
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
            return this.Equals(input as VirtualDiskId);
        }

        /// <summary>
        /// Returns true if VirtualDiskId instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ControllerBusNumber == input.ControllerBusNumber ||
                    (this.ControllerBusNumber != null &&
                    this.ControllerBusNumber.Equals(input.ControllerBusNumber))
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
                if (this.ControllerBusNumber != null)
                    hashCode = hashCode * 59 + this.ControllerBusNumber.GetHashCode();
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

