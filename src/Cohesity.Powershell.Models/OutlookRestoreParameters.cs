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
    /// Specifies information needed for recovering Mailboxes in O365Outlook environment.
    /// </summary>
    [DataContract]
    public partial class OutlookRestoreParameters :  IEquatable<OutlookRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookRestoreParameters" /> class.
        /// </summary>
        /// <param name="outlookMailboxList">Specifies the list of mailboxes to be restored..</param>
        /// <param name="targetFolderPath">Specifies the target folder path to restore the mailboxes. This will always be specified whether the target mailbox is the original or an alternate one..</param>
        /// <param name="targetMailbox">targetMailbox.</param>
        public OutlookRestoreParameters(List<OutlookMailbox> outlookMailboxList = default(List<OutlookMailbox>), string targetFolderPath = default(string), ProtectionSource targetMailbox = default(ProtectionSource))
        {
            this.OutlookMailboxList = outlookMailboxList;
            this.TargetFolderPath = targetFolderPath;
            this.OutlookMailboxList = outlookMailboxList;
            this.TargetFolderPath = targetFolderPath;
            this.TargetMailbox = targetMailbox;
        }
        
        /// <summary>
        /// Specifies the list of mailboxes to be restored.
        /// </summary>
        /// <value>Specifies the list of mailboxes to be restored.</value>
        [DataMember(Name="outlookMailboxList", EmitDefaultValue=true)]
        public List<OutlookMailbox> OutlookMailboxList { get; set; }

        /// <summary>
        /// Specifies the target folder path to restore the mailboxes. This will always be specified whether the target mailbox is the original or an alternate one.
        /// </summary>
        /// <value>Specifies the target folder path to restore the mailboxes. This will always be specified whether the target mailbox is the original or an alternate one.</value>
        [DataMember(Name="targetFolderPath", EmitDefaultValue=true)]
        public string TargetFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets TargetMailbox
        /// </summary>
        [DataMember(Name="targetMailbox", EmitDefaultValue=false)]
        public ProtectionSource TargetMailbox { get; set; }

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
            return this.Equals(input as OutlookRestoreParameters);
        }

        /// <summary>
        /// Returns true if OutlookRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of OutlookRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlookRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutlookMailboxList == input.OutlookMailboxList ||
                    this.OutlookMailboxList != null &&
                    input.OutlookMailboxList != null &&
                    this.OutlookMailboxList.SequenceEqual(input.OutlookMailboxList)
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
                if (this.OutlookMailboxList != null)
                    hashCode = hashCode * 59 + this.OutlookMailboxList.GetHashCode();
                if (this.TargetFolderPath != null)
                    hashCode = hashCode * 59 + this.TargetFolderPath.GetHashCode();
                if (this.TargetMailbox != null)
                    hashCode = hashCode * 59 + this.TargetMailbox.GetHashCode();
                return hashCode;
            }
        }

    }

}

