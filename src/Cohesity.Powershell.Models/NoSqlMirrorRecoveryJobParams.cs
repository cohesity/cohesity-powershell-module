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
    /// NoSqlMirrorRecoveryJobParams
    /// </summary>
    [DataContract]
    public partial class NoSqlMirrorRecoveryJobParams :  IEquatable<NoSqlMirrorRecoveryJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlMirrorRecoveryJobParams" /> class.
        /// </summary>
        /// <param name="mirrorRestoreParentTaskId">For mirroring, this id indicates task id of parent restore task in magneto This Id can be used by Imanis scheduler to create unique drectory on Imanis Scratch Pad view for storing adapater specific meta-data files (e.g error list) that will be passed to adapters for each incremental recovery runs.</param>
        public NoSqlMirrorRecoveryJobParams(long? mirrorRestoreParentTaskId = default(long?))
        {
            this.MirrorRestoreParentTaskId = mirrorRestoreParentTaskId;
            this.MirrorRestoreParentTaskId = mirrorRestoreParentTaskId;
        }
        
        /// <summary>
        /// For mirroring, this id indicates task id of parent restore task in magneto This Id can be used by Imanis scheduler to create unique drectory on Imanis Scratch Pad view for storing adapater specific meta-data files (e.g error list) that will be passed to adapters for each incremental recovery runs
        /// </summary>
        /// <value>For mirroring, this id indicates task id of parent restore task in magneto This Id can be used by Imanis scheduler to create unique drectory on Imanis Scratch Pad view for storing adapater specific meta-data files (e.g error list) that will be passed to adapters for each incremental recovery runs</value>
        [DataMember(Name="mirrorRestoreParentTaskId", EmitDefaultValue=true)]
        public long? MirrorRestoreParentTaskId { get; set; }

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
            return this.Equals(input as NoSqlMirrorRecoveryJobParams);
        }

        /// <summary>
        /// Returns true if NoSqlMirrorRecoveryJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlMirrorRecoveryJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlMirrorRecoveryJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MirrorRestoreParentTaskId == input.MirrorRestoreParentTaskId ||
                    (this.MirrorRestoreParentTaskId != null &&
                    this.MirrorRestoreParentTaskId.Equals(input.MirrorRestoreParentTaskId))
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
                if (this.MirrorRestoreParentTaskId != null)
                    hashCode = hashCode * 59 + this.MirrorRestoreParentTaskId.GetHashCode();
                return hashCode;
            }
        }

    }

}

