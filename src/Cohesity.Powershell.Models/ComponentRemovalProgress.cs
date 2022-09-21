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
    /// ComponentRemovalProgress is the struct to define the removal progress of an entity w.r.t a given component.
    /// </summary>
    [DataContract]
    public partial class ComponentRemovalProgress :  IEquatable<ComponentRemovalProgress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentRemovalProgress" /> class.
        /// </summary>
        /// <param name="removalProgress">Removal progress details..</param>
        /// <param name="serviceName">Name of the component..</param>
        public ComponentRemovalProgress(string removalProgress = default(string), string serviceName = default(string))
        {
            this.RemovalProgress = removalProgress;
            this.ServiceName = serviceName;
            this.RemovalProgress = removalProgress;
            this.ServiceName = serviceName;
        }
        
        /// <summary>
        /// Removal progress details.
        /// </summary>
        /// <value>Removal progress details.</value>
        [DataMember(Name="removalProgress", EmitDefaultValue=true)]
        public string RemovalProgress { get; set; }

        /// <summary>
        /// Name of the component.
        /// </summary>
        /// <value>Name of the component.</value>
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
            return this.Equals(input as ComponentRemovalProgress);
        }

        /// <summary>
        /// Returns true if ComponentRemovalProgress instances are equal
        /// </summary>
        /// <param name="input">Instance of ComponentRemovalProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComponentRemovalProgress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemovalProgress == input.RemovalProgress ||
                    (this.RemovalProgress != null &&
                    this.RemovalProgress.Equals(input.RemovalProgress))
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
                if (this.RemovalProgress != null)
                    hashCode = hashCode * 59 + this.RemovalProgress.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                return hashCode;
            }
        }

    }

}

