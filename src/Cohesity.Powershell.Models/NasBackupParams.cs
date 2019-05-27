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
    /// Message to capture any additional backup params for a NAS environment.
    /// </summary>
    [DataContract]
    public partial class NasBackupParams :  IEquatable<NasBackupParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasBackupParams" /> class.
        /// </summary>
        /// <param name="continueOnError">Whether the backup job should continue on errors for snapshot based backups. For non-snapshot-based generic NAS backup jobs, Magneto always continues on errors..</param>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        /// <param name="mixedModePreference">If the target entity is a mixed mode volume, which NAS protocol type the user prefer to backup. This does not apply to generic NAS and will be ignored..</param>
        /// <param name="snapshotChangeEnabled">Whether this backup job should utilize changelist like API when available for faster incremental backups..</param>
        public NasBackupParams(bool? continueOnError = default(bool?), FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto), int? mixedModePreference = default(int?), bool? snapshotChangeEnabled = default(bool?))
        {
            this.ContinueOnError = continueOnError;
            this.MixedModePreference = mixedModePreference;
            this.SnapshotChangeEnabled = snapshotChangeEnabled;
            this.ContinueOnError = continueOnError;
            this.FilteringPolicy = filteringPolicy;
            this.MixedModePreference = mixedModePreference;
            this.SnapshotChangeEnabled = snapshotChangeEnabled;
        }
        
        /// <summary>
        /// Whether the backup job should continue on errors for snapshot based backups. For non-snapshot-based generic NAS backup jobs, Magneto always continues on errors.
        /// </summary>
        /// <value>Whether the backup job should continue on errors for snapshot based backups. For non-snapshot-based generic NAS backup jobs, Magneto always continues on errors.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Gets or Sets FilteringPolicy
        /// </summary>
        [DataMember(Name="filteringPolicy", EmitDefaultValue=false)]
        public FilteringPolicyProto FilteringPolicy { get; set; }

        /// <summary>
        /// If the target entity is a mixed mode volume, which NAS protocol type the user prefer to backup. This does not apply to generic NAS and will be ignored.
        /// </summary>
        /// <value>If the target entity is a mixed mode volume, which NAS protocol type the user prefer to backup. This does not apply to generic NAS and will be ignored.</value>
        [DataMember(Name="mixedModePreference", EmitDefaultValue=true)]
        public int? MixedModePreference { get; set; }

        /// <summary>
        /// Whether this backup job should utilize changelist like API when available for faster incremental backups.
        /// </summary>
        /// <value>Whether this backup job should utilize changelist like API when available for faster incremental backups.</value>
        [DataMember(Name="snapshotChangeEnabled", EmitDefaultValue=true)]
        public bool? SnapshotChangeEnabled { get; set; }

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
            return this.Equals(input as NasBackupParams);
        }

        /// <summary>
        /// Returns true if NasBackupParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NasBackupParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasBackupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.FilteringPolicy == input.FilteringPolicy ||
                    (this.FilteringPolicy != null &&
                    this.FilteringPolicy.Equals(input.FilteringPolicy))
                ) && 
                (
                    this.MixedModePreference == input.MixedModePreference ||
                    (this.MixedModePreference != null &&
                    this.MixedModePreference.Equals(input.MixedModePreference))
                ) && 
                (
                    this.SnapshotChangeEnabled == input.SnapshotChangeEnabled ||
                    (this.SnapshotChangeEnabled != null &&
                    this.SnapshotChangeEnabled.Equals(input.SnapshotChangeEnabled))
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
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                if (this.MixedModePreference != null)
                    hashCode = hashCode * 59 + this.MixedModePreference.GetHashCode();
                if (this.SnapshotChangeEnabled != null)
                    hashCode = hashCode * 59 + this.SnapshotChangeEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}

