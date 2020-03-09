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
    /// Specifies the parameters needed to change the state of one or more services running on the Cluster.
    /// </summary>
    [DataContract]
    public partial class ChangeServiceStateParameters :  IEquatable<ChangeServiceStateParameters>
    {
        /// <summary>
        /// Specifies the action to take on the specified service. &#39;kStop&#39; indicates that the specified services will be stopped. &#39;kStart&#39; indicates that the specified services will be started. &#39;kRestart&#39; indicates that the specified services will be restarted.
        /// </summary>
        /// <value>Specifies the action to take on the specified service. &#39;kStop&#39; indicates that the specified services will be stopped. &#39;kStart&#39; indicates that the specified services will be started. &#39;kRestart&#39; indicates that the specified services will be restarted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum KStop for value: kStop
            /// </summary>
            [EnumMember(Value = "kStop")]
            KStop = 1,

            /// <summary>
            /// Enum KStart for value: kStart
            /// </summary>
            [EnumMember(Value = "kStart")]
            KStart = 2,

            /// <summary>
            /// Enum KRestart for value: kRestart
            /// </summary>
            [EnumMember(Value = "kRestart")]
            KRestart = 3

        }

        /// <summary>
        /// Specifies the action to take on the specified service. &#39;kStop&#39; indicates that the specified services will be stopped. &#39;kStart&#39; indicates that the specified services will be started. &#39;kRestart&#39; indicates that the specified services will be restarted.
        /// </summary>
        /// <value>Specifies the action to take on the specified service. &#39;kStop&#39; indicates that the specified services will be stopped. &#39;kStart&#39; indicates that the specified services will be started. &#39;kRestart&#39; indicates that the specified services will be restarted.</value>
        [DataMember(Name="action", EmitDefaultValue=true)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Defines Services
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServicesEnum
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
        /// Specifies the list of services to take the specified action on. If none are specified, all Cluster services will be affected. It should also be noted that some Cluster services are not stoppable and may not be affected by the action specified. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection.
        /// </summary>
        /// <value>Specifies the list of services to take the specified action on. If none are specified, all Cluster services will be affected. It should also be noted that some Cluster services are not stoppable and may not be affected by the action specified. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection.</value>
        [DataMember(Name="services", EmitDefaultValue=true)]
        public List<ServicesEnum> Services { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeServiceStateParameters" /> class.
        /// </summary>
        /// <param name="action">Specifies the action to take on the specified service. &#39;kStop&#39; indicates that the specified services will be stopped. &#39;kStart&#39; indicates that the specified services will be started. &#39;kRestart&#39; indicates that the specified services will be restarted..</param>
        /// <param name="services">Specifies the list of services to take the specified action on. If none are specified, all Cluster services will be affected. It should also be noted that some Cluster services are not stoppable and may not be affected by the action specified. &#39;kApollo&#39; is a service for reclaiming freed disk sectors on Nodes in the SnapFS distributed file system. &#39;kBridge&#39; is a service for managing the SnapFS distributed file system. &#39;kGenie&#39; is a service that is responsible for monitoring hardware health on the Cluster. &#39;kGenieGofer&#39; is a service that links the Genie service to other services on the Cluster. &#39;kMagneto&#39; is the data protection service of the Cohesity Data Platform. &#39;kIris&#39; is the service which serves REST API calls to the UI, CLI, and any scripts written by customers. &#39;kIrisProxy&#39; is a service that links the Iris service to other services on the Cluster. &#39;kScribe&#39; is the service responsible for storing filesystem metadata. &#39;kStats&#39; is the service that is responsible for retrieving and aggregating disk metrics across the Cluster. &#39;kYoda&#39; is an elastic search indexing service. &#39;kAlerts&#39; is a publisher and subscribing service for alerts. &#39;kKeychain&#39; is a service for managing disk encryption keys. &#39;kLogWatcher&#39; is a service that scans the log directory and reduces the number of logs if required. &#39;kStatsCollector&#39; is a service that periodically logs system stats. &#39;kGandalf&#39; is a distributed lock service and coordination manager. &#39;kNexus&#39; indicates the Nexus service. This is the service that is responsible for creation of Clusters and configuration of Nodes and networking. &#39;kNexusProxy&#39; is a service that links the Nexus service to other services on the Cluster. &#39;kStorageProxy&#39; is a service for accessing data on external entities. &#39;kTricorder&#39; is a diagnostic health testing service for Clusters. &#39;kRtClient&#39; is a reverse tunneling client service. &#39;kVaultProxy&#39; is a service for managing external targets that Clusters can be backed up to. &#39;kSmbProxy&#39; is an SMB protocol service. &#39;kBridgeProxy&#39; is the service that links the Bridge service to other services on the Cluster. &#39;kLibrarian&#39; is an elastic search indexing service. &#39;kGroot&#39; is a service for managing replication of SQL databases across multiple nodes in a Cluster. &#39;kEagleAgent&#39; is a service that is responsible for retrieving information on Cluster health. &#39;kAthena&#39; is a service for running distributed containerized applications on the Cohesity Data Platform. &#39;kBifrostBroker&#39; is a service for communicating with the Cohesity proxies for multitenancy. &#39;kSmb2Proxy&#39; is a new SMB protocol service. &#39;kOs&#39; can be specified in order to do a full reboot. &#39;kAtom&#39; is a service for receiving data for the Continuous Data Protection..</param>
        public ChangeServiceStateParameters(ActionEnum? action = default(ActionEnum?), List<ServicesEnum> services = default(List<ServicesEnum>))
        {
            this.Action = action;
            this.Services = services;
            this.Action = action;
            this.Services = services;
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
            return this.Equals(input as ChangeServiceStateParameters);
        }

        /// <summary>
        /// Returns true if ChangeServiceStateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeServiceStateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeServiceStateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services.SequenceEqual(input.Services)
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Services.GetHashCode();
                return hashCode;
            }
        }

    }

}

