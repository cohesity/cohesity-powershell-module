using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cohesity;

namespace CohesityApi.Controllers
{
    [Produces("application/json")]
    [Route("irisservices/api/v1/public/AccessTokens")]
    public class AccessTokensController : Controller
    {
        public ActionResult Post([FromBody] AccessTokenCredential credential)
        {
            if ("admin".Equals(credential.Username, StringComparison.OrdinalIgnoreCase))
                if ("password".Equals(credential.Password, StringComparison.OrdinalIgnoreCase))
                    return StatusCode(StatusCodes.Status201Created, new
                    {
                        AccessToken = "AT",
                        Privileges = new[] {
                            "Something"
                        },
                        TokenType = "json"
                    });

            return StatusCode(StatusCodes.Status403Forbidden, new
            {
                ErrorCode = 0,
                Message = "Wrong User"
            });
        }
    }
}