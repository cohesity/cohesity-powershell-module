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
    /// CloudArchivalDirectConfig specifies the properties of vaults used to perform Cloud Archive Direct (CAD)
    /// </summary>
    [DataContract]
    public partial class CloudArchivalDirectConfig :  IEquatable<CloudArchivalDirectConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudArchivalDirectConfig" /> class.
        /// </summary>
        /// <param name="bucketNamesapce">Specifies a namespace under the bucket used for archival..</param>
        /// <param name="physicalQuota">physicalQuota.</param>
        public CloudArchivalDirectConfig(string bucketNamesapce = default(string), QuotaPolicy physicalQuota = default(QuotaPolicy))
        {
            this.BucketNamesapce = bucketNamesapce;
            this.BucketNamesapce = bucketNamesapce;
            this.PhysicalQuota = physicalQuota;
        }
        
        /// <summary>
        /// Specifies a namespace under the bucket used for archival.
        /// </summary>
        /// <value>Specifies a namespace under the bucket used for archival.</value>
        [DataMember(Name="bucketNamesapce", EmitDefaultValue=true)]
        public string BucketNamesapce { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalQuota
        /// </summary>
        [DataMember(Name="physicalQuota", EmitDefaultValue=false)]
        public QuotaPolicy PhysicalQuota { get; set; }

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
            return this.Equals(input as CloudArchivalDirectConfig);
        }

        /// <summary>
        /// Returns true if CloudArchivalDirectConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudArchivalDirectConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudArchivalDirectConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BucketNamesapce == input.BucketNamesapce ||
                    (this.BucketNamesapce != null &&
                    this.BucketNamesapce.Equals(input.BucketNamesapce))
                ) && 
                (
                    this.PhysicalQuota == input.PhysicalQuota ||
                    (this.PhysicalQuota != null &&
                    this.PhysicalQuota.Equals(input.PhysicalQuota))
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
                if (this.BucketNamesapce != null)
                    hashCode = hashCode * 59 + this.BucketNamesapce.GetHashCode();
                if (this.PhysicalQuota != null)
                    hashCode = hashCode * 59 + this.PhysicalQuota.GetHashCode();
                return hashCode;
            }
        }

    }

}

