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
    /// Response &lt;clientID-Locks&gt; map as received from view-keeper is converted into this structure. These Locks belong to one file-path.
    /// </summary>
    [DataContract]
    public partial class NlmLock :  IEquatable<NlmLock>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NlmLock" /> class.
        /// </summary>
        /// <param name="clientId">Specifies the client ID.</param>
        /// <param name="lockRanges">lockRanges.</param>
        public NlmLock(string clientId = default(string), List<LockRange> lockRanges = default(List<LockRange>))
        {
            this.ClientId = clientId;
            this.LockRanges = lockRanges;
            this.ClientId = clientId;
            this.LockRanges = lockRanges;
        }
        
        /// <summary>
        /// Specifies the client ID
        /// </summary>
        /// <value>Specifies the client ID</value>
        [DataMember(Name="clientId", EmitDefaultValue=true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets LockRanges
        /// </summary>
        [DataMember(Name="lockRanges", EmitDefaultValue=true)]
        public List<LockRange> LockRanges { get; set; }

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
            return this.Equals(input as NlmLock);
        }

        /// <summary>
        /// Returns true if NlmLock instances are equal
        /// </summary>
        /// <param name="input">Instance of NlmLock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NlmLock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.LockRanges == input.LockRanges ||
                    this.LockRanges != null &&
                    input.LockRanges != null &&
                    this.LockRanges.Equals(input.LockRanges)
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.LockRanges != null)
                    hashCode = hashCode * 59 + this.LockRanges.GetHashCode();
                return hashCode;
            }
        }

    }

}

