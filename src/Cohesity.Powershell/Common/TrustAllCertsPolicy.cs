using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Cohesity.Common
{
    internal class TrustAllCertsPolicy : ICertificatePolicy
    {
        public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
        {
            return true;
        }
    }
}
