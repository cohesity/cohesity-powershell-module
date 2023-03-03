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
    /// Specifies information about a database file.
    /// </summary>
    [DataContract]
    public partial class DbFileInfo :  IEquatable<DbFileInfo>
    {
        /// <summary>
        /// Specifies the format type of the file that SQL database stores the data. Specifies the format type of the file that SQL database stores the data. &#39;kRows&#39; refers to a data file &#39;kLog&#39; refers to a log file &#39;kFileStream&#39; refers to a directory containing FILESTREAM data &#39;kNotSupportedType&#39; is for information purposes only. Not supported. &#39;kFullText&#39; refers to a full-text catalog.
        /// </summary>
        /// <value>Specifies the format type of the file that SQL database stores the data. Specifies the format type of the file that SQL database stores the data. &#39;kRows&#39; refers to a data file &#39;kLog&#39; refers to a log file &#39;kFileStream&#39; refers to a directory containing FILESTREAM data &#39;kNotSupportedType&#39; is for information purposes only. Not supported. &#39;kFullText&#39; refers to a full-text catalog.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileTypeEnum
        {
            /// <summary>
            /// Enum KRows for value: kRows
            /// </summary>
            [EnumMember(Value = "kRows")]
            KRows = 1,

            /// <summary>
            /// Enum KLog for value: kLog
            /// </summary>
            [EnumMember(Value = "kLog")]
            KLog = 2,

            /// <summary>
            /// Enum KFileStream for value: kFileStream
            /// </summary>
            [EnumMember(Value = "kFileStream")]
            KFileStream = 3,

            /// <summary>
            /// Enum KNotSupportedType for value: kNotSupportedType
            /// </summary>
            [EnumMember(Value = "kNotSupportedType")]
            KNotSupportedType = 4,

            /// <summary>
            /// Enum KFullText for value: kFullText
            /// </summary>
            [EnumMember(Value = "kFullText")]
            KFullText = 5

        }

        /// <summary>
        /// Specifies the format type of the file that SQL database stores the data. Specifies the format type of the file that SQL database stores the data. &#39;kRows&#39; refers to a data file &#39;kLog&#39; refers to a log file &#39;kFileStream&#39; refers to a directory containing FILESTREAM data &#39;kNotSupportedType&#39; is for information purposes only. Not supported. &#39;kFullText&#39; refers to a full-text catalog.
        /// </summary>
        /// <value>Specifies the format type of the file that SQL database stores the data. Specifies the format type of the file that SQL database stores the data. &#39;kRows&#39; refers to a data file &#39;kLog&#39; refers to a log file &#39;kFileStream&#39; refers to a directory containing FILESTREAM data &#39;kNotSupportedType&#39; is for information purposes only. Not supported. &#39;kFullText&#39; refers to a full-text catalog.</value>
        [DataMember(Name="fileType", EmitDefaultValue=true)]
        public FileTypeEnum? FileType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DbFileInfo" /> class.
        /// </summary>
        /// <param name="fileType">Specifies the format type of the file that SQL database stores the data. Specifies the format type of the file that SQL database stores the data. &#39;kRows&#39; refers to a data file &#39;kLog&#39; refers to a log file &#39;kFileStream&#39; refers to a directory containing FILESTREAM data &#39;kNotSupportedType&#39; is for information purposes only. Not supported. &#39;kFullText&#39; refers to a full-text catalog..</param>
        /// <param name="fullPath">Specifies the full path of the database file on the SQL host machine..</param>
        /// <param name="sizeBytes">Specifies the last known size of the database file..</param>
        public DbFileInfo(FileTypeEnum? fileType = default(FileTypeEnum?), string fullPath = default(string), long? sizeBytes = default(long?))
        {
            this.FileType = fileType;
            this.FullPath = fullPath;
            this.SizeBytes = sizeBytes;
            this.FileType = fileType;
            this.FullPath = fullPath;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Specifies the full path of the database file on the SQL host machine.
        /// </summary>
        /// <value>Specifies the full path of the database file on the SQL host machine.</value>
        [DataMember(Name="fullPath", EmitDefaultValue=true)]
        public string FullPath { get; set; }

        /// <summary>
        /// Specifies the last known size of the database file.
        /// </summary>
        /// <value>Specifies the last known size of the database file.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
        public long? SizeBytes { get; set; }

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
            return this.Equals(input as DbFileInfo);
        }

        /// <summary>
        /// Returns true if DbFileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DbFileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DbFileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileType == input.FileType ||
                    this.FileType.Equals(input.FileType)
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
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
                hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

