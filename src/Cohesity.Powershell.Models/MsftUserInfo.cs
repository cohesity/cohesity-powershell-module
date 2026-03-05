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
    /// Specifies additional information pertaining to Micrsoft account.
    /// </summary>
    [DataContract]
    public partial class MsftUserInfo :  IEquatable<MsftUserInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MsftUserInfo" /> class.
        /// </summary>
        /// <param name="accessibleEntityInfo">accessibleEntityInfo.</param>
        /// <param name="graphUuid">Specifies the Microsoft Graph UUID for the user..</param>
        /// <param name="msftTenantId">Specifies the Microsoft tenant ID for this user account. Please note this is NOT Cohesity&#39;s tenant ID..</param>
        public MsftUserInfo(AccessibleEntityInfo accessibleEntityInfo = default(AccessibleEntityInfo), string graphUuid = default(string), string msftTenantId = default(string))
        {
            this.GraphUuid = graphUuid;
            this.MsftTenantId = msftTenantId;
            this.AccessibleEntityInfo = accessibleEntityInfo;
            this.GraphUuid = graphUuid;
            this.MsftTenantId = msftTenantId;
        }
        
        /// <summary>
        /// Gets or Sets AccessibleEntityInfo
        /// </summary>
        [DataMember(Name="accessibleEntityInfo", EmitDefaultValue=false)]
        public AccessibleEntityInfo AccessibleEntityInfo { get; set; }

        /// <summary>
        /// Specifies the Microsoft Graph UUID for the user.
        /// </summary>
        /// <value>Specifies the Microsoft Graph UUID for the user.</value>
        [DataMember(Name="graphUuid", EmitDefaultValue=true)]
        public string GraphUuid { get; set; }

        /// <summary>
        /// Specifies the Microsoft tenant ID for this user account. Please note this is NOT Cohesity&#39;s tenant ID.
        /// </summary>
        /// <value>Specifies the Microsoft tenant ID for this user account. Please note this is NOT Cohesity&#39;s tenant ID.</value>
        [DataMember(Name="msftTenantId", EmitDefaultValue=true)]
        public string MsftTenantId { get; set; }

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
            return this.Equals(input as MsftUserInfo);
        }

        /// <summary>
        /// Returns true if MsftUserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MsftUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MsftUserInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessibleEntityInfo == input.AccessibleEntityInfo ||
                    (this.AccessibleEntityInfo != null &&
                    this.AccessibleEntityInfo.Equals(input.AccessibleEntityInfo))
                ) && 
                (
                    this.GraphUuid == input.GraphUuid ||
                    (this.GraphUuid != null &&
                    this.GraphUuid.Equals(input.GraphUuid))
                ) && 
                (
                    this.MsftTenantId == input.MsftTenantId ||
                    (this.MsftTenantId != null &&
                    this.MsftTenantId.Equals(input.MsftTenantId))
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
                if (this.AccessibleEntityInfo != null)
                    hashCode = hashCode * 59 + this.AccessibleEntityInfo.GetHashCode();
                if (this.GraphUuid != null)
                    hashCode = hashCode * 59 + this.GraphUuid.GetHashCode();
                if (this.MsftTenantId != null)
                    hashCode = hashCode * 59 + this.MsftTenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

