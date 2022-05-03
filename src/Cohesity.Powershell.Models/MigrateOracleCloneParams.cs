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
    /// OracleUpdateRestoreTaskOptions encapsulates information needed for executing migration of a successful Oracle Clone task.
    /// </summary>
    [DataContract]
    public partial class MigrateOracleCloneParams :  IEquatable<MigrateOracleCloneParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateOracleCloneParams" /> class.
        /// </summary>
        /// <param name="delaySecs">The delay in secs, after which the migration of the Clone should be triggered. \&quot;0\&quot; - Means the Migration should start as soon as the Clone successfully finished. That is the default behaviour.  0 &lt; - Means the migration will start when user triggers migration from UI.  &gt; 0 - Means the delay in seconds after which the migration of the clone would be triggered. [ For now this is not supported ].</param>
        /// <param name="targetPathVec">Vector of paths where the contents (i.e. datafile/redo-logs) of the clone DB will be migrated..</param>
        public MigrateOracleCloneParams(long? delaySecs = default(long?), List<string> targetPathVec = default(List<string>))
        {
            this.DelaySecs = delaySecs;
            this.TargetPathVec = targetPathVec;
        }
        
        /// <summary>
        /// The delay in secs, after which the migration of the Clone should be triggered. \&quot;0\&quot; - Means the Migration should start as soon as the Clone successfully finished. That is the default behaviour.  0 &lt; - Means the migration will start when user triggers migration from UI.  &gt; 0 - Means the delay in seconds after which the migration of the clone would be triggered. [ For now this is not supported ]
        /// </summary>
        /// <value>The delay in secs, after which the migration of the Clone should be triggered. \&quot;0\&quot; - Means the Migration should start as soon as the Clone successfully finished. That is the default behaviour.  0 &lt; - Means the migration will start when user triggers migration from UI.  &gt; 0 - Means the delay in seconds after which the migration of the clone would be triggered. [ For now this is not supported ]</value>
        [DataMember(Name="delaySecs", EmitDefaultValue=false)]
        public long? DelaySecs { get; set; }

        /// <summary>
        /// Vector of paths where the contents (i.e. datafile/redo-logs) of the clone DB will be migrated.
        /// </summary>
        /// <value>Vector of paths where the contents (i.e. datafile/redo-logs) of the clone DB will be migrated.</value>
        [DataMember(Name="targetPathVec", EmitDefaultValue=false)]
        public List<string> TargetPathVec { get; set; }

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
            return this.Equals(input as MigrateOracleCloneParams);
        }

        /// <summary>
        /// Returns true if MigrateOracleCloneParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrateOracleCloneParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrateOracleCloneParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DelaySecs == input.DelaySecs ||
                    (this.DelaySecs != null &&
                    this.DelaySecs.Equals(input.DelaySecs))
                ) && 
                (
                    this.TargetPathVec == input.TargetPathVec ||
                    this.TargetPathVec != null &&
                    this.TargetPathVec.Equals(input.TargetPathVec)
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
                if (this.DelaySecs != null)
                    hashCode = hashCode * 59 + this.DelaySecs.GetHashCode();
                if (this.TargetPathVec != null)
                    hashCode = hashCode * 59 + this.TargetPathVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

