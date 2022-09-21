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
    /// Specifies the unconfiguration of an IP.
    /// </summary>
    [DataContract]
    public partial class IpUnconfig :  IEquatable<IpUnconfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpUnconfig" /> class.
        /// </summary>
        /// <param name="interfaceName">The interface name..</param>
        /// <param name="ipFamily">IpFamily of this config..</param>
        /// <param name="nodeIds">Node ids..</param>
        public IpUnconfig(string interfaceName = default(string), int? ipFamily = default(int?), List<long> nodeIds = default(List<long>))
        {
            this.InterfaceName = interfaceName;
            this.IpFamily = ipFamily;
            this.NodeIds = nodeIds;
        }
        
        /// <summary>
        /// The interface name.
        /// </summary>
        /// <value>The interface name.</value>
        [DataMember(Name="interfaceName", EmitDefaultValue=true)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// IpFamily of this config.
        /// </summary>
        /// <value>IpFamily of this config.</value>
        [DataMember(Name="ipFamily", EmitDefaultValue=true)]
        public int? IpFamily { get; set; }

        /// <summary>
        /// Node ids.
        /// </summary>
        /// <value>Node ids.</value>
        [DataMember(Name="nodeIds", EmitDefaultValue=true)]
        public List<long> NodeIds { get; set; }

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
            return this.Equals(input as IpUnconfig);
        }

        /// <summary>
        /// Returns true if IpUnconfig instances are equal
        /// </summary>
        /// <param name="input">Instance of IpUnconfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpUnconfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InterfaceName == input.InterfaceName ||
                    (this.InterfaceName != null &&
                    this.InterfaceName.Equals(input.InterfaceName))
                ) && 
                (
                    this.IpFamily == input.IpFamily ||
                    (this.IpFamily != null &&
                    this.IpFamily.Equals(input.IpFamily))
                ) && 
                (
                    this.NodeIds == input.NodeIds ||
                    this.NodeIds != null &&
                    input.NodeIds != null &&
                    this.NodeIds.Equals(input.NodeIds)
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
                if (this.InterfaceName != null)
                    hashCode = hashCode * 59 + this.InterfaceName.GetHashCode();
                if (this.IpFamily != null)
                    hashCode = hashCode * 59 + this.IpFamily.GetHashCode();
                if (this.NodeIds != null)
                    hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

