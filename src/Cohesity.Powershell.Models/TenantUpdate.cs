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
    /// Specifies update details about a tenant.
    /// </summary>
    [DataContract]
    public partial class TenantUpdate :  IEquatable<TenantUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUpdate" /> class.
        /// </summary>
        /// <param name="bifrostEnabled">Specifies whether bifrost (Ambassador proxy) is enabled for tenant..</param>
        /// <param name="clusterHostname">The hostname for Cohesity cluster as seen by tenants and as is routable from the tenant&#39;s network. Tenant&#39;s VLAN&#39;s hostname, if available can be used instead but it is mandatory to provide this value if there&#39;s no VLAN hostname to use. Also, when set, this field would take precedence over VLAN hostname..</param>
        /// <param name="clusterIps">Set of IPs as seen from the tenant&#39;s network for the Cohesity cluster. Only one from &#39;ClusterHostname&#39; and &#39;ClusterIps&#39; is needed..</param>
        /// <param name="description">Specifies the description of this tenant..</param>
        /// <param name="isManagedOnHelios">Specifies whether this tenant is manged on helios.</param>
        /// <param name="name">Specifies the name of the tenant..</param>
        /// <param name="subscribeToAlertEmails">Service provider can optionally unsubscribe from the Tenant Alert Emails..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public TenantUpdate(bool? bifrostEnabled = default(bool?), string clusterHostname = default(string), List<string> clusterIps = default(List<string>), string description = default(string), bool? isManagedOnHelios = default(bool?), string name = default(string), bool? subscribeToAlertEmails = default(bool?), string tenantId = default(string))
        {
            this.BifrostEnabled = bifrostEnabled;
            this.ClusterHostname = clusterHostname;
            this.ClusterIps = clusterIps;
            this.Description = description;
            this.IsManagedOnHelios = isManagedOnHelios;
            this.Name = name;
            this.SubscribeToAlertEmails = subscribeToAlertEmails;
            this.TenantId = tenantId;
            this.BifrostEnabled = bifrostEnabled;
            this.ClusterHostname = clusterHostname;
            this.ClusterIps = clusterIps;
            this.Description = description;
            this.IsManagedOnHelios = isManagedOnHelios;
            this.Name = name;
            this.SubscribeToAlertEmails = subscribeToAlertEmails;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies whether bifrost (Ambassador proxy) is enabled for tenant.
        /// </summary>
        /// <value>Specifies whether bifrost (Ambassador proxy) is enabled for tenant.</value>
        [DataMember(Name="bifrostEnabled", EmitDefaultValue=true)]
        public bool? BifrostEnabled { get; set; }

        /// <summary>
        /// The hostname for Cohesity cluster as seen by tenants and as is routable from the tenant&#39;s network. Tenant&#39;s VLAN&#39;s hostname, if available can be used instead but it is mandatory to provide this value if there&#39;s no VLAN hostname to use. Also, when set, this field would take precedence over VLAN hostname.
        /// </summary>
        /// <value>The hostname for Cohesity cluster as seen by tenants and as is routable from the tenant&#39;s network. Tenant&#39;s VLAN&#39;s hostname, if available can be used instead but it is mandatory to provide this value if there&#39;s no VLAN hostname to use. Also, when set, this field would take precedence over VLAN hostname.</value>
        [DataMember(Name="clusterHostname", EmitDefaultValue=true)]
        public string ClusterHostname { get; set; }

        /// <summary>
        /// Set of IPs as seen from the tenant&#39;s network for the Cohesity cluster. Only one from &#39;ClusterHostname&#39; and &#39;ClusterIps&#39; is needed.
        /// </summary>
        /// <value>Set of IPs as seen from the tenant&#39;s network for the Cohesity cluster. Only one from &#39;ClusterHostname&#39; and &#39;ClusterIps&#39; is needed.</value>
        [DataMember(Name="clusterIps", EmitDefaultValue=true)]
        public List<string> ClusterIps { get; set; }

        /// <summary>
        /// Specifies the description of this tenant.
        /// </summary>
        /// <value>Specifies the description of this tenant.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether this tenant is manged on helios
        /// </summary>
        /// <value>Specifies whether this tenant is manged on helios</value>
        [DataMember(Name="isManagedOnHelios", EmitDefaultValue=true)]
        public bool? IsManagedOnHelios { get; set; }

        /// <summary>
        /// Specifies the name of the tenant.
        /// </summary>
        /// <value>Specifies the name of the tenant.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Service provider can optionally unsubscribe from the Tenant Alert Emails.
        /// </summary>
        /// <value>Service provider can optionally unsubscribe from the Tenant Alert Emails.</value>
        [DataMember(Name="subscribeToAlertEmails", EmitDefaultValue=true)]
        public bool? SubscribeToAlertEmails { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

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
            return this.Equals(input as TenantUpdate);
        }

        /// <summary>
        /// Returns true if TenantUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantUpdate input)
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
                    this.ClusterHostname == input.ClusterHostname ||
                    (this.ClusterHostname != null &&
                    this.ClusterHostname.Equals(input.ClusterHostname))
                ) && 
                (
                    this.ClusterIps == input.ClusterIps ||
                    this.ClusterIps != null &&
                    input.ClusterIps != null &&
                    this.ClusterIps.SequenceEqual(input.ClusterIps)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsManagedOnHelios == input.IsManagedOnHelios ||
                    (this.IsManagedOnHelios != null &&
                    this.IsManagedOnHelios.Equals(input.IsManagedOnHelios))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubscribeToAlertEmails == input.SubscribeToAlertEmails ||
                    (this.SubscribeToAlertEmails != null &&
                    this.SubscribeToAlertEmails.Equals(input.SubscribeToAlertEmails))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.ClusterHostname != null)
                    hashCode = hashCode * 59 + this.ClusterHostname.GetHashCode();
                if (this.ClusterIps != null)
                    hashCode = hashCode * 59 + this.ClusterIps.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsManagedOnHelios != null)
                    hashCode = hashCode * 59 + this.IsManagedOnHelios.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubscribeToAlertEmails != null)
                    hashCode = hashCode * 59 + this.SubscribeToAlertEmails.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

