// Copyright 2018 Cohesity Inc.
using System;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Text;
using Cohesity.Model;
using Cohesity.Powershell.Common;
using Newtonsoft.Json;

namespace Cohesity.Powershell.Cmdlets.Cluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Connects to a Cohesity Cluster and acquires an authentication token.
    /// </para>
    /// <para type="description">
    /// You must run this cmdlet with valid Cohesity credentials before any other Cohesity cmdlets.
    /// The subsequent Cohesity cmdlets will use this connection. The connection is valid for 24 hours.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Connect-CohesityCluster -Server 192.168.1.100 -Credential (Get-Credential)
    ///   </code>
    ///   <para>
    ///   Connects to a Cohesity Cluster at the address "192.168.1.100" using the provided credentials.
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
        /// The FQDN or IP address of any node in the Cohesity Cluster or Cluster VIP.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string Server { get; set; }

        /// <summary>
        /// <para type="description">
        /// The port to use to connect to Cohesity Cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long Port { get; set; } = 443;

        /// <summary>
        /// <para type="description">
        /// User credentials for the Cohesity Cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public PSCredential Credential { get; set; } = null;

        private Uri clusterUri;

        /// <summary>
        /// Begin processing.
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            if (string.IsNullOrWhiteSpace(Server))
                throw new ParameterBindingException($"{nameof(Server)} must not be empty.");

            try
            {
                clusterUri = new Uri(Uri.UriSchemeHttps + Uri.SchemeDelimiter + Server + ":" + Port.ToString());
            }
            catch (Exception ex)
            {
                throw new ParameterBindingException($"{nameof(Server)} is not in a valid format.", ex);
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

            try
            {
                var httpClient = Session.ApiClient.BuildClient(clusterUri, true);
                var response = httpClient.SendAsync(httpRequest).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    var error = JsonConvert.DeserializeObject<ErrorProto>(responseContent);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Failed to connect to the Cohesity Cluster");
                    sb.AppendLine(error.ErrorMsg);
                    throw new Exception(sb.ToString());
                }

                var accessToken = JsonConvert.DeserializeObject<AccessToken>(responseContent);

                var userProfile = new UserProfile
                {
                    ClusterUri = clusterUri,
                    AccessToken = accessToken,
                    AllowInvalidServerCertificates = true,
                    Credentials = credentials,
                    TimestampUTC = DateTime.UtcNow.ToFileTimeUtc(),
                    ServerName = Server
                };

                userProfileProvider.SetUserProfile(userProfile);

                WriteObject($"Connected to the Cohesity Cluster {Server} Successfully");
            }
            catch (AggregateException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Failed to connect to the Cohesity Cluster");

                foreach (Exception exInnerException in ex.Flatten().InnerExceptions)
                {
                    Exception exNestedInnerException = exInnerException;
                    do
                    {
                        if (!string.IsNullOrEmpty(exNestedInnerException.Message))
                        {
                            sb.AppendLine(exNestedInnerException.Message);
                        }

                        exNestedInnerException = exNestedInnerException.InnerException;
                    } while (exNestedInnerException != null);
                }

                throw new Exception(sb.ToString());
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Failed to connect to the Cohesity Cluster");
                sb.AppendLine(ex.Message);
                throw new Exception(sb.ToString());
            }
        }
    }
}
