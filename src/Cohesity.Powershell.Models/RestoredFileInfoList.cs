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
    /// RestoredFileInfoList
    /// </summary>
    [DataContract]
    public partial class RestoredFileInfoList :  IEquatable<RestoredFileInfoList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoredFileInfoList" /> class.
        /// </summary>
        /// <param name="isDirectory">Specifies whether the path points to directory..</param>
        public RestoredFileInfoList(bool? isDirectory = default(bool?))
        {
            this.IsDirectory = isDirectory;
            this.IsDirectory = isDirectory;
        }
        
        /// <summary>
        /// Specifies whether the path points to directory.
        /// </summary>
        /// <value>Specifies whether the path points to directory.</value>
        [DataMember(Name="isDirectory", EmitDefaultValue=true)]
        public bool? IsDirectory { get; set; }

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
            return this.Equals(input as RestoredFileInfoList);
        }

        /// <summary>
        /// Returns true if RestoredFileInfoList instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoredFileInfoList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoredFileInfoList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsDirectory == input.IsDirectory ||
                    (this.IsDirectory != null &&
                    this.IsDirectory.Equals(input.IsDirectory))
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
                if (this.IsDirectory != null)
                    hashCode = hashCode * 59 + this.IsDirectory.GetHashCode();
                return hashCode;
            }
        }

    }

}

