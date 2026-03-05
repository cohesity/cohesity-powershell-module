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
    /// Specifies primary server configuration
    /// </summary>
    [DataContract]
    public partial class NetbackupPrimaryServerConfig :  IEquatable<NetbackupPrimaryServerConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetbackupPrimaryServerConfig" /> class.
        /// </summary>
        /// <param name="fqdn">Specifies FQDN of primary server.</param>
        /// <param name="id">Specifies internally assigned id.</param>
        public NetbackupPrimaryServerConfig(string fqdn = default(string), long? id = default(long?))
        {
            this.Fqdn = fqdn;
            this.Id = id;
            this.Fqdn = fqdn;
            this.Id = id;
        }
        
        /// <summary>
        /// Specifies FQDN of primary server
        /// </summary>
        /// <value>Specifies FQDN of primary server</value>
        [DataMember(Name="fqdn", EmitDefaultValue=true)]
        public string Fqdn { get; set; }

        /// <summary>
        /// Specifies internally assigned id
        /// </summary>
        /// <value>Specifies internally assigned id</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

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
            return this.Equals(input as NetbackupPrimaryServerConfig);
        }

        /// <summary>
        /// Returns true if NetbackupPrimaryServerConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of NetbackupPrimaryServerConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetbackupPrimaryServerConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fqdn == input.Fqdn ||
                    (this.Fqdn != null &&
                    this.Fqdn.Equals(input.Fqdn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Fqdn != null)
                    hashCode = hashCode * 59 + this.Fqdn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

    }

}

