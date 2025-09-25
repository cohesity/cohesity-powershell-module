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
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Connect-CohesityCluster -Server 192.168.1.100 -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "mydomain.com\admin", (ConvertTo-SecureString -AsPlainText "p@ssword" -Force))
    ///   </code>
    ///   <para>
    ///   Connects to a Cohesity Cluster at the address "192.168.1.100" using the active directory user, by appending fully qualified domain name(mydomain.com) to the user.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Connect-CohesityCluster -Server 192.168.1.100 -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "LOCAL\user1@tenant1", (ConvertTo-SecureString -AsPlainText "p@ssword" -Force))
    ///   </code>
    ///   <para>
    ///   Connects to a Cohesity Cluster at the address "192.168.1.100" for a user "user1" in the tenant "tenant1".
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Connect-CohesityCluster -Server 192.168.1.100 -APIKey "00000000-0000-0000-0000-000000000000"
    ///   </code>
    ///   <para>
    ///   Connects to a Cohesity Cluster at the address "192.168.1.100" using the API Key (supported 6.5.1d onwards).
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Connect-CohesityCluster -Server 192.168.1.100 -sessionId "sessionId"
    ///   </code>
    ///   <para>
    ///   Connects to a Cohesity Cluster at the address "192.168.1.100" using the Session Id.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Connect-CohesityCluster -Server 192.168.1.100 -UseMFA -OtpType Email
    ///   </code>
    ///   <para>
    ///   Connects to a Cohesity Cluster at the address "192.168.1.100" using Multi-Factor Authentication(MFA). By default, OtpType will be considered as Totp if not provided. On trying to connect to the cluster using MFA, user will be prompted to provide OTP code.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommunications.Connect, "CohesityCluster", DefaultParameterSetName = "UsingCreds")]
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
        /// User credentials for the Cohesity Cluster.  To login as a tenant use the user name as LOCAL\user1@tenant1
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "UsingCreds")]
        public PSCredential Credential { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Cohesity API key
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = "UsingAPIKey")]
        public String APIKey { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Cohesity Session Id key
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = "UsingSessionId")]
        public String SessionId { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Do MFA required ?
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        // public bool UsingMFA { get; set; } = false;
        public SwitchParameter UseMFA { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies OTP type for MFA verification.
        /// 'Totp' implies the code is TOTP.
        /// 'Email' implies the code is email OTP. 
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public Model.AccessTokenCredential.OtpTypeEnum? OtpType { get; set; }

        private Uri clusterUri;
        private String otpCode;

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
            if (this.APIKey != null)
            {
                // allow the user profile for validating the api key
                var userProfile = new UserProfile
                {
                    ClusterUri = clusterUri,
                    AccessToken = null,
                    AllowInvalidServerCertificates = true,
                    APIKey = this.APIKey
                };
                userProfileProvider.SetUserProfile(userProfile);
                if (APIKeyAdapter.ValidateAPIKey(this.Server, this.APIKey))
                {
                    WriteObject($"Connected to the Cohesity Cluster {Server} Successfully");
                    return;
                }
                userProfileProvider.DeleteUserProfile();
                WriteObject("Failed to connect to the Cohesity Cluster.");
                return;
            }
            if (this.SessionId != null)
            {
                // allow the user profile for validating the api key
                var userProfile = new UserProfile
                {
                    ClusterUri = clusterUri,
                    AccessToken = null,
                    AllowInvalidServerCertificates = true,
                    SessionId = this.SessionId
                };
                userProfileProvider.SetUserProfile(userProfile);
                if (SessionIdAdapter.ValidateSessionId(this.Server, this.SessionId))
                {
                    WriteObject($"Connected to the Cohesity Cluster {Server} Successfully");
                    return;
                }
                userProfileProvider.DeleteUserProfile();
                WriteObject("Failed to connect to the Cohesity Cluster.");
                return;
            }

            var networkCredential = Credential.GetNetworkCredential();
            var domain = string.IsNullOrWhiteSpace(networkCredential.Domain) ? LocalDomain : networkCredential.Domain;

            // Use TLS1.1 or TLS1.2
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            if (UseMFA.IsPresent)
            {
                if (OtpType == Model.AccessTokenCredential.OtpTypeEnum.Email)
                {
                    var emailMfaBody = new AccessTokenCredential
                    {
                        Domain = domain,
                        Username = networkCredential.UserName,
                        Password = networkCredential.Password
                    };

                    // Send security code to the registered mail address for the logged in user
                    var emailMfaUrl = $"/v2/email-otp";
                    var emailMFARequest = new HttpRequestMessage(HttpMethod.Post, emailMfaUrl)
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(emailMfaBody), Encoding.UTF8, "application/json")
                    };

                    try
                    {
                        var httpClient = Session.ApiClient.BuildClient(clusterUri, true);
                        var sendSecurityCode = httpClient.SendAsync(emailMFARequest).Result;
                        var sendSecurityCodeResponse = sendSecurityCode.Content.ReadAsStringAsync().Result;

                        if (sendSecurityCode.StatusCode != HttpStatusCode.NoContent)
                        {
                            var accessCodeError = JsonConvert.DeserializeObject<ErrorProto>(sendSecurityCodeResponse);
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Failed to send access code to the registered email address");
                            sb.AppendLine(accessCodeError.ErrorMsg);
                            throw new Exception(sb.ToString());
                        }

                        Console.WriteLine("Access code is sent to the registered email address");
                    }
                    catch (Exception ex)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Failed to send access code to the registered email address");
                        sb.AppendLine(ex.Message);
                        throw new Exception(sb.ToString());
                    }
                }

                Console.WriteLine("Enter MFA code");
                otpCode = Console.ReadLine();
            }

            var credentials = new AccessTokenCredential
            {
                Domain = domain,
                Username = networkCredential.UserName,
                Password = networkCredential.Password,
                OtpCode = otpCode,
                OtpType = OtpType == null ? Model.AccessTokenCredential.OtpTypeEnum.Totp : OtpType
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
                };

                userProfileProvider.SetUserProfile(userProfile);
                //saving the credentials in process environment variable
                userProfileProvider.SaveCredentials(credentials);

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
