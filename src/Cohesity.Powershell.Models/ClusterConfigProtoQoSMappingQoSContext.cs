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
    /// QoSContext captures the properties that are relevant for QoS in a request. If a new field is added to QoSContext, cluster_config.h should be changed to enhance the hasher (QoSContextHash) and comparator (QoSContextEqual) for QoSContext.
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoQoSMappingQoSContext :  IEquatable<ClusterConfigProtoQoSMappingQoSContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoQoSMappingQoSContext" /> class.
        /// </summary>
        /// <param name="component">Component from which request is coming..</param>
        /// <param name="priority">Priority of a request..</param>
        /// <param name="type">type.</param>
        /// <param name="viewBoxId">View box id of a request..</param>
        /// <param name="viewId">View id of a request..</param>
        public ClusterConfigProtoQoSMappingQoSContext(int? component = default(int?), int? priority = default(int?), int? type = default(int?), long? viewBoxId = default(long?), long? viewId = default(long?))
        {
            this.Component = component;
            this.Priority = priority;
            this.Type = type;
            this.ViewBoxId = viewBoxId;
            this.ViewId = viewId;
        }
        
        /// <summary>
        /// Component from which request is coming.
        /// </summary>
        /// <value>Component from which request is coming.</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public int? Component { get; set; }

        /// <summary>
        /// Priority of a request.
        /// </summary>
        /// <value>Priority of a request.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// View box id of a request.
        /// </summary>
        /// <value>View box id of a request.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// View id of a request.
        /// </summary>
        /// <value>View id of a request.</value>
        [DataMember(Name="viewId", EmitDefaultValue=false)]
        public long? ViewId { get; set; }

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
            return this.Equals(input as ClusterConfigProtoQoSMappingQoSContext);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoQoSMappingQoSContext instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoQoSMappingQoSContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoQoSMappingQoSContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Component == input.Component ||
                    (this.Component != null &&
                    this.Component.Equals(input.Component))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
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
                if (this.Component != null)
                    hashCode = hashCode * 59 + this.Component.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                return hashCode;
            }
        }

    }

}

