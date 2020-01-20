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
    /// DeviceTreeChildDevice
    /// </summary>
    [DataContract]
    public partial class DeviceTreeChildDevice :  IEquatable<DeviceTreeChildDevice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTreeChildDevice" /> class.
        /// </summary>
        /// <param name="device">device.</param>
        /// <param name="partitionSlice">partitionSlice.</param>
        public DeviceTreeChildDevice(DeviceTree device = default(DeviceTree), DeviceTreePartitionSlice partitionSlice = default(DeviceTreePartitionSlice))
        {
            this.Device = device;
            this.PartitionSlice = partitionSlice;
        }
        
        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public DeviceTree Device { get; set; }

        /// <summary>
        /// Gets or Sets PartitionSlice
        /// </summary>
        [DataMember(Name="partitionSlice", EmitDefaultValue=false)]
        public DeviceTreePartitionSlice PartitionSlice { get; set; }

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
            return this.Equals(input as DeviceTreeChildDevice);
        }

        /// <summary>
        /// Returns true if DeviceTreeChildDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceTreeChildDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceTreeChildDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.PartitionSlice == input.PartitionSlice ||
                    (this.PartitionSlice != null &&
                    this.PartitionSlice.Equals(input.PartitionSlice))
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
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.PartitionSlice != null)
                    hashCode = hashCode * 59 + this.PartitionSlice.GetHashCode();
                return hashCode;
            }
        }

    }

}

