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
    /// RestoreObjectCustomization
    /// </summary>
    [DataContract]
    public partial class RestoreObjectCustomization :  IEquatable<RestoreObjectCustomization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreObjectCustomization" /> class.
        /// </summary>
        /// <param name="entityId">Represents the Entity id of the object for which below customizations are populated..</param>
        /// <param name="networkConfig">networkConfig.</param>
        public RestoreObjectCustomization(long? entityId = default(long?), RestoredObjectNetworkConfigProto networkConfig = default(RestoredObjectNetworkConfigProto))
        {
            this.EntityId = entityId;
            this.EntityId = entityId;
            this.NetworkConfig = networkConfig;
        }
        
        /// <summary>
        /// Represents the Entity id of the object for which below customizations are populated.
        /// </summary>
        /// <value>Represents the Entity id of the object for which below customizations are populated.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Gets or Sets NetworkConfig
        /// </summary>
        [DataMember(Name="networkConfig", EmitDefaultValue=false)]
        public RestoredObjectNetworkConfigProto NetworkConfig { get; set; }

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
            return this.Equals(input as RestoreObjectCustomization);
        }

        /// <summary>
        /// Returns true if RestoreObjectCustomization instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreObjectCustomization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreObjectCustomization input)
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
                    this.NetworkConfig == input.NetworkConfig ||
                    (this.NetworkConfig != null &&
                    this.NetworkConfig.Equals(input.NetworkConfig))
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
                if (this.NetworkConfig != null)
                    hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

