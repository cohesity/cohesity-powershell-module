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
    /// Specifies settings for copying Snapshots External Targets (such as AWS or Tape). This also specifies the retention policy that should be applied to Snapshots after they have been copied to the specified target.
    /// </summary>
    [DataContract]
    public partial class SnapshotArchivalCopyPolicy :  IEquatable<SnapshotArchivalCopyPolicy>
    {
        /// <summary>
        /// Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.
        /// </summary>
        /// <value>Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.</value>
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
        /// Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.
        /// </summary>
        /// <value>Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=true)]
        public PeriodicityEnum? Periodicity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotArchivalCopyPolicy" /> class.
        /// </summary>
        /// <param name="id">Specified the Id for a snapshot copy policy. This is generated when the policy is created..</param>
        /// <param name="copyPartial">Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured..</param>
        /// <param name="datalockConfig">datalockConfig.</param>
        /// <param name="daysToKeep">Specifies the number of days to retain copied Snapshots on the target..</param>
        /// <param name="multiplier">Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied..</param>
        /// <param name="periodicity">Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier..</param>
        /// <param name="target">Specifies the archival target to copy the Snapshots to..</param>
        public SnapshotArchivalCopyPolicy(string id = default(string), bool? copyPartial = default(bool?), DataLockConfig datalockConfig = default(DataLockConfig), long? daysToKeep = default(long?), int? multiplier = default(int?), PeriodicityEnum? periodicity = default(PeriodicityEnum?), ArchivalExternalTarget target = default(ArchivalExternalTarget))
        {
            this.Id = id;
            this.CopyPartial = copyPartial;
            this.DatalockConfig = datalockConfig;
            this.DaysToKeep = daysToKeep;
            this.Multiplier = multiplier;
            this.Periodicity = periodicity;
            this.Target = target;
        }
        
        /// <summary>
        /// Specified the Id for a snapshot copy policy. This is generated when the policy is created.
        /// </summary>
        /// <value>Specified the Id for a snapshot copy policy. This is generated when the policy is created.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured.
        /// </summary>
        /// <value>Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured.</value>
        [DataMember(Name="copyPartial", EmitDefaultValue=true)]
        public bool? CopyPartial { get; set; }

        /// <summary>
        /// Gets or Sets DatalockConfig
        /// </summary>
        [DataMember(Name="datalockConfig", EmitDefaultValue=false)]
        public DataLockConfig DatalockConfig { get; set; }

        /// <summary>
        /// Specifies the number of days to retain copied Snapshots on the target.
        /// </summary>
        /// <value>Specifies the number of days to retain copied Snapshots on the target.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=true)]
        public long? DaysToKeep { get; set; }

        /// <summary>
        /// Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied.
        /// </summary>
        /// <value>Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=true)]
        public int? Multiplier { get; set; }

        /// <summary>
        /// Specifies the archival target to copy the Snapshots to.
        /// </summary>
        /// <value>Specifies the archival target to copy the Snapshots to.</value>
        [DataMember(Name="target", EmitDefaultValue=true)]
        public ArchivalExternalTarget Target { get; set; }

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
            return this.Equals(input as SnapshotArchivalCopyPolicy);
        }

        /// <summary>
        /// Returns true if SnapshotArchivalCopyPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotArchivalCopyPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotArchivalCopyPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CopyPartial == input.CopyPartial ||
                    (this.CopyPartial != null &&
                    this.CopyPartial.Equals(input.CopyPartial))
                ) && 
                (
                    this.DatalockConfig == input.DatalockConfig ||
                    (this.DatalockConfig != null &&
                    this.DatalockConfig.Equals(input.DatalockConfig))
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
                    this.Periodicity.Equals(input.Periodicity)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CopyPartial != null)
                    hashCode = hashCode * 59 + this.CopyPartial.GetHashCode();
                if (this.DatalockConfig != null)
                    hashCode = hashCode * 59 + this.DatalockConfig.GetHashCode();
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

