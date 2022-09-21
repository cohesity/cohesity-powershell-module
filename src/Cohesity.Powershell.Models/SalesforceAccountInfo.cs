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
    /// Salesforce Account Information of a Helios user.
    /// </summary>
    [DataContract]
    public partial class SalesforceAccountInfo :  IEquatable<SalesforceAccountInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceAccountInfo" /> class.
        /// </summary>
        /// <param name="accountId">Specifies the Account Id assigned by Salesforce..</param>
        /// <param name="heliosAccessGrantStatus">Specifies the status of helios access..</param>
        /// <param name="isDGaaSUser">Specifies whether user is a DGaaS licensed user..</param>
        /// <param name="isDMaaSUser">Specifies whether user is a DMaaS licensed user..</param>
        /// <param name="isDRaaSUser">Specifies whether user is a DRaaS licensed user..</param>
        /// <param name="isRPaaSUser">Specifies whether user is a RPaaS licensed user..</param>
        /// <param name="isSalesUser">Specifies whether user is a Sales person from Cohesity..</param>
        /// <param name="isSupportUser">Specifies whether user is a support person from Cohesity..</param>
        /// <param name="userId">Specifies the User Id assigned by Salesforce..</param>
        public SalesforceAccountInfo(string accountId = default(string), string heliosAccessGrantStatus = default(string), bool? isDGaaSUser = default(bool?), bool? isDMaaSUser = default(bool?), bool? isDRaaSUser = default(bool?), bool? isRPaaSUser = default(bool?), bool? isSalesUser = default(bool?), bool? isSupportUser = default(bool?), string userId = default(string))
        {
            this.AccountId = accountId;
            this.HeliosAccessGrantStatus = heliosAccessGrantStatus;
            this.IsDGaaSUser = isDGaaSUser;
            this.IsDMaaSUser = isDMaaSUser;
            this.IsDRaaSUser = isDRaaSUser;
            this.IsRPaaSUser = isRPaaSUser;
            this.IsSalesUser = isSalesUser;
            this.IsSupportUser = isSupportUser;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Specifies the Account Id assigned by Salesforce.
        /// </summary>
        /// <value>Specifies the Account Id assigned by Salesforce.</value>
        [DataMember(Name="accountId", EmitDefaultValue=true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Specifies the status of helios access.
        /// </summary>
        /// <value>Specifies the status of helios access.</value>
        [DataMember(Name="heliosAccessGrantStatus", EmitDefaultValue=true)]
        public string HeliosAccessGrantStatus { get; set; }

        /// <summary>
        /// Specifies whether user is a DGaaS licensed user.
        /// </summary>
        /// <value>Specifies whether user is a DGaaS licensed user.</value>
        [DataMember(Name="isDGaaSUser", EmitDefaultValue=true)]
        public bool? IsDGaaSUser { get; set; }

        /// <summary>
        /// Specifies whether user is a DMaaS licensed user.
        /// </summary>
        /// <value>Specifies whether user is a DMaaS licensed user.</value>
        [DataMember(Name="isDMaaSUser", EmitDefaultValue=true)]
        public bool? IsDMaaSUser { get; set; }

        /// <summary>
        /// Specifies whether user is a DRaaS licensed user.
        /// </summary>
        /// <value>Specifies whether user is a DRaaS licensed user.</value>
        [DataMember(Name="isDRaaSUser", EmitDefaultValue=true)]
        public bool? IsDRaaSUser { get; set; }

        /// <summary>
        /// Specifies whether user is a RPaaS licensed user.
        /// </summary>
        /// <value>Specifies whether user is a RPaaS licensed user.</value>
        [DataMember(Name="isRPaaSUser", EmitDefaultValue=true)]
        public bool? IsRPaaSUser { get; set; }

        /// <summary>
        /// Specifies whether user is a Sales person from Cohesity.
        /// </summary>
        /// <value>Specifies whether user is a Sales person from Cohesity.</value>
        [DataMember(Name="isSalesUser", EmitDefaultValue=true)]
        public bool? IsSalesUser { get; set; }

        /// <summary>
        /// Specifies whether user is a support person from Cohesity.
        /// </summary>
        /// <value>Specifies whether user is a support person from Cohesity.</value>
        [DataMember(Name="isSupportUser", EmitDefaultValue=true)]
        public bool? IsSupportUser { get; set; }

        /// <summary>
        /// Specifies the User Id assigned by Salesforce.
        /// </summary>
        /// <value>Specifies the User Id assigned by Salesforce.</value>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public string UserId { get; set; }

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
            return this.Equals(input as SalesforceAccountInfo);
        }

        /// <summary>
        /// Returns true if SalesforceAccountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesforceAccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesforceAccountInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.HeliosAccessGrantStatus == input.HeliosAccessGrantStatus ||
                    (this.HeliosAccessGrantStatus != null &&
                    this.HeliosAccessGrantStatus.Equals(input.HeliosAccessGrantStatus))
                ) && 
                (
                    this.IsDGaaSUser == input.IsDGaaSUser ||
                    (this.IsDGaaSUser != null &&
                    this.IsDGaaSUser.Equals(input.IsDGaaSUser))
                ) && 
                (
                    this.IsDMaaSUser == input.IsDMaaSUser ||
                    (this.IsDMaaSUser != null &&
                    this.IsDMaaSUser.Equals(input.IsDMaaSUser))
                ) && 
                (
                    this.IsDRaaSUser == input.IsDRaaSUser ||
                    (this.IsDRaaSUser != null &&
                    this.IsDRaaSUser.Equals(input.IsDRaaSUser))
                ) && 
                (
                    this.IsRPaaSUser == input.IsRPaaSUser ||
                    (this.IsRPaaSUser != null &&
                    this.IsRPaaSUser.Equals(input.IsRPaaSUser))
                ) && 
                (
                    this.IsSalesUser == input.IsSalesUser ||
                    (this.IsSalesUser != null &&
                    this.IsSalesUser.Equals(input.IsSalesUser))
                ) && 
                (
                    this.IsSupportUser == input.IsSupportUser ||
                    (this.IsSupportUser != null &&
                    this.IsSupportUser.Equals(input.IsSupportUser))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.HeliosAccessGrantStatus != null)
                    hashCode = hashCode * 59 + this.HeliosAccessGrantStatus.GetHashCode();
                if (this.IsDGaaSUser != null)
                    hashCode = hashCode * 59 + this.IsDGaaSUser.GetHashCode();
                if (this.IsDMaaSUser != null)
                    hashCode = hashCode * 59 + this.IsDMaaSUser.GetHashCode();
                if (this.IsDRaaSUser != null)
                    hashCode = hashCode * 59 + this.IsDRaaSUser.GetHashCode();
                if (this.IsRPaaSUser != null)
                    hashCode = hashCode * 59 + this.IsRPaaSUser.GetHashCode();
                if (this.IsSalesUser != null)
                    hashCode = hashCode * 59 + this.IsSalesUser.GetHashCode();
                if (this.IsSupportUser != null)
                    hashCode = hashCode * 59 + this.IsSupportUser.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}

