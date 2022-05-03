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
    /// NoncurrentVersionExpirationAction
    /// </summary>
    [DataContract]
    public partial class NoncurrentVersionExpirationAction :  IEquatable<NoncurrentVersionExpirationAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoncurrentVersionExpirationAction" /> class.
        /// </summary>
        /// <param name="noncurrentDays">Specifies the number of days an object is noncurrent before performing the associated action..</param>
        public NoncurrentVersionExpirationAction(long? noncurrentDays = default(long?))
        {
            this.NoncurrentDays = noncurrentDays;
        }
        
        /// <summary>
        /// Specifies the number of days an object is noncurrent before performing the associated action.
        /// </summary>
        /// <value>Specifies the number of days an object is noncurrent before performing the associated action.</value>
        [DataMember(Name="noncurrentDays", EmitDefaultValue=false)]
        public long? NoncurrentDays { get; set; }

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
            return this.Equals(input as NoncurrentVersionExpirationAction);
        }

        /// <summary>
        /// Returns true if NoncurrentVersionExpirationAction instances are equal
        /// </summary>
        /// <param name="input">Instance of NoncurrentVersionExpirationAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoncurrentVersionExpirationAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NoncurrentDays == input.NoncurrentDays ||
                    (this.NoncurrentDays != null &&
                    this.NoncurrentDays.Equals(input.NoncurrentDays))
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
                if (this.NoncurrentDays != null)
                    hashCode = hashCode * 59 + this.NoncurrentDays.GetHashCode();
                return hashCode;
            }
        }

    }

}

