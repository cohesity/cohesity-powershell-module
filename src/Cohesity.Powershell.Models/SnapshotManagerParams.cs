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
    /// SnapshotManagerParams
    /// </summary>
    [DataContract]
    public partial class SnapshotManagerParams :  IEquatable<SnapshotManagerParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotManagerParams" /> class.
        /// </summary>
        /// <param name="awsSnapshotManagerParams">awsSnapshotManagerParams.</param>
        public SnapshotManagerParams(AWSSnapshotManagerParams awsSnapshotManagerParams = default(AWSSnapshotManagerParams))
        {
            this.AwsSnapshotManagerParams = awsSnapshotManagerParams;
        }
        
        /// <summary>
        /// Gets or Sets AwsSnapshotManagerParams
        /// </summary>
        [DataMember(Name="awsSnapshotManagerParams", EmitDefaultValue=false)]
        public AWSSnapshotManagerParams AwsSnapshotManagerParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotManagerParams {\n");
            sb.Append("  AwsSnapshotManagerParams: ").Append(AwsSnapshotManagerParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as SnapshotManagerParams);
        }

        /// <summary>
        /// Returns true if SnapshotManagerParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotManagerParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotManagerParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsSnapshotManagerParams == input.AwsSnapshotManagerParams ||
                    (this.AwsSnapshotManagerParams != null &&
                    this.AwsSnapshotManagerParams.Equals(input.AwsSnapshotManagerParams))
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
                if (this.AwsSnapshotManagerParams != null)
                    hashCode = hashCode * 59 + this.AwsSnapshotManagerParams.GetHashCode();
                return hashCode;
            }
        }

    }

}
