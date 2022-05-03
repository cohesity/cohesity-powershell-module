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
    /// OracleUpdateRestoreTaskOptions holds the information needed for updating an Oracle restore task. Currently this contains Oracle clone specific details, which would be needed in the migration workflow.
    /// </summary>
    [DataContract]
    public partial class OracleUpdateRestoreTaskOptions :  IEquatable<OracleUpdateRestoreTaskOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleUpdateRestoreTaskOptions" /> class.
        /// </summary>
        /// <param name="migrateCloneParams">migrateCloneParams.</param>
        public OracleUpdateRestoreTaskOptions(MigrateOracleCloneParams migrateCloneParams = default(MigrateOracleCloneParams))
        {
            this.MigrateCloneParams = migrateCloneParams;
        }
        
        /// <summary>
        /// Gets or Sets MigrateCloneParams
        /// </summary>
        [DataMember(Name="MigrateCloneParams", EmitDefaultValue=false)]
        public MigrateOracleCloneParams MigrateCloneParams { get; set; }

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
            return this.Equals(input as OracleUpdateRestoreTaskOptions);
        }

        /// <summary>
        /// Returns true if OracleUpdateRestoreTaskOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleUpdateRestoreTaskOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleUpdateRestoreTaskOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigrateCloneParams == input.MigrateCloneParams ||
                    (this.MigrateCloneParams != null &&
                    this.MigrateCloneParams.Equals(input.MigrateCloneParams))
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
                if (this.MigrateCloneParams != null)
                    hashCode = hashCode * 59 + this.MigrateCloneParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

