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
    /// AwsTargetParams
    /// </summary>
    [DataContract]
    public partial class AwsTargetParams :  IEquatable<AwsTargetParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsTargetParams" /> class.
        /// </summary>
        /// <param name="customServerConfig">customServerConfig.</param>
        /// <param name="isKnownSource">If set to true means we are recovering to a know source and &#39;known_source_config&#39; will be populated else &#39;custom_server_config&#39; will be populated..</param>
        /// <param name="knownSourceConfig">knownSourceConfig.</param>
        public AwsTargetParams(AwsTargetParamsNetworkConfig customServerConfig = default(AwsTargetParamsNetworkConfig), bool? isKnownSource = default(bool?), AwsTargetParamsNetworkConfig knownSourceConfig = default(AwsTargetParamsNetworkConfig))
        {
            this.IsKnownSource = isKnownSource;
            this.CustomServerConfig = customServerConfig;
            this.IsKnownSource = isKnownSource;
            this.KnownSourceConfig = knownSourceConfig;
        }
        
        /// <summary>
        /// Gets or Sets CustomServerConfig
        /// </summary>
        [DataMember(Name="customServerConfig", EmitDefaultValue=false)]
        public AwsTargetParamsNetworkConfig CustomServerConfig { get; set; }

        /// <summary>
        /// If set to true means we are recovering to a know source and &#39;known_source_config&#39; will be populated else &#39;custom_server_config&#39; will be populated.
        /// </summary>
        /// <value>If set to true means we are recovering to a know source and &#39;known_source_config&#39; will be populated else &#39;custom_server_config&#39; will be populated.</value>
        [DataMember(Name="isKnownSource", EmitDefaultValue=true)]
        public bool? IsKnownSource { get; set; }

        /// <summary>
        /// Gets or Sets KnownSourceConfig
        /// </summary>
        [DataMember(Name="knownSourceConfig", EmitDefaultValue=false)]
        public AwsTargetParamsNetworkConfig KnownSourceConfig { get; set; }

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
            return this.Equals(input as AwsTargetParams);
        }

        /// <summary>
        /// Returns true if AwsTargetParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsTargetParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsTargetParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomServerConfig == input.CustomServerConfig ||
                    (this.CustomServerConfig != null &&
                    this.CustomServerConfig.Equals(input.CustomServerConfig))
                ) && 
                (
                    this.IsKnownSource == input.IsKnownSource ||
                    (this.IsKnownSource != null &&
                    this.IsKnownSource.Equals(input.IsKnownSource))
                ) && 
                (
                    this.KnownSourceConfig == input.KnownSourceConfig ||
                    (this.KnownSourceConfig != null &&
                    this.KnownSourceConfig.Equals(input.KnownSourceConfig))
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
                if (this.CustomServerConfig != null)
                    hashCode = hashCode * 59 + this.CustomServerConfig.GetHashCode();
                if (this.IsKnownSource != null)
                    hashCode = hashCode * 59 + this.IsKnownSource.GetHashCode();
                if (this.KnownSourceConfig != null)
                    hashCode = hashCode * 59 + this.KnownSourceConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

