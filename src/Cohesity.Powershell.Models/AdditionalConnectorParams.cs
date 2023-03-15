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
        /// <param name="maxVmwareHttpSessions">Max http sessions per context for VMWare vAPI calls..</param>
        /// <param name="o365EmulatorEntityInfo">A token used only in O365 Emulator identifying the information of number of Users, Sites, Groups, Teams &amp; Public Folders and their ids..</param>
        /// <param name="o365Region">o365Region.</param>
        /// <param name="registeredEntitySfdcParams">registeredEntitySfdcParams.</param>
        /// <param name="useGetSearchableMailboxesApi">Wheather to use GetSearchableMailboxes EWS API while descovering User Mailboxes or not..</param>
        /// <param name="useOutlookEwsOauth">Whether OAuth should be used for authentication with EWS API (outlook backup), applicable only for Exchange Online..</param>
        public AdditionalConnectorParams(int? maxVmwareHttpSessions = default(int?), string o365EmulatorEntityInfo = default(string), O365RegionProto o365Region = default(O365RegionProto), RegisteredEntitySfdcParams registeredEntitySfdcParams = default(RegisteredEntitySfdcParams), bool? useGetSearchableMailboxesApi = default(bool?), bool? useOutlookEwsOauth = default(bool?))
        {
            this.MaxVmwareHttpSessions = maxVmwareHttpSessions;
            this.O365EmulatorEntityInfo = o365EmulatorEntityInfo;
            this.UseGetSearchableMailboxesApi = useGetSearchableMailboxesApi;
            this.UseOutlookEwsOauth = useOutlookEwsOauth;
            this.MaxVmwareHttpSessions = maxVmwareHttpSessions;
            this.O365EmulatorEntityInfo = o365EmulatorEntityInfo;
            this.O365Region = o365Region;
            this.RegisteredEntitySfdcParams = registeredEntitySfdcParams;
            this.UseGetSearchableMailboxesApi = useGetSearchableMailboxesApi;
            this.UseOutlookEwsOauth = useOutlookEwsOauth;
        }
        
        /// <summary>
        /// Max http sessions per context for VMWare vAPI calls.
        /// </summary>
        /// <value>Max http sessions per context for VMWare vAPI calls.</value>
        [DataMember(Name="maxVmwareHttpSessions", EmitDefaultValue=true)]
        public int? MaxVmwareHttpSessions { get; set; }

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
        /// Gets or Sets RegisteredEntitySfdcParams
        /// </summary>
        [DataMember(Name="registeredEntitySfdcParams", EmitDefaultValue=false)]
        public RegisteredEntitySfdcParams RegisteredEntitySfdcParams { get; set; }

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
                    this.MaxVmwareHttpSessions == input.MaxVmwareHttpSessions ||
                    (this.MaxVmwareHttpSessions != null &&
                    this.MaxVmwareHttpSessions.Equals(input.MaxVmwareHttpSessions))
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
                    this.RegisteredEntitySfdcParams == input.RegisteredEntitySfdcParams ||
                    (this.RegisteredEntitySfdcParams != null &&
                    this.RegisteredEntitySfdcParams.Equals(input.RegisteredEntitySfdcParams))
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
                if (this.MaxVmwareHttpSessions != null)
                    hashCode = hashCode * 59 + this.MaxVmwareHttpSessions.GetHashCode();
                if (this.O365EmulatorEntityInfo != null)
                    hashCode = hashCode * 59 + this.O365EmulatorEntityInfo.GetHashCode();
                if (this.O365Region != null)
                    hashCode = hashCode * 59 + this.O365Region.GetHashCode();
                if (this.RegisteredEntitySfdcParams != null)
                    hashCode = hashCode * 59 + this.RegisteredEntitySfdcParams.GetHashCode();
                if (this.UseGetSearchableMailboxesApi != null)
                    hashCode = hashCode * 59 + this.UseGetSearchableMailboxesApi.GetHashCode();
                if (this.UseOutlookEwsOauth != null)
                    hashCode = hashCode * 59 + this.UseOutlookEwsOauth.GetHashCode();
                return hashCode;
            }
        }

    }

}

