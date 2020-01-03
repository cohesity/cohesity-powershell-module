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
    /// Specifies details about the AD objects.
    /// </summary>
    [DataContract]
    public partial class AdObjectMetaData :  IEquatable<AdObjectMetaData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdObjectMetaData" /> class.
        /// </summary>
        /// <param name="distinguishedName">Specifies the Distinguished name of the AD object..</param>
        /// <param name="email">Specifies the email of the AD object of type user or group..</param>
        /// <param name="guid">Specifies the Guid of the AD object..</param>
        /// <param name="name">Specifies the name of the AD object..</param>
        /// <param name="objectType">Specifies the type of the AD Object. The type may be user, computer, group or ou..</param>
        /// <param name="samAccountName">Specifies the sam account name of the AD object..</param>
        public AdObjectMetaData(string distinguishedName = default(string), string email = default(string), string guid = default(string), string name = default(string), string objectType = default(string), string samAccountName = default(string))
        {
            this.DistinguishedName = distinguishedName;
            this.Email = email;
            this.Guid = guid;
            this.Name = name;
            this.ObjectType = objectType;
            this.SamAccountName = samAccountName;
            this.DistinguishedName = distinguishedName;
            this.Email = email;
            this.Guid = guid;
            this.Name = name;
            this.ObjectType = objectType;
            this.SamAccountName = samAccountName;
        }
        
        /// <summary>
        /// Specifies the Distinguished name of the AD object.
        /// </summary>
        /// <value>Specifies the Distinguished name of the AD object.</value>
        [DataMember(Name="distinguishedName", EmitDefaultValue=true)]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Specifies the email of the AD object of type user or group.
        /// </summary>
        /// <value>Specifies the email of the AD object of type user or group.</value>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Specifies the Guid of the AD object.
        /// </summary>
        /// <value>Specifies the Guid of the AD object.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies the name of the AD object.
        /// </summary>
        /// <value>Specifies the name of the AD object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the type of the AD Object. The type may be user, computer, group or ou.
        /// </summary>
        /// <value>Specifies the type of the AD Object. The type may be user, computer, group or ou.</value>
        [DataMember(Name="objectType", EmitDefaultValue=true)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Specifies the sam account name of the AD object.
        /// </summary>
        /// <value>Specifies the sam account name of the AD object.</value>
        [DataMember(Name="samAccountName", EmitDefaultValue=true)]
        public string SamAccountName { get; set; }

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
            return this.Equals(input as AdObjectMetaData);
        }

        /// <summary>
        /// Returns true if AdObjectMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of AdObjectMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdObjectMetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DistinguishedName == input.DistinguishedName ||
                    (this.DistinguishedName != null &&
                    this.DistinguishedName.Equals(input.DistinguishedName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.SamAccountName == input.SamAccountName ||
                    (this.SamAccountName != null &&
                    this.SamAccountName.Equals(input.SamAccountName))
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
                if (this.DistinguishedName != null)
                    hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.SamAccountName != null)
                    hashCode = hashCode * 59 + this.SamAccountName.GetHashCode();
                return hashCode;
            }
        }

    }

}

