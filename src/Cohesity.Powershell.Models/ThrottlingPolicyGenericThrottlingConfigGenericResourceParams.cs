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
    /// The type/name of the resource can be encoded in the resource_id field. This can be looked up by RM when it wants to create a provider for the said resource.  Example:- This is being leveraged by UDAv2 connectors for resources linked to an entity in the source&#39;s entity hierarchy. The entity to which the resource is linked, is encoded in the resource_id. This information is parsed by RM when it wants to create a provider for an entity linked resource and wants to look up the capacity of the resource to be created.
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyGenericThrottlingConfigGenericResourceParams :  IEquatable<ThrottlingPolicyGenericThrottlingConfigGenericResourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyGenericThrottlingConfigGenericResourceParams" /> class.
        /// </summary>
        /// <param name="capacity">Resource capacity..</param>
        /// <param name="resourceId">ID of the resource to uniquely identify it across all entity linked resource across all entity linked providers.  E.g.: UDAv2 connector resources use the following resource ID convention:-  &lt;resource_name&gt;:&lt;magneto_entity_hash&gt;.</param>
        public ThrottlingPolicyGenericThrottlingConfigGenericResourceParams(double? capacity = default(double?), string resourceId = default(string))
        {
            this.Capacity = capacity;
            this.ResourceId = resourceId;
            this.Capacity = capacity;
            this.ResourceId = resourceId;
        }
        
        /// <summary>
        /// Resource capacity.
        /// </summary>
        /// <value>Resource capacity.</value>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public double? Capacity { get; set; }

        /// <summary>
        /// ID of the resource to uniquely identify it across all entity linked resource across all entity linked providers.  E.g.: UDAv2 connector resources use the following resource ID convention:-  &lt;resource_name&gt;:&lt;magneto_entity_hash&gt;
        /// </summary>
        /// <value>ID of the resource to uniquely identify it across all entity linked resource across all entity linked providers.  E.g.: UDAv2 connector resources use the following resource ID convention:-  &lt;resource_name&gt;:&lt;magneto_entity_hash&gt;</value>
        [DataMember(Name="resourceId", EmitDefaultValue=true)]
        public string ResourceId { get; set; }

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
            return this.Equals(input as ThrottlingPolicyGenericThrottlingConfigGenericResourceParams);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyGenericThrottlingConfigGenericResourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyGenericThrottlingConfigGenericResourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyGenericThrottlingConfigGenericResourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                return hashCode;
            }
        }

    }

}

