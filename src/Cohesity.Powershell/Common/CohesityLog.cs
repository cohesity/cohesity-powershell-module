using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Cohesity.Powershell.Common
{
    internal class CohesityLog
    {
        private CmdletConfiguration __cmdletConfig = null;
        private static readonly CohesityLog instance = new CohesityLog();
        private CohesityLog()
        {
            Init();
        }
        public static CohesityLog Instance
        {
            get
            {
                return instance;
            }
        }
        private void Init()
        {
            try
            {
                __cmdletConfig = CmdletConfiguration.Instance;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not load logging module" + ex.Message);
            }
        }
        public void WriteCohesityLog(HttpRequestMessage request)
        {
            if(__cmdletConfig.LogSeverity == 0)
            {
                return;
            }
            if (__cmdletConfig.IsLogHeaderDetail)
            {
                WriteLog(request.RequestUri.AbsoluteUri,1);
                WriteLog(request.Headers.ToString(),1);
            }
            if (__cmdletConfig.IsLogRequestedPayload)
            {
                if(request.Content != null)
                {
                    WriteLog(request.Content.ToString(),1);
                }
            }

        }
        public void WriteCohesityLog(string message)
        {
            if (__cmdletConfig.LogSeverity == 0)
            {
                return;
            }
            WriteLog(message,1);
        }

        private void WriteLog(string message, int severity)
        {
            Console.WriteLine(message);
        }
    }
}
