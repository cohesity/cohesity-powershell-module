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
    /// QuiesceRule
    /// </summary>
    [DataContract]
    public partial class QuiesceRule :  IEquatable<QuiesceRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuiesceRule" /> class.
        /// </summary>
        /// <param name="podSelectorLabels">List of labels to identify pods belonging to a given workload resource (deployment, daemonset etc). Each label will be in format \&quot;key: value\&quot;..</param>
        /// <param name="postSnapshotHooks">Hooks to execute after snapshot complete for all volumes associated with the pods..</param>
        /// <param name="preSnapshotHooks">Hooks to execute before snapshotting PVCs associated with the pods..</param>
        /// <param name="uuid">Unique identifier for every quiescing group. This must be unique within a given entity in a protection group..</param>
        public QuiesceRule(Dictionary<string, string> podSelectorLabels = default(Dictionary<string, string>), List<QuiesceRuleHook> postSnapshotHooks = default(List<QuiesceRuleHook>), List<QuiesceRuleHook> preSnapshotHooks = default(List<QuiesceRuleHook>), string uuid = default(string))
        {
            this.PodSelectorLabels = podSelectorLabels;
            this.PostSnapshotHooks = postSnapshotHooks;
            this.PreSnapshotHooks = preSnapshotHooks;
            this.Uuid = uuid;
            this.PodSelectorLabels = podSelectorLabels;
            this.PostSnapshotHooks = postSnapshotHooks;
            this.PreSnapshotHooks = preSnapshotHooks;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// List of labels to identify pods belonging to a given workload resource (deployment, daemonset etc). Each label will be in format \&quot;key: value\&quot;.
        /// </summary>
        /// <value>List of labels to identify pods belonging to a given workload resource (deployment, daemonset etc). Each label will be in format \&quot;key: value\&quot;.</value>
        [DataMember(Name="podSelectorLabels", EmitDefaultValue=true)]
        public Dictionary<string, string> PodSelectorLabels { get; set; }

        /// <summary>
        /// Hooks to execute after snapshot complete for all volumes associated with the pods.
        /// </summary>
        /// <value>Hooks to execute after snapshot complete for all volumes associated with the pods.</value>
        [DataMember(Name="postSnapshotHooks", EmitDefaultValue=true)]
        public List<QuiesceRuleHook> PostSnapshotHooks { get; set; }

        /// <summary>
        /// Hooks to execute before snapshotting PVCs associated with the pods.
        /// </summary>
        /// <value>Hooks to execute before snapshotting PVCs associated with the pods.</value>
        [DataMember(Name="preSnapshotHooks", EmitDefaultValue=true)]
        public List<QuiesceRuleHook> PreSnapshotHooks { get; set; }

        /// <summary>
        /// Unique identifier for every quiescing group. This must be unique within a given entity in a protection group.
        /// </summary>
        /// <value>Unique identifier for every quiescing group. This must be unique within a given entity in a protection group.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as QuiesceRule);
        }

        /// <summary>
        /// Returns true if QuiesceRule instances are equal
        /// </summary>
        /// <param name="input">Instance of QuiesceRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuiesceRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PodSelectorLabels == input.PodSelectorLabels ||
                    this.PodSelectorLabels != null &&
                    input.PodSelectorLabels != null &&
                    this.PodSelectorLabels.SequenceEqual(input.PodSelectorLabels)
                ) && 
                (
                    this.PostSnapshotHooks == input.PostSnapshotHooks ||
                    this.PostSnapshotHooks != null &&
                    input.PostSnapshotHooks != null &&
                    this.PostSnapshotHooks.SequenceEqual(input.PostSnapshotHooks)
                ) && 
                (
                    this.PreSnapshotHooks == input.PreSnapshotHooks ||
                    this.PreSnapshotHooks != null &&
                    input.PreSnapshotHooks != null &&
                    this.PreSnapshotHooks.SequenceEqual(input.PreSnapshotHooks)
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.PodSelectorLabels != null)
                    hashCode = hashCode * 59 + this.PodSelectorLabels.GetHashCode();
                if (this.PostSnapshotHooks != null)
                    hashCode = hashCode * 59 + this.PostSnapshotHooks.GetHashCode();
                if (this.PreSnapshotHooks != null)
                    hashCode = hashCode * 59 + this.PreSnapshotHooks.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

