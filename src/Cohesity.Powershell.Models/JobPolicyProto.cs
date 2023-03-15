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
    /// A message that specifies the policies to use for a job.
    /// </summary>
    [DataContract]
    public partial class JobPolicyProto :  IEquatable<JobPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobPolicyProto" /> class.
        /// </summary>
        /// <param name="backupPolicy">backupPolicy.</param>
        /// <param name="snapshotTargetPolicyVec">Specifies additional policies that can be used to copy snapshots created by a backup run to different targets (such as a remote replica, tape etc). Each policy also specifies the retention policy that should be applied to the copied snapshots at the respective target..</param>
        public JobPolicyProto(BackupPolicyProto backupPolicy = default(BackupPolicyProto), List<SnapshotTargetPolicyProto> snapshotTargetPolicyVec = default(List<SnapshotTargetPolicyProto>))
        {
            this.SnapshotTargetPolicyVec = snapshotTargetPolicyVec;
            this.BackupPolicy = backupPolicy;
            this.SnapshotTargetPolicyVec = snapshotTargetPolicyVec;
        }
        
        /// <summary>
        /// Gets or Sets BackupPolicy
        /// </summary>
        [DataMember(Name="backupPolicy", EmitDefaultValue=false)]
        public BackupPolicyProto BackupPolicy { get; set; }

        /// <summary>
        /// Specifies additional policies that can be used to copy snapshots created by a backup run to different targets (such as a remote replica, tape etc). Each policy also specifies the retention policy that should be applied to the copied snapshots at the respective target.
        /// </summary>
        /// <value>Specifies additional policies that can be used to copy snapshots created by a backup run to different targets (such as a remote replica, tape etc). Each policy also specifies the retention policy that should be applied to the copied snapshots at the respective target.</value>
        [DataMember(Name="snapshotTargetPolicyVec", EmitDefaultValue=true)]
        public List<SnapshotTargetPolicyProto> SnapshotTargetPolicyVec { get; set; }

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
            return this.Equals(input as JobPolicyProto);
        }

        /// <summary>
        /// Returns true if JobPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupPolicy == input.BackupPolicy ||
                    (this.BackupPolicy != null &&
                    this.BackupPolicy.Equals(input.BackupPolicy))
                ) && 
                (
                    this.SnapshotTargetPolicyVec == input.SnapshotTargetPolicyVec ||
                    this.SnapshotTargetPolicyVec != null &&
                    input.SnapshotTargetPolicyVec != null &&
                    this.SnapshotTargetPolicyVec.SequenceEqual(input.SnapshotTargetPolicyVec)
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
                if (this.BackupPolicy != null)
                    hashCode = hashCode * 59 + this.BackupPolicy.GetHashCode();
                if (this.SnapshotTargetPolicyVec != null)
                    hashCode = hashCode * 59 + this.SnapshotTargetPolicyVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

