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
    /// WebHookDeliveryTarget Specifies the external api url to hit along with the related options for it.
    /// </summary>
    [DataContract]
    public partial class WebHookDeliveryTarget :  IEquatable<WebHookDeliveryTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookDeliveryTarget" /> class.
        /// </summary>
        /// <param name="curlOptions">Specifies curl options used to invoke external api url defined above..</param>
        /// <param name="externalApiUrl">externalApiUrl.</param>
        public WebHookDeliveryTarget(string curlOptions = default(string), string externalApiUrl = default(string))
        {
            this.CurlOptions = curlOptions;
            this.ExternalApiUrl = externalApiUrl;
            this.CurlOptions = curlOptions;
            this.ExternalApiUrl = externalApiUrl;
        }
        
        /// <summary>
        /// Specifies curl options used to invoke external api url defined above.
        /// </summary>
        /// <value>Specifies curl options used to invoke external api url defined above.</value>
        [DataMember(Name="curlOptions", EmitDefaultValue=true)]
        public string CurlOptions { get; set; }

        /// <summary>
        /// Gets or Sets ExternalApiUrl
        /// </summary>
        [DataMember(Name="externalApiUrl", EmitDefaultValue=true)]
        public string ExternalApiUrl { get; set; }

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
            return this.Equals(input as WebHookDeliveryTarget);
        }

        /// <summary>
        /// Returns true if WebHookDeliveryTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookDeliveryTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookDeliveryTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurlOptions == input.CurlOptions ||
                    (this.CurlOptions != null &&
                    this.CurlOptions.Equals(input.CurlOptions))
                ) && 
                (
                    this.ExternalApiUrl == input.ExternalApiUrl ||
                    (this.ExternalApiUrl != null &&
                    this.ExternalApiUrl.Equals(input.ExternalApiUrl))
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
                if (this.CurlOptions != null)
                    hashCode = hashCode * 59 + this.CurlOptions.GetHashCode();
                if (this.ExternalApiUrl != null)
                    hashCode = hashCode * 59 + this.ExternalApiUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}

