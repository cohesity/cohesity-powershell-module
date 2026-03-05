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
    /// ThrottlingPolicyGenericThrottlingConfig
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyGenericThrottlingConfig :  IEquatable<ThrottlingPolicyGenericThrottlingConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyGenericThrottlingConfig" /> class.
        /// </summary>
        /// <param name="genericResourceParamsVec">List of the config params for generic resources. For UDAv2, the connectors can advertise resources linked to various entities in the source&#39;s entity hierarchy. All such resources will be aggregated here in the list..</param>
        public ThrottlingPolicyGenericThrottlingConfig(List<ThrottlingPolicyGenericThrottlingConfigGenericResourceParams> genericResourceParamsVec = default(List<ThrottlingPolicyGenericThrottlingConfigGenericResourceParams>))
        {
            this.GenericResourceParamsVec = genericResourceParamsVec;
            this.GenericResourceParamsVec = genericResourceParamsVec;
        }
        
        /// <summary>
        /// List of the config params for generic resources. For UDAv2, the connectors can advertise resources linked to various entities in the source&#39;s entity hierarchy. All such resources will be aggregated here in the list.
        /// </summary>
        /// <value>List of the config params for generic resources. For UDAv2, the connectors can advertise resources linked to various entities in the source&#39;s entity hierarchy. All such resources will be aggregated here in the list.</value>
        [DataMember(Name="genericResourceParamsVec", EmitDefaultValue=true)]
        public List<ThrottlingPolicyGenericThrottlingConfigGenericResourceParams> GenericResourceParamsVec { get; set; }

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
            return this.Equals(input as ThrottlingPolicyGenericThrottlingConfig);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyGenericThrottlingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyGenericThrottlingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyGenericThrottlingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GenericResourceParamsVec == input.GenericResourceParamsVec ||
                    this.GenericResourceParamsVec != null &&
                    input.GenericResourceParamsVec != null &&
                    this.GenericResourceParamsVec.SequenceEqual(input.GenericResourceParamsVec)
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
                if (this.GenericResourceParamsVec != null)
                    hashCode = hashCode * 59 + this.GenericResourceParamsVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

