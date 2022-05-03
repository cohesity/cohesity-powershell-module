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
    /// IsilonEnvParamsZoneConfig
    /// </summary>
    [DataContract]
    public partial class IsilonEnvParamsZoneConfig :  IEquatable<IsilonEnvParamsZoneConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonEnvParamsZoneConfig" /> class.
        /// </summary>
        /// <param name="dynamicNetworkPoolConfig">dynamicNetworkPoolConfig.</param>
        /// <param name="groupnet">Name of the zone&#39;s groupnet..</param>
        /// <param name="smbCredentials">smbCredentials.</param>
        /// <param name="staticNetworkPoolConfig">staticNetworkPoolConfig.</param>
        public IsilonEnvParamsZoneConfig(IsilonEnvParamsZoneConfigNetworkPoolConfig dynamicNetworkPoolConfig = default(IsilonEnvParamsZoneConfigNetworkPoolConfig), string groupnet = default(string), NasMountCredentials smbCredentials = default(NasMountCredentials), IsilonEnvParamsZoneConfigNetworkPoolConfig staticNetworkPoolConfig = default(IsilonEnvParamsZoneConfigNetworkPoolConfig))
        {
            this.DynamicNetworkPoolConfig = dynamicNetworkPoolConfig;
            this.Groupnet = groupnet;
            this.SmbCredentials = smbCredentials;
            this.StaticNetworkPoolConfig = staticNetworkPoolConfig;
        }
        
        /// <summary>
        /// Gets or Sets DynamicNetworkPoolConfig
        /// </summary>
        [DataMember(Name="dynamicNetworkPoolConfig", EmitDefaultValue=false)]
        public IsilonEnvParamsZoneConfigNetworkPoolConfig DynamicNetworkPoolConfig { get; set; }

        /// <summary>
        /// Name of the zone&#39;s groupnet.
        /// </summary>
        /// <value>Name of the zone&#39;s groupnet.</value>
        [DataMember(Name="groupnet", EmitDefaultValue=false)]
        public string Groupnet { get; set; }

        /// <summary>
        /// Gets or Sets SmbCredentials
        /// </summary>
        [DataMember(Name="smbCredentials", EmitDefaultValue=false)]
        public NasMountCredentials SmbCredentials { get; set; }

        /// <summary>
        /// Gets or Sets StaticNetworkPoolConfig
        /// </summary>
        [DataMember(Name="staticNetworkPoolConfig", EmitDefaultValue=false)]
        public IsilonEnvParamsZoneConfigNetworkPoolConfig StaticNetworkPoolConfig { get; set; }

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
            return this.Equals(input as IsilonEnvParamsZoneConfig);
        }

        /// <summary>
        /// Returns true if IsilonEnvParamsZoneConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonEnvParamsZoneConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonEnvParamsZoneConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DynamicNetworkPoolConfig == input.DynamicNetworkPoolConfig ||
                    (this.DynamicNetworkPoolConfig != null &&
                    this.DynamicNetworkPoolConfig.Equals(input.DynamicNetworkPoolConfig))
                ) && 
                (
                    this.Groupnet == input.Groupnet ||
                    (this.Groupnet != null &&
                    this.Groupnet.Equals(input.Groupnet))
                ) && 
                (
                    this.SmbCredentials == input.SmbCredentials ||
                    (this.SmbCredentials != null &&
                    this.SmbCredentials.Equals(input.SmbCredentials))
                ) && 
                (
                    this.StaticNetworkPoolConfig == input.StaticNetworkPoolConfig ||
                    (this.StaticNetworkPoolConfig != null &&
                    this.StaticNetworkPoolConfig.Equals(input.StaticNetworkPoolConfig))
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
                if (this.DynamicNetworkPoolConfig != null)
                    hashCode = hashCode * 59 + this.DynamicNetworkPoolConfig.GetHashCode();
                if (this.Groupnet != null)
                    hashCode = hashCode * 59 + this.Groupnet.GetHashCode();
                if (this.SmbCredentials != null)
                    hashCode = hashCode * 59 + this.SmbCredentials.GetHashCode();
                if (this.StaticNetworkPoolConfig != null)
                    hashCode = hashCode * 59 + this.StaticNetworkPoolConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

