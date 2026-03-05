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
    /// This message defines the per object restore parameters for restoring a single user&#39;s mailbox.
    /// </summary>
    [DataContract]
    public partial class O365OutlookRestoreEntityParams :  IEquatable<O365OutlookRestoreEntityParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365OutlookRestoreEntityParams" /> class.
        /// </summary>
        /// <param name="snapshotFolderCounts">Stores the count of folders associated with different roots during the backup process in current snapshot..</param>
        public O365OutlookRestoreEntityParams(List<SnapshotFolderCounts> snapshotFolderCounts = default(List<SnapshotFolderCounts>))
        {
            this.SnapshotFolderCounts = snapshotFolderCounts;
            this.SnapshotFolderCounts = snapshotFolderCounts;
        }
        
        /// <summary>
        /// Stores the count of folders associated with different roots during the backup process in current snapshot.
        /// </summary>
        /// <value>Stores the count of folders associated with different roots during the backup process in current snapshot.</value>
        [DataMember(Name="snapshotFolderCounts", EmitDefaultValue=true)]
        public List<SnapshotFolderCounts> SnapshotFolderCounts { get; set; }

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
            return this.Equals(input as O365OutlookRestoreEntityParams);
        }

        /// <summary>
        /// Returns true if O365OutlookRestoreEntityParams instances are equal
        /// </summary>
        /// <param name="input">Instance of O365OutlookRestoreEntityParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365OutlookRestoreEntityParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SnapshotFolderCounts == input.SnapshotFolderCounts ||
                    this.SnapshotFolderCounts != null &&
                    input.SnapshotFolderCounts != null &&
                    this.SnapshotFolderCounts.SequenceEqual(input.SnapshotFolderCounts)
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
                if (this.SnapshotFolderCounts != null)
                    hashCode = hashCode * 59 + this.SnapshotFolderCounts.GetHashCode();
                return hashCode;
            }
        }

    }

}

