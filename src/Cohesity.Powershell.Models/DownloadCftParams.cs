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
    /// DownloadCftParams
    /// </summary>
    [DataContract]
    public partial class DownloadCftParams :  IEquatable<DownloadCftParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadCftParams" /> class.
        /// </summary>
        /// <param name="fileName">Specifies the file name of the cloud formation template..</param>
        /// <param name="filePath">Specifies the file path of the template. If passed null, \&quot;/home/cohesity/bin\&quot; will be considered as file path..</param>
        public DownloadCftParams(string fileName = default(string), string filePath = default(string))
        {
            this.FileName = fileName;
            this.FilePath = filePath;
        }
        
        /// <summary>
        /// Specifies the file name of the cloud formation template.
        /// </summary>
        /// <value>Specifies the file name of the cloud formation template.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies the file path of the template. If passed null, \&quot;/home/cohesity/bin\&quot; will be considered as file path.
        /// </summary>
        /// <value>Specifies the file path of the template. If passed null, \&quot;/home/cohesity/bin\&quot; will be considered as file path.</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }

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
            return this.Equals(input as DownloadCftParams);
        }

        /// <summary>
        /// Returns true if DownloadCftParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadCftParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadCftParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
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
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                return hashCode;
            }
        }

    }

}

