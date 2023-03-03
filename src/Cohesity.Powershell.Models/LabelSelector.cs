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
    /// LabelSelector
    /// </summary>
    [DataContract]
    public partial class LabelSelector :  IEquatable<LabelSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelSelector" /> class.
        /// </summary>
        /// <param name="matchLabels">This field is an object which consists of key-value pairs of all labels that must be matched by the selector.</param>
        /// <param name="name">Select all objects which have a label with key : \&quot;name\&quot; and value specified by this field..</param>
        /// <param name="serviceName">Select all objects which have a label with. key: \&quot;serviceName\&quot; and value as specified by this field..</param>
        public LabelSelector(List<LabelSelectorMatchLabelsEntry> matchLabels = default(List<LabelSelectorMatchLabelsEntry>), string name = default(string), string serviceName = default(string))
        {
            this.MatchLabels = matchLabels;
            this.Name = name;
            this.ServiceName = serviceName;
            this.MatchLabels = matchLabels;
            this.Name = name;
            this.ServiceName = serviceName;
        }
        
        /// <summary>
        /// This field is an object which consists of key-value pairs of all labels that must be matched by the selector
        /// </summary>
        /// <value>This field is an object which consists of key-value pairs of all labels that must be matched by the selector</value>
        [DataMember(Name="matchLabels", EmitDefaultValue=true)]
        public List<LabelSelectorMatchLabelsEntry> MatchLabels { get; set; }

        /// <summary>
        /// Select all objects which have a label with key : \&quot;name\&quot; and value specified by this field.
        /// </summary>
        /// <value>Select all objects which have a label with key : \&quot;name\&quot; and value specified by this field.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Select all objects which have a label with. key: \&quot;serviceName\&quot; and value as specified by this field.
        /// </summary>
        /// <value>Select all objects which have a label with. key: \&quot;serviceName\&quot; and value as specified by this field.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=true)]
        public string ServiceName { get; set; }

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
            return this.Equals(input as LabelSelector);
        }

        /// <summary>
        /// Returns true if LabelSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelSelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MatchLabels == input.MatchLabels ||
                    this.MatchLabels != null &&
                    input.MatchLabels != null &&
                    this.MatchLabels.SequenceEqual(input.MatchLabels)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
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
                if (this.MatchLabels != null)
                    hashCode = hashCode * 59 + this.MatchLabels.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                return hashCode;
            }
        }

    }

}

