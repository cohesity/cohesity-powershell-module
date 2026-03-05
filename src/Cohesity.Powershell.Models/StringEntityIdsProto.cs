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
    /// StringEntityIdsProto
    /// </summary>
    [DataContract]
    public partial class StringEntityIdsProto :  IEquatable<StringEntityIdsProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringEntityIdsProto" /> class.
        /// </summary>
        /// <param name="latestId">latestId.</param>
        /// <param name="latestSourceGeneratedIds">latestSourceGeneratedIds.</param>
        /// <param name="previousIds">Repeated field containing all the StringIds previously assigned to this entity. Note that it doesn&#39;t contain the latest id. THIS IS COMMENTED AS ONLY ONE GUID STRING ID IS SUPPORTED CURRENTLY. THIS SHOULD BE USED WHEN WE MOVE TO HASH BASED IDS..</param>
        /// <param name="previousSourceGeneratedIds">previousSourceGeneratedIds.</param>
        public StringEntityIdsProto(StringEntityIdsProtoStringId latestId = default(StringEntityIdsProtoStringId), StringEntityIdsProtoSourceGeneratedStringIds latestSourceGeneratedIds = default(StringEntityIdsProtoSourceGeneratedStringIds), List<StringEntityIdsProtoStringId> previousIds = default(List<StringEntityIdsProtoStringId>), StringEntityIdsProtoSourceGeneratedStringIds previousSourceGeneratedIds = default(StringEntityIdsProtoSourceGeneratedStringIds))
        {
            this.PreviousIds = previousIds;
            this.LatestId = latestId;
            this.LatestSourceGeneratedIds = latestSourceGeneratedIds;
            this.PreviousIds = previousIds;
            this.PreviousSourceGeneratedIds = previousSourceGeneratedIds;
        }
        
        /// <summary>
        /// Gets or Sets LatestId
        /// </summary>
        [DataMember(Name="latestId", EmitDefaultValue=false)]
        public StringEntityIdsProtoStringId LatestId { get; set; }

        /// <summary>
        /// Gets or Sets LatestSourceGeneratedIds
        /// </summary>
        [DataMember(Name="latestSourceGeneratedIds", EmitDefaultValue=false)]
        public StringEntityIdsProtoSourceGeneratedStringIds LatestSourceGeneratedIds { get; set; }

        /// <summary>
        /// Repeated field containing all the StringIds previously assigned to this entity. Note that it doesn&#39;t contain the latest id. THIS IS COMMENTED AS ONLY ONE GUID STRING ID IS SUPPORTED CURRENTLY. THIS SHOULD BE USED WHEN WE MOVE TO HASH BASED IDS.
        /// </summary>
        /// <value>Repeated field containing all the StringIds previously assigned to this entity. Note that it doesn&#39;t contain the latest id. THIS IS COMMENTED AS ONLY ONE GUID STRING ID IS SUPPORTED CURRENTLY. THIS SHOULD BE USED WHEN WE MOVE TO HASH BASED IDS.</value>
        [DataMember(Name="previousIds", EmitDefaultValue=true)]
        public List<StringEntityIdsProtoStringId> PreviousIds { get; set; }

        /// <summary>
        /// Gets or Sets PreviousSourceGeneratedIds
        /// </summary>
        [DataMember(Name="previousSourceGeneratedIds", EmitDefaultValue=false)]
        public StringEntityIdsProtoSourceGeneratedStringIds PreviousSourceGeneratedIds { get; set; }

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
            return this.Equals(input as StringEntityIdsProto);
        }

        /// <summary>
        /// Returns true if StringEntityIdsProto instances are equal
        /// </summary>
        /// <param name="input">Instance of StringEntityIdsProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringEntityIdsProto input)
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
                    this.LatestSourceGeneratedIds == input.LatestSourceGeneratedIds ||
                    (this.LatestSourceGeneratedIds != null &&
                    this.LatestSourceGeneratedIds.Equals(input.LatestSourceGeneratedIds))
                ) && 
                (
                    this.PreviousIds == input.PreviousIds ||
                    this.PreviousIds != null &&
                    input.PreviousIds != null &&
                    this.PreviousIds.SequenceEqual(input.PreviousIds)
                ) && 
                (
                    this.PreviousSourceGeneratedIds == input.PreviousSourceGeneratedIds ||
                    (this.PreviousSourceGeneratedIds != null &&
                    this.PreviousSourceGeneratedIds.Equals(input.PreviousSourceGeneratedIds))
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
                if (this.LatestSourceGeneratedIds != null)
                    hashCode = hashCode * 59 + this.LatestSourceGeneratedIds.GetHashCode();
                if (this.PreviousIds != null)
                    hashCode = hashCode * 59 + this.PreviousIds.GetHashCode();
                if (this.PreviousSourceGeneratedIds != null)
                    hashCode = hashCode * 59 + this.PreviousSourceGeneratedIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

