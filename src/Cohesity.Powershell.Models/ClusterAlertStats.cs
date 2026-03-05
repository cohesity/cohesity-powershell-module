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
    /// Specifies the cluster statistics based on active alerts.
    /// </summary>
    [DataContract]
    public partial class ClusterAlertStats :  IEquatable<ClusterAlertStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterAlertStats" /> class.
        /// </summary>
        /// <param name="numClustersWithCriticalAlerts">Specifies the count of clusters with at least one critical alert..</param>
        /// <param name="numClustersWithWarningAlerts">Specifies the count of clusters with at least one warning category alert and no critical alerts..</param>
        /// <param name="numHealthyClusters">Specifies the count of clusters with no warning or critical alerts..</param>
        public ClusterAlertStats(int? numClustersWithCriticalAlerts = default(int?), int? numClustersWithWarningAlerts = default(int?), int? numHealthyClusters = default(int?))
        {
            this.NumClustersWithCriticalAlerts = numClustersWithCriticalAlerts;
            this.NumClustersWithWarningAlerts = numClustersWithWarningAlerts;
            this.NumHealthyClusters = numHealthyClusters;
            this.NumClustersWithCriticalAlerts = numClustersWithCriticalAlerts;
            this.NumClustersWithWarningAlerts = numClustersWithWarningAlerts;
            this.NumHealthyClusters = numHealthyClusters;
        }
        
        /// <summary>
        /// Specifies the count of clusters with at least one critical alert.
        /// </summary>
        /// <value>Specifies the count of clusters with at least one critical alert.</value>
        [DataMember(Name="numClustersWithCriticalAlerts", EmitDefaultValue=true)]
        public int? NumClustersWithCriticalAlerts { get; set; }

        /// <summary>
        /// Specifies the count of clusters with at least one warning category alert and no critical alerts.
        /// </summary>
        /// <value>Specifies the count of clusters with at least one warning category alert and no critical alerts.</value>
        [DataMember(Name="numClustersWithWarningAlerts", EmitDefaultValue=true)]
        public int? NumClustersWithWarningAlerts { get; set; }

        /// <summary>
        /// Specifies the count of clusters with no warning or critical alerts.
        /// </summary>
        /// <value>Specifies the count of clusters with no warning or critical alerts.</value>
        [DataMember(Name="numHealthyClusters", EmitDefaultValue=true)]
        public int? NumHealthyClusters { get; set; }

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
            return this.Equals(input as ClusterAlertStats);
        }

        /// <summary>
        /// Returns true if ClusterAlertStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterAlertStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterAlertStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumClustersWithCriticalAlerts == input.NumClustersWithCriticalAlerts ||
                    (this.NumClustersWithCriticalAlerts != null &&
                    this.NumClustersWithCriticalAlerts.Equals(input.NumClustersWithCriticalAlerts))
                ) && 
                (
                    this.NumClustersWithWarningAlerts == input.NumClustersWithWarningAlerts ||
                    (this.NumClustersWithWarningAlerts != null &&
                    this.NumClustersWithWarningAlerts.Equals(input.NumClustersWithWarningAlerts))
                ) && 
                (
                    this.NumHealthyClusters == input.NumHealthyClusters ||
                    (this.NumHealthyClusters != null &&
                    this.NumHealthyClusters.Equals(input.NumHealthyClusters))
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
                if (this.NumClustersWithCriticalAlerts != null)
                    hashCode = hashCode * 59 + this.NumClustersWithCriticalAlerts.GetHashCode();
                if (this.NumClustersWithWarningAlerts != null)
                    hashCode = hashCode * 59 + this.NumClustersWithWarningAlerts.GetHashCode();
                if (this.NumHealthyClusters != null)
                    hashCode = hashCode * 59 + this.NumHealthyClusters.GetHashCode();
                return hashCode;
            }
        }

    }

}

