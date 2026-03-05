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
    /// Message that encapsulates the additional connector params to establish a connection with a particular environment.
    /// </summary>
    [DataContract]
    public partial class AdditionalConnectorParams :  IEquatable<AdditionalConnectorParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalConnectorParams" /> class.
        /// </summary>
        /// <param name="acropolisParams">acropolisParams.</param>
        /// <param name="connectorContextVersion">Connector context version of source entity. In the context of cluster upgrade this field is used to indicate abandoning earlier version connector context when updated magneto is expecting higher version..</param>
        /// <param name="disableCertCache">If set, the cert_cache_ in ConnectorCertificateValidator will not be used for this connector conext. Specific to agent connector contexts..</param>
        /// <param name="enforceHostnameVerification">This proto will dictate whether hostname verification needs to be done for agent based grpc connections. Currently, this will be applicable for non-clustered agent entities. NOTE: hostname verification will not be done magneto master, as it will need to upgrade the agent certs if they dont have SAN fields..</param>
        /// <param name="ewsExchangeParams">ewsExchangeParams.</param>
        /// <param name="graphTokenEndpoint">Endpoint URL for querying the MS graph token fetched from openid-configuration..</param>
        /// <param name="maxVmwareHttpSessions">Max http sessions per context for VMWare vAPI calls..</param>
        /// <param name="msgraphHost">Endpoint or host url where all the graph calls are made. It is fetched from openid-configuration..</param>
        /// <param name="o365EmulatorEntityInfo">A token used only in O365 Emulator identifying the information of number of Users, Sites, Groups, Teams &amp; Public Folders and their ids..</param>
        /// <param name="o365Region">o365Region.</param>
        /// <param name="outlookSkipCreatingAutodiscoverProxy">Whether we should skip creating autodiscove proxy. This is needed only during fetching eh and in public folder backups setup..</param>
        /// <param name="registeredEntitySfdcParams">registeredEntitySfdcParams.</param>
        /// <param name="useConnectorGroupId">Whether connector group id should be used for certain workflows. In CCS env where SaaS connectors for one geo location cannot access ESXi hosts for a different geo location, explicitly setting connector group id forces to use the connector group corresponding to the rigel which has connectivity to the ESXi host. Currently this is being leveraged by VMware tools based FLR for curl client calls..</param>
        /// <param name="useGetSearchableMailboxesApi">Wheather to use GetSearchableMailboxes EWS API while descovering User Mailboxes or not..</param>
        /// <param name="useOutlookEwsOauth">Whether OAuth should be used for authentication with EWS API (outlook backup), applicable only for Exchange Online..</param>
        public AdditionalConnectorParams(AdditionalAcropolisConnectorParams acropolisParams = default(AdditionalAcropolisConnectorParams), int? connectorContextVersion = default(int?), bool? disableCertCache = default(bool?), bool? enforceHostnameVerification = default(bool?), AdditionalEwsExchangeConnectorParams ewsExchangeParams = default(AdditionalEwsExchangeConnectorParams), string graphTokenEndpoint = default(string), int? maxVmwareHttpSessions = default(int?), string msgraphHost = default(string), string o365EmulatorEntityInfo = default(string), O365RegionProto o365Region = default(O365RegionProto), bool? outlookSkipCreatingAutodiscoverProxy = default(bool?), RegisteredEntitySfdcParams registeredEntitySfdcParams = default(RegisteredEntitySfdcParams), bool? useConnectorGroupId = default(bool?), bool? useGetSearchableMailboxesApi = default(bool?), bool? useOutlookEwsOauth = default(bool?))
        {
            this.ConnectorContextVersion = connectorContextVersion;
            this.DisableCertCache = disableCertCache;
            this.EnforceHostnameVerification = enforceHostnameVerification;
            this.GraphTokenEndpoint = graphTokenEndpoint;
            this.MaxVmwareHttpSessions = maxVmwareHttpSessions;
            this.MsgraphHost = msgraphHost;
            this.O365EmulatorEntityInfo = o365EmulatorEntityInfo;
            this.OutlookSkipCreatingAutodiscoverProxy = outlookSkipCreatingAutodiscoverProxy;
            this.UseConnectorGroupId = useConnectorGroupId;
            this.UseGetSearchableMailboxesApi = useGetSearchableMailboxesApi;
            this.UseOutlookEwsOauth = useOutlookEwsOauth;
            this.AcropolisParams = acropolisParams;
            this.ConnectorContextVersion = connectorContextVersion;
            this.DisableCertCache = disableCertCache;
            this.EnforceHostnameVerification = enforceHostnameVerification;
            this.EwsExchangeParams = ewsExchangeParams;
            this.GraphTokenEndpoint = graphTokenEndpoint;
            this.MaxVmwareHttpSessions = maxVmwareHttpSessions;
            this.MsgraphHost = msgraphHost;
            this.O365EmulatorEntityInfo = o365EmulatorEntityInfo;
            this.O365Region = o365Region;
            this.OutlookSkipCreatingAutodiscoverProxy = outlookSkipCreatingAutodiscoverProxy;
            this.RegisteredEntitySfdcParams = registeredEntitySfdcParams;
            this.UseConnectorGroupId = useConnectorGroupId;
            this.UseGetSearchableMailboxesApi = useGetSearchableMailboxesApi;
            this.UseOutlookEwsOauth = useOutlookEwsOauth;
        }
        
        /// <summary>
        /// Gets or Sets AcropolisParams
        /// </summary>
        [DataMember(Name="acropolisParams", EmitDefaultValue=false)]
        public AdditionalAcropolisConnectorParams AcropolisParams { get; set; }

        /// <summary>
        /// Connector context version of source entity. In the context of cluster upgrade this field is used to indicate abandoning earlier version connector context when updated magneto is expecting higher version.
        /// </summary>
        /// <value>Connector context version of source entity. In the context of cluster upgrade this field is used to indicate abandoning earlier version connector context when updated magneto is expecting higher version.</value>
        [DataMember(Name="connectorContextVersion", EmitDefaultValue=true)]
        public int? ConnectorContextVersion { get; set; }

        /// <summary>
        /// If set, the cert_cache_ in ConnectorCertificateValidator will not be used for this connector conext. Specific to agent connector contexts.
        /// </summary>
        /// <value>If set, the cert_cache_ in ConnectorCertificateValidator will not be used for this connector conext. Specific to agent connector contexts.</value>
        [DataMember(Name="disableCertCache", EmitDefaultValue=true)]
        public bool? DisableCertCache { get; set; }

        /// <summary>
        /// This proto will dictate whether hostname verification needs to be done for agent based grpc connections. Currently, this will be applicable for non-clustered agent entities. NOTE: hostname verification will not be done magneto master, as it will need to upgrade the agent certs if they dont have SAN fields.
        /// </summary>
        /// <value>This proto will dictate whether hostname verification needs to be done for agent based grpc connections. Currently, this will be applicable for non-clustered agent entities. NOTE: hostname verification will not be done magneto master, as it will need to upgrade the agent certs if they dont have SAN fields.</value>
        [DataMember(Name="enforceHostnameVerification", EmitDefaultValue=true)]
        public bool? EnforceHostnameVerification { get; set; }

        /// <summary>
        /// Gets or Sets EwsExchangeParams
        /// </summary>
        [DataMember(Name="ewsExchangeParams", EmitDefaultValue=false)]
        public AdditionalEwsExchangeConnectorParams EwsExchangeParams { get; set; }

        /// <summary>
        /// Endpoint URL for querying the MS graph token fetched from openid-configuration.
        /// </summary>
        /// <value>Endpoint URL for querying the MS graph token fetched from openid-configuration.</value>
        [DataMember(Name="graphTokenEndpoint", EmitDefaultValue=true)]
        public string GraphTokenEndpoint { get; set; }

        /// <summary>
        /// Max http sessions per context for VMWare vAPI calls.
        /// </summary>
        /// <value>Max http sessions per context for VMWare vAPI calls.</value>
        [DataMember(Name="maxVmwareHttpSessions", EmitDefaultValue=true)]
        public int? MaxVmwareHttpSessions { get; set; }

        /// <summary>
        /// Endpoint or host url where all the graph calls are made. It is fetched from openid-configuration.
        /// </summary>
        /// <value>Endpoint or host url where all the graph calls are made. It is fetched from openid-configuration.</value>
        [DataMember(Name="msgraphHost", EmitDefaultValue=true)]
        public string MsgraphHost { get; set; }

        /// <summary>
        /// A token used only in O365 Emulator identifying the information of number of Users, Sites, Groups, Teams &amp; Public Folders and their ids.
        /// </summary>
        /// <value>A token used only in O365 Emulator identifying the information of number of Users, Sites, Groups, Teams &amp; Public Folders and their ids.</value>
        [DataMember(Name="o365EmulatorEntityInfo", EmitDefaultValue=true)]
        public string O365EmulatorEntityInfo { get; set; }

        /// <summary>
        /// Gets or Sets O365Region
        /// </summary>
        [DataMember(Name="o365Region", EmitDefaultValue=false)]
        public O365RegionProto O365Region { get; set; }

        /// <summary>
        /// Whether we should skip creating autodiscove proxy. This is needed only during fetching eh and in public folder backups setup.
        /// </summary>
        /// <value>Whether we should skip creating autodiscove proxy. This is needed only during fetching eh and in public folder backups setup.</value>
        [DataMember(Name="outlookSkipCreatingAutodiscoverProxy", EmitDefaultValue=true)]
        public bool? OutlookSkipCreatingAutodiscoverProxy { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredEntitySfdcParams
        /// </summary>
        [DataMember(Name="registeredEntitySfdcParams", EmitDefaultValue=false)]
        public RegisteredEntitySfdcParams RegisteredEntitySfdcParams { get; set; }

        /// <summary>
        /// Whether connector group id should be used for certain workflows. In CCS env where SaaS connectors for one geo location cannot access ESXi hosts for a different geo location, explicitly setting connector group id forces to use the connector group corresponding to the rigel which has connectivity to the ESXi host. Currently this is being leveraged by VMware tools based FLR for curl client calls.
        /// </summary>
        /// <value>Whether connector group id should be used for certain workflows. In CCS env where SaaS connectors for one geo location cannot access ESXi hosts for a different geo location, explicitly setting connector group id forces to use the connector group corresponding to the rigel which has connectivity to the ESXi host. Currently this is being leveraged by VMware tools based FLR for curl client calls.</value>
        [DataMember(Name="useConnectorGroupId", EmitDefaultValue=true)]
        public bool? UseConnectorGroupId { get; set; }

        /// <summary>
        /// Wheather to use GetSearchableMailboxes EWS API while descovering User Mailboxes or not.
        /// </summary>
        /// <value>Wheather to use GetSearchableMailboxes EWS API while descovering User Mailboxes or not.</value>
        [DataMember(Name="useGetSearchableMailboxesApi", EmitDefaultValue=true)]
        public bool? UseGetSearchableMailboxesApi { get; set; }

        /// <summary>
        /// Whether OAuth should be used for authentication with EWS API (outlook backup), applicable only for Exchange Online.
        /// </summary>
        /// <value>Whether OAuth should be used for authentication with EWS API (outlook backup), applicable only for Exchange Online.</value>
        [DataMember(Name="useOutlookEwsOauth", EmitDefaultValue=true)]
        public bool? UseOutlookEwsOauth { get; set; }

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
            return this.Equals(input as AdditionalConnectorParams);
        }

        /// <summary>
        /// Returns true if AdditionalConnectorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalConnectorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalConnectorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisParams == input.AcropolisParams ||
                    (this.AcropolisParams != null &&
                    this.AcropolisParams.Equals(input.AcropolisParams))
                ) && 
                (
                    this.ConnectorContextVersion == input.ConnectorContextVersion ||
                    (this.ConnectorContextVersion != null &&
                    this.ConnectorContextVersion.Equals(input.ConnectorContextVersion))
                ) && 
                (
                    this.DisableCertCache == input.DisableCertCache ||
                    (this.DisableCertCache != null &&
                    this.DisableCertCache.Equals(input.DisableCertCache))
                ) && 
                (
                    this.EnforceHostnameVerification == input.EnforceHostnameVerification ||
                    (this.EnforceHostnameVerification != null &&
                    this.EnforceHostnameVerification.Equals(input.EnforceHostnameVerification))
                ) && 
                (
                    this.EwsExchangeParams == input.EwsExchangeParams ||
                    (this.EwsExchangeParams != null &&
                    this.EwsExchangeParams.Equals(input.EwsExchangeParams))
                ) && 
                (
                    this.GraphTokenEndpoint == input.GraphTokenEndpoint ||
                    (this.GraphTokenEndpoint != null &&
                    this.GraphTokenEndpoint.Equals(input.GraphTokenEndpoint))
                ) && 
                (
                    this.MaxVmwareHttpSessions == input.MaxVmwareHttpSessions ||
                    (this.MaxVmwareHttpSessions != null &&
                    this.MaxVmwareHttpSessions.Equals(input.MaxVmwareHttpSessions))
                ) && 
                (
                    this.MsgraphHost == input.MsgraphHost ||
                    (this.MsgraphHost != null &&
                    this.MsgraphHost.Equals(input.MsgraphHost))
                ) && 
                (
                    this.O365EmulatorEntityInfo == input.O365EmulatorEntityInfo ||
                    (this.O365EmulatorEntityInfo != null &&
                    this.O365EmulatorEntityInfo.Equals(input.O365EmulatorEntityInfo))
                ) && 
                (
                    this.O365Region == input.O365Region ||
                    (this.O365Region != null &&
                    this.O365Region.Equals(input.O365Region))
                ) && 
                (
                    this.OutlookSkipCreatingAutodiscoverProxy == input.OutlookSkipCreatingAutodiscoverProxy ||
                    (this.OutlookSkipCreatingAutodiscoverProxy != null &&
                    this.OutlookSkipCreatingAutodiscoverProxy.Equals(input.OutlookSkipCreatingAutodiscoverProxy))
                ) && 
                (
                    this.RegisteredEntitySfdcParams == input.RegisteredEntitySfdcParams ||
                    (this.RegisteredEntitySfdcParams != null &&
                    this.RegisteredEntitySfdcParams.Equals(input.RegisteredEntitySfdcParams))
                ) && 
                (
                    this.UseConnectorGroupId == input.UseConnectorGroupId ||
                    (this.UseConnectorGroupId != null &&
                    this.UseConnectorGroupId.Equals(input.UseConnectorGroupId))
                ) && 
                (
                    this.UseGetSearchableMailboxesApi == input.UseGetSearchableMailboxesApi ||
                    (this.UseGetSearchableMailboxesApi != null &&
                    this.UseGetSearchableMailboxesApi.Equals(input.UseGetSearchableMailboxesApi))
                ) && 
                (
                    this.UseOutlookEwsOauth == input.UseOutlookEwsOauth ||
                    (this.UseOutlookEwsOauth != null &&
                    this.UseOutlookEwsOauth.Equals(input.UseOutlookEwsOauth))
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
                if (this.AcropolisParams != null)
                    hashCode = hashCode * 59 + this.AcropolisParams.GetHashCode();
                if (this.ConnectorContextVersion != null)
                    hashCode = hashCode * 59 + this.ConnectorContextVersion.GetHashCode();
                if (this.DisableCertCache != null)
                    hashCode = hashCode * 59 + this.DisableCertCache.GetHashCode();
                if (this.EnforceHostnameVerification != null)
                    hashCode = hashCode * 59 + this.EnforceHostnameVerification.GetHashCode();
                if (this.EwsExchangeParams != null)
                    hashCode = hashCode * 59 + this.EwsExchangeParams.GetHashCode();
                if (this.GraphTokenEndpoint != null)
                    hashCode = hashCode * 59 + this.GraphTokenEndpoint.GetHashCode();
                if (this.MaxVmwareHttpSessions != null)
                    hashCode = hashCode * 59 + this.MaxVmwareHttpSessions.GetHashCode();
                if (this.MsgraphHost != null)
                    hashCode = hashCode * 59 + this.MsgraphHost.GetHashCode();
                if (this.O365EmulatorEntityInfo != null)
                    hashCode = hashCode * 59 + this.O365EmulatorEntityInfo.GetHashCode();
                if (this.O365Region != null)
                    hashCode = hashCode * 59 + this.O365Region.GetHashCode();
                if (this.OutlookSkipCreatingAutodiscoverProxy != null)
                    hashCode = hashCode * 59 + this.OutlookSkipCreatingAutodiscoverProxy.GetHashCode();
                if (this.RegisteredEntitySfdcParams != null)
                    hashCode = hashCode * 59 + this.RegisteredEntitySfdcParams.GetHashCode();
                if (this.UseConnectorGroupId != null)
                    hashCode = hashCode * 59 + this.UseConnectorGroupId.GetHashCode();
                if (this.UseGetSearchableMailboxesApi != null)
                    hashCode = hashCode * 59 + this.UseGetSearchableMailboxesApi.GetHashCode();
                if (this.UseOutlookEwsOauth != null)
                    hashCode = hashCode * 59 + this.UseOutlookEwsOauth.GetHashCode();
                return hashCode;
            }
        }

    }

}

