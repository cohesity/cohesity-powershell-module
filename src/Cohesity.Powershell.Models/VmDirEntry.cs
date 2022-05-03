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
    /// VmDirEntry is the struct to represent a file or a folder on a VM.
    /// </summary>
    [DataContract]
    public partial class VmDirEntry :  IEquatable<VmDirEntry>
    {
        /// <summary>
        /// DirEntryType is the type of entry i.e. file/folder. Specifies the type of directory entry.  &#39;kFile&#39; indicates that current entry is of file type. &#39;kDirectory&#39; indicates that current entry is of directory type. &#39;kSymlink&#39; indicates that current entry is of symbolic link.
        /// </summary>
        /// <value>DirEntryType is the type of entry i.e. file/folder. Specifies the type of directory entry.  &#39;kFile&#39; indicates that current entry is of file type. &#39;kDirectory&#39; indicates that current entry is of directory type. &#39;kSymlink&#39; indicates that current entry is of symbolic link.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KFile for value: kFile
            /// </summary>
            [EnumMember(Value = "kFile")]
            KFile = 1,

            /// <summary>
            /// Enum KDirectory for value: kDirectory
            /// </summary>
            [EnumMember(Value = "kDirectory")]
            KDirectory = 2,

            /// <summary>
            /// Enum KSymlink for value: kSymlink
            /// </summary>
            [EnumMember(Value = "kSymlink")]
            KSymlink = 3

        }

        /// <summary>
        /// DirEntryType is the type of entry i.e. file/folder. Specifies the type of directory entry.  &#39;kFile&#39; indicates that current entry is of file type. &#39;kDirectory&#39; indicates that current entry is of directory type. &#39;kSymlink&#39; indicates that current entry is of symbolic link.
        /// </summary>
        /// <value>DirEntryType is the type of entry i.e. file/folder. Specifies the type of directory entry.  &#39;kFile&#39; indicates that current entry is of file type. &#39;kDirectory&#39; indicates that current entry is of directory type. &#39;kSymlink&#39; indicates that current entry is of symbolic link.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VmDirEntry" /> class.
        /// </summary>
        /// <param name="fstatInfo">fstatInfo.</param>
        /// <param name="fullPath">FullPath is the full path of the file/directory..</param>
        /// <param name="name">Name is the name of the file or folder. For /test/file.txt, name will be file.txt..</param>
        /// <param name="type">DirEntryType is the type of entry i.e. file/folder. Specifies the type of directory entry.  &#39;kFile&#39; indicates that current entry is of file type. &#39;kDirectory&#39; indicates that current entry is of directory type. &#39;kSymlink&#39; indicates that current entry is of symbolic link..</param>
        public VmDirEntry(FileStatInfo fstatInfo = default(FileStatInfo), string fullPath = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.FstatInfo = fstatInfo;
            this.FullPath = fullPath;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets FstatInfo
        /// </summary>
        [DataMember(Name="fstatInfo", EmitDefaultValue=false)]
        public FileStatInfo FstatInfo { get; set; }

        /// <summary>
        /// FullPath is the full path of the file/directory.
        /// </summary>
        /// <value>FullPath is the full path of the file/directory.</value>
        [DataMember(Name="fullPath", EmitDefaultValue=false)]
        public string FullPath { get; set; }

        /// <summary>
        /// Name is the name of the file or folder. For /test/file.txt, name will be file.txt.
        /// </summary>
        /// <value>Name is the name of the file or folder. For /test/file.txt, name will be file.txt.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


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
            return this.Equals(input as VmDirEntry);
        }

        /// <summary>
        /// Returns true if VmDirEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of VmDirEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmDirEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FstatInfo == input.FstatInfo ||
                    (this.FstatInfo != null &&
                    this.FstatInfo.Equals(input.FstatInfo))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.FstatInfo != null)
                    hashCode = hashCode * 59 + this.FstatInfo.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

