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
    /// This model also specifies the previous ids for a given entity.\&quot;
    /// </summary>
    [DataContract]
    public partial class StringEntityIds :  IEquatable<StringEntityIds>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringEntityIds" /> class.
        /// </summary>
        /// <param name="latestId">latestId.</param>
        /// <param name="latestSourceGeneratedIds">Specifies the latest source-generated ID for an entity. It provides the most current identifier assigned by the primary source system..</param>
        /// <param name="previousIds">Specifies all the StringIds previously assigned to this entity. Note that it doesn&#39;t contain the latest id..</param>
        /// <param name="previousSourceGeneratedIds">Specifies a list of previously assigned source-generated IDs for an entity. It helps in tracking the historical identifiers that were assigned by the primary source system. This can be useful for audit trails, debugging, or migration purposes..</param>
        public StringEntityIds(VersionInfo latestId = default(VersionInfo), List<EntityIdentifiers> latestSourceGeneratedIds = default(List<EntityIdentifiers>), List<VersionInfo> previousIds = default(List<VersionInfo>), List<EntityIdentifiers> previousSourceGeneratedIds = default(List<EntityIdentifiers>))
        {
            this.LatestSourceGeneratedIds = latestSourceGeneratedIds;
            this.PreviousIds = previousIds;
            this.PreviousSourceGeneratedIds = previousSourceGeneratedIds;
            this.LatestId = latestId;
            this.LatestSourceGeneratedIds = latestSourceGeneratedIds;
            this.PreviousIds = previousIds;
            this.PreviousSourceGeneratedIds = previousSourceGeneratedIds;
        }
        
        /// <summary>
        /// Gets or Sets LatestId
        /// </summary>
        [DataMember(Name="latestId", EmitDefaultValue=false)]
        public VersionInfo LatestId { get; set; }

        /// <summary>
        /// Specifies the latest source-generated ID for an entity. It provides the most current identifier assigned by the primary source system.
        /// </summary>
        /// <value>Specifies the latest source-generated ID for an entity. It provides the most current identifier assigned by the primary source system.</value>
        [DataMember(Name="latestSourceGeneratedIds", EmitDefaultValue=true)]
        public List<EntityIdentifiers> LatestSourceGeneratedIds { get; set; }

        /// <summary>
        /// Specifies all the StringIds previously assigned to this entity. Note that it doesn&#39;t contain the latest id.
        /// </summary>
        /// <value>Specifies all the StringIds previously assigned to this entity. Note that it doesn&#39;t contain the latest id.</value>
        [DataMember(Name="previousIds", EmitDefaultValue=true)]
        public List<VersionInfo> PreviousIds { get; set; }

        /// <summary>
        /// Specifies a list of previously assigned source-generated IDs for an entity. It helps in tracking the historical identifiers that were assigned by the primary source system. This can be useful for audit trails, debugging, or migration purposes.
        /// </summary>
        /// <value>Specifies a list of previously assigned source-generated IDs for an entity. It helps in tracking the historical identifiers that were assigned by the primary source system. This can be useful for audit trails, debugging, or migration purposes.</value>
        [DataMember(Name="previousSourceGeneratedIds", EmitDefaultValue=true)]
        public List<EntityIdentifiers> PreviousSourceGeneratedIds { get; set; }

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
            return this.Equals(input as StringEntityIds);
        }

        /// <summary>
        /// Returns true if StringEntityIds instances are equal
        /// </summary>
        /// <param name="input">Instance of StringEntityIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringEntityIds input)
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
                    this.LatestSourceGeneratedIds != null &&
                    input.LatestSourceGeneratedIds != null &&
                    this.LatestSourceGeneratedIds.SequenceEqual(input.LatestSourceGeneratedIds)
                ) && 
                (
                    this.PreviousIds == input.PreviousIds ||
                    this.PreviousIds != null &&
                    input.PreviousIds != null &&
                    this.PreviousIds.SequenceEqual(input.PreviousIds)
                ) && 
                (
                    this.PreviousSourceGeneratedIds == input.PreviousSourceGeneratedIds ||
                    this.PreviousSourceGeneratedIds != null &&
                    input.PreviousSourceGeneratedIds != null &&
                    this.PreviousSourceGeneratedIds.SequenceEqual(input.PreviousSourceGeneratedIds)
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

