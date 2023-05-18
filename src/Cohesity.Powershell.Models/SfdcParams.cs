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
    /// Specifies an Object containing information about a registered Salesforce source.
    /// </summary>
    [DataContract]
    public partial class SfdcParams :  IEquatable<SfdcParams>
    {
        /// <summary>
        /// Specifies the Environment type for salesforce. &#39;PROD&#39; &#39;SANDBOX&#39; &#39;OTHER&#39;
        /// </summary>
        /// <value>Specifies the Environment type for salesforce. &#39;PROD&#39; &#39;SANDBOX&#39; &#39;OTHER&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EndpointTypeEnum
        {
            /// <summary>
            /// Enum PROD for value: PROD
            /// </summary>
            [EnumMember(Value = "PROD")]
            PROD = 1,

            /// <summary>
            /// Enum SANDBOX for value: SANDBOX
            /// </summary>
            [EnumMember(Value = "SANDBOX")]
            SANDBOX = 2,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 3

        }

        /// <summary>
        /// Specifies the Environment type for salesforce. &#39;PROD&#39; &#39;SANDBOX&#39; &#39;OTHER&#39;
        /// </summary>
        /// <value>Specifies the Environment type for salesforce. &#39;PROD&#39; &#39;SANDBOX&#39; &#39;OTHER&#39;</value>
        [DataMember(Name="endpointType", EmitDefaultValue=true)]
        public EndpointTypeEnum? EndpointType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcParams" /> class.
        /// </summary>
        /// <param name="accessToken">Token that will be used in subsequent api requests..</param>
        /// <param name="concurrentApiRequestsLimit">Specifies the maximum number of concurrent API requests allowed for salesforce..</param>
        /// <param name="consumerKey">Consumer key from the connected app in Sfdc..</param>
        /// <param name="consumerSecret">Consumer secret from the connected app in Sfdc..</param>
        /// <param name="dailyApiLimit">Maximum daily api limit.</param>
        /// <param name="endpoint">Sfdc Endpoint URL..</param>
        /// <param name="endpointType">Specifies the Environment type for salesforce. &#39;PROD&#39; &#39;SANDBOX&#39; &#39;OTHER&#39;.</param>
        /// <param name="metadataEndpointUrl">Metadata endpoint url. All metadata requests must be made to this url..</param>
        /// <param name="refreshToken">Token that will be used to refresh the access token..</param>
        /// <param name="soapEndpointUrl">Soap endpoint url. All soap requests must be made to this url..</param>
        /// <param name="useBulkApi">use bulk api if set to true.</param>
        public SfdcParams(string accessToken = default(string), long? concurrentApiRequestsLimit = default(long?), string consumerKey = default(string), string consumerSecret = default(string), long? dailyApiLimit = default(long?), string endpoint = default(string), EndpointTypeEnum? endpointType = default(EndpointTypeEnum?), string metadataEndpointUrl = default(string), string refreshToken = default(string), string soapEndpointUrl = default(string), bool? useBulkApi = default(bool?))
        {
            this.AccessToken = accessToken;
            this.ConcurrentApiRequestsLimit = concurrentApiRequestsLimit;
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
            this.DailyApiLimit = dailyApiLimit;
            this.Endpoint = endpoint;
            this.EndpointType = endpointType;
            this.MetadataEndpointUrl = metadataEndpointUrl;
            this.RefreshToken = refreshToken;
            this.SoapEndpointUrl = soapEndpointUrl;
            this.UseBulkApi = useBulkApi;
            this.AccessToken = accessToken;
            this.ConcurrentApiRequestsLimit = concurrentApiRequestsLimit;
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
            this.DailyApiLimit = dailyApiLimit;
            this.Endpoint = endpoint;
            this.EndpointType = endpointType;
            this.MetadataEndpointUrl = metadataEndpointUrl;
            this.RefreshToken = refreshToken;
            this.SoapEndpointUrl = soapEndpointUrl;
            this.UseBulkApi = useBulkApi;
        }
        
        /// <summary>
        /// Token that will be used in subsequent api requests.
        /// </summary>
        /// <value>Token that will be used in subsequent api requests.</value>
        [DataMember(Name="accessToken", EmitDefaultValue=true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Specifies the maximum number of concurrent API requests allowed for salesforce.
        /// </summary>
        /// <value>Specifies the maximum number of concurrent API requests allowed for salesforce.</value>
        [DataMember(Name="concurrentApiRequestsLimit", EmitDefaultValue=true)]
        public long? ConcurrentApiRequestsLimit { get; set; }

        /// <summary>
        /// Consumer key from the connected app in Sfdc.
        /// </summary>
        /// <value>Consumer key from the connected app in Sfdc.</value>
        [DataMember(Name="consumerKey", EmitDefaultValue=true)]
        public string ConsumerKey { get; set; }

        /// <summary>
        /// Consumer secret from the connected app in Sfdc.
        /// </summary>
        /// <value>Consumer secret from the connected app in Sfdc.</value>
        [DataMember(Name="consumerSecret", EmitDefaultValue=true)]
        public string ConsumerSecret { get; set; }

        /// <summary>
        /// Maximum daily api limit
        /// </summary>
        /// <value>Maximum daily api limit</value>
        [DataMember(Name="dailyApiLimit", EmitDefaultValue=true)]
        public long? DailyApiLimit { get; set; }

        /// <summary>
        /// Sfdc Endpoint URL.
        /// </summary>
        /// <value>Sfdc Endpoint URL.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Metadata endpoint url. All metadata requests must be made to this url.
        /// </summary>
        /// <value>Metadata endpoint url. All metadata requests must be made to this url.</value>
        [DataMember(Name="metadataEndpointUrl", EmitDefaultValue=true)]
        public string MetadataEndpointUrl { get; set; }

        /// <summary>
        /// Token that will be used to refresh the access token.
        /// </summary>
        /// <value>Token that will be used to refresh the access token.</value>
        [DataMember(Name="refreshToken", EmitDefaultValue=true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Soap endpoint url. All soap requests must be made to this url.
        /// </summary>
        /// <value>Soap endpoint url. All soap requests must be made to this url.</value>
        [DataMember(Name="soapEndpointUrl", EmitDefaultValue=true)]
        public string SoapEndpointUrl { get; set; }

        /// <summary>
        /// use bulk api if set to true
        /// </summary>
        /// <value>use bulk api if set to true</value>
        [DataMember(Name="useBulkApi", EmitDefaultValue=true)]
        public bool? UseBulkApi { get; set; }

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
            return this.Equals(input as SfdcParams);
        }

        /// <summary>
        /// Returns true if SfdcParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ConcurrentApiRequestsLimit == input.ConcurrentApiRequestsLimit ||
                    (this.ConcurrentApiRequestsLimit != null &&
                    this.ConcurrentApiRequestsLimit.Equals(input.ConcurrentApiRequestsLimit))
                ) && 
                (
                    this.ConsumerKey == input.ConsumerKey ||
                    (this.ConsumerKey != null &&
                    this.ConsumerKey.Equals(input.ConsumerKey))
                ) && 
                (
                    this.ConsumerSecret == input.ConsumerSecret ||
                    (this.ConsumerSecret != null &&
                    this.ConsumerSecret.Equals(input.ConsumerSecret))
                ) && 
                (
                    this.DailyApiLimit == input.DailyApiLimit ||
                    (this.DailyApiLimit != null &&
                    this.DailyApiLimit.Equals(input.DailyApiLimit))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.EndpointType == input.EndpointType ||
                    this.EndpointType.Equals(input.EndpointType)
                ) && 
                (
                    this.MetadataEndpointUrl == input.MetadataEndpointUrl ||
                    (this.MetadataEndpointUrl != null &&
                    this.MetadataEndpointUrl.Equals(input.MetadataEndpointUrl))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.SoapEndpointUrl == input.SoapEndpointUrl ||
                    (this.SoapEndpointUrl != null &&
                    this.SoapEndpointUrl.Equals(input.SoapEndpointUrl))
                ) && 
                (
                    this.UseBulkApi == input.UseBulkApi ||
                    (this.UseBulkApi != null &&
                    this.UseBulkApi.Equals(input.UseBulkApi))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ConcurrentApiRequestsLimit != null)
                    hashCode = hashCode * 59 + this.ConcurrentApiRequestsLimit.GetHashCode();
                if (this.ConsumerKey != null)
                    hashCode = hashCode * 59 + this.ConsumerKey.GetHashCode();
                if (this.ConsumerSecret != null)
                    hashCode = hashCode * 59 + this.ConsumerSecret.GetHashCode();
                if (this.DailyApiLimit != null)
                    hashCode = hashCode * 59 + this.DailyApiLimit.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                hashCode = hashCode * 59 + this.EndpointType.GetHashCode();
                if (this.MetadataEndpointUrl != null)
                    hashCode = hashCode * 59 + this.MetadataEndpointUrl.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.SoapEndpointUrl != null)
                    hashCode = hashCode * 59 + this.SoapEndpointUrl.GetHashCode();
                if (this.UseBulkApi != null)
                    hashCode = hashCode * 59 + this.UseBulkApi.GetHashCode();
                return hashCode;
            }
        }

    }

}

