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
        /// <param name="mailboxVec">In a RestoreJob , user will provide the list of mailboxes to be restored. Provision is there for restoring full AND partial mailbox recovery..</param>
        /// <param name="pstParams">pstParams.</param>
        /// <param name="skipMbxPermitForPst">Indicates whether PST conversion should skip mailbox entity permit..</param>
        /// <param name="targetFolderPath">User will type the target folder path. This will always be specified (whether target_mailbox is original mailbox or alternate). If multiple folders are selected, they will all be restored to this folder. The appropriate hierarchy along with the folder names will be preserved..</param>
        /// <param name="targetMailbox">targetMailbox.</param>
        public RestoreOutlookParams(List<RestoreOutlookParamsMailbox> mailboxVec = default(List<RestoreOutlookParamsMailbox>), EwsToPstConversionParams pstParams = default(EwsToPstConversionParams), bool? skipMbxPermitForPst = default(bool?), string targetFolderPath = default(string), EntityProto targetMailbox = default(EntityProto))
        {
            this.MailboxVec = mailboxVec;
            this.SkipMbxPermitForPst = skipMbxPermitForPst;
            this.TargetFolderPath = targetFolderPath;
            this.MailboxVec = mailboxVec;
            this.PstParams = pstParams;
            this.SkipMbxPermitForPst = skipMbxPermitForPst;
            this.TargetFolderPath = targetFolderPath;
            this.TargetMailbox = targetMailbox;
        }
        
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
        /// Indicates whether PST conversion should skip mailbox entity permit.
        /// </summary>
        /// <value>Indicates whether PST conversion should skip mailbox entity permit.</value>
        [DataMember(Name="skipMbxPermitForPst", EmitDefaultValue=true)]
        public bool? SkipMbxPermitForPst { get; set; }

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
                    this.SkipMbxPermitForPst == input.SkipMbxPermitForPst ||
                    (this.SkipMbxPermitForPst != null &&
                    this.SkipMbxPermitForPst.Equals(input.SkipMbxPermitForPst))
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
                if (this.MailboxVec != null)
                    hashCode = hashCode * 59 + this.MailboxVec.GetHashCode();
                if (this.PstParams != null)
                    hashCode = hashCode * 59 + this.PstParams.GetHashCode();
                if (this.SkipMbxPermitForPst != null)
                    hashCode = hashCode * 59 + this.SkipMbxPermitForPst.GetHashCode();
                if (this.TargetFolderPath != null)
                    hashCode = hashCode * 59 + this.TargetFolderPath.GetHashCode();
                if (this.TargetMailbox != null)
                    hashCode = hashCode * 59 + this.TargetMailbox.GetHashCode();
                return hashCode;
            }
        }

    }

}

