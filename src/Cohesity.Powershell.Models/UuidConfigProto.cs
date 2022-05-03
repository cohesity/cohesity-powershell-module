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
    /// UuidConfigProto
    /// </summary>
    [DataContract]
    public partial class UuidConfigProto :  IEquatable<UuidConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UuidConfigProto" /> class.
        /// </summary>
        /// <param name="preserveUuid">preserveUuid.</param>
        public UuidConfigProto(bool? preserveUuid = default(bool?))
        {
            this.PreserveUuid = preserveUuid;
        }
        
        /// <summary>
        /// Gets or Sets PreserveUuid
        /// </summary>
        [DataMember(Name="preserveUuid", EmitDefaultValue=false)]
        public bool? PreserveUuid { get; set; }

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
            return this.Equals(input as UuidConfigProto);
        }

        /// <summary>
        /// Returns true if UuidConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of UuidConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UuidConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreserveUuid == input.PreserveUuid ||
                    (this.PreserveUuid != null &&
                    this.PreserveUuid.Equals(input.PreserveUuid))
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
                if (this.PreserveUuid != null)
                    hashCode = hashCode * 59 + this.PreserveUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

