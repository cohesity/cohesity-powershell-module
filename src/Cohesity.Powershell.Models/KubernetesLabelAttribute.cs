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
    /// Specifies a Kubernetes label.
    /// </summary>
    [DataContract]
    public partial class KubernetesLabelAttribute :  IEquatable<KubernetesLabelAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesLabelAttribute" /> class.
        /// </summary>
        /// <param name="id">Specifies the Cohesity id of the K8s label..</param>
        /// <param name="name">Specifies the appended key and value of the K8s label..</param>
        /// <param name="uuid">Specifies Kubernetes Unique Identifier (UUID) of the K8s label..</param>
        public KubernetesLabelAttribute(long? id = default(long?), string name = default(string), string uuid = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Uuid = uuid;
            this.Id = id;
            this.Name = name;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the Cohesity id of the K8s label.
        /// </summary>
        /// <value>Specifies the Cohesity id of the K8s label.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the appended key and value of the K8s label.
        /// </summary>
        /// <value>Specifies the appended key and value of the K8s label.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies Kubernetes Unique Identifier (UUID) of the K8s label.
        /// </summary>
        /// <value>Specifies Kubernetes Unique Identifier (UUID) of the K8s label.</value>
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
            return this.Equals(input as KubernetesLabelAttribute);
        }

        /// <summary>
        /// Returns true if KubernetesLabelAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesLabelAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesLabelAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

