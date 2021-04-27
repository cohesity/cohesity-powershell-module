using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Cohesity.Powershell.Common
{
    internal class CohesityLog
    {
        private CmdletConfiguration __cmdletConfig = null;
        //private Runspace __runSpace = null;
        //private Pipeline __pipeline = null;
        //private Command __cmd = null;
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
                //__runSpace = RunspaceFactory.CreateRunspace();
                //__runSpace.Open();
                //__pipeline = __runSpace.CreatePipeline();
                //// script based cohesity logs
                //__cmd = new Command("CSLog");
            }
            catch(Exception ex)
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
            //if(__cmd == null)
            //{
            //    Console.WriteLine("Command object could not be created, cannot create log.");
            //    return;
            //}
            if (__cmdletConfig.IsLogHeaderDetail)
            {
                //__cmd.Parameters.Add("Message", request.Content.Headers.ToString());
                Console.WriteLine(request.Content.Headers.ToString());
            }
            if (__cmdletConfig.IsLogRequestedPayload)
            {
                //__cmd.Parameters.Add("Message", request.Content.ToString());
                if(request.Content != null)
                {
                    Console.WriteLine(request.Content.ToString());
                }
            }

        }
        public void WriteCohesityLog(string message)
        {
            if (__cmdletConfig.LogSeverity == 0)
            {
                return;
            }
            Console.WriteLine(message);
            //__cmd.Parameters.Add("Message", message);
        }
    }
}
