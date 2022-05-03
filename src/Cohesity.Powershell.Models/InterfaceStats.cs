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
    /// InterfaceStats
    /// </summary>
    [DataContract]
    public partial class InterfaceStats :  IEquatable<InterfaceStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceStats" /> class.
        /// </summary>
        /// <param name="rxBytes">rxBytes.</param>
        /// <param name="rxDropped">rxDropped.</param>
        /// <param name="rxErrors">rxErrors.</param>
        /// <param name="rxPkts">Receive counters..</param>
        /// <param name="txBytes">txBytes.</param>
        /// <param name="txDropped">txDropped.</param>
        /// <param name="txErrors">txErrors.</param>
        /// <param name="txPkts">Transmit counters..</param>
        public InterfaceStats(long? rxBytes = default(long?), long? rxDropped = default(long?), long? rxErrors = default(long?), long? rxPkts = default(long?), long? txBytes = default(long?), long? txDropped = default(long?), long? txErrors = default(long?), long? txPkts = default(long?))
        {
            this.RxBytes = rxBytes;
            this.RxDropped = rxDropped;
            this.RxErrors = rxErrors;
            this.RxPkts = rxPkts;
            this.TxBytes = txBytes;
            this.TxDropped = txDropped;
            this.TxErrors = txErrors;
            this.TxPkts = txPkts;
        }
        
        /// <summary>
        /// Gets or Sets RxBytes
        /// </summary>
        [DataMember(Name="rxBytes", EmitDefaultValue=false)]
        public long? RxBytes { get; set; }

        /// <summary>
        /// Gets or Sets RxDropped
        /// </summary>
        [DataMember(Name="rxDropped", EmitDefaultValue=false)]
        public long? RxDropped { get; set; }

        /// <summary>
        /// Gets or Sets RxErrors
        /// </summary>
        [DataMember(Name="rxErrors", EmitDefaultValue=false)]
        public long? RxErrors { get; set; }

        /// <summary>
        /// Receive counters.
        /// </summary>
        /// <value>Receive counters.</value>
        [DataMember(Name="rxPkts", EmitDefaultValue=false)]
        public long? RxPkts { get; set; }

        /// <summary>
        /// Gets or Sets TxBytes
        /// </summary>
        [DataMember(Name="txBytes", EmitDefaultValue=false)]
        public long? TxBytes { get; set; }

        /// <summary>
        /// Gets or Sets TxDropped
        /// </summary>
        [DataMember(Name="txDropped", EmitDefaultValue=false)]
        public long? TxDropped { get; set; }

        /// <summary>
        /// Gets or Sets TxErrors
        /// </summary>
        [DataMember(Name="txErrors", EmitDefaultValue=false)]
        public long? TxErrors { get; set; }

        /// <summary>
        /// Transmit counters.
        /// </summary>
        /// <value>Transmit counters.</value>
        [DataMember(Name="txPkts", EmitDefaultValue=false)]
        public long? TxPkts { get; set; }

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
            return this.Equals(input as InterfaceStats);
        }

        /// <summary>
        /// Returns true if InterfaceStats instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RxBytes == input.RxBytes ||
                    (this.RxBytes != null &&
                    this.RxBytes.Equals(input.RxBytes))
                ) && 
                (
                    this.RxDropped == input.RxDropped ||
                    (this.RxDropped != null &&
                    this.RxDropped.Equals(input.RxDropped))
                ) && 
                (
                    this.RxErrors == input.RxErrors ||
                    (this.RxErrors != null &&
                    this.RxErrors.Equals(input.RxErrors))
                ) && 
                (
                    this.RxPkts == input.RxPkts ||
                    (this.RxPkts != null &&
                    this.RxPkts.Equals(input.RxPkts))
                ) && 
                (
                    this.TxBytes == input.TxBytes ||
                    (this.TxBytes != null &&
                    this.TxBytes.Equals(input.TxBytes))
                ) && 
                (
                    this.TxDropped == input.TxDropped ||
                    (this.TxDropped != null &&
                    this.TxDropped.Equals(input.TxDropped))
                ) && 
                (
                    this.TxErrors == input.TxErrors ||
                    (this.TxErrors != null &&
                    this.TxErrors.Equals(input.TxErrors))
                ) && 
                (
                    this.TxPkts == input.TxPkts ||
                    (this.TxPkts != null &&
                    this.TxPkts.Equals(input.TxPkts))
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
                if (this.RxBytes != null)
                    hashCode = hashCode * 59 + this.RxBytes.GetHashCode();
                if (this.RxDropped != null)
                    hashCode = hashCode * 59 + this.RxDropped.GetHashCode();
                if (this.RxErrors != null)
                    hashCode = hashCode * 59 + this.RxErrors.GetHashCode();
                if (this.RxPkts != null)
                    hashCode = hashCode * 59 + this.RxPkts.GetHashCode();
                if (this.TxBytes != null)
                    hashCode = hashCode * 59 + this.TxBytes.GetHashCode();
                if (this.TxDropped != null)
                    hashCode = hashCode * 59 + this.TxDropped.GetHashCode();
                if (this.TxErrors != null)
                    hashCode = hashCode * 59 + this.TxErrors.GetHashCode();
                if (this.TxPkts != null)
                    hashCode = hashCode * 59 + this.TxPkts.GetHashCode();
                return hashCode;
            }
        }

    }

}

