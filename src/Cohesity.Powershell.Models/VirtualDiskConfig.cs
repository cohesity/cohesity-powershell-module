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
    /// Acropolis Virtual Disk
    /// </summary>
    [DataContract]
    public partial class VirtualDiskConfig :  IEquatable<VirtualDiskConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskConfig" /> class.
        /// </summary>
        /// <param name="deviceBus">The device bus for the virtual disk device..</param>
        /// <param name="deviceIndex">Index of the device on the adapter type..</param>
        /// <param name="diskSizeBytes">Disk size in Bytes..</param>
        public VirtualDiskConfig(string deviceBus = default(string), int? deviceIndex = default(int?), long? diskSizeBytes = default(long?))
        {
            this.DeviceBus = deviceBus;
            this.DeviceIndex = deviceIndex;
            this.DiskSizeBytes = diskSizeBytes;
            this.DeviceBus = deviceBus;
            this.DeviceIndex = deviceIndex;
            this.DiskSizeBytes = diskSizeBytes;
        }
        
        /// <summary>
        /// The device bus for the virtual disk device.
        /// </summary>
        /// <value>The device bus for the virtual disk device.</value>
        [DataMember(Name="deviceBus", EmitDefaultValue=true)]
        public string DeviceBus { get; set; }

        /// <summary>
        /// Index of the device on the adapter type.
        /// </summary>
        /// <value>Index of the device on the adapter type.</value>
        [DataMember(Name="deviceIndex", EmitDefaultValue=true)]
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Disk size in Bytes.
        /// </summary>
        /// <value>Disk size in Bytes.</value>
        [DataMember(Name="diskSizeBytes", EmitDefaultValue=true)]
        public long? DiskSizeBytes { get; set; }

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
            return this.Equals(input as VirtualDiskConfig);
        }

        /// <summary>
        /// Returns true if VirtualDiskConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceBus == input.DeviceBus ||
                    (this.DeviceBus != null &&
                    this.DeviceBus.Equals(input.DeviceBus))
                ) && 
                (
                    this.DeviceIndex == input.DeviceIndex ||
                    (this.DeviceIndex != null &&
                    this.DeviceIndex.Equals(input.DeviceIndex))
                ) && 
                (
                    this.DiskSizeBytes == input.DiskSizeBytes ||
                    (this.DiskSizeBytes != null &&
                    this.DiskSizeBytes.Equals(input.DiskSizeBytes))
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
                if (this.DeviceBus != null)
                    hashCode = hashCode * 59 + this.DeviceBus.GetHashCode();
                if (this.DeviceIndex != null)
                    hashCode = hashCode * 59 + this.DeviceIndex.GetHashCode();
                if (this.DiskSizeBytes != null)
                    hashCode = hashCode * 59 + this.DiskSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

