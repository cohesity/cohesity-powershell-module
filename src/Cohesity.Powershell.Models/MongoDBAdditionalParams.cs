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
    /// Contains additional  parameters required for taking backup from this Mongo cluster.
    /// </summary>
    [DataContract]
    public partial class MongoDBAdditionalParams :  IEquatable<MongoDBAdditionalParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBAdditionalParams" /> class.
        /// </summary>
        /// <param name="secondaryNodeTag">The tag associated with the secondary nodes from which backups should be performed..</param>
        /// <param name="useSecondaryForBackup">Set to true if this cluster uses secondary nodes for backup..</param>
        public MongoDBAdditionalParams(List<string> secondaryNodeTag = default(List<string>), bool? useSecondaryForBackup = default(bool?))
        {
            this.SecondaryNodeTag = secondaryNodeTag;
            this.UseSecondaryForBackup = useSecondaryForBackup;
            this.SecondaryNodeTag = secondaryNodeTag;
            this.UseSecondaryForBackup = useSecondaryForBackup;
        }
        
        /// <summary>
        /// The tag associated with the secondary nodes from which backups should be performed.
        /// </summary>
        /// <value>The tag associated with the secondary nodes from which backups should be performed.</value>
        [DataMember(Name="secondaryNodeTag", EmitDefaultValue=true)]
        public List<string> SecondaryNodeTag { get; set; }

        /// <summary>
        /// Set to true if this cluster uses secondary nodes for backup.
        /// </summary>
        /// <value>Set to true if this cluster uses secondary nodes for backup.</value>
        [DataMember(Name="useSecondaryForBackup", EmitDefaultValue=true)]
        public bool? UseSecondaryForBackup { get; set; }

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
            return this.Equals(input as MongoDBAdditionalParams);
        }

        /// <summary>
        /// Returns true if MongoDBAdditionalParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBAdditionalParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBAdditionalParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecondaryNodeTag == input.SecondaryNodeTag ||
                    this.SecondaryNodeTag != null &&
                    input.SecondaryNodeTag != null &&
                    this.SecondaryNodeTag.SequenceEqual(input.SecondaryNodeTag)
                ) && 
                (
                    this.UseSecondaryForBackup == input.UseSecondaryForBackup ||
                    (this.UseSecondaryForBackup != null &&
                    this.UseSecondaryForBackup.Equals(input.UseSecondaryForBackup))
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
                if (this.SecondaryNodeTag != null)
                    hashCode = hashCode * 59 + this.SecondaryNodeTag.GetHashCode();
                if (this.UseSecondaryForBackup != null)
                    hashCode = hashCode * 59 + this.UseSecondaryForBackup.GetHashCode();
                return hashCode;
            }
        }

    }

}

