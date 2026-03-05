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
    /// Message to capture additional backup params specific to Azure SQL.
    /// </summary>
    [DataContract]
    public partial class AzureSqlEnvBackupParamsProto :  IEquatable<AzureSqlEnvBackupParamsProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureSqlEnvBackupParamsProto" /> class.
        /// </summary>
        /// <param name="copyDatabase">If the flag is set to true, a copy of the database is created during backup, and the backup is performed from the copied database. This backup will be transactionally consistent. If the flag is set to false, the backup is performed from the production database while transactions are in progress. In this case, the backup will be transactionally inconsistent, and recovery can fail or the recovered database may be in an inconsistent state..</param>
        /// <param name="copyDbSku">copyDbSku.</param>
        /// <param name="diskType">The type of temporary disk to be provisioned for database backup..</param>
        /// <param name="sqlPackageOptions">sqlPackageOptions.</param>
        /// <param name="tempDiskSizeGb">Size of the disk we will attach to rigel to use for exporting this DB..</param>
        public AzureSqlEnvBackupParamsProto(bool? copyDatabase = default(bool?), EntitySKU copyDbSku = default(EntitySKU), int? diskType = default(int?), SqlPackage sqlPackageOptions = default(SqlPackage), int? tempDiskSizeGb = default(int?))
        {
            this.CopyDatabase = copyDatabase;
            this.DiskType = diskType;
            this.TempDiskSizeGb = tempDiskSizeGb;
            this.CopyDatabase = copyDatabase;
            this.CopyDbSku = copyDbSku;
            this.DiskType = diskType;
            this.SqlPackageOptions = sqlPackageOptions;
            this.TempDiskSizeGb = tempDiskSizeGb;
        }
        
        /// <summary>
        /// If the flag is set to true, a copy of the database is created during backup, and the backup is performed from the copied database. This backup will be transactionally consistent. If the flag is set to false, the backup is performed from the production database while transactions are in progress. In this case, the backup will be transactionally inconsistent, and recovery can fail or the recovered database may be in an inconsistent state.
        /// </summary>
        /// <value>If the flag is set to true, a copy of the database is created during backup, and the backup is performed from the copied database. This backup will be transactionally consistent. If the flag is set to false, the backup is performed from the production database while transactions are in progress. In this case, the backup will be transactionally inconsistent, and recovery can fail or the recovered database may be in an inconsistent state.</value>
        [DataMember(Name="copyDatabase", EmitDefaultValue=true)]
        public bool? CopyDatabase { get; set; }

        /// <summary>
        /// Gets or Sets CopyDbSku
        /// </summary>
        [DataMember(Name="copyDbSku", EmitDefaultValue=false)]
        public EntitySKU CopyDbSku { get; set; }

        /// <summary>
        /// The type of temporary disk to be provisioned for database backup.
        /// </summary>
        /// <value>The type of temporary disk to be provisioned for database backup.</value>
        [DataMember(Name="diskType", EmitDefaultValue=true)]
        public int? DiskType { get; set; }

        /// <summary>
        /// Gets or Sets SqlPackageOptions
        /// </summary>
        [DataMember(Name="sqlPackageOptions", EmitDefaultValue=false)]
        public SqlPackage SqlPackageOptions { get; set; }

        /// <summary>
        /// Size of the disk we will attach to rigel to use for exporting this DB.
        /// </summary>
        /// <value>Size of the disk we will attach to rigel to use for exporting this DB.</value>
        [DataMember(Name="tempDiskSizeGb", EmitDefaultValue=true)]
        public int? TempDiskSizeGb { get; set; }

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
            return this.Equals(input as AzureSqlEnvBackupParamsProto);
        }

        /// <summary>
        /// Returns true if AzureSqlEnvBackupParamsProto instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureSqlEnvBackupParamsProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureSqlEnvBackupParamsProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyDatabase == input.CopyDatabase ||
                    (this.CopyDatabase != null &&
                    this.CopyDatabase.Equals(input.CopyDatabase))
                ) && 
                (
                    this.CopyDbSku == input.CopyDbSku ||
                    (this.CopyDbSku != null &&
                    this.CopyDbSku.Equals(input.CopyDbSku))
                ) && 
                (
                    this.DiskType == input.DiskType ||
                    (this.DiskType != null &&
                    this.DiskType.Equals(input.DiskType))
                ) && 
                (
                    this.SqlPackageOptions == input.SqlPackageOptions ||
                    (this.SqlPackageOptions != null &&
                    this.SqlPackageOptions.Equals(input.SqlPackageOptions))
                ) && 
                (
                    this.TempDiskSizeGb == input.TempDiskSizeGb ||
                    (this.TempDiskSizeGb != null &&
                    this.TempDiskSizeGb.Equals(input.TempDiskSizeGb))
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
                if (this.CopyDatabase != null)
                    hashCode = hashCode * 59 + this.CopyDatabase.GetHashCode();
                if (this.CopyDbSku != null)
                    hashCode = hashCode * 59 + this.CopyDbSku.GetHashCode();
                if (this.DiskType != null)
                    hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                if (this.SqlPackageOptions != null)
                    hashCode = hashCode * 59 + this.SqlPackageOptions.GetHashCode();
                if (this.TempDiskSizeGb != null)
                    hashCode = hashCode * 59 + this.TempDiskSizeGb.GetHashCode();
                return hashCode;
            }
        }

    }

}

