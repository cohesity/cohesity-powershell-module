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
    /// Specifies the parameters needed for an append hosts request.
    /// </summary>
    [DataContract]
    public partial class AppendHostsParameters :  IEquatable<AppendHostsParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppendHostsParameters" /> class.
        /// </summary>
        /// <param name="hosts">Specifies the list of host entries to be added to the Cluster&#39;s etc/hosts file..</param>
        public AppendHostsParameters(List<HostEntry> hosts = default(List<HostEntry>))
        {
            this.Hosts = hosts;
            this.Hosts = hosts;
        }
        
        /// <summary>
        /// Specifies the list of host entries to be added to the Cluster&#39;s etc/hosts file.
        /// </summary>
        /// <value>Specifies the list of host entries to be added to the Cluster&#39;s etc/hosts file.</value>
        [DataMember(Name="hosts", EmitDefaultValue=true)]
        public List<HostEntry> Hosts { get; set; }

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
            return this.Equals(input as AppendHostsParameters);
        }

        /// <summary>
        /// Returns true if AppendHostsParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of AppendHostsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppendHostsParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
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
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                return hashCode;
            }
        }

    }

}

