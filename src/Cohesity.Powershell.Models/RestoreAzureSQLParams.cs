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
    /// RestoreAzureSQLParams
    /// </summary>
    [DataContract]
    public partial class RestoreAzureSQLParams :  IEquatable<RestoreAzureSQLParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAzureSQLParams" /> class.
        /// </summary>
        /// <param name="diskType">The type of temporary disk to be provisioned for database restore..</param>
        /// <param name="newDatabaseName">The new name of the database. It is optional, if not specified then backup time database name will be used..</param>
        /// <param name="overwriteDatabase">If false, recovery will fail if the database (with same name as this request) exists on the target server. If true, recovery will delete/overwrite the existing database as part of recovery..</param>
        /// <param name="restoredDbSku">restoredDbSku.</param>
        /// <param name="sqlPackageOptions">sqlPackageOptions.</param>
        public RestoreAzureSQLParams(int? diskType = default(int?), string newDatabaseName = default(string), bool? overwriteDatabase = default(bool?), EntitySKU restoredDbSku = default(EntitySKU), SqlPackage sqlPackageOptions = default(SqlPackage))
        {
            this.DiskType = diskType;
            this.NewDatabaseName = newDatabaseName;
            this.OverwriteDatabase = overwriteDatabase;
            this.DiskType = diskType;
            this.NewDatabaseName = newDatabaseName;
            this.OverwriteDatabase = overwriteDatabase;
            this.RestoredDbSku = restoredDbSku;
            this.SqlPackageOptions = sqlPackageOptions;
        }
        
        /// <summary>
        /// The type of temporary disk to be provisioned for database restore.
        /// </summary>
        /// <value>The type of temporary disk to be provisioned for database restore.</value>
        [DataMember(Name="diskType", EmitDefaultValue=true)]
        public int? DiskType { get; set; }

        /// <summary>
        /// The new name of the database. It is optional, if not specified then backup time database name will be used.
        /// </summary>
        /// <value>The new name of the database. It is optional, if not specified then backup time database name will be used.</value>
        [DataMember(Name="newDatabaseName", EmitDefaultValue=true)]
        public string NewDatabaseName { get; set; }

        /// <summary>
        /// If false, recovery will fail if the database (with same name as this request) exists on the target server. If true, recovery will delete/overwrite the existing database as part of recovery.
        /// </summary>
        /// <value>If false, recovery will fail if the database (with same name as this request) exists on the target server. If true, recovery will delete/overwrite the existing database as part of recovery.</value>
        [DataMember(Name="overwriteDatabase", EmitDefaultValue=true)]
        public bool? OverwriteDatabase { get; set; }

        /// <summary>
        /// Gets or Sets RestoredDbSku
        /// </summary>
        [DataMember(Name="restoredDbSku", EmitDefaultValue=false)]
        public EntitySKU RestoredDbSku { get; set; }

        /// <summary>
        /// Gets or Sets SqlPackageOptions
        /// </summary>
        [DataMember(Name="sqlPackageOptions", EmitDefaultValue=false)]
        public SqlPackage SqlPackageOptions { get; set; }

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
            return this.Equals(input as RestoreAzureSQLParams);
        }

        /// <summary>
        /// Returns true if RestoreAzureSQLParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAzureSQLParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAzureSQLParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskType == input.DiskType ||
                    (this.DiskType != null &&
                    this.DiskType.Equals(input.DiskType))
                ) && 
                (
                    this.NewDatabaseName == input.NewDatabaseName ||
                    (this.NewDatabaseName != null &&
                    this.NewDatabaseName.Equals(input.NewDatabaseName))
                ) && 
                (
                    this.OverwriteDatabase == input.OverwriteDatabase ||
                    (this.OverwriteDatabase != null &&
                    this.OverwriteDatabase.Equals(input.OverwriteDatabase))
                ) && 
                (
                    this.RestoredDbSku == input.RestoredDbSku ||
                    (this.RestoredDbSku != null &&
                    this.RestoredDbSku.Equals(input.RestoredDbSku))
                ) && 
                (
                    this.SqlPackageOptions == input.SqlPackageOptions ||
                    (this.SqlPackageOptions != null &&
                    this.SqlPackageOptions.Equals(input.SqlPackageOptions))
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
                if (this.DiskType != null)
                    hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                if (this.NewDatabaseName != null)
                    hashCode = hashCode * 59 + this.NewDatabaseName.GetHashCode();
                if (this.OverwriteDatabase != null)
                    hashCode = hashCode * 59 + this.OverwriteDatabase.GetHashCode();
                if (this.RestoredDbSku != null)
                    hashCode = hashCode * 59 + this.RestoredDbSku.GetHashCode();
                if (this.SqlPackageOptions != null)
                    hashCode = hashCode * 59 + this.SqlPackageOptions.GetHashCode();
                return hashCode;
            }
        }

    }

}

