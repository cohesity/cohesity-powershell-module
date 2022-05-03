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
    /// Message that encapsulates the various params required to establish a connection with a particular environment.
    /// </summary>
    [DataContract]
    public partial class ConnectorParams :  IEquatable<ConnectorParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorParams" /> class.
        /// </summary>
        /// <param name="additionalParams">additionalParams.</param>
        /// <param name="agentEndpoint">For some of the environments connection to endpoint is done through an agent. This captures the agent endpoint information..</param>
        /// <param name="agentPort">Optional agent port to use when connecting to the server. If this is not specified, then environment specific default port will be used..</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="endpoint">The endpoint URL of the environment (such as the address of the vCenter instance for a VMware environment, etc)..</param>
        /// <param name="entity">entity.</param>
        /// <param name="hostType">The host environment type. This is set for kPhysical type environment..</param>
        /// <param name="id">A unique id associated with this connector params. This is a convenience field and is used to maintain an index to different connection params. This is generated at the time when the source is registered with Magneto..</param>
        /// <param name="networkRealmId">The network-realm id of the tenant through which this source is accessible. This realm could be a collection of hyxes. If this is set(&gt;&#x3D; 0), tenant_id must also be set. Value of &#39;0&#39; has special semantics, refer bifrost/base/constant.cc..</param>
        /// <param name="populateSubnetForAllClusterNodes">If set to true, inter agent communcation will be enabled and for every GetAgentInfo call we will fill subnet information of all the nodes in clustered entity..</param>
        /// <param name="port">Optional port to use when connecting to the server. If this is not specified, then environment specific default port will be used..</param>
        /// <param name="tenantId">The tenant_id for the environment. This is used to remotely access connectors and executors via bifrost..</param>
        /// <param name="type">The type of environment to connect to..</param>
        /// <param name="version">A version that is associated with the params. This is updated anytime any of the params change. This is used to discard older connector params..</param>
        public ConnectorParams(AdditionalConnectorParams additionalParams = default(AdditionalConnectorParams), string agentEndpoint = default(string), int? agentPort = default(int?), Credentials credentials = default(Credentials), string endpoint = default(string), EntityProto entity = default(EntityProto), int? hostType = default(int?), long? id = default(long?), long? networkRealmId = default(long?), bool? populateSubnetForAllClusterNodes = default(bool?), int? port = default(int?), string tenantId = default(string), int? type = default(int?), long? version = default(long?))
        {
            this.AdditionalParams = additionalParams;
            this.AgentEndpoint = agentEndpoint;
            this.AgentPort = agentPort;
            this.Credentials = credentials;
            this.Endpoint = endpoint;
            this.Entity = entity;
            this.HostType = hostType;
            this.Id = id;
            this.NetworkRealmId = networkRealmId;
            this.PopulateSubnetForAllClusterNodes = populateSubnetForAllClusterNodes;
            this.Port = port;
            this.TenantId = tenantId;
            this.Type = type;
            this.Version = version;
        }
        
        /// <summary>
        /// Gets or Sets AdditionalParams
        /// </summary>
        [DataMember(Name="additionalParams", EmitDefaultValue=false)]
        public AdditionalConnectorParams AdditionalParams { get; set; }

        /// <summary>
        /// For some of the environments connection to endpoint is done through an agent. This captures the agent endpoint information.
        /// </summary>
        /// <value>For some of the environments connection to endpoint is done through an agent. This captures the agent endpoint information.</value>
        [DataMember(Name="agentEndpoint", EmitDefaultValue=false)]
        public string AgentEndpoint { get; set; }

        /// <summary>
        /// Optional agent port to use when connecting to the server. If this is not specified, then environment specific default port will be used.
        /// </summary>
        /// <value>Optional agent port to use when connecting to the server. If this is not specified, then environment specific default port will be used.</value>
        [DataMember(Name="agentPort", EmitDefaultValue=false)]
        public int? AgentPort { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// The endpoint URL of the environment (such as the address of the vCenter instance for a VMware environment, etc).
        /// </summary>
        /// <value>The endpoint URL of the environment (such as the address of the vCenter instance for a VMware environment, etc).</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// The host environment type. This is set for kPhysical type environment.
        /// </summary>
        /// <value>The host environment type. This is set for kPhysical type environment.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public int? HostType { get; set; }

        /// <summary>
        /// A unique id associated with this connector params. This is a convenience field and is used to maintain an index to different connection params. This is generated at the time when the source is registered with Magneto.
        /// </summary>
        /// <value>A unique id associated with this connector params. This is a convenience field and is used to maintain an index to different connection params. This is generated at the time when the source is registered with Magneto.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The network-realm id of the tenant through which this source is accessible. This realm could be a collection of hyxes. If this is set(&gt;&#x3D; 0), tenant_id must also be set. Value of &#39;0&#39; has special semantics, refer bifrost/base/constant.cc.
        /// </summary>
        /// <value>The network-realm id of the tenant through which this source is accessible. This realm could be a collection of hyxes. If this is set(&gt;&#x3D; 0), tenant_id must also be set. Value of &#39;0&#39; has special semantics, refer bifrost/base/constant.cc.</value>
        [DataMember(Name="networkRealmId", EmitDefaultValue=false)]
        public long? NetworkRealmId { get; set; }

        /// <summary>
        /// If set to true, inter agent communcation will be enabled and for every GetAgentInfo call we will fill subnet information of all the nodes in clustered entity.
        /// </summary>
        /// <value>If set to true, inter agent communcation will be enabled and for every GetAgentInfo call we will fill subnet information of all the nodes in clustered entity.</value>
        [DataMember(Name="populateSubnetForAllClusterNodes", EmitDefaultValue=false)]
        public bool? PopulateSubnetForAllClusterNodes { get; set; }

        /// <summary>
        /// Optional port to use when connecting to the server. If this is not specified, then environment specific default port will be used.
        /// </summary>
        /// <value>Optional port to use when connecting to the server. If this is not specified, then environment specific default port will be used.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The tenant_id for the environment. This is used to remotely access connectors and executors via bifrost.
        /// </summary>
        /// <value>The tenant_id for the environment. This is used to remotely access connectors and executors via bifrost.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The type of environment to connect to.
        /// </summary>
        /// <value>The type of environment to connect to.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// A version that is associated with the params. This is updated anytime any of the params change. This is used to discard older connector params.
        /// </summary>
        /// <value>A version that is associated with the params. This is updated anytime any of the params change. This is used to discard older connector params.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

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
            return this.Equals(input as ConnectorParams);
        }

        /// <summary>
        /// Returns true if ConnectorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalParams == input.AdditionalParams ||
                    (this.AdditionalParams != null &&
                    this.AdditionalParams.Equals(input.AdditionalParams))
                ) && 
                (
                    this.AgentEndpoint == input.AgentEndpoint ||
                    (this.AgentEndpoint != null &&
                    this.AgentEndpoint.Equals(input.AgentEndpoint))
                ) && 
                (
                    this.AgentPort == input.AgentPort ||
                    (this.AgentPort != null &&
                    this.AgentPort.Equals(input.AgentPort))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NetworkRealmId == input.NetworkRealmId ||
                    (this.NetworkRealmId != null &&
                    this.NetworkRealmId.Equals(input.NetworkRealmId))
                ) && 
                (
                    this.PopulateSubnetForAllClusterNodes == input.PopulateSubnetForAllClusterNodes ||
                    (this.PopulateSubnetForAllClusterNodes != null &&
                    this.PopulateSubnetForAllClusterNodes.Equals(input.PopulateSubnetForAllClusterNodes))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.AdditionalParams != null)
                    hashCode = hashCode * 59 + this.AdditionalParams.GetHashCode();
                if (this.AgentEndpoint != null)
                    hashCode = hashCode * 59 + this.AgentEndpoint.GetHashCode();
                if (this.AgentPort != null)
                    hashCode = hashCode * 59 + this.AgentPort.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NetworkRealmId != null)
                    hashCode = hashCode * 59 + this.NetworkRealmId.GetHashCode();
                if (this.PopulateSubnetForAllClusterNodes != null)
                    hashCode = hashCode * 59 + this.PopulateSubnetForAllClusterNodes.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

