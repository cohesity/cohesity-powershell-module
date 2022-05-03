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
    /// Protobuf that describes the Keystone access control list (ACL) permissions for a swift container. Note: Keystone ACL is applicable for only keystone authenticated users.
    /// </summary>
    [DataContract]
    public partial class KeystoneACLProto :  IEquatable<KeystoneACLProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeystoneACLProto" /> class.
        /// </summary>
        /// <param name="readGrantees">readGrantees.</param>
        /// <param name="writeGrantees">writeGrantees.</param>
        public KeystoneACLProto(KeystoneACLProtoGrantees readGrantees = default(KeystoneACLProtoGrantees), KeystoneACLProtoGrantees writeGrantees = default(KeystoneACLProtoGrantees))
        {
            this.ReadGrantees = readGrantees;
            this.WriteGrantees = writeGrantees;
        }
        
        /// <summary>
        /// Gets or Sets ReadGrantees
        /// </summary>
        [DataMember(Name="readGrantees", EmitDefaultValue=false)]
        public KeystoneACLProtoGrantees ReadGrantees { get; set; }

        /// <summary>
        /// Gets or Sets WriteGrantees
        /// </summary>
        [DataMember(Name="writeGrantees", EmitDefaultValue=false)]
        public KeystoneACLProtoGrantees WriteGrantees { get; set; }

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
            return this.Equals(input as KeystoneACLProto);
        }

        /// <summary>
        /// Returns true if KeystoneACLProto instances are equal
        /// </summary>
        /// <param name="input">Instance of KeystoneACLProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeystoneACLProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReadGrantees == input.ReadGrantees ||
                    (this.ReadGrantees != null &&
                    this.ReadGrantees.Equals(input.ReadGrantees))
                ) && 
                (
                    this.WriteGrantees == input.WriteGrantees ||
                    (this.WriteGrantees != null &&
                    this.WriteGrantees.Equals(input.WriteGrantees))
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
                if (this.ReadGrantees != null)
                    hashCode = hashCode * 59 + this.ReadGrantees.GetHashCode();
                if (this.WriteGrantees != null)
                    hashCode = hashCode * 59 + this.WriteGrantees.GetHashCode();
                return hashCode;
            }
        }

    }

}

