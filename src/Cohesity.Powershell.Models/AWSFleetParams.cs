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
    /// AWSFleetParams
    /// </summary>
    [DataContract]
    public partial class AWSFleetParams :  IEquatable<AWSFleetParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSFleetParams" /> class.
        /// </summary>
        /// <param name="fleetSubnetType">Fleet&#39;s subnet type. This field should always be set when specifying fleet params..</param>
        /// <param name="fleetTagVec">Optional list of tags to be associated with the fleets..</param>
        /// <param name="networkParams">networkParams.</param>
        public AWSFleetParams(int? fleetSubnetType = default(int?), List<AWSFleetParamsTag> fleetTagVec = default(List<AWSFleetParamsTag>), AWSFleetParamsNetworkParams networkParams = default(AWSFleetParamsNetworkParams))
        {
            this.FleetSubnetType = fleetSubnetType;
            this.FleetTagVec = fleetTagVec;
            this.FleetSubnetType = fleetSubnetType;
            this.FleetTagVec = fleetTagVec;
            this.NetworkParams = networkParams;
        }
        
        /// <summary>
        /// Fleet&#39;s subnet type. This field should always be set when specifying fleet params.
        /// </summary>
        /// <value>Fleet&#39;s subnet type. This field should always be set when specifying fleet params.</value>
        [DataMember(Name="fleetSubnetType", EmitDefaultValue=true)]
        public int? FleetSubnetType { get; set; }

        /// <summary>
        /// Optional list of tags to be associated with the fleets.
        /// </summary>
        /// <value>Optional list of tags to be associated with the fleets.</value>
        [DataMember(Name="fleetTagVec", EmitDefaultValue=true)]
        public List<AWSFleetParamsTag> FleetTagVec { get; set; }

        /// <summary>
        /// Gets or Sets NetworkParams
        /// </summary>
        [DataMember(Name="networkParams", EmitDefaultValue=false)]
        public AWSFleetParamsNetworkParams NetworkParams { get; set; }

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
            return this.Equals(input as AWSFleetParams);
        }

        /// <summary>
        /// Returns true if AWSFleetParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSFleetParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSFleetParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FleetSubnetType == input.FleetSubnetType ||
                    (this.FleetSubnetType != null &&
                    this.FleetSubnetType.Equals(input.FleetSubnetType))
                ) && 
                (
                    this.FleetTagVec == input.FleetTagVec ||
                    this.FleetTagVec != null &&
                    input.FleetTagVec != null &&
                    this.FleetTagVec.SequenceEqual(input.FleetTagVec)
                ) && 
                (
                    this.NetworkParams == input.NetworkParams ||
                    (this.NetworkParams != null &&
                    this.NetworkParams.Equals(input.NetworkParams))
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
                if (this.FleetSubnetType != null)
                    hashCode = hashCode * 59 + this.FleetSubnetType.GetHashCode();
                if (this.FleetTagVec != null)
                    hashCode = hashCode * 59 + this.FleetTagVec.GetHashCode();
                if (this.NetworkParams != null)
                    hashCode = hashCode * 59 + this.NetworkParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

