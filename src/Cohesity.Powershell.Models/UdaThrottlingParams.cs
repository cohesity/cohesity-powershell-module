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
    /// UdaThrottlingParams
    /// </summary>
    [DataContract]
    public partial class UdaThrottlingParams :  IEquatable<UdaThrottlingParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaThrottlingParams" /> class.
        /// </summary>
        /// <param name="maxAnyjobResources">Max source specific resource to use for any job on source. Total resource usage should not exceed this for all jobs on source..</param>
        /// <param name="maxBackupResources">Max source specific resource to use for backup on source..</param>
        /// <param name="maxLogBackupResources">Max source specific resource to use for log backup on source..</param>
        /// <param name="maxRestoreResources">Max source specific resource to use for restore on source..</param>
        public UdaThrottlingParams(int? maxAnyjobResources = default(int?), int? maxBackupResources = default(int?), int? maxLogBackupResources = default(int?), int? maxRestoreResources = default(int?))
        {
            this.MaxAnyjobResources = maxAnyjobResources;
            this.MaxBackupResources = maxBackupResources;
            this.MaxLogBackupResources = maxLogBackupResources;
            this.MaxRestoreResources = maxRestoreResources;
            this.MaxAnyjobResources = maxAnyjobResources;
            this.MaxBackupResources = maxBackupResources;
            this.MaxLogBackupResources = maxLogBackupResources;
            this.MaxRestoreResources = maxRestoreResources;
        }
        
        /// <summary>
        /// Max source specific resource to use for any job on source. Total resource usage should not exceed this for all jobs on source.
        /// </summary>
        /// <value>Max source specific resource to use for any job on source. Total resource usage should not exceed this for all jobs on source.</value>
        [DataMember(Name="maxAnyjobResources", EmitDefaultValue=true)]
        public int? MaxAnyjobResources { get; set; }

        /// <summary>
        /// Max source specific resource to use for backup on source.
        /// </summary>
        /// <value>Max source specific resource to use for backup on source.</value>
        [DataMember(Name="maxBackupResources", EmitDefaultValue=true)]
        public int? MaxBackupResources { get; set; }

        /// <summary>
        /// Max source specific resource to use for log backup on source.
        /// </summary>
        /// <value>Max source specific resource to use for log backup on source.</value>
        [DataMember(Name="maxLogBackupResources", EmitDefaultValue=true)]
        public int? MaxLogBackupResources { get; set; }

        /// <summary>
        /// Max source specific resource to use for restore on source.
        /// </summary>
        /// <value>Max source specific resource to use for restore on source.</value>
        [DataMember(Name="maxRestoreResources", EmitDefaultValue=true)]
        public int? MaxRestoreResources { get; set; }

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
            return this.Equals(input as UdaThrottlingParams);
        }

        /// <summary>
        /// Returns true if UdaThrottlingParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaThrottlingParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaThrottlingParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxAnyjobResources == input.MaxAnyjobResources ||
                    (this.MaxAnyjobResources != null &&
                    this.MaxAnyjobResources.Equals(input.MaxAnyjobResources))
                ) && 
                (
                    this.MaxBackupResources == input.MaxBackupResources ||
                    (this.MaxBackupResources != null &&
                    this.MaxBackupResources.Equals(input.MaxBackupResources))
                ) && 
                (
                    this.MaxLogBackupResources == input.MaxLogBackupResources ||
                    (this.MaxLogBackupResources != null &&
                    this.MaxLogBackupResources.Equals(input.MaxLogBackupResources))
                ) && 
                (
                    this.MaxRestoreResources == input.MaxRestoreResources ||
                    (this.MaxRestoreResources != null &&
                    this.MaxRestoreResources.Equals(input.MaxRestoreResources))
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
                if (this.MaxAnyjobResources != null)
                    hashCode = hashCode * 59 + this.MaxAnyjobResources.GetHashCode();
                if (this.MaxBackupResources != null)
                    hashCode = hashCode * 59 + this.MaxBackupResources.GetHashCode();
                if (this.MaxLogBackupResources != null)
                    hashCode = hashCode * 59 + this.MaxLogBackupResources.GetHashCode();
                if (this.MaxRestoreResources != null)
                    hashCode = hashCode * 59 + this.MaxRestoreResources.GetHashCode();
                return hashCode;
            }
        }

    }

}

