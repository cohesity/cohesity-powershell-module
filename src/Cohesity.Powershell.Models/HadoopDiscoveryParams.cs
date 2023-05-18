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
    /// Specifies an Object containing information about discovering a Hadoop source.
    /// </summary>
    [DataContract]
    public partial class HadoopDiscoveryParams :  IEquatable<HadoopDiscoveryParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HadoopDiscoveryParams" /> class.
        /// </summary>
        /// <param name="configDirectory">Specifies the configuration directory.</param>
        /// <param name="host">Specifies the host IP..</param>
        public HadoopDiscoveryParams(string configDirectory = default(string), string host = default(string))
        {
            this.ConfigDirectory = configDirectory;
            this.Host = host;
            this.ConfigDirectory = configDirectory;
            this.Host = host;
        }
        
        /// <summary>
        /// Specifies the configuration directory
        /// </summary>
        /// <value>Specifies the configuration directory</value>
        [DataMember(Name="configDirectory", EmitDefaultValue=true)]
        public string ConfigDirectory { get; set; }

        /// <summary>
        /// Specifies the host IP.
        /// </summary>
        /// <value>Specifies the host IP.</value>
        [DataMember(Name="host", EmitDefaultValue=true)]
        public string Host { get; set; }

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
            return this.Equals(input as HadoopDiscoveryParams);
        }

        /// <summary>
        /// Returns true if HadoopDiscoveryParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HadoopDiscoveryParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HadoopDiscoveryParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigDirectory == input.ConfigDirectory ||
                    (this.ConfigDirectory != null &&
                    this.ConfigDirectory.Equals(input.ConfigDirectory))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
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
                if (this.ConfigDirectory != null)
                    hashCode = hashCode * 59 + this.ConfigDirectory.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                return hashCode;
            }
        }

    }

}

