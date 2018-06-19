using Cohesity.Models;
using Newtonsoft.Json;
using System;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Cohesity
{
    /// <summary>
    /// <para type="synopsis">
    /// Connect to Cohesity cluster.
    /// </para>
    /// <para type="description">
    /// Before executing other Cohesity cmdlets, you must connect with a valid Cohesity username and password.
    /// Subsequent Cohesity cmdlets will use this connection.
    /// A connection is valid for 24 hours.
    /// </para>
    /// </summary>
    [Cmdlet("Cohesity", "Connect")]
    public class Connect : PSCmdlet
    {
        private static string LocalDomain = "LOCAL";

        private Session Session
        {
            get
            {
                var result = SessionState.PSVariable.GetValue("Session") as Session;
                if (result == null)
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }


        [Parameter(Position = 1, Mandatory = true)]
        public string BaseUri { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the domain the user is logging in to. 
        /// For a Local user model, the domain is always LOCAL. 
        /// For LDAP/AD user models, the domain will map to an LDAP connection string. 
        /// A user is uniquely identified by a combination of username and domain. 
        /// If this is not set, LOCAL is assumed.
        /// </para>
        /// </summary>
        [Alias("D")]
        [Parameter(Position = 2, Mandatory = true)]
        [AllowEmptyString]
        public string Domain { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the login name of the Cohesity user. 
        /// (required).
        /// </para>
        /// </summary>
        [Alias("U")]
        [Parameter(Position = 3, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Username { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the password of the Cohesity user account. 
        /// (required).
        /// </para>
        /// </summary>
        [Alias("P")]
        [Parameter(Position = 4, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Password { get; set; }

        public bool sslIgnore = true;

        [Parameter]
        public SwitchParameter SslIgnore
        {
            get { return sslIgnore; }
            set { sslIgnore = value; }
        }

        private string preparedUrl;
        private string preparedDomain;

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            if (string.IsNullOrWhiteSpace(BaseUri))
                throw new ParameterBindingException($"{nameof(BaseUri)} must not be empty.");

            preparedDomain = string.IsNullOrWhiteSpace(Domain) ? LocalDomain : Domain;

            Session.NetworkClient.SslIgnore = sslIgnore;

            try
            {
                if (!BaseUri.StartsWith(Uri.UriSchemeHttp, StringComparison.OrdinalIgnoreCase) && !BaseUri.StartsWith(Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase))
                {
                    BaseUri = Uri.UriSchemeHttps + Uri.SchemeDelimiter + BaseUri;
                }

                var baseUri = new Uri(BaseUri);
                Session.NetworkClient.BaseUri = baseUri;
            }
            catch (Exception ex)
            {
                throw new ParameterBindingException($"{nameof(BaseUri)} is not in a valid format.", ex);
            }

            preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/accessTokens";
        }

        protected override void ProcessRecord()
        {
            var credentials = new AccessTokenCredential
            {
                Domain = preparedDomain,
                Username = Username,
                Password = Password
            };

            var httpRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(preparedUrl),
                Content = new StringContent(JsonConvert.SerializeObject(credentials), Encoding.UTF8, "application/json")
            };

            var httpClient = Session.NetworkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode != HttpStatusCode.Created)
            {
                var error = JsonConvert.DeserializeObject<Error>(responseContent);
                WriteVerbose(error.Message);
                return;
                //throw new Exception(
                //    $"Operation returned an invalid status code '{response.StatusCode}' with Exception:{(string.IsNullOrWhiteSpace(responseContent) ? "Not Available" : responseContent)}");
            }

            Session.NetworkClient.AccessToken = JsonConvert.DeserializeObject<AccessTokenObject>(responseContent);

            WriteVerbose("Connected to Cohesity Cluster Successfully");
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }
    }
}
