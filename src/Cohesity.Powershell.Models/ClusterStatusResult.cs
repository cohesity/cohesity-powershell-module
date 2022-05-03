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
    /// Specifies the result of getting the status of a Cluster.
    /// </summary>
    [DataContract]
    public partial class ClusterStatusResult :  IEquatable<ClusterStatusResult>
    {
        /// <summary>
        /// Specifies the current operation being run on the Cluster. &#39;kNone&#39; indicates that there is no current operation taking place. &#39;kDestroy&#39; indicates that the Cluster is currently being destroyed. &#39;kUpgrade&#39; indicates that the Cluster is currently being upgraded. &#39;kClean&#39; indicates that the Cluster is being cleaned. &#39;kRemoveNode&#39; indicates that a Node is being removed from the Cluster. &#39;kRestartServices&#39; indicates that the services on the Cluster are currently being restarted.
        /// </summary>
        /// <value>Specifies the current operation being run on the Cluster. &#39;kNone&#39; indicates that there is no current operation taking place. &#39;kDestroy&#39; indicates that the Cluster is currently being destroyed. &#39;kUpgrade&#39; indicates that the Cluster is currently being upgraded. &#39;kClean&#39; indicates that the Cluster is being cleaned. &#39;kRemoveNode&#39; indicates that a Node is being removed from the Cluster. &#39;kRestartServices&#39; indicates that the services on the Cluster are currently being restarted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrentOperationEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KDestroy for value: kDestroy
            /// </summary>
            [EnumMember(Value = "kDestroy")]
            KDestroy = 2,

            /// <summary>
            /// Enum KUpgrade for value: kUpgrade
            /// </summary>
            [EnumMember(Value = "kUpgrade")]
            KUpgrade = 3,

            /// <summary>
            /// Enum KClean for value: kClean
            /// </summary>
            [EnumMember(Value = "kClean")]
            KClean = 4,

            /// <summary>
            /// Enum KRemoveNode for value: kRemoveNode
            /// </summary>
            [EnumMember(Value = "kRemoveNode")]
            KRemoveNode = 5,

            /// <summary>
            /// Enum KRestartServices for value: kRestartServices
            /// </summary>
            [EnumMember(Value = "kRestartServices")]
            KRestartServices = 6

        }

        /// <summary>
        /// Specifies the current operation being run on the Cluster. &#39;kNone&#39; indicates that there is no current operation taking place. &#39;kDestroy&#39; indicates that the Cluster is currently being destroyed. &#39;kUpgrade&#39; indicates that the Cluster is currently being upgraded. &#39;kClean&#39; indicates that the Cluster is being cleaned. &#39;kRemoveNode&#39; indicates that a Node is being removed from the Cluster. &#39;kRestartServices&#39; indicates that the services on the Cluster are currently being restarted.
        /// </summary>
        /// <value>Specifies the current operation being run on the Cluster. &#39;kNone&#39; indicates that there is no current operation taking place. &#39;kDestroy&#39; indicates that the Cluster is currently being destroyed. &#39;kUpgrade&#39; indicates that the Cluster is currently being upgraded. &#39;kClean&#39; indicates that the Cluster is being cleaned. &#39;kRemoveNode&#39; indicates that a Node is being removed from the Cluster. &#39;kRestartServices&#39; indicates that the services on the Cluster are currently being restarted.</value>
        [DataMember(Name="currentOperation", EmitDefaultValue=false)]
        public CurrentOperationEnum? CurrentOperation { get; set; }
        /// <summary>
        /// Specifies the current healing state of the Cluster. &#39;kNoRemoval&#39; indicates that there are no removal operations currently happening on the Cluster. &#39;kNodeRemoval&#39; indicates that there is a Node being removed from the Cluster. &#39;kDiskRemoval&#39; indicates that there is a Disk being removed from the Cluster. &#39;kNodeAndDiskRemoval&#39; indicates that there is a Node and a Disk being removed from the Cluster.
        /// </summary>
        /// <value>Specifies the current healing state of the Cluster. &#39;kNoRemoval&#39; indicates that there are no removal operations currently happening on the Cluster. &#39;kNodeRemoval&#39; indicates that there is a Node being removed from the Cluster. &#39;kDiskRemoval&#39; indicates that there is a Disk being removed from the Cluster. &#39;kNodeAndDiskRemoval&#39; indicates that there is a Node and a Disk being removed from the Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemovalStateEnum
        {
            /// <summary>
            /// Enum KNoRemoval for value: kNoRemoval
            /// </summary>
            [EnumMember(Value = "kNoRemoval")]
            KNoRemoval = 1,

            /// <summary>
            /// Enum KNodeRemoval for value: kNodeRemoval
            /// </summary>
            [EnumMember(Value = "kNodeRemoval")]
            KNodeRemoval = 2,

            /// <summary>
            /// Enum KDiskRemoval for value: kDiskRemoval
            /// </summary>
            [EnumMember(Value = "kDiskRemoval")]
            KDiskRemoval = 3,

            /// <summary>
            /// Enum KNodeAndDiskRemoval for value: kNodeAndDiskRemoval
            /// </summary>
            [EnumMember(Value = "kNodeAndDiskRemoval")]
            KNodeAndDiskRemoval = 4

        }

        /// <summary>
        /// Specifies the current healing state of the Cluster. &#39;kNoRemoval&#39; indicates that there are no removal operations currently happening on the Cluster. &#39;kNodeRemoval&#39; indicates that there is a Node being removed from the Cluster. &#39;kDiskRemoval&#39; indicates that there is a Disk being removed from the Cluster. &#39;kNodeAndDiskRemoval&#39; indicates that there is a Node and a Disk being removed from the Cluster.
        /// </summary>
        /// <value>Specifies the current healing state of the Cluster. &#39;kNoRemoval&#39; indicates that there are no removal operations currently happening on the Cluster. &#39;kNodeRemoval&#39; indicates that there is a Node being removed from the Cluster. &#39;kDiskRemoval&#39; indicates that there is a Disk being removed from the Cluster. &#39;kNodeAndDiskRemoval&#39; indicates that there is a Node and a Disk being removed from the Cluster.</value>
        [DataMember(Name="removalState", EmitDefaultValue=false)]
        public RemovalStateEnum? RemovalState { get; set; }
        /// <summary>
        /// Defines StoppedServices
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StoppedServicesEnum
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
            /// Enum KRtClient for value: kRtClient
            /// </summary>
            [EnumMember(Value = "kRtClient")]
            KRtClient = 19,

            /// <summary>
            /// Enum KVaultProxy for value: kVaultProxy
            /// </summary>
            [EnumMember(Value = "kVaultProxy")]
            KVaultProxy = 20,

            /// <summary>
            /// Enum KSmbProxy for value: kSmbProxy
            /// </summary>
            [EnumMember(Value = "kSmbProxy")]
            KSmbProxy = 21,

            /// <summary>
            /// Enum KBridgeProxy for value: kBridgeProxy
            /// </summary>
            [EnumMember(Value = "kBridgeProxy")]
            KBridgeProxy = 22,

            /// <summary>
            /// Enum KLibrarian for value: kLibrarian
            /// </summary>
            [EnumMember(Value = "kLibrarian")]
            KLibrarian = 23,

            /// <summary>
            /// Enum KGroot for value: kGroot
            /// </summary>
            [EnumMember(Value = "kGroot")]
            KGroot = 24,

            /// <summary>
            /// Enum KEagleAgent for value: kEagleAgent
            /// </summary>
            [EnumMember(Value = "kEagleAgent")]
            KEagleAgent = 25,

            /// <summary>
            /// Enum KAthena for value: kAthena
            /// </summary>
            [EnumMember(Value = "kAthena")]
            KAthena = 26,

            /// <summary>
            /// Enum KBifrostBroker for value: kBifrostBroker
            /// </summary>
            [EnumMember(Value = "kBifrostBroker")]
            KBifrostBroker = 27,

            /// <summary>
            /// Enum KSmb2Proxy for value: kSmb2Proxy
            /// </summary>
            [EnumMember(Value = "kSmb2Proxy")]
            KSmb2Proxy = 28,

            /// <summary>
            /// Enum KOs for value: kOs
            /// </summary>
            [EnumMember(Value = "kOs")]
            KOs = 29,

            /// <summary>
            /// Enum KAtom for value: kAtom
            /// </summary>
            [EnumMember(Value = "kAtom")]
            KAtom = 30,

            /// <summary>
            /// Enum KIcebox for value: kIcebox
            /// </summary>
            [EnumMember(Value = "kIcebox")]
            KIcebox = 31

        }


        /// <summary>
        /// Specifies the list of stopped services on the Cluster. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster.
        /// </summary>
        /// <value>Specifies the list of stopped services on the Cluster. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster.</value>
        [DataMember(Name="stoppedServices", EmitDefaultValue=false)]
        public List<StoppedServicesEnum> StoppedServices { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusResult" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the ID of the Cluster..</param>
        /// <param name="clusterIncarnationId">Specifies the incarnation ID of the Cluster..</param>
        /// <param name="currentOperation">Specifies the current operation being run on the Cluster. &#39;kNone&#39; indicates that there is no current operation taking place. &#39;kDestroy&#39; indicates that the Cluster is currently being destroyed. &#39;kUpgrade&#39; indicates that the Cluster is currently being upgraded. &#39;kClean&#39; indicates that the Cluster is being cleaned. &#39;kRemoveNode&#39; indicates that a Node is being removed from the Cluster. &#39;kRestartServices&#39; indicates that the services on the Cluster are currently being restarted..</param>
        /// <param name="message">Specifies an optional message describing details of the Cluster status..</param>
        /// <param name="name">Specifies the name of the Cluster..</param>
        /// <param name="nodeStatuses">Specifies the status of each Node on the Cluster..</param>
        /// <param name="removalState">Specifies the current healing state of the Cluster. &#39;kNoRemoval&#39; indicates that there are no removal operations currently happening on the Cluster. &#39;kNodeRemoval&#39; indicates that there is a Node being removed from the Cluster. &#39;kDiskRemoval&#39; indicates that there is a Disk being removed from the Cluster. &#39;kNodeAndDiskRemoval&#39; indicates that there is a Node and a Disk being removed from the Cluster..</param>
        /// <param name="servicesSynced">Specifies whether or not the services are synced with the list of stopped services..</param>
        /// <param name="softwareVersion">Specifies the software version of the Cluster..</param>
        /// <param name="stoppedServices">Specifies the list of stopped services on the Cluster. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection. &#39;kPatch&#39; is a service for downloading and applying patches. &#39;kCompass&#39; is a service for serving dns request for external and internal traffic. &#39;kEtlServer&#39; is a service responsible for ETling data for globalsearch. &#39;kIcebox&#39; is service that links Icebox service to other services on cluster..</param>
        /// <param name="systemAppStatus">Specifies the status of each system app on the Cluster.</param>
        public ClusterStatusResult(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), CurrentOperationEnum? currentOperation = default(CurrentOperationEnum?), string message = default(string), string name = default(string), List<NodeStatusResult> nodeStatuses = default(List<NodeStatusResult>), RemovalStateEnum? removalState = default(RemovalStateEnum?), bool? servicesSynced = default(bool?), string softwareVersion = default(string), List<StoppedServicesEnum> stoppedServices = default(List<StoppedServicesEnum>), List<SystemAppStatusResult> systemAppStatus = default(List<SystemAppStatusResult>))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.CurrentOperation = currentOperation;
            this.Message = message;
            this.Name = name;
            this.NodeStatuses = nodeStatuses;
            this.RemovalState = removalState;
            this.ServicesSynced = servicesSynced;
            this.SoftwareVersion = softwareVersion;
            this.StoppedServices = stoppedServices;
            this.SystemAppStatus = systemAppStatus;
        }
        
        /// <summary>
        /// Specifies the ID of the Cluster.
        /// </summary>
        /// <value>Specifies the ID of the Cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the incarnation ID of the Cluster.
        /// </summary>
        /// <value>Specifies the incarnation ID of the Cluster.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=false)]
        public long? ClusterIncarnationId { get; set; }


        /// <summary>
        /// Specifies an optional message describing details of the Cluster status.
        /// </summary>
        /// <value>Specifies an optional message describing details of the Cluster status.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies the name of the Cluster.
        /// </summary>
        /// <value>Specifies the name of the Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the status of each Node on the Cluster.
        /// </summary>
        /// <value>Specifies the status of each Node on the Cluster.</value>
        [DataMember(Name="nodeStatuses", EmitDefaultValue=false)]
        public List<NodeStatusResult> NodeStatuses { get; set; }


        /// <summary>
        /// Specifies whether or not the services are synced with the list of stopped services.
        /// </summary>
        /// <value>Specifies whether or not the services are synced with the list of stopped services.</value>
        [DataMember(Name="servicesSynced", EmitDefaultValue=false)]
        public bool? ServicesSynced { get; set; }

        /// <summary>
        /// Specifies the software version of the Cluster.
        /// </summary>
        /// <value>Specifies the software version of the Cluster.</value>
        [DataMember(Name="softwareVersion", EmitDefaultValue=false)]
        public string SoftwareVersion { get; set; }


        /// <summary>
        /// Specifies the status of each system app on the Cluster
        /// </summary>
        /// <value>Specifies the status of each system app on the Cluster</value>
        [DataMember(Name="systemAppStatus", EmitDefaultValue=false)]
        public List<SystemAppStatusResult> SystemAppStatus { get; set; }

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
            return this.Equals(input as ClusterStatusResult);
        }

        /// <summary>
        /// Returns true if ClusterStatusResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterStatusResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterStatusResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.CurrentOperation == input.CurrentOperation ||
                    (this.CurrentOperation != null &&
                    this.CurrentOperation.Equals(input.CurrentOperation))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NodeStatuses == input.NodeStatuses ||
                    this.NodeStatuses != null &&
                    this.NodeStatuses.Equals(input.NodeStatuses)
                ) && 
                (
                    this.RemovalState == input.RemovalState ||
                    (this.RemovalState != null &&
                    this.RemovalState.Equals(input.RemovalState))
                ) && 
                (
                    this.ServicesSynced == input.ServicesSynced ||
                    (this.ServicesSynced != null &&
                    this.ServicesSynced.Equals(input.ServicesSynced))
                ) && 
                (
                    this.SoftwareVersion == input.SoftwareVersion ||
                    (this.SoftwareVersion != null &&
                    this.SoftwareVersion.Equals(input.SoftwareVersion))
                ) && 
                (
                    this.StoppedServices == input.StoppedServices ||
                    this.StoppedServices != null &&
                    this.StoppedServices.Equals(input.StoppedServices)
                ) && 
                (
                    this.SystemAppStatus == input.SystemAppStatus ||
                    this.SystemAppStatus != null &&
                    this.SystemAppStatus.Equals(input.SystemAppStatus)
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.CurrentOperation != null)
                    hashCode = hashCode * 59 + this.CurrentOperation.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeStatuses != null)
                    hashCode = hashCode * 59 + this.NodeStatuses.GetHashCode();
                if (this.RemovalState != null)
                    hashCode = hashCode * 59 + this.RemovalState.GetHashCode();
                if (this.ServicesSynced != null)
                    hashCode = hashCode * 59 + this.ServicesSynced.GetHashCode();
                if (this.SoftwareVersion != null)
                    hashCode = hashCode * 59 + this.SoftwareVersion.GetHashCode();
                if (this.StoppedServices != null)
                    hashCode = hashCode * 59 + this.StoppedServices.GetHashCode();
                if (this.SystemAppStatus != null)
                    hashCode = hashCode * 59 + this.SystemAppStatus.GetHashCode();
                return hashCode;
            }
        }

    }

}

