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
    /// Specifies the metadata for the Sharepoint Site document.
    /// </summary>
    [DataContract]
    public partial class SharepointDocumentMetadata :  IEquatable<SharepointDocumentMetadata>
    {
        /// <summary>
        /// Specifies the type of site document(file/folder). Specifies the Sharepoint document type.  &#39;kFile&#39; specifies a file. &#39;kFolder&#39; specifies a folder.
        /// </summary>
        /// <value>Specifies the type of site document(file/folder). Specifies the Sharepoint document type.  &#39;kFile&#39; specifies a file. &#39;kFolder&#39; specifies a folder.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeEnum
        {
            /// <summary>
            /// Enum KFile for value: kFile
            /// </summary>
            [EnumMember(Value = "kFile")]
            KFile = 1,

            /// <summary>
            /// Enum KFolder for value: kFolder
            /// </summary>
            [EnumMember(Value = "kFolder")]
            KFolder = 2

        }

        /// <summary>
        /// Specifies the type of site document(file/folder). Specifies the Sharepoint document type.  &#39;kFile&#39; specifies a file. &#39;kFolder&#39; specifies a folder.
        /// </summary>
        /// <value>Specifies the type of site document(file/folder). Specifies the Sharepoint document type.  &#39;kFile&#39; specifies a file. &#39;kFolder&#39; specifies a folder.</value>
        [DataMember(Name="documentType", EmitDefaultValue=true)]
        public DocumentTypeEnum? DocumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointDocumentMetadata" /> class.
        /// </summary>
        /// <param name="documentType">Specifies the type of site document(file/folder). Specifies the Sharepoint document type.  &#39;kFile&#39; specifies a file. &#39;kFolder&#39; specifies a folder..</param>
        public SharepointDocumentMetadata(DocumentTypeEnum? documentType = default(DocumentTypeEnum?))
        {
            this.DocumentType = documentType;
            this.DocumentType = documentType;
        }
        
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
            return this.Equals(input as SharepointDocumentMetadata);
        }

        /// <summary>
        /// Returns true if SharepointDocumentMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of SharepointDocumentMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharepointDocumentMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentType == input.DocumentType ||
                    this.DocumentType.Equals(input.DocumentType)
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
                hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                return hashCode;
            }
        }

    }

}

