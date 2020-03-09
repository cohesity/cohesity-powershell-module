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
    /// AWSFleetParamsNetworkParams
    /// </summary>
    [DataContract]
    public partial class AWSFleetParamsNetworkParams :  IEquatable<AWSFleetParamsNetworkParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSFleetParamsNetworkParams" /> class.
        /// </summary>
        /// <param name="subnet">Subnet for the fleet..</param>
        /// <param name="vpc">VPC for the fleet..</param>
        public AWSFleetParamsNetworkParams(string subnet = default(string), string vpc = default(string))
        {
            this.Subnet = subnet;
            this.Vpc = vpc;
            this.Subnet = subnet;
            this.Vpc = vpc;
        }
        
        /// <summary>
        /// Subnet for the fleet.
        /// </summary>
        /// <value>Subnet for the fleet.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public string Subnet { get; set; }

        /// <summary>
        /// VPC for the fleet.
        /// </summary>
        /// <value>VPC for the fleet.</value>
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
            return this.Equals(input as AWSFleetParamsNetworkParams);
        }

        /// <summary>
        /// Returns true if AWSFleetParamsNetworkParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSFleetParamsNetworkParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSFleetParamsNetworkParams input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.Vpc != null)
                    hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                return hashCode;
            }
        }

    }

}

