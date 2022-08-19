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
    /// CompareADObjectsResultADAttribute
    /// </summary>
    [DataContract]
    public partial class CompareADObjectsResultADAttribute :  IEquatable<CompareADObjectsResultADAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareADObjectsResultADAttribute" /> class.
        /// </summary>
        /// <param name="attrFlags">Object result flags of type ADAttributeFlags..</param>
        /// <param name="destValue">destValue.</param>
        /// <param name="ldapName">LDAP attribute name..</param>
        /// <param name="sameValue">sameValue.</param>
        /// <param name="sourceValue">sourceValue.</param>
        /// <param name="status">status.</param>
        public CompareADObjectsResultADAttribute(int? attrFlags = default(int?), CompareADObjectsResultADAttributeValue destValue = default(CompareADObjectsResultADAttributeValue), string ldapName = default(string), CompareADObjectsResultADAttributeValue sameValue = default(CompareADObjectsResultADAttributeValue), CompareADObjectsResultADAttributeValue sourceValue = default(CompareADObjectsResultADAttributeValue), ErrorProto status = default(ErrorProto))
        {
            this.AttrFlags = attrFlags;
            this.LdapName = ldapName;
            this.AttrFlags = attrFlags;
            this.DestValue = destValue;
            this.LdapName = ldapName;
            this.SameValue = sameValue;
            this.SourceValue = sourceValue;
            this.Status = status;
        }
        
        /// <summary>
        /// Object result flags of type ADAttributeFlags.
        /// </summary>
        /// <value>Object result flags of type ADAttributeFlags.</value>
        [DataMember(Name="attrFlags", EmitDefaultValue=true)]
        public int? AttrFlags { get; set; }

        /// <summary>
        /// Gets or Sets DestValue
        /// </summary>
        [DataMember(Name="destValue", EmitDefaultValue=false)]
        public CompareADObjectsResultADAttributeValue DestValue { get; set; }

        /// <summary>
        /// LDAP attribute name.
        /// </summary>
        /// <value>LDAP attribute name.</value>
        [DataMember(Name="ldapName", EmitDefaultValue=true)]
        public string LdapName { get; set; }

        /// <summary>
        /// Gets or Sets SameValue
        /// </summary>
        [DataMember(Name="sameValue", EmitDefaultValue=false)]
        public CompareADObjectsResultADAttributeValue SameValue { get; set; }

        /// <summary>
        /// Gets or Sets SourceValue
        /// </summary>
        [DataMember(Name="sourceValue", EmitDefaultValue=false)]
        public CompareADObjectsResultADAttributeValue SourceValue { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ErrorProto Status { get; set; }

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
            return this.Equals(input as CompareADObjectsResultADAttribute);
        }

        /// <summary>
        /// Returns true if CompareADObjectsResultADAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of CompareADObjectsResultADAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompareADObjectsResultADAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttrFlags == input.AttrFlags ||
                    (this.AttrFlags != null &&
                    this.AttrFlags.Equals(input.AttrFlags))
                ) && 
                (
                    this.DestValue == input.DestValue ||
                    (this.DestValue != null &&
                    this.DestValue.Equals(input.DestValue))
                ) && 
                (
                    this.LdapName == input.LdapName ||
                    (this.LdapName != null &&
                    this.LdapName.Equals(input.LdapName))
                ) && 
                (
                    this.SameValue == input.SameValue ||
                    (this.SameValue != null &&
                    this.SameValue.Equals(input.SameValue))
                ) && 
                (
                    this.SourceValue == input.SourceValue ||
                    (this.SourceValue != null &&
                    this.SourceValue.Equals(input.SourceValue))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AttrFlags != null)
                    hashCode = hashCode * 59 + this.AttrFlags.GetHashCode();
                if (this.DestValue != null)
                    hashCode = hashCode * 59 + this.DestValue.GetHashCode();
                if (this.LdapName != null)
                    hashCode = hashCode * 59 + this.LdapName.GetHashCode();
                if (this.SameValue != null)
                    hashCode = hashCode * 59 + this.SameValue.GetHashCode();
                if (this.SourceValue != null)
                    hashCode = hashCode * 59 + this.SourceValue.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

