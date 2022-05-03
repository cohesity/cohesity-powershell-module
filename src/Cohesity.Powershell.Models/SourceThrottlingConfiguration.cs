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
    /// Specifies the source side throttling configuration.
    /// </summary>
    [DataContract]
    public partial class SourceThrottlingConfiguration :  IEquatable<SourceThrottlingConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceThrottlingConfiguration" /> class.
        /// </summary>
        /// <param name="cpuThrottlingConfig">cpuThrottlingConfig.</param>
        /// <param name="networkThrottlingConfig">networkThrottlingConfig.</param>
        public SourceThrottlingConfiguration(ThrottlingConfiguration cpuThrottlingConfig = default(ThrottlingConfiguration), ThrottlingConfiguration networkThrottlingConfig = default(ThrottlingConfiguration))
        {
            this.CpuThrottlingConfig = cpuThrottlingConfig;
            this.NetworkThrottlingConfig = networkThrottlingConfig;
        }
        
        /// <summary>
        /// Gets or Sets CpuThrottlingConfig
        /// </summary>
        [DataMember(Name="cpuThrottlingConfig", EmitDefaultValue=false)]
        public ThrottlingConfiguration CpuThrottlingConfig { get; set; }

        /// <summary>
        /// Gets or Sets NetworkThrottlingConfig
        /// </summary>
        [DataMember(Name="networkThrottlingConfig", EmitDefaultValue=false)]
        public ThrottlingConfiguration NetworkThrottlingConfig { get; set; }

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
            return this.Equals(input as SourceThrottlingConfiguration);
        }

        /// <summary>
        /// Returns true if SourceThrottlingConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceThrottlingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceThrottlingConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CpuThrottlingConfig == input.CpuThrottlingConfig ||
                    (this.CpuThrottlingConfig != null &&
                    this.CpuThrottlingConfig.Equals(input.CpuThrottlingConfig))
                ) && 
                (
                    this.NetworkThrottlingConfig == input.NetworkThrottlingConfig ||
                    (this.NetworkThrottlingConfig != null &&
                    this.NetworkThrottlingConfig.Equals(input.NetworkThrottlingConfig))
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
                if (this.CpuThrottlingConfig != null)
                    hashCode = hashCode * 59 + this.CpuThrottlingConfig.GetHashCode();
                if (this.NetworkThrottlingConfig != null)
                    hashCode = hashCode * 59 + this.NetworkThrottlingConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

