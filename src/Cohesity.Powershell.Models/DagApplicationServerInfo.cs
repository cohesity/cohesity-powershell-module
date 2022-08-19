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
    /// Specifies the information about the status of the Exchange Application Server which is a member of the DAG.
    /// </summary>
    [DataContract]
    public partial class DagApplicationServerInfo :  IEquatable<DagApplicationServerInfo>
    {
        /// <summary>
        /// Specifies the status of the registration of the Exchange Application Server. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.
        /// </summary>
        /// <value>Specifies the status of the registration of the Exchange Application Server. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.</value>
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
        /// Specifies the status of the registration of the Exchange Application Server. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.
        /// </summary>
        /// <value>Specifies the status of the registration of the Exchange Application Server. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DagApplicationServerInfo" /> class.
        /// </summary>
        /// <param name="fqdn">Specifies the fully qualified domain name of the Exchange Server..</param>
        /// <param name="guid">Specifies the Guid of the Exchange Application Server..</param>
        /// <param name="id">Specifies the entity id of the Exchange Application server..</param>
        /// <param name="name">Specifies the display name of the Exchange Application Server..</param>
        /// <param name="ownerId">Specifies the entity id of the owner entity of the Exchange Application Server..</param>
        /// <param name="status">Specifies the status of the registration of the Exchange Application Server. Specifies the status of registration of Exchange Application Server. &#39;kUnknown&#39; indicates the status is not known. &#39;kHealthy&#39; indicates the status is healty and is registered as Exchange Server. &#39;kUnHealthy&#39; indicates the exchange application is registered on the physical server but it is unreachable now. &#39;kUnregistered&#39; indicates the server is not registered as physical source. &#39;kUnreachable&#39; indicates the server is not reachable from the cohesity cluster or the cohesity protection server is not installed on the exchange server. &#39;kDetached&#39; indicates the server is removed from the ExchangeDAG..</param>
        /// <param name="totalSizeBytes">Specifies the total size of all Exchange database copies in all the Exchange Application Servers that are part of the DAG..</param>
        public DagApplicationServerInfo(string fqdn = default(string), string guid = default(string), long? id = default(long?), string name = default(string), long? ownerId = default(long?), StatusEnum? status = default(StatusEnum?), long? totalSizeBytes = default(long?))
        {
            this.Fqdn = fqdn;
            this.Guid = guid;
            this.Id = id;
            this.Name = name;
            this.OwnerId = ownerId;
            this.Status = status;
            this.TotalSizeBytes = totalSizeBytes;
            this.Fqdn = fqdn;
            this.Guid = guid;
            this.Id = id;
            this.Name = name;
            this.OwnerId = ownerId;
            this.Status = status;
            this.TotalSizeBytes = totalSizeBytes;
        }
        
        /// <summary>
        /// Specifies the fully qualified domain name of the Exchange Server.
        /// </summary>
        /// <value>Specifies the fully qualified domain name of the Exchange Server.</value>
        [DataMember(Name="fqdn", EmitDefaultValue=true)]
        public string Fqdn { get; set; }

        /// <summary>
        /// Specifies the Guid of the Exchange Application Server.
        /// </summary>
        /// <value>Specifies the Guid of the Exchange Application Server.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies the entity id of the Exchange Application server.
        /// </summary>
        /// <value>Specifies the entity id of the Exchange Application server.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the display name of the Exchange Application Server.
        /// </summary>
        /// <value>Specifies the display name of the Exchange Application Server.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the entity id of the owner entity of the Exchange Application Server.
        /// </summary>
        /// <value>Specifies the entity id of the owner entity of the Exchange Application Server.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies the total size of all Exchange database copies in all the Exchange Application Servers that are part of the DAG.
        /// </summary>
        /// <value>Specifies the total size of all Exchange database copies in all the Exchange Application Servers that are part of the DAG.</value>
        [DataMember(Name="totalSizeBytes", EmitDefaultValue=true)]
        public long? TotalSizeBytes { get; set; }

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
            return this.Equals(input as DagApplicationServerInfo);
        }

        /// <summary>
        /// Returns true if DagApplicationServerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DagApplicationServerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DagApplicationServerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fqdn == input.Fqdn ||
                    (this.Fqdn != null &&
                    this.Fqdn.Equals(input.Fqdn))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TotalSizeBytes == input.TotalSizeBytes ||
                    (this.TotalSizeBytes != null &&
                    this.TotalSizeBytes.Equals(input.TotalSizeBytes))
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
                if (this.Fqdn != null)
                    hashCode = hashCode * 59 + this.Fqdn.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

