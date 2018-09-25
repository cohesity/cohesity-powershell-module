// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// NodeSystemDiskInfo
    /// </summary>
    [DataContract]
    public partial class NodeSystemDiskInfo :  IEquatable<NodeSystemDiskInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeSystemDiskInfo" /> class.
        /// </summary>
        /// <param name="devicePath">DevicePath is the device path of the disk..</param>
        /// <param name="id">Id is the id of the disk..</param>
        /// <param name="offline">Offline specifies whether a disk is marked offline..</param>
        public NodeSystemDiskInfo(string devicePath = default(string), long? id = default(long?), bool? offline = default(bool?))
        {
            this.DevicePath = devicePath;
            this.Id = id;
            this.Offline = offline;
        }
        
        /// <summary>
        /// DevicePath is the device path of the disk.
        /// </summary>
        /// <value>DevicePath is the device path of the disk.</value>
        [DataMember(Name="devicePath", EmitDefaultValue=false)]
        public string DevicePath { get; set; }

        /// <summary>
        /// Id is the id of the disk.
        /// </summary>
        /// <value>Id is the id of the disk.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Offline specifies whether a disk is marked offline.
        /// </summary>
        /// <value>Offline specifies whether a disk is marked offline.</value>
        [DataMember(Name="offline", EmitDefaultValue=false)]
        public bool? Offline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as NodeSystemDiskInfo);
        }

        /// <summary>
        /// Returns true if NodeSystemDiskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeSystemDiskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeSystemDiskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DevicePath == input.DevicePath ||
                    (this.DevicePath != null &&
                    this.DevicePath.Equals(input.DevicePath))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Offline == input.Offline ||
                    (this.Offline != null &&
                    this.Offline.Equals(input.Offline))
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
                if (this.DevicePath != null)
                    hashCode = hashCode * 59 + this.DevicePath.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Offline != null)
                    hashCode = hashCode * 59 + this.Offline.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

