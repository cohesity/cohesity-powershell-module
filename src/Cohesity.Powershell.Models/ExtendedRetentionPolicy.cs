// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// ExtendedRetentionPolicy
    /// </summary>
    [DataContract]
    public partial class ExtendedRetentionPolicy :  IEquatable<ExtendedRetentionPolicy>
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
        /// Initializes a new instance of the <see cref="ExtendedRetentionPolicy" /> class.
        /// </summary>
        /// <param name="daysToKeep">Specifies the number of days to retain copied Snapshots on the target..</param>
        /// <param name="multiplier">Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied..</param>
        /// <param name="periodicity">Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier..</param>
        public ExtendedRetentionPolicy(long? daysToKeep = default(long?), int? multiplier = default(int?), PeriodicityEnum? periodicity = default(PeriodicityEnum?))
        {
            this.DaysToKeep = daysToKeep;
            this.Multiplier = multiplier;
            this.Periodicity = periodicity;
        }
        
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
            return this.Equals(input as ExtendedRetentionPolicy);
        }

        /// <summary>
        /// Returns true if ExtendedRetentionPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendedRetentionPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendedRetentionPolicy input)
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
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    (this.Periodicity != null &&
                    this.Periodicity.Equals(input.Periodicity))
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
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                if (this.Periodicity != null)
                    hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

