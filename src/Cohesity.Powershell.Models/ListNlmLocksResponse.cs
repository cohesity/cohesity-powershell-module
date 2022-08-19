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
    /// Query response to list of NLM locks.
    /// </summary>
    [DataContract]
    public partial class ListNlmLocksResponse :  IEquatable<ListNlmLocksResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListNlmLocksResponse" /> class.
        /// </summary>
        /// <param name="cookie">Specifies an opaque string to pass to get the next set of NLM locks. If null is returned, this response is the last set of NLM locks..</param>
        /// <param name="filesNlmLocks">Specifies the list of NLM locks..</param>
        public ListNlmLocksResponse(string cookie = default(string), List<FileNlmLocks> filesNlmLocks = default(List<FileNlmLocks>))
        {
            this.Cookie = cookie;
            this.FilesNlmLocks = filesNlmLocks;
            this.Cookie = cookie;
            this.FilesNlmLocks = filesNlmLocks;
        }
        
        /// <summary>
        /// Specifies an opaque string to pass to get the next set of NLM locks. If null is returned, this response is the last set of NLM locks.
        /// </summary>
        /// <value>Specifies an opaque string to pass to get the next set of NLM locks. If null is returned, this response is the last set of NLM locks.</value>
        [DataMember(Name="cookie", EmitDefaultValue=true)]
        public string Cookie { get; set; }

        /// <summary>
        /// Specifies the list of NLM locks.
        /// </summary>
        /// <value>Specifies the list of NLM locks.</value>
        [DataMember(Name="filesNlmLocks", EmitDefaultValue=true)]
        public List<FileNlmLocks> FilesNlmLocks { get; set; }

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
            return this.Equals(input as ListNlmLocksResponse);
        }

        /// <summary>
        /// Returns true if ListNlmLocksResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListNlmLocksResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListNlmLocksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cookie == input.Cookie ||
                    (this.Cookie != null &&
                    this.Cookie.Equals(input.Cookie))
                ) && 
                (
                    this.FilesNlmLocks == input.FilesNlmLocks ||
                    this.FilesNlmLocks != null &&
                    input.FilesNlmLocks != null &&
                    this.FilesNlmLocks.Equals(input.FilesNlmLocks)
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
                if (this.Cookie != null)
                    hashCode = hashCode * 59 + this.Cookie.GetHashCode();
                if (this.FilesNlmLocks != null)
                    hashCode = hashCode * 59 + this.FilesNlmLocks.GetHashCode();
                return hashCode;
            }
        }

    }

}

