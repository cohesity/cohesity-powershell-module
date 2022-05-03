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
    /// DownloadCftResponse
    /// </summary>
    [DataContract]
    public partial class DownloadCftResponse :  IEquatable<DownloadCftResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadCftResponse" /> class.
        /// </summary>
        /// <param name="content">Specifies the content of the file..</param>
        /// <param name="fileName">Specifies the content of the CFT. in: body Specifies the file name of the cloud formation template..</param>
        public DownloadCftResponse(List<int?> content = default(List<int?>), string fileName = default(string))
        {
            this.Content = content;
            this.FileName = fileName;
        }
        
        /// <summary>
        /// Specifies the content of the file.
        /// </summary>
        /// <value>Specifies the content of the file.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<int?> Content { get; set; }

        /// <summary>
        /// Specifies the content of the CFT. in: body Specifies the file name of the cloud formation template.
        /// </summary>
        /// <value>Specifies the content of the CFT. in: body Specifies the file name of the cloud formation template.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

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
            return this.Equals(input as DownloadCftResponse);
        }

        /// <summary>
        /// Returns true if DownloadCftResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadCftResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadCftResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    this.Content.Equals(input.Content)
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                return hashCode;
            }
        }

    }

}

