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
    /// Specifies information about an Oracle Host.
    /// </summary>
    [DataContract]
    public partial class OracleHost :  IEquatable<OracleHost>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleHost" /> class.
        /// </summary>
        /// <param name="cpuCount">Specifies the count of CPU available on the host..</param>
        /// <param name="ipAddresses">Specifies the IP address of the host..</param>
        /// <param name="ports">Specifies ports available for this host..</param>
        /// <param name="sessions">Specifies multiple session configurations available for this host..</param>
        public OracleHost(int? cpuCount = default(int?), List<string> ipAddresses = default(List<string>), List<long> ports = default(List<long>), List<OracleSession> sessions = default(List<OracleSession>))
        {
            this.CpuCount = cpuCount;
            this.IpAddresses = ipAddresses;
            this.Ports = ports;
            this.Sessions = sessions;
            this.CpuCount = cpuCount;
            this.IpAddresses = ipAddresses;
            this.Ports = ports;
            this.Sessions = sessions;
        }
        
        /// <summary>
        /// Specifies the count of CPU available on the host.
        /// </summary>
        /// <value>Specifies the count of CPU available on the host.</value>
        [DataMember(Name="cpuCount", EmitDefaultValue=true)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Specifies the IP address of the host.
        /// </summary>
        /// <value>Specifies the IP address of the host.</value>
        [DataMember(Name="ipAddresses", EmitDefaultValue=true)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// Specifies ports available for this host.
        /// </summary>
        /// <value>Specifies ports available for this host.</value>
        [DataMember(Name="ports", EmitDefaultValue=true)]
        public List<long> Ports { get; set; }

        /// <summary>
        /// Specifies multiple session configurations available for this host.
        /// </summary>
        /// <value>Specifies multiple session configurations available for this host.</value>
        [DataMember(Name="sessions", EmitDefaultValue=true)]
        public List<OracleSession> Sessions { get; set; }

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
            return this.Equals(input as OracleHost);
        }

        /// <summary>
        /// Returns true if OracleHost instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleHost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleHost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CpuCount == input.CpuCount ||
                    (this.CpuCount != null &&
                    this.CpuCount.Equals(input.CpuCount))
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    this.IpAddresses != null &&
                    input.IpAddresses != null &&
                    this.IpAddresses.SequenceEqual(input.IpAddresses)
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.Sessions == input.Sessions ||
                    this.Sessions != null &&
                    input.Sessions != null &&
                    this.Sessions.SequenceEqual(input.Sessions)
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
                if (this.CpuCount != null)
                    hashCode = hashCode * 59 + this.CpuCount.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Sessions != null)
                    hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                return hashCode;
            }
        }

    }

}

