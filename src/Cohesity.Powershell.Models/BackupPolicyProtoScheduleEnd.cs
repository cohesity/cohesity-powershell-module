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
    /// BackupPolicyProtoScheduleEnd
    /// </summary>
    [DataContract]
    public partial class BackupPolicyProtoScheduleEnd :  IEquatable<BackupPolicyProtoScheduleEnd>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupPolicyProtoScheduleEnd" /> class.
        /// </summary>
        /// <param name="endAfterNumBackups">The following field has been deprecated. TODO(mark): Append \&quot;_DEPRECATED\&quot; to this field name once iris has stopped referring to it.  If specified, the backup job will no longer be run after it has been run these many times..</param>
        /// <param name="endTimeUsecs">If specified, the backup job will no longer be run after this time..</param>
        public BackupPolicyProtoScheduleEnd(long? endAfterNumBackups = default(long?), long? endTimeUsecs = default(long?))
        {
            this.EndAfterNumBackups = endAfterNumBackups;
            this.EndTimeUsecs = endTimeUsecs;
            this.EndAfterNumBackups = endAfterNumBackups;
            this.EndTimeUsecs = endTimeUsecs;
        }
        
        /// <summary>
        /// The following field has been deprecated. TODO(mark): Append \&quot;_DEPRECATED\&quot; to this field name once iris has stopped referring to it.  If specified, the backup job will no longer be run after it has been run these many times.
        /// </summary>
        /// <value>The following field has been deprecated. TODO(mark): Append \&quot;_DEPRECATED\&quot; to this field name once iris has stopped referring to it.  If specified, the backup job will no longer be run after it has been run these many times.</value>
        [DataMember(Name="endAfterNumBackups", EmitDefaultValue=true)]
        public long? EndAfterNumBackups { get; set; }

        /// <summary>
        /// If specified, the backup job will no longer be run after this time.
        /// </summary>
        /// <value>If specified, the backup job will no longer be run after this time.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupPolicyProtoScheduleEnd {\n");
            sb.Append("  EndAfterNumBackups: ").Append(EndAfterNumBackups).Append("\n");
            sb.Append("  EndTimeUsecs: ").Append(EndTimeUsecs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as BackupPolicyProtoScheduleEnd);
        }

        /// <summary>
        /// Returns true if BackupPolicyProtoScheduleEnd instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupPolicyProtoScheduleEnd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupPolicyProtoScheduleEnd input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndAfterNumBackups == input.EndAfterNumBackups ||
                    (this.EndAfterNumBackups != null &&
                    this.EndAfterNumBackups.Equals(input.EndAfterNumBackups))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
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
                if (this.EndAfterNumBackups != null)
                    hashCode = hashCode * 59 + this.EndAfterNumBackups.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}
