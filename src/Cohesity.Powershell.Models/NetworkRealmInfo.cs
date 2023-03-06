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
    /// Contains mapping of network realms with adapter specific entities. This will be populated by IRIS for create/update source requests so that we can persist the mapping in the corresponding entity hierarchy.
    /// </summary>
    [DataContract]
    public partial class NetworkRealmInfo :  IEquatable<NetworkRealmInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRealmInfo" /> class.
        /// </summary>
        /// <param name="connectorGroupId">&#39;network_realm_id&#39; maintains the collection of connector_group_id. Connector group id for the environment. If it is set, Magneto will fetch the bifrost server based on &lt;network_realm_id, connector_group_id&gt;..</param>
        /// <param name="entityId">Entity id to which the network_realm_id is mapped to. This can be a non root entity as well..</param>
        /// <param name="networkRealmId">Network Realm id to use for the tenant. This realm could be a collection of Rigel/HyX..</param>
        public NetworkRealmInfo(long? connectorGroupId = default(long?), long? entityId = default(long?), long? networkRealmId = default(long?))
        {
            this.ConnectorGroupId = connectorGroupId;
            this.EntityId = entityId;
            this.NetworkRealmId = networkRealmId;
            this.ConnectorGroupId = connectorGroupId;
            this.EntityId = entityId;
            this.NetworkRealmId = networkRealmId;
        }
        
        /// <summary>
        /// &#39;network_realm_id&#39; maintains the collection of connector_group_id. Connector group id for the environment. If it is set, Magneto will fetch the bifrost server based on &lt;network_realm_id, connector_group_id&gt;.
        /// </summary>
        /// <value>&#39;network_realm_id&#39; maintains the collection of connector_group_id. Connector group id for the environment. If it is set, Magneto will fetch the bifrost server based on &lt;network_realm_id, connector_group_id&gt;.</value>
        [DataMember(Name="connectorGroupId", EmitDefaultValue=true)]
        public long? ConnectorGroupId { get; set; }

        /// <summary>
        /// Entity id to which the network_realm_id is mapped to. This can be a non root entity as well.
        /// </summary>
        /// <value>Entity id to which the network_realm_id is mapped to. This can be a non root entity as well.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Network Realm id to use for the tenant. This realm could be a collection of Rigel/HyX.
        /// </summary>
        /// <value>Network Realm id to use for the tenant. This realm could be a collection of Rigel/HyX.</value>
        [DataMember(Name="networkRealmId", EmitDefaultValue=true)]
        public long? NetworkRealmId { get; set; }

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
            return this.Equals(input as NetworkRealmInfo);
        }

        /// <summary>
        /// Returns true if NetworkRealmInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkRealmInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkRealmInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectorGroupId == input.ConnectorGroupId ||
                    (this.ConnectorGroupId != null &&
                    this.ConnectorGroupId.Equals(input.ConnectorGroupId))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.NetworkRealmId == input.NetworkRealmId ||
                    (this.NetworkRealmId != null &&
                    this.NetworkRealmId.Equals(input.NetworkRealmId))
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
                if (this.ConnectorGroupId != null)
                    hashCode = hashCode * 59 + this.ConnectorGroupId.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.NetworkRealmId != null)
                    hashCode = hashCode * 59 + this.NetworkRealmId.GetHashCode();
                return hashCode;
            }
        }

    }

}

