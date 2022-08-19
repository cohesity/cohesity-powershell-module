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
    /// BucketPolicy
    /// </summary>
    [DataContract]
    public partial class BucketPolicy :  IEquatable<BucketPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketPolicy" /> class.
        /// </summary>
        /// <param name="id">The identifier for the bucket policy..</param>
        /// <param name="rawPolicyStr">Raw JSON string of the stored policy..</param>
        /// <param name="statementVec">This field defines the statement to execute for each request..</param>
        /// <param name="version">This field specifies the language syntax rules that are to be used to process the policy..</param>
        public BucketPolicy(string id = default(string), string rawPolicyStr = default(string), List<Statement> statementVec = default(List<Statement>), string version = default(string))
        {
            this.Id = id;
            this.RawPolicyStr = rawPolicyStr;
            this.StatementVec = statementVec;
            this.Version = version;
            this.Id = id;
            this.RawPolicyStr = rawPolicyStr;
            this.StatementVec = statementVec;
            this.Version = version;
        }
        
        /// <summary>
        /// The identifier for the bucket policy.
        /// </summary>
        /// <value>The identifier for the bucket policy.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Raw JSON string of the stored policy.
        /// </summary>
        /// <value>Raw JSON string of the stored policy.</value>
        [DataMember(Name="rawPolicyStr", EmitDefaultValue=true)]
        public string RawPolicyStr { get; set; }

        /// <summary>
        /// This field defines the statement to execute for each request.
        /// </summary>
        /// <value>This field defines the statement to execute for each request.</value>
        [DataMember(Name="statementVec", EmitDefaultValue=true)]
        public List<Statement> StatementVec { get; set; }

        /// <summary>
        /// This field specifies the language syntax rules that are to be used to process the policy.
        /// </summary>
        /// <value>This field specifies the language syntax rules that are to be used to process the policy.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as BucketPolicy);
        }

        /// <summary>
        /// Returns true if BucketPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RawPolicyStr == input.RawPolicyStr ||
                    (this.RawPolicyStr != null &&
                    this.RawPolicyStr.Equals(input.RawPolicyStr))
                ) && 
                (
                    this.StatementVec == input.StatementVec ||
                    this.StatementVec != null &&
                    input.StatementVec != null &&
                    this.StatementVec.Equals(input.StatementVec)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RawPolicyStr != null)
                    hashCode = hashCode * 59 + this.RawPolicyStr.GetHashCode();
                if (this.StatementVec != null)
                    hashCode = hashCode * 59 + this.StatementVec.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

