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
    /// Message to capture any additional backup params for a HyperV environment.
    /// </summary>
    [DataContract]
    public partial class HyperVBackupEnvParams :  IEquatable<HyperVBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperVBackupEnvParams" /> class.
        /// </summary>
        /// <param name="allowCrashConsistentSnapshot">Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails..</param>
        public HyperVBackupEnvParams(bool? allowCrashConsistentSnapshot = default(bool?))
        {
            this.AllowCrashConsistentSnapshot = allowCrashConsistentSnapshot;
            this.AllowCrashConsistentSnapshot = allowCrashConsistentSnapshot;
        }
        
        /// <summary>
        /// Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails.
        /// </summary>
        /// <value>Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails.</value>
        [DataMember(Name="allowCrashConsistentSnapshot", EmitDefaultValue=true)]
        public bool? AllowCrashConsistentSnapshot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperVBackupEnvParams {\n");
            sb.Append("  AllowCrashConsistentSnapshot: ").Append(AllowCrashConsistentSnapshot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as HyperVBackupEnvParams);
        }

        /// <summary>
        /// Returns true if HyperVBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HyperVBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperVBackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowCrashConsistentSnapshot == input.AllowCrashConsistentSnapshot ||
                    (this.AllowCrashConsistentSnapshot != null &&
                    this.AllowCrashConsistentSnapshot.Equals(input.AllowCrashConsistentSnapshot))
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
                if (this.AllowCrashConsistentSnapshot != null)
                    hashCode = hashCode * 59 + this.AllowCrashConsistentSnapshot.GetHashCode();
                return hashCode;
            }
        }

    }

}
