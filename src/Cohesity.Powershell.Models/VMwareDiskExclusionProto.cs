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
    /// This message contains basic info of the disk to be excluded from backup. The info contained here: 1. should be enough to identify the disk during the backup job. 2. is a subset of the message fetched to be displayed to the end user. Example: entities/vmware.proto. Note: Currently this is only implemented for VMware type source.
    /// </summary>
    [DataContract]
    public partial class VMwareDiskExclusionProto :  IEquatable<VMwareDiskExclusionProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareDiskExclusionProto" /> class.
        /// </summary>
        /// <param name="controllerBusNumber">Controller&#39;s bus-id controlling the virtual disk in question..</param>
        /// <param name="controllerType">Controller&#39;s type (SCSI, IDE etc)..</param>
        /// <param name="unitNumber">Disk unit number to identify the virtual disk within a controller..</param>
        public VMwareDiskExclusionProto(long? controllerBusNumber = default(long?), string controllerType = default(string), long? unitNumber = default(long?))
        {
            this.ControllerBusNumber = controllerBusNumber;
            this.ControllerType = controllerType;
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
            return this.Equals(input as VMwareDiskExclusionProto);
        }

        /// <summary>
        /// Returns true if VMwareDiskExclusionProto instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareDiskExclusionProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareDiskExclusionProto input)
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
                if (this.UnitNumber != null)
                    hashCode = hashCode * 59 + this.UnitNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}

