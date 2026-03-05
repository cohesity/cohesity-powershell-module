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
    /// CloudCredentials
    /// </summary>
    [DataContract]
    public partial class CloudCredentials :  IEquatable<CloudCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudCredentials" /> class.
        /// </summary>
        /// <param name="awsCredentials">awsCredentials.</param>
        public CloudCredentials(AwsCredentials awsCredentials = default(AwsCredentials))
        {
            this.AwsCredentials = awsCredentials;
        }
        
        /// <summary>
        /// Gets or Sets AwsCredentials
        /// </summary>
        [DataMember(Name="awsCredentials", EmitDefaultValue=false)]
        public AwsCredentials AwsCredentials { get; set; }

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
            return this.Equals(input as CloudCredentials);
        }

        /// <summary>
        /// Returns true if CloudCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsCredentials == input.AwsCredentials ||
                    (this.AwsCredentials != null &&
                    this.AwsCredentials.Equals(input.AwsCredentials))
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
                if (this.AwsCredentials != null)
                    hashCode = hashCode * 59 + this.AwsCredentials.GetHashCode();
                return hashCode;
            }
        }

    }

}

