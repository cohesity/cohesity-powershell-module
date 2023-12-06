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
    /// Statement
    /// </summary>
    [DataContract]
    public partial class Statement :  IEquatable<Statement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statement" /> class.
        /// </summary>
        /// <param name="actionVec">This field includes keyword which map to permission for each S3 operation. We support wildcard(&#39;*&#39; and &#39;?&#39;) for this field. Some of the valid formats are : \&quot;*\&quot;, \&quot;s3:*\&quot;, \&quot;s3:*Object\&quot;.</param>
        /// <param name="conditionVec">The field specified the conditions for when a policy is in effect..</param>
        /// <param name="isAllow">This field specifies whether the statement results in an allow or an explicit deny..</param>
        /// <param name="negateActionVec">If set, actions except the ones specified in action_vec would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotAction\&quot; element..</param>
        /// <param name="negatePrincipal">If set, users except the specified principal would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotPrincipal\&quot; element..</param>
        /// <param name="negateResourceVec">If set, resources except the ones specified in resource_vec would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotResource\&quot; element..</param>
        /// <param name="principal">principal.</param>
        /// <param name="resourceVec">This field indicates the resource for which the statement is applied. The format we will be using is \&quot;urn:csf:s3:::bucket_name/key_name\&quot;. &#39;csf&#39; stands for Cohesity SmartFiles. We support wildcard(&#39;*&#39; and &#39;?&#39;) in the key name. Some of the valid formats are : \&quot;urn:csf:s3:::bucket_name\&quot;, \&quot;urn:csf:s3:::bucket_name/_*\&quot;, \&quot;urn:csf:s3:::bucket_name/_*_/ab?\&quot; We remove the common prefix &#39;urn:csf:s3:::bucket_name&#39; from the string and then store it in proto..</param>
        /// <param name="sid">Statement identifier..</param>
        public Statement(List<string> actionVec = default(List<string>), List<Condition> conditionVec = default(List<Condition>), bool? isAllow = default(bool?), bool? negateActionVec = default(bool?), bool? negatePrincipal = default(bool?), bool? negateResourceVec = default(bool?), Principal principal = default(Principal), List<string> resourceVec = default(List<string>), string sid = default(string))
        {
            this.ActionVec = actionVec;
            this.ConditionVec = conditionVec;
            this.IsAllow = isAllow;
            this.NegateActionVec = negateActionVec;
            this.NegatePrincipal = negatePrincipal;
            this.NegateResourceVec = negateResourceVec;
            this.ResourceVec = resourceVec;
            this.Sid = sid;
            this.ActionVec = actionVec;
            this.ConditionVec = conditionVec;
            this.IsAllow = isAllow;
            this.NegateActionVec = negateActionVec;
            this.NegatePrincipal = negatePrincipal;
            this.NegateResourceVec = negateResourceVec;
            this.Principal = principal;
            this.ResourceVec = resourceVec;
            this.Sid = sid;
        }
        
        /// <summary>
        /// This field includes keyword which map to permission for each S3 operation. We support wildcard(&#39;*&#39; and &#39;?&#39;) for this field. Some of the valid formats are : \&quot;*\&quot;, \&quot;s3:*\&quot;, \&quot;s3:*Object\&quot;
        /// </summary>
        /// <value>This field includes keyword which map to permission for each S3 operation. We support wildcard(&#39;*&#39; and &#39;?&#39;) for this field. Some of the valid formats are : \&quot;*\&quot;, \&quot;s3:*\&quot;, \&quot;s3:*Object\&quot;</value>
        [DataMember(Name="actionVec", EmitDefaultValue=true)]
        public List<string> ActionVec { get; set; }

        /// <summary>
        /// The field specified the conditions for when a policy is in effect.
        /// </summary>
        /// <value>The field specified the conditions for when a policy is in effect.</value>
        [DataMember(Name="conditionVec", EmitDefaultValue=true)]
        public List<Condition> ConditionVec { get; set; }

        /// <summary>
        /// This field specifies whether the statement results in an allow or an explicit deny.
        /// </summary>
        /// <value>This field specifies whether the statement results in an allow or an explicit deny.</value>
        [DataMember(Name="isAllow", EmitDefaultValue=true)]
        public bool? IsAllow { get; set; }

        /// <summary>
        /// If set, actions except the ones specified in action_vec would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotAction\&quot; element.
        /// </summary>
        /// <value>If set, actions except the ones specified in action_vec would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotAction\&quot; element.</value>
        [DataMember(Name="negateActionVec", EmitDefaultValue=true)]
        public bool? NegateActionVec { get; set; }

        /// <summary>
        /// If set, users except the specified principal would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotPrincipal\&quot; element.
        /// </summary>
        /// <value>If set, users except the specified principal would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotPrincipal\&quot; element.</value>
        [DataMember(Name="negatePrincipal", EmitDefaultValue=true)]
        public bool? NegatePrincipal { get; set; }

        /// <summary>
        /// If set, resources except the ones specified in resource_vec would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotResource\&quot; element.
        /// </summary>
        /// <value>If set, resources except the ones specified in resource_vec would be considered valid for evaluating the statement. This is set if JSON has \&quot;NotResource\&quot; element.</value>
        [DataMember(Name="negateResourceVec", EmitDefaultValue=true)]
        public bool? NegateResourceVec { get; set; }

        /// <summary>
        /// Gets or Sets Principal
        /// </summary>
        [DataMember(Name="principal", EmitDefaultValue=false)]
        public Principal Principal { get; set; }

        /// <summary>
        /// This field indicates the resource for which the statement is applied. The format we will be using is \&quot;urn:csf:s3:::bucket_name/key_name\&quot;. &#39;csf&#39; stands for Cohesity SmartFiles. We support wildcard(&#39;*&#39; and &#39;?&#39;) in the key name. Some of the valid formats are : \&quot;urn:csf:s3:::bucket_name\&quot;, \&quot;urn:csf:s3:::bucket_name/_*\&quot;, \&quot;urn:csf:s3:::bucket_name/_*_/ab?\&quot; We remove the common prefix &#39;urn:csf:s3:::bucket_name&#39; from the string and then store it in proto.
        /// </summary>
        /// <value>This field indicates the resource for which the statement is applied. The format we will be using is \&quot;urn:csf:s3:::bucket_name/key_name\&quot;. &#39;csf&#39; stands for Cohesity SmartFiles. We support wildcard(&#39;*&#39; and &#39;?&#39;) in the key name. Some of the valid formats are : \&quot;urn:csf:s3:::bucket_name\&quot;, \&quot;urn:csf:s3:::bucket_name/_*\&quot;, \&quot;urn:csf:s3:::bucket_name/_*_/ab?\&quot; We remove the common prefix &#39;urn:csf:s3:::bucket_name&#39; from the string and then store it in proto.</value>
        [DataMember(Name="resourceVec", EmitDefaultValue=true)]
        public List<string> ResourceVec { get; set; }

        /// <summary>
        /// Statement identifier.
        /// </summary>
        /// <value>Statement identifier.</value>
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
            return this.Equals(input as Statement);
        }

        /// <summary>
        /// Returns true if Statement instances are equal
        /// </summary>
        /// <param name="input">Instance of Statement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionVec == input.ActionVec ||
                    this.ActionVec != null &&
                    input.ActionVec != null &&
                    this.ActionVec.SequenceEqual(input.ActionVec)
                ) && 
                (
                    this.ConditionVec == input.ConditionVec ||
                    this.ConditionVec != null &&
                    input.ConditionVec != null &&
                    this.ConditionVec.SequenceEqual(input.ConditionVec)
                ) && 
                (
                    this.IsAllow == input.IsAllow ||
                    (this.IsAllow != null &&
                    this.IsAllow.Equals(input.IsAllow))
                ) && 
                (
                    this.NegateActionVec == input.NegateActionVec ||
                    (this.NegateActionVec != null &&
                    this.NegateActionVec.Equals(input.NegateActionVec))
                ) && 
                (
                    this.NegatePrincipal == input.NegatePrincipal ||
                    (this.NegatePrincipal != null &&
                    this.NegatePrincipal.Equals(input.NegatePrincipal))
                ) && 
                (
                    this.NegateResourceVec == input.NegateResourceVec ||
                    (this.NegateResourceVec != null &&
                    this.NegateResourceVec.Equals(input.NegateResourceVec))
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.ResourceVec == input.ResourceVec ||
                    this.ResourceVec != null &&
                    input.ResourceVec != null &&
                    this.ResourceVec.SequenceEqual(input.ResourceVec)
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
                if (this.ActionVec != null)
                    hashCode = hashCode * 59 + this.ActionVec.GetHashCode();
                if (this.ConditionVec != null)
                    hashCode = hashCode * 59 + this.ConditionVec.GetHashCode();
                if (this.IsAllow != null)
                    hashCode = hashCode * 59 + this.IsAllow.GetHashCode();
                if (this.NegateActionVec != null)
                    hashCode = hashCode * 59 + this.NegateActionVec.GetHashCode();
                if (this.NegatePrincipal != null)
                    hashCode = hashCode * 59 + this.NegatePrincipal.GetHashCode();
                if (this.NegateResourceVec != null)
                    hashCode = hashCode * 59 + this.NegateResourceVec.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.ResourceVec != null)
                    hashCode = hashCode * 59 + this.ResourceVec.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                return hashCode;
            }
        }

    }

}

