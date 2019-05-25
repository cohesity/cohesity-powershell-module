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
    /// Specifies the result of a request to download a package to a Cluster.
    /// </summary>
    [DataContract]
    public partial class DownloadPackageResult :  IEquatable<DownloadPackageResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadPackageResult" /> class.
        /// </summary>
        /// <param name="message">Specifies a message describing the result of the request to download a package to a Cluster..</param>
        public DownloadPackageResult(string message = default(string))
        {
            this.Message = message;
            this.Message = message;
        }
        
        /// <summary>
        /// Specifies a message describing the result of the request to download a package to a Cluster.
        /// </summary>
        /// <value>Specifies a message describing the result of the request to download a package to a Cluster.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadPackageResult {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as DownloadPackageResult);
        }

        /// <summary>
        /// Returns true if DownloadPackageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadPackageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadPackageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }

}
