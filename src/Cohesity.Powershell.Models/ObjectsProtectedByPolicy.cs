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
    /// Objects (e.g. VMs) protected by Policy.
    /// </summary>
    [DataContract]
    public partial class ObjectsProtectedByPolicy :  IEquatable<ObjectsProtectedByPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsProtectedByPolicy" /> class.
        /// </summary>
        /// <param name="objectsProtected">Protected Objects..</param>
        /// <param name="policyId">Id of the policy..</param>
        /// <param name="policyName">Name of the policy..</param>
        public ObjectsProtectedByPolicy(List<ObjectsByEnv> objectsProtected = default(List<ObjectsByEnv>), string policyId = default(string), string policyName = default(string))
        {
            this.ObjectsProtected = objectsProtected;
            this.PolicyId = policyId;
            this.PolicyName = policyName;
            this.ObjectsProtected = objectsProtected;
            this.PolicyId = policyId;
            this.PolicyName = policyName;
        }
        
        /// <summary>
        /// Protected Objects.
        /// </summary>
        /// <value>Protected Objects.</value>
        [DataMember(Name="objectsProtected", EmitDefaultValue=true)]
        public List<ObjectsByEnv> ObjectsProtected { get; set; }

        /// <summary>
        /// Id of the policy.
        /// </summary>
        /// <value>Id of the policy.</value>
        [DataMember(Name="policyId", EmitDefaultValue=true)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Name of the policy.
        /// </summary>
        /// <value>Name of the policy.</value>
        [DataMember(Name="policyName", EmitDefaultValue=true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectsProtectedByPolicy {\n");
            sb.Append("  ObjectsProtected: ").Append(ObjectsProtected).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as ObjectsProtectedByPolicy);
        }

        /// <summary>
        /// Returns true if ObjectsProtectedByPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectsProtectedByPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectsProtectedByPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectsProtected == input.ObjectsProtected ||
                    this.ObjectsProtected != null &&
                    input.ObjectsProtected != null &&
                    this.ObjectsProtected.SequenceEqual(input.ObjectsProtected)
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
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
                if (this.ObjectsProtected != null)
                    hashCode = hashCode * 59 + this.ObjectsProtected.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                return hashCode;
            }
        }

    }

}
