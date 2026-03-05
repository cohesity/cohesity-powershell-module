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
    /// IbmUserMetadata specifies additional information pertaining to an IBM IAM user. Following struct defines the generic template for holding all IBM IAM user&#39;s properties. The struct is populated during various authentication methods we support on OnPrem and Helios (IBM OneHelios). As this is used for multiple purposes, part of the following fields may be kept empty depending on the use case.
    /// </summary>
    [DataContract]
    public partial class IbmUserMetadata :  IEquatable<IbmUserMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IbmUserMetadata" /> class.
        /// </summary>
        /// <param name="iAMId">Specifies the IAM ID of the IBM customer..</param>
        /// <param name="accountId">Specifies the Account ID of the IBM customer..</param>
        /// <param name="authnId">Specifies the Authn ID of the IBM customer..</param>
        /// <param name="authnName">Specifies the Authn Name of the IBM customer..</param>
        /// <param name="grantType">Specifies the grant type of the IBM customer..</param>
        /// <param name="iamName">Specifies the IAM Name of the IBM customer..</param>
        /// <param name="isSreUser">Specifies whether an IBM User is SRE. Currently, IBM SRE users are local users. Hence, upon login, the following must be set to true for SRE users. In future, when SRE logins are migrated via IAM, the logic needs to be updated..</param>
        /// <param name="resourceGroupId">Specifies the resource group ID of the IBM customer..</param>
        /// <param name="serviceInstances">Specifies the list of IBM Service instances belonging to the IAM user..</param>
        /// <param name="tenantCRN">Specifies the Tenant CRN of the IBM customer..</param>
        public IbmUserMetadata(string iAMId = default(string), string accountId = default(string), string authnId = default(string), string authnName = default(string), string grantType = default(string), string iamName = default(string), bool? isSreUser = default(bool?), string resourceGroupId = default(string), List<IbmServiceInstanceForUser> serviceInstances = default(List<IbmServiceInstanceForUser>), string tenantCRN = default(string))
        {
            this.IAMId = iAMId;
            this.AccountId = accountId;
            this.AuthnId = authnId;
            this.AuthnName = authnName;
            this.GrantType = grantType;
            this.IamName = iamName;
            this.IsSreUser = isSreUser;
            this.ResourceGroupId = resourceGroupId;
            this.ServiceInstances = serviceInstances;
            this.TenantCRN = tenantCRN;
            this.IAMId = iAMId;
            this.AccountId = accountId;
            this.AuthnId = authnId;
            this.AuthnName = authnName;
            this.GrantType = grantType;
            this.IamName = iamName;
            this.IsSreUser = isSreUser;
            this.ResourceGroupId = resourceGroupId;
            this.ServiceInstances = serviceInstances;
            this.TenantCRN = tenantCRN;
        }
        
        /// <summary>
        /// Specifies the IAM ID of the IBM customer.
        /// </summary>
        /// <value>Specifies the IAM ID of the IBM customer.</value>
        [DataMember(Name="IAMId", EmitDefaultValue=true)]
        public string IAMId { get; set; }

        /// <summary>
        /// Specifies the Account ID of the IBM customer.
        /// </summary>
        /// <value>Specifies the Account ID of the IBM customer.</value>
        [DataMember(Name="accountId", EmitDefaultValue=true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Specifies the Authn ID of the IBM customer.
        /// </summary>
        /// <value>Specifies the Authn ID of the IBM customer.</value>
        [DataMember(Name="authnId", EmitDefaultValue=true)]
        public string AuthnId { get; set; }

        /// <summary>
        /// Specifies the Authn Name of the IBM customer.
        /// </summary>
        /// <value>Specifies the Authn Name of the IBM customer.</value>
        [DataMember(Name="authnName", EmitDefaultValue=true)]
        public string AuthnName { get; set; }

        /// <summary>
        /// Specifies the grant type of the IBM customer.
        /// </summary>
        /// <value>Specifies the grant type of the IBM customer.</value>
        [DataMember(Name="grantType", EmitDefaultValue=true)]
        public string GrantType { get; set; }

        /// <summary>
        /// Specifies the IAM Name of the IBM customer.
        /// </summary>
        /// <value>Specifies the IAM Name of the IBM customer.</value>
        [DataMember(Name="iamName", EmitDefaultValue=true)]
        public string IamName { get; set; }

        /// <summary>
        /// Specifies whether an IBM User is SRE. Currently, IBM SRE users are local users. Hence, upon login, the following must be set to true for SRE users. In future, when SRE logins are migrated via IAM, the logic needs to be updated.
        /// </summary>
        /// <value>Specifies whether an IBM User is SRE. Currently, IBM SRE users are local users. Hence, upon login, the following must be set to true for SRE users. In future, when SRE logins are migrated via IAM, the logic needs to be updated.</value>
        [DataMember(Name="isSreUser", EmitDefaultValue=true)]
        public bool? IsSreUser { get; set; }

        /// <summary>
        /// Specifies the resource group ID of the IBM customer.
        /// </summary>
        /// <value>Specifies the resource group ID of the IBM customer.</value>
        [DataMember(Name="resourceGroupId", EmitDefaultValue=true)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies the list of IBM Service instances belonging to the IAM user.
        /// </summary>
        /// <value>Specifies the list of IBM Service instances belonging to the IAM user.</value>
        [DataMember(Name="serviceInstances", EmitDefaultValue=true)]
        public List<IbmServiceInstanceForUser> ServiceInstances { get; set; }

        /// <summary>
        /// Specifies the Tenant CRN of the IBM customer.
        /// </summary>
        /// <value>Specifies the Tenant CRN of the IBM customer.</value>
        [DataMember(Name="tenantCRN", EmitDefaultValue=true)]
        public string TenantCRN { get; set; }

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
            return this.Equals(input as IbmUserMetadata);
        }

        /// <summary>
        /// Returns true if IbmUserMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of IbmUserMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IbmUserMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IAMId == input.IAMId ||
                    (this.IAMId != null &&
                    this.IAMId.Equals(input.IAMId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AuthnId == input.AuthnId ||
                    (this.AuthnId != null &&
                    this.AuthnId.Equals(input.AuthnId))
                ) && 
                (
                    this.AuthnName == input.AuthnName ||
                    (this.AuthnName != null &&
                    this.AuthnName.Equals(input.AuthnName))
                ) && 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.IamName == input.IamName ||
                    (this.IamName != null &&
                    this.IamName.Equals(input.IamName))
                ) && 
                (
                    this.IsSreUser == input.IsSreUser ||
                    (this.IsSreUser != null &&
                    this.IsSreUser.Equals(input.IsSreUser))
                ) && 
                (
                    this.ResourceGroupId == input.ResourceGroupId ||
                    (this.ResourceGroupId != null &&
                    this.ResourceGroupId.Equals(input.ResourceGroupId))
                ) && 
                (
                    this.ServiceInstances == input.ServiceInstances ||
                    this.ServiceInstances != null &&
                    input.ServiceInstances != null &&
                    this.ServiceInstances.SequenceEqual(input.ServiceInstances)
                ) && 
                (
                    this.TenantCRN == input.TenantCRN ||
                    (this.TenantCRN != null &&
                    this.TenantCRN.Equals(input.TenantCRN))
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
                if (this.IAMId != null)
                    hashCode = hashCode * 59 + this.IAMId.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AuthnId != null)
                    hashCode = hashCode * 59 + this.AuthnId.GetHashCode();
                if (this.AuthnName != null)
                    hashCode = hashCode * 59 + this.AuthnName.GetHashCode();
                if (this.GrantType != null)
                    hashCode = hashCode * 59 + this.GrantType.GetHashCode();
                if (this.IamName != null)
                    hashCode = hashCode * 59 + this.IamName.GetHashCode();
                if (this.IsSreUser != null)
                    hashCode = hashCode * 59 + this.IsSreUser.GetHashCode();
                if (this.ResourceGroupId != null)
                    hashCode = hashCode * 59 + this.ResourceGroupId.GetHashCode();
                if (this.ServiceInstances != null)
                    hashCode = hashCode * 59 + this.ServiceInstances.GetHashCode();
                if (this.TenantCRN != null)
                    hashCode = hashCode * 59 + this.TenantCRN.GetHashCode();
                return hashCode;
            }
        }

    }

}

