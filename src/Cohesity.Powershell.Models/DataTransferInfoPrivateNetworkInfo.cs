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
    /// DataTransferInfoPrivateNetworkInfo
    /// </summary>
    [DataContract]
    public partial class DataTransferInfoPrivateNetworkInfo :  IEquatable<DataTransferInfoPrivateNetworkInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferInfoPrivateNetworkInfo" /> class.
        /// </summary>
        /// <param name="location">Region/location of the virtual network..</param>
        /// <param name="region">region.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="vpn">vpn.</param>
        public DataTransferInfoPrivateNetworkInfo(string location = default(string), EntityProto region = default(EntityProto), EntityProto subnet = default(EntityProto), EntityProto vpn = default(EntityProto))
        {
            this.Location = location;
            this.Location = location;
            this.Region = region;
            this.Subnet = subnet;
            this.Vpn = vpn;
        }
        
        /// <summary>
        /// Region/location of the virtual network.
        /// </summary>
        /// <value>Region/location of the virtual network.</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public EntityProto Region { get; set; }

        /// <summary>
        /// Gets or Sets Subnet
        /// </summary>
        [DataMember(Name="subnet", EmitDefaultValue=false)]
        public EntityProto Subnet { get; set; }

        /// <summary>
        /// Gets or Sets Vpn
        /// </summary>
        [DataMember(Name="vpn", EmitDefaultValue=false)]
        public EntityProto Vpn { get; set; }

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
            return this.Equals(input as DataTransferInfoPrivateNetworkInfo);
        }

        /// <summary>
        /// Returns true if DataTransferInfoPrivateNetworkInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferInfoPrivateNetworkInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferInfoPrivateNetworkInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
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
                    this.Vpn == input.Vpn ||
                    (this.Vpn != null &&
                    this.Vpn.Equals(input.Vpn))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.Vpn != null)
                    hashCode = hashCode * 59 + this.Vpn.GetHashCode();
                return hashCode;
            }
        }

    }

}

