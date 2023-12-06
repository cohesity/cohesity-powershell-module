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
    /// Specified info about the GCP disk.
    /// </summary>
    [DataContract]
    public partial class GcpDiskInfo :  IEquatable<GcpDiskInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpDiskInfo" /> class.
        /// </summary>
        /// <param name="deviceName">Specifies the name of the device. Eg - /dev/sdb..</param>
        /// <param name="id">Specified ID of the disk..</param>
        /// <param name="isRootDevice">Specifies if the disk is attached as root device..</param>
        /// <param name="name">Specifies the name of the disk..</param>
        /// <param name="sizeGb">Specifies the size of the device..</param>
        /// <param name="type">Specifies the type of the disk..</param>
        public GcpDiskInfo(string deviceName = default(string), long? id = default(long?), bool? isRootDevice = default(bool?), string name = default(string), long? sizeGb = default(long?), string type = default(string))
        {
            this.DeviceName = deviceName;
            this.Id = id;
            this.IsRootDevice = isRootDevice;
            this.Name = name;
            this.SizeGb = sizeGb;
            this.Type = type;
            this.DeviceName = deviceName;
            this.Id = id;
            this.IsRootDevice = isRootDevice;
            this.Name = name;
            this.SizeGb = sizeGb;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the name of the device. Eg - /dev/sdb.
        /// </summary>
        /// <value>Specifies the name of the device. Eg - /dev/sdb.</value>
        [DataMember(Name="deviceName", EmitDefaultValue=true)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Specified ID of the disk.
        /// </summary>
        /// <value>Specified ID of the disk.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies if the disk is attached as root device.
        /// </summary>
        /// <value>Specifies if the disk is attached as root device.</value>
        [DataMember(Name="isRootDevice", EmitDefaultValue=true)]
        public bool? IsRootDevice { get; set; }

        /// <summary>
        /// Specifies the name of the disk.
        /// </summary>
        /// <value>Specifies the name of the disk.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the size of the device.
        /// </summary>
        /// <value>Specifies the size of the device.</value>
        [DataMember(Name="sizeGb", EmitDefaultValue=true)]
        public long? SizeGb { get; set; }

        /// <summary>
        /// Specifies the type of the disk.
        /// </summary>
        /// <value>Specifies the type of the disk.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

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
            return this.Equals(input as GcpDiskInfo);
        }

        /// <summary>
        /// Returns true if GcpDiskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpDiskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpDiskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsRootDevice == input.IsRootDevice ||
                    (this.IsRootDevice != null &&
                    this.IsRootDevice.Equals(input.IsRootDevice))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SizeGb == input.SizeGb ||
                    (this.SizeGb != null &&
                    this.SizeGb.Equals(input.SizeGb))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsRootDevice != null)
                    hashCode = hashCode * 59 + this.IsRootDevice.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SizeGb != null)
                    hashCode = hashCode * 59 + this.SizeGb.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

