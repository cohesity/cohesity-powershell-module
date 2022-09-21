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
    /// CommonACLProtoGrantees
    /// </summary>
    [DataContract]
    public partial class CommonACLProtoGrantees :  IEquatable<CommonACLProtoGrantees>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonACLProtoGrantees" /> class.
        /// </summary>
        /// <param name="allUsers">This field indicates if all users are granted ACL permission..</param>
        /// <param name="deniedReferrerVec">This field holds a list of referers who are denied ACL permission..</param>
        /// <param name="grantedReferrerVec">This field holds a list of referers who are granted ACL permission..</param>
        /// <param name="rlistings">This fields indicates if container GET and HEAD operations are permitted provided that read access is granted (using referer ACL) on objects..</param>
        public CommonACLProtoGrantees(bool? allUsers = default(bool?), List<string> deniedReferrerVec = default(List<string>), List<string> grantedReferrerVec = default(List<string>), bool? rlistings = default(bool?))
        {
            this.AllUsers = allUsers;
            this.DeniedReferrerVec = deniedReferrerVec;
            this.GrantedReferrerVec = grantedReferrerVec;
            this.Rlistings = rlistings;
            this.AllUsers = allUsers;
            this.DeniedReferrerVec = deniedReferrerVec;
            this.GrantedReferrerVec = grantedReferrerVec;
            this.Rlistings = rlistings;
        }
        
        /// <summary>
        /// This field indicates if all users are granted ACL permission.
        /// </summary>
        /// <value>This field indicates if all users are granted ACL permission.</value>
        [DataMember(Name="allUsers", EmitDefaultValue=true)]
        public bool? AllUsers { get; set; }

        /// <summary>
        /// This field holds a list of referers who are denied ACL permission.
        /// </summary>
        /// <value>This field holds a list of referers who are denied ACL permission.</value>
        [DataMember(Name="deniedReferrerVec", EmitDefaultValue=true)]
        public List<string> DeniedReferrerVec { get; set; }

        /// <summary>
        /// This field holds a list of referers who are granted ACL permission.
        /// </summary>
        /// <value>This field holds a list of referers who are granted ACL permission.</value>
        [DataMember(Name="grantedReferrerVec", EmitDefaultValue=true)]
        public List<string> GrantedReferrerVec { get; set; }

        /// <summary>
        /// This fields indicates if container GET and HEAD operations are permitted provided that read access is granted (using referer ACL) on objects.
        /// </summary>
        /// <value>This fields indicates if container GET and HEAD operations are permitted provided that read access is granted (using referer ACL) on objects.</value>
        [DataMember(Name="rlistings", EmitDefaultValue=true)]
        public bool? Rlistings { get; set; }

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
            return this.Equals(input as CommonACLProtoGrantees);
        }

        /// <summary>
        /// Returns true if CommonACLProtoGrantees instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonACLProtoGrantees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonACLProtoGrantees input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllUsers == input.AllUsers ||
                    (this.AllUsers != null &&
                    this.AllUsers.Equals(input.AllUsers))
                ) && 
                (
                    this.DeniedReferrerVec == input.DeniedReferrerVec ||
                    this.DeniedReferrerVec != null &&
                    input.DeniedReferrerVec != null &&
                    this.DeniedReferrerVec.Equals(input.DeniedReferrerVec)
                ) && 
                (
                    this.GrantedReferrerVec == input.GrantedReferrerVec ||
                    this.GrantedReferrerVec != null &&
                    input.GrantedReferrerVec != null &&
                    this.GrantedReferrerVec.Equals(input.GrantedReferrerVec)
                ) && 
                (
                    this.Rlistings == input.Rlistings ||
                    (this.Rlistings != null &&
                    this.Rlistings.Equals(input.Rlistings))
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
                if (this.AllUsers != null)
                    hashCode = hashCode * 59 + this.AllUsers.GetHashCode();
                if (this.DeniedReferrerVec != null)
                    hashCode = hashCode * 59 + this.DeniedReferrerVec.GetHashCode();
                if (this.GrantedReferrerVec != null)
                    hashCode = hashCode * 59 + this.GrantedReferrerVec.GetHashCode();
                if (this.Rlistings != null)
                    hashCode = hashCode * 59 + this.Rlistings.GetHashCode();
                return hashCode;
            }
        }

    }

}

