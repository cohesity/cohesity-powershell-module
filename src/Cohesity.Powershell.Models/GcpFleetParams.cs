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
    /// Specifies various resources when deploying a Fleet instance on GCP.
    /// </summary>
    [DataContract]
    public partial class GcpFleetParams :  IEquatable<GcpFleetParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpFleetParams" /> class.
        /// </summary>
        /// <param name="fleetNetworkTags">Specifies the network tag information for the fleet..</param>
        /// <param name="gcpFleetNetworkParamsList">Specifies the priority list of network params for the fleet..</param>
        public GcpFleetParams(List<string> fleetNetworkTags = default(List<string>), List<GcpFleetNetworkParams> gcpFleetNetworkParamsList = default(List<GcpFleetNetworkParams>))
        {
            this.FleetNetworkTags = fleetNetworkTags;
            this.GcpFleetNetworkParamsList = gcpFleetNetworkParamsList;
            this.FleetNetworkTags = fleetNetworkTags;
            this.GcpFleetNetworkParamsList = gcpFleetNetworkParamsList;
        }
        
        /// <summary>
        /// Specifies the network tag information for the fleet.
        /// </summary>
        /// <value>Specifies the network tag information for the fleet.</value>
        [DataMember(Name="fleetNetworkTags", EmitDefaultValue=true)]
        public List<string> FleetNetworkTags { get; set; }

        /// <summary>
        /// Specifies the priority list of network params for the fleet.
        /// </summary>
        /// <value>Specifies the priority list of network params for the fleet.</value>
        [DataMember(Name="gcpFleetNetworkParamsList", EmitDefaultValue=true)]
        public List<GcpFleetNetworkParams> GcpFleetNetworkParamsList { get; set; }

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
            return this.Equals(input as GcpFleetParams);
        }

        /// <summary>
        /// Returns true if GcpFleetParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpFleetParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpFleetParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FleetNetworkTags == input.FleetNetworkTags ||
                    this.FleetNetworkTags != null &&
                    input.FleetNetworkTags != null &&
                    this.FleetNetworkTags.SequenceEqual(input.FleetNetworkTags)
                ) && 
                (
                    this.GcpFleetNetworkParamsList == input.GcpFleetNetworkParamsList ||
                    this.GcpFleetNetworkParamsList != null &&
                    input.GcpFleetNetworkParamsList != null &&
                    this.GcpFleetNetworkParamsList.SequenceEqual(input.GcpFleetNetworkParamsList)
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
                if (this.FleetNetworkTags != null)
                    hashCode = hashCode * 59 + this.FleetNetworkTags.GetHashCode();
                if (this.GcpFleetNetworkParamsList != null)
                    hashCode = hashCode * 59 + this.GcpFleetNetworkParamsList.GetHashCode();
                return hashCode;
            }
        }

    }

}

