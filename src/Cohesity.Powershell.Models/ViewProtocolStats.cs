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
    /// Specifies the View Protocol stats.
    /// </summary>
    [DataContract]
    public partial class ViewProtocolStats :  IEquatable<ViewProtocolStats>
    {
        /// <summary>
        /// Defines Protocols
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolsEnum
        {
            /// <summary>
            /// Enum KIscsi for value: kIscsi
            /// </summary>
            [EnumMember(Value = "kIscsi")]
            KIscsi = 1,

            /// <summary>
            /// Enum KS3 for value: kS3
            /// </summary>
            [EnumMember(Value = "kS3")]
            KS3 = 2,

            /// <summary>
            /// Enum KSmb for value: kSmb
            /// </summary>
            [EnumMember(Value = "kSmb")]
            KSmb = 3,

            /// <summary>
            /// Enum KNfs for value: kNfs
            /// </summary>
            [EnumMember(Value = "kNfs")]
            KNfs = 4

        }


        /// <summary>
        /// Specifies the protocols supported on these Views.
        /// </summary>
        /// <value>Specifies the protocols supported on these Views.</value>
        [DataMember(Name="protocols", EmitDefaultValue=false)]
        public List<ProtocolsEnum> Protocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewProtocolStats" /> class.
        /// </summary>
        /// <param name="protocols">Specifies the protocols supported on these Views..</param>
        /// <param name="sizeBytes">Specifies the size of all the Views in bytes which are using the specified protocol..</param>
        /// <param name="viewCount">Specifies the number of Views which are using the specified protocol..</param>
        public ViewProtocolStats(List<ProtocolsEnum> protocols = default(List<ProtocolsEnum>), long? sizeBytes = default(long?), long? viewCount = default(long?))
        {
            this.SizeBytes = sizeBytes;
            this.ViewCount = viewCount;
            this.Protocols = protocols;
            this.SizeBytes = sizeBytes;
            this.ViewCount = viewCount;
        }
        
        /// <summary>
        /// Specifies the size of all the Views in bytes which are using the specified protocol.
        /// </summary>
        /// <value>Specifies the size of all the Views in bytes which are using the specified protocol.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Specifies the number of Views which are using the specified protocol.
        /// </summary>
        /// <value>Specifies the number of Views which are using the specified protocol.</value>
        [DataMember(Name="viewCount", EmitDefaultValue=true)]
        public long? ViewCount { get; set; }

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
            return this.Equals(input as ViewProtocolStats);
        }

        /// <summary>
        /// Returns true if ViewProtocolStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewProtocolStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewProtocolStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Protocols == input.Protocols ||
                    this.Protocols.SequenceEqual(input.Protocols)
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
                ) && 
                (
                    this.ViewCount == input.ViewCount ||
                    (this.ViewCount != null &&
                    this.ViewCount.Equals(input.ViewCount))
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
                hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                if (this.ViewCount != null)
                    hashCode = hashCode * 59 + this.ViewCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

