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
    /// Specifies the result of querying the state of a specific service on the Cluster.
    /// </summary>
    [DataContract]
    public partial class ServiceStateResult :  IEquatable<ServiceStateResult>
    {
        /// <summary>
        /// Specifies the name of the service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster. kScribe, kStats, kYoda, kAlerts, kKeychain, kLogWatcher, kStatsCollecter, kGandalf, kNexus, kNexusProxy, kStorageProxy, kRtClient, kVaultProxy, kSmbProxy, kBridgeProxy, kLibrarian, kGroot, kEagleAgent, kAthena, kBifrostBroker, kSmb2Proxy, kOs, kAtom, kIcebox
        /// </summary>
        /// <value>Specifies the name of the service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster. kScribe, kStats, kYoda, kAlerts, kKeychain, kLogWatcher, kStatsCollecter, kGandalf, kNexus, kNexusProxy, kStorageProxy, kRtClient, kVaultProxy, kSmbProxy, kBridgeProxy, kLibrarian, kGroot, kEagleAgent, kAthena, kBifrostBroker, kSmb2Proxy, kOs, kAtom, kIcebox</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceEnum
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
            KOs = 30,

            /// <summary>
            /// Enum KAtom for value: kAtom
            /// </summary>
            [EnumMember(Value = "kAtom")]
            KAtom = 31

        }

        /// <summary>
        /// Specifies the name of the service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster. kScribe, kStats, kYoda, kAlerts, kKeychain, kLogWatcher, kStatsCollecter, kGandalf, kNexus, kNexusProxy, kStorageProxy, kRtClient, kVaultProxy, kSmbProxy, kBridgeProxy, kLibrarian, kGroot, kEagleAgent, kAthena, kBifrostBroker, kSmb2Proxy, kOs, kAtom, kIcebox
        /// </summary>
        /// <value>Specifies the name of the service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster. kScribe, kStats, kYoda, kAlerts, kKeychain, kLogWatcher, kStatsCollecter, kGandalf, kNexus, kNexusProxy, kStorageProxy, kRtClient, kVaultProxy, kSmbProxy, kBridgeProxy, kLibrarian, kGroot, kEagleAgent, kAthena, kBifrostBroker, kSmb2Proxy, kOs, kAtom, kIcebox</value>
        [DataMember(Name="service", EmitDefaultValue=true)]
        public ServiceEnum? Service { get; set; }
        /// <summary>
        /// Specifies the state of the service. &#39;kServiceStopped&#39; indicates that the service has been stopped. &#39;kServiceRunning&#39; indicates that the service is currently running. &#39;kServiceRestarting&#39; indicates that the service is in the queue to be restarted.
        /// </summary>
        /// <value>Specifies the state of the service. &#39;kServiceStopped&#39; indicates that the service has been stopped. &#39;kServiceRunning&#39; indicates that the service is currently running. &#39;kServiceRestarting&#39; indicates that the service is in the queue to be restarted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum KServiceStopped for value: kServiceStopped
            /// </summary>
            [EnumMember(Value = "kServiceStopped")]
            KServiceStopped = 1,

            /// <summary>
            /// Enum KServiceRunning for value: kServiceRunning
            /// </summary>
            [EnumMember(Value = "kServiceRunning")]
            KServiceRunning = 2,

            /// <summary>
            /// Enum KServiceRestarting for value: kServiceRestarting
            /// </summary>
            [EnumMember(Value = "kServiceRestarting")]
            KServiceRestarting = 3

        }

        /// <summary>
        /// Specifies the state of the service. &#39;kServiceStopped&#39; indicates that the service has been stopped. &#39;kServiceRunning&#39; indicates that the service is currently running. &#39;kServiceRestarting&#39; indicates that the service is in the queue to be restarted.
        /// </summary>
        /// <value>Specifies the state of the service. &#39;kServiceStopped&#39; indicates that the service has been stopped. &#39;kServiceRunning&#39; indicates that the service is currently running. &#39;kServiceRestarting&#39; indicates that the service is in the queue to be restarted.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceStateResult" /> class.
        /// </summary>
        /// <param name="service">Specifies the name of the service. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster. kScribe, kStats, kYoda, kAlerts, kKeychain, kLogWatcher, kStatsCollecter, kGandalf, kNexus, kNexusProxy, kStorageProxy, kRtClient, kVaultProxy, kSmbProxy, kBridgeProxy, kLibrarian, kGroot, kEagleAgent, kAthena, kBifrostBroker, kSmb2Proxy, kOs, kAtom, kIcebox.</param>
        /// <param name="state">Specifies the state of the service. &#39;kServiceStopped&#39; indicates that the service has been stopped. &#39;kServiceRunning&#39; indicates that the service is currently running. &#39;kServiceRestarting&#39; indicates that the service is in the queue to be restarted..</param>
        public ServiceStateResult(ServiceEnum? service = default(ServiceEnum?), StateEnum? state = default(StateEnum?))
        {
            this.Service = service;
            this.State = state;
        }
        
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
            return this.Equals(input as ServiceStateResult);
        }

        /// <summary>
        /// Returns true if ServiceStateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceStateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceStateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Service == input.Service ||
                    this.Service.Equals(input.Service)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                hashCode = hashCode * 59 + this.Service.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}

