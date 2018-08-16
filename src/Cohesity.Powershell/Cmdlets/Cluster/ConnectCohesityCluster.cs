using Cohesity.Models;
using Cohesity.Powershell;
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
    /// Connects to a Cohesity cluster.
    /// </para>
    /// <para type="description">
    /// Before executing other Cohesity cmdlets, you must first connect using valid Cohesity credentials.
    /// Subsequent Cohesity cmdlets will use this connection.
    /// A connection is valid for 24 hours.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Connect-CohesityCluster -ClusterIP 192.168.1.100
    ///   </code>
    ///   <para>
    ///   Connects to a Cohesity Cluster at the address "192.168.1.100".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommunications.Connect, "CohesityCluster")]
    public class ConnectCohesityCluster : PSCmdlet
    {
        private static readonly string LocalDomain = "LOCAL";

        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        private readonly UserProfileProvider userProfileProvider;

        /// <summary>
        /// Construct the cmdlet.
        /// </summary>
        public ConnectCohesityCluster()
        {
            userProfileProvider = ServiceLocator.GetUserProfileProvider();
        }

        /// <summary>
        /// <para type="description">
        /// The address of a Cohesity Cluster to be connected.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = true)]
        public string ClusterIP { get; set; }

        /// <summary>
        /// <para type="description">
        /// User credentials for the Cohesity Cluster.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = true)]
        public PSCredential Credential { get; set; } = null;

        private bool sslIgnore = true;

        /// <summary>
        /// <para type="description">
        /// Ignore invalid SSL/TLS connections.
        /// </para>
        /// </summary>
        [Parameter]
        public SwitchParameter SslIgnore
        {
            get { return sslIgnore; }
            set { sslIgnore = value; }
        }

        private Uri clusterUri;

        /// <summary>
        /// Begin processing.
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            if (string.IsNullOrWhiteSpace(ClusterIP))
                throw new ParameterBindingException($"{nameof(ClusterIP)} must not be empty.");

            try
            {
                if (!ClusterIP.StartsWith(Uri.UriSchemeHttp, StringComparison.OrdinalIgnoreCase) && !ClusterIP.StartsWith(Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase))
                {
                    ClusterIP = Uri.UriSchemeHttps + Uri.SchemeDelimiter + ClusterIP;
                }

                clusterUri = new Uri(ClusterIP);
            }
            catch (Exception ex)
            {
                throw new ParameterBindingException($"{nameof(ClusterIP)} is not in a valid format.", ex);
            }
        }

        /// <summary>
        /// Process Records
        /// </summary>
        protected override void ProcessRecord()
        {
            var networkCredential = Credential.GetNetworkCredential();
            var domain = string.IsNullOrWhiteSpace(networkCredential.Domain) ? LocalDomain : networkCredential.Domain;

            var credentials = new AccessTokenCredential
            {
                Domain = domain,
                Username = networkCredential.UserName,
                Password = networkCredential.Password
            };

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, "public/accessTokens")
            {
                Content = new StringContent(JsonConvert.SerializeObject(credentials), Encoding.UTF8, "application/json")
            };

            var httpClient = Session.NetworkClient.BuildClient(clusterUri, sslIgnore);
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode != HttpStatusCode.Created)
            {
                var error = JsonConvert.DeserializeObject<Error>(responseContent);
                WriteObject(error.Message);
                return;
            }

            var accessToken = JsonConvert.DeserializeObject<AccessTokenObject>(responseContent);

            var userProfile = new UserProfile
            {
                ClusterUri = clusterUri,
                AccessToken = accessToken,
                AllowInvalidServerCertificates = sslIgnore
            };

            userProfileProvider.SetUserProfile(userProfile);

            WriteObject("Connected to Cohesity Cluster Successfully");
        }
    }
}
