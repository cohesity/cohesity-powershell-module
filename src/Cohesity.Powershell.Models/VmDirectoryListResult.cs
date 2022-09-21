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
    /// VmDirectoryListResult is a struct containing information about each directory entry.
    /// </summary>
    [DataContract]
    public partial class VmDirectoryListResult :  IEquatable<VmDirectoryListResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmDirectoryListResult" /> class.
        /// </summary>
        /// <param name="cookie">Cookie is used for paginating results. If ReadVMDirResult is returning partial results, this field will be set. Supplying this cookie will resume listing from where this result left off..</param>
        /// <param name="entries">Entries is the array of files and folders that are immediate children of the parent directory specified in the request..</param>
        public VmDirectoryListResult(string cookie = default(string), List<VmDirEntry> entries = default(List<VmDirEntry>))
        {
            this.Cookie = cookie;
            this.Entries = entries;
            this.Cookie = cookie;
            this.Entries = entries;
        }
        
        /// <summary>
        /// Cookie is used for paginating results. If ReadVMDirResult is returning partial results, this field will be set. Supplying this cookie will resume listing from where this result left off.
        /// </summary>
        /// <value>Cookie is used for paginating results. If ReadVMDirResult is returning partial results, this field will be set. Supplying this cookie will resume listing from where this result left off.</value>
        [DataMember(Name="cookie", EmitDefaultValue=true)]
        public string Cookie { get; set; }

        /// <summary>
        /// Entries is the array of files and folders that are immediate children of the parent directory specified in the request.
        /// </summary>
        /// <value>Entries is the array of files and folders that are immediate children of the parent directory specified in the request.</value>
        [DataMember(Name="entries", EmitDefaultValue=true)]
        public List<VmDirEntry> Entries { get; set; }

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
            return this.Equals(input as VmDirectoryListResult);
        }

        /// <summary>
        /// Returns true if VmDirectoryListResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VmDirectoryListResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmDirectoryListResult input)
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
                    this.Entries == input.Entries ||
                    this.Entries != null &&
                    input.Entries != null &&
                    this.Entries.Equals(input.Entries)
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
                if (this.Entries != null)
                    hashCode = hashCode * 59 + this.Entries.GetHashCode();
                return hashCode;
            }
        }

    }

}

