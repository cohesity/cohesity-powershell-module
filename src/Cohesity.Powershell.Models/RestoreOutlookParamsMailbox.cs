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
    /// RestoreOutlookParamsMailbox
    /// </summary>
    [DataContract]
    public partial class RestoreOutlookParamsMailbox :  IEquatable<RestoreOutlookParamsMailbox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOutlookParamsMailbox" /> class.
        /// </summary>
        /// <param name="folderVec">If is_entire_mailbox_required is set to false, user will then specify which particular folders are to be restored..</param>
        /// <param name="isEntireMailboxRequired">Specify if the entire mailbox is to be restored..</param>
        /// <param name="_object">_object.</param>
        public RestoreOutlookParamsMailbox(List<RestoreOutlookParamsFolder> folderVec = default(List<RestoreOutlookParamsFolder>), bool? isEntireMailboxRequired = default(bool?), RestoreObject _object = default(RestoreObject))
        {
            this.FolderVec = folderVec;
            this.IsEntireMailboxRequired = isEntireMailboxRequired;
            this.FolderVec = folderVec;
            this.IsEntireMailboxRequired = isEntireMailboxRequired;
            this.Object = _object;
        }
        
        /// <summary>
        /// If is_entire_mailbox_required is set to false, user will then specify which particular folders are to be restored.
        /// </summary>
        /// <value>If is_entire_mailbox_required is set to false, user will then specify which particular folders are to be restored.</value>
        [DataMember(Name="folderVec", EmitDefaultValue=true)]
        public List<RestoreOutlookParamsFolder> FolderVec { get; set; }

        /// <summary>
        /// Specify if the entire mailbox is to be restored.
        /// </summary>
        /// <value>Specify if the entire mailbox is to be restored.</value>
        [DataMember(Name="isEntireMailboxRequired", EmitDefaultValue=true)]
        public bool? IsEntireMailboxRequired { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public RestoreObject Object { get; set; }

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
            return this.Equals(input as RestoreOutlookParamsMailbox);
        }

        /// <summary>
        /// Returns true if RestoreOutlookParamsMailbox instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOutlookParamsMailbox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOutlookParamsMailbox input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FolderVec == input.FolderVec ||
                    this.FolderVec != null &&
                    input.FolderVec != null &&
                    this.FolderVec.SequenceEqual(input.FolderVec)
                ) && 
                (
                    this.IsEntireMailboxRequired == input.IsEntireMailboxRequired ||
                    (this.IsEntireMailboxRequired != null &&
                    this.IsEntireMailboxRequired.Equals(input.IsEntireMailboxRequired))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.FolderVec != null)
                    hashCode = hashCode * 59 + this.FolderVec.GetHashCode();
                if (this.IsEntireMailboxRequired != null)
                    hashCode = hashCode * 59 + this.IsEntireMailboxRequired.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                return hashCode;
            }
        }

    }

}

