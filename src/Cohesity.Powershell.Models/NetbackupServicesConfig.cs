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
    /// Specifies configuration of NetBackup services
    /// </summary>
    [DataContract]
    public partial class NetbackupServicesConfig :  IEquatable<NetbackupServicesConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetbackupServicesConfig" /> class.
        /// </summary>
        /// <param name="primaryServers">Specifies config of NetBackup primary servers.</param>
        public NetbackupServicesConfig(List<NetbackupPrimaryServerConfig> primaryServers = default(List<NetbackupPrimaryServerConfig>))
        {
            this.PrimaryServers = primaryServers;
            this.PrimaryServers = primaryServers;
        }
        
        /// <summary>
        /// Specifies config of NetBackup primary servers
        /// </summary>
        /// <value>Specifies config of NetBackup primary servers</value>
        [DataMember(Name="primaryServers", EmitDefaultValue=true)]
        public List<NetbackupPrimaryServerConfig> PrimaryServers { get; set; }

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
            return this.Equals(input as NetbackupServicesConfig);
        }

        /// <summary>
        /// Returns true if NetbackupServicesConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of NetbackupServicesConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetbackupServicesConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryServers == input.PrimaryServers ||
                    this.PrimaryServers != null &&
                    input.PrimaryServers != null &&
                    this.PrimaryServers.SequenceEqual(input.PrimaryServers)
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
                if (this.PrimaryServers != null)
                    hashCode = hashCode * 59 + this.PrimaryServers.GetHashCode();
                return hashCode;
            }
        }

    }

}

