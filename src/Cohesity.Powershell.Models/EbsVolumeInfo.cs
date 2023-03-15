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
    /// Specifies information about an AWS volume attached to an EC2 instance.
    /// </summary>
    [DataContract]
    public partial class EbsVolumeInfo :  IEquatable<EbsVolumeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EbsVolumeInfo" /> class.
        /// </summary>
        /// <param name="deviceName">Specifies the name of the device. Eg - /dev/sdb..</param>
        /// <param name="id">Specifies the ID of the volume..</param>
        /// <param name="isRootDevice">Specifies if the volume is attached as root device..</param>
        /// <param name="name">Specifies the name of the volume..</param>
        /// <param name="sizeBytes">Specifies the size of the volume in bytes..</param>
        /// <param name="tags">Specifies the list of tags on EBS volume..</param>
        /// <param name="type">Specifies the type of the volume. Eg - gp2, io1..</param>
        public EbsVolumeInfo(string deviceName = default(string), string id = default(string), bool? isRootDevice = default(bool?), string name = default(string), long? sizeBytes = default(long?), List<EBSVolumeTag> tags = default(List<EBSVolumeTag>), string type = default(string))
        {
            this.DeviceName = deviceName;
            this.Id = id;
            this.IsRootDevice = isRootDevice;
            this.Name = name;
            this.SizeBytes = sizeBytes;
            this.Tags = tags;
            this.Type = type;
            this.DeviceName = deviceName;
            this.Id = id;
            this.IsRootDevice = isRootDevice;
            this.Name = name;
            this.SizeBytes = sizeBytes;
            this.Tags = tags;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the name of the device. Eg - /dev/sdb.
        /// </summary>
        /// <value>Specifies the name of the device. Eg - /dev/sdb.</value>
        [DataMember(Name="deviceName", EmitDefaultValue=true)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Specifies the ID of the volume.
        /// </summary>
        /// <value>Specifies the ID of the volume.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies if the volume is attached as root device.
        /// </summary>
        /// <value>Specifies if the volume is attached as root device.</value>
        [DataMember(Name="isRootDevice", EmitDefaultValue=true)]
        public bool? IsRootDevice { get; set; }

        /// <summary>
        /// Specifies the name of the volume.
        /// </summary>
        /// <value>Specifies the name of the volume.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the size of the volume in bytes.
        /// </summary>
        /// <value>Specifies the size of the volume in bytes.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Specifies the list of tags on EBS volume.
        /// </summary>
        /// <value>Specifies the list of tags on EBS volume.</value>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<EBSVolumeTag> Tags { get; set; }

        /// <summary>
        /// Specifies the type of the volume. Eg - gp2, io1.
        /// </summary>
        /// <value>Specifies the type of the volume. Eg - gp2, io1.</value>
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
            return this.Equals(input as EbsVolumeInfo);
        }

        /// <summary>
        /// Returns true if EbsVolumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EbsVolumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EbsVolumeInfo input)
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
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

