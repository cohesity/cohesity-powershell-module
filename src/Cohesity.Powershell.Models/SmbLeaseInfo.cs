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
    /// SmbLeaseInfo
    /// </summary>
    [DataContract]
    public partial class SmbLeaseInfo :  IEquatable<SmbLeaseInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbLeaseInfo" /> class.
        /// </summary>
        /// <param name="isBreaking">Whether lease break is in progress.</param>
        /// <param name="leaseBreakType">Lease type that is attempted to being broken..</param>
        /// <param name="leaseTye">Lease type granted for open..</param>
        public SmbLeaseInfo(bool? isBreaking = default(bool?), List<string> leaseBreakType = default(List<string>), List<string> leaseTye = default(List<string>))
        {
            this.IsBreaking = isBreaking;
            this.LeaseBreakType = leaseBreakType;
            this.LeaseTye = leaseTye;
            this.IsBreaking = isBreaking;
            this.LeaseBreakType = leaseBreakType;
            this.LeaseTye = leaseTye;
        }
        
        /// <summary>
        /// Whether lease break is in progress
        /// </summary>
        /// <value>Whether lease break is in progress</value>
        [DataMember(Name="isBreaking", EmitDefaultValue=true)]
        public bool? IsBreaking { get; set; }

        /// <summary>
        /// Lease type that is attempted to being broken.
        /// </summary>
        /// <value>Lease type that is attempted to being broken.</value>
        [DataMember(Name="leaseBreakType", EmitDefaultValue=true)]
        public List<string> LeaseBreakType { get; set; }

        /// <summary>
        /// Lease type granted for open.
        /// </summary>
        /// <value>Lease type granted for open.</value>
        [DataMember(Name="leaseTye", EmitDefaultValue=true)]
        public List<string> LeaseTye { get; set; }

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
            return this.Equals(input as SmbLeaseInfo);
        }

        /// <summary>
        /// Returns true if SmbLeaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbLeaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbLeaseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsBreaking == input.IsBreaking ||
                    (this.IsBreaking != null &&
                    this.IsBreaking.Equals(input.IsBreaking))
                ) && 
                (
                    this.LeaseBreakType == input.LeaseBreakType ||
                    this.LeaseBreakType != null &&
                    input.LeaseBreakType != null &&
                    this.LeaseBreakType.SequenceEqual(input.LeaseBreakType)
                ) && 
                (
                    this.LeaseTye == input.LeaseTye ||
                    this.LeaseTye != null &&
                    input.LeaseTye != null &&
                    this.LeaseTye.SequenceEqual(input.LeaseTye)
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
                if (this.IsBreaking != null)
                    hashCode = hashCode * 59 + this.IsBreaking.GetHashCode();
                if (this.LeaseBreakType != null)
                    hashCode = hashCode * 59 + this.LeaseBreakType.GetHashCode();
                if (this.LeaseTye != null)
                    hashCode = hashCode * 59 + this.LeaseTye.GetHashCode();
                return hashCode;
            }
        }

    }

}

