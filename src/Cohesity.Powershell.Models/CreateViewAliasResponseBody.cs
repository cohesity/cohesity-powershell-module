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
    /// CreateViewAliasResponseBody
    /// </summary>
    [DataContract]
    public partial class CreateViewAliasResponseBody :  IEquatable<CreateViewAliasResponseBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateViewAliasResponseBody" /> class.
        /// </summary>
        /// <param name="aliasName">Alias name..</param>
        /// <param name="enableFilerAuditLog">Specifies whether to enable filer audit log on this view alias..</param>
        /// <param name="enableSmbEncryption">Specifies the SMB encryption for the View Alias. If set, it enables the SMB encryption for the View Alias. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format..</param>
        /// <param name="enableSmbViewDiscovery">If set, it enables discovery of view alias for SMB..</param>
        /// <param name="enforceSmbEncryption">Specifies the SMB encryption for all the sessions for the View Alias. If set, encryption is enforced for all the sessions for the View Alias. When enabled all future and existing unencrypted sessions are disallowed..</param>
        /// <param name="message">Specifies the creating view alias message..</param>
        /// <param name="sharePermissions">Specifies a list of share level permissions..</param>
        /// <param name="subnetWhitelist">Specifies a list of Subnets with IP addresses that have permissions to access the View Alias. (Overrides the Subnets specified at the global Cohesity Cluster level and View level.).</param>
        /// <param name="superUserSids">Specifies a list of user sids who have Superuser access to this alias..</param>
        /// <param name="viewName">View name..</param>
        /// <param name="viewPath">View path for the alias..</param>
        public CreateViewAliasResponseBody(string aliasName = default(string), bool? enableFilerAuditLog = default(bool?), bool? enableSmbEncryption = default(bool?), bool? enableSmbViewDiscovery = default(bool?), bool? enforceSmbEncryption = default(bool?), string message = default(string), List<SmbPermission> sharePermissions = default(List<SmbPermission>), List<Subnet> subnetWhitelist = default(List<Subnet>), List<string> superUserSids = default(List<string>), string viewName = default(string), string viewPath = default(string))
        {
            this.AliasName = aliasName;
            this.EnableFilerAuditLog = enableFilerAuditLog;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.Message = message;
            this.SharePermissions = sharePermissions;
            this.SubnetWhitelist = subnetWhitelist;
            this.SuperUserSids = superUserSids;
            this.ViewName = viewName;
            this.ViewPath = viewPath;
        }
        
        /// <summary>
        /// Alias name.
        /// </summary>
        /// <value>Alias name.</value>
        [DataMember(Name="aliasName", EmitDefaultValue=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// Specifies whether to enable filer audit log on this view alias.
        /// </summary>
        /// <value>Specifies whether to enable filer audit log on this view alias.</value>
        [DataMember(Name="enableFilerAuditLog", EmitDefaultValue=false)]
        public bool? EnableFilerAuditLog { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for the View Alias. If set, it enables the SMB encryption for the View Alias. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.
        /// </summary>
        /// <value>Specifies the SMB encryption for the View Alias. If set, it enables the SMB encryption for the View Alias. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.</value>
        [DataMember(Name="enableSmbEncryption", EmitDefaultValue=false)]
        public bool? EnableSmbEncryption { get; set; }

        /// <summary>
        /// If set, it enables discovery of view alias for SMB.
        /// </summary>
        /// <value>If set, it enables discovery of view alias for SMB.</value>
        [DataMember(Name="enableSmbViewDiscovery", EmitDefaultValue=false)]
        public bool? EnableSmbViewDiscovery { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for all the sessions for the View Alias. If set, encryption is enforced for all the sessions for the View Alias. When enabled all future and existing unencrypted sessions are disallowed.
        /// </summary>
        /// <value>Specifies the SMB encryption for all the sessions for the View Alias. If set, encryption is enforced for all the sessions for the View Alias. When enabled all future and existing unencrypted sessions are disallowed.</value>
        [DataMember(Name="enforceSmbEncryption", EmitDefaultValue=false)]
        public bool? EnforceSmbEncryption { get; set; }

        /// <summary>
        /// Specifies the creating view alias message.
        /// </summary>
        /// <value>Specifies the creating view alias message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies a list of share level permissions.
        /// </summary>
        /// <value>Specifies a list of share level permissions.</value>
        [DataMember(Name="sharePermissions", EmitDefaultValue=false)]
        public List<SmbPermission> SharePermissions { get; set; }

        /// <summary>
        /// Specifies a list of Subnets with IP addresses that have permissions to access the View Alias. (Overrides the Subnets specified at the global Cohesity Cluster level and View level.)
        /// </summary>
        /// <value>Specifies a list of Subnets with IP addresses that have permissions to access the View Alias. (Overrides the Subnets specified at the global Cohesity Cluster level and View level.)</value>
        [DataMember(Name="subnetWhitelist", EmitDefaultValue=false)]
        public List<Subnet> SubnetWhitelist { get; set; }

        /// <summary>
        /// Specifies a list of user sids who have Superuser access to this alias.
        /// </summary>
        /// <value>Specifies a list of user sids who have Superuser access to this alias.</value>
        [DataMember(Name="superUserSids", EmitDefaultValue=false)]
        public List<string> SuperUserSids { get; set; }

        /// <summary>
        /// View name.
        /// </summary>
        /// <value>View name.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// View path for the alias.
        /// </summary>
        /// <value>View path for the alias.</value>
        [DataMember(Name="viewPath", EmitDefaultValue=false)]
        public string ViewPath { get; set; }

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
            return this.Equals(input as CreateViewAliasResponseBody);
        }

        /// <summary>
        /// Returns true if CreateViewAliasResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateViewAliasResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateViewAliasResponseBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AliasName == input.AliasName ||
                    (this.AliasName != null &&
                    this.AliasName.Equals(input.AliasName))
                ) && 
                (
                    this.EnableFilerAuditLog == input.EnableFilerAuditLog ||
                    (this.EnableFilerAuditLog != null &&
                    this.EnableFilerAuditLog.Equals(input.EnableFilerAuditLog))
                ) && 
                (
                    this.EnableSmbEncryption == input.EnableSmbEncryption ||
                    (this.EnableSmbEncryption != null &&
                    this.EnableSmbEncryption.Equals(input.EnableSmbEncryption))
                ) && 
                (
                    this.EnableSmbViewDiscovery == input.EnableSmbViewDiscovery ||
                    (this.EnableSmbViewDiscovery != null &&
                    this.EnableSmbViewDiscovery.Equals(input.EnableSmbViewDiscovery))
                ) && 
                (
                    this.EnforceSmbEncryption == input.EnforceSmbEncryption ||
                    (this.EnforceSmbEncryption != null &&
                    this.EnforceSmbEncryption.Equals(input.EnforceSmbEncryption))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SharePermissions == input.SharePermissions ||
                    this.SharePermissions != null &&
                    this.SharePermissions.Equals(input.SharePermissions)
                ) && 
                (
                    this.SubnetWhitelist == input.SubnetWhitelist ||
                    this.SubnetWhitelist != null &&
                    this.SubnetWhitelist.Equals(input.SubnetWhitelist)
                ) && 
                (
                    this.SuperUserSids == input.SuperUserSids ||
                    this.SuperUserSids != null &&
                    this.SuperUserSids.Equals(input.SuperUserSids)
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.ViewPath == input.ViewPath ||
                    (this.ViewPath != null &&
                    this.ViewPath.Equals(input.ViewPath))
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
                if (this.AliasName != null)
                    hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.EnableFilerAuditLog != null)
                    hashCode = hashCode * 59 + this.EnableFilerAuditLog.GetHashCode();
                if (this.EnableSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnableSmbEncryption.GetHashCode();
                if (this.EnableSmbViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableSmbViewDiscovery.GetHashCode();
                if (this.EnforceSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnforceSmbEncryption.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SharePermissions != null)
                    hashCode = hashCode * 59 + this.SharePermissions.GetHashCode();
                if (this.SubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.SubnetWhitelist.GetHashCode();
                if (this.SuperUserSids != null)
                    hashCode = hashCode * 59 + this.SuperUserSids.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.ViewPath != null)
                    hashCode = hashCode * 59 + this.ViewPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

