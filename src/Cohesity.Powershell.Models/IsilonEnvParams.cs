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
    /// Message to capture Ision-spcific environment parameters.
    /// </summary>
    [DataContract]
    public partial class IsilonEnvParams :  IEquatable<IsilonEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonEnvParams" /> class.
        /// </summary>
        /// <param name="zoneConfigMap">Mapping from access zone name to configuration..</param>
        public IsilonEnvParams(List<IsilonEnvParamsZoneConfigMapEntry> zoneConfigMap = default(List<IsilonEnvParamsZoneConfigMapEntry>))
        {
            this.ZoneConfigMap = zoneConfigMap;
            this.ZoneConfigMap = zoneConfigMap;
        }
        
        /// <summary>
        /// Mapping from access zone name to configuration.
        /// </summary>
        /// <value>Mapping from access zone name to configuration.</value>
        [DataMember(Name="zoneConfigMap", EmitDefaultValue=true)]
        public List<IsilonEnvParamsZoneConfigMapEntry> ZoneConfigMap { get; set; }

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
            return this.Equals(input as IsilonEnvParams);
        }

        /// <summary>
        /// Returns true if IsilonEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZoneConfigMap == input.ZoneConfigMap ||
                    this.ZoneConfigMap != null &&
                    input.ZoneConfigMap != null &&
                    this.ZoneConfigMap.SequenceEqual(input.ZoneConfigMap)
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
                if (this.ZoneConfigMap != null)
                    hashCode = hashCode * 59 + this.ZoneConfigMap.GetHashCode();
                return hashCode;
            }
        }

    }

}

