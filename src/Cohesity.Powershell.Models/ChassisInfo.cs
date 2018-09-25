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
    /// ChassisInfo
    /// </summary>
    [DataContract]
    public partial class ChassisInfo :  IEquatable<ChassisInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChassisInfo" /> class.
        /// </summary>
        /// <param name="chassisId">ChassisId is a unique id assigned to the chassis..</param>
        /// <param name="chassisName">ChassisName is the name of the chassis. This could be the chassis serial number..</param>
        /// <param name="location">Location is the location of the chassis within the rack..</param>
        /// <param name="rackId">Rack is the rack within which this chassis lives..</param>
        public ChassisInfo(long? chassisId = default(long?), string chassisName = default(string), string location = default(string), long? rackId = default(long?))
        {
            this.ChassisId = chassisId;
            this.ChassisName = chassisName;
            this.Location = location;
            this.RackId = rackId;
        }
        
        /// <summary>
        /// ChassisId is a unique id assigned to the chassis.
        /// </summary>
        /// <value>ChassisId is a unique id assigned to the chassis.</value>
        [DataMember(Name="chassisId", EmitDefaultValue=false)]
        public long? ChassisId { get; set; }

        /// <summary>
        /// ChassisName is the name of the chassis. This could be the chassis serial number.
        /// </summary>
        /// <value>ChassisName is the name of the chassis. This could be the chassis serial number.</value>
        [DataMember(Name="chassisName", EmitDefaultValue=false)]
        public string ChassisName { get; set; }

        /// <summary>
        /// Location is the location of the chassis within the rack.
        /// </summary>
        /// <value>Location is the location of the chassis within the rack.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Rack is the rack within which this chassis lives.
        /// </summary>
        /// <value>Rack is the rack within which this chassis lives.</value>
        [DataMember(Name="rackId", EmitDefaultValue=false)]
        public long? RackId { get; set; }

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
            return this.Equals(input as ChassisInfo);
        }

        /// <summary>
        /// Returns true if ChassisInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ChassisInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChassisInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChassisId == input.ChassisId ||
                    (this.ChassisId != null &&
                    this.ChassisId.Equals(input.ChassisId))
                ) && 
                (
                    this.ChassisName == input.ChassisName ||
                    (this.ChassisName != null &&
                    this.ChassisName.Equals(input.ChassisName))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.RackId == input.RackId ||
                    (this.RackId != null &&
                    this.RackId.Equals(input.RackId))
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
                if (this.ChassisId != null)
                    hashCode = hashCode * 59 + this.ChassisId.GetHashCode();
                if (this.ChassisName != null)
                    hashCode = hashCode * 59 + this.ChassisName.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.RackId != null)
                    hashCode = hashCode * 59 + this.RackId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

