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
    /// Contains all params specified by the user while registering a Sfdc source.
    /// </summary>
    [DataContract]
    public partial class RegisteredEntitySfdcParams :  IEquatable<RegisteredEntitySfdcParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredEntitySfdcParams" /> class.
        /// </summary>
        /// <param name="accessToken">Token that will be used in subsequent api requests..</param>
        /// <param name="apiLimit">Maximum daily api limit.</param>
        /// <param name="authToken">Token that will be used for fetching access_token from salesforce..</param>
        /// <param name="callbackUrl">Callback URL that is required to fetch Access token from salesforce..</param>
        /// <param name="concurrentReqLimit">Concurrent API Request Limits..</param>
        /// <param name="consumerKey">Consumer key from the connected app in Sfdc..</param>
        /// <param name="consumerSecret">Consumer secret from the connected app in Sfdc..</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="endpoint">Sfdc instance_url. Rename to instance_url later..</param>
        /// <param name="endpointType">endpointType.</param>
        /// <param name="metadataEndpointUrl">Metadata endpoint url. All metadata requests must be made to this url..</param>
        /// <param name="refreshToken">Token that will be used to refresh the access token..</param>
        /// <param name="soapEndpointUrl">Soap endpoint url. All soap requests must be made to this url..</param>
        /// <param name="useBulkApi">use bulk api if set to true.</param>
        public RegisteredEntitySfdcParams(string accessToken = default(string), long? apiLimit = default(long?), string authToken = default(string), string callbackUrl = default(string), long? concurrentReqLimit = default(long?), string consumerKey = default(string), string consumerSecret = default(string), Credentials credentials = default(Credentials), string endpoint = default(string), int? endpointType = default(int?), string metadataEndpointUrl = default(string), string refreshToken = default(string), string soapEndpointUrl = default(string), bool? useBulkApi = default(bool?))
        {
            this.AccessToken = accessToken;
            this.ApiLimit = apiLimit;
            this.AuthToken = authToken;
            this.CallbackUrl = callbackUrl;
            this.ConcurrentReqLimit = concurrentReqLimit;
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
            this.Endpoint = endpoint;
            this.EndpointType = endpointType;
            this.MetadataEndpointUrl = metadataEndpointUrl;
            this.RefreshToken = refreshToken;
            this.SoapEndpointUrl = soapEndpointUrl;
            this.UseBulkApi = useBulkApi;
            this.AccessToken = accessToken;
            this.ApiLimit = apiLimit;
            this.AuthToken = authToken;
            this.CallbackUrl = callbackUrl;
            this.ConcurrentReqLimit = concurrentReqLimit;
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
            this.Credentials = credentials;
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
        /// Maximum daily api limit
        /// </summary>
        /// <value>Maximum daily api limit</value>
        [DataMember(Name="apiLimit", EmitDefaultValue=true)]
        public long? ApiLimit { get; set; }

        /// <summary>
        /// Token that will be used for fetching access_token from salesforce.
        /// </summary>
        /// <value>Token that will be used for fetching access_token from salesforce.</value>
        [DataMember(Name="authToken", EmitDefaultValue=true)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Callback URL that is required to fetch Access token from salesforce.
        /// </summary>
        /// <value>Callback URL that is required to fetch Access token from salesforce.</value>
        [DataMember(Name="callbackUrl", EmitDefaultValue=true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Concurrent API Request Limits.
        /// </summary>
        /// <value>Concurrent API Request Limits.</value>
        [DataMember(Name="concurrentReqLimit", EmitDefaultValue=true)]
        public long? ConcurrentReqLimit { get; set; }

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
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Sfdc instance_url. Rename to instance_url later.
        /// </summary>
        /// <value>Sfdc instance_url. Rename to instance_url later.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets EndpointType
        /// </summary>
        [DataMember(Name="endpointType", EmitDefaultValue=true)]
        public int? EndpointType { get; set; }

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
            return this.Equals(input as RegisteredEntitySfdcParams);
        }

        /// <summary>
        /// Returns true if RegisteredEntitySfdcParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisteredEntitySfdcParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisteredEntitySfdcParams input)
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
                    this.ApiLimit == input.ApiLimit ||
                    (this.ApiLimit != null &&
                    this.ApiLimit.Equals(input.ApiLimit))
                ) && 
                (
                    this.AuthToken == input.AuthToken ||
                    (this.AuthToken != null &&
                    this.AuthToken.Equals(input.AuthToken))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.ConcurrentReqLimit == input.ConcurrentReqLimit ||
                    (this.ConcurrentReqLimit != null &&
                    this.ConcurrentReqLimit.Equals(input.ConcurrentReqLimit))
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
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.EndpointType == input.EndpointType ||
                    (this.EndpointType != null &&
                    this.EndpointType.Equals(input.EndpointType))
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
                if (this.ApiLimit != null)
                    hashCode = hashCode * 59 + this.ApiLimit.GetHashCode();
                if (this.AuthToken != null)
                    hashCode = hashCode * 59 + this.AuthToken.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.ConcurrentReqLimit != null)
                    hashCode = hashCode * 59 + this.ConcurrentReqLimit.GetHashCode();
                if (this.ConsumerKey != null)
                    hashCode = hashCode * 59 + this.ConsumerKey.GetHashCode();
                if (this.ConsumerSecret != null)
                    hashCode = hashCode * 59 + this.ConsumerSecret.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.EndpointType != null)
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

