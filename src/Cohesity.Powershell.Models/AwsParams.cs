// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// AwsParams
    /// </summary>
    [DataContract]
    public partial class AwsParams :  IEquatable<AwsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsParams" /> class.
        /// </summary>
        /// <param name="region">Specifies id of the AWS region in which to deploy the VM..</param>
        public AwsParams(long? region = default(long?))
        {
            this.Region = region;
        }
        
        /// <summary>
        /// Specifies id of the AWS region in which to deploy the VM.
        /// </summary>
        /// <value>Specifies id of the AWS region in which to deploy the VM.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public long? Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as AwsParams);
        }

        /// <summary>
        /// Returns true if AwsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

