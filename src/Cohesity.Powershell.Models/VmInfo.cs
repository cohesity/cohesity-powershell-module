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
    /// VmInfo specifies information of a VM.
    /// </summary>
    [DataContract]
    public partial class VmInfo :  IEquatable<VmInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmInfo" /> class.
        /// </summary>
        /// <param name="healthDetail">Specifies the reason if vm is unhealthy..</param>
        /// <param name="healthStatus">Specifies the current health status of the app instance..</param>
        /// <param name="name">Specifies name of the VM..</param>
        /// <param name="nodePorts">Specifies nodeports assigned to the vm..</param>
        public VmInfo(string healthDetail = default(string), int? healthStatus = default(int?), string name = default(string), List<NodePort> nodePorts = default(List<NodePort>))
        {
            this.HealthDetail = healthDetail;
            this.HealthStatus = healthStatus;
            this.Name = name;
            this.NodePorts = nodePorts;
            this.HealthDetail = healthDetail;
            this.HealthStatus = healthStatus;
            this.Name = name;
            this.NodePorts = nodePorts;
        }
        
        /// <summary>
        /// Specifies the reason if vm is unhealthy.
        /// </summary>
        /// <value>Specifies the reason if vm is unhealthy.</value>
        [DataMember(Name="healthDetail", EmitDefaultValue=true)]
        public string HealthDetail { get; set; }

        /// <summary>
        /// Specifies the current health status of the app instance.
        /// </summary>
        /// <value>Specifies the current health status of the app instance.</value>
        [DataMember(Name="healthStatus", EmitDefaultValue=true)]
        public int? HealthStatus { get; set; }

        /// <summary>
        /// Specifies name of the VM.
        /// </summary>
        /// <value>Specifies name of the VM.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies nodeports assigned to the vm.
        /// </summary>
        /// <value>Specifies nodeports assigned to the vm.</value>
        [DataMember(Name="nodePorts", EmitDefaultValue=true)]
        public List<NodePort> NodePorts { get; set; }

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
            return this.Equals(input as VmInfo);
        }

        /// <summary>
        /// Returns true if VmInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VmInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HealthDetail == input.HealthDetail ||
                    (this.HealthDetail != null &&
                    this.HealthDetail.Equals(input.HealthDetail))
                ) && 
                (
                    this.HealthStatus == input.HealthStatus ||
                    (this.HealthStatus != null &&
                    this.HealthStatus.Equals(input.HealthStatus))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NodePorts == input.NodePorts ||
                    this.NodePorts != null &&
                    input.NodePorts != null &&
                    this.NodePorts.Equals(input.NodePorts)
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
                if (this.HealthDetail != null)
                    hashCode = hashCode * 59 + this.HealthDetail.GetHashCode();
                if (this.HealthStatus != null)
                    hashCode = hashCode * 59 + this.HealthStatus.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodePorts != null)
                    hashCode = hashCode * 59 + this.NodePorts.GetHashCode();
                return hashCode;
            }
        }

    }

}

