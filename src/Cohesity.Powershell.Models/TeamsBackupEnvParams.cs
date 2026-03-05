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
    /// Message to capture any additional backup params for Teams within the Office365 environment.
    /// </summary>
    [DataContract]
    public partial class TeamsBackupEnvParams :  IEquatable<TeamsBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsBackupEnvParams" /> class.
        /// </summary>
        /// <param name="chatsBackupStartTimeMsecs">Specifies the time from which the backup process should start. Only data from this time onward will be included in the backup. It&#39;s epoch time in milliseconds..</param>
        /// <param name="teamsExclusionTypes">Specifies the types of exclusions to apply for Teams backup..</param>
        public TeamsBackupEnvParams(long? chatsBackupStartTimeMsecs = default(long?), List<int> teamsExclusionTypes = default(List<int>))
        {
            this.ChatsBackupStartTimeMsecs = chatsBackupStartTimeMsecs;
            this.TeamsExclusionTypes = teamsExclusionTypes;
            this.ChatsBackupStartTimeMsecs = chatsBackupStartTimeMsecs;
            this.TeamsExclusionTypes = teamsExclusionTypes;
        }
        
        /// <summary>
        /// Specifies the time from which the backup process should start. Only data from this time onward will be included in the backup. It&#39;s epoch time in milliseconds.
        /// </summary>
        /// <value>Specifies the time from which the backup process should start. Only data from this time onward will be included in the backup. It&#39;s epoch time in milliseconds.</value>
        [DataMember(Name="chatsBackupStartTimeMsecs", EmitDefaultValue=true)]
        public long? ChatsBackupStartTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the types of exclusions to apply for Teams backup.
        /// </summary>
        /// <value>Specifies the types of exclusions to apply for Teams backup.</value>
        [DataMember(Name="teamsExclusionTypes", EmitDefaultValue=true)]
        public List<int> TeamsExclusionTypes { get; set; }

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
            return this.Equals(input as TeamsBackupEnvParams);
        }

        /// <summary>
        /// Returns true if TeamsBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamsBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsBackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChatsBackupStartTimeMsecs == input.ChatsBackupStartTimeMsecs ||
                    (this.ChatsBackupStartTimeMsecs != null &&
                    this.ChatsBackupStartTimeMsecs.Equals(input.ChatsBackupStartTimeMsecs))
                ) && 
                (
                    this.TeamsExclusionTypes == input.TeamsExclusionTypes ||
                    this.TeamsExclusionTypes != null &&
                    input.TeamsExclusionTypes != null &&
                    this.TeamsExclusionTypes.SequenceEqual(input.TeamsExclusionTypes)
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
                if (this.ChatsBackupStartTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ChatsBackupStartTimeMsecs.GetHashCode();
                if (this.TeamsExclusionTypes != null)
                    hashCode = hashCode * 59 + this.TeamsExclusionTypes.GetHashCode();
                return hashCode;
            }
        }

    }

}

