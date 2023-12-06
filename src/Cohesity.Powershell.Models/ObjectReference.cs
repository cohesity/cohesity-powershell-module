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
    /// ObjectReference contains enough information to let you inspect or modify the referred object.
    /// </summary>
    [DataContract]
    public partial class ObjectReference :  IEquatable<ObjectReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectReference" /> class.
        /// </summary>
        /// <param name="apiGroup">API group make it easier to extend the Kubernetes API. The API group is specified in a REST path and in the apiVersion field..</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values..</param>
        /// <param name="kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to..</param>
        /// <param name="name">Name of the referent..</param>
        /// <param name="_namespace">Namespace of the referent..</param>
        /// <param name="resourceVersion">Specific resourceVersion to which this reference is made, if any..</param>
        /// <param name="uid">UID of the referent..</param>
        public ObjectReference(string apiGroup = default(string), string apiVersion = default(string), string kind = default(string), string name = default(string), string _namespace = default(string), string resourceVersion = default(string), string uid = default(string))
        {
            this.ApiGroup = apiGroup;
            this.ApiVersion = apiVersion;
            this.Kind = kind;
            this.Name = name;
            this.Namespace = _namespace;
            this.ResourceVersion = resourceVersion;
            this.Uid = uid;
            this.ApiGroup = apiGroup;
            this.ApiVersion = apiVersion;
            this.Kind = kind;
            this.Name = name;
            this.Namespace = _namespace;
            this.ResourceVersion = resourceVersion;
            this.Uid = uid;
        }
        
        /// <summary>
        /// API group make it easier to extend the Kubernetes API. The API group is specified in a REST path and in the apiVersion field.
        /// </summary>
        /// <value>API group make it easier to extend the Kubernetes API. The API group is specified in a REST path and in the apiVersion field.</value>
        [DataMember(Name="apiGroup", EmitDefaultValue=true)]
        public string ApiGroup { get; set; }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values.
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values.</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=true)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to.
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to.</value>
        [DataMember(Name="kind", EmitDefaultValue=true)]
        public string Kind { get; set; }

        /// <summary>
        /// Name of the referent.
        /// </summary>
        /// <value>Name of the referent.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Namespace of the referent.
        /// </summary>
        /// <value>Namespace of the referent.</value>
        [DataMember(Name="namespace", EmitDefaultValue=true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Specific resourceVersion to which this reference is made, if any.
        /// </summary>
        /// <value>Specific resourceVersion to which this reference is made, if any.</value>
        [DataMember(Name="resourceVersion", EmitDefaultValue=true)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// UID of the referent.
        /// </summary>
        /// <value>UID of the referent.</value>
        [DataMember(Name="uid", EmitDefaultValue=true)]
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
            return this.Equals(input as ObjectReference);
        }

        /// <summary>
        /// Returns true if ObjectReference instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiGroup == input.ApiGroup ||
                    (this.ApiGroup != null &&
                    this.ApiGroup.Equals(input.ApiGroup))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
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
                    this.ResourceVersion == input.ResourceVersion ||
                    (this.ResourceVersion != null &&
                    this.ResourceVersion.Equals(input.ResourceVersion))
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
                if (this.ApiGroup != null)
                    hashCode = hashCode * 59 + this.ApiGroup.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ResourceVersion != null)
                    hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                return hashCode;
            }
        }

    }

}

