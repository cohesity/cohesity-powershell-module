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
    /// ExperimentalAdapterEntityIdentifier
    /// </summary>
    [DataContract]
    public partial class ExperimentalAdapterEntityIdentifier :  IEquatable<ExperimentalAdapterEntityIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalAdapterEntityIdentifier" /> class.
        /// </summary>
        /// <param name="latestId">latestId.</param>
        /// <param name="previousIds">Slice containing all the entity hashes previously assigned to this entity by the adapter..</param>
        public ExperimentalAdapterEntityIdentifier(ExperimentalAdapterEntityId latestId = default(ExperimentalAdapterEntityId), List<ExperimentalAdapterEntityId> previousIds = default(List<ExperimentalAdapterEntityId>))
        {
            this.PreviousIds = previousIds;
            this.LatestId = latestId;
            this.PreviousIds = previousIds;
        }
        
        /// <summary>
        /// Gets or Sets LatestId
        /// </summary>
        [DataMember(Name="latestId", EmitDefaultValue=false)]
        public ExperimentalAdapterEntityId LatestId { get; set; }

        /// <summary>
        /// Slice containing all the entity hashes previously assigned to this entity by the adapter.
        /// </summary>
        /// <value>Slice containing all the entity hashes previously assigned to this entity by the adapter.</value>
        [DataMember(Name="previousIds", EmitDefaultValue=true)]
        public List<ExperimentalAdapterEntityId> PreviousIds { get; set; }

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
            return this.Equals(input as ExperimentalAdapterEntityIdentifier);
        }

        /// <summary>
        /// Returns true if ExperimentalAdapterEntityIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of ExperimentalAdapterEntityIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExperimentalAdapterEntityIdentifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LatestId == input.LatestId ||
                    (this.LatestId != null &&
                    this.LatestId.Equals(input.LatestId))
                ) && 
                (
                    this.PreviousIds == input.PreviousIds ||
                    this.PreviousIds != null &&
                    input.PreviousIds != null &&
                    this.PreviousIds.SequenceEqual(input.PreviousIds)
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
                if (this.LatestId != null)
                    hashCode = hashCode * 59 + this.LatestId.GetHashCode();
                if (this.PreviousIds != null)
                    hashCode = hashCode * 59 + this.PreviousIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

