using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cohesity
{
    /// <summary>
    /// Extends <see cref="NetworkClient"/> with common functions.
    /// </summary>
    internal static class NetworkClientExtensions
    {
        public static string Get(this NetworkClient networkClient, string url)
        {
            var httpRequest = networkClient.CreateRequest(HttpMethod.Get, new Uri(url));

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(
                $"Operation returned an invalid status code '{response.StatusCode}' with Exception:{(string.IsNullOrWhiteSpace(responseContent) ? "Not Available" : responseContent)}");
        }

        public static T Get<T>(this NetworkClient networkClient, string url)
        {
            var responseContent = Get(networkClient, url);
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        public static string Post(this NetworkClient networkClient, string url, string content)
        {
            var httpRequest = networkClient.CreatePostRequest(new Uri(url), content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(
                $"Operation returned an invalid status code '{response.StatusCode}' with Exception:{(string.IsNullOrWhiteSpace(responseContent) ? "Not Available" : responseContent)}");
        }

        public static string Post(this NetworkClient networkClient, string url, object content)
        {
            var httpRequest = networkClient.CreatePostRequest(new Uri(url), content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(
                $"Operation returned an invalid status code '{response.StatusCode}' with Exception:{(string.IsNullOrWhiteSpace(responseContent) ? "Not Available" : responseContent)}");
        }

        public static T Post<T>(this NetworkClient networkClient, string url, object content)
        {
            var responseContent = Post(networkClient, url, content);
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        public static string Put(this NetworkClient networkClient, string url, object content)
        {
            var httpRequest = networkClient.CreatePutRequest(new Uri(url), content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(
                $"Operation returned an invalid status code '{response.StatusCode}' with Exception:{(string.IsNullOrWhiteSpace(responseContent) ? "Not Available" : responseContent)}");
        }

        public static T Put<T>(this NetworkClient networkClient, string url, object content)
        {
            var responseContent = Put(networkClient, url, content);
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        public static string Delete(this NetworkClient networkClient, string url, object content)
        {
            var httpRequest = networkClient.CreateDeleteRequest(new Uri(url), content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(
                $"Operation returned an invalid status code '{response.StatusCode}' with Exception:{(string.IsNullOrWhiteSpace(responseContent) ? "Not Available" : responseContent)}");
        }

        public static string Delete(this NetworkClient networkClient, string url, string content)
        {
            var httpRequest = networkClient.CreateDeleteRequest(new Uri(url), content);

            var httpClient = networkClient.HttpClient;
            var response = httpClient.SendAsync(httpRequest).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseContent;
            }

            throw new Exception(
                $"Operation returned an invalid status code '{response.StatusCode}' with Exception:{(string.IsNullOrWhiteSpace(responseContent) ? "Not Available" : responseContent)}");
        }

    }
}
