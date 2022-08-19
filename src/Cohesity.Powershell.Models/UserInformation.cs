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
    /// A message to encapsulate information about the user who made the request. Request should be filtered by these fields if specified so that only the objects that the user is permissioned for are returned. If both sid_vec &amp; tenant_id are specified then an intersection of respective results should be returned.
    /// </summary>
    [DataContract]
    public partial class UserInformation :  IEquatable<UserInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInformation" /> class.
        /// </summary>
        /// <param name="includeSubtenantObjects">Whether objects owned by subtenants should be returned. This would require a prefix search with the passed tenant_id. All tenants are considered sub-tenants of the admin. For GET requests, if tenant id is empty(admin user is querying) and if this flag is false, we will only return untagged objects. If it is true, we will return everything..</param>
        /// <param name="pulseAttributeVec">Specifies the KeyValuePair that client (eg. Iris) wants to persist along with the corresponding (soon-to-be-created) Pulse task for the current action. Eg. pulse_attribute_vec can drive user notifications by associating a Pulse Task with user SID and later Pulse can be searched by client specified Sid to get all finished tasks for the logged in user..</param>
        /// <param name="sidVec">If specified, only the objects associated with these SIDs should be returned..</param>
        /// <param name="tenantIdVec">If specified, only the objects associated with this tenant should be returned. A given tenant ID is always a prefix of the ids of its subtenants. Eg. if tenant_id of cluster admin is empty string then it will be a prefix match for all the tenants on the cluster..</param>
        public UserInformation(bool? includeSubtenantObjects = default(bool?), List<KeyValuePair> pulseAttributeVec = default(List<KeyValuePair>), List<ClusterConfigProtoSID> sidVec = default(List<ClusterConfigProtoSID>), List<string> tenantIdVec = default(List<string>))
        {
            this.IncludeSubtenantObjects = includeSubtenantObjects;
            this.PulseAttributeVec = pulseAttributeVec;
            this.SidVec = sidVec;
            this.TenantIdVec = tenantIdVec;
            this.IncludeSubtenantObjects = includeSubtenantObjects;
            this.PulseAttributeVec = pulseAttributeVec;
            this.SidVec = sidVec;
            this.TenantIdVec = tenantIdVec;
        }
        
        /// <summary>
        /// Whether objects owned by subtenants should be returned. This would require a prefix search with the passed tenant_id. All tenants are considered sub-tenants of the admin. For GET requests, if tenant id is empty(admin user is querying) and if this flag is false, we will only return untagged objects. If it is true, we will return everything.
        /// </summary>
        /// <value>Whether objects owned by subtenants should be returned. This would require a prefix search with the passed tenant_id. All tenants are considered sub-tenants of the admin. For GET requests, if tenant id is empty(admin user is querying) and if this flag is false, we will only return untagged objects. If it is true, we will return everything.</value>
        [DataMember(Name="includeSubtenantObjects", EmitDefaultValue=true)]
        public bool? IncludeSubtenantObjects { get; set; }

        /// <summary>
        /// Specifies the KeyValuePair that client (eg. Iris) wants to persist along with the corresponding (soon-to-be-created) Pulse task for the current action. Eg. pulse_attribute_vec can drive user notifications by associating a Pulse Task with user SID and later Pulse can be searched by client specified Sid to get all finished tasks for the logged in user.
        /// </summary>
        /// <value>Specifies the KeyValuePair that client (eg. Iris) wants to persist along with the corresponding (soon-to-be-created) Pulse task for the current action. Eg. pulse_attribute_vec can drive user notifications by associating a Pulse Task with user SID and later Pulse can be searched by client specified Sid to get all finished tasks for the logged in user.</value>
        [DataMember(Name="pulseAttributeVec", EmitDefaultValue=true)]
        public List<KeyValuePair> PulseAttributeVec { get; set; }

        /// <summary>
        /// If specified, only the objects associated with these SIDs should be returned.
        /// </summary>
        /// <value>If specified, only the objects associated with these SIDs should be returned.</value>
        [DataMember(Name="sidVec", EmitDefaultValue=true)]
        public List<ClusterConfigProtoSID> SidVec { get; set; }

        /// <summary>
        /// If specified, only the objects associated with this tenant should be returned. A given tenant ID is always a prefix of the ids of its subtenants. Eg. if tenant_id of cluster admin is empty string then it will be a prefix match for all the tenants on the cluster.
        /// </summary>
        /// <value>If specified, only the objects associated with this tenant should be returned. A given tenant ID is always a prefix of the ids of its subtenants. Eg. if tenant_id of cluster admin is empty string then it will be a prefix match for all the tenants on the cluster.</value>
        [DataMember(Name="tenantIdVec", EmitDefaultValue=true)]
        public List<string> TenantIdVec { get; set; }

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
            return this.Equals(input as UserInformation);
        }

        /// <summary>
        /// Returns true if UserInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeSubtenantObjects == input.IncludeSubtenantObjects ||
                    (this.IncludeSubtenantObjects != null &&
                    this.IncludeSubtenantObjects.Equals(input.IncludeSubtenantObjects))
                ) && 
                (
                    this.PulseAttributeVec == input.PulseAttributeVec ||
                    this.PulseAttributeVec != null &&
                    input.PulseAttributeVec != null &&
                    this.PulseAttributeVec.Equals(input.PulseAttributeVec)
                ) && 
                (
                    this.SidVec == input.SidVec ||
                    this.SidVec != null &&
                    input.SidVec != null &&
                    this.SidVec.Equals(input.SidVec)
                ) && 
                (
                    this.TenantIdVec == input.TenantIdVec ||
                    this.TenantIdVec != null &&
                    input.TenantIdVec != null &&
                    this.TenantIdVec.Equals(input.TenantIdVec)
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
                if (this.IncludeSubtenantObjects != null)
                    hashCode = hashCode * 59 + this.IncludeSubtenantObjects.GetHashCode();
                if (this.PulseAttributeVec != null)
                    hashCode = hashCode * 59 + this.PulseAttributeVec.GetHashCode();
                if (this.SidVec != null)
                    hashCode = hashCode * 59 + this.SidVec.GetHashCode();
                if (this.TenantIdVec != null)
                    hashCode = hashCode * 59 + this.TenantIdVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

