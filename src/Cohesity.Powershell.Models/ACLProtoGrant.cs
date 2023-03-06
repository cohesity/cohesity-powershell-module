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
    /// ACLProtoGrant
    /// </summary>
    [DataContract]
    public partial class ACLProtoGrant :  IEquatable<ACLProtoGrant>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACLProtoGrant" /> class.
        /// </summary>
        /// <param name="grantee">grantee.</param>
        /// <param name="permissionVec">Vector of permission granted to this grantee..</param>
        public ACLProtoGrant(GranteeProto grantee = default(GranteeProto), List<int> permissionVec = default(List<int>))
        {
            this.PermissionVec = permissionVec;
            this.Grantee = grantee;
            this.PermissionVec = permissionVec;
        }
        
        /// <summary>
        /// Gets or Sets Grantee
        /// </summary>
        [DataMember(Name="grantee", EmitDefaultValue=false)]
        public GranteeProto Grantee { get; set; }

        /// <summary>
        /// Vector of permission granted to this grantee.
        /// </summary>
        /// <value>Vector of permission granted to this grantee.</value>
        [DataMember(Name="permissionVec", EmitDefaultValue=true)]
        public List<int> PermissionVec { get; set; }

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
            return this.Equals(input as ACLProtoGrant);
        }

        /// <summary>
        /// Returns true if ACLProtoGrant instances are equal
        /// </summary>
        /// <param name="input">Instance of ACLProtoGrant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ACLProtoGrant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Grantee == input.Grantee ||
                    (this.Grantee != null &&
                    this.Grantee.Equals(input.Grantee))
                ) && 
                (
                    this.PermissionVec == input.PermissionVec ||
                    this.PermissionVec != null &&
                    input.PermissionVec != null &&
                    this.PermissionVec.SequenceEqual(input.PermissionVec)
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
                if (this.Grantee != null)
                    hashCode = hashCode * 59 + this.Grantee.GetHashCode();
                if (this.PermissionVec != null)
                    hashCode = hashCode * 59 + this.PermissionVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

