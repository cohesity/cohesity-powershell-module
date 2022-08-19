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
    /// Specifies information about a M365 Teams Channel.
    /// </summary>
    [DataContract]
    public partial class M365TeamsChannelInfo :  IEquatable<M365TeamsChannelInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M365TeamsChannelInfo" /> class.
        /// </summary>
        /// <param name="isPrivate">Specifies if this is a private channel..</param>
        /// <param name="name">Specifies the name of a M365 Teams channel..</param>
        public M365TeamsChannelInfo(bool? isPrivate = default(bool?), string name = default(string))
        {
            this.IsPrivate = isPrivate;
            this.Name = name;
            this.IsPrivate = isPrivate;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies if this is a private channel.
        /// </summary>
        /// <value>Specifies if this is a private channel.</value>
        [DataMember(Name="isPrivate", EmitDefaultValue=true)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Specifies the name of a M365 Teams channel.
        /// </summary>
        /// <value>Specifies the name of a M365 Teams channel.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as M365TeamsChannelInfo);
        }

        /// <summary>
        /// Returns true if M365TeamsChannelInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of M365TeamsChannelInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(M365TeamsChannelInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsPrivate == input.IsPrivate ||
                    (this.IsPrivate != null &&
                    this.IsPrivate.Equals(input.IsPrivate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.IsPrivate != null)
                    hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

