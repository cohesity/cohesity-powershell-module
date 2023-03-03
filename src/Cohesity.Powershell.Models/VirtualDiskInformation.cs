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
    /// VirtualDiskInformation
    /// </summary>
    [DataContract]
    public partial class VirtualDiskInformation :  IEquatable<VirtualDiskInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskInformation" /> class.
        /// </summary>
        /// <param name="busNumber">Specifies the Id of the controller bus that controls the disk..</param>
        /// <param name="controllerType">Specifies the controller type like SCSI, or IDE etc..</param>
        /// <param name="diskId">Specifies original disk id. This is sufficient to identify the disk information, but in some scenarios, users may specify the controller option instead..</param>
        /// <param name="diskLocation">diskLocation.</param>
        /// <param name="diskSizeInBytes">Specifies size of the virtual disk in bytes..</param>
        /// <param name="filePath">Specifies the original file path if applicable..</param>
        /// <param name="mountPoints">Specifies the list of mount points..</param>
        /// <param name="unitNumber">Specifies the disk file name. This is the VMDK name and not the flat file name..</param>
        public VirtualDiskInformation(long? busNumber = default(long?), string controllerType = default(string), string diskId = default(string), ProtectionSource diskLocation = default(ProtectionSource), long? diskSizeInBytes = default(long?), string filePath = default(string), List<string> mountPoints = default(List<string>), long? unitNumber = default(long?))
        {
            this.BusNumber = busNumber;
            this.ControllerType = controllerType;
            this.DiskId = diskId;
            this.DiskSizeInBytes = diskSizeInBytes;
            this.FilePath = filePath;
            this.MountPoints = mountPoints;
            this.UnitNumber = unitNumber;
            this.BusNumber = busNumber;
            this.ControllerType = controllerType;
            this.DiskId = diskId;
            this.DiskLocation = diskLocation;
            this.DiskSizeInBytes = diskSizeInBytes;
            this.FilePath = filePath;
            this.MountPoints = mountPoints;
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
        /// Specifies original disk id. This is sufficient to identify the disk information, but in some scenarios, users may specify the controller option instead.
        /// </summary>
        /// <value>Specifies original disk id. This is sufficient to identify the disk information, but in some scenarios, users may specify the controller option instead.</value>
        [DataMember(Name="diskId", EmitDefaultValue=true)]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or Sets DiskLocation
        /// </summary>
        [DataMember(Name="diskLocation", EmitDefaultValue=false)]
        public ProtectionSource DiskLocation { get; set; }

        /// <summary>
        /// Specifies size of the virtual disk in bytes.
        /// </summary>
        /// <value>Specifies size of the virtual disk in bytes.</value>
        [DataMember(Name="diskSizeInBytes", EmitDefaultValue=true)]
        public long? DiskSizeInBytes { get; set; }

        /// <summary>
        /// Specifies the original file path if applicable.
        /// </summary>
        /// <value>Specifies the original file path if applicable.</value>
        [DataMember(Name="filePath", EmitDefaultValue=true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Specifies the list of mount points.
        /// </summary>
        /// <value>Specifies the list of mount points.</value>
        [DataMember(Name="mountPoints", EmitDefaultValue=true)]
        public List<string> MountPoints { get; set; }

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
            return this.Equals(input as VirtualDiskInformation);
        }

        /// <summary>
        /// Returns true if VirtualDiskInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskInformation input)
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
                    this.DiskLocation == input.DiskLocation ||
                    (this.DiskLocation != null &&
                    this.DiskLocation.Equals(input.DiskLocation))
                ) && 
                (
                    this.DiskSizeInBytes == input.DiskSizeInBytes ||
                    (this.DiskSizeInBytes != null &&
                    this.DiskSizeInBytes.Equals(input.DiskSizeInBytes))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.MountPoints == input.MountPoints ||
                    this.MountPoints != null &&
                    input.MountPoints != null &&
                    this.MountPoints.SequenceEqual(input.MountPoints)
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
                if (this.DiskLocation != null)
                    hashCode = hashCode * 59 + this.DiskLocation.GetHashCode();
                if (this.DiskSizeInBytes != null)
                    hashCode = hashCode * 59 + this.DiskSizeInBytes.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.MountPoints != null)
                    hashCode = hashCode * 59 + this.MountPoints.GetHashCode();
                if (this.UnitNumber != null)
                    hashCode = hashCode * 59 + this.UnitNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}

