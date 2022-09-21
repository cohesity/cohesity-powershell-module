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
    /// TenantAccess
    /// </summary>
    [DataContract]
    public partial class TenantAccess :  IEquatable<TenantAccess>
    {
        /// <summary>
        /// Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;Mcm&#39; implies tenant is Mcm Cluster tenant.
        /// </summary>
        /// <value>Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;Mcm&#39; implies tenant is Mcm Cluster tenant.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TenantTypeEnum
        {
            /// <summary>
            /// Enum Dmaas for value: Dmaas
            /// </summary>
            [EnumMember(Value = "Dmaas")]
            Dmaas = 1,

            /// <summary>
            /// Enum Mcm for value: Mcm
            /// </summary>
            [EnumMember(Value = "Mcm")]
            Mcm = 2

        }

        /// <summary>
        /// Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;Mcm&#39; implies tenant is Mcm Cluster tenant.
        /// </summary>
        /// <value>Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;Mcm&#39; implies tenant is Mcm Cluster tenant.</value>
        [DataMember(Name="tenantType", EmitDefaultValue=true)]
        public TenantTypeEnum? TenantType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantAccess" /> class.
        /// </summary>
        /// <param name="clusterIdentifiers">Specifies the list of clusters..</param>
        /// <param name="createdTimeMsecs">Specifies the epoch time in milliseconds when the tenant access was created..</param>
        /// <param name="effectiveTimeMsecs">Specifies the epoch time in milliseconds when the tenant access becomes effective. Until that time, the user cannot log in..</param>
        /// <param name="expiredTimeMsecs">Specifies the epoch time in milliseconds when the tenant access becomes expired. After that, the user cannot log in..</param>
        /// <param name="isAccessActive">IsAccessActive specifies whether or not a tenant access is active, or has been deactivated by the customer. The default behavior is &#39;true&#39;..</param>
        /// <param name="isActive">Specifies whether or not the tenant is active..</param>
        /// <param name="isDeleted">Specifies whether or not the tenant is deleted..</param>
        /// <param name="lastUpdatedTimeMsecs">Specifies the epoch time in milliseconds when the tenant access was last modified..</param>
        /// <param name="roles">Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;..</param>
        /// <param name="tenantId">Specifies the tenant id..</param>
        /// <param name="tenantName">Specifies the tenant name..</param>
        /// <param name="tenantType">Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;Mcm&#39; implies tenant is Mcm Cluster tenant..</param>
        public TenantAccess(List<ClusterIdentifier> clusterIdentifiers = default(List<ClusterIdentifier>), long? createdTimeMsecs = default(long?), long? effectiveTimeMsecs = default(long?), long? expiredTimeMsecs = default(long?), bool? isAccessActive = default(bool?), bool? isActive = default(bool?), bool? isDeleted = default(bool?), long? lastUpdatedTimeMsecs = default(long?), List<string> roles = default(List<string>), string tenantId = default(string), string tenantName = default(string), TenantTypeEnum? tenantType = default(TenantTypeEnum?))
        {
            this.ClusterIdentifiers = clusterIdentifiers;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.EffectiveTimeMsecs = effectiveTimeMsecs;
            this.ExpiredTimeMsecs = expiredTimeMsecs;
            this.IsAccessActive = isAccessActive;
            this.IsActive = isActive;
            this.IsDeleted = isDeleted;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.Roles = roles;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
            this.TenantType = tenantType;
            this.ClusterIdentifiers = clusterIdentifiers;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.EffectiveTimeMsecs = effectiveTimeMsecs;
            this.ExpiredTimeMsecs = expiredTimeMsecs;
            this.IsAccessActive = isAccessActive;
            this.IsActive = isActive;
            this.IsDeleted = isDeleted;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.Roles = roles;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
            this.TenantType = tenantType;
        }
        
        /// <summary>
        /// Specifies the list of clusters.
        /// </summary>
        /// <value>Specifies the list of clusters.</value>
        [DataMember(Name="clusterIdentifiers", EmitDefaultValue=true)]
        public List<ClusterIdentifier> ClusterIdentifiers { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the tenant access was created.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the tenant access was created.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the tenant access becomes effective. Until that time, the user cannot log in.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the tenant access becomes effective. Until that time, the user cannot log in.</value>
        [DataMember(Name="effectiveTimeMsecs", EmitDefaultValue=true)]
        public long? EffectiveTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the tenant access becomes expired. After that, the user cannot log in.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the tenant access becomes expired. After that, the user cannot log in.</value>
        [DataMember(Name="expiredTimeMsecs", EmitDefaultValue=true)]
        public long? ExpiredTimeMsecs { get; set; }

        /// <summary>
        /// IsAccessActive specifies whether or not a tenant access is active, or has been deactivated by the customer. The default behavior is &#39;true&#39;.
        /// </summary>
        /// <value>IsAccessActive specifies whether or not a tenant access is active, or has been deactivated by the customer. The default behavior is &#39;true&#39;.</value>
        [DataMember(Name="isAccessActive", EmitDefaultValue=true)]
        public bool? IsAccessActive { get; set; }

        /// <summary>
        /// Specifies whether or not the tenant is active.
        /// </summary>
        /// <value>Specifies whether or not the tenant is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies whether or not the tenant is deleted.
        /// </summary>
        /// <value>Specifies whether or not the tenant is deleted.</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the tenant access was last modified.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the tenant access was last modified.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=true)]
        public long? LastUpdatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;.
        /// </summary>
        /// <value>Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;.</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the tenant id.
        /// </summary>
        /// <value>Specifies the tenant id.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the tenant name.
        /// </summary>
        /// <value>Specifies the tenant name.</value>
        [DataMember(Name="tenantName", EmitDefaultValue=true)]
        public string TenantName { get; set; }

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
            return this.Equals(input as TenantAccess);
        }

        /// <summary>
        /// Returns true if TenantAccess instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantAccess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterIdentifiers == input.ClusterIdentifiers ||
                    this.ClusterIdentifiers != null &&
                    input.ClusterIdentifiers != null &&
                    this.ClusterIdentifiers.Equals(input.ClusterIdentifiers)
                ) && 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.EffectiveTimeMsecs == input.EffectiveTimeMsecs ||
                    (this.EffectiveTimeMsecs != null &&
                    this.EffectiveTimeMsecs.Equals(input.EffectiveTimeMsecs))
                ) && 
                (
                    this.ExpiredTimeMsecs == input.ExpiredTimeMsecs ||
                    (this.ExpiredTimeMsecs != null &&
                    this.ExpiredTimeMsecs.Equals(input.ExpiredTimeMsecs))
                ) && 
                (
                    this.IsAccessActive == input.IsAccessActive ||
                    (this.IsAccessActive != null &&
                    this.IsAccessActive.Equals(input.IsAccessActive))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.Equals(input.Roles)
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
                    this.TenantType == input.TenantType ||
                    this.TenantType.Equals(input.TenantType)
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
                if (this.ClusterIdentifiers != null)
                    hashCode = hashCode * 59 + this.ClusterIdentifiers.GetHashCode();
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.EffectiveTimeMsecs != null)
                    hashCode = hashCode * 59 + this.EffectiveTimeMsecs.GetHashCode();
                if (this.ExpiredTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiredTimeMsecs.GetHashCode();
                if (this.IsAccessActive != null)
                    hashCode = hashCode * 59 + this.IsAccessActive.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                hashCode = hashCode * 59 + this.TenantType.GetHashCode();
                return hashCode;
            }
        }

    }

}

