// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies settings for copying Snapshots to Remote Clusters. This also specifies the retention policy that should be applied to Snapshots after they have been copied to the specified target.
    /// </summary>
    [DataContract]
    public partial class SnapshotReplicationCopyPolicy :  IEquatable<SnapshotReplicationCopyPolicy>
    {
        /// <summary>
        /// Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.
        /// </summary>
        /// <value>Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodicityEnum
        {
            
            /// <summary>
            /// Enum KEvery for value: kEvery
            /// </summary>
            [EnumMember(Value = "kEvery")]
            KEvery = 1,
            
            /// <summary>
            /// Enum KHour for value: kHour
            /// </summary>
            [EnumMember(Value = "kHour")]
            KHour = 2,
            
            /// <summary>
            /// Enum KDay for value: kDay
            /// </summary>
            [EnumMember(Value = "kDay")]
            KDay = 3,
            
            /// <summary>
            /// Enum KWeek for value: kWeek
            /// </summary>
            [EnumMember(Value = "kWeek")]
            KWeek = 4,
            
            /// <summary>
            /// Enum KMonth for value: kMonth
            /// </summary>
            [EnumMember(Value = "kMonth")]
            KMonth = 5,
            
            /// <summary>
            /// Enum KYear for value: kYear
            /// </summary>
            [EnumMember(Value = "kYear")]
            KYear = 6
        }

        /// <summary>
        /// Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.
        /// </summary>
        /// <value>Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public PeriodicityEnum? Periodicity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotReplicationCopyPolicy" /> class.
        /// </summary>
        /// <param name="copyPartial">Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured..</param>
        /// <param name="daysToKeep">Specifies the number of days to retain copied Snapshots on the target..</param>
        /// <param name="multiplier">Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied..</param>
        /// <param name="periodicity">Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier..</param>
        /// <param name="target">target.</param>
        public SnapshotReplicationCopyPolicy(bool? copyPartial = default(bool?), long? daysToKeep = default(long?), int? multiplier = default(int?), PeriodicityEnum? periodicity = default(PeriodicityEnum?), ReplicationTarget_ target = default(ReplicationTarget_))
        {
            this.CopyPartial = copyPartial;
            this.DaysToKeep = daysToKeep;
            this.Multiplier = multiplier;
            this.Periodicity = periodicity;
            this.Target = target;
        }
        
        /// <summary>
        /// Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured.
        /// </summary>
        /// <value>Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured.</value>
        [DataMember(Name="copyPartial", EmitDefaultValue=false)]
        public bool? CopyPartial { get; set; }

        /// <summary>
        /// Specifies the number of days to retain copied Snapshots on the target.
        /// </summary>
        /// <value>Specifies the number of days to retain copied Snapshots on the target.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=false)]
        public long? DaysToKeep { get; set; }

        /// <summary>
        /// Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied.
        /// </summary>
        /// <value>Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=false)]
        public int? Multiplier { get; set; }


        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public ReplicationTarget_ Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as SnapshotReplicationCopyPolicy);
        }

        /// <summary>
        /// Returns true if SnapshotReplicationCopyPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotReplicationCopyPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotReplicationCopyPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyPartial == input.CopyPartial ||
                    (this.CopyPartial != null &&
                    this.CopyPartial.Equals(input.CopyPartial))
                ) && 
                (
                    this.DaysToKeep == input.DaysToKeep ||
                    (this.DaysToKeep != null &&
                    this.DaysToKeep.Equals(input.DaysToKeep))
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    (this.Periodicity != null &&
                    this.Periodicity.Equals(input.Periodicity))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.CopyPartial != null)
                    hashCode = hashCode * 59 + this.CopyPartial.GetHashCode();
                if (this.DaysToKeep != null)
                    hashCode = hashCode * 59 + this.DaysToKeep.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                if (this.Periodicity != null)
                    hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

