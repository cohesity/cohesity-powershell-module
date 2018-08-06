using System;
using System.Management.Automation;

namespace Cohesity.Powershell
{
    class UserProfile
    {
        public Uri ClusterUri { get; set; }

        public bool AllowInvalidServerCertificates { get; set; } = false;

        public PSCredential Credential { get; set; }

        public AccessTokenObject AccessToken { get; set; }
    
    }
}
