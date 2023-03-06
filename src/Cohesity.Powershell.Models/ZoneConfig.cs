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
    /// ZoneConfig
    /// </summary>
    [DataContract]
    public partial class ZoneConfig :  IEquatable<ZoneConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneConfig" /> class.
        /// </summary>
        /// <param name="dynamicNetworkPoolConfig">dynamicNetworkPoolConfig.</param>
        /// <param name="groupnet">Specifies the name of the Access Zone&#39;s groupnet..</param>
        /// <param name="name">Specifies the name of the Access Zone..</param>
        /// <param name="smbCredentials">smbCredentials.</param>
        /// <param name="staticNetworkPoolConfig">staticNetworkPoolConfig.</param>
        public ZoneConfig(NetworkPoolConfig dynamicNetworkPoolConfig = default(NetworkPoolConfig), string groupnet = default(string), string name = default(string), NasMountCredentialParams smbCredentials = default(NasMountCredentialParams), NetworkPoolConfig staticNetworkPoolConfig = default(NetworkPoolConfig))
        {
            this.Groupnet = groupnet;
            this.Name = name;
            this.DynamicNetworkPoolConfig = dynamicNetworkPoolConfig;
            this.Groupnet = groupnet;
            this.Name = name;
            this.SmbCredentials = smbCredentials;
            this.StaticNetworkPoolConfig = staticNetworkPoolConfig;
        }
        
        /// <summary>
        /// Gets or Sets DynamicNetworkPoolConfig
        /// </summary>
        [DataMember(Name="dynamicNetworkPoolConfig", EmitDefaultValue=false)]
        public NetworkPoolConfig DynamicNetworkPoolConfig { get; set; }

        /// <summary>
        /// Specifies the name of the Access Zone&#39;s groupnet.
        /// </summary>
        /// <value>Specifies the name of the Access Zone&#39;s groupnet.</value>
        [DataMember(Name="groupnet", EmitDefaultValue=true)]
        public string Groupnet { get; set; }

        /// <summary>
        /// Specifies the name of the Access Zone.
        /// </summary>
        /// <value>Specifies the name of the Access Zone.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SmbCredentials
        /// </summary>
        [DataMember(Name="smbCredentials", EmitDefaultValue=false)]
        public NasMountCredentialParams SmbCredentials { get; set; }

        /// <summary>
        /// Gets or Sets StaticNetworkPoolConfig
        /// </summary>
        [DataMember(Name="staticNetworkPoolConfig", EmitDefaultValue=false)]
        public NetworkPoolConfig StaticNetworkPoolConfig { get; set; }

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
            return this.Equals(input as ZoneConfig);
        }

        /// <summary>
        /// Returns true if ZoneConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneConfig input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SmbCredentials != null)
                    hashCode = hashCode * 59 + this.SmbCredentials.GetHashCode();
                if (this.StaticNetworkPoolConfig != null)
                    hashCode = hashCode * 59 + this.StaticNetworkPoolConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

