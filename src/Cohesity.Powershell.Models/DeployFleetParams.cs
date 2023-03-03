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
    /// DeployFleetParams
    /// </summary>
    [DataContract]
    public partial class DeployFleetParams :  IEquatable<DeployFleetParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployFleetParams" /> class.
        /// </summary>
        /// <param name="awsFleetParams">awsFleetParams.</param>
        public DeployFleetParams(AWSFleetParams awsFleetParams = default(AWSFleetParams))
        {
            this.AwsFleetParams = awsFleetParams;
        }
        
        /// <summary>
        /// Gets or Sets AwsFleetParams
        /// </summary>
        [DataMember(Name="awsFleetParams", EmitDefaultValue=false)]
        public AWSFleetParams AwsFleetParams { get; set; }

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
            return this.Equals(input as DeployFleetParams);
        }

        /// <summary>
        /// Returns true if DeployFleetParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployFleetParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployFleetParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsFleetParams == input.AwsFleetParams ||
                    (this.AwsFleetParams != null &&
                    this.AwsFleetParams.Equals(input.AwsFleetParams))
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
                if (this.AwsFleetParams != null)
                    hashCode = hashCode * 59 + this.AwsFleetParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

