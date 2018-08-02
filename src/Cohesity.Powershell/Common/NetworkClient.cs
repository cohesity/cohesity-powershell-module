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

        public NetworkClient()
        {
            BuildClient();
        }

        private void BuildClient()
        {

            var handler = new HttpClientHandler();

            if (SslIgnore)
            {
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                    {
                        return true;
                    };

                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                // ServicePointManager.CertificatePolicy = new TrustAllCertsPolicy();
                ServicePointManager.CheckCertificateRevocationList = false;
                ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                {
                    return true;
                };
            }

            HttpClient = new HttpClient(handler);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private bool sslIgnore = false;
        public bool SslIgnore
        {
            get
            {
                return sslIgnore;
            }
            set
            {
                sslIgnore = value;
                BuildClient();
            }
        }

        private const string ApiFragment = "irisservices/api/v1";

        private Uri baseUri;

        public Uri BaseUri
        {
            get
            {
                return new Uri(baseUri + ApiFragment);
            }
            set
            {
                baseUri = value;
            }
        }

        //private WebRequestHandler Handler;
        public HttpClient HttpClient { get; private set; }

        public HttpRequestMessage CreateRequest(HttpMethod method, Uri requestUri)
        {
            var request = new HttpRequestMessage(method, requestUri);
            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreatePostRequest(Uri requestUri, object content)
        {
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = requestUri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreatePostRequest(Uri requestUri, string content)
        {
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = requestUri,
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreatePutRequest(Uri requestUri, object content)
        {
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = requestUri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreateDeleteRequest(Uri requestUri, object content)
        {
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = requestUri,
                Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public HttpRequestMessage CreateDeleteRequest(Uri requestUri, string content)
        {
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = requestUri,
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            if (AccessToken != null)
            {
                request.Headers.Add("Authorization", $"{AccessToken.TokenType} {AccessToken.AccessToken}");
            }

            return request;
        }

        public AccessTokenObject AccessToken { get; set; }

        public bool IsAuthenticated
        {
            get
            {
                return AccessToken != null;
            }
        }

        //public string RawAccessToken { get; set; }
    }

    //internal class TrustAllCertsPolicy : ICertificatePolicy
    //{
    //    public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
    //    {
    //        return true;
    //    }

    //}
}
