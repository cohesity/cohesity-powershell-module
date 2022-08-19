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
    /// Specifies the Outlook mailbox with restore details to support full or partial recovery.
    /// </summary>
    [DataContract]
    public partial class OutlookMailbox :  IEquatable<OutlookMailbox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookMailbox" /> class.
        /// </summary>
        /// <param name="mailboxObject">mailboxObject.</param>
        /// <param name="outlookFolderList">Specifies the list of folders to be restored incase user wishes not to restore entire mailbox..</param>
        /// <param name="restoreEntireMailbox">Specifies whether the entire mailbox is to be restored..</param>
        public OutlookMailbox(RestoreObjectDetails mailboxObject = default(RestoreObjectDetails), List<OutlookFolder> outlookFolderList = default(List<OutlookFolder>), bool? restoreEntireMailbox = default(bool?))
        {
            this.OutlookFolderList = outlookFolderList;
            this.RestoreEntireMailbox = restoreEntireMailbox;
            this.MailboxObject = mailboxObject;
            this.OutlookFolderList = outlookFolderList;
            this.RestoreEntireMailbox = restoreEntireMailbox;
        }
        
        /// <summary>
        /// Gets or Sets MailboxObject
        /// </summary>
        [DataMember(Name="mailboxObject", EmitDefaultValue=false)]
        public RestoreObjectDetails MailboxObject { get; set; }

        /// <summary>
        /// Specifies the list of folders to be restored incase user wishes not to restore entire mailbox.
        /// </summary>
        /// <value>Specifies the list of folders to be restored incase user wishes not to restore entire mailbox.</value>
        [DataMember(Name="outlookFolderList", EmitDefaultValue=true)]
        public List<OutlookFolder> OutlookFolderList { get; set; }

        /// <summary>
        /// Specifies whether the entire mailbox is to be restored.
        /// </summary>
        /// <value>Specifies whether the entire mailbox is to be restored.</value>
        [DataMember(Name="restoreEntireMailbox", EmitDefaultValue=true)]
        public bool? RestoreEntireMailbox { get; set; }

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
            return this.Equals(input as OutlookMailbox);
        }

        /// <summary>
        /// Returns true if OutlookMailbox instances are equal
        /// </summary>
        /// <param name="input">Instance of OutlookMailbox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlookMailbox input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MailboxObject == input.MailboxObject ||
                    (this.MailboxObject != null &&
                    this.MailboxObject.Equals(input.MailboxObject))
                ) && 
                (
                    this.OutlookFolderList == input.OutlookFolderList ||
                    this.OutlookFolderList != null &&
                    input.OutlookFolderList != null &&
                    this.OutlookFolderList.Equals(input.OutlookFolderList)
                ) && 
                (
                    this.RestoreEntireMailbox == input.RestoreEntireMailbox ||
                    (this.RestoreEntireMailbox != null &&
                    this.RestoreEntireMailbox.Equals(input.RestoreEntireMailbox))
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
                if (this.MailboxObject != null)
                    hashCode = hashCode * 59 + this.MailboxObject.GetHashCode();
                if (this.OutlookFolderList != null)
                    hashCode = hashCode * 59 + this.OutlookFolderList.GetHashCode();
                if (this.RestoreEntireMailbox != null)
                    hashCode = hashCode * 59 + this.RestoreEntireMailbox.GetHashCode();
                return hashCode;
            }
        }

    }

}

