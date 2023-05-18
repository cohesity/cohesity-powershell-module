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
    /// Specifies information about access zone in an Isilon Cluster.
    /// </summary>
    [DataContract]
    public partial class IsilonAccessZone :  IEquatable<IsilonAccessZone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonAccessZone" /> class.
        /// </summary>
        /// <param name="groupnet">Specifies the groupnet name of the Isilon Access Zone..</param>
        /// <param name="id">Specifies the id of the access zone..</param>
        /// <param name="name">Specifies the name of the access zone..</param>
        /// <param name="networkPools">Specifies the network pools associated with the Isilon Access Zone..</param>
        /// <param name="path">Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;..</param>
        public IsilonAccessZone(string groupnet = default(string), long? id = default(long?), string name = default(string), List<NetworkPool> networkPools = default(List<NetworkPool>), string path = default(string))
        {
            this.Groupnet = groupnet;
            this.Id = id;
            this.Name = name;
            this.NetworkPools = networkPools;
            this.Path = path;
            this.Groupnet = groupnet;
            this.Id = id;
            this.Name = name;
            this.NetworkPools = networkPools;
            this.Path = path;
        }
        
        /// <summary>
        /// Specifies the groupnet name of the Isilon Access Zone.
        /// </summary>
        /// <value>Specifies the groupnet name of the Isilon Access Zone.</value>
        [DataMember(Name="groupnet", EmitDefaultValue=true)]
        public string Groupnet { get; set; }

        /// <summary>
        /// Specifies the id of the access zone.
        /// </summary>
        /// <value>Specifies the id of the access zone.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the access zone.
        /// </summary>
        /// <value>Specifies the name of the access zone.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the network pools associated with the Isilon Access Zone.
        /// </summary>
        /// <value>Specifies the network pools associated with the Isilon Access Zone.</value>
        [DataMember(Name="networkPools", EmitDefaultValue=true)]
        public List<NetworkPool> NetworkPools { get; set; }

        /// <summary>
        /// Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;.
        /// </summary>
        /// <value>Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

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
            return this.Equals(input as IsilonAccessZone);
        }

        /// <summary>
        /// Returns true if IsilonAccessZone instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonAccessZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonAccessZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Groupnet == input.Groupnet ||
                    (this.Groupnet != null &&
                    this.Groupnet.Equals(input.Groupnet))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkPools == input.NetworkPools ||
                    this.NetworkPools != null &&
                    input.NetworkPools != null &&
                    this.NetworkPools.SequenceEqual(input.NetworkPools)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Groupnet != null)
                    hashCode = hashCode * 59 + this.Groupnet.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkPools != null)
                    hashCode = hashCode * 59 + this.NetworkPools.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}

