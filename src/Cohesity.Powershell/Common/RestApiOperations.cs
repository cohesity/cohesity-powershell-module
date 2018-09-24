// Copyright 2018 Cohesity Inc.
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cohesity.Powershell.Common
{
    internal static class RestApiOperations
    {
        private static T DeserializeObject<T>(string responseContent)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            return JsonConvert.DeserializeObject<T>(responseContent, settings);
        }

        private static string extractMessageFromErrorResponse(string responseContent)
        {
            if (!string.IsNullOrWhiteSpace(responseContent))
            {
                JObject errorResponse = JObject.Parse(responseContent);
                return (string)errorResponse["message"];
            }
            else
            {
                return "No Error Message";
            }
        }

        public static string Get(this RestApiClient networkClient, string url)
        {
            var httpRequest = networkClient.CreateRequest(HttpMethod.Get, url);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static T Get<T>(this RestApiClient networkClient, string url)
        {
            var responseContent = Get(networkClient, url);
            return DeserializeObject<T>(responseContent);
        }

        public static string Post(this RestApiClient networkClient, string url, string content)
        {
            if(content == null) content = string.Empty;

            var httpRequest = networkClient.CreatePostRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }
            
            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static string Post(this RestApiClient networkClient, string url, object content)
        {
            var httpRequest = networkClient.CreatePostRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static T Post<T>(this RestApiClient networkClient, string url, object content)
        {
            var responseContent = Post(networkClient, url, content);
            return DeserializeObject<T>(responseContent);
        }

        public static string Put(this RestApiClient networkClient, string url, object content)
        {
            var httpRequest = networkClient.CreatePutRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static T Put<T>(this RestApiClient networkClient, string url, object content)
        {
            var responseContent = Put(networkClient, url, content);
            return DeserializeObject<T>(responseContent);
        }

        public static string Delete(this RestApiClient networkClient, string url, object content)
        {
            var httpRequest = networkClient.CreateDeleteRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static string Delete(this RestApiClient networkClient, string url, string content)
        {
            var httpRequest = networkClient.CreateDeleteRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

    }
}
