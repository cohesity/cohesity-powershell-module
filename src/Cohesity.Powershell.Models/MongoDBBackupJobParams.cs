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
        /// <param name="mongodbAdditionalInfo">mongodbAdditionalInfo.</param>
        public MongoDBBackupJobParams(MongoDBAdditionalParams mongodbAdditionalInfo = default(MongoDBAdditionalParams))
        {
            this.MongodbAdditionalInfo = mongodbAdditionalInfo;
        }
        
        /// <summary>
        /// Gets or Sets MongodbAdditionalInfo
        /// </summary>
        [DataMember(Name="mongodbAdditionalInfo", EmitDefaultValue=false)]
        public MongoDBAdditionalParams MongodbAdditionalInfo { get; set; }

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
                    this.MongodbAdditionalInfo == input.MongodbAdditionalInfo ||
                    (this.MongodbAdditionalInfo != null &&
                    this.MongodbAdditionalInfo.Equals(input.MongodbAdditionalInfo))
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
                if (this.MongodbAdditionalInfo != null)
                    hashCode = hashCode * 59 + this.MongodbAdditionalInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

