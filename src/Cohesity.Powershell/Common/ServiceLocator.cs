// Copyright 2018 Cohesity Inc.
namespace Cohesity.Powershell.Common
{
    internal class ServiceLocator
    {
        private static UserProfileProvider userProfileProvider = null;

        public static UserProfileProvider GetUserProfileProvider()
        {
            if (userProfileProvider == null)
            {
                userProfileProvider = new UserProfileProvider();
            }

            return userProfileProvider;
        }
    }
}
