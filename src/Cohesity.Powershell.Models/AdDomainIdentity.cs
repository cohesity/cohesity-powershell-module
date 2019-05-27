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
    /// AD domain identity information.
    /// </summary>
    [DataContract]
    public partial class AdDomainIdentity :  IEquatable<AdDomainIdentity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdDomainIdentity" /> class.
        /// </summary>
        /// <param name="dn">Specifies distinguished name of the domain..</param>
        /// <param name="guid">Specifies Unique objectGUID for an AD domain..</param>
        /// <param name="name">Specifies display name of the domain..</param>
        /// <param name="sid">Specifies domain SID..</param>
        public AdDomainIdentity(string dn = default(string), string guid = default(string), string name = default(string), string sid = default(string))
        {
            this.Dn = dn;
            this.Guid = guid;
            this.Name = name;
            this.Sid = sid;
            this.Dn = dn;
            this.Guid = guid;
            this.Name = name;
            this.Sid = sid;
        }
        
        /// <summary>
        /// Specifies distinguished name of the domain.
        /// </summary>
        /// <value>Specifies distinguished name of the domain.</value>
        [DataMember(Name="dn", EmitDefaultValue=true)]
        public string Dn { get; set; }

        /// <summary>
        /// Specifies Unique objectGUID for an AD domain.
        /// </summary>
        /// <value>Specifies Unique objectGUID for an AD domain.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies display name of the domain.
        /// </summary>
        /// <value>Specifies display name of the domain.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies domain SID.
        /// </summary>
        /// <value>Specifies domain SID.</value>
        [DataMember(Name="sid", EmitDefaultValue=true)]
        public string Sid { get; set; }

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
            return this.Equals(input as AdDomainIdentity);
        }

        /// <summary>
        /// Returns true if AdDomainIdentity instances are equal
        /// </summary>
        /// <param name="input">Instance of AdDomainIdentity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdDomainIdentity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dn == input.Dn ||
                    (this.Dn != null &&
                    this.Dn.Equals(input.Dn))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
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
                if (this.Dn != null)
                    hashCode = hashCode * 59 + this.Dn.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                return hashCode;
            }
        }

    }

}

