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
    /// GroupMembershipInfo
    /// </summary>
    [DataContract]
    public partial class GroupMembershipInfo :  IEquatable<GroupMembershipInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMembershipInfo" /> class.
        /// </summary>
        /// <param name="entityId">Specifies the entity Id of the Group..</param>
        /// <param name="graphUuid">Specifies the Graph UUID of the Group..</param>
        public GroupMembershipInfo(long? entityId = default(long?), string graphUuid = default(string))
        {
            this.EntityId = entityId;
            this.GraphUuid = graphUuid;
            this.EntityId = entityId;
            this.GraphUuid = graphUuid;
        }
        
        /// <summary>
        /// Specifies the entity Id of the Group.
        /// </summary>
        /// <value>Specifies the entity Id of the Group.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies the Graph UUID of the Group.
        /// </summary>
        /// <value>Specifies the Graph UUID of the Group.</value>
        [DataMember(Name="graphUuid", EmitDefaultValue=true)]
        public string GraphUuid { get; set; }

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
            return this.Equals(input as GroupMembershipInfo);
        }

        /// <summary>
        /// Returns true if GroupMembershipInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMembershipInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMembershipInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.GraphUuid == input.GraphUuid ||
                    (this.GraphUuid != null &&
                    this.GraphUuid.Equals(input.GraphUuid))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.GraphUuid != null)
                    hashCode = hashCode * 59 + this.GraphUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

