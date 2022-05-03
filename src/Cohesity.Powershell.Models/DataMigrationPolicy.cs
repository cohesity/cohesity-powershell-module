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
    /// Specifies settings for data migration in NAS environment. This also specifies the retention policy that should be applied to files after they have been moved to cohesity cluster.
    /// </summary>
    [DataContract]
    public partial class DataMigrationPolicy :  IEquatable<DataMigrationPolicy>
    {
        /// <summary>
        /// Specifies WORM retention type for the files. When a WORM retention type is specified, the files will be kept until the maximum of the retention time. During that time, the files cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.
        /// </summary>
        /// <value>Specifies WORM retention type for the files. When a WORM retention type is specified, the files will be kept until the maximum of the retention time. During that time, the files cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WormRetentionTypeEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KCompliance for value: kCompliance
            /// </summary>
            [EnumMember(Value = "kCompliance")]
            KCompliance = 2,

            /// <summary>
            /// Enum KAdministrative for value: kAdministrative
            /// </summary>
            [EnumMember(Value = "kAdministrative")]
            KAdministrative = 3

        }

        /// <summary>
        /// Specifies WORM retention type for the files. When a WORM retention type is specified, the files will be kept until the maximum of the retention time. During that time, the files cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.
        /// </summary>
        /// <value>Specifies WORM retention type for the files. When a WORM retention type is specified, the files will be kept until the maximum of the retention time. During that time, the files cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.</value>
        [DataMember(Name="wormRetentionType", EmitDefaultValue=false)]
        public WormRetentionTypeEnum? WormRetentionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataMigrationPolicy" /> class.
        /// </summary>
        /// <param name="daysToKeep">Specifies how many days to retain Snapshots on the Cohesity Cluster..</param>
        /// <param name="schedulingPolicy">schedulingPolicy.</param>
        /// <param name="wormRetentionType">Specifies WORM retention type for the files. When a WORM retention type is specified, the files will be kept until the maximum of the retention time. During that time, the files cannot be deleted. &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes..</param>
        public DataMigrationPolicy(long? daysToKeep = default(long?), SchedulingPolicy schedulingPolicy = default(SchedulingPolicy), WormRetentionTypeEnum? wormRetentionType = default(WormRetentionTypeEnum?))
        {
            this.DaysToKeep = daysToKeep;
            this.SchedulingPolicy = schedulingPolicy;
            this.WormRetentionType = wormRetentionType;
        }
        
        /// <summary>
        /// Specifies how many days to retain Snapshots on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies how many days to retain Snapshots on the Cohesity Cluster.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=false)]
        public long? DaysToKeep { get; set; }

        /// <summary>
        /// Gets or Sets SchedulingPolicy
        /// </summary>
        [DataMember(Name="schedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicy SchedulingPolicy { get; set; }


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
            return this.Equals(input as DataMigrationPolicy);
        }

        /// <summary>
        /// Returns true if DataMigrationPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of DataMigrationPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataMigrationPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DaysToKeep == input.DaysToKeep ||
                    (this.DaysToKeep != null &&
                    this.DaysToKeep.Equals(input.DaysToKeep))
                ) && 
                (
                    this.SchedulingPolicy == input.SchedulingPolicy ||
                    (this.SchedulingPolicy != null &&
                    this.SchedulingPolicy.Equals(input.SchedulingPolicy))
                ) && 
                (
                    this.WormRetentionType == input.WormRetentionType ||
                    (this.WormRetentionType != null &&
                    this.WormRetentionType.Equals(input.WormRetentionType))
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
                if (this.DaysToKeep != null)
                    hashCode = hashCode * 59 + this.DaysToKeep.GetHashCode();
                if (this.SchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.SchedulingPolicy.GetHashCode();
                if (this.WormRetentionType != null)
                    hashCode = hashCode * 59 + this.WormRetentionType.GetHashCode();
                return hashCode;
            }
        }

    }

}

