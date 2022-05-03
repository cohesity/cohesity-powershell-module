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
    /// Specifies various resources when deploying a VM to Fleet instances.
    /// </summary>
    [DataContract]
    public partial class FleetParams :  IEquatable<FleetParams>
    {
        /// <summary>
        /// Specifies the subnet type of the fleet. Specifies the type of the fleet subnet. &#39;kCluster&#39; implies same subnet as of Cluster, valid only for Cloud Edition cluster. &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.
        /// </summary>
        /// <value>Specifies the subnet type of the fleet. Specifies the type of the fleet subnet. &#39;kCluster&#39; implies same subnet as of Cluster, valid only for Cloud Edition cluster. &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FleetSubnetTypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KSourceVM for value: kSourceVM
            /// </summary>
            [EnumMember(Value = "kSourceVM")]
            KSourceVM = 2,

            /// <summary>
            /// Enum KCustom for value: kCustom
            /// </summary>
            [EnumMember(Value = "kCustom")]
            KCustom = 3

        }

        /// <summary>
        /// Specifies the subnet type of the fleet. Specifies the type of the fleet subnet. &#39;kCluster&#39; implies same subnet as of Cluster, valid only for Cloud Edition cluster. &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.
        /// </summary>
        /// <value>Specifies the subnet type of the fleet. Specifies the type of the fleet subnet. &#39;kCluster&#39; implies same subnet as of Cluster, valid only for Cloud Edition cluster. &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.</value>
        [DataMember(Name="fleetSubnetType", EmitDefaultValue=false)]
        public FleetSubnetTypeEnum? FleetSubnetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetParams" /> class.
        /// </summary>
        /// <param name="fleetNetworkParams">fleetNetworkParams.</param>
        /// <param name="fleetSubnetType">Specifies the subnet type of the fleet. Specifies the type of the fleet subnet. &#39;kCluster&#39; implies same subnet as of Cluster, valid only for Cloud Edition cluster. &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet..</param>
        /// <param name="fleetTags">Specifies the tag information for the fleet..</param>
        public FleetParams(FleetNetworkParams fleetNetworkParams = default(FleetNetworkParams), FleetSubnetTypeEnum? fleetSubnetType = default(FleetSubnetTypeEnum?), List<FleetTag> fleetTags = default(List<FleetTag>))
        {
            this.FleetNetworkParams = fleetNetworkParams;
            this.FleetSubnetType = fleetSubnetType;
            this.FleetTags = fleetTags;
        }
        
        /// <summary>
        /// Gets or Sets FleetNetworkParams
        /// </summary>
        [DataMember(Name="fleetNetworkParams", EmitDefaultValue=false)]
        public FleetNetworkParams FleetNetworkParams { get; set; }


        /// <summary>
        /// Specifies the tag information for the fleet.
        /// </summary>
        /// <value>Specifies the tag information for the fleet.</value>
        [DataMember(Name="fleetTags", EmitDefaultValue=false)]
        public List<FleetTag> FleetTags { get; set; }

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
            return this.Equals(input as FleetParams);
        }

        /// <summary>
        /// Returns true if FleetParams instances are equal
        /// </summary>
        /// <param name="input">Instance of FleetParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FleetParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FleetNetworkParams == input.FleetNetworkParams ||
                    (this.FleetNetworkParams != null &&
                    this.FleetNetworkParams.Equals(input.FleetNetworkParams))
                ) && 
                (
                    this.FleetSubnetType == input.FleetSubnetType ||
                    (this.FleetSubnetType != null &&
                    this.FleetSubnetType.Equals(input.FleetSubnetType))
                ) && 
                (
                    this.FleetTags == input.FleetTags ||
                    this.FleetTags != null &&
                    this.FleetTags.Equals(input.FleetTags)
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
                if (this.FleetNetworkParams != null)
                    hashCode = hashCode * 59 + this.FleetNetworkParams.GetHashCode();
                if (this.FleetSubnetType != null)
                    hashCode = hashCode * 59 + this.FleetSubnetType.GetHashCode();
                if (this.FleetTags != null)
                    hashCode = hashCode * 59 + this.FleetTags.GetHashCode();
                return hashCode;
            }
        }

    }

}

