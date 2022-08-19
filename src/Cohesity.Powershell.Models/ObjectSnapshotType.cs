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
    /// ObjectSnapshotType
    /// </summary>
    [DataContract]
    public partial class ObjectSnapshotType :  IEquatable<ObjectSnapshotType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectSnapshotType" /> class.
        /// </summary>
        /// <param name="msg">This captures any additional message about the snapshot itself, e.g. if the app-consistent snapshot had to fallback to crash consistent, this will contain that..</param>
        /// <param name="type">type.</param>
        public ObjectSnapshotType(string msg = default(string), int? type = default(int?))
        {
            this.Msg = msg;
            this.Type = type;
            this.Msg = msg;
            this.Type = type;
        }
        
        /// <summary>
        /// This captures any additional message about the snapshot itself, e.g. if the app-consistent snapshot had to fallback to crash consistent, this will contain that.
        /// </summary>
        /// <value>This captures any additional message about the snapshot itself, e.g. if the app-consistent snapshot had to fallback to crash consistent, this will contain that.</value>
        [DataMember(Name="msg", EmitDefaultValue=true)]
        public string Msg { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as ObjectSnapshotType);
        }

        /// <summary>
        /// Returns true if ObjectSnapshotType instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectSnapshotType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectSnapshotType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Msg != null)
                    hashCode = hashCode * 59 + this.Msg.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

