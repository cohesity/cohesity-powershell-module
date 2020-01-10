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
    /// AdObjectAttributeParameters are AD attribute recovery parameters for one or more AD objects
    /// </summary>
    [DataContract]
    public partial class AdObjectAttributeParameters :  IEquatable<AdObjectAttributeParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdObjectAttributeParameters" /> class.
        /// </summary>
        /// <param name="adGuidPairs">Specifies the array of source and destination object guid pairs to restore attributes..</param>
        /// <param name="excludeLdapProperties">Specifies the array of LDAP property names to excluded from &#39;property_vec&#39;. Excluded property name cannot contain wildcard character &#39;*&#39;.  Property names are case insensitive..</param>
        /// <param name="ldapProperties">Specifies the array of LDAP property(attribute) names. The name can be standard or custom property defined in AD schema partition. The property can contain wildcard character &#39;*&#39;. If this array is empty, then &#39;*&#39; is assigned, means restore all properties except default system excluded properties. Wildcards will be expanded. If &#39;memberOf&#39; property is included, group membership of the objects specified in &#39;guid_vec&#39; will be restored. Property that does not exist for an object is ignored and no error info is returned for that property. Property names are case insensitive..</param>
        /// <param name="mergeMultiValProperties">Specifies the Option to merge multi-valued values vs clearing and setting values from the AD snapshot. Defaults is to overwrite production AD values from the source AD snapshot. When updating group membership (using &#39;memberOf&#39; property), setting this option to true will result in group membership merge. This is useful in cases where production AD has later updates that should not be overridden while restoring an attribute..</param>
        public AdObjectAttributeParameters(List<ADGuidPair> adGuidPairs = default(List<ADGuidPair>), List<string> excludeLdapProperties = default(List<string>), List<string> ldapProperties = default(List<string>), bool? mergeMultiValProperties = default(bool?))
        {
            this.AdGuidPairs = adGuidPairs;
            this.ExcludeLdapProperties = excludeLdapProperties;
            this.LdapProperties = ldapProperties;
            this.MergeMultiValProperties = mergeMultiValProperties;
            this.AdGuidPairs = adGuidPairs;
            this.ExcludeLdapProperties = excludeLdapProperties;
            this.LdapProperties = ldapProperties;
            this.MergeMultiValProperties = mergeMultiValProperties;
        }
        
        /// <summary>
        /// Specifies the array of source and destination object guid pairs to restore attributes.
        /// </summary>
        /// <value>Specifies the array of source and destination object guid pairs to restore attributes.</value>
        [DataMember(Name="adGuidPairs", EmitDefaultValue=true)]
        public List<ADGuidPair> AdGuidPairs { get; set; }

        /// <summary>
        /// Specifies the array of LDAP property names to excluded from &#39;property_vec&#39;. Excluded property name cannot contain wildcard character &#39;*&#39;.  Property names are case insensitive.
        /// </summary>
        /// <value>Specifies the array of LDAP property names to excluded from &#39;property_vec&#39;. Excluded property name cannot contain wildcard character &#39;*&#39;.  Property names are case insensitive.</value>
        [DataMember(Name="excludeLdapProperties", EmitDefaultValue=true)]
        public List<string> ExcludeLdapProperties { get; set; }

        /// <summary>
        /// Specifies the array of LDAP property(attribute) names. The name can be standard or custom property defined in AD schema partition. The property can contain wildcard character &#39;*&#39;. If this array is empty, then &#39;*&#39; is assigned, means restore all properties except default system excluded properties. Wildcards will be expanded. If &#39;memberOf&#39; property is included, group membership of the objects specified in &#39;guid_vec&#39; will be restored. Property that does not exist for an object is ignored and no error info is returned for that property. Property names are case insensitive.
        /// </summary>
        /// <value>Specifies the array of LDAP property(attribute) names. The name can be standard or custom property defined in AD schema partition. The property can contain wildcard character &#39;*&#39;. If this array is empty, then &#39;*&#39; is assigned, means restore all properties except default system excluded properties. Wildcards will be expanded. If &#39;memberOf&#39; property is included, group membership of the objects specified in &#39;guid_vec&#39; will be restored. Property that does not exist for an object is ignored and no error info is returned for that property. Property names are case insensitive.</value>
        [DataMember(Name="ldapProperties", EmitDefaultValue=true)]
        public List<string> LdapProperties { get; set; }

        /// <summary>
        /// Specifies the Option to merge multi-valued values vs clearing and setting values from the AD snapshot. Defaults is to overwrite production AD values from the source AD snapshot. When updating group membership (using &#39;memberOf&#39; property), setting this option to true will result in group membership merge. This is useful in cases where production AD has later updates that should not be overridden while restoring an attribute.
        /// </summary>
        /// <value>Specifies the Option to merge multi-valued values vs clearing and setting values from the AD snapshot. Defaults is to overwrite production AD values from the source AD snapshot. When updating group membership (using &#39;memberOf&#39; property), setting this option to true will result in group membership merge. This is useful in cases where production AD has later updates that should not be overridden while restoring an attribute.</value>
        [DataMember(Name="mergeMultiValProperties", EmitDefaultValue=true)]
        public bool? MergeMultiValProperties { get; set; }

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
            return this.Equals(input as AdObjectAttributeParameters);
        }

        /// <summary>
        /// Returns true if AdObjectAttributeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of AdObjectAttributeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdObjectAttributeParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdGuidPairs == input.AdGuidPairs ||
                    this.AdGuidPairs != null &&
                    input.AdGuidPairs != null &&
                    this.AdGuidPairs.SequenceEqual(input.AdGuidPairs)
                ) && 
                (
                    this.ExcludeLdapProperties == input.ExcludeLdapProperties ||
                    this.ExcludeLdapProperties != null &&
                    input.ExcludeLdapProperties != null &&
                    this.ExcludeLdapProperties.SequenceEqual(input.ExcludeLdapProperties)
                ) && 
                (
                    this.LdapProperties == input.LdapProperties ||
                    this.LdapProperties != null &&
                    input.LdapProperties != null &&
                    this.LdapProperties.SequenceEqual(input.LdapProperties)
                ) && 
                (
                    this.MergeMultiValProperties == input.MergeMultiValProperties ||
                    (this.MergeMultiValProperties != null &&
                    this.MergeMultiValProperties.Equals(input.MergeMultiValProperties))
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
                if (this.AdGuidPairs != null)
                    hashCode = hashCode * 59 + this.AdGuidPairs.GetHashCode();
                if (this.ExcludeLdapProperties != null)
                    hashCode = hashCode * 59 + this.ExcludeLdapProperties.GetHashCode();
                if (this.LdapProperties != null)
                    hashCode = hashCode * 59 + this.LdapProperties.GetHashCode();
                if (this.MergeMultiValProperties != null)
                    hashCode = hashCode * 59 + this.MergeMultiValProperties.GetHashCode();
                return hashCode;
            }
        }

    }

}

