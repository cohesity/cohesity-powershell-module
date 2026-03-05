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
    /// Specifies the service instace statistics based on active alerts.
    /// </summary>
    [DataContract]
    public partial class InstanceAlertStats :  IEquatable<InstanceAlertStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceAlertStats" /> class.
        /// </summary>
        /// <param name="numHealthyInstances">Specifies the count of instances with no warning or critical alerts..</param>
        /// <param name="numInstancesWithCriticalAlerts">Specifies the count of instances with at least one critical alert..</param>
        /// <param name="numInstancesWithWarningAlerts">Specifies the count of instances with at least one warning category alert and no critical alerts..</param>
        public InstanceAlertStats(int? numHealthyInstances = default(int?), int? numInstancesWithCriticalAlerts = default(int?), int? numInstancesWithWarningAlerts = default(int?))
        {
            this.NumHealthyInstances = numHealthyInstances;
            this.NumInstancesWithCriticalAlerts = numInstancesWithCriticalAlerts;
            this.NumInstancesWithWarningAlerts = numInstancesWithWarningAlerts;
            this.NumHealthyInstances = numHealthyInstances;
            this.NumInstancesWithCriticalAlerts = numInstancesWithCriticalAlerts;
            this.NumInstancesWithWarningAlerts = numInstancesWithWarningAlerts;
        }
        
        /// <summary>
        /// Specifies the count of instances with no warning or critical alerts.
        /// </summary>
        /// <value>Specifies the count of instances with no warning or critical alerts.</value>
        [DataMember(Name="numHealthyInstances", EmitDefaultValue=true)]
        public int? NumHealthyInstances { get; set; }

        /// <summary>
        /// Specifies the count of instances with at least one critical alert.
        /// </summary>
        /// <value>Specifies the count of instances with at least one critical alert.</value>
        [DataMember(Name="numInstancesWithCriticalAlerts", EmitDefaultValue=true)]
        public int? NumInstancesWithCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of instances with at least one warning category alert and no critical alerts.
        /// </summary>
        /// <value>Specifies the count of instances with at least one warning category alert and no critical alerts.</value>
        [DataMember(Name="numInstancesWithWarningAlerts", EmitDefaultValue=true)]
        public int? NumInstancesWithWarningAlerts { get; set; }

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
            return this.Equals(input as InstanceAlertStats);
        }

        /// <summary>
        /// Returns true if InstanceAlertStats instances are equal
        /// </summary>
        /// <param name="input">Instance of InstanceAlertStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceAlertStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumHealthyInstances == input.NumHealthyInstances ||
                    (this.NumHealthyInstances != null &&
                    this.NumHealthyInstances.Equals(input.NumHealthyInstances))
                ) && 
                (
                    this.NumInstancesWithCriticalAlerts == input.NumInstancesWithCriticalAlerts ||
                    (this.NumInstancesWithCriticalAlerts != null &&
                    this.NumInstancesWithCriticalAlerts.Equals(input.NumInstancesWithCriticalAlerts))
                ) && 
                (
                    this.NumInstancesWithWarningAlerts == input.NumInstancesWithWarningAlerts ||
                    (this.NumInstancesWithWarningAlerts != null &&
                    this.NumInstancesWithWarningAlerts.Equals(input.NumInstancesWithWarningAlerts))
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
                if (this.NumHealthyInstances != null)
                    hashCode = hashCode * 59 + this.NumHealthyInstances.GetHashCode();
                if (this.NumInstancesWithCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumInstancesWithCriticalAlerts.GetHashCode();
                if (this.NumInstancesWithWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumInstancesWithWarningAlerts.GetHashCode();
                return hashCode;
            }
        }

    }

}

