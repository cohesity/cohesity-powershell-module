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
        public bool RefreshToken = false;
        public string TenantID = null;
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
        public bool IsRefreshToken
        {
            get
            {
                return this.__config.RefreshToken;
            }
        }
        public bool IsTenantConfigured
        {
            get
            {
                return (null == this.__config.TenantID) ? false : true;
            }
        }
        public string GetTenantID()
        {
            return this.__config.TenantID;
        }
    }
}
