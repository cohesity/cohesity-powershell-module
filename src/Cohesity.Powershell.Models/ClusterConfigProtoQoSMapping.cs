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
    /// If a new enum value is added to either QoSMapping.Type or QoSPrincipal.Priority in a future version, direct upgrades must be disallowed from a pre-2.5 version to that version (without upgrading to 2.5 first). Contact nexus team for getting an appropriate restriction into the upgrade compatibility list.
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoQoSMapping :  IEquatable<ClusterConfigProtoQoSMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoQoSMapping" /> class.
        /// </summary>
        /// <param name="principalId">Principal id of the QoS principal to which qos_context maps to..</param>
        /// <param name="qosContext">qosContext.</param>
        public ClusterConfigProtoQoSMapping(long? principalId = default(long?), ClusterConfigProtoQoSMappingQoSContext qosContext = default(ClusterConfigProtoQoSMappingQoSContext))
        {
            this.PrincipalId = principalId;
            this.PrincipalId = principalId;
            this.QosContext = qosContext;
        }
        
        /// <summary>
        /// Principal id of the QoS principal to which qos_context maps to.
        /// </summary>
        /// <value>Principal id of the QoS principal to which qos_context maps to.</value>
        [DataMember(Name="principalId", EmitDefaultValue=true)]
        public long? PrincipalId { get; set; }

        /// <summary>
        /// Gets or Sets QosContext
        /// </summary>
        [DataMember(Name="qosContext", EmitDefaultValue=false)]
        public ClusterConfigProtoQoSMappingQoSContext QosContext { get; set; }

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
            return this.Equals(input as ClusterConfigProtoQoSMapping);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoQoSMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoQoSMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoQoSMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrincipalId == input.PrincipalId ||
                    (this.PrincipalId != null &&
                    this.PrincipalId.Equals(input.PrincipalId))
                ) && 
                (
                    this.QosContext == input.QosContext ||
                    (this.QosContext != null &&
                    this.QosContext.Equals(input.QosContext))
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
                if (this.PrincipalId != null)
                    hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                if (this.QosContext != null)
                    hashCode = hashCode * 59 + this.QosContext.GetHashCode();
                return hashCode;
            }
        }

    }

}

