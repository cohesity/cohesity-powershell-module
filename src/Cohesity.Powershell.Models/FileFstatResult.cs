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
    /// FileFstatResult is the struct to return the result of file Fstats.
    /// </summary>
    [DataContract]
    public partial class FileFstatResult :  IEquatable<FileFstatResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileFstatResult" /> class.
        /// </summary>
        /// <param name="cookie">Cookie is used for paginating results. If ReadVMDirResult is returning partial results, this field will be set. Supplying this cookie will resume listing from where this result left off..</param>
        /// <param name="fstatInfo">fstatInfo.</param>
        public FileFstatResult(int? cookie = default(int?), FileStatInfo fstatInfo = default(FileStatInfo))
        {
            this.Cookie = cookie;
            this.Cookie = cookie;
            this.FstatInfo = fstatInfo;
        }
        
        /// <summary>
        /// Cookie is used for paginating results. If ReadVMDirResult is returning partial results, this field will be set. Supplying this cookie will resume listing from where this result left off.
        /// </summary>
        /// <value>Cookie is used for paginating results. If ReadVMDirResult is returning partial results, this field will be set. Supplying this cookie will resume listing from where this result left off.</value>
        [DataMember(Name="cookie", EmitDefaultValue=true)]
        public int? Cookie { get; set; }

        /// <summary>
        /// Gets or Sets FstatInfo
        /// </summary>
        [DataMember(Name="fstatInfo", EmitDefaultValue=false)]
        public FileStatInfo FstatInfo { get; set; }

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
            return this.Equals(input as FileFstatResult);
        }

        /// <summary>
        /// Returns true if FileFstatResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FileFstatResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileFstatResult input)
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
                    this.FstatInfo == input.FstatInfo ||
                    (this.FstatInfo != null &&
                    this.FstatInfo.Equals(input.FstatInfo))
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
                if (this.FstatInfo != null)
                    hashCode = hashCode * 59 + this.FstatInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

