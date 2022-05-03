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
    /// NfsSquash
    /// </summary>
    [DataContract]
    public partial class NfsSquash :  IEquatable<NfsSquash>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfsSquash" /> class.
        /// </summary>
        /// <param name="gid">GID mapped for all clients..</param>
        /// <param name="uid">UID mapped for all clients..</param>
        public NfsSquash(int? gid = default(int?), int? uid = default(int?))
        {
            this.Gid = gid;
            this.Uid = uid;
        }
        
        /// <summary>
        /// GID mapped for all clients.
        /// </summary>
        /// <value>GID mapped for all clients.</value>
        [DataMember(Name="gid", EmitDefaultValue=false)]
        public int? Gid { get; set; }

        /// <summary>
        /// UID mapped for all clients.
        /// </summary>
        /// <value>UID mapped for all clients.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public int? Uid { get; set; }

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
            return this.Equals(input as NfsSquash);
        }

        /// <summary>
        /// Returns true if NfsSquash instances are equal
        /// </summary>
        /// <param name="input">Instance of NfsSquash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsSquash input)
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

