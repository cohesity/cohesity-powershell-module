// Copyright 2018 Cohesity Inc.
using System;
using System.IO;
using Cohesity.Model;
using Newtonsoft.Json;

namespace Cohesity.Powershell.Common
{
    internal class UserProfileProvider
    {
        string COHESITY_USER_PROFILE = "cohesityUserProfile";
        public UserProfile GetUserProfile()
        {
            var userProfileJson = Environment.GetEnvironmentVariable(this.COHESITY_USER_PROFILE, EnvironmentVariableTarget.Process);
            if (userProfileJson == null)
            {
                return null;
            }
            return JsonConvert.DeserializeObject<UserProfile>(userProfileJson);
        }

        public void SetUserProfile(UserProfile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            var userProfileJson = JsonConvert.SerializeObject(profile);
            Environment.SetEnvironmentVariable(this.COHESITY_USER_PROFILE, userProfileJson, EnvironmentVariableTarget.Process);
        }

        public void DeleteUserProfile()
        {
            Environment.SetEnvironmentVariable(this.COHESITY_USER_PROFILE, null, EnvironmentVariableTarget.Process);
        }

        internal void SaveCredentials(AccessTokenCredential credentials)
        {
            var credentialsJson = JsonConvert.SerializeObject(credentials);
            Environment.SetEnvironmentVariable("cohesityCredentials", credentialsJson, EnvironmentVariableTarget.Process);
        }
        internal AccessTokenCredential GetCredentials()
        {
            var credentialsJson = Environment.GetEnvironmentVariable("cohesityCredentials", EnvironmentVariableTarget.Process);
            if(credentialsJson == null)
            {
                return null;
            }
             return JsonConvert.DeserializeObject<AccessTokenCredential>(credentialsJson);
        }
    }
}
