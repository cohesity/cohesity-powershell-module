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
        /// <param name="numCriticalAlerts">Specifies the count of active critical Alerts excluding alerts that belong to other bucket..</param>
        /// <param name="numCriticalAlertsCategories">Specifies the count of active critical alerts categories..</param>
        /// <param name="numDataServiceAlerts">Specifies the count of active service Alerts..</param>
        /// <param name="numDataServiceCriticalAlerts">Specifies the count of active service critical Alerts..</param>
        /// <param name="numDataServiceInfoAlerts">Specifies the count of active service info Alerts..</param>
        /// <param name="numDataServiceWarningAlerts">Specifies the count of active service warning Alerts..</param>
        /// <param name="numHardwareAlerts">Specifies the count of active hardware Alerts..</param>
        /// <param name="numHardwareCriticalAlerts">Specifies the count of active hardware critical Alerts..</param>
        /// <param name="numHardwareInfoAlerts">Specifies the count of active hardware info Alerts..</param>
        /// <param name="numHardwareWarningAlerts">Specifies the count of active hardware warning Alerts..</param>
        /// <param name="numInfoAlerts">Specifies the count of active info Alerts excluding alerts that belong to other bucket..</param>
        /// <param name="numInfoAlertsCategories">Specifies the count of active info alerts categories..</param>
        /// <param name="numMaintenanceAlerts">Specifies the count of active Alerts of maintenance bucket.</param>
        /// <param name="numMaintenanceCriticalAlerts">Specifies the count of active other critical Alerts..</param>
        /// <param name="numMaintenanceInfoAlerts">Specifies the count of active other info Alerts..</param>
        /// <param name="numMaintenanceWarningAlerts">Specifies the count of active other warning Alerts..</param>
        /// <param name="numSoftwareAlerts">Specifies the count of active software Alerts..</param>
        /// <param name="numSoftwareCriticalAlerts">Specifies the count of active software critical Alerts..</param>
        /// <param name="numSoftwareInfoAlerts">Specifies the count of active software info Alerts..</param>
        /// <param name="numSoftwareWarningAlerts">Specifies the count of active software warning Alerts..</param>
        /// <param name="numWarningAlerts">Specifies the count of active warning Alerts excluding alerts that belong to other bucket..</param>
        /// <param name="numWarningAlertsCategories">Specifies the count of active warning alerts categories..</param>
        public ActiveAlertsStats(long? numCriticalAlerts = default(long?), long? numCriticalAlertsCategories = default(long?), long? numDataServiceAlerts = default(long?), long? numDataServiceCriticalAlerts = default(long?), long? numDataServiceInfoAlerts = default(long?), long? numDataServiceWarningAlerts = default(long?), long? numHardwareAlerts = default(long?), long? numHardwareCriticalAlerts = default(long?), long? numHardwareInfoAlerts = default(long?), long? numHardwareWarningAlerts = default(long?), long? numInfoAlerts = default(long?), long? numInfoAlertsCategories = default(long?), long? numMaintenanceAlerts = default(long?), long? numMaintenanceCriticalAlerts = default(long?), long? numMaintenanceInfoAlerts = default(long?), long? numMaintenanceWarningAlerts = default(long?), long? numSoftwareAlerts = default(long?), long? numSoftwareCriticalAlerts = default(long?), long? numSoftwareInfoAlerts = default(long?), long? numSoftwareWarningAlerts = default(long?), long? numWarningAlerts = default(long?), long? numWarningAlertsCategories = default(long?))
        {
            this.NumCriticalAlerts = numCriticalAlerts;
            this.NumCriticalAlertsCategories = numCriticalAlertsCategories;
            this.NumDataServiceAlerts = numDataServiceAlerts;
            this.NumDataServiceCriticalAlerts = numDataServiceCriticalAlerts;
            this.NumDataServiceInfoAlerts = numDataServiceInfoAlerts;
            this.NumDataServiceWarningAlerts = numDataServiceWarningAlerts;
            this.NumHardwareAlerts = numHardwareAlerts;
            this.NumHardwareCriticalAlerts = numHardwareCriticalAlerts;
            this.NumHardwareInfoAlerts = numHardwareInfoAlerts;
            this.NumHardwareWarningAlerts = numHardwareWarningAlerts;
            this.NumInfoAlerts = numInfoAlerts;
            this.NumInfoAlertsCategories = numInfoAlertsCategories;
            this.NumMaintenanceAlerts = numMaintenanceAlerts;
            this.NumMaintenanceCriticalAlerts = numMaintenanceCriticalAlerts;
            this.NumMaintenanceInfoAlerts = numMaintenanceInfoAlerts;
            this.NumMaintenanceWarningAlerts = numMaintenanceWarningAlerts;
            this.NumSoftwareAlerts = numSoftwareAlerts;
            this.NumSoftwareCriticalAlerts = numSoftwareCriticalAlerts;
            this.NumSoftwareInfoAlerts = numSoftwareInfoAlerts;
            this.NumSoftwareWarningAlerts = numSoftwareWarningAlerts;
            this.NumWarningAlerts = numWarningAlerts;
            this.NumWarningAlertsCategories = numWarningAlertsCategories;
        }
        
        /// <summary>
        /// Specifies the count of active critical Alerts excluding alerts that belong to other bucket.
        /// </summary>
        /// <value>Specifies the count of active critical Alerts excluding alerts that belong to other bucket.</value>
        [DataMember(Name="numCriticalAlerts", EmitDefaultValue=false)]
        public long? NumCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active critical alerts categories.
        /// </summary>
        /// <value>Specifies the count of active critical alerts categories.</value>
        [DataMember(Name="numCriticalAlertsCategories", EmitDefaultValue=false)]
        public long? NumCriticalAlertsCategories { get; set; }

        /// <summary>
        /// Specifies the count of active service Alerts.
        /// </summary>
        /// <value>Specifies the count of active service Alerts.</value>
        [DataMember(Name="numDataServiceAlerts", EmitDefaultValue=false)]
        public long? NumDataServiceAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active service critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active service critical Alerts.</value>
        [DataMember(Name="numDataServiceCriticalAlerts", EmitDefaultValue=false)]
        public long? NumDataServiceCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active service info Alerts.
        /// </summary>
        /// <value>Specifies the count of active service info Alerts.</value>
        [DataMember(Name="numDataServiceInfoAlerts", EmitDefaultValue=false)]
        public long? NumDataServiceInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active service warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active service warning Alerts.</value>
        [DataMember(Name="numDataServiceWarningAlerts", EmitDefaultValue=false)]
        public long? NumDataServiceWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware Alerts.</value>
        [DataMember(Name="numHardwareAlerts", EmitDefaultValue=false)]
        public long? NumHardwareAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware critical Alerts.</value>
        [DataMember(Name="numHardwareCriticalAlerts", EmitDefaultValue=false)]
        public long? NumHardwareCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware info Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware info Alerts.</value>
        [DataMember(Name="numHardwareInfoAlerts", EmitDefaultValue=false)]
        public long? NumHardwareInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active hardware warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active hardware warning Alerts.</value>
        [DataMember(Name="numHardwareWarningAlerts", EmitDefaultValue=false)]
        public long? NumHardwareWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active info Alerts excluding alerts that belong to other bucket.
        /// </summary>
        /// <value>Specifies the count of active info Alerts excluding alerts that belong to other bucket.</value>
        [DataMember(Name="numInfoAlerts", EmitDefaultValue=false)]
        public long? NumInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active info alerts categories.
        /// </summary>
        /// <value>Specifies the count of active info alerts categories.</value>
        [DataMember(Name="numInfoAlertsCategories", EmitDefaultValue=false)]
        public long? NumInfoAlertsCategories { get; set; }

        /// <summary>
        /// Specifies the count of active Alerts of maintenance bucket
        /// </summary>
        /// <value>Specifies the count of active Alerts of maintenance bucket</value>
        [DataMember(Name="numMaintenanceAlerts", EmitDefaultValue=false)]
        public long? NumMaintenanceAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active other critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active other critical Alerts.</value>
        [DataMember(Name="numMaintenanceCriticalAlerts", EmitDefaultValue=false)]
        public long? NumMaintenanceCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active other info Alerts.
        /// </summary>
        /// <value>Specifies the count of active other info Alerts.</value>
        [DataMember(Name="numMaintenanceInfoAlerts", EmitDefaultValue=false)]
        public long? NumMaintenanceInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active other warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active other warning Alerts.</value>
        [DataMember(Name="numMaintenanceWarningAlerts", EmitDefaultValue=false)]
        public long? NumMaintenanceWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software Alerts.
        /// </summary>
        /// <value>Specifies the count of active software Alerts.</value>
        [DataMember(Name="numSoftwareAlerts", EmitDefaultValue=false)]
        public long? NumSoftwareAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software critical Alerts.
        /// </summary>
        /// <value>Specifies the count of active software critical Alerts.</value>
        [DataMember(Name="numSoftwareCriticalAlerts", EmitDefaultValue=false)]
        public long? NumSoftwareCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software info Alerts.
        /// </summary>
        /// <value>Specifies the count of active software info Alerts.</value>
        [DataMember(Name="numSoftwareInfoAlerts", EmitDefaultValue=false)]
        public long? NumSoftwareInfoAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active software warning Alerts.
        /// </summary>
        /// <value>Specifies the count of active software warning Alerts.</value>
        [DataMember(Name="numSoftwareWarningAlerts", EmitDefaultValue=false)]
        public long? NumSoftwareWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active warning Alerts excluding alerts that belong to other bucket.
        /// </summary>
        /// <value>Specifies the count of active warning Alerts excluding alerts that belong to other bucket.</value>
        [DataMember(Name="numWarningAlerts", EmitDefaultValue=false)]
        public long? NumWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of active warning alerts categories.
        /// </summary>
        /// <value>Specifies the count of active warning alerts categories.</value>
        [DataMember(Name="numWarningAlertsCategories", EmitDefaultValue=false)]
        public long? NumWarningAlertsCategories { get; set; }

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
                    this.NumCriticalAlertsCategories == input.NumCriticalAlertsCategories ||
                    (this.NumCriticalAlertsCategories != null &&
                    this.NumCriticalAlertsCategories.Equals(input.NumCriticalAlertsCategories))
                ) && 
                (
                    this.NumDataServiceAlerts == input.NumDataServiceAlerts ||
                    (this.NumDataServiceAlerts != null &&
                    this.NumDataServiceAlerts.Equals(input.NumDataServiceAlerts))
                ) && 
                (
                    this.NumDataServiceCriticalAlerts == input.NumDataServiceCriticalAlerts ||
                    (this.NumDataServiceCriticalAlerts != null &&
                    this.NumDataServiceCriticalAlerts.Equals(input.NumDataServiceCriticalAlerts))
                ) && 
                (
                    this.NumDataServiceInfoAlerts == input.NumDataServiceInfoAlerts ||
                    (this.NumDataServiceInfoAlerts != null &&
                    this.NumDataServiceInfoAlerts.Equals(input.NumDataServiceInfoAlerts))
                ) && 
                (
                    this.NumDataServiceWarningAlerts == input.NumDataServiceWarningAlerts ||
                    (this.NumDataServiceWarningAlerts != null &&
                    this.NumDataServiceWarningAlerts.Equals(input.NumDataServiceWarningAlerts))
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
                    this.NumInfoAlertsCategories == input.NumInfoAlertsCategories ||
                    (this.NumInfoAlertsCategories != null &&
                    this.NumInfoAlertsCategories.Equals(input.NumInfoAlertsCategories))
                ) && 
                (
                    this.NumMaintenanceAlerts == input.NumMaintenanceAlerts ||
                    (this.NumMaintenanceAlerts != null &&
                    this.NumMaintenanceAlerts.Equals(input.NumMaintenanceAlerts))
                ) && 
                (
                    this.NumMaintenanceCriticalAlerts == input.NumMaintenanceCriticalAlerts ||
                    (this.NumMaintenanceCriticalAlerts != null &&
                    this.NumMaintenanceCriticalAlerts.Equals(input.NumMaintenanceCriticalAlerts))
                ) && 
                (
                    this.NumMaintenanceInfoAlerts == input.NumMaintenanceInfoAlerts ||
                    (this.NumMaintenanceInfoAlerts != null &&
                    this.NumMaintenanceInfoAlerts.Equals(input.NumMaintenanceInfoAlerts))
                ) && 
                (
                    this.NumMaintenanceWarningAlerts == input.NumMaintenanceWarningAlerts ||
                    (this.NumMaintenanceWarningAlerts != null &&
                    this.NumMaintenanceWarningAlerts.Equals(input.NumMaintenanceWarningAlerts))
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
                ) && 
                (
                    this.NumWarningAlertsCategories == input.NumWarningAlertsCategories ||
                    (this.NumWarningAlertsCategories != null &&
                    this.NumWarningAlertsCategories.Equals(input.NumWarningAlertsCategories))
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
                if (this.NumCriticalAlertsCategories != null)
                    hashCode = hashCode * 59 + this.NumCriticalAlertsCategories.GetHashCode();
                if (this.NumDataServiceAlerts != null)
                    hashCode = hashCode * 59 + this.NumDataServiceAlerts.GetHashCode();
                if (this.NumDataServiceCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumDataServiceCriticalAlerts.GetHashCode();
                if (this.NumDataServiceInfoAlerts != null)
                    hashCode = hashCode * 59 + this.NumDataServiceInfoAlerts.GetHashCode();
                if (this.NumDataServiceWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumDataServiceWarningAlerts.GetHashCode();
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
                if (this.NumInfoAlertsCategories != null)
                    hashCode = hashCode * 59 + this.NumInfoAlertsCategories.GetHashCode();
                if (this.NumMaintenanceAlerts != null)
                    hashCode = hashCode * 59 + this.NumMaintenanceAlerts.GetHashCode();
                if (this.NumMaintenanceCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumMaintenanceCriticalAlerts.GetHashCode();
                if (this.NumMaintenanceInfoAlerts != null)
                    hashCode = hashCode * 59 + this.NumMaintenanceInfoAlerts.GetHashCode();
                if (this.NumMaintenanceWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumMaintenanceWarningAlerts.GetHashCode();
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
                if (this.NumWarningAlertsCategories != null)
                    hashCode = hashCode * 59 + this.NumWarningAlertsCategories.GetHashCode();
                return hashCode;
            }
        }

    }

}

