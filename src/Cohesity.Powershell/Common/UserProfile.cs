using System;
using System.Management.Automation;

namespace Cohesity.Powershell
{
    class UserProfile
    {
        public Uri ClusterUri { get; set; }

        public bool AllowInvalidServerCertificates { get; set; } = false;
        
        public AccessTokenObject AccessToken { get; set; }
    
    }
}
