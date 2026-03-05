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
    /// RestoreSanParams
    /// </summary>
    [DataContract]
    public partial class RestoreSanParams :  IEquatable<RestoreSanParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSanParams" /> class.
        /// </summary>
        /// <param name="storagePool">storagePool.</param>
        /// <param name="transportMode">transportMode.</param>
        /// <param name="useThinClone">If true, then use thin clone to restore storage array snapshots..</param>
        public RestoreSanParams(EntityProto storagePool = default(EntityProto), int? transportMode = default(int?), bool? useThinClone = default(bool?))
        {
            this.TransportMode = transportMode;
            this.UseThinClone = useThinClone;
            this.StoragePool = storagePool;
            this.TransportMode = transportMode;
            this.UseThinClone = useThinClone;
        }
        
        /// <summary>
        /// Gets or Sets StoragePool
        /// </summary>
        [DataMember(Name="storagePool", EmitDefaultValue=false)]
        public EntityProto StoragePool { get; set; }

        /// <summary>
        /// Gets or Sets TransportMode
        /// </summary>
        [DataMember(Name="transportMode", EmitDefaultValue=true)]
        public int? TransportMode { get; set; }

        /// <summary>
        /// If true, then use thin clone to restore storage array snapshots.
        /// </summary>
        /// <value>If true, then use thin clone to restore storage array snapshots.</value>
        [DataMember(Name="useThinClone", EmitDefaultValue=true)]
        public bool? UseThinClone { get; set; }

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
            return this.Equals(input as RestoreSanParams);
        }

        /// <summary>
        /// Returns true if RestoreSanParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreSanParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreSanParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoragePool == input.StoragePool ||
                    (this.StoragePool != null &&
                    this.StoragePool.Equals(input.StoragePool))
                ) && 
                (
                    this.TransportMode == input.TransportMode ||
                    (this.TransportMode != null &&
                    this.TransportMode.Equals(input.TransportMode))
                ) && 
                (
                    this.UseThinClone == input.UseThinClone ||
                    (this.UseThinClone != null &&
                    this.UseThinClone.Equals(input.UseThinClone))
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
                if (this.StoragePool != null)
                    hashCode = hashCode * 59 + this.StoragePool.GetHashCode();
                if (this.TransportMode != null)
                    hashCode = hashCode * 59 + this.TransportMode.GetHashCode();
                if (this.UseThinClone != null)
                    hashCode = hashCode * 59 + this.UseThinClone.GetHashCode();
                return hashCode;
            }
        }

    }

}

