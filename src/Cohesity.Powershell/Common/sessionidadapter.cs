using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesity.Powershell.Common
{
    class SessionIdAdapter
    {
        static public bool ValidateSessionId(string server, string sessionId)
        {
            Session session = new Session();
            var preparedUrl = $"/public/users";
            var result = session.ApiClient.Get<IEnumerable<Model.User>>(preparedUrl);
            ICollection<Model.User> users = result as ICollection<Model.User>;
            if (users.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
