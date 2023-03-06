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
    /// Protobuf that describes the Common access control list (ACL) permissions for a swift container. TODO (avinash_aita): Verify the &#39;.rlistings&#39; write ACL behavior. If necessary, remove persisting &#39;write_rlistings&#39; field and fail such requests.
    /// </summary>
    [DataContract]
    public partial class CommonACLProto :  IEquatable<CommonACLProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonACLProto" /> class.
        /// </summary>
        /// <param name="readGrantees">readGrantees.</param>
        /// <param name="writeRlistings">Write permissions granted to grantees..</param>
        public CommonACLProto(CommonACLProtoGrantees readGrantees = default(CommonACLProtoGrantees), bool? writeRlistings = default(bool?))
        {
            this.WriteRlistings = writeRlistings;
            this.ReadGrantees = readGrantees;
            this.WriteRlistings = writeRlistings;
        }
        
        /// <summary>
        /// Gets or Sets ReadGrantees
        /// </summary>
        [DataMember(Name="readGrantees", EmitDefaultValue=false)]
        public CommonACLProtoGrantees ReadGrantees { get; set; }

        /// <summary>
        /// Write permissions granted to grantees.
        /// </summary>
        /// <value>Write permissions granted to grantees.</value>
        [DataMember(Name="writeRlistings", EmitDefaultValue=true)]
        public bool? WriteRlistings { get; set; }

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
            return this.Equals(input as CommonACLProto);
        }

        /// <summary>
        /// Returns true if CommonACLProto instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonACLProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonACLProto input)
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
                    this.WriteRlistings == input.WriteRlistings ||
                    (this.WriteRlistings != null &&
                    this.WriteRlistings.Equals(input.WriteRlistings))
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
                if (this.WriteRlistings != null)
                    hashCode = hashCode * 59 + this.WriteRlistings.GetHashCode();
                return hashCode;
            }
        }

    }

}

