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
    /// ADAttributeRestoreParam
    /// </summary>
    [DataContract]
    public partial class ADAttributeRestoreParam :  IEquatable<ADAttributeRestoreParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADAttributeRestoreParam" /> class.
        /// </summary>
        /// <param name="excludedPropertyVec">Array of LDAP property names to excluded from &#39;property_vec&#39;. Excluded property name cannot contain wildcard character &#39;*&#39;.  Property names are case insensitive..</param>
        /// <param name="guidpairVec">Array of source and destination object guid pairs to restore attributes. Pair source guid refers to guid in AD snapshot in source_server endpoint. Destination guid refers to guid in production AD. If destination guid is empty, then source guid in AD snapshot should exist in production AD..</param>
        /// <param name="optionFlags">Attribute restore option flags of type ADAttributeOptionFlags..</param>
        /// <param name="propertyVec">Array of LDAP property(attribute) names. The name can be standard or custom property defined in AD schema partition. The property can contain wildcard character &#39;*&#39;. If this array is empty, then &#39;*&#39; is assigned, means restore all properties except default system excluded properties. Wildcards will be expanded. If &#39;memberOf&#39; property is included, group membership of the objects specified in &#39;guid_vec&#39; will be restored. Property that does not exist for an object is ignored and no error info is returned for that property. Property names are case insensitive. Caller may check the ADAttributeFlags.kSystem obtained during object compare to exclude system properties..</param>
        public ADAttributeRestoreParam(List<string> excludedPropertyVec = default(List<string>), List<ADGuidPair> guidpairVec = default(List<ADGuidPair>), int? optionFlags = default(int?), List<string> propertyVec = default(List<string>))
        {
            this.ExcludedPropertyVec = excludedPropertyVec;
            this.GuidpairVec = guidpairVec;
            this.OptionFlags = optionFlags;
            this.PropertyVec = propertyVec;
            this.ExcludedPropertyVec = excludedPropertyVec;
            this.GuidpairVec = guidpairVec;
            this.OptionFlags = optionFlags;
            this.PropertyVec = propertyVec;
        }
        
        /// <summary>
        /// Array of LDAP property names to excluded from &#39;property_vec&#39;. Excluded property name cannot contain wildcard character &#39;*&#39;.  Property names are case insensitive.
        /// </summary>
        /// <value>Array of LDAP property names to excluded from &#39;property_vec&#39;. Excluded property name cannot contain wildcard character &#39;*&#39;.  Property names are case insensitive.</value>
        [DataMember(Name="excludedPropertyVec", EmitDefaultValue=true)]
        public List<string> ExcludedPropertyVec { get; set; }

        /// <summary>
        /// Array of source and destination object guid pairs to restore attributes. Pair source guid refers to guid in AD snapshot in source_server endpoint. Destination guid refers to guid in production AD. If destination guid is empty, then source guid in AD snapshot should exist in production AD.
        /// </summary>
        /// <value>Array of source and destination object guid pairs to restore attributes. Pair source guid refers to guid in AD snapshot in source_server endpoint. Destination guid refers to guid in production AD. If destination guid is empty, then source guid in AD snapshot should exist in production AD.</value>
        [DataMember(Name="guidpairVec", EmitDefaultValue=true)]
        public List<ADGuidPair> GuidpairVec { get; set; }

        /// <summary>
        /// Attribute restore option flags of type ADAttributeOptionFlags.
        /// </summary>
        /// <value>Attribute restore option flags of type ADAttributeOptionFlags.</value>
        [DataMember(Name="optionFlags", EmitDefaultValue=true)]
        public int? OptionFlags { get; set; }

        /// <summary>
        /// Array of LDAP property(attribute) names. The name can be standard or custom property defined in AD schema partition. The property can contain wildcard character &#39;*&#39;. If this array is empty, then &#39;*&#39; is assigned, means restore all properties except default system excluded properties. Wildcards will be expanded. If &#39;memberOf&#39; property is included, group membership of the objects specified in &#39;guid_vec&#39; will be restored. Property that does not exist for an object is ignored and no error info is returned for that property. Property names are case insensitive. Caller may check the ADAttributeFlags.kSystem obtained during object compare to exclude system properties.
        /// </summary>
        /// <value>Array of LDAP property(attribute) names. The name can be standard or custom property defined in AD schema partition. The property can contain wildcard character &#39;*&#39;. If this array is empty, then &#39;*&#39; is assigned, means restore all properties except default system excluded properties. Wildcards will be expanded. If &#39;memberOf&#39; property is included, group membership of the objects specified in &#39;guid_vec&#39; will be restored. Property that does not exist for an object is ignored and no error info is returned for that property. Property names are case insensitive. Caller may check the ADAttributeFlags.kSystem obtained during object compare to exclude system properties.</value>
        [DataMember(Name="propertyVec", EmitDefaultValue=true)]
        public List<string> PropertyVec { get; set; }

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
            return this.Equals(input as ADAttributeRestoreParam);
        }

        /// <summary>
        /// Returns true if ADAttributeRestoreParam instances are equal
        /// </summary>
        /// <param name="input">Instance of ADAttributeRestoreParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADAttributeRestoreParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludedPropertyVec == input.ExcludedPropertyVec ||
                    this.ExcludedPropertyVec != null &&
                    input.ExcludedPropertyVec != null &&
                    this.ExcludedPropertyVec.SequenceEqual(input.ExcludedPropertyVec)
                ) && 
                (
                    this.GuidpairVec == input.GuidpairVec ||
                    this.GuidpairVec != null &&
                    input.GuidpairVec != null &&
                    this.GuidpairVec.SequenceEqual(input.GuidpairVec)
                ) && 
                (
                    this.OptionFlags == input.OptionFlags ||
                    (this.OptionFlags != null &&
                    this.OptionFlags.Equals(input.OptionFlags))
                ) && 
                (
                    this.PropertyVec == input.PropertyVec ||
                    this.PropertyVec != null &&
                    input.PropertyVec != null &&
                    this.PropertyVec.SequenceEqual(input.PropertyVec)
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
                if (this.ExcludedPropertyVec != null)
                    hashCode = hashCode * 59 + this.ExcludedPropertyVec.GetHashCode();
                if (this.GuidpairVec != null)
                    hashCode = hashCode * 59 + this.GuidpairVec.GetHashCode();
                if (this.OptionFlags != null)
                    hashCode = hashCode * 59 + this.OptionFlags.GetHashCode();
                if (this.PropertyVec != null)
                    hashCode = hashCode * 59 + this.PropertyVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

