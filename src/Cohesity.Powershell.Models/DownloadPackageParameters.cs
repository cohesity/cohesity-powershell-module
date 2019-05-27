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
    /// Specifies the parameters needed for a request to download a new software package to a Cluster.
    /// </summary>
    [DataContract]
    public partial class DownloadPackageParameters :  IEquatable<DownloadPackageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadPackageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadPackageParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadPackageParameters" /> class.
        /// </summary>
        /// <param name="url">Specifies a URL from which the package can be downloaded to the Cluster. (required).</param>
        public DownloadPackageParameters(string url = default(string))
        {
            this.Url = url;
        }
        
        /// <summary>
        /// Specifies a URL from which the package can be downloaded to the Cluster.
        /// </summary>
        /// <value>Specifies a URL from which the package can be downloaded to the Cluster.</value>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

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
            return this.Equals(input as DownloadPackageParameters);
        }

        /// <summary>
        /// Returns true if DownloadPackageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadPackageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadPackageParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

    }

}

