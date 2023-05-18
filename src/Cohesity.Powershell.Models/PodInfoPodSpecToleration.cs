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
    /// PodInfoPodSpecToleration
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecToleration :  IEquatable<PodInfoPodSpecToleration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecToleration" /> class.
        /// </summary>
        /// <param name="effect">Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute..</param>
        /// <param name="key">Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys..</param>
        /// <param name="_operator">Operator represents a key&#39;s relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category..</param>
        /// <param name="tolerationSeconds">TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system..</param>
        /// <param name="value">Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string..</param>
        public PodInfoPodSpecToleration(string effect = default(string), string key = default(string), string _operator = default(string), long? tolerationSeconds = default(long?), string value = default(string))
        {
            this.Effect = effect;
            this.Key = key;
            this.Operator = _operator;
            this.TolerationSeconds = tolerationSeconds;
            this.Value = value;
            this.Effect = effect;
            this.Key = key;
            this.Operator = _operator;
            this.TolerationSeconds = tolerationSeconds;
            this.Value = value;
        }
        
        /// <summary>
        /// Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
        /// </summary>
        /// <value>Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.</value>
        [DataMember(Name="effect", EmitDefaultValue=true)]
        public string Effect { get; set; }

        /// <summary>
        /// Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.
        /// </summary>
        /// <value>Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Operator represents a key&#39;s relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.
        /// </summary>
        /// <value>Operator represents a key&#39;s relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.</value>
        [DataMember(Name="operator", EmitDefaultValue=true)]
        public string Operator { get; set; }

        /// <summary>
        /// TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.
        /// </summary>
        /// <value>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.</value>
        [DataMember(Name="tolerationSeconds", EmitDefaultValue=true)]
        public long? TolerationSeconds { get; set; }

        /// <summary>
        /// Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.
        /// </summary>
        /// <value>Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

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
            return this.Equals(input as PodInfoPodSpecToleration);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecToleration instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecToleration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecToleration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Effect == input.Effect ||
                    (this.Effect != null &&
                    this.Effect.Equals(input.Effect))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.TolerationSeconds == input.TolerationSeconds ||
                    (this.TolerationSeconds != null &&
                    this.TolerationSeconds.Equals(input.TolerationSeconds))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Effect != null)
                    hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.TolerationSeconds != null)
                    hashCode = hashCode * 59 + this.TolerationSeconds.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

