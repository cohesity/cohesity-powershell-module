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
    /// Message that specifies the WORM attributes. WORM attributes can be associated with any of the following: 1. backup policy: compliance or administrative policy with worm retention. 2. backup runs: worm retention inherited from policy at successful backup run completion.. 3. backup tasks do not inherit WORM retention. Instead they check for WORM property on the corresponding backup run. There are no WORM attributes associated with the backup job.
    /// </summary>
    [DataContract]
    public partial class WormRetentionProto :  IEquatable<WormRetentionProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WormRetentionProto" /> class.
        /// </summary>
        /// <param name="enableWormOnExternalTarget">Whether objects in the external target associated with this policy need to be made immutable..</param>
        /// <param name="policyType">The type of WORM policy set on this run. This field is irrelevant while objects are on legal hold. Objects put on legal hold automatically raise the WORM level on the object behaviorally to the strictest level i.e. kCompliance..</param>
        /// <param name="retentionSecs">Retention time for datalock in seconds. This will be always relative time..</param>
        /// <param name="version">Version number for this proto..</param>
        public WormRetentionProto(bool? enableWormOnExternalTarget = default(bool?), int? policyType = default(int?), long? retentionSecs = default(long?), int? version = default(int?))
        {
            this.EnableWormOnExternalTarget = enableWormOnExternalTarget;
            this.PolicyType = policyType;
            this.RetentionSecs = retentionSecs;
            this.Version = version;
            this.EnableWormOnExternalTarget = enableWormOnExternalTarget;
            this.PolicyType = policyType;
            this.RetentionSecs = retentionSecs;
            this.Version = version;
        }
        
        /// <summary>
        /// Whether objects in the external target associated with this policy need to be made immutable.
        /// </summary>
        /// <value>Whether objects in the external target associated with this policy need to be made immutable.</value>
        [DataMember(Name="enableWormOnExternalTarget", EmitDefaultValue=true)]
        public bool? EnableWormOnExternalTarget { get; set; }

        /// <summary>
        /// The type of WORM policy set on this run. This field is irrelevant while objects are on legal hold. Objects put on legal hold automatically raise the WORM level on the object behaviorally to the strictest level i.e. kCompliance.
        /// </summary>
        /// <value>The type of WORM policy set on this run. This field is irrelevant while objects are on legal hold. Objects put on legal hold automatically raise the WORM level on the object behaviorally to the strictest level i.e. kCompliance.</value>
        [DataMember(Name="policyType", EmitDefaultValue=true)]
        public int? PolicyType { get; set; }

        /// <summary>
        /// Retention time for datalock in seconds. This will be always relative time.
        /// </summary>
        /// <value>Retention time for datalock in seconds. This will be always relative time.</value>
        [DataMember(Name="retentionSecs", EmitDefaultValue=true)]
        public long? RetentionSecs { get; set; }

        /// <summary>
        /// Version number for this proto.
        /// </summary>
        /// <value>Version number for this proto.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; set; }

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
            return this.Equals(input as WormRetentionProto);
        }

        /// <summary>
        /// Returns true if WormRetentionProto instances are equal
        /// </summary>
        /// <param name="input">Instance of WormRetentionProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WormRetentionProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableWormOnExternalTarget == input.EnableWormOnExternalTarget ||
                    (this.EnableWormOnExternalTarget != null &&
                    this.EnableWormOnExternalTarget.Equals(input.EnableWormOnExternalTarget))
                ) && 
                (
                    this.PolicyType == input.PolicyType ||
                    (this.PolicyType != null &&
                    this.PolicyType.Equals(input.PolicyType))
                ) && 
                (
                    this.RetentionSecs == input.RetentionSecs ||
                    (this.RetentionSecs != null &&
                    this.RetentionSecs.Equals(input.RetentionSecs))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.EnableWormOnExternalTarget != null)
                    hashCode = hashCode * 59 + this.EnableWormOnExternalTarget.GetHashCode();
                if (this.PolicyType != null)
                    hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.RetentionSecs != null)
                    hashCode = hashCode * 59 + this.RetentionSecs.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

