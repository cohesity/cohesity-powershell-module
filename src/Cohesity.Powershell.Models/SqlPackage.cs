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
    /// Details can be found here https://tinyurl.com/ysryshrx
    /// </summary>
    [DataContract]
    public partial class SqlPackage :  IEquatable<SqlPackage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlPackage" /> class.
        /// </summary>
        /// <param name="compression">Only applies to backup..</param>
        /// <param name="maxParallelism">Specifies the degree of parallelism for concurrent operations running against a database. The default value is 8. Applies to backup/restore..</param>
        /// <param name="verifyExtraction">Specifies whether the extracted schema model should be verified. If set to true, schema validation rules are run on the dacpac or bacpac. Only applies to backup..</param>
        public SqlPackage(int? compression = default(int?), int? maxParallelism = default(int?), bool? verifyExtraction = default(bool?))
        {
            this.Compression = compression;
            this.MaxParallelism = maxParallelism;
            this.VerifyExtraction = verifyExtraction;
            this.Compression = compression;
            this.MaxParallelism = maxParallelism;
            this.VerifyExtraction = verifyExtraction;
        }
        
        /// <summary>
        /// Only applies to backup.
        /// </summary>
        /// <value>Only applies to backup.</value>
        [DataMember(Name="compression", EmitDefaultValue=true)]
        public int? Compression { get; set; }

        /// <summary>
        /// Specifies the degree of parallelism for concurrent operations running against a database. The default value is 8. Applies to backup/restore.
        /// </summary>
        /// <value>Specifies the degree of parallelism for concurrent operations running against a database. The default value is 8. Applies to backup/restore.</value>
        [DataMember(Name="maxParallelism", EmitDefaultValue=true)]
        public int? MaxParallelism { get; set; }

        /// <summary>
        /// Specifies whether the extracted schema model should be verified. If set to true, schema validation rules are run on the dacpac or bacpac. Only applies to backup.
        /// </summary>
        /// <value>Specifies whether the extracted schema model should be verified. If set to true, schema validation rules are run on the dacpac or bacpac. Only applies to backup.</value>
        [DataMember(Name="verifyExtraction", EmitDefaultValue=true)]
        public bool? VerifyExtraction { get; set; }

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
            return this.Equals(input as SqlPackage);
        }

        /// <summary>
        /// Returns true if SqlPackage instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlPackage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Compression == input.Compression ||
                    (this.Compression != null &&
                    this.Compression.Equals(input.Compression))
                ) && 
                (
                    this.MaxParallelism == input.MaxParallelism ||
                    (this.MaxParallelism != null &&
                    this.MaxParallelism.Equals(input.MaxParallelism))
                ) && 
                (
                    this.VerifyExtraction == input.VerifyExtraction ||
                    (this.VerifyExtraction != null &&
                    this.VerifyExtraction.Equals(input.VerifyExtraction))
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
                if (this.Compression != null)
                    hashCode = hashCode * 59 + this.Compression.GetHashCode();
                if (this.MaxParallelism != null)
                    hashCode = hashCode * 59 + this.MaxParallelism.GetHashCode();
                if (this.VerifyExtraction != null)
                    hashCode = hashCode * 59 + this.VerifyExtraction.GetHashCode();
                return hashCode;
            }
        }

    }

}

