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
    /// Message to capture any additional backup params specific to externally triggered backup job.
    /// </summary>
    [DataContract]
    public partial class ExternallyTriggeredJobParams :  IEquatable<ExternallyTriggeredJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternallyTriggeredJobParams" /> class.
        /// </summary>
        /// <param name="clientType">The client type for this job..</param>
        /// <param name="sbtParams">sbtParams.</param>
        /// <param name="tags">All the tags populated in the runs of the externally triggered job. This field is only for the convenience of UI filtering the runs based on the tag. It should be populated only for the Iris query requests and should never be persisted..</param>
        public ExternallyTriggeredJobParams(int? clientType = default(int?), ExternallyTriggeredJobParamsExternallyTriggeredSbtParams sbtParams = default(ExternallyTriggeredJobParamsExternallyTriggeredSbtParams), List<string> tags = default(List<string>))
        {
            this.ClientType = clientType;
            this.Tags = tags;
            this.ClientType = clientType;
            this.SbtParams = sbtParams;
            this.Tags = tags;
        }
        
        /// <summary>
        /// The client type for this job.
        /// </summary>
        /// <value>The client type for this job.</value>
        [DataMember(Name="clientType", EmitDefaultValue=true)]
        public int? ClientType { get; set; }

        /// <summary>
        /// Gets or Sets SbtParams
        /// </summary>
        [DataMember(Name="sbtParams", EmitDefaultValue=false)]
        public ExternallyTriggeredJobParamsExternallyTriggeredSbtParams SbtParams { get; set; }

        /// <summary>
        /// All the tags populated in the runs of the externally triggered job. This field is only for the convenience of UI filtering the runs based on the tag. It should be populated only for the Iris query requests and should never be persisted.
        /// </summary>
        /// <value>All the tags populated in the runs of the externally triggered job. This field is only for the convenience of UI filtering the runs based on the tag. It should be populated only for the Iris query requests and should never be persisted.</value>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

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
            return this.Equals(input as ExternallyTriggeredJobParams);
        }

        /// <summary>
        /// Returns true if ExternallyTriggeredJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternallyTriggeredJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternallyTriggeredJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientType == input.ClientType ||
                    (this.ClientType != null &&
                    this.ClientType.Equals(input.ClientType))
                ) && 
                (
                    this.SbtParams == input.SbtParams ||
                    (this.SbtParams != null &&
                    this.SbtParams.Equals(input.SbtParams))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.ClientType != null)
                    hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.SbtParams != null)
                    hashCode = hashCode * 59 + this.SbtParams.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }

    }

}

