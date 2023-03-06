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
    /// Specifies the various network params for the fleet.
    /// </summary>
    [DataContract]
    public partial class FleetNetworkParams :  IEquatable<FleetNetworkParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetNetworkParams" /> class.
        /// </summary>
        /// <param name="region">Specifies the region for the fleet..</param>
        /// <param name="subnet">Specifies the subnet for the fleet..</param>
        /// <param name="vpc">Specifies the vpc for the fleet..</param>
        public FleetNetworkParams(string region = default(string), string subnet = default(string), string vpc = default(string))
        {
            this.Region = region;
            this.Subnet = subnet;
            this.Vpc = vpc;
            this.Region = region;
            this.Subnet = subnet;
            this.Vpc = vpc;
        }
        
        /// <summary>
        /// Specifies the region for the fleet.
        /// </summary>
        /// <value>Specifies the region for the fleet.</value>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public string Region { get; set; }

        /// <summary>
        /// Specifies the subnet for the fleet.
        /// </summary>
        /// <value>Specifies the subnet for the fleet.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public string Subnet { get; set; }

        /// <summary>
        /// Specifies the vpc for the fleet.
        /// </summary>
        /// <value>Specifies the vpc for the fleet.</value>
        [DataMember(Name="vpc", EmitDefaultValue=true)]
        public string Vpc { get; set; }

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
            return this.Equals(input as FleetNetworkParams);
        }

        /// <summary>
        /// Returns true if FleetNetworkParams instances are equal
        /// </summary>
        /// <param name="input">Instance of FleetNetworkParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FleetNetworkParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.Vpc == input.Vpc ||
                    (this.Vpc != null &&
                    this.Vpc.Equals(input.Vpc))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.Vpc != null)
                    hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                return hashCode;
            }
        }

    }

}

