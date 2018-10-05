// Copyright 2018 Cohesity Inc.
using System;
using System.Management.Automation;
using System.Net;
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

        public static string Get(this RestApiClient networkClient, string url, out HttpStatusCode statusCode)
        {
            var httpRequest = networkClient.CreateRequest(HttpMethod.Get, url);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            statusCode = response.StatusCode;
            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static T Get<T>(this RestApiClient networkClient, string url)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            var responseContent = Get(networkClient, url, out statusCode);
            return DeserializeObject<T>(responseContent);
        }

        public static T Get<T>(this RestApiClient networkClient, string url, Action<string> writeDebug)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            var responseContent = Get(networkClient, url, out statusCode);
            T res = JsonConvert.DeserializeObject<T>(responseContent);
            string json = JsonConvert.SerializeObject(res, Formatting.Indented);
            writeDebug("GET " + url + " \r\n HTTP StatusCode: " + (int)statusCode + " " + statusCode + "\r\n JSON:\r\n" + json);
            return res;
        }

        public static string Post(this RestApiClient networkClient, string url, string content, out HttpStatusCode statusCode)
        {
            if (content == null) content = string.Empty;

            var httpRequest = networkClient.CreatePostRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            statusCode = response.StatusCode;
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
        public static string Post(this RestApiClient networkClient, string url, object content, out HttpStatusCode statusCode)
        {
            var httpRequest = networkClient.CreatePostRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            statusCode = response.StatusCode;
            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static T Post<T>(this RestApiClient networkClient, string url, object content)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            var responseContent = Post(networkClient, url, content, out statusCode);
            return DeserializeObject<T>(responseContent);
        }

        public static T Post<T>(this RestApiClient networkClient, string url, object content, Action<string> writeDebug)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            var responseContent = Post(networkClient, url, content, out statusCode);
            T res = JsonConvert.DeserializeObject<T>(responseContent);
            string json = JsonConvert.SerializeObject(res, Formatting.Indented);
            writeDebug("POST " + url + " \r\n Request(JSON):\r\n" + content + " \r\n HTTP StatusCode:" + (int)statusCode + " " + statusCode + "\r\n Response(JSON):\r\n" + json);
            return res;
        }

        public static string Post(this RestApiClient networkClient, string url, object content, Action<string> writeDebug)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            string res = networkClient.Post(url, content, out statusCode);
            writeDebug("POST " + url + " \r\n Request(JSON):\r\n" + content + " \r\n  HTTP StatusCode: " + (int)statusCode + " " + statusCode);
            return res;
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

        public static string Put(this RestApiClient networkClient, string url, object content, out HttpStatusCode statusCode)
        {
            var httpRequest = networkClient.CreatePutRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            statusCode = response.StatusCode;
            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static T Put<T>(this RestApiClient networkClient, string url, object content)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            var responseContent = Put(networkClient, url, content, out statusCode);
            return DeserializeObject<T>(responseContent);
        }

        public static T Put<T>(this RestApiClient networkClient, string url, object content, Action<string> writeDebug)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            var responseContent = Put(networkClient, url, content, out statusCode);
            T res = DeserializeObject<T>(responseContent);
            string json = JsonConvert.SerializeObject(res, Formatting.Indented);
            writeDebug("PUT " + url + " \r\n Request(JSON):\r\n" + content + " \r\n HTTP StatusCode:" + (int)statusCode + " " + statusCode + "\r\n Response(JSON):\r\n" + json);
            return res;
        }

        public static string Delete(this RestApiClient networkClient, string url, object content, out HttpStatusCode statusCode)
        {
            var httpRequest = networkClient.CreateDeleteRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            statusCode = response.StatusCode;
            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
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

        public static string Delete(this RestApiClient networkClient, string url, string content, out HttpStatusCode statusCode)
        {
            var httpRequest = networkClient.CreateDeleteRequest(url, content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            statusCode = response.StatusCode;
            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(extractMessageFromErrorResponse(responseContent));
        }

        public static string Delete(this RestApiClient networkClient, string url, object content, Action<string> writeDebug)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            string response = networkClient.Delete(url, content, out statusCode);
            writeDebug("DELETE " + url + "\r\n Request (RAW):\r\n" + content + " \r\n  Response StatusCode:" + (int)statusCode + " " + statusCode);
            return response;
        }

    }
}