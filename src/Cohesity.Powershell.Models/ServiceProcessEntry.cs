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
    /// Specifies the name of a Service running on the Cluster as well as a list of process IDs associated with that service.
    /// </summary>
    [DataContract]
    public partial class ServiceProcessEntry :  IEquatable<ServiceProcessEntry>
    {
        /// <summary>
        /// Specifies the name of the Service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot.
        /// </summary>
        /// <value>Specifies the name of the Service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceNameEnum
        {
            /// <summary>
            /// Enum KApollo for value: kApollo
            /// </summary>
            [EnumMember(Value = "kApollo")]
            KApollo = 1,

            /// <summary>
            /// Enum KBridge for value: kBridge
            /// </summary>
            [EnumMember(Value = "kBridge")]
            KBridge = 2,

            /// <summary>
            /// Enum KGenie for value: kGenie
            /// </summary>
            [EnumMember(Value = "kGenie")]
            KGenie = 3,

            /// <summary>
            /// Enum KGenieGofer for value: kGenieGofer
            /// </summary>
            [EnumMember(Value = "kGenieGofer")]
            KGenieGofer = 4,

            /// <summary>
            /// Enum KMagneto for value: kMagneto
            /// </summary>
            [EnumMember(Value = "kMagneto")]
            KMagneto = 5,

            /// <summary>
            /// Enum KIris for value: kIris
            /// </summary>
            [EnumMember(Value = "kIris")]
            KIris = 6,

            /// <summary>
            /// Enum KIrisProxy for value: kIrisProxy
            /// </summary>
            [EnumMember(Value = "kIrisProxy")]
            KIrisProxy = 7,

            /// <summary>
            /// Enum KScribe for value: kScribe
            /// </summary>
            [EnumMember(Value = "kScribe")]
            KScribe = 8,

            /// <summary>
            /// Enum KStats for value: kStats
            /// </summary>
            [EnumMember(Value = "kStats")]
            KStats = 9,

            /// <summary>
            /// Enum KYoda for value: kYoda
            /// </summary>
            [EnumMember(Value = "kYoda")]
            KYoda = 10,

            /// <summary>
            /// Enum KAlerts for value: kAlerts
            /// </summary>
            [EnumMember(Value = "kAlerts")]
            KAlerts = 11,

            /// <summary>
            /// Enum KKeychain for value: kKeychain
            /// </summary>
            [EnumMember(Value = "kKeychain")]
            KKeychain = 12,

            /// <summary>
            /// Enum KLogWatcher for value: kLogWatcher
            /// </summary>
            [EnumMember(Value = "kLogWatcher")]
            KLogWatcher = 13,

            /// <summary>
            /// Enum KStatsCollecter for value: kStatsCollecter
            /// </summary>
            [EnumMember(Value = "kStatsCollecter")]
            KStatsCollecter = 14,

            /// <summary>
            /// Enum KGandalf for value: kGandalf
            /// </summary>
            [EnumMember(Value = "kGandalf")]
            KGandalf = 15,

            /// <summary>
            /// Enum KNexus for value: kNexus
            /// </summary>
            [EnumMember(Value = "kNexus")]
            KNexus = 16,

            /// <summary>
            /// Enum KNexusProxy for value: kNexusProxy
            /// </summary>
            [EnumMember(Value = "kNexusProxy")]
            KNexusProxy = 17,

            /// <summary>
            /// Enum KStorageProxy for value: kStorageProxy
            /// </summary>
            [EnumMember(Value = "kStorageProxy")]
            KStorageProxy = 18,

            /// <summary>
            /// Enum KTricorder for value: kTricorder
            /// </summary>
            [EnumMember(Value = "kTricorder")]
            KTricorder = 19,

            /// <summary>
            /// Enum KRtClient for value: kRtClient
            /// </summary>
            [EnumMember(Value = "kRtClient")]
            KRtClient = 20,

            /// <summary>
            /// Enum KVaultProxy for value: kVaultProxy
            /// </summary>
            [EnumMember(Value = "kVaultProxy")]
            KVaultProxy = 21,

            /// <summary>
            /// Enum KSmbProxy for value: kSmbProxy
            /// </summary>
            [EnumMember(Value = "kSmbProxy")]
            KSmbProxy = 22,

            /// <summary>
            /// Enum KBridgeProxy for value: kBridgeProxy
            /// </summary>
            [EnumMember(Value = "kBridgeProxy")]
            KBridgeProxy = 23,

            /// <summary>
            /// Enum KLibrarian for value: kLibrarian
            /// </summary>
            [EnumMember(Value = "kLibrarian")]
            KLibrarian = 24,

            /// <summary>
            /// Enum KGroot for value: kGroot
            /// </summary>
            [EnumMember(Value = "kGroot")]
            KGroot = 25,

            /// <summary>
            /// Enum KEagleAgent for value: kEagleAgent
            /// </summary>
            [EnumMember(Value = "kEagleAgent")]
            KEagleAgent = 26,

            /// <summary>
            /// Enum KAthena for value: kAthena
            /// </summary>
            [EnumMember(Value = "kAthena")]
            KAthena = 27,

            /// <summary>
            /// Enum KBifrostBroker for value: kBifrostBroker
            /// </summary>
            [EnumMember(Value = "kBifrostBroker")]
            KBifrostBroker = 28,

            /// <summary>
            /// Enum KSmb2Proxy for value: kSmb2Proxy
            /// </summary>
            [EnumMember(Value = "kSmb2Proxy")]
            KSmb2Proxy = 29,

            /// <summary>
            /// Enum KOs for value: kOs
            /// </summary>
            [EnumMember(Value = "kOs")]
            KOs = 30

        }

        /// <summary>
        /// Specifies the name of the Service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot.
        /// </summary>
        /// <value>Specifies the name of the Service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=true)]
        public ServiceNameEnum? ServiceName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProcessEntry" /> class.
        /// </summary>
        /// <param name="processIds">Specifies the list of process IDs associated with the Service..</param>
        /// <param name="serviceName">Specifies the name of the Service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot..</param>
        public ServiceProcessEntry(List<long> processIds = default(List<long>), ServiceNameEnum? serviceName = default(ServiceNameEnum?))
        {
            this.ProcessIds = processIds;
            this.ServiceName = serviceName;
            this.ProcessIds = processIds;
            this.ServiceName = serviceName;
        }
        
        /// <summary>
        /// Specifies the list of process IDs associated with the Service.
        /// </summary>
        /// <value>Specifies the list of process IDs associated with the Service.</value>
        [DataMember(Name="processIds", EmitDefaultValue=true)]
        public List<long> ProcessIds { get; set; }

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
            return this.Equals(input as ServiceProcessEntry);
        }

        /// <summary>
        /// Returns true if ServiceProcessEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceProcessEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceProcessEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessIds == input.ProcessIds ||
                    this.ProcessIds != null &&
                    input.ProcessIds != null &&
                    this.ProcessIds.SequenceEqual(input.ProcessIds)
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    this.ServiceName.Equals(input.ServiceName)
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
                if (this.ProcessIds != null)
                    hashCode = hashCode * 59 + this.ProcessIds.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                return hashCode;
            }
        }

    }

}

