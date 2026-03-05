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
    /// Specified info about the Azure disk.
    /// </summary>
    [DataContract]
    public partial class AzureDiskInfo :  IEquatable<AzureDiskInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDiskInfo" /> class.
        /// </summary>
        /// <param name="isOsDisk">Specifies if the disk is attached as root device..</param>
        /// <param name="name">Specifies the name of the disk..</param>
        /// <param name="sizeBytes">Specifies the size of the device..</param>
        public AzureDiskInfo(bool? isOsDisk = default(bool?), string name = default(string), long? sizeBytes = default(long?))
        {
            this.IsOsDisk = isOsDisk;
            this.Name = name;
            this.SizeBytes = sizeBytes;
            this.IsOsDisk = isOsDisk;
            this.Name = name;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Specifies if the disk is attached as root device.
        /// </summary>
        /// <value>Specifies if the disk is attached as root device.</value>
        [DataMember(Name="isOsDisk", EmitDefaultValue=true)]
        public bool? IsOsDisk { get; set; }

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
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
        public long? SizeBytes { get; set; }

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
            return this.Equals(input as AzureDiskInfo);
        }

        /// <summary>
        /// Returns true if AzureDiskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureDiskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureDiskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsOsDisk == input.IsOsDisk ||
                    (this.IsOsDisk != null &&
                    this.IsOsDisk.Equals(input.IsOsDisk))
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
                if (this.IsOsDisk != null)
                    hashCode = hashCode * 59 + this.IsOsDisk.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

