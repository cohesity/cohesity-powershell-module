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
    /// RestoreRDSPostgresParams
    /// </summary>
    [DataContract]
    public partial class RestoreRDSPostgresParams :  IEquatable<RestoreRDSPostgresParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreRDSPostgresParams" /> class.
        /// </summary>
        /// <param name="awsTargetParams">awsTargetParams.</param>
        /// <param name="overwriteDatabase">If false, recovery will fail if the database (with same name as this request) exists on the target server. If true, recovery will delete/overwrite the existing database as part of recovery..</param>
        /// <param name="prefixToDatabaseName">Specifies the prefix to be prepended to the object name after the recovery..</param>
        /// <param name="suffixToDatabaseName">Specifies the suffix to be appended to the object name after the recovery..</param>
        public RestoreRDSPostgresParams(AwsTargetParams awsTargetParams = default(AwsTargetParams), bool? overwriteDatabase = default(bool?), string prefixToDatabaseName = default(string), string suffixToDatabaseName = default(string))
        {
            this.OverwriteDatabase = overwriteDatabase;
            this.PrefixToDatabaseName = prefixToDatabaseName;
            this.SuffixToDatabaseName = suffixToDatabaseName;
            this.AwsTargetParams = awsTargetParams;
            this.OverwriteDatabase = overwriteDatabase;
            this.PrefixToDatabaseName = prefixToDatabaseName;
            this.SuffixToDatabaseName = suffixToDatabaseName;
        }
        
        /// <summary>
        /// Gets or Sets AwsTargetParams
        /// </summary>
        [DataMember(Name="awsTargetParams", EmitDefaultValue=false)]
        public AwsTargetParams AwsTargetParams { get; set; }

        /// <summary>
        /// If false, recovery will fail if the database (with same name as this request) exists on the target server. If true, recovery will delete/overwrite the existing database as part of recovery.
        /// </summary>
        /// <value>If false, recovery will fail if the database (with same name as this request) exists on the target server. If true, recovery will delete/overwrite the existing database as part of recovery.</value>
        [DataMember(Name="overwriteDatabase", EmitDefaultValue=true)]
        public bool? OverwriteDatabase { get; set; }

        /// <summary>
        /// Specifies the prefix to be prepended to the object name after the recovery.
        /// </summary>
        /// <value>Specifies the prefix to be prepended to the object name after the recovery.</value>
        [DataMember(Name="prefixToDatabaseName", EmitDefaultValue=true)]
        public string PrefixToDatabaseName { get; set; }

        /// <summary>
        /// Specifies the suffix to be appended to the object name after the recovery.
        /// </summary>
        /// <value>Specifies the suffix to be appended to the object name after the recovery.</value>
        [DataMember(Name="suffixToDatabaseName", EmitDefaultValue=true)]
        public string SuffixToDatabaseName { get; set; }

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
            return this.Equals(input as RestoreRDSPostgresParams);
        }

        /// <summary>
        /// Returns true if RestoreRDSPostgresParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreRDSPostgresParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreRDSPostgresParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsTargetParams == input.AwsTargetParams ||
                    (this.AwsTargetParams != null &&
                    this.AwsTargetParams.Equals(input.AwsTargetParams))
                ) && 
                (
                    this.OverwriteDatabase == input.OverwriteDatabase ||
                    (this.OverwriteDatabase != null &&
                    this.OverwriteDatabase.Equals(input.OverwriteDatabase))
                ) && 
                (
                    this.PrefixToDatabaseName == input.PrefixToDatabaseName ||
                    (this.PrefixToDatabaseName != null &&
                    this.PrefixToDatabaseName.Equals(input.PrefixToDatabaseName))
                ) && 
                (
                    this.SuffixToDatabaseName == input.SuffixToDatabaseName ||
                    (this.SuffixToDatabaseName != null &&
                    this.SuffixToDatabaseName.Equals(input.SuffixToDatabaseName))
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
                if (this.AwsTargetParams != null)
                    hashCode = hashCode * 59 + this.AwsTargetParams.GetHashCode();
                if (this.OverwriteDatabase != null)
                    hashCode = hashCode * 59 + this.OverwriteDatabase.GetHashCode();
                if (this.PrefixToDatabaseName != null)
                    hashCode = hashCode * 59 + this.PrefixToDatabaseName.GetHashCode();
                if (this.SuffixToDatabaseName != null)
                    hashCode = hashCode * 59 + this.SuffixToDatabaseName.GetHashCode();
                return hashCode;
            }
        }

    }

}

