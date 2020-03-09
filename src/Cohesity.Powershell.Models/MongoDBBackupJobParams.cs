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
    /// Contains any additional mongodb environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class MongoDBBackupJobParams :  IEquatable<MongoDBBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBBackupJobParams" /> class.
        /// </summary>
        /// <param name="mongoAdditionalInfo">mongoAdditionalInfo.</param>
        public MongoDBBackupJobParams(MongoDBAdditionalParams mongoAdditionalInfo = default(MongoDBAdditionalParams))
        {
            this.MongoAdditionalInfo = mongoAdditionalInfo;
        }
        
        /// <summary>
        /// Gets or Sets MongoAdditionalInfo
        /// </summary>
        [DataMember(Name="mongoAdditionalInfo", EmitDefaultValue=false)]
        public MongoDBAdditionalParams MongoAdditionalInfo { get; set; }

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
            return this.Equals(input as MongoDBBackupJobParams);
        }

        /// <summary>
        /// Returns true if MongoDBBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MongoAdditionalInfo == input.MongoAdditionalInfo ||
                    (this.MongoAdditionalInfo != null &&
                    this.MongoAdditionalInfo.Equals(input.MongoAdditionalInfo))
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
                if (this.MongoAdditionalInfo != null)
                    hashCode = hashCode * 59 + this.MongoAdditionalInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

