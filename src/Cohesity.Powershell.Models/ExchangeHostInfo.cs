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
    /// Specifies the Information about the Exchange host.
    /// </summary>
    [DataContract]
    public partial class ExchangeHostInfo :  IEquatable<ExchangeHostInfo>
    {
        /// <summary>
        /// Specifies the status of the agent on the Exchange host. Specifies the status of agent on Exchange Application Server. &#39;kSupported&#39; indicates the agent is supported for Exchange data protection. &#39;kUnSupported&#39; indicates the agent is not supported for Exchange data protection. &#39;kUpgrade&#39; indicates the agent of server need to be upgraded.
        /// </summary>
        /// <value>Specifies the status of the agent on the Exchange host. Specifies the status of agent on Exchange Application Server. &#39;kSupported&#39; indicates the agent is supported for Exchange data protection. &#39;kUnSupported&#39; indicates the agent is not supported for Exchange data protection. &#39;kUpgrade&#39; indicates the agent of server need to be upgraded.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AgentStatusEnum
        {
            /// <summary>
            /// Enum KSupported for value: kSupported
            /// </summary>
            [EnumMember(Value = "kSupported")]
            KSupported = 1,

            /// <summary>
            /// Enum KUpgrade for value: kUpgrade
            /// </summary>
            [EnumMember(Value = "kUpgrade")]
            KUpgrade = 2,

            /// <summary>
            /// Enum KUnsupported for value: kUnsupported
            /// </summary>
            [EnumMember(Value = "kUnsupported")]
            KUnsupported = 3

        }

        /// <summary>
        /// Specifies the status of the agent on the Exchange host. Specifies the status of agent on Exchange Application Server. &#39;kSupported&#39; indicates the agent is supported for Exchange data protection. &#39;kUnSupported&#39; indicates the agent is not supported for Exchange data protection. &#39;kUpgrade&#39; indicates the agent of server need to be upgraded.
        /// </summary>
        /// <value>Specifies the status of the agent on the Exchange host. Specifies the status of agent on Exchange Application Server. &#39;kSupported&#39; indicates the agent is supported for Exchange data protection. &#39;kUnSupported&#39; indicates the agent is not supported for Exchange data protection. &#39;kUpgrade&#39; indicates the agent of server need to be upgraded.</value>
        [DataMember(Name="agentStatus", EmitDefaultValue=false)]
        public AgentStatusEnum? AgentStatus { get; set; }
        /// <summary>
        /// Specifies the status of the registration of the Exchange Host. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.
        /// </summary>
        /// <value>Specifies the status of the registration of the Exchange Host. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 1,

            /// <summary>
            /// Enum KHealthy for value: kHealthy
            /// </summary>
            [EnumMember(Value = "kHealthy")]
            KHealthy = 2,

            /// <summary>
            /// Enum KUnHealthy for value: kUnHealthy
            /// </summary>
            [EnumMember(Value = "kUnHealthy")]
            KUnHealthy = 3,

            /// <summary>
            /// Enum KUnregistered for value: kUnregistered
            /// </summary>
            [EnumMember(Value = "kUnregistered")]
            KUnregistered = 4,

            /// <summary>
            /// Enum KUreachable for value: kUreachable
            /// </summary>
            [EnumMember(Value = "kUreachable")]
            KUreachable = 5,

            /// <summary>
            /// Enum KDetached for value: kDetached
            /// </summary>
            [EnumMember(Value = "kDetached")]
            KDetached = 6

        }

        /// <summary>
        /// Specifies the status of the registration of the Exchange Host. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.
        /// </summary>
        /// <value>Specifies the status of the registration of the Exchange Host. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeHostInfo" /> class.
        /// </summary>
        /// <param name="agentStatus">Specifies the status of the agent on the Exchange host. Specifies the status of agent on Exchange Application Server. &#39;kSupported&#39; indicates the agent is supported for Exchange data protection. &#39;kUnSupported&#39; indicates the agent is not supported for Exchange data protection. &#39;kUpgrade&#39; indicates the agent of server need to be upgraded..</param>
        /// <param name="endpoint">Specifies the endpoint of the Exchange host..</param>
        /// <param name="guid">Specifies the guid of the Exchange host..</param>
        /// <param name="name">Specifies the display name of the Exchange host..</param>
        /// <param name="protectionSourceId">Specifies the Protection source id of the Physical Host if the Exchange application is already registered on the physical host with the above endpoint..</param>
        /// <param name="status">Specifies the status of the registration of the Exchange Host. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG..</param>
        public ExchangeHostInfo(AgentStatusEnum? agentStatus = default(AgentStatusEnum?), string endpoint = default(string), string guid = default(string), string name = default(string), long? protectionSourceId = default(long?), StatusEnum? status = default(StatusEnum?))
        {
            this.AgentStatus = agentStatus;
            this.Endpoint = endpoint;
            this.Guid = guid;
            this.Name = name;
            this.ProtectionSourceId = protectionSourceId;
            this.Status = status;
        }
        

        /// <summary>
        /// Specifies the endpoint of the Exchange host.
        /// </summary>
        /// <value>Specifies the endpoint of the Exchange host.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Specifies the guid of the Exchange host.
        /// </summary>
        /// <value>Specifies the guid of the Exchange host.</value>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies the display name of the Exchange host.
        /// </summary>
        /// <value>Specifies the display name of the Exchange host.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the Protection source id of the Physical Host if the Exchange application is already registered on the physical host with the above endpoint.
        /// </summary>
        /// <value>Specifies the Protection source id of the Physical Host if the Exchange application is already registered on the physical host with the above endpoint.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=false)]
        public long? ProtectionSourceId { get; set; }


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
            return this.Equals(input as ExchangeHostInfo);
        }

        /// <summary>
        /// Returns true if ExchangeHostInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeHostInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeHostInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentStatus == input.AgentStatus ||
                    (this.AgentStatus != null &&
                    this.AgentStatus.Equals(input.AgentStatus))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProtectionSourceId == input.ProtectionSourceId ||
                    (this.ProtectionSourceId != null &&
                    this.ProtectionSourceId.Equals(input.ProtectionSourceId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AgentStatus != null)
                    hashCode = hashCode * 59 + this.AgentStatus.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

