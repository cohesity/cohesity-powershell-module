// Copyright 2018 Cohesity Inc.
using System;
using Cohesity.Powershell.Common;

namespace Cohesity
{
    /// <summary>
    /// Session information shared by cmdlets.
    /// </summary>
    internal class Session
    {

        private RestApiClient apiClient = null;

        /// <summary>
        /// The network client used for communicating with Cohestiy REST API.
        /// </summary>
        public RestApiClient ApiClient
        {
            get
            {
                if (apiClient == null)
                {
                    apiClient = new RestApiClient();
                }

                return apiClient;
            }
        }

        public void AssertAuthentication()
        {
            if (!ApiClient.IsAuthenticated)
                throw new Exception("Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'");
        }        

    }
}
