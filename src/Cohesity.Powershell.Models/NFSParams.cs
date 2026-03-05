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
    /// NFSParams
    /// </summary>
    [DataContract]
    public partial class NFSParams :  IEquatable<NFSParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NFSParams" /> class.
        /// </summary>
        /// <param name="nfsMountOptions">Parameter for nfs mount options.</param>
        /// <param name="nfsProtocolType">Parameter for nfs protocol type.</param>
        /// <param name="nfsSecurityType">Parameter to indicate kerberos security type. This is valid only when nfs_protocol_type is 6(kNFs4_1).</param>
        public NFSParams(string nfsMountOptions = default(string), int? nfsProtocolType = default(int?), int? nfsSecurityType = default(int?))
        {
            this.NfsMountOptions = nfsMountOptions;
            this.NfsProtocolType = nfsProtocolType;
            this.NfsSecurityType = nfsSecurityType;
            this.NfsMountOptions = nfsMountOptions;
            this.NfsProtocolType = nfsProtocolType;
            this.NfsSecurityType = nfsSecurityType;
        }
        
        /// <summary>
        /// Parameter for nfs mount options
        /// </summary>
        /// <value>Parameter for nfs mount options</value>
        [DataMember(Name="nfsMountOptions", EmitDefaultValue=true)]
        public string NfsMountOptions { get; set; }

        /// <summary>
        /// Parameter for nfs protocol type
        /// </summary>
        /// <value>Parameter for nfs protocol type</value>
        [DataMember(Name="nfsProtocolType", EmitDefaultValue=true)]
        public int? NfsProtocolType { get; set; }

        /// <summary>
        /// Parameter to indicate kerberos security type. This is valid only when nfs_protocol_type is 6(kNFs4_1)
        /// </summary>
        /// <value>Parameter to indicate kerberos security type. This is valid only when nfs_protocol_type is 6(kNFs4_1)</value>
        [DataMember(Name="nfsSecurityType", EmitDefaultValue=true)]
        public int? NfsSecurityType { get; set; }

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
            return this.Equals(input as NFSParams);
        }

        /// <summary>
        /// Returns true if NFSParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NFSParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NFSParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NfsMountOptions == input.NfsMountOptions ||
                    (this.NfsMountOptions != null &&
                    this.NfsMountOptions.Equals(input.NfsMountOptions))
                ) && 
                (
                    this.NfsProtocolType == input.NfsProtocolType ||
                    (this.NfsProtocolType != null &&
                    this.NfsProtocolType.Equals(input.NfsProtocolType))
                ) && 
                (
                    this.NfsSecurityType == input.NfsSecurityType ||
                    (this.NfsSecurityType != null &&
                    this.NfsSecurityType.Equals(input.NfsSecurityType))
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
                if (this.NfsMountOptions != null)
                    hashCode = hashCode * 59 + this.NfsMountOptions.GetHashCode();
                if (this.NfsProtocolType != null)
                    hashCode = hashCode * 59 + this.NfsProtocolType.GetHashCode();
                if (this.NfsSecurityType != null)
                    hashCode = hashCode * 59 + this.NfsSecurityType.GetHashCode();
                return hashCode;
            }
        }

    }

}

