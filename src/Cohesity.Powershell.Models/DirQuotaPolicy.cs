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
    /// Specifies a policy configuration for the directory quota. A policy is the sole entity which describes the usage limits of a directory in a view.  &#x60;DirPath&#x60; is the identifier of a policy. It must be specified for adding, updating or removing a policy. If &#x60;Policy&#x60; is not set, then it is considered to be removed.
    /// </summary>
    [DataContract]
    public partial class DirQuotaPolicy :  IEquatable<DirQuotaPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirQuotaPolicy" /> class.
        /// </summary>
        /// <param name="dirPath">Specifies the path of the directory in the view..</param>
        /// <param name="dirWalkPending">Denotes directory quota walk is pending or not..</param>
        /// <param name="policy">policy.</param>
        /// <param name="usageBytes">Specifies the current usage (in bytes) by the directory in the view. This is set by the response received from bridge when querying directory quota usage..</param>
        public DirQuotaPolicy(string dirPath = default(string), bool? dirWalkPending = default(bool?), QuotaPolicy policy = default(QuotaPolicy), long? usageBytes = default(long?))
        {
            this.DirPath = dirPath;
            this.DirWalkPending = dirWalkPending;
            this.Policy = policy;
            this.UsageBytes = usageBytes;
        }
        
        /// <summary>
        /// Specifies the path of the directory in the view.
        /// </summary>
        /// <value>Specifies the path of the directory in the view.</value>
        [DataMember(Name="dirPath", EmitDefaultValue=false)]
        public string DirPath { get; set; }

        /// <summary>
        /// Denotes directory quota walk is pending or not.
        /// </summary>
        /// <value>Denotes directory quota walk is pending or not.</value>
        [DataMember(Name="dirWalkPending", EmitDefaultValue=false)]
        public bool? DirWalkPending { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public QuotaPolicy Policy { get; set; }

        /// <summary>
        /// Specifies the current usage (in bytes) by the directory in the view. This is set by the response received from bridge when querying directory quota usage.
        /// </summary>
        /// <value>Specifies the current usage (in bytes) by the directory in the view. This is set by the response received from bridge when querying directory quota usage.</value>
        [DataMember(Name="usageBytes", EmitDefaultValue=false)]
        public long? UsageBytes { get; set; }

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
            return this.Equals(input as DirQuotaPolicy);
        }

        /// <summary>
        /// Returns true if DirQuotaPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of DirQuotaPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirQuotaPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirPath == input.DirPath ||
                    (this.DirPath != null &&
                    this.DirPath.Equals(input.DirPath))
                ) && 
                (
                    this.DirWalkPending == input.DirWalkPending ||
                    (this.DirWalkPending != null &&
                    this.DirWalkPending.Equals(input.DirWalkPending))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.UsageBytes == input.UsageBytes ||
                    (this.UsageBytes != null &&
                    this.UsageBytes.Equals(input.UsageBytes))
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
                if (this.DirPath != null)
                    hashCode = hashCode * 59 + this.DirPath.GetHashCode();
                if (this.DirWalkPending != null)
                    hashCode = hashCode * 59 + this.DirWalkPending.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.UsageBytes != null)
                    hashCode = hashCode * 59 + this.UsageBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

