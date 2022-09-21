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
    /// ADObjectRestoreStatusADAttributeRestoreStatus
    /// </summary>
    [DataContract]
    public partial class ADObjectRestoreStatusADAttributeRestoreStatus :  IEquatable<ADObjectRestoreStatusADAttributeRestoreStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADObjectRestoreStatusADAttributeRestoreStatus" /> class.
        /// </summary>
        /// <param name="attrstatusVec">Error status. If the &#39;attrstatus_vec&#39; is empty or contains kNoError, treat the attribute restore as success. For multi-valued properties such as &#39;memberOf&#39;, this vector may contain failure to add or remove specific value within the multi-value set..</param>
        /// <param name="ldapName">LDAP name of the attribute..</param>
        public ADObjectRestoreStatusADAttributeRestoreStatus(List<ErrorProto> attrstatusVec = default(List<ErrorProto>), string ldapName = default(string))
        {
            this.AttrstatusVec = attrstatusVec;
            this.LdapName = ldapName;
            this.AttrstatusVec = attrstatusVec;
            this.LdapName = ldapName;
        }
        
        /// <summary>
        /// Error status. If the &#39;attrstatus_vec&#39; is empty or contains kNoError, treat the attribute restore as success. For multi-valued properties such as &#39;memberOf&#39;, this vector may contain failure to add or remove specific value within the multi-value set.
        /// </summary>
        /// <value>Error status. If the &#39;attrstatus_vec&#39; is empty or contains kNoError, treat the attribute restore as success. For multi-valued properties such as &#39;memberOf&#39;, this vector may contain failure to add or remove specific value within the multi-value set.</value>
        [DataMember(Name="attrstatusVec", EmitDefaultValue=true)]
        public List<ErrorProto> AttrstatusVec { get; set; }

        /// <summary>
        /// LDAP name of the attribute.
        /// </summary>
        /// <value>LDAP name of the attribute.</value>
        [DataMember(Name="ldapName", EmitDefaultValue=true)]
        public string LdapName { get; set; }

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
            return this.Equals(input as ADObjectRestoreStatusADAttributeRestoreStatus);
        }

        /// <summary>
        /// Returns true if ADObjectRestoreStatusADAttributeRestoreStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ADObjectRestoreStatusADAttributeRestoreStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADObjectRestoreStatusADAttributeRestoreStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttrstatusVec == input.AttrstatusVec ||
                    this.AttrstatusVec != null &&
                    input.AttrstatusVec != null &&
                    this.AttrstatusVec.Equals(input.AttrstatusVec)
                ) && 
                (
                    this.LdapName == input.LdapName ||
                    (this.LdapName != null &&
                    this.LdapName.Equals(input.LdapName))
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
                if (this.AttrstatusVec != null)
                    hashCode = hashCode * 59 + this.AttrstatusVec.GetHashCode();
                if (this.LdapName != null)
                    hashCode = hashCode * 59 + this.LdapName.GetHashCode();
                return hashCode;
            }
        }

    }

}

