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
    /// SmbActiveFileOpensResponse
    /// </summary>
    [DataContract]
    public partial class SmbActiveFileOpensResponse :  IEquatable<SmbActiveFileOpensResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbActiveFileOpensResponse" /> class.
        /// </summary>
        /// <param name="activeFilePaths">activeFilePaths.</param>
        /// <param name="cookie">Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens..</param>
        public SmbActiveFileOpensResponse(List<SmbActiveFilePath> activeFilePaths = default(List<SmbActiveFilePath>), string cookie = default(string))
        {
            this.ActiveFilePaths = activeFilePaths;
            this.Cookie = cookie;
        }
        
        /// <summary>
        /// Gets or Sets ActiveFilePaths
        /// </summary>
        [DataMember(Name="activeFilePaths", EmitDefaultValue=false)]
        public List<SmbActiveFilePath> ActiveFilePaths { get; set; }

        /// <summary>
        /// Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens.
        /// </summary>
        /// <value>Specifies an opaque string to pass to get the next set of active opens. If null is returned, this response is the last set of active opens.</value>
        [DataMember(Name="cookie", EmitDefaultValue=false)]
        public string Cookie { get; set; }

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
            return this.Equals(input as SmbActiveFileOpensResponse);
        }

        /// <summary>
        /// Returns true if SmbActiveFileOpensResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbActiveFileOpensResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbActiveFileOpensResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveFilePaths == input.ActiveFilePaths ||
                    this.ActiveFilePaths != null &&
                    this.ActiveFilePaths.SequenceEqual(input.ActiveFilePaths)
                ) && 
                (
                    this.Cookie == input.Cookie ||
                    (this.Cookie != null &&
                    this.Cookie.Equals(input.Cookie))
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
                if (this.ActiveFilePaths != null)
                    hashCode = hashCode * 59 + this.ActiveFilePaths.GetHashCode();
                if (this.Cookie != null)
                    hashCode = hashCode * 59 + this.Cookie.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

