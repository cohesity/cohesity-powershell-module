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
    /// Specifies the parameters needed to expand a Cohesity Physical Edition Cluster.
    /// </summary>
    [DataContract]
    public partial class ExpandPhysicalClusterParameters :  IEquatable<ExpandPhysicalClusterParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpandPhysicalClusterParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpandPhysicalClusterParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpandPhysicalClusterParameters" /> class.
        /// </summary>
        /// <param name="chassisSerialToRackIdMap">ChassisSerialToRackId map..</param>
        /// <param name="nodeConfigs">Specifies the configuration details of the Nodes in the Cluster. (required).</param>
        /// <param name="vips">Specifies the virtual IPs to add to the Cluster..</param>
        public ExpandPhysicalClusterParameters(Dictionary<string, long> chassisSerialToRackIdMap = default(Dictionary<string, long>), List<PhysicalNodeConfiguration> nodeConfigs = default(List<PhysicalNodeConfiguration>), List<string> vips = default(List<string>))
        {
            this.ChassisSerialToRackIdMap = chassisSerialToRackIdMap;
            this.NodeConfigs = nodeConfigs;
            this.Vips = vips;
        }
        
        /// <summary>
        /// ChassisSerialToRackId map.
        /// </summary>
        /// <value>ChassisSerialToRackId map.</value>
        [DataMember(Name="chassisSerialToRackIdMap", EmitDefaultValue=true)]
        public Dictionary<string, long> ChassisSerialToRackIdMap { get; set; }

        /// <summary>
        /// Specifies the configuration details of the Nodes in the Cluster.
        /// </summary>
        /// <value>Specifies the configuration details of the Nodes in the Cluster.</value>
        [DataMember(Name="nodeConfigs", EmitDefaultValue=true)]
        public List<PhysicalNodeConfiguration> NodeConfigs { get; set; }

        /// <summary>
        /// Specifies the virtual IPs to add to the Cluster.
        /// </summary>
        /// <value>Specifies the virtual IPs to add to the Cluster.</value>
        [DataMember(Name="vips", EmitDefaultValue=true)]
        public List<string> Vips { get; set; }

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
            return this.Equals(input as ExpandPhysicalClusterParameters);
        }

        /// <summary>
        /// Returns true if ExpandPhysicalClusterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpandPhysicalClusterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpandPhysicalClusterParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChassisSerialToRackIdMap == input.ChassisSerialToRackIdMap ||
                    this.ChassisSerialToRackIdMap != null &&
                    input.ChassisSerialToRackIdMap != null &&
                    this.ChassisSerialToRackIdMap.Equals(input.ChassisSerialToRackIdMap)
                ) && 
                (
                    this.NodeConfigs == input.NodeConfigs ||
                    this.NodeConfigs != null &&
                    input.NodeConfigs != null &&
                    this.NodeConfigs.Equals(input.NodeConfigs)
                ) && 
                (
                    this.Vips == input.Vips ||
                    this.Vips != null &&
                    input.Vips != null &&
                    this.Vips.Equals(input.Vips)
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
                if (this.ChassisSerialToRackIdMap != null)
                    hashCode = hashCode * 59 + this.ChassisSerialToRackIdMap.GetHashCode();
                if (this.NodeConfigs != null)
                    hashCode = hashCode * 59 + this.NodeConfigs.GetHashCode();
                if (this.Vips != null)
                    hashCode = hashCode * 59 + this.Vips.GetHashCode();
                return hashCode;
            }
        }

    }

}

