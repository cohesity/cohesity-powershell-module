using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesity
{
    public class AccessTokenCredential
    {

        /// <summary>
        /// Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.
        /// </summary>
        /// <value>
        /// Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.
        /// </value>
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.
        /// </summary>
        /// <value>Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.</value>
        public string Password { get; set; }

        /// <summary>
        /// Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.
        /// </summary>
        /// <value>Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.</value>
        public string Username { get; set; }


    }
}

