using System;

namespace Cohesity
{
    /// <summary>
    /// Session information shared by cmdlets.
    /// </summary>
    internal class Session
    {

        private NetworkClient networkClient = null;

        /// <summary>
        /// The network client used for communicating with Cohestiy resources API.
        /// </summary>
        public NetworkClient NetworkClient
        {
            get
            {
                if (networkClient == null)
                {
                    networkClient = new NetworkClient();
                }

                return networkClient;
            }
        }

        public void AssertAuthentication()
        {
            if (!NetworkClient.IsAuthenticated)
                throw new Exception("Connection is required, use Cohesity-Connect.");
        }

        

    }
}
