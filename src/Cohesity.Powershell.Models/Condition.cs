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
    /// Condition
    /// </summary>
    [DataContract]
    public partial class Condition :  IEquatable<Condition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="condOperator">This field describes the operator to use to perform the condition checks..</param>
        /// <param name="conditionKeyValuesMap">This field describes the condition keys and the values specified for that key. An example of key is \&quot;s3:x-amz-acl\&quot; with values like \&quot;public-read\&quot;, meaning that the request should include \&quot;public-read\&quot; in the ACL header..</param>
        /// <param name="forAllValues">This field describes whether the condition matches all of the input values matches against any at least one of the values in &#39;condition_key_values_map&#39;..</param>
        /// <param name="forAnyValue">This field describes whether the condition matches any of the input values matches against any one of the values in &#39;condition_key_values_map&#39;..</param>
        /// <param name="ifExists">This field describes whether to evaluate condition as true if the condition key does not exist and if it exists then it should match the values from &#39;condition_key_values_map&#39;..</param>
        public Condition(int? condOperator = default(int?), List<ConditionConditionKeyValuesMapEntry> conditionKeyValuesMap = default(List<ConditionConditionKeyValuesMapEntry>), bool? forAllValues = default(bool?), bool? forAnyValue = default(bool?), bool? ifExists = default(bool?))
        {
            this.CondOperator = condOperator;
            this.ConditionKeyValuesMap = conditionKeyValuesMap;
            this.ForAllValues = forAllValues;
            this.ForAnyValue = forAnyValue;
            this.IfExists = ifExists;
            this.CondOperator = condOperator;
            this.ConditionKeyValuesMap = conditionKeyValuesMap;
            this.ForAllValues = forAllValues;
            this.ForAnyValue = forAnyValue;
            this.IfExists = ifExists;
        }
        
        /// <summary>
        /// This field describes the operator to use to perform the condition checks.
        /// </summary>
        /// <value>This field describes the operator to use to perform the condition checks.</value>
        [DataMember(Name="condOperator", EmitDefaultValue=true)]
        public int? CondOperator { get; set; }

        /// <summary>
        /// This field describes the condition keys and the values specified for that key. An example of key is \&quot;s3:x-amz-acl\&quot; with values like \&quot;public-read\&quot;, meaning that the request should include \&quot;public-read\&quot; in the ACL header.
        /// </summary>
        /// <value>This field describes the condition keys and the values specified for that key. An example of key is \&quot;s3:x-amz-acl\&quot; with values like \&quot;public-read\&quot;, meaning that the request should include \&quot;public-read\&quot; in the ACL header.</value>
        [DataMember(Name="conditionKeyValuesMap", EmitDefaultValue=true)]
        public List<ConditionConditionKeyValuesMapEntry> ConditionKeyValuesMap { get; set; }

        /// <summary>
        /// This field describes whether the condition matches all of the input values matches against any at least one of the values in &#39;condition_key_values_map&#39;.
        /// </summary>
        /// <value>This field describes whether the condition matches all of the input values matches against any at least one of the values in &#39;condition_key_values_map&#39;.</value>
        [DataMember(Name="forAllValues", EmitDefaultValue=true)]
        public bool? ForAllValues { get; set; }

        /// <summary>
        /// This field describes whether the condition matches any of the input values matches against any one of the values in &#39;condition_key_values_map&#39;.
        /// </summary>
        /// <value>This field describes whether the condition matches any of the input values matches against any one of the values in &#39;condition_key_values_map&#39;.</value>
        [DataMember(Name="forAnyValue", EmitDefaultValue=true)]
        public bool? ForAnyValue { get; set; }

        /// <summary>
        /// This field describes whether to evaluate condition as true if the condition key does not exist and if it exists then it should match the values from &#39;condition_key_values_map&#39;.
        /// </summary>
        /// <value>This field describes whether to evaluate condition as true if the condition key does not exist and if it exists then it should match the values from &#39;condition_key_values_map&#39;.</value>
        [DataMember(Name="ifExists", EmitDefaultValue=true)]
        public bool? IfExists { get; set; }

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
            return this.Equals(input as Condition);
        }

        /// <summary>
        /// Returns true if Condition instances are equal
        /// </summary>
        /// <param name="input">Instance of Condition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Condition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CondOperator == input.CondOperator ||
                    (this.CondOperator != null &&
                    this.CondOperator.Equals(input.CondOperator))
                ) && 
                (
                    this.ConditionKeyValuesMap == input.ConditionKeyValuesMap ||
                    this.ConditionKeyValuesMap != null &&
                    input.ConditionKeyValuesMap != null &&
                    this.ConditionKeyValuesMap.SequenceEqual(input.ConditionKeyValuesMap)
                ) && 
                (
                    this.ForAllValues == input.ForAllValues ||
                    (this.ForAllValues != null &&
                    this.ForAllValues.Equals(input.ForAllValues))
                ) && 
                (
                    this.ForAnyValue == input.ForAnyValue ||
                    (this.ForAnyValue != null &&
                    this.ForAnyValue.Equals(input.ForAnyValue))
                ) && 
                (
                    this.IfExists == input.IfExists ||
                    (this.IfExists != null &&
                    this.IfExists.Equals(input.IfExists))
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
                if (this.CondOperator != null)
                    hashCode = hashCode * 59 + this.CondOperator.GetHashCode();
                if (this.ConditionKeyValuesMap != null)
                    hashCode = hashCode * 59 + this.ConditionKeyValuesMap.GetHashCode();
                if (this.ForAllValues != null)
                    hashCode = hashCode * 59 + this.ForAllValues.GetHashCode();
                if (this.ForAnyValue != null)
                    hashCode = hashCode * 59 + this.ForAnyValue.GetHashCode();
                if (this.IfExists != null)
                    hashCode = hashCode * 59 + this.IfExists.GetHashCode();
                return hashCode;
            }
        }

    }

}

