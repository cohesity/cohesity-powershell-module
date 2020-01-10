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
    /// StorageSnapshotProviderParams
    /// </summary>
    [DataContract]
    public partial class StorageSnapshotProviderParams :  IEquatable<StorageSnapshotProviderParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageSnapshotProviderParams" /> class.
        /// </summary>
        /// <param name="connectorParams">connectorParams.</param>
        /// <param name="entity">entity.</param>
        public StorageSnapshotProviderParams(ConnectorParams connectorParams = default(ConnectorParams), EntityProto entity = default(EntityProto))
        {
            this.ConnectorParams = connectorParams;
            this.Entity = entity;
        }
        
        /// <summary>
        /// Gets or Sets ConnectorParams
        /// </summary>
        [DataMember(Name="connectorParams", EmitDefaultValue=false)]
        public ConnectorParams ConnectorParams { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

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
            return this.Equals(input as StorageSnapshotProviderParams);
        }

        /// <summary>
        /// Returns true if StorageSnapshotProviderParams instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageSnapshotProviderParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageSnapshotProviderParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectorParams == input.ConnectorParams ||
                    (this.ConnectorParams != null &&
                    this.ConnectorParams.Equals(input.ConnectorParams))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
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
                if (this.ConnectorParams != null)
                    hashCode = hashCode * 59 + this.ConnectorParams.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                return hashCode;
            }
        }

    }

}

