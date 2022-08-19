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
    /// Interface
    /// </summary>
    [DataContract]
    public partial class Interface :  IEquatable<Interface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interface" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="name">name.</param>
        /// <param name="networkParams">networkParams.</param>
        public Interface(string message = default(string), string name = default(string), NetworkParams networkParams = default(NetworkParams))
        {
            this.Message = message;
            this.Name = name;
            this.Message = message;
            this.Name = name;
            this.NetworkParams = networkParams;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NetworkParams
        /// </summary>
        [DataMember(Name="networkParams", EmitDefaultValue=false)]
        public NetworkParams NetworkParams { get; set; }

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
            return this.Equals(input as Interface);
        }

        /// <summary>
        /// Returns true if Interface instances are equal
        /// </summary>
        /// <param name="input">Instance of Interface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Interface input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkParams == input.NetworkParams ||
                    (this.NetworkParams != null &&
                    this.NetworkParams.Equals(input.NetworkParams))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkParams != null)
                    hashCode = hashCode * 59 + this.NetworkParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

