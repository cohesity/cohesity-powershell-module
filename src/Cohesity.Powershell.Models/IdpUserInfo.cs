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
    /// Specifies an IdP User&#39;s information logged in using an IdP. This information is not stored on the Cluster.
    /// </summary>
    [DataContract]
    public partial class IdpUserInfo :  IEquatable<IdpUserInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdpUserInfo" /> class.
        /// </summary>
        /// <param name="groupSids">Specifies the SIDs of the groups..</param>
        /// <param name="groups">Specifies the Idp groups that the user is part of. As the user may not be registered on the cluster, we may have to capture the idp group membership. This way, if a group is created on the cluster later, users will instantly have access to tenantIds from that group as well..</param>
        /// <param name="idpId">Specifies the unique Id assigned by the Cluster for the IdP..</param>
        /// <param name="isFloatingUser">Specifies whether or not this is a floating user..</param>
        /// <param name="issuerId">Specifies the unique identifier assigned by the vendor for this Cluster..</param>
        /// <param name="userId">Specifies the unique identifier assigned by the vendor for the user..</param>
        /// <param name="vendor">Specifies the vendor providing the IdP service..</param>
        public IdpUserInfo(List<string> groupSids = default(List<string>), List<string> groups = default(List<string>), long? idpId = default(long?), bool? isFloatingUser = default(bool?), string issuerId = default(string), string userId = default(string), string vendor = default(string))
        {
            this.GroupSids = groupSids;
            this.Groups = groups;
            this.IdpId = idpId;
            this.IsFloatingUser = isFloatingUser;
            this.IssuerId = issuerId;
            this.UserId = userId;
            this.Vendor = vendor;
            this.GroupSids = groupSids;
            this.Groups = groups;
            this.IdpId = idpId;
            this.IsFloatingUser = isFloatingUser;
            this.IssuerId = issuerId;
            this.UserId = userId;
            this.Vendor = vendor;
        }
        
        /// <summary>
        /// Specifies the SIDs of the groups.
        /// </summary>
        /// <value>Specifies the SIDs of the groups.</value>
        [DataMember(Name="groupSids", EmitDefaultValue=true)]
        public List<string> GroupSids { get; set; }

        /// <summary>
        /// Specifies the Idp groups that the user is part of. As the user may not be registered on the cluster, we may have to capture the idp group membership. This way, if a group is created on the cluster later, users will instantly have access to tenantIds from that group as well.
        /// </summary>
        /// <value>Specifies the Idp groups that the user is part of. As the user may not be registered on the cluster, we may have to capture the idp group membership. This way, if a group is created on the cluster later, users will instantly have access to tenantIds from that group as well.</value>
        [DataMember(Name="groups", EmitDefaultValue=true)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Specifies the unique Id assigned by the Cluster for the IdP.
        /// </summary>
        /// <value>Specifies the unique Id assigned by the Cluster for the IdP.</value>
        [DataMember(Name="idpId", EmitDefaultValue=true)]
        public long? IdpId { get; set; }

        /// <summary>
        /// Specifies whether or not this is a floating user.
        /// </summary>
        /// <value>Specifies whether or not this is a floating user.</value>
        [DataMember(Name="isFloatingUser", EmitDefaultValue=true)]
        public bool? IsFloatingUser { get; set; }

        /// <summary>
        /// Specifies the unique identifier assigned by the vendor for this Cluster.
        /// </summary>
        /// <value>Specifies the unique identifier assigned by the vendor for this Cluster.</value>
        [DataMember(Name="issuerId", EmitDefaultValue=true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Specifies the unique identifier assigned by the vendor for the user.
        /// </summary>
        /// <value>Specifies the unique identifier assigned by the vendor for the user.</value>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies the vendor providing the IdP service.
        /// </summary>
        /// <value>Specifies the vendor providing the IdP service.</value>
        [DataMember(Name="vendor", EmitDefaultValue=true)]
        public string Vendor { get; set; }

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
            return this.Equals(input as IdpUserInfo);
        }

        /// <summary>
        /// Returns true if IdpUserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IdpUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdpUserInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupSids == input.GroupSids ||
                    this.GroupSids != null &&
                    input.GroupSids != null &&
                    this.GroupSids.SequenceEqual(input.GroupSids)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.IdpId == input.IdpId ||
                    (this.IdpId != null &&
                    this.IdpId.Equals(input.IdpId))
                ) && 
                (
                    this.IsFloatingUser == input.IsFloatingUser ||
                    (this.IsFloatingUser != null &&
                    this.IsFloatingUser.Equals(input.IsFloatingUser))
                ) && 
                (
                    this.IssuerId == input.IssuerId ||
                    (this.IssuerId != null &&
                    this.IssuerId.Equals(input.IssuerId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
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
                if (this.GroupSids != null)
                    hashCode = hashCode * 59 + this.GroupSids.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.IdpId != null)
                    hashCode = hashCode * 59 + this.IdpId.GetHashCode();
                if (this.IsFloatingUser != null)
                    hashCode = hashCode * 59 + this.IsFloatingUser.GetHashCode();
                if (this.IssuerId != null)
                    hashCode = hashCode * 59 + this.IssuerId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Vendor != null)
                    hashCode = hashCode * 59 + this.Vendor.GetHashCode();
                return hashCode;
            }
        }

    }

}

