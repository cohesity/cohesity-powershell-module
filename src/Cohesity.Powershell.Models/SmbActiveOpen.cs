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
    /// SmbActiveOpen
    /// </summary>
    [DataContract]
    public partial class SmbActiveOpen :  IEquatable<SmbActiveOpen>
    {
        /// <summary>
        /// Defines AccessInfoList
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessInfoListEnum
        {
            
            /// <summary>
            /// Enum KFileReadData for value: kFileReadData
            /// </summary>
            [EnumMember(Value = "kFileReadData")]
            KFileReadData = 1,
            
            /// <summary>
            /// Enum KFileWriteData for value: kFileWriteData
            /// </summary>
            [EnumMember(Value = "kFileWriteData")]
            KFileWriteData = 2,
            
            /// <summary>
            /// Enum KFileAppendData for value: kFileAppendData
            /// </summary>
            [EnumMember(Value = "kFileAppendData")]
            KFileAppendData = 3,
            
            /// <summary>
            /// Enum KFileReadEa for value: kFileReadEa
            /// </summary>
            [EnumMember(Value = "kFileReadEa")]
            KFileReadEa = 4,
            
            /// <summary>
            /// Enum KFileWriteEa for value: kFileWriteEa
            /// </summary>
            [EnumMember(Value = "kFileWriteEa")]
            KFileWriteEa = 5,
            
            /// <summary>
            /// Enum KFileExecute for value: kFileExecute
            /// </summary>
            [EnumMember(Value = "kFileExecute")]
            KFileExecute = 6,
            
            /// <summary>
            /// Enum KFileDeleteChild for value: kFileDeleteChild
            /// </summary>
            [EnumMember(Value = "kFileDeleteChild")]
            KFileDeleteChild = 7,
            
            /// <summary>
            /// Enum KFileReadAttributes for value: kFileReadAttributes
            /// </summary>
            [EnumMember(Value = "kFileReadAttributes")]
            KFileReadAttributes = 8,
            
            /// <summary>
            /// Enum KFileWriteAttributes for value: kFileWriteAttributes
            /// </summary>
            [EnumMember(Value = "kFileWriteAttributes")]
            KFileWriteAttributes = 9,
            
            /// <summary>
            /// Enum KDelete for value: kDelete
            /// </summary>
            [EnumMember(Value = "kDelete")]
            KDelete = 10,
            
            /// <summary>
            /// Enum KReadControl for value: kReadControl
            /// </summary>
            [EnumMember(Value = "kReadControl")]
            KReadControl = 11,
            
            /// <summary>
            /// Enum KWriteDac for value: kWriteDac
            /// </summary>
            [EnumMember(Value = "kWriteDac")]
            KWriteDac = 12,
            
            /// <summary>
            /// Enum KWriteOwner for value: kWriteOwner
            /// </summary>
            [EnumMember(Value = "kWriteOwner")]
            KWriteOwner = 13,
            
            /// <summary>
            /// Enum KSynchronize for value: kSynchronize
            /// </summary>
            [EnumMember(Value = "kSynchronize")]
            KSynchronize = 14,
            
            /// <summary>
            /// Enum KAccessSystemSecurity for value: kAccessSystemSecurity
            /// </summary>
            [EnumMember(Value = "kAccessSystemSecurity")]
            KAccessSystemSecurity = 15,
            
            /// <summary>
            /// Enum KMaximumAllowed for value: kMaximumAllowed
            /// </summary>
            [EnumMember(Value = "kMaximumAllowed")]
            KMaximumAllowed = 16,
            
            /// <summary>
            /// Enum KGenericAll for value: kGenericAll
            /// </summary>
            [EnumMember(Value = "kGenericAll")]
            KGenericAll = 17,
            
            /// <summary>
            /// Enum KGenericExecute for value: kGenericExecute
            /// </summary>
            [EnumMember(Value = "kGenericExecute")]
            KGenericExecute = 18,
            
            /// <summary>
            /// Enum KGenericWrite for value: kGenericWrite
            /// </summary>
            [EnumMember(Value = "kGenericWrite")]
            KGenericWrite = 19,
            
            /// <summary>
            /// Enum KGenericRead for value: kGenericRead
            /// </summary>
            [EnumMember(Value = "kGenericRead")]
            KGenericRead = 20
        }


        /// <summary>
        /// &#39;kFileReadData&#39; indicates the right to read data from the file or named pipe. &#39;kFileWriteData&#39; indicates the right to write data into the file or named pipe beyond the end of the file. &#39;kFileAppendData&#39; indicates the right to append data into the file or named pipe. &#39;kFileReadEa&#39; indicates the right to read the extended attributes of the file or named pipe. &#39;kFileWriteEa&#39; indicates the right to write or change the extended attributes to the file or named pipe. &#39;kFileExecute&#39; indicates the right to delete entries within a directory. &#39;kFileDeleteChild&#39; indicates the right to execute the file. &#39;kFileReadAttributes&#39; indicates the right to read the attributes of the file. &#39;kFileWriteAttributes&#39; indicates the right to change the attributes of the file. &#39;kDelete&#39; indicates the right to delete the file. &#39;kReadControl&#39; indicates the right to read the security descriptor for the file or named pipe. &#39;kWriteDac&#39; indicates the right to change the discretionary access control list (DACL) in the security descriptor for the file or named pipe. For the DACL data structure, see ACL in [MS-DTYP]. &#39;kWriteOwner&#39; indicates the right to change the owner in the security descriptor for the file or named pipe. &#39;kSynchronize&#39; is used only by SMB2 clients. &#39;kAccessSystemSecurity&#39; indicates the right to read or change the system access control list (SACL) in the security descriptor for the file or named pipe. For the SACL data structure, see ACL in [MS-DTYP].&lt;42&gt; &#39;kMaximumAllowed&#39; indicates that the client is requesting an open to the file with the highest level of access the client has on this file. If no access is granted for the client on this file, the server MUST fail the open with STATUS_ACCESS_DENIED. &#39;kGenericAll&#39; indicates a request for all the access flags that are previously listed except kMaximumAllowed and kAccessSystemSecurity. &#39;kGenericExecute&#39; indicates a request for the following combination of access flags listed above: kFileReadAttributes| kFileExecute| kSynchronize| kReadControl. &#39;kGenericWrite&#39; indicates a request for the following combination of access flags listed above: kFileWriteData| kFileAppendData| kFileWriteAttributes| kFileWriteEa| kSynchronize| kReadControl. &#39;kGenericRead&#39; indicates a request for the following combination of access flags listed above: kFileReadData| kFileReadAttributes| kFileReadEa| kSynchronize| kReadControl.
        /// </summary>
        /// <value>&#39;kFileReadData&#39; indicates the right to read data from the file or named pipe. &#39;kFileWriteData&#39; indicates the right to write data into the file or named pipe beyond the end of the file. &#39;kFileAppendData&#39; indicates the right to append data into the file or named pipe. &#39;kFileReadEa&#39; indicates the right to read the extended attributes of the file or named pipe. &#39;kFileWriteEa&#39; indicates the right to write or change the extended attributes to the file or named pipe. &#39;kFileExecute&#39; indicates the right to delete entries within a directory. &#39;kFileDeleteChild&#39; indicates the right to execute the file. &#39;kFileReadAttributes&#39; indicates the right to read the attributes of the file. &#39;kFileWriteAttributes&#39; indicates the right to change the attributes of the file. &#39;kDelete&#39; indicates the right to delete the file. &#39;kReadControl&#39; indicates the right to read the security descriptor for the file or named pipe. &#39;kWriteDac&#39; indicates the right to change the discretionary access control list (DACL) in the security descriptor for the file or named pipe. For the DACL data structure, see ACL in [MS-DTYP]. &#39;kWriteOwner&#39; indicates the right to change the owner in the security descriptor for the file or named pipe. &#39;kSynchronize&#39; is used only by SMB2 clients. &#39;kAccessSystemSecurity&#39; indicates the right to read or change the system access control list (SACL) in the security descriptor for the file or named pipe. For the SACL data structure, see ACL in [MS-DTYP].&lt;42&gt; &#39;kMaximumAllowed&#39; indicates that the client is requesting an open to the file with the highest level of access the client has on this file. If no access is granted for the client on this file, the server MUST fail the open with STATUS_ACCESS_DENIED. &#39;kGenericAll&#39; indicates a request for all the access flags that are previously listed except kMaximumAllowed and kAccessSystemSecurity. &#39;kGenericExecute&#39; indicates a request for the following combination of access flags listed above: kFileReadAttributes| kFileExecute| kSynchronize| kReadControl. &#39;kGenericWrite&#39; indicates a request for the following combination of access flags listed above: kFileWriteData| kFileAppendData| kFileWriteAttributes| kFileWriteEa| kSynchronize| kReadControl. &#39;kGenericRead&#39; indicates a request for the following combination of access flags listed above: kFileReadData| kFileReadAttributes| kFileReadEa| kSynchronize| kReadControl.</value>
        [DataMember(Name="accessInfoList", EmitDefaultValue=false)]
        public List<AccessInfoListEnum> AccessInfoList { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbActiveOpen" /> class.
        /// </summary>
        /// <param name="accessInfoList">&#39;kFileReadData&#39; indicates the right to read data from the file or named pipe. &#39;kFileWriteData&#39; indicates the right to write data into the file or named pipe beyond the end of the file. &#39;kFileAppendData&#39; indicates the right to append data into the file or named pipe. &#39;kFileReadEa&#39; indicates the right to read the extended attributes of the file or named pipe. &#39;kFileWriteEa&#39; indicates the right to write or change the extended attributes to the file or named pipe. &#39;kFileExecute&#39; indicates the right to delete entries within a directory. &#39;kFileDeleteChild&#39; indicates the right to execute the file. &#39;kFileReadAttributes&#39; indicates the right to read the attributes of the file. &#39;kFileWriteAttributes&#39; indicates the right to change the attributes of the file. &#39;kDelete&#39; indicates the right to delete the file. &#39;kReadControl&#39; indicates the right to read the security descriptor for the file or named pipe. &#39;kWriteDac&#39; indicates the right to change the discretionary access control list (DACL) in the security descriptor for the file or named pipe. For the DACL data structure, see ACL in [MS-DTYP]. &#39;kWriteOwner&#39; indicates the right to change the owner in the security descriptor for the file or named pipe. &#39;kSynchronize&#39; is used only by SMB2 clients. &#39;kAccessSystemSecurity&#39; indicates the right to read or change the system access control list (SACL) in the security descriptor for the file or named pipe. For the SACL data structure, see ACL in [MS-DTYP].&lt;42&gt; &#39;kMaximumAllowed&#39; indicates that the client is requesting an open to the file with the highest level of access the client has on this file. If no access is granted for the client on this file, the server MUST fail the open with STATUS_ACCESS_DENIED. &#39;kGenericAll&#39; indicates a request for all the access flags that are previously listed except kMaximumAllowed and kAccessSystemSecurity. &#39;kGenericExecute&#39; indicates a request for the following combination of access flags listed above: kFileReadAttributes| kFileExecute| kSynchronize| kReadControl. &#39;kGenericWrite&#39; indicates a request for the following combination of access flags listed above: kFileWriteData| kFileAppendData| kFileWriteAttributes| kFileWriteEa| kSynchronize| kReadControl. &#39;kGenericRead&#39; indicates a request for the following combination of access flags listed above: kFileReadData| kFileReadAttributes| kFileReadEa| kSynchronize| kReadControl..</param>
        /// <param name="openId">Specifies the id of the active open..</param>
        /// <param name="othersCanDelete">Specifies whether others are allowed to delete..</param>
        /// <param name="othersCanRead">Specifies whether others are allowed to read..</param>
        /// <param name="othersCanWrite">Specifies whether others are allowed to write..</param>
        public SmbActiveOpen(List<AccessInfoListEnum> accessInfoList = default(List<AccessInfoListEnum>), long? openId = default(long?), bool? othersCanDelete = default(bool?), bool? othersCanRead = default(bool?), bool? othersCanWrite = default(bool?))
        {
            this.AccessInfoList = accessInfoList;
            this.OpenId = openId;
            this.OthersCanDelete = othersCanDelete;
            this.OthersCanRead = othersCanRead;
            this.OthersCanWrite = othersCanWrite;
        }
        

        /// <summary>
        /// Specifies the id of the active open.
        /// </summary>
        /// <value>Specifies the id of the active open.</value>
        [DataMember(Name="openId", EmitDefaultValue=false)]
        public long? OpenId { get; set; }

        /// <summary>
        /// Specifies whether others are allowed to delete.
        /// </summary>
        /// <value>Specifies whether others are allowed to delete.</value>
        [DataMember(Name="othersCanDelete", EmitDefaultValue=false)]
        public bool? OthersCanDelete { get; set; }

        /// <summary>
        /// Specifies whether others are allowed to read.
        /// </summary>
        /// <value>Specifies whether others are allowed to read.</value>
        [DataMember(Name="othersCanRead", EmitDefaultValue=false)]
        public bool? OthersCanRead { get; set; }

        /// <summary>
        /// Specifies whether others are allowed to write.
        /// </summary>
        /// <value>Specifies whether others are allowed to write.</value>
        [DataMember(Name="othersCanWrite", EmitDefaultValue=false)]
        public bool? OthersCanWrite { get; set; }

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
            return this.Equals(input as SmbActiveOpen);
        }

        /// <summary>
        /// Returns true if SmbActiveOpen instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbActiveOpen to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbActiveOpen input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessInfoList == input.AccessInfoList ||
                    this.AccessInfoList != null &&
                    this.AccessInfoList.SequenceEqual(input.AccessInfoList)
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OthersCanDelete == input.OthersCanDelete ||
                    (this.OthersCanDelete != null &&
                    this.OthersCanDelete.Equals(input.OthersCanDelete))
                ) && 
                (
                    this.OthersCanRead == input.OthersCanRead ||
                    (this.OthersCanRead != null &&
                    this.OthersCanRead.Equals(input.OthersCanRead))
                ) && 
                (
                    this.OthersCanWrite == input.OthersCanWrite ||
                    (this.OthersCanWrite != null &&
                    this.OthersCanWrite.Equals(input.OthersCanWrite))
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
                if (this.AccessInfoList != null)
                    hashCode = hashCode * 59 + this.AccessInfoList.GetHashCode();
                if (this.OpenId != null)
                    hashCode = hashCode * 59 + this.OpenId.GetHashCode();
                if (this.OthersCanDelete != null)
                    hashCode = hashCode * 59 + this.OthersCanDelete.GetHashCode();
                if (this.OthersCanRead != null)
                    hashCode = hashCode * 59 + this.OthersCanRead.GetHashCode();
                if (this.OthersCanWrite != null)
                    hashCode = hashCode * 59 + this.OthersCanWrite.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

