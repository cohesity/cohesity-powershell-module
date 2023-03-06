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
    /// Specifies the parameters needed for an edit hosts request.
    /// </summary>
    [DataContract]
    public partial class EditHostsParameters :  IEquatable<EditHostsParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHostsParameters" /> class.
        /// </summary>
        /// <param name="hosts">Specifies the list of host entries to be edited. Each IP address listed in the list of host entries will have its corresponding domain names in the /etc/hosts file replaced with the domain names specified here..</param>
        public EditHostsParameters(List<HostEntry> hosts = default(List<HostEntry>))
        {
            this.Hosts = hosts;
            this.Hosts = hosts;
        }
        
        /// <summary>
        /// Specifies the list of host entries to be edited. Each IP address listed in the list of host entries will have its corresponding domain names in the /etc/hosts file replaced with the domain names specified here.
        /// </summary>
        /// <value>Specifies the list of host entries to be edited. Each IP address listed in the list of host entries will have its corresponding domain names in the /etc/hosts file replaced with the domain names specified here.</value>
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
            return this.Equals(input as EditHostsParameters);
        }

        /// <summary>
        /// Returns true if EditHostsParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of EditHostsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EditHostsParameters input)
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

