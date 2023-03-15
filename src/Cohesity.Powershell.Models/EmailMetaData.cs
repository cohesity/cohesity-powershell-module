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
    /// Specifies details about the emails and the folder containing emails.
    /// </summary>
    [DataContract]
    public partial class EmailMetaData :  IEquatable<EmailMetaData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMetaData" /> class.
        /// </summary>
        /// <param name="allUnderHierarchy">AllUnderHierarchy specifies if logs of all the tenants under the hierarchy of tenant with id TenantId should be returned..</param>
        /// <param name="bccRecipientAddresses">Specifies the email addresses of the bcc recipients..</param>
        /// <param name="ccRecipientAddresses">Specifies the email addresses of the cc recipients..</param>
        /// <param name="directoryPath">Specifies the directory path to the item..</param>
        /// <param name="domainIds">Specifies the domain Ids in which mailboxes are registered..</param>
        /// <param name="emailSubject">Specifies the subject of the email..</param>
        /// <param name="folderKey">Specifes the Parent Folder key..</param>
        /// <param name="folderName">Specifies the parent folder name of the email..</param>
        /// <param name="hasAttachments">Specifies whether the emails have any attachments..</param>
        /// <param name="itemKey">Specifies the Key(unique within mailbox) for Outlook item such as Email. This key is not indexed but used for identifying the item while restore..</param>
        /// <param name="mailboxIds">Specifies the mailbox Ids which contains the emails/folders..</param>
        /// <param name="protectionJobIds">Specifies the protection job Ids which have backed up mailbox(es) continaing emails/folders..</param>
        /// <param name="receivedEndTime">Specifies the unix end time for querying on email&#39;s received time..</param>
        /// <param name="receivedStartTime">Specifies the unix start time for querying on email&#39;s received time..</param>
        /// <param name="receivedTimeSeconds">Specifies the unix time when the email was received..</param>
        /// <param name="recipientAddresses">Specifies the email addresses of the recipients..</param>
        /// <param name="senderAddress">Specifies the email address of the sender..</param>
        /// <param name="sentTimeSeconds">Specifies the unix time when the email was sent..</param>
        /// <param name="showOnlyEmailFolders">Specifies whether the query result should include only Email folders..</param>
        /// <param name="tenantId">TenantId specifies the tenant whose action resulted in the audit log..</param>
        public EmailMetaData(bool? allUnderHierarchy = default(bool?), List<string> bccRecipientAddresses = default(List<string>), List<string> ccRecipientAddresses = default(List<string>), string directoryPath = default(string), List<long> domainIds = default(List<long>), string emailSubject = default(string), long? folderKey = default(long?), string folderName = default(string), bool? hasAttachments = default(bool?), string itemKey = default(string), List<long> mailboxIds = default(List<long>), List<long> protectionJobIds = default(List<long>), long? receivedEndTime = default(long?), long? receivedStartTime = default(long?), long? receivedTimeSeconds = default(long?), List<string> recipientAddresses = default(List<string>), string senderAddress = default(string), long? sentTimeSeconds = default(long?), bool? showOnlyEmailFolders = default(bool?), string tenantId = default(string))
        {
            this.AllUnderHierarchy = allUnderHierarchy;
            this.BccRecipientAddresses = bccRecipientAddresses;
            this.CcRecipientAddresses = ccRecipientAddresses;
            this.DirectoryPath = directoryPath;
            this.DomainIds = domainIds;
            this.EmailSubject = emailSubject;
            this.FolderKey = folderKey;
            this.FolderName = folderName;
            this.HasAttachments = hasAttachments;
            this.ItemKey = itemKey;
            this.MailboxIds = mailboxIds;
            this.ProtectionJobIds = protectionJobIds;
            this.ReceivedEndTime = receivedEndTime;
            this.ReceivedStartTime = receivedStartTime;
            this.ReceivedTimeSeconds = receivedTimeSeconds;
            this.RecipientAddresses = recipientAddresses;
            this.SenderAddress = senderAddress;
            this.SentTimeSeconds = sentTimeSeconds;
            this.ShowOnlyEmailFolders = showOnlyEmailFolders;
            this.TenantId = tenantId;
            this.AllUnderHierarchy = allUnderHierarchy;
            this.BccRecipientAddresses = bccRecipientAddresses;
            this.CcRecipientAddresses = ccRecipientAddresses;
            this.DirectoryPath = directoryPath;
            this.DomainIds = domainIds;
            this.EmailSubject = emailSubject;
            this.FolderKey = folderKey;
            this.FolderName = folderName;
            this.HasAttachments = hasAttachments;
            this.ItemKey = itemKey;
            this.MailboxIds = mailboxIds;
            this.ProtectionJobIds = protectionJobIds;
            this.ReceivedEndTime = receivedEndTime;
            this.ReceivedStartTime = receivedStartTime;
            this.ReceivedTimeSeconds = receivedTimeSeconds;
            this.RecipientAddresses = recipientAddresses;
            this.SenderAddress = senderAddress;
            this.SentTimeSeconds = sentTimeSeconds;
            this.ShowOnlyEmailFolders = showOnlyEmailFolders;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// AllUnderHierarchy specifies if logs of all the tenants under the hierarchy of tenant with id TenantId should be returned.
        /// </summary>
        /// <value>AllUnderHierarchy specifies if logs of all the tenants under the hierarchy of tenant with id TenantId should be returned.</value>
        [DataMember(Name="allUnderHierarchy", EmitDefaultValue=true)]
        public bool? AllUnderHierarchy { get; set; }

        /// <summary>
        /// Specifies the email addresses of the bcc recipients.
        /// </summary>
        /// <value>Specifies the email addresses of the bcc recipients.</value>
        [DataMember(Name="bccRecipientAddresses", EmitDefaultValue=true)]
        public List<string> BccRecipientAddresses { get; set; }

        /// <summary>
        /// Specifies the email addresses of the cc recipients.
        /// </summary>
        /// <value>Specifies the email addresses of the cc recipients.</value>
        [DataMember(Name="ccRecipientAddresses", EmitDefaultValue=true)]
        public List<string> CcRecipientAddresses { get; set; }

        /// <summary>
        /// Specifies the directory path to the item.
        /// </summary>
        /// <value>Specifies the directory path to the item.</value>
        [DataMember(Name="directoryPath", EmitDefaultValue=true)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Specifies the domain Ids in which mailboxes are registered.
        /// </summary>
        /// <value>Specifies the domain Ids in which mailboxes are registered.</value>
        [DataMember(Name="domainIds", EmitDefaultValue=true)]
        public List<long> DomainIds { get; set; }

        /// <summary>
        /// Specifies the subject of the email.
        /// </summary>
        /// <value>Specifies the subject of the email.</value>
        [DataMember(Name="emailSubject", EmitDefaultValue=true)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// Specifes the Parent Folder key.
        /// </summary>
        /// <value>Specifes the Parent Folder key.</value>
        [DataMember(Name="folderKey", EmitDefaultValue=true)]
        public long? FolderKey { get; set; }

        /// <summary>
        /// Specifies the parent folder name of the email.
        /// </summary>
        /// <value>Specifies the parent folder name of the email.</value>
        [DataMember(Name="folderName", EmitDefaultValue=true)]
        public string FolderName { get; set; }

        /// <summary>
        /// Specifies whether the emails have any attachments.
        /// </summary>
        /// <value>Specifies whether the emails have any attachments.</value>
        [DataMember(Name="hasAttachments", EmitDefaultValue=true)]
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// Specifies the Key(unique within mailbox) for Outlook item such as Email. This key is not indexed but used for identifying the item while restore.
        /// </summary>
        /// <value>Specifies the Key(unique within mailbox) for Outlook item such as Email. This key is not indexed but used for identifying the item while restore.</value>
        [DataMember(Name="itemKey", EmitDefaultValue=true)]
        public string ItemKey { get; set; }

        /// <summary>
        /// Specifies the mailbox Ids which contains the emails/folders.
        /// </summary>
        /// <value>Specifies the mailbox Ids which contains the emails/folders.</value>
        [DataMember(Name="mailboxIds", EmitDefaultValue=true)]
        public List<long> MailboxIds { get; set; }

        /// <summary>
        /// Specifies the protection job Ids which have backed up mailbox(es) continaing emails/folders.
        /// </summary>
        /// <value>Specifies the protection job Ids which have backed up mailbox(es) continaing emails/folders.</value>
        [DataMember(Name="protectionJobIds", EmitDefaultValue=true)]
        public List<long> ProtectionJobIds { get; set; }

        /// <summary>
        /// Specifies the unix end time for querying on email&#39;s received time.
        /// </summary>
        /// <value>Specifies the unix end time for querying on email&#39;s received time.</value>
        [DataMember(Name="receivedEndTime", EmitDefaultValue=true)]
        public long? ReceivedEndTime { get; set; }

        /// <summary>
        /// Specifies the unix start time for querying on email&#39;s received time.
        /// </summary>
        /// <value>Specifies the unix start time for querying on email&#39;s received time.</value>
        [DataMember(Name="receivedStartTime", EmitDefaultValue=true)]
        public long? ReceivedStartTime { get; set; }

        /// <summary>
        /// Specifies the unix time when the email was received.
        /// </summary>
        /// <value>Specifies the unix time when the email was received.</value>
        [DataMember(Name="receivedTimeSeconds", EmitDefaultValue=true)]
        public long? ReceivedTimeSeconds { get; set; }

        /// <summary>
        /// Specifies the email addresses of the recipients.
        /// </summary>
        /// <value>Specifies the email addresses of the recipients.</value>
        [DataMember(Name="recipientAddresses", EmitDefaultValue=true)]
        public List<string> RecipientAddresses { get; set; }

        /// <summary>
        /// Specifies the email address of the sender.
        /// </summary>
        /// <value>Specifies the email address of the sender.</value>
        [DataMember(Name="senderAddress", EmitDefaultValue=true)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// Specifies the unix time when the email was sent.
        /// </summary>
        /// <value>Specifies the unix time when the email was sent.</value>
        [DataMember(Name="sentTimeSeconds", EmitDefaultValue=true)]
        public long? SentTimeSeconds { get; set; }

        /// <summary>
        /// Specifies whether the query result should include only Email folders.
        /// </summary>
        /// <value>Specifies whether the query result should include only Email folders.</value>
        [DataMember(Name="showOnlyEmailFolders", EmitDefaultValue=true)]
        public bool? ShowOnlyEmailFolders { get; set; }

        /// <summary>
        /// TenantId specifies the tenant whose action resulted in the audit log.
        /// </summary>
        /// <value>TenantId specifies the tenant whose action resulted in the audit log.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
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
            return this.Equals(input as EmailMetaData);
        }

        /// <summary>
        /// Returns true if EmailMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailMetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllUnderHierarchy == input.AllUnderHierarchy ||
                    (this.AllUnderHierarchy != null &&
                    this.AllUnderHierarchy.Equals(input.AllUnderHierarchy))
                ) && 
                (
                    this.BccRecipientAddresses == input.BccRecipientAddresses ||
                    this.BccRecipientAddresses != null &&
                    input.BccRecipientAddresses != null &&
                    this.BccRecipientAddresses.SequenceEqual(input.BccRecipientAddresses)
                ) && 
                (
                    this.CcRecipientAddresses == input.CcRecipientAddresses ||
                    this.CcRecipientAddresses != null &&
                    input.CcRecipientAddresses != null &&
                    this.CcRecipientAddresses.SequenceEqual(input.CcRecipientAddresses)
                ) && 
                (
                    this.DirectoryPath == input.DirectoryPath ||
                    (this.DirectoryPath != null &&
                    this.DirectoryPath.Equals(input.DirectoryPath))
                ) && 
                (
                    this.DomainIds == input.DomainIds ||
                    this.DomainIds != null &&
                    input.DomainIds != null &&
                    this.DomainIds.SequenceEqual(input.DomainIds)
                ) && 
                (
                    this.EmailSubject == input.EmailSubject ||
                    (this.EmailSubject != null &&
                    this.EmailSubject.Equals(input.EmailSubject))
                ) && 
                (
                    this.FolderKey == input.FolderKey ||
                    (this.FolderKey != null &&
                    this.FolderKey.Equals(input.FolderKey))
                ) && 
                (
                    this.FolderName == input.FolderName ||
                    (this.FolderName != null &&
                    this.FolderName.Equals(input.FolderName))
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    (this.HasAttachments != null &&
                    this.HasAttachments.Equals(input.HasAttachments))
                ) && 
                (
                    this.ItemKey == input.ItemKey ||
                    (this.ItemKey != null &&
                    this.ItemKey.Equals(input.ItemKey))
                ) && 
                (
                    this.MailboxIds == input.MailboxIds ||
                    this.MailboxIds != null &&
                    input.MailboxIds != null &&
                    this.MailboxIds.SequenceEqual(input.MailboxIds)
                ) && 
                (
                    this.ProtectionJobIds == input.ProtectionJobIds ||
                    this.ProtectionJobIds != null &&
                    input.ProtectionJobIds != null &&
                    this.ProtectionJobIds.SequenceEqual(input.ProtectionJobIds)
                ) && 
                (
                    this.ReceivedEndTime == input.ReceivedEndTime ||
                    (this.ReceivedEndTime != null &&
                    this.ReceivedEndTime.Equals(input.ReceivedEndTime))
                ) && 
                (
                    this.ReceivedStartTime == input.ReceivedStartTime ||
                    (this.ReceivedStartTime != null &&
                    this.ReceivedStartTime.Equals(input.ReceivedStartTime))
                ) && 
                (
                    this.ReceivedTimeSeconds == input.ReceivedTimeSeconds ||
                    (this.ReceivedTimeSeconds != null &&
                    this.ReceivedTimeSeconds.Equals(input.ReceivedTimeSeconds))
                ) && 
                (
                    this.RecipientAddresses == input.RecipientAddresses ||
                    this.RecipientAddresses != null &&
                    input.RecipientAddresses != null &&
                    this.RecipientAddresses.SequenceEqual(input.RecipientAddresses)
                ) && 
                (
                    this.SenderAddress == input.SenderAddress ||
                    (this.SenderAddress != null &&
                    this.SenderAddress.Equals(input.SenderAddress))
                ) && 
                (
                    this.SentTimeSeconds == input.SentTimeSeconds ||
                    (this.SentTimeSeconds != null &&
                    this.SentTimeSeconds.Equals(input.SentTimeSeconds))
                ) && 
                (
                    this.ShowOnlyEmailFolders == input.ShowOnlyEmailFolders ||
                    (this.ShowOnlyEmailFolders != null &&
                    this.ShowOnlyEmailFolders.Equals(input.ShowOnlyEmailFolders))
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
                if (this.AllUnderHierarchy != null)
                    hashCode = hashCode * 59 + this.AllUnderHierarchy.GetHashCode();
                if (this.BccRecipientAddresses != null)
                    hashCode = hashCode * 59 + this.BccRecipientAddresses.GetHashCode();
                if (this.CcRecipientAddresses != null)
                    hashCode = hashCode * 59 + this.CcRecipientAddresses.GetHashCode();
                if (this.DirectoryPath != null)
                    hashCode = hashCode * 59 + this.DirectoryPath.GetHashCode();
                if (this.DomainIds != null)
                    hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                if (this.EmailSubject != null)
                    hashCode = hashCode * 59 + this.EmailSubject.GetHashCode();
                if (this.FolderKey != null)
                    hashCode = hashCode * 59 + this.FolderKey.GetHashCode();
                if (this.FolderName != null)
                    hashCode = hashCode * 59 + this.FolderName.GetHashCode();
                if (this.HasAttachments != null)
                    hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.ItemKey != null)
                    hashCode = hashCode * 59 + this.ItemKey.GetHashCode();
                if (this.MailboxIds != null)
                    hashCode = hashCode * 59 + this.MailboxIds.GetHashCode();
                if (this.ProtectionJobIds != null)
                    hashCode = hashCode * 59 + this.ProtectionJobIds.GetHashCode();
                if (this.ReceivedEndTime != null)
                    hashCode = hashCode * 59 + this.ReceivedEndTime.GetHashCode();
                if (this.ReceivedStartTime != null)
                    hashCode = hashCode * 59 + this.ReceivedStartTime.GetHashCode();
                if (this.ReceivedTimeSeconds != null)
                    hashCode = hashCode * 59 + this.ReceivedTimeSeconds.GetHashCode();
                if (this.RecipientAddresses != null)
                    hashCode = hashCode * 59 + this.RecipientAddresses.GetHashCode();
                if (this.SenderAddress != null)
                    hashCode = hashCode * 59 + this.SenderAddress.GetHashCode();
                if (this.SentTimeSeconds != null)
                    hashCode = hashCode * 59 + this.SentTimeSeconds.GetHashCode();
                if (this.ShowOnlyEmailFolders != null)
                    hashCode = hashCode * 59 + this.ShowOnlyEmailFolders.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}

