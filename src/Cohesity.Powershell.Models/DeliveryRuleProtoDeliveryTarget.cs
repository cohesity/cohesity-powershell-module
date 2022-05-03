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
    /// Delivery targets for the notifications. For now only email delivery is supported. In future, we can potentially add other delivery targets such as paging, SMS, etc.
    /// </summary>
    [DataContract]
    public partial class DeliveryRuleProtoDeliveryTarget :  IEquatable<DeliveryRuleProtoDeliveryTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryRuleProtoDeliveryTarget" /> class.
        /// </summary>
        /// <param name="emailAddress">List of email addresses to send notifications..</param>
        /// <param name="emailRecipientType">emailRecipientType.</param>
        /// <param name="externalApiCurlOptions">Specifies the curl options used to invoke above rest external api..</param>
        /// <param name="externalApiUrl">Specifies the external api to be invoked when an alert matching this rule is raised..</param>
        /// <param name="locale">Locale for the delivery target..</param>
        /// <param name="snmpNotification">Need to send snmp notification for matched alerts..</param>
        /// <param name="syslogNotification">Need to write syslog for matched alerts..</param>
        /// <param name="tenantId">Tenant who has been assigned this target. This field is not populated within AlertsDataProto persisted in Gandalf. This is a convenience field and is populated on the fly by the Alerts component for delivery targets in the delivery_target_list within AlertProto. This field is utilized by NotificationDeliveryHelper to group delivery targets so that we could send out a single email to all the email addresses registered with the same locale by a given tenant or by the SP admin. Another approach could have been to use an internal object, but since the AlertProto contains a list of type DeliveryTarget, this field has been added to make it convenient to pass around an AlertProto object..</param>
        public DeliveryRuleProtoDeliveryTarget(string emailAddress = default(string), int? emailRecipientType = default(int?), string externalApiCurlOptions = default(string), string externalApiUrl = default(string), string locale = default(string), bool? snmpNotification = default(bool?), bool? syslogNotification = default(bool?), string tenantId = default(string))
        {
            this.EmailAddress = emailAddress;
            this.EmailRecipientType = emailRecipientType;
            this.ExternalApiCurlOptions = externalApiCurlOptions;
            this.ExternalApiUrl = externalApiUrl;
            this.Locale = locale;
            this.SnmpNotification = snmpNotification;
            this.SyslogNotification = syslogNotification;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// List of email addresses to send notifications.
        /// </summary>
        /// <value>List of email addresses to send notifications.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets EmailRecipientType
        /// </summary>
        [DataMember(Name="emailRecipientType", EmitDefaultValue=false)]
        public int? EmailRecipientType { get; set; }

        /// <summary>
        /// Specifies the curl options used to invoke above rest external api.
        /// </summary>
        /// <value>Specifies the curl options used to invoke above rest external api.</value>
        [DataMember(Name="externalApiCurlOptions", EmitDefaultValue=false)]
        public string ExternalApiCurlOptions { get; set; }

        /// <summary>
        /// Specifies the external api to be invoked when an alert matching this rule is raised.
        /// </summary>
        /// <value>Specifies the external api to be invoked when an alert matching this rule is raised.</value>
        [DataMember(Name="externalApiUrl", EmitDefaultValue=false)]
        public string ExternalApiUrl { get; set; }

        /// <summary>
        /// Locale for the delivery target.
        /// </summary>
        /// <value>Locale for the delivery target.</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Need to send snmp notification for matched alerts.
        /// </summary>
        /// <value>Need to send snmp notification for matched alerts.</value>
        [DataMember(Name="snmpNotification", EmitDefaultValue=false)]
        public bool? SnmpNotification { get; set; }

        /// <summary>
        /// Need to write syslog for matched alerts.
        /// </summary>
        /// <value>Need to write syslog for matched alerts.</value>
        [DataMember(Name="syslogNotification", EmitDefaultValue=false)]
        public bool? SyslogNotification { get; set; }

        /// <summary>
        /// Tenant who has been assigned this target. This field is not populated within AlertsDataProto persisted in Gandalf. This is a convenience field and is populated on the fly by the Alerts component for delivery targets in the delivery_target_list within AlertProto. This field is utilized by NotificationDeliveryHelper to group delivery targets so that we could send out a single email to all the email addresses registered with the same locale by a given tenant or by the SP admin. Another approach could have been to use an internal object, but since the AlertProto contains a list of type DeliveryTarget, this field has been added to make it convenient to pass around an AlertProto object.
        /// </summary>
        /// <value>Tenant who has been assigned this target. This field is not populated within AlertsDataProto persisted in Gandalf. This is a convenience field and is populated on the fly by the Alerts component for delivery targets in the delivery_target_list within AlertProto. This field is utilized by NotificationDeliveryHelper to group delivery targets so that we could send out a single email to all the email addresses registered with the same locale by a given tenant or by the SP admin. Another approach could have been to use an internal object, but since the AlertProto contains a list of type DeliveryTarget, this field has been added to make it convenient to pass around an AlertProto object.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

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
            return this.Equals(input as DeliveryRuleProtoDeliveryTarget);
        }

        /// <summary>
        /// Returns true if DeliveryRuleProtoDeliveryTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryRuleProtoDeliveryTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryRuleProtoDeliveryTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.EmailRecipientType == input.EmailRecipientType ||
                    (this.EmailRecipientType != null &&
                    this.EmailRecipientType.Equals(input.EmailRecipientType))
                ) && 
                (
                    this.ExternalApiCurlOptions == input.ExternalApiCurlOptions ||
                    (this.ExternalApiCurlOptions != null &&
                    this.ExternalApiCurlOptions.Equals(input.ExternalApiCurlOptions))
                ) && 
                (
                    this.ExternalApiUrl == input.ExternalApiUrl ||
                    (this.ExternalApiUrl != null &&
                    this.ExternalApiUrl.Equals(input.ExternalApiUrl))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.SnmpNotification == input.SnmpNotification ||
                    (this.SnmpNotification != null &&
                    this.SnmpNotification.Equals(input.SnmpNotification))
                ) && 
                (
                    this.SyslogNotification == input.SyslogNotification ||
                    (this.SyslogNotification != null &&
                    this.SyslogNotification.Equals(input.SyslogNotification))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.EmailRecipientType != null)
                    hashCode = hashCode * 59 + this.EmailRecipientType.GetHashCode();
                if (this.ExternalApiCurlOptions != null)
                    hashCode = hashCode * 59 + this.ExternalApiCurlOptions.GetHashCode();
                if (this.ExternalApiUrl != null)
                    hashCode = hashCode * 59 + this.ExternalApiUrl.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.SnmpNotification != null)
                    hashCode = hashCode * 59 + this.SnmpNotification.GetHashCode();
                if (this.SyslogNotification != null)
                    hashCode = hashCode * 59 + this.SyslogNotification.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

