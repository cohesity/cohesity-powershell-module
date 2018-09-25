// Copyright 2018 Cohesity Inc.

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the time of day to start the Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily Protection Schedule. Default value is 02:00 AM.
    /// </summary>
    [DataContract]
    public partial class ProtectionScheduleStartTime_ :  IEquatable<ProtectionScheduleStartTime_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionScheduleStartTime_" /> class.
        /// </summary>
        /// <param name="hour">Specifies an (0-23) hour in a day..</param>
        /// <param name="minute">Specifies a (0-59) minute in an hour..</param>
        public ProtectionScheduleStartTime_(int? hour = default(int?), int? minute = default(int?))
        {
            this.Hour = hour;
            this.Minute = minute;
        }
        
        /// <summary>
        /// Specifies an (0-23) hour in a day.
        /// </summary>
        /// <value>Specifies an (0-23) hour in a day.</value>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// Specifies a (0-59) minute in an hour.
        /// </summary>
        /// <value>Specifies a (0-59) minute in an hour.</value>
        [DataMember(Name="minute", EmitDefaultValue=false)]
        public int? Minute { get; set; }

        ///// <summary>
        ///// Returns the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class ProtectionScheduleStartTime_ {\n");
        //    sb.Append("  Hour: ").Append(Hour).Append("\n");
        //    sb.Append("  Minute: ").Append(Minute).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}
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
            return this.Equals(input as ProtectionScheduleStartTime_);
        }

        /// <summary>
        /// Returns true if ProtectionScheduleStartTime_ instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionScheduleStartTime_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionScheduleStartTime_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hour == input.Hour ||
                    (this.Hour != null &&
                    this.Hour.Equals(input.Hour))
                ) && 
                (
                    this.Minute == input.Minute ||
                    (this.Minute != null &&
                    this.Minute.Equals(input.Minute))
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
                if (this.Hour != null)
                    hashCode = hashCode * 59 + this.Hour.GetHashCode();
                if (this.Minute != null)
                    hashCode = hashCode * 59 + this.Minute.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

