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
    /// StatsGroup describes the details of a stats group. A stats group is a basic group of usage stats, it is the usage of a tenant within a storage domain may also for a specific consumer type.
    /// </summary>
    [DataContract]
    public partial class StatsGroup :  IEquatable<StatsGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsGroup" /> class.
        /// </summary>
        /// <param name="consumer">consumer.</param>
        /// <param name="entityId">Specifies the entity id of the group..</param>
        /// <param name="id">Specifies the id of the group..</param>
        /// <param name="name">Specifies the name of the group..</param>
        /// <param name="tenantId">Specifies the id of the organization (tenant) with respect to this group..</param>
        /// <param name="tenantName">Specifies the name of the organization (tenant) with respect to this group..</param>
        /// <param name="viewBoxId">Specifies the id of the view box (storage domain) with respect to this group..</param>
        /// <param name="viewBoxName">Specifies the name of the view box (storage domain) with respect to this group..</param>
        public StatsGroup(Consumer consumer = default(Consumer), string entityId = default(string), long? id = default(long?), string name = default(string), string tenantId = default(string), string tenantName = default(string), long? viewBoxId = default(long?), string viewBoxName = default(string))
        {
            this.Consumer = consumer;
            this.EntityId = entityId;
            this.Id = id;
            this.Name = name;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
            this.ViewBoxId = viewBoxId;
            this.ViewBoxName = viewBoxName;
        }
        
        /// <summary>
        /// Gets or Sets Consumer
        /// </summary>
        [DataMember(Name="consumer", EmitDefaultValue=false)]
        public Consumer Consumer { get; set; }

        /// <summary>
        /// Specifies the entity id of the group.
        /// </summary>
        /// <value>Specifies the entity id of the group.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Specifies the id of the group.
        /// </summary>
        /// <value>Specifies the id of the group.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the group.
        /// </summary>
        /// <value>Specifies the name of the group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the id of the organization (tenant) with respect to this group.
        /// </summary>
        /// <value>Specifies the id of the organization (tenant) with respect to this group.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the name of the organization (tenant) with respect to this group.
        /// </summary>
        /// <value>Specifies the name of the organization (tenant) with respect to this group.</value>
        [DataMember(Name="tenantName", EmitDefaultValue=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// Specifies the id of the view box (storage domain) with respect to this group.
        /// </summary>
        /// <value>Specifies the id of the view box (storage domain) with respect to this group.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Specifies the name of the view box (storage domain) with respect to this group.
        /// </summary>
        /// <value>Specifies the name of the view box (storage domain) with respect to this group.</value>
        [DataMember(Name="viewBoxName", EmitDefaultValue=false)]
        public string ViewBoxName { get; set; }

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
            return this.Equals(input as StatsGroup);
        }

        /// <summary>
        /// Returns true if StatsGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of StatsGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatsGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Consumer == input.Consumer ||
                    (this.Consumer != null &&
                    this.Consumer.Equals(input.Consumer))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.TenantName == input.TenantName ||
                    (this.TenantName != null &&
                    this.TenantName.Equals(input.TenantName))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewBoxName == input.ViewBoxName ||
                    (this.ViewBoxName != null &&
                    this.ViewBoxName.Equals(input.ViewBoxName))
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
                if (this.Consumer != null)
                    hashCode = hashCode * 59 + this.Consumer.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewBoxName != null)
                    hashCode = hashCode * 59 + this.ViewBoxName.GetHashCode();
                return hashCode;
            }
        }

    }

}

