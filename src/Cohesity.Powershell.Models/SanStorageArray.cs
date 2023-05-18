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
    /// Specifies a SAN Storage Array.
    /// </summary>
    [DataContract]
    public partial class SanStorageArray :  IEquatable<SanStorageArray>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SanStorageArray" /> class.
        /// </summary>
        /// <param name="id">Specifies a unique id of a SAN Storage Array. The id is unique across Cohesity Clusters..</param>
        /// <param name="ports">Specifies the SAN ports of the SAN Storage Array..</param>
        /// <param name="revision">Specifies the revision of the SAN Storage Array..</param>
        /// <param name="version">Specifies the version of the SAN Storage Array..</param>
        public SanStorageArray(string id = default(string), List<IscsiSanPort> ports = default(List<IscsiSanPort>), string revision = default(string), string version = default(string))
        {
            this.Id = id;
            this.Ports = ports;
            this.Revision = revision;
            this.Version = version;
            this.Id = id;
            this.Ports = ports;
            this.Revision = revision;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies a unique id of a SAN Storage Array. The id is unique across Cohesity Clusters.
        /// </summary>
        /// <value>Specifies a unique id of a SAN Storage Array. The id is unique across Cohesity Clusters.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the SAN ports of the SAN Storage Array.
        /// </summary>
        /// <value>Specifies the SAN ports of the SAN Storage Array.</value>
        [DataMember(Name="ports", EmitDefaultValue=true)]
        public List<IscsiSanPort> Ports { get; set; }

        /// <summary>
        /// Specifies the revision of the SAN Storage Array.
        /// </summary>
        /// <value>Specifies the revision of the SAN Storage Array.</value>
        [DataMember(Name="revision", EmitDefaultValue=true)]
        public string Revision { get; set; }

        /// <summary>
        /// Specifies the version of the SAN Storage Array.
        /// </summary>
        /// <value>Specifies the version of the SAN Storage Array.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as SanStorageArray);
        }

        /// <summary>
        /// Returns true if SanStorageArray instances are equal
        /// </summary>
        /// <param name="input">Instance of SanStorageArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SanStorageArray input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

