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
    /// Specifies update app instance state parameters.
    /// </summary>
    [DataContract]
    public partial class UpdateAppInstanceStateParameters :  IEquatable<UpdateAppInstanceStateParameters>
    {
        /// <summary>
        /// Specifies the desired app instance state type. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.
        /// </summary>
        /// <value>Specifies the desired app instance state type. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum KInitializing for value: kInitializing
            /// </summary>
            [EnumMember(Value = "kInitializing")]
            KInitializing = 1,

            /// <summary>
            /// Enum KRunning for value: kRunning
            /// </summary>
            [EnumMember(Value = "kRunning")]
            KRunning = 2,

            /// <summary>
            /// Enum KPausing for value: kPausing
            /// </summary>
            [EnumMember(Value = "kPausing")]
            KPausing = 3,

            /// <summary>
            /// Enum KPaused for value: kPaused
            /// </summary>
            [EnumMember(Value = "kPaused")]
            KPaused = 4,

            /// <summary>
            /// Enum KTerminating for value: kTerminating
            /// </summary>
            [EnumMember(Value = "kTerminating")]
            KTerminating = 5,

            /// <summary>
            /// Enum KTerminated for value: kTerminated
            /// </summary>
            [EnumMember(Value = "kTerminated")]
            KTerminated = 6,

            /// <summary>
            /// Enum KFailed for value: kFailed
            /// </summary>
            [EnumMember(Value = "kFailed")]
            KFailed = 7

        }

        /// <summary>
        /// Specifies the desired app instance state type. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.
        /// </summary>
        /// <value>Specifies the desired app instance state type. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppInstanceStateParameters" /> class.
        /// </summary>
        /// <param name="state">Specifies the desired app instance state type. Specifies operational status of an app instance. kInitializing - The app instance has been launched or resumed, but is not fully running yet. kRunning - The app instance is running. Check health_status for the actual health. kPausing - The app instance is being paused. kPaused - The app instance has been paused. kTerminating - The app instance is being terminated. kTerminated -  The app instance has been terminated. kFailed - The app instance has failed due to an unrecoverable error..</param>
        public UpdateAppInstanceStateParameters(StateEnum? state = default(StateEnum?))
        {
            this.State = state;
            this.State = state;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAppInstanceStateParameters {\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as UpdateAppInstanceStateParameters);
        }

        /// <summary>
        /// Returns true if UpdateAppInstanceStateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAppInstanceStateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAppInstanceStateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}
