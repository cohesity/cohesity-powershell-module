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
    /// Hyperv Virtual Disk
    /// </summary>
    [DataContract]
    public partial class VirtualDiskBasicInfo :  IEquatable<VirtualDiskBasicInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskBasicInfo" /> class.
        /// </summary>
        /// <param name="controllerBusNumber">Controller bus number..</param>
        /// <param name="controllerType">Controller type..</param>
        /// <param name="unitNumber">Disk unit number..</param>
        public VirtualDiskBasicInfo(long? controllerBusNumber = default(long?), string controllerType = default(string), long? unitNumber = default(long?))
        {
            this.ControllerBusNumber = controllerBusNumber;
            this.ControllerType = controllerType;
            this.UnitNumber = unitNumber;
            this.ControllerBusNumber = controllerBusNumber;
            this.ControllerType = controllerType;
            this.UnitNumber = unitNumber;
        }
        
        /// <summary>
        /// Controller bus number.
        /// </summary>
        /// <value>Controller bus number.</value>
        [DataMember(Name="controllerBusNumber", EmitDefaultValue=true)]
        public long? ControllerBusNumber { get; set; }

        /// <summary>
        /// Controller type.
        /// </summary>
        /// <value>Controller type.</value>
        [DataMember(Name="controllerType", EmitDefaultValue=true)]
        public string ControllerType { get; set; }

        /// <summary>
        /// Disk unit number.
        /// </summary>
        /// <value>Disk unit number.</value>
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
            return this.Equals(input as VirtualDiskBasicInfo);
        }

        /// <summary>
        /// Returns true if VirtualDiskBasicInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskBasicInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskBasicInfo input)
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

