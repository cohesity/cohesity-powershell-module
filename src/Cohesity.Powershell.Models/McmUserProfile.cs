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
    /// McmUserProfile
    /// </summary>
    [DataContract]
    public partial class McmUserProfile :  IEquatable<McmUserProfile>
    {
        /// <summary>
        /// Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;OnPrem&#39; implies tenant is cluster tenant.
        /// </summary>
        /// <value>Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;OnPrem&#39; implies tenant is cluster tenant.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TenantTypeEnum
        {
            /// <summary>
            /// Enum Dmaas for value: Dmaas
            /// </summary>
            [EnumMember(Value = "Dmaas")]
            Dmaas = 1,

            /// <summary>
            /// Enum OnPrem for value: OnPrem
            /// </summary>
            [EnumMember(Value = "OnPrem")]
            OnPrem = 2

        }

        /// <summary>
        /// Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;OnPrem&#39; implies tenant is cluster tenant.
        /// </summary>
        /// <value>Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;OnPrem&#39; implies tenant is cluster tenant.</value>
        [DataMember(Name="tenantType", EmitDefaultValue=false)]
        public TenantTypeEnum? TenantType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="McmUserProfile" /> class.
        /// </summary>
        /// <param name="clusterIdentifiers">Specifies the list of clusters. This is only valid if tenant type is OnPrem..</param>
        /// <param name="isActive">Specifies whether or not the tenant is active..</param>
        /// <param name="isDeleted">Specifies whether or not the tenant is deleted..</param>
        /// <param name="regionIds">Specifies the list of regions. This is only valid if tenant type is Dmaas..</param>
        /// <param name="tenantId">Specifies the tenant id..</param>
        /// <param name="tenantName">Specifies the tenant name..</param>
        /// <param name="tenantType">Specifies the MCM tenant type. &#39;Dmaas&#39; implies tenant type is DMaaS. &#39;OnPrem&#39; implies tenant is cluster tenant..</param>
        public McmUserProfile(List<ClusterIdentifier> clusterIdentifiers = default(List<ClusterIdentifier>), bool? isActive = default(bool?), bool? isDeleted = default(bool?), List<string> regionIds = default(List<string>), string tenantId = default(string), string tenantName = default(string), TenantTypeEnum? tenantType = default(TenantTypeEnum?))
        {
            this.ClusterIdentifiers = clusterIdentifiers;
            this.IsActive = isActive;
            this.IsDeleted = isDeleted;
            this.RegionIds = regionIds;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
            this.TenantType = tenantType;
        }
        
        /// <summary>
        /// Specifies the list of clusters. This is only valid if tenant type is OnPrem.
        /// </summary>
        /// <value>Specifies the list of clusters. This is only valid if tenant type is OnPrem.</value>
        [DataMember(Name="clusterIdentifiers", EmitDefaultValue=false)]
        public List<ClusterIdentifier> ClusterIdentifiers { get; set; }

        /// <summary>
        /// Specifies whether or not the tenant is active.
        /// </summary>
        /// <value>Specifies whether or not the tenant is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies whether or not the tenant is deleted.
        /// </summary>
        /// <value>Specifies whether or not the tenant is deleted.</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Specifies the list of regions. This is only valid if tenant type is Dmaas.
        /// </summary>
        /// <value>Specifies the list of regions. This is only valid if tenant type is Dmaas.</value>
        [DataMember(Name="regionIds", EmitDefaultValue=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// Specifies the tenant id.
        /// </summary>
        /// <value>Specifies the tenant id.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the tenant name.
        /// </summary>
        /// <value>Specifies the tenant name.</value>
        [DataMember(Name="tenantName", EmitDefaultValue=false)]
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
            return this.Equals(input as McmUserProfile);
        }

        /// <summary>
        /// Returns true if McmUserProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of McmUserProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(McmUserProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterIdentifiers == input.ClusterIdentifiers ||
                    this.ClusterIdentifiers != null &&
                    this.ClusterIdentifiers.Equals(input.ClusterIdentifiers)
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
                    this.RegionIds == input.RegionIds ||
                    this.RegionIds != null &&
                    this.RegionIds.Equals(input.RegionIds)
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
                    (this.TenantType != null &&
                    this.TenantType.Equals(input.TenantType))
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
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.RegionIds != null)
                    hashCode = hashCode * 59 + this.RegionIds.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.TenantType != null)
                    hashCode = hashCode * 59 + this.TenantType.GetHashCode();
                return hashCode;
            }
        }

    }

}

