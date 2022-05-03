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
        /// <param name="targetFolderPath">targetFolderPath.</param>
        /// <param name="targetMailbox">targetMailbox.</param>
        public RestoreOutlookParams(List<RestoreOutlookParamsMailbox> mailboxVec = default(List<RestoreOutlookParamsMailbox>), EwsToPstConversionParams pstParams = default(EwsToPstConversionParams), string targetFolderPath = default(string), EntityProto targetMailbox = default(EntityProto))
        {
            this.MailboxVec = mailboxVec;
            this.PstParams = pstParams;
            this.TargetFolderPath = targetFolderPath;
            this.TargetMailbox = targetMailbox;
        }
        
        /// <summary>
        /// In a RestoreJob , user will provide the list of mailboxes to be restored. Provision is there for restoring full AND partial mailbox recovery.
        /// </summary>
        /// <value>In a RestoreJob , user will provide the list of mailboxes to be restored. Provision is there for restoring full AND partial mailbox recovery.</value>
        [DataMember(Name="mailboxVec", EmitDefaultValue=false)]
        public List<RestoreOutlookParamsMailbox> MailboxVec { get; set; }

        /// <summary>
        /// Gets or Sets PstParams
        /// </summary>
        [DataMember(Name="pstParams", EmitDefaultValue=false)]
        public EwsToPstConversionParams PstParams { get; set; }

        /// <summary>
        /// Gets or Sets TargetFolderPath
        /// </summary>
        [DataMember(Name="targetFolderPath", EmitDefaultValue=false)]
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
                    this.MailboxVec.Equals(input.MailboxVec)
                ) && 
                (
                    this.PstParams == input.PstParams ||
                    (this.PstParams != null &&
                    this.PstParams.Equals(input.PstParams))
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
                if (this.TargetFolderPath != null)
                    hashCode = hashCode * 59 + this.TargetFolderPath.GetHashCode();
                if (this.TargetMailbox != null)
                    hashCode = hashCode * 59 + this.TargetMailbox.GetHashCode();
                return hashCode;
            }
        }

    }

}

