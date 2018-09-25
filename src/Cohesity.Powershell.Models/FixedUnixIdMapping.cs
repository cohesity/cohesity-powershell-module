// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the fields when mapping type is set to &#39;kFixed&#39;. It maps all Active Directory users of a domain to a fixed Unix uid, and gid.
    /// </summary>
    [DataContract]
    public partial class FixedUnixIdMapping :  IEquatable<FixedUnixIdMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedUnixIdMapping" /> class.
        /// </summary>
        /// <param name="gid">Specifies the fixed Unix GID, when mapping type is set to kFixed..</param>
        /// <param name="uid">Specifies the fixed Unix UID, when mapping type is set to kFixed..</param>
        public FixedUnixIdMapping(long? gid = default(long?), long? uid = default(long?))
        {
            this.Gid = gid;
            this.Uid = uid;
        }
        
        /// <summary>
        /// Specifies the fixed Unix GID, when mapping type is set to kFixed.
        /// </summary>
        /// <value>Specifies the fixed Unix GID, when mapping type is set to kFixed.</value>
        [DataMember(Name="gid", EmitDefaultValue=false)]
        public long? Gid { get; set; }

        /// <summary>
        /// Specifies the fixed Unix UID, when mapping type is set to kFixed.
        /// </summary>
        /// <value>Specifies the fixed Unix UID, when mapping type is set to kFixed.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as FixedUnixIdMapping);
        }

        /// <summary>
        /// Returns true if FixedUnixIdMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedUnixIdMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedUnixIdMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
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
                if (this.Gid != null)
                    hashCode = hashCode * 59 + this.Gid.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

