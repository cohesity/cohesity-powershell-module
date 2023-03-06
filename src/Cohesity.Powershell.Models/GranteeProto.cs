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
    /// GranteeProto
    /// </summary>
    [DataContract]
    public partial class GranteeProto :  IEquatable<GranteeProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GranteeProto" /> class.
        /// </summary>
        /// <param name="emailAddress">If grantee is of type &#39;kEmailUser&#39;, this field will contain the email address of the user..</param>
        /// <param name="group">If grantee is of type &#39;kGroup&#39;, this field will contain the group to which permission is granted..</param>
        /// <param name="type">type.</param>
        /// <param name="userId">If grantee is of type &#39;kRegisteredUser&#39;, this field will contain the canonical id of the user..</param>
        public GranteeProto(string emailAddress = default(string), int? group = default(int?), int? type = default(int?), string userId = default(string))
        {
            this.EmailAddress = emailAddress;
            this.Group = group;
            this.Type = type;
            this.UserId = userId;
            this.EmailAddress = emailAddress;
            this.Group = group;
            this.Type = type;
            this.UserId = userId;
        }
        
        /// <summary>
        /// If grantee is of type &#39;kEmailUser&#39;, this field will contain the email address of the user.
        /// </summary>
        /// <value>If grantee is of type &#39;kEmailUser&#39;, this field will contain the email address of the user.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// If grantee is of type &#39;kGroup&#39;, this field will contain the group to which permission is granted.
        /// </summary>
        /// <value>If grantee is of type &#39;kGroup&#39;, this field will contain the group to which permission is granted.</value>
        [DataMember(Name="group", EmitDefaultValue=true)]
        public int? Group { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// If grantee is of type &#39;kRegisteredUser&#39;, this field will contain the canonical id of the user.
        /// </summary>
        /// <value>If grantee is of type &#39;kRegisteredUser&#39;, this field will contain the canonical id of the user.</value>
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
            return this.Equals(input as GranteeProto);
        }

        /// <summary>
        /// Returns true if GranteeProto instances are equal
        /// </summary>
        /// <param name="input">Instance of GranteeProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GranteeProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}

