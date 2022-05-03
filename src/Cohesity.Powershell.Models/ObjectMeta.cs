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
    /// ObjectMeta
    /// </summary>
    [DataContract]
    public partial class ObjectMeta :  IEquatable<ObjectMeta>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectMeta" /> class.
        /// </summary>
        /// <param name="annotations">Annotations added to the object..</param>
        /// <param name="labels">A set of key-value pairs, capturing the labels of a k8s object..</param>
        /// <param name="name">Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated..</param>
        /// <param name="_namespace">Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \&quot;default\&quot; namespace, but \&quot;default\&quot; is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty..</param>
        /// <param name="uid">UUID of the object queried..</param>
        public ObjectMeta(List<ObjectMetaAnnotationsEntry> annotations = default(List<ObjectMetaAnnotationsEntry>), List<ObjectMetaLabelsEntry> labels = default(List<ObjectMetaLabelsEntry>), string name = default(string), string _namespace = default(string), string uid = default(string))
        {
            this.Annotations = annotations;
            this.Labels = labels;
            this.Name = name;
            this.Namespace = _namespace;
            this.Uid = uid;
        }
        
        /// <summary>
        /// Annotations added to the object.
        /// </summary>
        /// <value>Annotations added to the object.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public List<ObjectMetaAnnotationsEntry> Annotations { get; set; }

        /// <summary>
        /// A set of key-value pairs, capturing the labels of a k8s object.
        /// </summary>
        /// <value>A set of key-value pairs, capturing the labels of a k8s object.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<ObjectMetaLabelsEntry> Labels { get; set; }

        /// <summary>
        /// Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated.
        /// </summary>
        /// <value>Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \&quot;default\&quot; namespace, but \&quot;default\&quot; is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.
        /// </summary>
        /// <value>Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \&quot;default\&quot; namespace, but \&quot;default\&quot; is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// UUID of the object queried.
        /// </summary>
        /// <value>UUID of the object queried.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }

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
            return this.Equals(input as ObjectMeta);
        }

        /// <summary>
        /// Returns true if ObjectMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    this.Annotations.Equals(input.Annotations)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.Equals(input.Labels)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
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
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                return hashCode;
            }
        }

    }

}

