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
    /// Specifies the permission information of entities.
    /// </summary>
    [DataContract]
    public partial class EntityPermissionInformation :  IEquatable<EntityPermissionInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPermissionInformation" /> class.
        /// </summary>
        /// <param name="entityId">Specifies the entity id..</param>
        /// <param name="groups">Specifies groups that have access to entity in case of restricted user..</param>
        /// <param name="isInferred">Specifies whether the Entity Permission Information is inferred or not. For example, SQL application hosted over vCenter will have inferred entity permission information..</param>
        /// <param name="isRegisteredBySp">Specifies whether this entity is registered by the SP or not. This will be populated only if the entity is a root entity. Refer to magneto/base/permissions.proto for details..</param>
        /// <param name="registeringTenantId">Specifies the tenant id that registered this entity. This will be populated only if the entity is a root entity..</param>
        /// <param name="tenant">tenant.</param>
        /// <param name="users">Specifies users that have access to entity in case of restricted user..</param>
        public EntityPermissionInformation(long? entityId = default(long?), List<GroupInfo> groups = default(List<GroupInfo>), bool? isInferred = default(bool?), bool? isRegisteredBySp = default(bool?), string registeringTenantId = default(string), TenantInfo tenant = default(TenantInfo), List<UserInfo> users = default(List<UserInfo>))
        {
            this.EntityId = entityId;
            this.Groups = groups;
            this.IsInferred = isInferred;
            this.IsRegisteredBySp = isRegisteredBySp;
            this.RegisteringTenantId = registeringTenantId;
            this.Users = users;
        }
        
        /// <summary>
        /// Specifies the entity id.
        /// </summary>
        /// <value>Specifies the entity id.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies groups that have access to entity in case of restricted user.
        /// </summary>
        /// <value>Specifies groups that have access to entity in case of restricted user.</value>
        [DataMember(Name="groups", EmitDefaultValue=true)]
        public List<GroupInfo> Groups { get; set; }

        /// <summary>
        /// Specifies whether the Entity Permission Information is inferred or not. For example, SQL application hosted over vCenter will have inferred entity permission information.
        /// </summary>
        /// <value>Specifies whether the Entity Permission Information is inferred or not. For example, SQL application hosted over vCenter will have inferred entity permission information.</value>
        [DataMember(Name="isInferred", EmitDefaultValue=true)]
        public bool? IsInferred { get; set; }

        /// <summary>
        /// Specifies whether this entity is registered by the SP or not. This will be populated only if the entity is a root entity. Refer to magneto/base/permissions.proto for details.
        /// </summary>
        /// <value>Specifies whether this entity is registered by the SP or not. This will be populated only if the entity is a root entity. Refer to magneto/base/permissions.proto for details.</value>
        [DataMember(Name="isRegisteredBySp", EmitDefaultValue=true)]
        public bool? IsRegisteredBySp { get; set; }

        /// <summary>
        /// Specifies the tenant id that registered this entity. This will be populated only if the entity is a root entity.
        /// </summary>
        /// <value>Specifies the tenant id that registered this entity. This will be populated only if the entity is a root entity.</value>
        [DataMember(Name="registeringTenantId", EmitDefaultValue=true)]
        public string RegisteringTenantId { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=false)]
        public TenantInfo Tenant { get; set; }

        /// <summary>
        /// Specifies users that have access to entity in case of restricted user.
        /// </summary>
        /// <value>Specifies users that have access to entity in case of restricted user.</value>
        [DataMember(Name="users", EmitDefaultValue=true)]
        public List<UserInfo> Users { get; set; }

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
            return this.Equals(input as EntityPermissionInformation);
        }

        /// <summary>
        /// Returns true if EntityPermissionInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityPermissionInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityPermissionInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.Equals(input.Groups)
                ) && 
                (
                    this.IsInferred == input.IsInferred ||
                    (this.IsInferred != null &&
                    this.IsInferred.Equals(input.IsInferred))
                ) && 
                (
                    this.IsRegisteredBySp == input.IsRegisteredBySp ||
                    (this.IsRegisteredBySp != null &&
                    this.IsRegisteredBySp.Equals(input.IsRegisteredBySp))
                ) && 
                (
                    this.RegisteringTenantId == input.RegisteringTenantId ||
                    (this.RegisteringTenantId != null &&
                    this.RegisteringTenantId.Equals(input.RegisteringTenantId))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.Equals(input.Users)
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.IsInferred != null)
                    hashCode = hashCode * 59 + this.IsInferred.GetHashCode();
                if (this.IsRegisteredBySp != null)
                    hashCode = hashCode * 59 + this.IsRegisteredBySp.GetHashCode();
                if (this.RegisteringTenantId != null)
                    hashCode = hashCode * 59 + this.RegisteringTenantId.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }

    }

}

