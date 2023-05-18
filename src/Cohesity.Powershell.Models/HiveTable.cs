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
    /// Specifies an Object containing information about a Hive table.
    /// </summary>
    [DataContract]
    public partial class HiveTable :  IEquatable<HiveTable>
    {
        /// <summary>
        /// Specifies the type of table ex. MANAGED,VIRTUAL etc. Specifies the type of an Hive table. &#39;kManaged&#39; indicates a MANAGED Hive table. &#39;kExternal&#39; indicates a EXTERNAL Hive table. &#39;kVirtual&#39; indicates a VIRTUAL Hive tablet. &#39;kIndex&#39; indicates a INDEX Hive table.
        /// </summary>
        /// <value>Specifies the type of table ex. MANAGED,VIRTUAL etc. Specifies the type of an Hive table. &#39;kManaged&#39; indicates a MANAGED Hive table. &#39;kExternal&#39; indicates a EXTERNAL Hive table. &#39;kVirtual&#39; indicates a VIRTUAL Hive tablet. &#39;kIndex&#39; indicates a INDEX Hive table.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TableTypeEnum
        {
            /// <summary>
            /// Enum KManaged for value: kManaged
            /// </summary>
            [EnumMember(Value = "kManaged")]
            KManaged = 1,

            /// <summary>
            /// Enum KExternal for value: kExternal
            /// </summary>
            [EnumMember(Value = "kExternal")]
            KExternal = 2,

            /// <summary>
            /// Enum KVirtual for value: kVirtual
            /// </summary>
            [EnumMember(Value = "kVirtual")]
            KVirtual = 3,

            /// <summary>
            /// Enum KIndex for value: kIndex
            /// </summary>
            [EnumMember(Value = "kIndex")]
            KIndex = 4

        }

        /// <summary>
        /// Specifies the type of table ex. MANAGED,VIRTUAL etc. Specifies the type of an Hive table. &#39;kManaged&#39; indicates a MANAGED Hive table. &#39;kExternal&#39; indicates a EXTERNAL Hive table. &#39;kVirtual&#39; indicates a VIRTUAL Hive tablet. &#39;kIndex&#39; indicates a INDEX Hive table.
        /// </summary>
        /// <value>Specifies the type of table ex. MANAGED,VIRTUAL etc. Specifies the type of an Hive table. &#39;kManaged&#39; indicates a MANAGED Hive table. &#39;kExternal&#39; indicates a EXTERNAL Hive table. &#39;kVirtual&#39; indicates a VIRTUAL Hive tablet. &#39;kIndex&#39; indicates a INDEX Hive table.</value>
        [DataMember(Name="tableType", EmitDefaultValue=true)]
        public TableTypeEnum? TableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HiveTable" /> class.
        /// </summary>
        /// <param name="approxSizeBytes">Specifies the approx size of the table in bytes..</param>
        /// <param name="createdOn">Specifies the created on, epoch millis..</param>
        /// <param name="isTransactionalTable">Specifies if this is a transactional table..</param>
        /// <param name="owner">Specifies the owner of the table..</param>
        /// <param name="tableType">Specifies the type of table ex. MANAGED,VIRTUAL etc. Specifies the type of an Hive table. &#39;kManaged&#39; indicates a MANAGED Hive table. &#39;kExternal&#39; indicates a EXTERNAL Hive table. &#39;kVirtual&#39; indicates a VIRTUAL Hive tablet. &#39;kIndex&#39; indicates a INDEX Hive table..</param>
        public HiveTable(long? approxSizeBytes = default(long?), long? createdOn = default(long?), bool? isTransactionalTable = default(bool?), string owner = default(string), TableTypeEnum? tableType = default(TableTypeEnum?))
        {
            this.ApproxSizeBytes = approxSizeBytes;
            this.CreatedOn = createdOn;
            this.IsTransactionalTable = isTransactionalTable;
            this.Owner = owner;
            this.TableType = tableType;
            this.ApproxSizeBytes = approxSizeBytes;
            this.CreatedOn = createdOn;
            this.IsTransactionalTable = isTransactionalTable;
            this.Owner = owner;
            this.TableType = tableType;
        }
        
        /// <summary>
        /// Specifies the approx size of the table in bytes.
        /// </summary>
        /// <value>Specifies the approx size of the table in bytes.</value>
        [DataMember(Name="approxSizeBytes", EmitDefaultValue=true)]
        public long? ApproxSizeBytes { get; set; }

        /// <summary>
        /// Specifies the created on, epoch millis.
        /// </summary>
        /// <value>Specifies the created on, epoch millis.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// Specifies if this is a transactional table.
        /// </summary>
        /// <value>Specifies if this is a transactional table.</value>
        [DataMember(Name="isTransactionalTable", EmitDefaultValue=true)]
        public bool? IsTransactionalTable { get; set; }

        /// <summary>
        /// Specifies the owner of the table.
        /// </summary>
        /// <value>Specifies the owner of the table.</value>
        [DataMember(Name="owner", EmitDefaultValue=true)]
        public string Owner { get; set; }

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
            return this.Equals(input as HiveTable);
        }

        /// <summary>
        /// Returns true if HiveTable instances are equal
        /// </summary>
        /// <param name="input">Instance of HiveTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HiveTable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApproxSizeBytes == input.ApproxSizeBytes ||
                    (this.ApproxSizeBytes != null &&
                    this.ApproxSizeBytes.Equals(input.ApproxSizeBytes))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.IsTransactionalTable == input.IsTransactionalTable ||
                    (this.IsTransactionalTable != null &&
                    this.IsTransactionalTable.Equals(input.IsTransactionalTable))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.TableType == input.TableType ||
                    this.TableType.Equals(input.TableType)
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
                if (this.ApproxSizeBytes != null)
                    hashCode = hashCode * 59 + this.ApproxSizeBytes.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.IsTransactionalTable != null)
                    hashCode = hashCode * 59 + this.IsTransactionalTable.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                hashCode = hashCode * 59 + this.TableType.GetHashCode();
                return hashCode;
            }
        }

    }

}

