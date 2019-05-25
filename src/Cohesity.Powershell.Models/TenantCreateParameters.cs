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
    /// Specifies the settings used to create/add a new tenant.
    /// </summary>
    [DataContract]
    public partial class TenantCreateParameters :  IEquatable<TenantCreateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantCreateParameters" /> class.
        /// </summary>
        /// <param name="bifrostEnabled">Specifies whether bifrost (Ambassador proxy) is enabled for tenant..</param>
        /// <param name="description">Specifies the description of this tenant..</param>
        /// <param name="name">Specifies the name of the tenant..</param>
        /// <param name="orgSuffix">Specifies the organization suffix needed to construct tenant id. Tenant id is not completely auto generated rather chosen by tenant/SP admin as we needed same tenant id on multiple clusters to support replication across clusters, etc..</param>
        /// <param name="parentTenantId">Specifies the parent tenant of this tenant if available..</param>
        /// <param name="subscribeToAlertEmails">Service provider can optionally unsubscribe from the Tenant Alert Emails..</param>
        public TenantCreateParameters(bool? bifrostEnabled = default(bool?), string description = default(string), string name = default(string), string orgSuffix = default(string), string parentTenantId = default(string), bool? subscribeToAlertEmails = default(bool?))
        {
            this.BifrostEnabled = bifrostEnabled;
            this.Description = description;
            this.Name = name;
            this.OrgSuffix = orgSuffix;
            this.ParentTenantId = parentTenantId;
            this.SubscribeToAlertEmails = subscribeToAlertEmails;
            this.BifrostEnabled = bifrostEnabled;
            this.Description = description;
            this.Name = name;
            this.OrgSuffix = orgSuffix;
            this.ParentTenantId = parentTenantId;
            this.SubscribeToAlertEmails = subscribeToAlertEmails;
        }
        
        /// <summary>
        /// Specifies whether bifrost (Ambassador proxy) is enabled for tenant.
        /// </summary>
        /// <value>Specifies whether bifrost (Ambassador proxy) is enabled for tenant.</value>
        [DataMember(Name="bifrostEnabled", EmitDefaultValue=true)]
        public bool? BifrostEnabled { get; set; }

        /// <summary>
        /// Specifies the description of this tenant.
        /// </summary>
        /// <value>Specifies the description of this tenant.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the name of the tenant.
        /// </summary>
        /// <value>Specifies the name of the tenant.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the organization suffix needed to construct tenant id. Tenant id is not completely auto generated rather chosen by tenant/SP admin as we needed same tenant id on multiple clusters to support replication across clusters, etc.
        /// </summary>
        /// <value>Specifies the organization suffix needed to construct tenant id. Tenant id is not completely auto generated rather chosen by tenant/SP admin as we needed same tenant id on multiple clusters to support replication across clusters, etc.</value>
        [DataMember(Name="orgSuffix", EmitDefaultValue=true)]
        public string OrgSuffix { get; set; }

        /// <summary>
        /// Specifies the parent tenant of this tenant if available.
        /// </summary>
        /// <value>Specifies the parent tenant of this tenant if available.</value>
        [DataMember(Name="parentTenantId", EmitDefaultValue=true)]
        public string ParentTenantId { get; set; }

        /// <summary>
        /// Service provider can optionally unsubscribe from the Tenant Alert Emails.
        /// </summary>
        /// <value>Service provider can optionally unsubscribe from the Tenant Alert Emails.</value>
        [DataMember(Name="subscribeToAlertEmails", EmitDefaultValue=true)]
        public bool? SubscribeToAlertEmails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantCreateParameters {\n");
            sb.Append("  BifrostEnabled: ").Append(BifrostEnabled).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrgSuffix: ").Append(OrgSuffix).Append("\n");
            sb.Append("  ParentTenantId: ").Append(ParentTenantId).Append("\n");
            sb.Append("  SubscribeToAlertEmails: ").Append(SubscribeToAlertEmails).Append("\n");
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
            return this.Equals(input as TenantCreateParameters);
        }

        /// <summary>
        /// Returns true if TenantCreateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantCreateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantCreateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BifrostEnabled == input.BifrostEnabled ||
                    (this.BifrostEnabled != null &&
                    this.BifrostEnabled.Equals(input.BifrostEnabled))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrgSuffix == input.OrgSuffix ||
                    (this.OrgSuffix != null &&
                    this.OrgSuffix.Equals(input.OrgSuffix))
                ) && 
                (
                    this.ParentTenantId == input.ParentTenantId ||
                    (this.ParentTenantId != null &&
                    this.ParentTenantId.Equals(input.ParentTenantId))
                ) && 
                (
                    this.SubscribeToAlertEmails == input.SubscribeToAlertEmails ||
                    (this.SubscribeToAlertEmails != null &&
                    this.SubscribeToAlertEmails.Equals(input.SubscribeToAlertEmails))
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
                if (this.BifrostEnabled != null)
                    hashCode = hashCode * 59 + this.BifrostEnabled.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrgSuffix != null)
                    hashCode = hashCode * 59 + this.OrgSuffix.GetHashCode();
                if (this.ParentTenantId != null)
                    hashCode = hashCode * 59 + this.ParentTenantId.GetHashCode();
                if (this.SubscribeToAlertEmails != null)
                    hashCode = hashCode * 59 + this.SubscribeToAlertEmails.GetHashCode();
                return hashCode;
            }
        }

    }

}
