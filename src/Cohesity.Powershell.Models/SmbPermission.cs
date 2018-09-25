// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a single SMB permission.
    /// </summary>
    [DataContract]
    public partial class SmbPermission :  IEquatable<SmbPermission>
    {
        /// <summary>
        /// Specifies the read/write access to the SMB share. &#39;kReadyOnly&#39; indicates read only access to the SMB share. &#39;kReadWrite&#39; indicates read and write access to the SMB share. &#39;kFullControl&#39; indicates full administrative control of the SMB share. &#39;kSpecialAccess&#39; indicates custom permissions to the SMB share using access masks structures.
        /// </summary>
        /// <value>Specifies the read/write access to the SMB share. &#39;kReadyOnly&#39; indicates read only access to the SMB share. &#39;kReadWrite&#39; indicates read and write access to the SMB share. &#39;kFullControl&#39; indicates full administrative control of the SMB share. &#39;kSpecialAccess&#39; indicates custom permissions to the SMB share using access masks structures.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessEnum
        {
            
            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 1,
            
            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 2,
            
            /// <summary>
            /// Enum KModify for value: kModify
            /// </summary>
            [EnumMember(Value = "kModify")]
            KModify = 3,
            
            /// <summary>
            /// Enum KFullControl for value: kFullControl
            /// </summary>
            [EnumMember(Value = "kFullControl")]
            KFullControl = 4,
            
            /// <summary>
            /// Enum KSpecialAccess for value: kSpecialAccess
            /// </summary>
            [EnumMember(Value = "kSpecialAccess")]
            KSpecialAccess = 5
        }

        /// <summary>
        /// Specifies the read/write access to the SMB share. &#39;kReadyOnly&#39; indicates read only access to the SMB share. &#39;kReadWrite&#39; indicates read and write access to the SMB share. &#39;kFullControl&#39; indicates full administrative control of the SMB share. &#39;kSpecialAccess&#39; indicates custom permissions to the SMB share using access masks structures.
        /// </summary>
        /// <value>Specifies the read/write access to the SMB share. &#39;kReadyOnly&#39; indicates read only access to the SMB share. &#39;kReadWrite&#39; indicates read and write access to the SMB share. &#39;kFullControl&#39; indicates full administrative control of the SMB share. &#39;kSpecialAccess&#39; indicates custom permissions to the SMB share using access masks structures.</value>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public AccessEnum? Access { get; set; }
        /// <summary>
        /// Specifies how the permission should be applied to folders and/or files.
        /// </summary>
        /// <value>Specifies how the permission should be applied to folders and/or files.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            
            /// <summary>
            /// Enum KFolderSubFoldersAndFiles for value: kFolderSubFoldersAndFiles
            /// </summary>
            [EnumMember(Value = "kFolderSubFoldersAndFiles")]
            KFolderSubFoldersAndFiles = 1,
            
            /// <summary>
            /// Enum KFolderAndSubFolders for value: kFolderAndSubFolders
            /// </summary>
            [EnumMember(Value = "kFolderAndSubFolders")]
            KFolderAndSubFolders = 2,
            
            /// <summary>
            /// Enum KFolderAndFiles for value: kFolderAndFiles
            /// </summary>
            [EnumMember(Value = "kFolderAndFiles")]
            KFolderAndFiles = 3,
            
            /// <summary>
            /// Enum KFolderOnly for value: kFolderOnly
            /// </summary>
            [EnumMember(Value = "kFolderOnly")]
            KFolderOnly = 4,
            
            /// <summary>
            /// Enum KSubFoldersAndFilesOnly for value: kSubFoldersAndFilesOnly
            /// </summary>
            [EnumMember(Value = "kSubFoldersAndFilesOnly")]
            KSubFoldersAndFilesOnly = 5,
            
            /// <summary>
            /// Enum KSubFoldersOnly for value: kSubFoldersOnly
            /// </summary>
            [EnumMember(Value = "kSubFoldersOnly")]
            KSubFoldersOnly = 6,
            
            /// <summary>
            /// Enum KFilesOnly for value: kFilesOnly
            /// </summary>
            [EnumMember(Value = "kFilesOnly")]
            KFilesOnly = 7
        }

        /// <summary>
        /// Specifies how the permission should be applied to folders and/or files.
        /// </summary>
        /// <value>Specifies how the permission should be applied to folders and/or files.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Specifies the type of permission. &#39;kAllow&#39; indicates access is allowed. &#39;kDeny&#39; indicates access is denied. &#39;kSpecialType&#39; indicates a type defined in the Access Control Entry (ACE) does not map to &#39;kAllow&#39; or &#39;kDeny&#39;.
        /// </summary>
        /// <value>Specifies the type of permission. &#39;kAllow&#39; indicates access is allowed. &#39;kDeny&#39; indicates access is denied. &#39;kSpecialType&#39; indicates a type defined in the Access Control Entry (ACE) does not map to &#39;kAllow&#39; or &#39;kDeny&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KAllow for value: kAllow
            /// </summary>
            [EnumMember(Value = "kAllow")]
            KAllow = 1,
            
            /// <summary>
            /// Enum KDeny for value: kDeny
            /// </summary>
            [EnumMember(Value = "kDeny")]
            KDeny = 2,
            
            /// <summary>
            /// Enum KSpecialType for value: kSpecialType
            /// </summary>
            [EnumMember(Value = "kSpecialType")]
            KSpecialType = 3
        }

        /// <summary>
        /// Specifies the type of permission. &#39;kAllow&#39; indicates access is allowed. &#39;kDeny&#39; indicates access is denied. &#39;kSpecialType&#39; indicates a type defined in the Access Control Entry (ACE) does not map to &#39;kAllow&#39; or &#39;kDeny&#39;.
        /// </summary>
        /// <value>Specifies the type of permission. &#39;kAllow&#39; indicates access is allowed. &#39;kDeny&#39; indicates access is denied. &#39;kSpecialType&#39; indicates a type defined in the Access Control Entry (ACE) does not map to &#39;kAllow&#39; or &#39;kDeny&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbPermission" /> class.
        /// </summary>
        /// <param name="access">Specifies the read/write access to the SMB share. &#39;kReadyOnly&#39; indicates read only access to the SMB share. &#39;kReadWrite&#39; indicates read and write access to the SMB share. &#39;kFullControl&#39; indicates full administrative control of the SMB share. &#39;kSpecialAccess&#39; indicates custom permissions to the SMB share using access masks structures..</param>
        /// <param name="mode">Specifies how the permission should be applied to folders and/or files..</param>
        /// <param name="sid">Specifies the security identifier (SID) of the principal..</param>
        /// <param name="specialAccessMask">Specifies custom access permissions. When the access mask from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;access&#39;, this field is populated with the custom mask derived from the ACE and &#39;access&#39; is set to kSpecialAccess. This is a placeholder for storing an unmapped access permission and should not be set when creating and editing a View..</param>
        /// <param name="specialType">Specifies a custom type. When the type from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;type&#39;, this field is populated with the custom type derived from the ACE and &#39;type&#39; is set to kSpecialType. This is a placeholder for storing an unmapped type and should not be set when creating and editing a View..</param>
        /// <param name="type">Specifies the type of permission. &#39;kAllow&#39; indicates access is allowed. &#39;kDeny&#39; indicates access is denied. &#39;kSpecialType&#39; indicates a type defined in the Access Control Entry (ACE) does not map to &#39;kAllow&#39; or &#39;kDeny&#39;..</param>
        public SmbPermission(AccessEnum? access = default(AccessEnum?), ModeEnum? mode = default(ModeEnum?), string sid = default(string), int? specialAccessMask = default(int?), int? specialType = default(int?), TypeEnum? type = default(TypeEnum?))
        {
            this.Access = access;
            this.Mode = mode;
            this.Sid = sid;
            this.SpecialAccessMask = specialAccessMask;
            this.SpecialType = specialType;
            this.Type = type;
        }
        


        /// <summary>
        /// Specifies the security identifier (SID) of the principal.
        /// </summary>
        /// <value>Specifies the security identifier (SID) of the principal.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies custom access permissions. When the access mask from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;access&#39;, this field is populated with the custom mask derived from the ACE and &#39;access&#39; is set to kSpecialAccess. This is a placeholder for storing an unmapped access permission and should not be set when creating and editing a View.
        /// </summary>
        /// <value>Specifies custom access permissions. When the access mask from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;access&#39;, this field is populated with the custom mask derived from the ACE and &#39;access&#39; is set to kSpecialAccess. This is a placeholder for storing an unmapped access permission and should not be set when creating and editing a View.</value>
        [DataMember(Name="specialAccessMask", EmitDefaultValue=false)]
        public int? SpecialAccessMask { get; set; }

        /// <summary>
        /// Specifies a custom type. When the type from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;type&#39;, this field is populated with the custom type derived from the ACE and &#39;type&#39; is set to kSpecialType. This is a placeholder for storing an unmapped type and should not be set when creating and editing a View.
        /// </summary>
        /// <value>Specifies a custom type. When the type from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;type&#39;, this field is populated with the custom type derived from the ACE and &#39;type&#39; is set to kSpecialType. This is a placeholder for storing an unmapped type and should not be set when creating and editing a View.</value>
        [DataMember(Name="specialType", EmitDefaultValue=false)]
        public int? SpecialType { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as SmbPermission);
        }

        /// <summary>
        /// Returns true if SmbPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbPermission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.SpecialAccessMask == input.SpecialAccessMask ||
                    (this.SpecialAccessMask != null &&
                    this.SpecialAccessMask.Equals(input.SpecialAccessMask))
                ) && 
                (
                    this.SpecialType == input.SpecialType ||
                    (this.SpecialType != null &&
                    this.SpecialType.Equals(input.SpecialType))
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
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.SpecialAccessMask != null)
                    hashCode = hashCode * 59 + this.SpecialAccessMask.GetHashCode();
                if (this.SpecialType != null)
                    hashCode = hashCode * 59 + this.SpecialType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

