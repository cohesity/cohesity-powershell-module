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
    /// OwnerInfo
    /// </summary>
    [DataContract]
    public partial class OwnerInfo :  IEquatable<OwnerInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerInfo" /> class.
        /// </summary>
        /// <param name="userId">Unique identifier of the owner..</param>
        public OwnerInfo(string userId = default(string))
        {
            this.UserId = userId;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Unique identifier of the owner.
        /// </summary>
        /// <value>Unique identifier of the owner.</value>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public string UserId { get; set; }

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
            return this.Equals(input as OwnerInfo);
        }

        /// <summary>
        /// Returns true if OwnerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OwnerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}

