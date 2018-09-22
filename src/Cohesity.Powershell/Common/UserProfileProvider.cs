// Copyright 2018 Cohesity Inc.
using System;
using System.IO;
using Newtonsoft.Json;

namespace Cohesity.Powershell.Common
{
    internal class UserProfileProvider
    {
        public UserProfile GetUserProfile()
        {
            var userProfileFilename = GetUserProfileFilename();

            if (!File.Exists(userProfileFilename))
            {
                return null;
            }

            var profileJson = string.Empty;

            using (var fs = File.OpenRead(userProfileFilename))
            {
                if (!fs.CanRead)
                {
                    throw new InvalidOperationException($"Cannot read user profile located at \"{userProfileFilename}\".");
                }

                using (var sw = new StreamReader(fs))
                {
                    profileJson = sw.ReadToEnd();
                }
            }

            if (string.IsNullOrWhiteSpace(profileJson))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<UserProfile>(profileJson);
        }

        public void SetUserProfile(UserProfile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            var profileJson = JsonConvert.SerializeObject(profile);
            var userProfileFilename = GetUserProfileFilename();


            using (var fs = File.OpenWrite(userProfileFilename))
            {


                if (!fs.CanWrite)
                {
                    throw new InvalidOperationException($"Cannot write user profile located at \"{userProfileFilename}\".");
                }

                fs.SetLength(0);

                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(profileJson);
                }
            }
        }

        public void DeleteUserProfile()
        {
            var userProfileFilename = GetUserProfileFilename();

            if (File.Exists(userProfileFilename))
            {
                File.Delete(userProfileFilename);
            }
        }

        private string GetUserProfileFilename()
        {
            var userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return Path.Combine(userProfilePath, ".cohesity");
        }
    }
}
