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
        /// <param name="networkParamsMap">Map for a region to network params, as network params can be defined per region. Only set when kCustom fleet subnet type is being used..</param>
        /// <param name="networkParamsVec">Network information for the fleet. This will be only set when fleet_subnet_type is kCustom..</param>
        public AWSFleetParams(int? fleetSubnetType = default(int?), List<AWSFleetParamsTag> fleetTagVec = default(List<AWSFleetParamsTag>), AWSFleetParamsNetworkParams networkParams = default(AWSFleetParamsNetworkParams), List<AWSFleetParamsNetworkParamsMapEntry> networkParamsMap = default(List<AWSFleetParamsNetworkParamsMapEntry>), List<AWSFleetParamsNetworkParams> networkParamsVec = default(List<AWSFleetParamsNetworkParams>))
        {
            this.FleetSubnetType = fleetSubnetType;
            this.FleetTagVec = fleetTagVec;
            this.NetworkParamsMap = networkParamsMap;
            this.NetworkParamsVec = networkParamsVec;
            this.FleetSubnetType = fleetSubnetType;
            this.FleetTagVec = fleetTagVec;
            this.NetworkParams = networkParams;
            this.NetworkParamsMap = networkParamsMap;
            this.NetworkParamsVec = networkParamsVec;
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
        /// Map for a region to network params, as network params can be defined per region. Only set when kCustom fleet subnet type is being used.
        /// </summary>
        /// <value>Map for a region to network params, as network params can be defined per region. Only set when kCustom fleet subnet type is being used.</value>
        [DataMember(Name="networkParamsMap", EmitDefaultValue=true)]
        public List<AWSFleetParamsNetworkParamsMapEntry> NetworkParamsMap { get; set; }

        /// <summary>
        /// Network information for the fleet. This will be only set when fleet_subnet_type is kCustom.
        /// </summary>
        /// <value>Network information for the fleet. This will be only set when fleet_subnet_type is kCustom.</value>
        [DataMember(Name="networkParamsVec", EmitDefaultValue=true)]
        public List<AWSFleetParamsNetworkParams> NetworkParamsVec { get; set; }

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
                ) && 
                (
                    this.NetworkParamsMap == input.NetworkParamsMap ||
                    this.NetworkParamsMap != null &&
                    input.NetworkParamsMap != null &&
                    this.NetworkParamsMap.SequenceEqual(input.NetworkParamsMap)
                ) && 
                (
                    this.NetworkParamsVec == input.NetworkParamsVec ||
                    this.NetworkParamsVec != null &&
                    input.NetworkParamsVec != null &&
                    this.NetworkParamsVec.SequenceEqual(input.NetworkParamsVec)
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
                if (this.NetworkParamsMap != null)
                    hashCode = hashCode * 59 + this.NetworkParamsMap.GetHashCode();
                if (this.NetworkParamsVec != null)
                    hashCode = hashCode * 59 + this.NetworkParamsVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

