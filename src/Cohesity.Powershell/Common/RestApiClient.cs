// Copyright 2018 Cohesity Inc.
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Cohesity.Model;
using Newtonsoft.Json;

namespace Cohesity.Powershell.Common
{
    internal class RestApiClient
    {
        private UserProfileProvider userProfileProvider;
        public HttpClient HttpClient { get; private set; }

        public RestApiClient()
        {
            userProfileProvider = ServiceLocator.GetUserProfileProvider();

            var userProfile = userProfileProvider.GetUserProfile();
            if (userProfile != null)
            {
                BuildClient(userProfile.ClusterUri, userProfile.AllowInvalidServerCertificates);
            }
        }

        /// <summary>
        /// When disconnecting from cluster, remove client so that there is no way to connect from current state.
        /// </summary>
        public void Disconnect()
        {
            if (HttpClient != null)
            {
                HttpClient.Dispose();
                HttpClient = null;
            }
        }

        public HttpClient BuildClient(Uri baseAddress, bool allowInvalidServerCertificates) 
        {
            var handler = new HttpClientHandler();

            if (allowInvalidServerCertificates)
            {
#if NETCORE
                handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
#endif

#if NETFRAMEWORK
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
#endif
            }

            HttpClient = new HttpClient(handler);
            HttpClient.BaseAddress = new Uri(baseAddress, CohesityConstants.ApiBasePath);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(CohesityConstants.ContentType));
            HttpClient.DefaultRequestHeaders.Add(CohesityConstants.HttpHeaderUserAgent, CohesityConstants.ModuleName);

            return HttpClient;
        }
        
        
        private Uri GetUri(string fragment)
        {
            var userProfile = userProfileProvider.GetUserProfile();
            if (userProfile == null)
                return null;

            if (userProfile.ClusterUri == null)
                return null;

            var baseUri = new Uri(userProfile.ClusterUri, CohesityConstants.ApiBasePath);

            if (fragment.StartsWith("/"))
            {
                fragment = fragment.TrimStart('/');
            }

            return new Uri(baseUri, fragment);
        }

        public HttpRequestMessage CreateRequest(HttpMethod method, string requestUri)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage(method, uri);
            if (AccessToken != null)
            {
                request.Headers.Add(
                    CohesityConstants.HttpHeaderAuthorization,
                    $"{AccessToken.TokenType} {AccessToken._AccessToken}");
            }

            CohesityLog.Instance.WriteCohesityLog(request);
            return request;
        }

        public HttpRequestMessage CreatePostRequest(string requestUri, object content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, CohesityConstants.ContentType)
            };

            if (AccessToken != null)
            {
                request.Headers.Add(
                    CohesityConstants.HttpHeaderAuthorization,
                    $"{AccessToken.TokenType} {AccessToken._AccessToken}");
            }

            CohesityLog.Instance.WriteCohesityLog(request);
            return request;
        }

        public HttpRequestMessage CreatePostRequest(string requestUri, string content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
                Content = new StringContent(content, Encoding.UTF8, CohesityConstants.ContentType)
            };

            if (AccessToken != null)
            {
                request.Headers.Add(
                    CohesityConstants.HttpHeaderAuthorization,
                    $"{AccessToken.TokenType} {AccessToken._AccessToken}");
            }

            CohesityLog.Instance.WriteCohesityLog(request);
            return request;
        }

        public HttpRequestMessage CreatePutRequest(string requestUri, object content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = uri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, CohesityConstants.ContentType)
            };

            if (AccessToken != null)
            {
                request.Headers.Add(
                    CohesityConstants.HttpHeaderAuthorization,
                    $"{AccessToken.TokenType} {AccessToken._AccessToken}");
            }

            CohesityLog.Instance.WriteCohesityLog(request);
            return request;
        }

        public HttpRequestMessage CreateDeleteRequest(string requestUri, object content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = uri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, CohesityConstants.ContentType)
            };

            if (AccessToken != null)
            {
                request.Headers.Add(
                    CohesityConstants.HttpHeaderAuthorization,
                    $"{AccessToken.TokenType} {AccessToken._AccessToken}");
            }

            CohesityLog.Instance.WriteCohesityLog(request);
            return request;
        }

        public HttpRequestMessage CreateDeleteRequest(string requestUri, string content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = uri,
                Content = new StringContent(content, Encoding.UTF8, CohesityConstants.ContentType)
            };

            if (AccessToken != null)
            {
                request.Headers.Add(
                    CohesityConstants.HttpHeaderAuthorization,
                    $"{AccessToken.TokenType} {AccessToken._AccessToken}");
            }

            CohesityLog.Instance.WriteCohesityLog(request);
            return request;
        }

        public AccessToken AccessToken
        {
            get
            {
                var userProfile = userProfileProvider.GetUserProfile();
                if (userProfile == null)
                    return null;

                return userProfile.AccessToken;
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                var userProfile = userProfileProvider.GetUserProfile();

                if (userProfile == null)
                    return false;

                return userProfile.AccessToken != null;
            }
        }
        public bool ShallRefreshToken()
        {
            return CmdletConfiguration.Instance.IsRefreshToken;
        }
        public bool InitiateTokenRefresh()
        {
            var userProfile = userProfileProvider.GetUserProfile();
            if(null == userProfile)
            {
                return false;
            }
            Console.WriteLine("The session token has expired, attempting to refresh.");
            AccessTokenCredential credentials = userProfileProvider.GetCredentials();
            if (null == credentials)
            {
                Console.WriteLine("No credentials available to implictly connect the cluster.");
                return false;
            }

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, "public/accessTokens")
            {
                Content = new StringContent(JsonConvert.SerializeObject(credentials), Encoding.UTF8, "application/json")
            };

            try
            {
                var httpClient = BuildClient(userProfile.ClusterUri, true);
                var response = httpClient.SendAsync(httpRequest).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    var error = JsonConvert.DeserializeObject<ErrorProto>(responseContent);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(error.ErrorMsg);
                    Console.WriteLine("Exception : Refreshing the token, " + sb.ToString());
                    return false;
                }

                var accessToken = JsonConvert.DeserializeObject<AccessToken>(responseContent);

                userProfile.AccessToken = accessToken;
                userProfileProvider.SetUserProfile(userProfile);
                Console.WriteLine("The session token has been refreshed.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : Refreshing the token, " + ex.Message);
                return false;
            }
            return true;
        }
    }
}
