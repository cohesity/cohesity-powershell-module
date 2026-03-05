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
    /// MaintenanceModeConfigProtoWorkflowInterventionSpec
    /// </summary>
    [DataContract]
    public partial class MaintenanceModeConfigProtoWorkflowInterventionSpec :  IEquatable<MaintenanceModeConfigProtoWorkflowInterventionSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaintenanceModeConfigProtoWorkflowInterventionSpec" /> class.
        /// </summary>
        /// <param name="intervention">intervention.</param>
        /// <param name="workflowType">workflowType.</param>
        public MaintenanceModeConfigProtoWorkflowInterventionSpec(int? intervention = default(int?), int? workflowType = default(int?))
        {
            this.Intervention = intervention;
            this.WorkflowType = workflowType;
            this.Intervention = intervention;
            this.WorkflowType = workflowType;
        }
        
        /// <summary>
        /// Gets or Sets Intervention
        /// </summary>
        [DataMember(Name="intervention", EmitDefaultValue=true)]
        public int? Intervention { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowType
        /// </summary>
        [DataMember(Name="workflowType", EmitDefaultValue=true)]
        public int? WorkflowType { get; set; }

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
            return this.Equals(input as MaintenanceModeConfigProtoWorkflowInterventionSpec);
        }

        /// <summary>
        /// Returns true if MaintenanceModeConfigProtoWorkflowInterventionSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of MaintenanceModeConfigProtoWorkflowInterventionSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaintenanceModeConfigProtoWorkflowInterventionSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Intervention == input.Intervention ||
                    (this.Intervention != null &&
                    this.Intervention.Equals(input.Intervention))
                ) && 
                (
                    this.WorkflowType == input.WorkflowType ||
                    (this.WorkflowType != null &&
                    this.WorkflowType.Equals(input.WorkflowType))
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
                if (this.Intervention != null)
                    hashCode = hashCode * 59 + this.Intervention.GetHashCode();
                if (this.WorkflowType != null)
                    hashCode = hashCode * 59 + this.WorkflowType.GetHashCode();
                return hashCode;
            }
        }

    }

}

