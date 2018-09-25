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
    /// SslCertificateConfig represents the SSL certificate object exposed to the user.
    /// </summary>
    [DataContract]
    public partial class SslCertificateConfig :  IEquatable<SslCertificateConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SslCertificateConfig" /> class.
        /// </summary>
        /// <param name="certificate">Certificate is a SSL certificate used by Iris HTTPS webserver. TODO(gaurav): Consider using multipart form for certificate file..</param>
        /// <param name="lastUpdateTimeMsecs">LastUpdateTimeMsecs is a time in milliseconds at which certificate was last updated..</param>
        /// <param name="privateKey">PrivateKey is a matching private key of the above certificate..</param>
        public SslCertificateConfig(string certificate = default(string), long? lastUpdateTimeMsecs = default(long?), string privateKey = default(string))
        {
            this.Certificate = certificate;
            this.LastUpdateTimeMsecs = lastUpdateTimeMsecs;
            this.PrivateKey = privateKey;
        }
        
        /// <summary>
        /// Certificate is a SSL certificate used by Iris HTTPS webserver. TODO(gaurav): Consider using multipart form for certificate file.
        /// </summary>
        /// <value>Certificate is a SSL certificate used by Iris HTTPS webserver. TODO(gaurav): Consider using multipart form for certificate file.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// LastUpdateTimeMsecs is a time in milliseconds at which certificate was last updated.
        /// </summary>
        /// <value>LastUpdateTimeMsecs is a time in milliseconds at which certificate was last updated.</value>
        [DataMember(Name="lastUpdateTimeMsecs", EmitDefaultValue=false)]
        public long? LastUpdateTimeMsecs { get; set; }

        /// <summary>
        /// PrivateKey is a matching private key of the above certificate.
        /// </summary>
        /// <value>PrivateKey is a matching private key of the above certificate.</value>
        [DataMember(Name="privateKey", EmitDefaultValue=false)]
        public string PrivateKey { get; set; }

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
            return this.Equals(input as SslCertificateConfig);
        }

        /// <summary>
        /// Returns true if SslCertificateConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of SslCertificateConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SslCertificateConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.LastUpdateTimeMsecs == input.LastUpdateTimeMsecs ||
                    (this.LastUpdateTimeMsecs != null &&
                    this.LastUpdateTimeMsecs.Equals(input.LastUpdateTimeMsecs))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.LastUpdateTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdateTimeMsecs.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

