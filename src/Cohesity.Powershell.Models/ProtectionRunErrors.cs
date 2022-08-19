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
    /// ProtectionRunErrors
    /// </summary>
    [DataContract]
    public partial class ProtectionRunErrors :  IEquatable<ProtectionRunErrors>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionRunErrors" /> class.
        /// </summary>
        /// <param name="errors">Specifies the list of errors encountered by a task during a protection run..</param>
        /// <param name="fileNames">Specifies the list of filenames with errors encountered by a task during a protection run..</param>
        /// <param name="paginationCookie">Specifies the cookie for next set of results..</param>
        public ProtectionRunErrors(List<RequestError> errors = default(List<RequestError>), List<string> fileNames = default(List<string>), string paginationCookie = default(string))
        {
            this.Errors = errors;
            this.FileNames = fileNames;
            this.PaginationCookie = paginationCookie;
            this.Errors = errors;
            this.FileNames = fileNames;
            this.PaginationCookie = paginationCookie;
        }
        
        /// <summary>
        /// Specifies the list of errors encountered by a task during a protection run.
        /// </summary>
        /// <value>Specifies the list of errors encountered by a task during a protection run.</value>
        [DataMember(Name="errors", EmitDefaultValue=true)]
        public List<RequestError> Errors { get; set; }

        /// <summary>
        /// Specifies the list of filenames with errors encountered by a task during a protection run.
        /// </summary>
        /// <value>Specifies the list of filenames with errors encountered by a task during a protection run.</value>
        [DataMember(Name="fileNames", EmitDefaultValue=true)]
        public List<string> FileNames { get; set; }

        /// <summary>
        /// Specifies the cookie for next set of results.
        /// </summary>
        /// <value>Specifies the cookie for next set of results.</value>
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
            return this.Equals(input as ProtectionRunErrors);
        }

        /// <summary>
        /// Returns true if ProtectionRunErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionRunErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionRunErrors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.Equals(input.Errors)
                ) && 
                (
                    this.FileNames == input.FileNames ||
                    this.FileNames != null &&
                    input.FileNames != null &&
                    this.FileNames.Equals(input.FileNames)
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.FileNames != null)
                    hashCode = hashCode * 59 + this.FileNames.GetHashCode();
                if (this.PaginationCookie != null)
                    hashCode = hashCode * 59 + this.PaginationCookie.GetHashCode();
                return hashCode;
            }
        }

    }

}

