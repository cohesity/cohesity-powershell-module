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
    /// Specifies an Object containing information about a registered mongodb physical source.
    /// </summary>
    [DataContract]
    public partial class MongoDBPhysicalParams :  IEquatable<MongoDBPhysicalParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBPhysicalParams" /> class.
        /// </summary>
        /// <param name="hostname">Specifies the hostname of this MongoDB OPs manager..</param>
        /// <param name="isSSlRequired">Specifies if connection to MongoDB has to be over SSL..</param>
        /// <param name="port">Specifies the port of this MongoDB OPs manager..</param>
        public MongoDBPhysicalParams(string hostname = default(string), bool? isSSlRequired = default(bool?), int? port = default(int?))
        {
            this.Hostname = hostname;
            this.IsSSlRequired = isSSlRequired;
            this.Port = port;
            this.Hostname = hostname;
            this.IsSSlRequired = isSSlRequired;
            this.Port = port;
        }
        
        /// <summary>
        /// Specifies the hostname of this MongoDB OPs manager.
        /// </summary>
        /// <value>Specifies the hostname of this MongoDB OPs manager.</value>
        [DataMember(Name="hostname", EmitDefaultValue=true)]
        public string Hostname { get; set; }

        /// <summary>
        /// Specifies if connection to MongoDB has to be over SSL.
        /// </summary>
        /// <value>Specifies if connection to MongoDB has to be over SSL.</value>
        [DataMember(Name="isSSlRequired", EmitDefaultValue=true)]
        public bool? IsSSlRequired { get; set; }

        /// <summary>
        /// Specifies the port of this MongoDB OPs manager.
        /// </summary>
        /// <value>Specifies the port of this MongoDB OPs manager.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; set; }

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
            return this.Equals(input as MongoDBPhysicalParams);
        }

        /// <summary>
        /// Returns true if MongoDBPhysicalParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBPhysicalParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBPhysicalParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.IsSSlRequired == input.IsSSlRequired ||
                    (this.IsSSlRequired != null &&
                    this.IsSSlRequired.Equals(input.IsSSlRequired))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.IsSSlRequired != null)
                    hashCode = hashCode * 59 + this.IsSSlRequired.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }

    }

}

