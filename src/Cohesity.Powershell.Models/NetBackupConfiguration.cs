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
    /// Specifies the parameters the user wants to use when configuring NetBackup for the new Cluster.
    /// </summary>
    [DataContract]
    public partial class NetBackupConfiguration :  IEquatable<NetBackupConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetBackupConfiguration" /> class.
        /// </summary>
        /// <param name="nbContainerSubnetIp">Specifies the NetBackup container subnet IP..</param>
        /// <param name="nbContainerSubnetMask">Specifies the NetBackup container subnet mask..</param>
        /// <param name="nbMediaServerFqdn">Specifies the NetBackup media server FQDNs..</param>
        /// <param name="nbMediaServerVips">Specifies the NetBackup media server VIPs..</param>
        /// <param name="nbPrimaryServerApiKey">Specifies the NetBackup primary server API key..</param>
        /// <param name="nbPrimaryServerFqdn">Specifies the NetBackup primary server FQDN..</param>
        public NetBackupConfiguration(string nbContainerSubnetIp = default(string), string nbContainerSubnetMask = default(string), List<string> nbMediaServerFqdn = default(List<string>), List<string> nbMediaServerVips = default(List<string>), string nbPrimaryServerApiKey = default(string), string nbPrimaryServerFqdn = default(string))
        {
            this.NbContainerSubnetIp = nbContainerSubnetIp;
            this.NbContainerSubnetMask = nbContainerSubnetMask;
            this.NbMediaServerFqdn = nbMediaServerFqdn;
            this.NbMediaServerVips = nbMediaServerVips;
            this.NbPrimaryServerApiKey = nbPrimaryServerApiKey;
            this.NbPrimaryServerFqdn = nbPrimaryServerFqdn;
            this.NbContainerSubnetIp = nbContainerSubnetIp;
            this.NbContainerSubnetMask = nbContainerSubnetMask;
            this.NbMediaServerFqdn = nbMediaServerFqdn;
            this.NbMediaServerVips = nbMediaServerVips;
            this.NbPrimaryServerApiKey = nbPrimaryServerApiKey;
            this.NbPrimaryServerFqdn = nbPrimaryServerFqdn;
        }
        
        /// <summary>
        /// Specifies the NetBackup container subnet IP.
        /// </summary>
        /// <value>Specifies the NetBackup container subnet IP.</value>
        [DataMember(Name="nbContainerSubnetIp", EmitDefaultValue=true)]
        public string NbContainerSubnetIp { get; set; }

        /// <summary>
        /// Specifies the NetBackup container subnet mask.
        /// </summary>
        /// <value>Specifies the NetBackup container subnet mask.</value>
        [DataMember(Name="nbContainerSubnetMask", EmitDefaultValue=true)]
        public string NbContainerSubnetMask { get; set; }

        /// <summary>
        /// Specifies the NetBackup media server FQDNs.
        /// </summary>
        /// <value>Specifies the NetBackup media server FQDNs.</value>
        [DataMember(Name="nbMediaServerFqdn", EmitDefaultValue=true)]
        public List<string> NbMediaServerFqdn { get; set; }

        /// <summary>
        /// Specifies the NetBackup media server VIPs.
        /// </summary>
        /// <value>Specifies the NetBackup media server VIPs.</value>
        [DataMember(Name="nbMediaServerVips", EmitDefaultValue=true)]
        public List<string> NbMediaServerVips { get; set; }

        /// <summary>
        /// Specifies the NetBackup primary server API key.
        /// </summary>
        /// <value>Specifies the NetBackup primary server API key.</value>
        [DataMember(Name="nbPrimaryServerApiKey", EmitDefaultValue=true)]
        public string NbPrimaryServerApiKey { get; set; }

        /// <summary>
        /// Specifies the NetBackup primary server FQDN.
        /// </summary>
        /// <value>Specifies the NetBackup primary server FQDN.</value>
        [DataMember(Name="nbPrimaryServerFqdn", EmitDefaultValue=true)]
        public string NbPrimaryServerFqdn { get; set; }

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
            return this.Equals(input as NetBackupConfiguration);
        }

        /// <summary>
        /// Returns true if NetBackupConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of NetBackupConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetBackupConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NbContainerSubnetIp == input.NbContainerSubnetIp ||
                    (this.NbContainerSubnetIp != null &&
                    this.NbContainerSubnetIp.Equals(input.NbContainerSubnetIp))
                ) && 
                (
                    this.NbContainerSubnetMask == input.NbContainerSubnetMask ||
                    (this.NbContainerSubnetMask != null &&
                    this.NbContainerSubnetMask.Equals(input.NbContainerSubnetMask))
                ) && 
                (
                    this.NbMediaServerFqdn == input.NbMediaServerFqdn ||
                    this.NbMediaServerFqdn != null &&
                    input.NbMediaServerFqdn != null &&
                    this.NbMediaServerFqdn.SequenceEqual(input.NbMediaServerFqdn)
                ) && 
                (
                    this.NbMediaServerVips == input.NbMediaServerVips ||
                    this.NbMediaServerVips != null &&
                    input.NbMediaServerVips != null &&
                    this.NbMediaServerVips.SequenceEqual(input.NbMediaServerVips)
                ) && 
                (
                    this.NbPrimaryServerApiKey == input.NbPrimaryServerApiKey ||
                    (this.NbPrimaryServerApiKey != null &&
                    this.NbPrimaryServerApiKey.Equals(input.NbPrimaryServerApiKey))
                ) && 
                (
                    this.NbPrimaryServerFqdn == input.NbPrimaryServerFqdn ||
                    (this.NbPrimaryServerFqdn != null &&
                    this.NbPrimaryServerFqdn.Equals(input.NbPrimaryServerFqdn))
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
                if (this.NbContainerSubnetIp != null)
                    hashCode = hashCode * 59 + this.NbContainerSubnetIp.GetHashCode();
                if (this.NbContainerSubnetMask != null)
                    hashCode = hashCode * 59 + this.NbContainerSubnetMask.GetHashCode();
                if (this.NbMediaServerFqdn != null)
                    hashCode = hashCode * 59 + this.NbMediaServerFqdn.GetHashCode();
                if (this.NbMediaServerVips != null)
                    hashCode = hashCode * 59 + this.NbMediaServerVips.GetHashCode();
                if (this.NbPrimaryServerApiKey != null)
                    hashCode = hashCode * 59 + this.NbPrimaryServerApiKey.GetHashCode();
                if (this.NbPrimaryServerFqdn != null)
                    hashCode = hashCode * 59 + this.NbPrimaryServerFqdn.GetHashCode();
                return hashCode;
            }
        }

    }

}

