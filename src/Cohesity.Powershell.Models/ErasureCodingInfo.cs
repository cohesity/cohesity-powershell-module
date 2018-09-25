// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// ErasureCodingInfo
    /// </summary>
    [DataContract]
    public partial class ErasureCodingInfo :  IEquatable<ErasureCodingInfo>
    {
        /// <summary>
        /// Algorthm used for erasure coding.
        /// </summary>
        /// <value>Algorthm used for erasure coding.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            
            /// <summary>
            /// Enum REEDSOLOMON for value: REED_SOLOMON
            /// </summary>
            [EnumMember(Value = "REED_SOLOMON")]
            REEDSOLOMON = 1,
            
            /// <summary>
            /// Enum LRC for value: LRC
            /// </summary>
            [EnumMember(Value = "LRC")]
            LRC = 2
        }

        /// <summary>
        /// Algorthm used for erasure coding.
        /// </summary>
        /// <value>Algorthm used for erasure coding.</value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public AlgorithmEnum? Algorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErasureCodingInfo" /> class.
        /// </summary>
        /// <param name="algorithm">Algorthm used for erasure coding..</param>
        /// <param name="erasureCodingEnabled">Specifies whether Erasure coding is enabled on the Storage Domain (View Box)..</param>
        /// <param name="inlineErasureCoding">Specifies if erasure coding should occur inline (as the data is being written). This field is only relevant if erasure coding is enabled..</param>
        /// <param name="numCodedStripes">The number of coded stripes..</param>
        /// <param name="numDataStripes">The number of stripes containing data..</param>
        public ErasureCodingInfo(AlgorithmEnum? algorithm = default(AlgorithmEnum?), bool? erasureCodingEnabled = default(bool?), bool? inlineErasureCoding = default(bool?), int? numCodedStripes = default(int?), int? numDataStripes = default(int?))
        {
            this.Algorithm = algorithm;
            this.ErasureCodingEnabled = erasureCodingEnabled;
            this.InlineErasureCoding = inlineErasureCoding;
            this.NumCodedStripes = numCodedStripes;
            this.NumDataStripes = numDataStripes;
        }
        

        /// <summary>
        /// Specifies whether Erasure coding is enabled on the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies whether Erasure coding is enabled on the Storage Domain (View Box).</value>
        [DataMember(Name="erasureCodingEnabled", EmitDefaultValue=false)]
        public bool? ErasureCodingEnabled { get; set; }

        /// <summary>
        /// Specifies if erasure coding should occur inline (as the data is being written). This field is only relevant if erasure coding is enabled.
        /// </summary>
        /// <value>Specifies if erasure coding should occur inline (as the data is being written). This field is only relevant if erasure coding is enabled.</value>
        [DataMember(Name="inlineErasureCoding", EmitDefaultValue=false)]
        public bool? InlineErasureCoding { get; set; }

        /// <summary>
        /// The number of coded stripes.
        /// </summary>
        /// <value>The number of coded stripes.</value>
        [DataMember(Name="numCodedStripes", EmitDefaultValue=false)]
        public int? NumCodedStripes { get; set; }

        /// <summary>
        /// The number of stripes containing data.
        /// </summary>
        /// <value>The number of stripes containing data.</value>
        [DataMember(Name="numDataStripes", EmitDefaultValue=false)]
        public int? NumDataStripes { get; set; }

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
            return this.Equals(input as ErasureCodingInfo);
        }

        /// <summary>
        /// Returns true if ErasureCodingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ErasureCodingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErasureCodingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.ErasureCodingEnabled == input.ErasureCodingEnabled ||
                    (this.ErasureCodingEnabled != null &&
                    this.ErasureCodingEnabled.Equals(input.ErasureCodingEnabled))
                ) && 
                (
                    this.InlineErasureCoding == input.InlineErasureCoding ||
                    (this.InlineErasureCoding != null &&
                    this.InlineErasureCoding.Equals(input.InlineErasureCoding))
                ) && 
                (
                    this.NumCodedStripes == input.NumCodedStripes ||
                    (this.NumCodedStripes != null &&
                    this.NumCodedStripes.Equals(input.NumCodedStripes))
                ) && 
                (
                    this.NumDataStripes == input.NumDataStripes ||
                    (this.NumDataStripes != null &&
                    this.NumDataStripes.Equals(input.NumDataStripes))
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
                if (this.Algorithm != null)
                    hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.ErasureCodingEnabled != null)
                    hashCode = hashCode * 59 + this.ErasureCodingEnabled.GetHashCode();
                if (this.InlineErasureCoding != null)
                    hashCode = hashCode * 59 + this.InlineErasureCoding.GetHashCode();
                if (this.NumCodedStripes != null)
                    hashCode = hashCode * 59 + this.NumCodedStripes.GetHashCode();
                if (this.NumDataStripes != null)
                    hashCode = hashCode * 59 + this.NumDataStripes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

