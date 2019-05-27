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
    /// Specifies the Result parameters for all infected files.
    /// </summary>
    [DataContract]
    public partial class InfectedFiles :  IEquatable<InfectedFiles>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfectedFiles" /> class.
        /// </summary>
        /// <param name="infectedFiles">Specifies the infected files..</param>
        /// <param name="paginationCookie">This cookie can be used in the succeeding call to list infected files to get the next set of infected files. If set to nil, it means that there&#39;s no more results that the server could provide..</param>
        public InfectedFiles(List<InfectedFile> infectedFiles = default(List<InfectedFile>), string paginationCookie = default(string))
        {
            this._InfectedFiles = infectedFiles;
            this.PaginationCookie = paginationCookie;
            this._InfectedFiles = infectedFiles;
            this.PaginationCookie = paginationCookie;
        }
        
        /// <summary>
        /// Specifies the infected files.
        /// </summary>
        /// <value>Specifies the infected files.</value>
        [DataMember(Name="infectedFiles", EmitDefaultValue=true)]
        public List<InfectedFile> _InfectedFiles { get; set; }

        /// <summary>
        /// This cookie can be used in the succeeding call to list infected files to get the next set of infected files. If set to nil, it means that there&#39;s no more results that the server could provide.
        /// </summary>
        /// <value>This cookie can be used in the succeeding call to list infected files to get the next set of infected files. If set to nil, it means that there&#39;s no more results that the server could provide.</value>
        [DataMember(Name="paginationCookie", EmitDefaultValue=true)]
        public string PaginationCookie { get; set; }

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
            return this.Equals(input as InfectedFiles);
        }

        /// <summary>
        /// Returns true if InfectedFiles instances are equal
        /// </summary>
        /// <param name="input">Instance of InfectedFiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfectedFiles input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._InfectedFiles == input._InfectedFiles ||
                    this._InfectedFiles != null &&
                    input._InfectedFiles != null &&
                    this._InfectedFiles.SequenceEqual(input._InfectedFiles)
                ) && 
                (
                    this.PaginationCookie == input.PaginationCookie ||
                    (this.PaginationCookie != null &&
                    this.PaginationCookie.Equals(input.PaginationCookie))
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
                if (this._InfectedFiles != null)
                    hashCode = hashCode * 59 + this._InfectedFiles.GetHashCode();
                if (this.PaginationCookie != null)
                    hashCode = hashCode * 59 + this.PaginationCookie.GetHashCode();
                return hashCode;
            }
        }

    }

}

