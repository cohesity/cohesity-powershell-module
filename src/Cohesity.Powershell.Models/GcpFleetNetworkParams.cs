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
    /// GcpFleetNetworkParams
    /// </summary>
    [DataContract]
    public partial class GcpFleetNetworkParams :  IEquatable<GcpFleetNetworkParams>
    {
        /// <summary>
        /// Specifies the priority of the subnet type. Specifies the priority of the fleet subnet type for GCP. &#39;kPrimary&#39; implies first priority to subnet type. &#39;kSecondary&#39; implies second priority to subnet type. &#39;kTertiary&#39; implies third priority to subnet type.
        /// </summary>
        /// <value>Specifies the priority of the subnet type. Specifies the priority of the fleet subnet type for GCP. &#39;kPrimary&#39; implies first priority to subnet type. &#39;kSecondary&#39; implies second priority to subnet type. &#39;kTertiary&#39; implies third priority to subnet type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FleetSubnetPriorityEnum
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
        /// Specifies the priority of the subnet type. Specifies the priority of the fleet subnet type for GCP. &#39;kPrimary&#39; implies first priority to subnet type. &#39;kSecondary&#39; implies second priority to subnet type. &#39;kTertiary&#39; implies third priority to subnet type.
        /// </summary>
        /// <value>Specifies the priority of the subnet type. Specifies the priority of the fleet subnet type for GCP. &#39;kPrimary&#39; implies first priority to subnet type. &#39;kSecondary&#39; implies second priority to subnet type. &#39;kTertiary&#39; implies third priority to subnet type.</value>
        [DataMember(Name="fleetSubnetPriority", EmitDefaultValue=true)]
        public FleetSubnetPriorityEnum? FleetSubnetPriority { get; set; }
        /// <summary>
        /// Specifies the subnet type of the fleet. Specifies the type of the fleet subnet for GCP. &#39;kCluster&#39; implies same subnet as of Cluster (for CE and NGCE cluster). &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.
        /// </summary>
        /// <value>Specifies the subnet type of the fleet. Specifies the type of the fleet subnet for GCP. &#39;kCluster&#39; implies same subnet as of Cluster (for CE and NGCE cluster). &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.</value>
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
        /// Specifies the subnet type of the fleet. Specifies the type of the fleet subnet for GCP. &#39;kCluster&#39; implies same subnet as of Cluster (for CE and NGCE cluster). &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.
        /// </summary>
        /// <value>Specifies the subnet type of the fleet. Specifies the type of the fleet subnet for GCP. &#39;kCluster&#39; implies same subnet as of Cluster (for CE and NGCE cluster). &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet.</value>
        [DataMember(Name="fleetSubnetType", EmitDefaultValue=true)]
        public FleetSubnetTypeEnum? FleetSubnetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpFleetNetworkParams" /> class.
        /// </summary>
        /// <param name="fleetSubnetPriority">Specifies the priority of the subnet type. Specifies the priority of the fleet subnet type for GCP. &#39;kPrimary&#39; implies first priority to subnet type. &#39;kSecondary&#39; implies second priority to subnet type. &#39;kTertiary&#39; implies third priority to subnet type..</param>
        /// <param name="fleetSubnetType">Specifies the subnet type of the fleet. Specifies the type of the fleet subnet for GCP. &#39;kCluster&#39; implies same subnet as of Cluster (for CE and NGCE cluster). &#39;kSourceVM&#39; implies same subnet as of source vm. &#39;kCustom&#39; implies the custome subnet..</param>
        /// <param name="networkParamsList">Specifies the list of network params for the fleet..</param>
        public GcpFleetNetworkParams(FleetSubnetPriorityEnum? fleetSubnetPriority = default(FleetSubnetPriorityEnum?), FleetSubnetTypeEnum? fleetSubnetType = default(FleetSubnetTypeEnum?), List<FleetNetworkParams> networkParamsList = default(List<FleetNetworkParams>))
        {
            this.FleetSubnetPriority = fleetSubnetPriority;
            this.FleetSubnetType = fleetSubnetType;
            this.NetworkParamsList = networkParamsList;
            this.FleetSubnetPriority = fleetSubnetPriority;
            this.FleetSubnetType = fleetSubnetType;
            this.NetworkParamsList = networkParamsList;
        }
        
        /// <summary>
        /// Specifies the list of network params for the fleet.
        /// </summary>
        /// <value>Specifies the list of network params for the fleet.</value>
        [DataMember(Name="networkParamsList", EmitDefaultValue=true)]
        public List<FleetNetworkParams> NetworkParamsList { get; set; }

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
            return this.Equals(input as GcpFleetNetworkParams);
        }

        /// <summary>
        /// Returns true if GcpFleetNetworkParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpFleetNetworkParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpFleetNetworkParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FleetSubnetPriority == input.FleetSubnetPriority ||
                    this.FleetSubnetPriority.Equals(input.FleetSubnetPriority)
                ) && 
                (
                    this.FleetSubnetType == input.FleetSubnetType ||
                    this.FleetSubnetType.Equals(input.FleetSubnetType)
                ) && 
                (
                    this.NetworkParamsList == input.NetworkParamsList ||
                    this.NetworkParamsList != null &&
                    input.NetworkParamsList != null &&
                    this.NetworkParamsList.SequenceEqual(input.NetworkParamsList)
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
                hashCode = hashCode * 59 + this.FleetSubnetPriority.GetHashCode();
                hashCode = hashCode * 59 + this.FleetSubnetType.GetHashCode();
                if (this.NetworkParamsList != null)
                    hashCode = hashCode * 59 + this.NetworkParamsList.GetHashCode();
                return hashCode;
            }
        }

    }

}

