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
    /// Specifies the active alert statistics details.
    /// </summary>
    [DataContract]
    public partial class ActiveAlertsStats :  IEquatable<ActiveAlertsStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveAlertsStats" /> class.
        /// </summary>
        /// <param name="numCriticalAlerts">Specifies the count of active critical Alerts..</param>
        /// <param name="numHardwareAlerts">Specifies the count of active hardware Alerts..</param>
        /// <param name="numHardwareCriticalAlerts">Specifies the count of active hardware critical Alerts..</param>
        /// <param name="numHardwareInfoAlerts">Specifies the count of active hardware info Alerts..</param>
        /// <param name="numHardwareWarningAlerts">Specifies the count of active hardware warning Alerts..</param>
        /// <param name="numInfoAlerts">Specifies the count of active info Alerts..</param>
        /// <param name="numServiceAlerts">Specifies the count of active service Alerts..</param>
        /// <param name="numServiceCriticalAlerts">Specifies the count of active service critical Alerts..</param>
        /// <param name="numServiceInfoAlerts">Specifies the count of active service info Alerts..</param>
        /// <param name="numServiceWarningAlerts">Specifies the count of active service warning Alerts..</param>
        /// <param name="numSoftwareAlerts">Specifies the count of active software Alerts..</param>
        /// <param name="numSoftwareCriticalAlerts">Specifies the count of active software critical Alerts..</param>
        /// <param name="numSoftwareInfoAlerts">Specifies the count of active software info Alerts..</param>
        /// <param name="numSoftwareWarningAlerts">Specifies the count of active software warning Alerts..</param>
        /// <param name="numWarningAlerts">Specifies the count of active warning Alerts..</param>
        public ActiveAlertsStats(long? numCriticalAlerts = default(long?), long? numHardwareAlerts = default(long?), long? numHardwareCriticalAlerts = default(long?), long? numHardwareInfoAlerts = default(long?), long? numHardwareWarningAlerts = default(long?), long? numInfoAlerts = default(long?), long? numServiceAlerts = default(long?), long? numServiceCriticalAlerts = default(long?), long? numServiceInfoAlerts = default(long?), long? numServiceWarningAlerts = default(long?), long? numSoftwareAlerts = default(long?), long? numSoftwareCriticalAlerts = default(long?), long? numSoftwareInfoAlerts = default(long?), long? numSoftwareWarningAlerts = default(long?), long? numWarningAlerts = default(long?))
        {
            this.NumCriticalAlerts = numCriticalAlerts;
            this.NumHardwareAlerts = numHardwareAlerts;
            this.NumHardwareCriticalAlerts = numHardwareCriticalAlerts;
            this.NumHardwareInfoAlerts = numHardwareInfoAlerts;
            this.NumHardwareWarningAlerts = numHardwareWarningAlerts;
            this.NumInfoAlerts = numInfoAlerts;
            this.NumServiceAlerts = numServiceAlerts;
            this.NumServiceCriticalAlerts = numServiceCriticalAlerts;
            this.NumServiceInfoAlerts = numServiceInfoAlerts;
            this.NumServiceWarningAlerts = numServiceWarningAlerts;
            this.NumSoftwareAlerts = numSoftwareAlerts;
            this.NumSoftwareCriticalAlerts = numSoftwareCriticalAlerts;
            this.NumSoftwareInfoAlerts = numSoftwareInfoAlerts;
            this.NumSoftwareWarningAlerts = numSoftwareWarningAlerts;
            this.NumWarningAlerts = numWarningAlerts;
            this.NumCriticalAlerts = numCriticalAlerts;
            this.NumHardwareAlerts = numHardwareAlerts;
            this.NumHardwareCriticalAlerts = numHardwareCriticalAlerts;
            this.NumHardwareInfoAlerts = numHardwareInfoAlerts;
            this.NumHardwareWarningAlerts = numHardwareWarningAlerts;
            this.NumInfoAlerts = numInfoAlerts;
            this.NumServiceAlerts = numServiceAlerts;
            this.NumServiceCriticalAlerts = numServiceCriticalAlerts;
            this.NumServiceInfoAlerts = numServiceInfoAlerts;
            this.NumServiceWarningAlerts = numServiceWarningAlerts;
            this.NumSoftwareAlerts = numSoftwareAlerts;
            this.NumSoftwareCriticalAlerts = numSoftwareCriticalAlerts;
            this.NumSoftwareInfoAlerts = numSoftwareInfoAlerts;
            this.NumSoftwareWarningAlerts = numSoftwareWarningAlerts;
            this.NumWarningAlerts = numWarningAlerts;
        }
        
        /// <summary>
        /// Specifies the count of active critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active critical Alerts.</value>
        [DataMember(Name="numCriticalAlerts", EmitDefaultValue=true)]
        public long? NumCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware Alerts.</value>
        [DataMember(Name="numHardwareAlerts", EmitDefaultValue=true)]
        public long? NumHardwareAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware critical Alerts.</value>
        [DataMember(Name="numHardwareCriticalAlerts", EmitDefaultValue=true)]
        public long? NumHardwareCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware info Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware info Alerts.</value>
        [DataMember(Name="numHardwareInfoAlerts", EmitDefaultValue=true)]
        public long? NumHardwareInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware warning Alerts.</value>
        [DataMember(Name="numHardwareWarningAlerts", EmitDefaultValue=true)]
        public long? NumHardwareWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active info Alerts.
        /// </summary>
        /// <value>Specifies the count of active info Alerts.</value>
        [DataMember(Name="numInfoAlerts", EmitDefaultValue=true)]
        public long? NumInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active service Alerts.
        /// </summary>
        /// <value>Specifies the count of active service Alerts.</value>
        [DataMember(Name="numServiceAlerts", EmitDefaultValue=true)]
        public long? NumServiceAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active service critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active service critical Alerts.</value>
        [DataMember(Name="numServiceCriticalAlerts", EmitDefaultValue=true)]
        public long? NumServiceCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active service info Alerts.
        /// </summary>
        /// <value>Specifies the count of active service info Alerts.</value>
        [DataMember(Name="numServiceInfoAlerts", EmitDefaultValue=true)]
        public long? NumServiceInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active service warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active service warning Alerts.</value>
        [DataMember(Name="numServiceWarningAlerts", EmitDefaultValue=true)]
        public long? NumServiceWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software Alerts.
        /// </summary>
        /// <value>Specifies the count of active software Alerts.</value>
        [DataMember(Name="numSoftwareAlerts", EmitDefaultValue=true)]
        public long? NumSoftwareAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active software critical Alerts.</value>
        [DataMember(Name="numSoftwareCriticalAlerts", EmitDefaultValue=true)]
        public long? NumSoftwareCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software info Alerts.
        /// </summary>
        /// <value>Specifies the count of active software info Alerts.</value>
        [DataMember(Name="numSoftwareInfoAlerts", EmitDefaultValue=true)]
        public long? NumSoftwareInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active software warning Alerts.</value>
        [DataMember(Name="numSoftwareWarningAlerts", EmitDefaultValue=true)]
        public long? NumSoftwareWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active warning Alerts.</value>
        [DataMember(Name="numWarningAlerts", EmitDefaultValue=true)]
        public long? NumWarningAlerts { get; set; }

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
            return this.Equals(input as ActiveAlertsStats);
        }

        /// <summary>
        /// Returns true if ActiveAlertsStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveAlertsStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveAlertsStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumCriticalAlerts == input.NumCriticalAlerts ||
                    (this.NumCriticalAlerts != null &&
                    this.NumCriticalAlerts.Equals(input.NumCriticalAlerts))
                ) && 
                (
                    this.NumHardwareAlerts == input.NumHardwareAlerts ||
                    (this.NumHardwareAlerts != null &&
                    this.NumHardwareAlerts.Equals(input.NumHardwareAlerts))
                ) && 
                (
                    this.NumHardwareCriticalAlerts == input.NumHardwareCriticalAlerts ||
                    (this.NumHardwareCriticalAlerts != null &&
                    this.NumHardwareCriticalAlerts.Equals(input.NumHardwareCriticalAlerts))
                ) && 
                (
                    this.NumHardwareInfoAlerts == input.NumHardwareInfoAlerts ||
                    (this.NumHardwareInfoAlerts != null &&
                    this.NumHardwareInfoAlerts.Equals(input.NumHardwareInfoAlerts))
                ) && 
                (
                    this.NumHardwareWarningAlerts == input.NumHardwareWarningAlerts ||
                    (this.NumHardwareWarningAlerts != null &&
                    this.NumHardwareWarningAlerts.Equals(input.NumHardwareWarningAlerts))
                ) && 
                (
                    this.NumInfoAlerts == input.NumInfoAlerts ||
                    (this.NumInfoAlerts != null &&
                    this.NumInfoAlerts.Equals(input.NumInfoAlerts))
                ) && 
                (
                    this.NumServiceAlerts == input.NumServiceAlerts ||
                    (this.NumServiceAlerts != null &&
                    this.NumServiceAlerts.Equals(input.NumServiceAlerts))
                ) && 
                (
                    this.NumServiceCriticalAlerts == input.NumServiceCriticalAlerts ||
                    (this.NumServiceCriticalAlerts != null &&
                    this.NumServiceCriticalAlerts.Equals(input.NumServiceCriticalAlerts))
                ) && 
                (
                    this.NumServiceInfoAlerts == input.NumServiceInfoAlerts ||
                    (this.NumServiceInfoAlerts != null &&
                    this.NumServiceInfoAlerts.Equals(input.NumServiceInfoAlerts))
                ) && 
                (
                    this.NumServiceWarningAlerts == input.NumServiceWarningAlerts ||
                    (this.NumServiceWarningAlerts != null &&
                    this.NumServiceWarningAlerts.Equals(input.NumServiceWarningAlerts))
                ) && 
                (
                    this.NumSoftwareAlerts == input.NumSoftwareAlerts ||
                    (this.NumSoftwareAlerts != null &&
                    this.NumSoftwareAlerts.Equals(input.NumSoftwareAlerts))
                ) && 
                (
                    this.NumSoftwareCriticalAlerts == input.NumSoftwareCriticalAlerts ||
                    (this.NumSoftwareCriticalAlerts != null &&
                    this.NumSoftwareCriticalAlerts.Equals(input.NumSoftwareCriticalAlerts))
                ) && 
                (
                    this.NumSoftwareInfoAlerts == input.NumSoftwareInfoAlerts ||
                    (this.NumSoftwareInfoAlerts != null &&
                    this.NumSoftwareInfoAlerts.Equals(input.NumSoftwareInfoAlerts))
                ) && 
                (
                    this.NumSoftwareWarningAlerts == input.NumSoftwareWarningAlerts ||
                    (this.NumSoftwareWarningAlerts != null &&
                    this.NumSoftwareWarningAlerts.Equals(input.NumSoftwareWarningAlerts))
                ) && 
                (
                    this.NumWarningAlerts == input.NumWarningAlerts ||
                    (this.NumWarningAlerts != null &&
                    this.NumWarningAlerts.Equals(input.NumWarningAlerts))
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
                if (this.NumCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumCriticalAlerts.GetHashCode();
                if (this.NumHardwareAlerts != null)
                    hashCode = hashCode * 59 + this.NumHardwareAlerts.GetHashCode();
                if (this.NumHardwareCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumHardwareCriticalAlerts.GetHashCode();
                if (this.NumHardwareInfoAlerts != null)
                    hashCode = hashCode * 59 + this.NumHardwareInfoAlerts.GetHashCode();
                if (this.NumHardwareWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumHardwareWarningAlerts.GetHashCode();
                if (this.NumInfoAlerts != null)
                    hashCode = hashCode * 59 + this.NumInfoAlerts.GetHashCode();
                if (this.NumServiceAlerts != null)
                    hashCode = hashCode * 59 + this.NumServiceAlerts.GetHashCode();
                if (this.NumServiceCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumServiceCriticalAlerts.GetHashCode();
                if (this.NumServiceInfoAlerts != null)
                    hashCode = hashCode * 59 + this.NumServiceInfoAlerts.GetHashCode();
                if (this.NumServiceWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumServiceWarningAlerts.GetHashCode();
                if (this.NumSoftwareAlerts != null)
                    hashCode = hashCode * 59 + this.NumSoftwareAlerts.GetHashCode();
                if (this.NumSoftwareCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumSoftwareCriticalAlerts.GetHashCode();
                if (this.NumSoftwareInfoAlerts != null)
                    hashCode = hashCode * 59 + this.NumSoftwareInfoAlerts.GetHashCode();
                if (this.NumSoftwareWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumSoftwareWarningAlerts.GetHashCode();
                if (this.NumWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumWarningAlerts.GetHashCode();
                return hashCode;
            }
        }

    }

}

