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
    /// Specifies the Quality of Service (QoS) Policy details.
    /// </summary>
    [DataContract]
    public partial class QoSPolicy :  IEquatable<QoSPolicy>
    {
        /// <summary>
        /// Specifies Priority of the Qos Policy. Priority of QoS Policy as defined in cluster config proto.
        /// </summary>
        /// <value>Specifies Priority of the Qos Policy. Priority of QoS Policy as defined in cluster config proto.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum KLow for value: kLow
            /// </summary>
            [EnumMember(Value = "kLow")]
            KLow = 1,

            /// <summary>
            /// Enum KHigh for value: kHigh
            /// </summary>
            [EnumMember(Value = "kHigh")]
            KHigh = 2

        }

        /// <summary>
        /// Specifies Priority of the Qos Policy. Priority of QoS Policy as defined in cluster config proto.
        /// </summary>
        /// <value>Specifies Priority of the Qos Policy. Priority of QoS Policy as defined in cluster config proto.</value>
        [DataMember(Name="priority", EmitDefaultValue=true)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QoSPolicy" /> class.
        /// </summary>
        /// <param name="alwaysUseSsd">Specifies whether to always write to SSD even if SeqWriteSsdPct is 0..</param>
        /// <param name="id">Specifies Id of the QoS Policy..</param>
        /// <param name="minRequests">Specifies minimum number of requests,  corresponding to this Policy, executed in the QoS queue..</param>
        /// <param name="name">Specifies Name of the Qos Policy..</param>
        /// <param name="priority">Specifies Priority of the Qos Policy. Priority of QoS Policy as defined in cluster config proto..</param>
        /// <param name="randomWriteHydraPct">Specifies percentage of a random write request belonging to this Policy that hits hydra..</param>
        /// <param name="randomWriteSsdPct">Specifies percentage of a random write request belonging to this Policy that hits SSD..</param>
        /// <param name="seqWriteHydraPct">Specifies percentage of a sequential write request belonging to this Policy that hits hydra..</param>
        /// <param name="seqWriteSsdPct">Specifies percentage of a sequential write request belonging to this Policy that hits SSD..</param>
        /// <param name="weight">Specifies Weight of the QoS Policy used in QoS queue..</param>
        /// <param name="workLoadType">Specifies Workload type attribute associated with this Policy..</param>
        public QoSPolicy(bool? alwaysUseSsd = default(bool?), long? id = default(long?), int? minRequests = default(int?), string name = default(string), PriorityEnum? priority = default(PriorityEnum?), int? randomWriteHydraPct = default(int?), int? randomWriteSsdPct = default(int?), int? seqWriteHydraPct = default(int?), int? seqWriteSsdPct = default(int?), int? weight = default(int?), string workLoadType = default(string))
        {
            this.AlwaysUseSsd = alwaysUseSsd;
            this.Id = id;
            this.MinRequests = minRequests;
            this.Name = name;
            this.Priority = priority;
            this.RandomWriteHydraPct = randomWriteHydraPct;
            this.RandomWriteSsdPct = randomWriteSsdPct;
            this.SeqWriteHydraPct = seqWriteHydraPct;
            this.SeqWriteSsdPct = seqWriteSsdPct;
            this.Weight = weight;
            this.WorkLoadType = workLoadType;
            this.AlwaysUseSsd = alwaysUseSsd;
            this.Id = id;
            this.MinRequests = minRequests;
            this.Name = name;
            this.Priority = priority;
            this.RandomWriteHydraPct = randomWriteHydraPct;
            this.RandomWriteSsdPct = randomWriteSsdPct;
            this.SeqWriteHydraPct = seqWriteHydraPct;
            this.SeqWriteSsdPct = seqWriteSsdPct;
            this.Weight = weight;
            this.WorkLoadType = workLoadType;
        }
        
        /// <summary>
        /// Specifies whether to always write to SSD even if SeqWriteSsdPct is 0.
        /// </summary>
        /// <value>Specifies whether to always write to SSD even if SeqWriteSsdPct is 0.</value>
        [DataMember(Name="alwaysUseSsd", EmitDefaultValue=true)]
        public bool? AlwaysUseSsd { get; set; }

        /// <summary>
        /// Specifies Id of the QoS Policy.
        /// </summary>
        /// <value>Specifies Id of the QoS Policy.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies minimum number of requests,  corresponding to this Policy, executed in the QoS queue.
        /// </summary>
        /// <value>Specifies minimum number of requests,  corresponding to this Policy, executed in the QoS queue.</value>
        [DataMember(Name="minRequests", EmitDefaultValue=true)]
        public int? MinRequests { get; set; }

        /// <summary>
        /// Specifies Name of the Qos Policy.
        /// </summary>
        /// <value>Specifies Name of the Qos Policy.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies percentage of a random write request belonging to this Policy that hits hydra.
        /// </summary>
        /// <value>Specifies percentage of a random write request belonging to this Policy that hits hydra.</value>
        [DataMember(Name="randomWriteHydraPct", EmitDefaultValue=true)]
        public int? RandomWriteHydraPct { get; set; }

        /// <summary>
        /// Specifies percentage of a random write request belonging to this Policy that hits SSD.
        /// </summary>
        /// <value>Specifies percentage of a random write request belonging to this Policy that hits SSD.</value>
        [DataMember(Name="randomWriteSsdPct", EmitDefaultValue=true)]
        public int? RandomWriteSsdPct { get; set; }

        /// <summary>
        /// Specifies percentage of a sequential write request belonging to this Policy that hits hydra.
        /// </summary>
        /// <value>Specifies percentage of a sequential write request belonging to this Policy that hits hydra.</value>
        [DataMember(Name="seqWriteHydraPct", EmitDefaultValue=true)]
        public int? SeqWriteHydraPct { get; set; }

        /// <summary>
        /// Specifies percentage of a sequential write request belonging to this Policy that hits SSD.
        /// </summary>
        /// <value>Specifies percentage of a sequential write request belonging to this Policy that hits SSD.</value>
        [DataMember(Name="seqWriteSsdPct", EmitDefaultValue=true)]
        public int? SeqWriteSsdPct { get; set; }

        /// <summary>
        /// Specifies Weight of the QoS Policy used in QoS queue.
        /// </summary>
        /// <value>Specifies Weight of the QoS Policy used in QoS queue.</value>
        [DataMember(Name="weight", EmitDefaultValue=true)]
        public int? Weight { get; set; }

        /// <summary>
        /// Specifies Workload type attribute associated with this Policy.
        /// </summary>
        /// <value>Specifies Workload type attribute associated with this Policy.</value>
        [DataMember(Name="workLoadType", EmitDefaultValue=true)]
        public string WorkLoadType { get; set; }

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
            return this.Equals(input as QoSPolicy);
        }

        /// <summary>
        /// Returns true if QoSPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of QoSPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QoSPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlwaysUseSsd == input.AlwaysUseSsd ||
                    (this.AlwaysUseSsd != null &&
                    this.AlwaysUseSsd.Equals(input.AlwaysUseSsd))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MinRequests == input.MinRequests ||
                    (this.MinRequests != null &&
                    this.MinRequests.Equals(input.MinRequests))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.RandomWriteHydraPct == input.RandomWriteHydraPct ||
                    (this.RandomWriteHydraPct != null &&
                    this.RandomWriteHydraPct.Equals(input.RandomWriteHydraPct))
                ) && 
                (
                    this.RandomWriteSsdPct == input.RandomWriteSsdPct ||
                    (this.RandomWriteSsdPct != null &&
                    this.RandomWriteSsdPct.Equals(input.RandomWriteSsdPct))
                ) && 
                (
                    this.SeqWriteHydraPct == input.SeqWriteHydraPct ||
                    (this.SeqWriteHydraPct != null &&
                    this.SeqWriteHydraPct.Equals(input.SeqWriteHydraPct))
                ) && 
                (
                    this.SeqWriteSsdPct == input.SeqWriteSsdPct ||
                    (this.SeqWriteSsdPct != null &&
                    this.SeqWriteSsdPct.Equals(input.SeqWriteSsdPct))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.WorkLoadType == input.WorkLoadType ||
                    (this.WorkLoadType != null &&
                    this.WorkLoadType.Equals(input.WorkLoadType))
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
                if (this.AlwaysUseSsd != null)
                    hashCode = hashCode * 59 + this.AlwaysUseSsd.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MinRequests != null)
                    hashCode = hashCode * 59 + this.MinRequests.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RandomWriteHydraPct != null)
                    hashCode = hashCode * 59 + this.RandomWriteHydraPct.GetHashCode();
                if (this.RandomWriteSsdPct != null)
                    hashCode = hashCode * 59 + this.RandomWriteSsdPct.GetHashCode();
                if (this.SeqWriteHydraPct != null)
                    hashCode = hashCode * 59 + this.SeqWriteHydraPct.GetHashCode();
                if (this.SeqWriteSsdPct != null)
                    hashCode = hashCode * 59 + this.SeqWriteSsdPct.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.WorkLoadType != null)
                    hashCode = hashCode * 59 + this.WorkLoadType.GetHashCode();
                return hashCode;
            }
        }

    }

}

