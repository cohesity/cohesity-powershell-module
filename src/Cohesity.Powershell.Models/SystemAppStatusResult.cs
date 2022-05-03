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
    /// Specifies the result of getting the status of System Apps.
    /// </summary>
    [DataContract]
    public partial class SystemAppStatusResult :  IEquatable<SystemAppStatusResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemAppStatusResult" /> class.
        /// </summary>
        /// <param name="availableReplicas">Required field..</param>
        /// <param name="configuredReplicas">Required field..</param>
        /// <param name="name">Required field..</param>
        /// <param name="readyReplicas">Required field..</param>
        /// <param name="serviceEndpoint">Required field..</param>
        public SystemAppStatusResult(int? availableReplicas = default(int?), int? configuredReplicas = default(int?), string name = default(string), int? readyReplicas = default(int?), string serviceEndpoint = default(string))
        {
            this.AvailableReplicas = availableReplicas;
            this.ConfiguredReplicas = configuredReplicas;
            this.Name = name;
            this.ReadyReplicas = readyReplicas;
            this.ServiceEndpoint = serviceEndpoint;
        }
        
        /// <summary>
        /// Required field.
        /// </summary>
        /// <value>Required field.</value>
        [DataMember(Name="availableReplicas", EmitDefaultValue=false)]
        public int? AvailableReplicas { get; set; }

        /// <summary>
        /// Required field.
        /// </summary>
        /// <value>Required field.</value>
        [DataMember(Name="configuredReplicas", EmitDefaultValue=false)]
        public int? ConfiguredReplicas { get; set; }

        /// <summary>
        /// Required field.
        /// </summary>
        /// <value>Required field.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Required field.
        /// </summary>
        /// <value>Required field.</value>
        [DataMember(Name="readyReplicas", EmitDefaultValue=false)]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Required field.
        /// </summary>
        /// <value>Required field.</value>
        [DataMember(Name="serviceEndpoint", EmitDefaultValue=false)]
        public string ServiceEndpoint { get; set; }

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
            return this.Equals(input as SystemAppStatusResult);
        }

        /// <summary>
        /// Returns true if SystemAppStatusResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemAppStatusResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemAppStatusResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableReplicas == input.AvailableReplicas ||
                    (this.AvailableReplicas != null &&
                    this.AvailableReplicas.Equals(input.AvailableReplicas))
                ) && 
                (
                    this.ConfiguredReplicas == input.ConfiguredReplicas ||
                    (this.ConfiguredReplicas != null &&
                    this.ConfiguredReplicas.Equals(input.ConfiguredReplicas))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReadyReplicas == input.ReadyReplicas ||
                    (this.ReadyReplicas != null &&
                    this.ReadyReplicas.Equals(input.ReadyReplicas))
                ) && 
                (
                    this.ServiceEndpoint == input.ServiceEndpoint ||
                    (this.ServiceEndpoint != null &&
                    this.ServiceEndpoint.Equals(input.ServiceEndpoint))
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
                if (this.AvailableReplicas != null)
                    hashCode = hashCode * 59 + this.AvailableReplicas.GetHashCode();
                if (this.ConfiguredReplicas != null)
                    hashCode = hashCode * 59 + this.ConfiguredReplicas.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReadyReplicas != null)
                    hashCode = hashCode * 59 + this.ReadyReplicas.GetHashCode();
                if (this.ServiceEndpoint != null)
                    hashCode = hashCode * 59 + this.ServiceEndpoint.GetHashCode();
                return hashCode;
            }
        }

    }

}

