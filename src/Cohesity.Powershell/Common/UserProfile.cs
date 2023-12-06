﻿// Copyright 2018 Cohesity Inc.
using Cohesity.Model;
using System;

namespace Cohesity.Powershell.Common
{
    class UserProfile
    {
        public Uri ClusterUri { get; set; }

        public bool AllowInvalidServerCertificates { get; set; } = false;
        
        public AccessToken AccessToken { get; set; }
    
        public string APIKey { get; set; }
        public string SessionId { get; set; }
    }
}