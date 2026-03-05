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
    /// RestoreOutlookParams
    /// </summary>
    [DataContract]
    public partial class RestoreOutlookParams :  IEquatable<RestoreOutlookParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOutlookParams" /> class.
        /// </summary>
        /// <param name="allowGraphImportRestore">If set to true, the restore is allowed to use the graph item import APIs and workflow..</param>
        /// <param name="archiveRecoverableItemsPrefix">Human readable prefix that is prepended to the archive recoverable items folder name..</param>
        /// <param name="ewsExchangeTarget">ewsExchangeTarget.</param>
        /// <param name="itemRecoveryMethod">Governs how items are restored to microsoft. See enum definitions for details..</param>
        /// <param name="mailboxVec">In a RestoreJob , user will provide the list of mailboxes to be restored. Provision is there for restoring full AND partial mailbox recovery..</param>
        /// <param name="pstParams">pstParams.</param>
        /// <param name="recoverableItemsPrefix">Human readable prefix that is prepended to the recoverable items folder name..</param>
        /// <param name="skipMbxPermitForPst">Indicates whether PST conversion should skip mailbox entity permit..</param>
        /// <param name="skipRecoverArchiveMailbox">Whether to skip recovery of the archive mailbox (or its items)..</param>
        /// <param name="skipRecoverArchiveRecoverableItems">Whether to skip recovery of archive recoverable items folders..</param>
        /// <param name="skipRecoverPrimaryMailbox">Whether to skip recovery of items in the message folder root..</param>
        /// <param name="skipRecoverRecoverableItems">Whether to skip recovery of recoverable items folders..</param>
        /// <param name="targetFolderPath">User will type the target folder path. This will always be specified (whether target_mailbox is original mailbox or alternate). If multiple folders are selected, they will all be restored to this folder. The appropriate hierarchy along with the folder names will be preserved..</param>
        /// <param name="targetMailbox">targetMailbox.</param>
        public RestoreOutlookParams(bool? allowGraphImportRestore = default(bool?), string archiveRecoverableItemsPrefix = default(string), RestoreOutlookParamsEwsExchangeTarget ewsExchangeTarget = default(RestoreOutlookParamsEwsExchangeTarget), int? itemRecoveryMethod = default(int?), List<RestoreOutlookParamsMailbox> mailboxVec = default(List<RestoreOutlookParamsMailbox>), EwsToPstConversionParams pstParams = default(EwsToPstConversionParams), string recoverableItemsPrefix = default(string), bool? skipMbxPermitForPst = default(bool?), bool? skipRecoverArchiveMailbox = default(bool?), bool? skipRecoverArchiveRecoverableItems = default(bool?), bool? skipRecoverPrimaryMailbox = default(bool?), bool? skipRecoverRecoverableItems = default(bool?), string targetFolderPath = default(string), EntityProto targetMailbox = default(EntityProto))
        {
            this.AllowGraphImportRestore = allowGraphImportRestore;
            this.ArchiveRecoverableItemsPrefix = archiveRecoverableItemsPrefix;
            this.ItemRecoveryMethod = itemRecoveryMethod;
            this.MailboxVec = mailboxVec;
            this.RecoverableItemsPrefix = recoverableItemsPrefix;
            this.SkipMbxPermitForPst = skipMbxPermitForPst;
            this.SkipRecoverArchiveMailbox = skipRecoverArchiveMailbox;
            this.SkipRecoverArchiveRecoverableItems = skipRecoverArchiveRecoverableItems;
            this.SkipRecoverPrimaryMailbox = skipRecoverPrimaryMailbox;
            this.SkipRecoverRecoverableItems = skipRecoverRecoverableItems;
            this.TargetFolderPath = targetFolderPath;
            this.AllowGraphImportRestore = allowGraphImportRestore;
            this.ArchiveRecoverableItemsPrefix = archiveRecoverableItemsPrefix;
            this.EwsExchangeTarget = ewsExchangeTarget;
            this.ItemRecoveryMethod = itemRecoveryMethod;
            this.MailboxVec = mailboxVec;
            this.PstParams = pstParams;
            this.RecoverableItemsPrefix = recoverableItemsPrefix;
            this.SkipMbxPermitForPst = skipMbxPermitForPst;
            this.SkipRecoverArchiveMailbox = skipRecoverArchiveMailbox;
            this.SkipRecoverArchiveRecoverableItems = skipRecoverArchiveRecoverableItems;
            this.SkipRecoverPrimaryMailbox = skipRecoverPrimaryMailbox;
            this.SkipRecoverRecoverableItems = skipRecoverRecoverableItems;
            this.TargetFolderPath = targetFolderPath;
            this.TargetMailbox = targetMailbox;
        }
        
        /// <summary>
        /// If set to true, the restore is allowed to use the graph item import APIs and workflow.
        /// </summary>
        /// <value>If set to true, the restore is allowed to use the graph item import APIs and workflow.</value>
        [DataMember(Name="allowGraphImportRestore", EmitDefaultValue=true)]
        public bool? AllowGraphImportRestore { get; set; }

        /// <summary>
        /// Human readable prefix that is prepended to the archive recoverable items folder name.
        /// </summary>
        /// <value>Human readable prefix that is prepended to the archive recoverable items folder name.</value>
        [DataMember(Name="archiveRecoverableItemsPrefix", EmitDefaultValue=true)]
        public string ArchiveRecoverableItemsPrefix { get; set; }

        /// <summary>
        /// Gets or Sets EwsExchangeTarget
        /// </summary>
        [DataMember(Name="ewsExchangeTarget", EmitDefaultValue=false)]
        public RestoreOutlookParamsEwsExchangeTarget EwsExchangeTarget { get; set; }

        /// <summary>
        /// Governs how items are restored to microsoft. See enum definitions for details.
        /// </summary>
        /// <value>Governs how items are restored to microsoft. See enum definitions for details.</value>
        [DataMember(Name="itemRecoveryMethod", EmitDefaultValue=true)]
        public int? ItemRecoveryMethod { get; set; }

        /// <summary>
        /// In a RestoreJob , user will provide the list of mailboxes to be restored. Provision is there for restoring full AND partial mailbox recovery.
        /// </summary>
        /// <value>In a RestoreJob , user will provide the list of mailboxes to be restored. Provision is there for restoring full AND partial mailbox recovery.</value>
        [DataMember(Name="mailboxVec", EmitDefaultValue=true)]
        public List<RestoreOutlookParamsMailbox> MailboxVec { get; set; }

        /// <summary>
        /// Gets or Sets PstParams
        /// </summary>
        [DataMember(Name="pstParams", EmitDefaultValue=false)]
        public EwsToPstConversionParams PstParams { get; set; }

        /// <summary>
        /// Human readable prefix that is prepended to the recoverable items folder name.
        /// </summary>
        /// <value>Human readable prefix that is prepended to the recoverable items folder name.</value>
        [DataMember(Name="recoverableItemsPrefix", EmitDefaultValue=true)]
        public string RecoverableItemsPrefix { get; set; }

        /// <summary>
        /// Indicates whether PST conversion should skip mailbox entity permit.
        /// </summary>
        /// <value>Indicates whether PST conversion should skip mailbox entity permit.</value>
        [DataMember(Name="skipMbxPermitForPst", EmitDefaultValue=true)]
        public bool? SkipMbxPermitForPst { get; set; }

        /// <summary>
        /// Whether to skip recovery of the archive mailbox (or its items).
        /// </summary>
        /// <value>Whether to skip recovery of the archive mailbox (or its items).</value>
        [DataMember(Name="skipRecoverArchiveMailbox", EmitDefaultValue=true)]
        public bool? SkipRecoverArchiveMailbox { get; set; }

        /// <summary>
        /// Whether to skip recovery of archive recoverable items folders.
        /// </summary>
        /// <value>Whether to skip recovery of archive recoverable items folders.</value>
        [DataMember(Name="skipRecoverArchiveRecoverableItems", EmitDefaultValue=true)]
        public bool? SkipRecoverArchiveRecoverableItems { get; set; }

        /// <summary>
        /// Whether to skip recovery of items in the message folder root.
        /// </summary>
        /// <value>Whether to skip recovery of items in the message folder root.</value>
        [DataMember(Name="skipRecoverPrimaryMailbox", EmitDefaultValue=true)]
        public bool? SkipRecoverPrimaryMailbox { get; set; }

        /// <summary>
        /// Whether to skip recovery of recoverable items folders.
        /// </summary>
        /// <value>Whether to skip recovery of recoverable items folders.</value>
        [DataMember(Name="skipRecoverRecoverableItems", EmitDefaultValue=true)]
        public bool? SkipRecoverRecoverableItems { get; set; }

        /// <summary>
        /// User will type the target folder path. This will always be specified (whether target_mailbox is original mailbox or alternate). If multiple folders are selected, they will all be restored to this folder. The appropriate hierarchy along with the folder names will be preserved.
        /// </summary>
        /// <value>User will type the target folder path. This will always be specified (whether target_mailbox is original mailbox or alternate). If multiple folders are selected, they will all be restored to this folder. The appropriate hierarchy along with the folder names will be preserved.</value>
        [DataMember(Name="targetFolderPath", EmitDefaultValue=true)]
        public string TargetFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets TargetMailbox
        /// </summary>
        [DataMember(Name="targetMailbox", EmitDefaultValue=false)]
        public EntityProto TargetMailbox { get; set; }

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
            return this.Equals(input as RestoreOutlookParams);
        }

        /// <summary>
        /// Returns true if RestoreOutlookParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOutlookParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOutlookParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowGraphImportRestore == input.AllowGraphImportRestore ||
                    (this.AllowGraphImportRestore != null &&
                    this.AllowGraphImportRestore.Equals(input.AllowGraphImportRestore))
                ) && 
                (
                    this.ArchiveRecoverableItemsPrefix == input.ArchiveRecoverableItemsPrefix ||
                    (this.ArchiveRecoverableItemsPrefix != null &&
                    this.ArchiveRecoverableItemsPrefix.Equals(input.ArchiveRecoverableItemsPrefix))
                ) && 
                (
                    this.EwsExchangeTarget == input.EwsExchangeTarget ||
                    (this.EwsExchangeTarget != null &&
                    this.EwsExchangeTarget.Equals(input.EwsExchangeTarget))
                ) && 
                (
                    this.ItemRecoveryMethod == input.ItemRecoveryMethod ||
                    (this.ItemRecoveryMethod != null &&
                    this.ItemRecoveryMethod.Equals(input.ItemRecoveryMethod))
                ) && 
                (
                    this.MailboxVec == input.MailboxVec ||
                    this.MailboxVec != null &&
                    input.MailboxVec != null &&
                    this.MailboxVec.SequenceEqual(input.MailboxVec)
                ) && 
                (
                    this.PstParams == input.PstParams ||
                    (this.PstParams != null &&
                    this.PstParams.Equals(input.PstParams))
                ) && 
                (
                    this.RecoverableItemsPrefix == input.RecoverableItemsPrefix ||
                    (this.RecoverableItemsPrefix != null &&
                    this.RecoverableItemsPrefix.Equals(input.RecoverableItemsPrefix))
                ) && 
                (
                    this.SkipMbxPermitForPst == input.SkipMbxPermitForPst ||
                    (this.SkipMbxPermitForPst != null &&
                    this.SkipMbxPermitForPst.Equals(input.SkipMbxPermitForPst))
                ) && 
                (
                    this.SkipRecoverArchiveMailbox == input.SkipRecoverArchiveMailbox ||
                    (this.SkipRecoverArchiveMailbox != null &&
                    this.SkipRecoverArchiveMailbox.Equals(input.SkipRecoverArchiveMailbox))
                ) && 
                (
                    this.SkipRecoverArchiveRecoverableItems == input.SkipRecoverArchiveRecoverableItems ||
                    (this.SkipRecoverArchiveRecoverableItems != null &&
                    this.SkipRecoverArchiveRecoverableItems.Equals(input.SkipRecoverArchiveRecoverableItems))
                ) && 
                (
                    this.SkipRecoverPrimaryMailbox == input.SkipRecoverPrimaryMailbox ||
                    (this.SkipRecoverPrimaryMailbox != null &&
                    this.SkipRecoverPrimaryMailbox.Equals(input.SkipRecoverPrimaryMailbox))
                ) && 
                (
                    this.SkipRecoverRecoverableItems == input.SkipRecoverRecoverableItems ||
                    (this.SkipRecoverRecoverableItems != null &&
                    this.SkipRecoverRecoverableItems.Equals(input.SkipRecoverRecoverableItems))
                ) && 
                (
                    this.TargetFolderPath == input.TargetFolderPath ||
                    (this.TargetFolderPath != null &&
                    this.TargetFolderPath.Equals(input.TargetFolderPath))
                ) && 
                (
                    this.TargetMailbox == input.TargetMailbox ||
                    (this.TargetMailbox != null &&
                    this.TargetMailbox.Equals(input.TargetMailbox))
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
                if (this.AllowGraphImportRestore != null)
                    hashCode = hashCode * 59 + this.AllowGraphImportRestore.GetHashCode();
                if (this.ArchiveRecoverableItemsPrefix != null)
                    hashCode = hashCode * 59 + this.ArchiveRecoverableItemsPrefix.GetHashCode();
                if (this.EwsExchangeTarget != null)
                    hashCode = hashCode * 59 + this.EwsExchangeTarget.GetHashCode();
                if (this.ItemRecoveryMethod != null)
                    hashCode = hashCode * 59 + this.ItemRecoveryMethod.GetHashCode();
                if (this.MailboxVec != null)
                    hashCode = hashCode * 59 + this.MailboxVec.GetHashCode();
                if (this.PstParams != null)
                    hashCode = hashCode * 59 + this.PstParams.GetHashCode();
                if (this.RecoverableItemsPrefix != null)
                    hashCode = hashCode * 59 + this.RecoverableItemsPrefix.GetHashCode();
                if (this.SkipMbxPermitForPst != null)
                    hashCode = hashCode * 59 + this.SkipMbxPermitForPst.GetHashCode();
                if (this.SkipRecoverArchiveMailbox != null)
                    hashCode = hashCode * 59 + this.SkipRecoverArchiveMailbox.GetHashCode();
                if (this.SkipRecoverArchiveRecoverableItems != null)
                    hashCode = hashCode * 59 + this.SkipRecoverArchiveRecoverableItems.GetHashCode();
                if (this.SkipRecoverPrimaryMailbox != null)
                    hashCode = hashCode * 59 + this.SkipRecoverPrimaryMailbox.GetHashCode();
                if (this.SkipRecoverRecoverableItems != null)
                    hashCode = hashCode * 59 + this.SkipRecoverRecoverableItems.GetHashCode();
                if (this.TargetFolderPath != null)
                    hashCode = hashCode * 59 + this.TargetFolderPath.GetHashCode();
                if (this.TargetMailbox != null)
                    hashCode = hashCode * 59 + this.TargetMailbox.GetHashCode();
                return hashCode;
            }
        }

    }

}

