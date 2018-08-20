using Cohesity.Powershell;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cohesity
{
    internal class NetworkClient
    {
        private const string ApiFragment = "irisservices/api/v1/";

        private UserProfileProvider userProfileProvider;
        public HttpClient HttpClient { get; private set; }

        public NetworkClient()
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
#if NETSTANDARD2_0 || NETCOREAPP2_0 || NETCOREAPP2_1
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                {
                    return true;
                };
#endif

#if NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET47 || NET471 || NET472
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = false;
                ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                {
                    return true;
                };
#endif
            }

            HttpClient = new HttpClient(handler);
            HttpClient.BaseAddress = new Uri(baseAddress, ApiFragment);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return HttpClient;
        }
        
        
        private Uri GetUri(string fragment)
        {
            var userProfile = userProfileProvider.GetUserProfile();
            if (userProfile == null)
                return null;

            if (userProfile.ClusterUri == null)
                return null;

            var baseUri = new Uri(userProfile.ClusterUri, ApiFragment);

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
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreatePostRequest(string requestUri, object content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreatePostRequest(string requestUri, string content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreatePutRequest(string requestUri, object content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = uri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreateDeleteRequest(string requestUri, object content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = uri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreateDeleteRequest(string requestUri, string content)
        {
            var uri = GetUri(requestUri);
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = uri,
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public AccessTokenObject AccessToken
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

    }
}
