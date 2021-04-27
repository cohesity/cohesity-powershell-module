using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesity.Powershell.Common
{
    internal class CmdletConfig
    {
        public int LogSeverity = 0;
        public bool LogRequestedPayload = false;
        public bool LogResponseData = false;
        public bool LogHeaderDetail = false;
        public bool RefreshToken = false;
    }
    internal class CmdletConfiguration
    {
        private static readonly CmdletConfiguration instance = new CmdletConfiguration();
        static CmdletConfiguration()
        {
        }

        private CmdletConfiguration()
        {
        }

        public static CmdletConfiguration Instance
        {
            get
            {
                instance.LoadConfig();
                return instance;
            }
        }
        private CmdletConfig __config = new CmdletConfig();
        private string GetConfigFilename()
        {
            var configFilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return Path.Combine(configFilePath, "cohesity","config.json");
        }
        private bool LoadConfig()
        {
            try
            {
                var configleFilename = GetConfigFilename();

                if (!File.Exists(configleFilename))
                {
                    return false;
                }
                var configJson = string.Empty;

                using (var fs = File.OpenRead(configleFilename))
                {
                    if (!fs.CanRead)
                    {
                        return false;
                    }

                    using (var sw = new StreamReader(fs))
                    {
                        configJson = sw.ReadToEnd();
                    }
                }

                if (string.IsNullOrWhiteSpace(configJson))
                {
                    return false;
                }

                this.__config = JsonConvert.DeserializeObject<CmdletConfig>(configJson);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public int LogSeverity
        {
            get
            {
                return this.__config.LogSeverity;
            }
        }
        public bool IsLogRequestedPayload
        {
            get
            {
                return this.__config.LogRequestedPayload;
            }
        }
        public bool IsLogResponseData
        {
            get
            {
                return this.__config.LogResponseData;
            }
        }
        public bool IsLogHeaderDetail
        {
            get
            {
                return this.__config.LogHeaderDetail;
            }
        }
        public bool IsRefreshToken
        {
            get
            {
                return this.__config.RefreshToken;
            }
        }
    }
}
