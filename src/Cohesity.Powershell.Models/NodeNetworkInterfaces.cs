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
    /// Specifies the network interfaces present on a specific Node in a Cluster.
    /// </summary>
    [DataContract]
    public partial class NodeNetworkInterfaces :  IEquatable<NodeNetworkInterfaces>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeNetworkInterfaces" /> class.
        /// </summary>
        /// <param name="chassisSerial">Specifies the serial number of Chassis..</param>
        /// <param name="id">Specifies the ID of the Node..</param>
        /// <param name="interfaces">Specifies the list of network interfaces present on this Node..</param>
        /// <param name="message">Specifies an optional message describing the result of the request pertaining to this Node..</param>
        /// <param name="slot">Specifies the slot number the Node is located in..</param>
        public NodeNetworkInterfaces(string chassisSerial = default(string), long? id = default(long?), List<NetworkInterface> interfaces = default(List<NetworkInterface>), string message = default(string), long? slot = default(long?))
        {
            this.ChassisSerial = chassisSerial;
            this.Id = id;
            this.Interfaces = interfaces;
            this.Message = message;
            this.Slot = slot;
            this.ChassisSerial = chassisSerial;
            this.Id = id;
            this.Interfaces = interfaces;
            this.Message = message;
            this.Slot = slot;
        }
        
        /// <summary>
        /// Specifies the serial number of Chassis.
        /// </summary>
        /// <value>Specifies the serial number of Chassis.</value>
        [DataMember(Name="chassisSerial", EmitDefaultValue=true)]
        public string ChassisSerial { get; set; }

        /// <summary>
        /// Specifies the ID of the Node.
        /// </summary>
        /// <value>Specifies the ID of the Node.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the list of network interfaces present on this Node.
        /// </summary>
        /// <value>Specifies the list of network interfaces present on this Node.</value>
        [DataMember(Name="interfaces", EmitDefaultValue=true)]
        public List<NetworkInterface> Interfaces { get; set; }

        /// <summary>
        /// Specifies an optional message describing the result of the request pertaining to this Node.
        /// </summary>
        /// <value>Specifies an optional message describing the result of the request pertaining to this Node.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies the slot number the Node is located in.
        /// </summary>
        /// <value>Specifies the slot number the Node is located in.</value>
        [DataMember(Name="slot", EmitDefaultValue=true)]
        public long? Slot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeNetworkInterfaces {\n");
            sb.Append("  ChassisSerial: ").Append(ChassisSerial).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as NodeNetworkInterfaces);
        }

        /// <summary>
        /// Returns true if NodeNetworkInterfaces instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeNetworkInterfaces to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeNetworkInterfaces input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChassisSerial == input.ChassisSerial ||
                    (this.ChassisSerial != null &&
                    this.ChassisSerial.Equals(input.ChassisSerial))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Interfaces == input.Interfaces ||
                    this.Interfaces != null &&
                    input.Interfaces != null &&
                    this.Interfaces.SequenceEqual(input.Interfaces)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Slot == input.Slot ||
                    (this.Slot != null &&
                    this.Slot.Equals(input.Slot))
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
                if (this.ChassisSerial != null)
                    hashCode = hashCode * 59 + this.ChassisSerial.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Interfaces != null)
                    hashCode = hashCode * 59 + this.Interfaces.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Slot != null)
                    hashCode = hashCode * 59 + this.Slot.GetHashCode();
                return hashCode;
            }
        }

    }

}
