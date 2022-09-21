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
    /// Specifies if the endpoint provided in the request is standalone exchange server or not. If the endpoint is not a standalone exchange server, the list of hosts which belong to the Exchange DAG are returned.
    /// </summary>
    [DataContract]
    public partial class ExchangeDagHostsResponse :  IEquatable<ExchangeDagHostsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeDagHostsResponse" /> class.
        /// </summary>
        /// <param name="exchangeDagProtectionPreference">exchangeDagProtectionPreference.</param>
        /// <param name="exchangeHostInfoList">Specifies the list of exchange hosts that belong to Exchange DAG..</param>
        /// <param name="guid">Specifies the Unique GUID for the DAG..</param>
        /// <param name="isStandaloneHost">Specifies if the endpoint provided in the request is a standlone exchange server or not. exchangeHostInfoList is not populated if it is a standalone exchange server..</param>
        /// <param name="name">Specifies the display name of the DAG..</param>
        /// <param name="protectionSourceId">Specifies the Protection Source Id of the Exchange DAG if it is already created..</param>
        public ExchangeDagHostsResponse(ExchangeDAGProtectionPreference exchangeDagProtectionPreference = default(ExchangeDAGProtectionPreference), List<ExchangeHostInfo> exchangeHostInfoList = default(List<ExchangeHostInfo>), string guid = default(string), bool? isStandaloneHost = default(bool?), string name = default(string), long? protectionSourceId = default(long?))
        {
            this.ExchangeHostInfoList = exchangeHostInfoList;
            this.Guid = guid;
            this.IsStandaloneHost = isStandaloneHost;
            this.Name = name;
            this.ProtectionSourceId = protectionSourceId;
            this.ExchangeDagProtectionPreference = exchangeDagProtectionPreference;
            this.ExchangeHostInfoList = exchangeHostInfoList;
            this.Guid = guid;
            this.IsStandaloneHost = isStandaloneHost;
            this.Name = name;
            this.ProtectionSourceId = protectionSourceId;
        }
        
        /// <summary>
        /// Gets or Sets ExchangeDagProtectionPreference
        /// </summary>
        [DataMember(Name="exchangeDagProtectionPreference", EmitDefaultValue=false)]
        public ExchangeDAGProtectionPreference ExchangeDagProtectionPreference { get; set; }

        /// <summary>
        /// Specifies the list of exchange hosts that belong to Exchange DAG.
        /// </summary>
        /// <value>Specifies the list of exchange hosts that belong to Exchange DAG.</value>
        [DataMember(Name="exchangeHostInfoList", EmitDefaultValue=true)]
        public List<ExchangeHostInfo> ExchangeHostInfoList { get; set; }

        /// <summary>
        /// Specifies the Unique GUID for the DAG.
        /// </summary>
        /// <value>Specifies the Unique GUID for the DAG.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies if the endpoint provided in the request is a standlone exchange server or not. exchangeHostInfoList is not populated if it is a standalone exchange server.
        /// </summary>
        /// <value>Specifies if the endpoint provided in the request is a standlone exchange server or not. exchangeHostInfoList is not populated if it is a standalone exchange server.</value>
        [DataMember(Name="isStandaloneHost", EmitDefaultValue=true)]
        public bool? IsStandaloneHost { get; set; }

        /// <summary>
        /// Specifies the display name of the DAG.
        /// </summary>
        /// <value>Specifies the display name of the DAG.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the Protection Source Id of the Exchange DAG if it is already created.
        /// </summary>
        /// <value>Specifies the Protection Source Id of the Exchange DAG if it is already created.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=true)]
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
            return this.Equals(input as ExchangeDagHostsResponse);
        }

        /// <summary>
        /// Returns true if ExchangeDagHostsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeDagHostsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeDagHostsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExchangeDagProtectionPreference == input.ExchangeDagProtectionPreference ||
                    (this.ExchangeDagProtectionPreference != null &&
                    this.ExchangeDagProtectionPreference.Equals(input.ExchangeDagProtectionPreference))
                ) && 
                (
                    this.ExchangeHostInfoList == input.ExchangeHostInfoList ||
                    this.ExchangeHostInfoList != null &&
                    input.ExchangeHostInfoList != null &&
                    this.ExchangeHostInfoList.Equals(input.ExchangeHostInfoList)
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IsStandaloneHost == input.IsStandaloneHost ||
                    (this.IsStandaloneHost != null &&
                    this.IsStandaloneHost.Equals(input.IsStandaloneHost))
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
                if (this.ExchangeDagProtectionPreference != null)
                    hashCode = hashCode * 59 + this.ExchangeDagProtectionPreference.GetHashCode();
                if (this.ExchangeHostInfoList != null)
                    hashCode = hashCode * 59 + this.ExchangeHostInfoList.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IsStandaloneHost != null)
                    hashCode = hashCode * 59 + this.IsStandaloneHost.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                return hashCode;
            }
        }

    }

}

