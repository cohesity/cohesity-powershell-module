using System.Collections.Generic;

namespace Cohesity
{
    public class AccessTokenObject
    {
        public AccessTokenObject()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessToken" /> class.
        /// </summary>
        /// <param name="accessToken">Generated access token..</param>
        /// <param name="privileges">privileges.</param>
        /// <param name="tokenType">Access token type..</param>
        public AccessTokenObject(string accessToken = default(string), List<string> privileges = default(List<string>), string tokenType = default(string))
        {
            this.AccessToken = accessToken;
            this.Privileges = privileges;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Generated access token.
        /// </summary>
        /// <value>Generated access token.</value>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets Privileges
        /// </summary>
        public List<string> Privileges { get; set; }

        /// <summary>
        /// Access token type.
        /// </summary>
        /// <value>Access token type.</value>
        public string TokenType { get; set; }
    }
}

