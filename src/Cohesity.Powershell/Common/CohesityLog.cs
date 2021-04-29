using NLog;
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
        private static readonly NLog.Logger __log = NLog.LogManager.GetCurrentClassLogger();
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
                string logFileName = ConstructLogFileName(__cmdletConfig);
                var config = new NLog.Config.LoggingConfiguration();
                var logfile = new NLog.Targets.FileTarget("CohesityPowershellSDKLogFile") { FileName = logFileName, ArchiveAboveSize = 1024*1024, ArchiveNumbering = NLog.Targets.ArchiveNumberingMode.DateAndSequence };
                config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
                // Apply config           
                NLog.LogManager.Configuration = config;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not load logging module" + ex.Message);
            }
        }
        private string ConstructLogFileName(CmdletConfiguration param)
        {
            string logFileName = null;
            if(param.LogFilePath != null)
            {
                logFileName = String.Format("{0}/{1}", param.LogFilePath, param.LogFileName);
            }
            else
            {
                logFileName = String.Format("{0}/{1}/{2}", System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), param.ConfigFolder, param.LogFileName);
            }
            return logFileName;
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
            __log.Info(message);
        }
    }
}
