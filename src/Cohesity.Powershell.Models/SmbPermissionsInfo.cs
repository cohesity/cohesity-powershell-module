// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about SMB permissions.
    /// </summary>
    [DataContract]
    public partial class SmbPermissionsInfo :  IEquatable<SmbPermissionsInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbPermissionsInfo" /> class.
        /// </summary>
        /// <param name="ownerSid">Specifies the security identifier (SID) of the owner of the SMB share..</param>
        /// <param name="permissions">Specifies a list of SMB permissions..</param>
        public SmbPermissionsInfo(string ownerSid = default(string), List<SmbPermission> permissions = default(List<SmbPermission>))
        {
            this.OwnerSid = ownerSid;
            this.Permissions = permissions;
        }
        
        /// <summary>
        /// Specifies the security identifier (SID) of the owner of the SMB share.
        /// </summary>
        /// <value>Specifies the security identifier (SID) of the owner of the SMB share.</value>
        [DataMember(Name="ownerSid", EmitDefaultValue=false)]
        public string OwnerSid { get; set; }

        /// <summary>
        /// Specifies a list of SMB permissions.
        /// </summary>
        /// <value>Specifies a list of SMB permissions.</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<SmbPermission> Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as SmbPermissionsInfo);
        }

        /// <summary>
        /// Returns true if SmbPermissionsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbPermissionsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbPermissionsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerSid == input.OwnerSid ||
                    (this.OwnerSid != null &&
                    this.OwnerSid.Equals(input.OwnerSid))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.OwnerSid != null)
                    hashCode = hashCode * 59 + this.OwnerSid.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

