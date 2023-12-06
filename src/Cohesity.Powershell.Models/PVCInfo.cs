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
    /// Message that encapsulates information about a PVC. We only extract relevant information from a larger response sent by Kubernetes.
    /// </summary>
    [DataContract]
    public partial class PVCInfo :  IEquatable<PVCInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PVCInfo" /> class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values..</param>
        /// <param name="kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="spec">spec.</param>
        public PVCInfo(string apiVersion = default(string), string kind = default(string), ObjectMeta metadata = default(ObjectMeta), PVCInfoPVCSpec spec = default(PVCInfoPVCSpec))
        {
            this.ApiVersion = apiVersion;
            this.Kind = kind;
            this.ApiVersion = apiVersion;
            this.Kind = kind;
            this.Metadata = metadata;
            this.Spec = spec;
        }
        
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
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Spec
        /// </summary>
        [DataMember(Name="spec", EmitDefaultValue=false)]
        public PVCInfoPVCSpec Spec { get; set; }

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
            return this.Equals(input as PVCInfo);
        }

        /// <summary>
        /// Returns true if PVCInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PVCInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PVCInfo input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                return hashCode;
            }
        }

    }

}

