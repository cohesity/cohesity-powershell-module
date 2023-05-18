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
    /// ThrottlingPolicyRegisteredSourceThrottlingConfig
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyRegisteredSourceThrottlingConfig :  IEquatable<ThrottlingPolicyRegisteredSourceThrottlingConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyRegisteredSourceThrottlingConfig" /> class.
        /// </summary>
        /// <param name="maxConcurrentBackups">maxConcurrentBackups.</param>
        /// <param name="nasThrottlingParams">nasThrottlingParams.</param>
        /// <param name="udaThrottlingParams">udaThrottlingParams.</param>
        public ThrottlingPolicyRegisteredSourceThrottlingConfig(int? maxConcurrentBackups = default(int?), NasThrottlingParams nasThrottlingParams = default(NasThrottlingParams), UdaThrottlingParams udaThrottlingParams = default(UdaThrottlingParams))
        {
            this.MaxConcurrentBackups = maxConcurrentBackups;
            this.MaxConcurrentBackups = maxConcurrentBackups;
            this.NasThrottlingParams = nasThrottlingParams;
            this.UdaThrottlingParams = udaThrottlingParams;
        }
        
        /// <summary>
        /// Gets or Sets MaxConcurrentBackups
        /// </summary>
        [DataMember(Name="maxConcurrentBackups", EmitDefaultValue=true)]
        public int? MaxConcurrentBackups { get; set; }

        /// <summary>
        /// Gets or Sets NasThrottlingParams
        /// </summary>
        [DataMember(Name="nasThrottlingParams", EmitDefaultValue=false)]
        public NasThrottlingParams NasThrottlingParams { get; set; }

        /// <summary>
        /// Gets or Sets UdaThrottlingParams
        /// </summary>
        [DataMember(Name="udaThrottlingParams", EmitDefaultValue=false)]
        public UdaThrottlingParams UdaThrottlingParams { get; set; }

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
            return this.Equals(input as ThrottlingPolicyRegisteredSourceThrottlingConfig);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyRegisteredSourceThrottlingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyRegisteredSourceThrottlingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyRegisteredSourceThrottlingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxConcurrentBackups == input.MaxConcurrentBackups ||
                    (this.MaxConcurrentBackups != null &&
                    this.MaxConcurrentBackups.Equals(input.MaxConcurrentBackups))
                ) && 
                (
                    this.NasThrottlingParams == input.NasThrottlingParams ||
                    (this.NasThrottlingParams != null &&
                    this.NasThrottlingParams.Equals(input.NasThrottlingParams))
                ) && 
                (
                    this.UdaThrottlingParams == input.UdaThrottlingParams ||
                    (this.UdaThrottlingParams != null &&
                    this.UdaThrottlingParams.Equals(input.UdaThrottlingParams))
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
                if (this.MaxConcurrentBackups != null)
                    hashCode = hashCode * 59 + this.MaxConcurrentBackups.GetHashCode();
                if (this.NasThrottlingParams != null)
                    hashCode = hashCode * 59 + this.NasThrottlingParams.GetHashCode();
                if (this.UdaThrottlingParams != null)
                    hashCode = hashCode * 59 + this.UdaThrottlingParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

