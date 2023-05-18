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
    /// Specifies information about role such as the category, privileges, description, etc. A role can be a default system role or a custom role. Custom roles are user-defined roles that are created using the Cohesity Dashboard, the REST API or the CLI. System roles are provided by default on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class Role :  IEquatable<Role>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="createdTimeMsecs">Specifies the epoch time in milliseconds when the role was created..</param>
        /// <param name="description">Specifies a description about the role..</param>
        /// <param name="isCustomRole">Specifies if the role is a user-defined custom role. If true, the role is a user-defined custom role that was created using the REST API, the Cohesity Dashboard or the CLI. If false, the role is a default system role that was created during Cluster creation..</param>
        /// <param name="label">Specifies the label for the role as displayed on the Cohesity Dashboard such as &#39;Viewer&#39;..</param>
        /// <param name="lastUpdatedTimeMsecs">Specifies the epoch time in milliseconds when the role was last modified..</param>
        /// <param name="name">Specifies the internal Cluster name for the role such as COHESITY_VIEWER. For custom roles, the name and the label are the same. For default system roles, the name and label are different..</param>
        /// <param name="privileges">Array of Privileges.  Specifies the privileges assigned to the role. When a user or group is assigned this role, these privileges define the operations the user or group can perform on the Cohesity Cluster..</param>
        /// <param name="tenantId">Specifies unique id of the tenant owning the role..</param>
        /// <param name="tenantIds">Specifies id of tenants using this role..</param>
        public Role(long? createdTimeMsecs = default(long?), string description = default(string), bool? isCustomRole = default(bool?), string label = default(string), long? lastUpdatedTimeMsecs = default(long?), string name = default(string), List<string> privileges = default(List<string>), string tenantId = default(string), List<string> tenantIds = default(List<string>))
        {
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.IsCustomRole = isCustomRole;
            this.Label = label;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.Name = name;
            this.Privileges = privileges;
            this.TenantId = tenantId;
            this.TenantIds = tenantIds;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.IsCustomRole = isCustomRole;
            this.Label = label;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.Name = name;
            this.Privileges = privileges;
            this.TenantId = tenantId;
            this.TenantIds = tenantIds;
        }
        
        /// <summary>
        /// Specifies the epoch time in milliseconds when the role was created.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the role was created.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies a description about the role.
        /// </summary>
        /// <value>Specifies a description about the role.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if the role is a user-defined custom role. If true, the role is a user-defined custom role that was created using the REST API, the Cohesity Dashboard or the CLI. If false, the role is a default system role that was created during Cluster creation.
        /// </summary>
        /// <value>Specifies if the role is a user-defined custom role. If true, the role is a user-defined custom role that was created using the REST API, the Cohesity Dashboard or the CLI. If false, the role is a default system role that was created during Cluster creation.</value>
        [DataMember(Name="isCustomRole", EmitDefaultValue=true)]
        public bool? IsCustomRole { get; set; }

        /// <summary>
        /// Specifies the label for the role as displayed on the Cohesity Dashboard such as &#39;Viewer&#39;.
        /// </summary>
        /// <value>Specifies the label for the role as displayed on the Cohesity Dashboard such as &#39;Viewer&#39;.</value>
        [DataMember(Name="label", EmitDefaultValue=true)]
        public string Label { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the role was last modified.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the role was last modified.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=true)]
        public long? LastUpdatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the internal Cluster name for the role such as COHESITY_VIEWER. For custom roles, the name and the label are the same. For default system roles, the name and label are different.
        /// </summary>
        /// <value>Specifies the internal Cluster name for the role such as COHESITY_VIEWER. For custom roles, the name and the label are the same. For default system roles, the name and label are different.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Array of Privileges.  Specifies the privileges assigned to the role. When a user or group is assigned this role, these privileges define the operations the user or group can perform on the Cohesity Cluster.
        /// </summary>
        /// <value>Array of Privileges.  Specifies the privileges assigned to the role. When a user or group is assigned this role, these privileges define the operations the user or group can perform on the Cohesity Cluster.</value>
        [DataMember(Name="privileges", EmitDefaultValue=true)]
        public List<string> Privileges { get; set; }

        /// <summary>
        /// Specifies unique id of the tenant owning the role.
        /// </summary>
        /// <value>Specifies unique id of the tenant owning the role.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies id of tenants using this role.
        /// </summary>
        /// <value>Specifies id of tenants using this role.</value>
        [DataMember(Name="tenantIds", EmitDefaultValue=true)]
        public List<string> TenantIds { get; set; }

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
            return this.Equals(input as Role);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="input">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsCustomRole == input.IsCustomRole ||
                    (this.IsCustomRole != null &&
                    this.IsCustomRole.Equals(input.IsCustomRole))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    this.Privileges != null &&
                    input.Privileges != null &&
                    this.Privileges.SequenceEqual(input.Privileges)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.TenantIds == input.TenantIds ||
                    this.TenantIds != null &&
                    input.TenantIds != null &&
                    this.TenantIds.SequenceEqual(input.TenantIds)
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
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsCustomRole != null)
                    hashCode = hashCode * 59 + this.IsCustomRole.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantIds != null)
                    hashCode = hashCode * 59 + this.TenantIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

