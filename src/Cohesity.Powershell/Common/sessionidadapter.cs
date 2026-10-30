using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Cohesity.Model;
using Newtonsoft.Json;

namespace Cohesity.Powershell.Common
{
    class SessionIdAdapter
    {
        public static bool ValidateSessionId(string server, string sessionId)
        {
            var session = new Session();
            var preparedUrl = $"/public/users";

            try
            {
                var result = session.ApiClient.Get<IEnumerable<Model.User>>(preparedUrl);
                if (result is ICollection<Model.User> users && users.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception during session regeneration: " + ex.Message);
            }

            return TryRegenerateSessionId(server);
        }

        private static bool TryRegenerateSessionId(string server)
        {
            var userProfileProvider = ServiceLocator.GetUserProfileProvider();
            var userProfile = userProfileProvider.GetUserProfile();
            var credentials = userProfileProvider.GetCredentials();

            if (userProfile == null || credentials == null || userProfile.ClusterUri == null)
            {
                Console.WriteLine("Missing profile or credentials.");
                return false;
            }

            try
            {
                var requestBody = new
                {
                    username = credentials.Username,
                    password = credentials.Password
                };

                var clusterUri = userProfile.ClusterUri.ToString();
                if (clusterUri.Contains("/irisservices/api/v1"))
                {
                    clusterUri = clusterUri.Replace("/irisservices/api/v1", "");
                }

                var baseUri = new Uri(clusterUri);
                var apiUri = new Uri(baseUri, "v2/users/sessions");

                var httpRequest = new HttpRequestMessage(HttpMethod.Post, apiUri)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json")
                };

                var httpClient = new RestApiClient().BuildClient(userProfile.ClusterUri, true);



                var response = httpClient.SendAsync(httpRequest).Result;
                var content = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var sessionResponse = JsonConvert.DeserializeObject<SessionIdResponse>(content);
                    userProfile.SessionId = sessionResponse.SessionId;
                    userProfileProvider.SetUserProfile(userProfile);

                    Console.WriteLine("Session ID successfully regenerated.");

                    // Retry validation
                    var session = new Session();
                    var users = session.ApiClient.Get<IEnumerable<Model.User>>("/public/users");
                    return users != null && users.Any();
                }
                else
                {
                    Console.WriteLine("Failed to regenerate session ID: " + content);
                }
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Failed to connect to the Cohesity Cluster");
                sb.AppendLine(ex.Message);
                throw new Exception(sb.ToString());
            }

            return false;
        }
    }

    /// <summary>
    /// Represents the response from the Cohesity API containing the session ID.
    /// </summary>
    public class SessionIdResponse
    {
        /// <summary>
        /// The session ID returned by the Cohesity API after successful authentication.
        /// </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }
}
