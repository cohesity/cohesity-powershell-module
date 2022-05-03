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
    /// RestoreO365GroupsParamsMSGroupInfo
    /// </summary>
    [DataContract]
    public partial class RestoreO365GroupsParamsMSGroupInfo :  IEquatable<RestoreO365GroupsParamsMSGroupInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreO365GroupsParamsMSGroupInfo" /> class.
        /// </summary>
        /// <param name="groupGranularParams">groupGranularParams.</param>
        /// <param name="isFullGroupRequired">Specify if the entire Group (mailbox + site) is to be restored..</param>
        /// <param name="mailboxRestoreType">Whether mailbox restore is full or granular..</param>
        /// <param name="_object">_object.</param>
        /// <param name="siteRestoreType">Whether site restore is full or granular..</param>
        public RestoreO365GroupsParamsMSGroupInfo(RestoreO365GroupsParamsGroupGranularParams groupGranularParams = default(RestoreO365GroupsParamsGroupGranularParams), bool? isFullGroupRequired = default(bool?), int? mailboxRestoreType = default(int?), RestoreObject _object = default(RestoreObject), int? siteRestoreType = default(int?))
        {
            this.GroupGranularParams = groupGranularParams;
            this.IsFullGroupRequired = isFullGroupRequired;
            this.MailboxRestoreType = mailboxRestoreType;
            this.Object = _object;
            this.SiteRestoreType = siteRestoreType;
        }
        
        /// <summary>
        /// Gets or Sets GroupGranularParams
        /// </summary>
        [DataMember(Name="groupGranularParams", EmitDefaultValue=false)]
        public RestoreO365GroupsParamsGroupGranularParams GroupGranularParams { get; set; }

        /// <summary>
        /// Specify if the entire Group (mailbox + site) is to be restored.
        /// </summary>
        /// <value>Specify if the entire Group (mailbox + site) is to be restored.</value>
        [DataMember(Name="isFullGroupRequired", EmitDefaultValue=false)]
        public bool? IsFullGroupRequired { get; set; }

        /// <summary>
        /// Whether mailbox restore is full or granular.
        /// </summary>
        /// <value>Whether mailbox restore is full or granular.</value>
        [DataMember(Name="mailboxRestoreType", EmitDefaultValue=false)]
        public int? MailboxRestoreType { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public RestoreObject Object { get; set; }

        /// <summary>
        /// Whether site restore is full or granular.
        /// </summary>
        /// <value>Whether site restore is full or granular.</value>
        [DataMember(Name="siteRestoreType", EmitDefaultValue=false)]
        public int? SiteRestoreType { get; set; }

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
            return this.Equals(input as RestoreO365GroupsParamsMSGroupInfo);
        }

        /// <summary>
        /// Returns true if RestoreO365GroupsParamsMSGroupInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreO365GroupsParamsMSGroupInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreO365GroupsParamsMSGroupInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupGranularParams == input.GroupGranularParams ||
                    (this.GroupGranularParams != null &&
                    this.GroupGranularParams.Equals(input.GroupGranularParams))
                ) && 
                (
                    this.IsFullGroupRequired == input.IsFullGroupRequired ||
                    (this.IsFullGroupRequired != null &&
                    this.IsFullGroupRequired.Equals(input.IsFullGroupRequired))
                ) && 
                (
                    this.MailboxRestoreType == input.MailboxRestoreType ||
                    (this.MailboxRestoreType != null &&
                    this.MailboxRestoreType.Equals(input.MailboxRestoreType))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.SiteRestoreType == input.SiteRestoreType ||
                    (this.SiteRestoreType != null &&
                    this.SiteRestoreType.Equals(input.SiteRestoreType))
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
                if (this.GroupGranularParams != null)
                    hashCode = hashCode * 59 + this.GroupGranularParams.GetHashCode();
                if (this.IsFullGroupRequired != null)
                    hashCode = hashCode * 59 + this.IsFullGroupRequired.GetHashCode();
                if (this.MailboxRestoreType != null)
                    hashCode = hashCode * 59 + this.MailboxRestoreType.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.SiteRestoreType != null)
                    hashCode = hashCode * 59 + this.SiteRestoreType.GetHashCode();
                return hashCode;
            }
        }

    }

}

