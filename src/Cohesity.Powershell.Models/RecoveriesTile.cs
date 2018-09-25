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
    /// RecoveriesTile
    /// </summary>
    [DataContract]
    public partial class RecoveriesTile :  IEquatable<RecoveriesTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveriesTile" /> class.
        /// </summary>
        /// <param name="lastMonthNumRecoveries">Number of Recoveries in the last 30 days..</param>
        /// <param name="lastMonthRecoveriesByType">lastMonthRecoveriesByType.</param>
        /// <param name="lastMonthRecoverySizeBytes">Bytes recovered in the last 30 days..</param>
        /// <param name="recoveryNumRunning">Number of recoveries that are currently running..</param>
        public RecoveriesTile(int? lastMonthNumRecoveries = default(int?), List<RestoreCountByObjectType> lastMonthRecoveriesByType = default(List<RestoreCountByObjectType>), long? lastMonthRecoverySizeBytes = default(long?), int? recoveryNumRunning = default(int?))
        {
            this.LastMonthNumRecoveries = lastMonthNumRecoveries;
            this.LastMonthRecoveriesByType = lastMonthRecoveriesByType;
            this.LastMonthRecoverySizeBytes = lastMonthRecoverySizeBytes;
            this.RecoveryNumRunning = recoveryNumRunning;
        }
        
        /// <summary>
        /// Number of Recoveries in the last 30 days.
        /// </summary>
        /// <value>Number of Recoveries in the last 30 days.</value>
        [DataMember(Name="lastMonthNumRecoveries", EmitDefaultValue=false)]
        public int? LastMonthNumRecoveries { get; set; }

        /// <summary>
        /// Gets or Sets LastMonthRecoveriesByType
        /// </summary>
        [DataMember(Name="lastMonthRecoveriesByType", EmitDefaultValue=false)]
        public List<RestoreCountByObjectType> LastMonthRecoveriesByType { get; set; }

        /// <summary>
        /// Bytes recovered in the last 30 days.
        /// </summary>
        /// <value>Bytes recovered in the last 30 days.</value>
        [DataMember(Name="lastMonthRecoverySizeBytes", EmitDefaultValue=false)]
        public long? LastMonthRecoverySizeBytes { get; set; }

        /// <summary>
        /// Number of recoveries that are currently running.
        /// </summary>
        /// <value>Number of recoveries that are currently running.</value>
        [DataMember(Name="recoveryNumRunning", EmitDefaultValue=false)]
        public int? RecoveryNumRunning { get; set; }

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
            return this.Equals(input as RecoveriesTile);
        }

        /// <summary>
        /// Returns true if RecoveriesTile instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoveriesTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoveriesTile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastMonthNumRecoveries == input.LastMonthNumRecoveries ||
                    (this.LastMonthNumRecoveries != null &&
                    this.LastMonthNumRecoveries.Equals(input.LastMonthNumRecoveries))
                ) && 
                (
                    this.LastMonthRecoveriesByType == input.LastMonthRecoveriesByType ||
                    this.LastMonthRecoveriesByType != null &&
                    this.LastMonthRecoveriesByType.SequenceEqual(input.LastMonthRecoveriesByType)
                ) && 
                (
                    this.LastMonthRecoverySizeBytes == input.LastMonthRecoverySizeBytes ||
                    (this.LastMonthRecoverySizeBytes != null &&
                    this.LastMonthRecoverySizeBytes.Equals(input.LastMonthRecoverySizeBytes))
                ) && 
                (
                    this.RecoveryNumRunning == input.RecoveryNumRunning ||
                    (this.RecoveryNumRunning != null &&
                    this.RecoveryNumRunning.Equals(input.RecoveryNumRunning))
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
                if (this.LastMonthNumRecoveries != null)
                    hashCode = hashCode * 59 + this.LastMonthNumRecoveries.GetHashCode();
                if (this.LastMonthRecoveriesByType != null)
                    hashCode = hashCode * 59 + this.LastMonthRecoveriesByType.GetHashCode();
                if (this.LastMonthRecoverySizeBytes != null)
                    hashCode = hashCode * 59 + this.LastMonthRecoverySizeBytes.GetHashCode();
                if (this.RecoveryNumRunning != null)
                    hashCode = hashCode * 59 + this.RecoveryNumRunning.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

