// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a request to upgrade the Cohesity agents on one or more Physical Servers registered on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class UpgradePhysicalServerAgents :  IEquatable<UpgradePhysicalServerAgents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradePhysicalServerAgents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpgradePhysicalServerAgents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradePhysicalServerAgents" /> class.
        /// </summary>
        /// <param name="agentIds">Specifies a list of agentIds associated with the Physical Servers to upgrade with the agent release currently available from the Cohesity Cluster. (required).</param>
        public UpgradePhysicalServerAgents(List<long?> agentIds = default(List<long?>))
        {
            // to ensure "agentIds" is required (not null)
            if (agentIds == null)
            {
                throw new InvalidDataException("agentIds is a required property for UpgradePhysicalServerAgents and cannot be null");
            }
            else
            {
                this.AgentIds = agentIds;
            }
        }
        
        /// <summary>
        /// Specifies a list of agentIds associated with the Physical Servers to upgrade with the agent release currently available from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies a list of agentIds associated with the Physical Servers to upgrade with the agent release currently available from the Cohesity Cluster.</value>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public List<long?> AgentIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as UpgradePhysicalServerAgents);
        }

        /// <summary>
        /// Returns true if UpgradePhysicalServerAgents instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradePhysicalServerAgents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradePhysicalServerAgents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentIds == input.AgentIds ||
                    this.AgentIds != null &&
                    this.AgentIds.SequenceEqual(input.AgentIds)
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
                if (this.AgentIds != null)
                    hashCode = hashCode * 59 + this.AgentIds.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

