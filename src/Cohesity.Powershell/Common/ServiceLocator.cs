namespace Cohesity.Powershell
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
