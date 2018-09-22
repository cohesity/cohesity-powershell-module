// Copyright 2018 Cohesity Inc.
using System;

namespace Cohesity.Powershell.Common
{
    class UserProfile
    {
        public Uri ClusterUri { get; set; }

        public bool AllowInvalidServerCertificates { get; set; } = false;
        
        public AccessTokenObject AccessToken { get; set; }
    
    }
}
