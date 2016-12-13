using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GMusicProxyGui
{
    public static class ConfigController
    {
        private static XmlDataStore.XmlDataStore dataStore = null;
        public static XmlDataStore.XmlDataStore DataStore
        {
            get
            {
                if (dataStore == null)
                    dataStore = new XmlDataStore.XmlDataStore(Path.Combine(Application.StartupPath, "config.xml"), "GMusicProxyGui");
                return dataStore;
            }
        }

        public static string MusicPath
        {
            get
            {
                return DataStore.GetString("musicPath");
            }
            set
            {
                DataStore.SetString("musicPath", value);
            }
        }

        public static string ProxyUrl
        {
            get
            {
                return DataStore.GetString("proxyUrl");
            }
            set
            {
                DataStore.SetString("proxyUrl", value);
            }
        }

        public static int ResultCount
        {
            get
            {
                return DataStore.GetInt("resultCount");
            }
            set
            {
                DataStore.SetInt("resultCount", value);
            }
        }

        public static bool IgnoreErrors
        {
            get
            {
                return DataStore.GetBool("ignoreErrors");
            }
            set
            {
                DataStore.SetBool("ignoreErrors", value);
            }
        }

        public static void ToDefault()
        {
            MusicPath = Path.Combine(Application.StartupPath, "music");
            ProxyUrl = "http://localhost:9999/";
            ResultCount = 20;
            IgnoreErrors = false;
        }

        public static bool CheckFirstStartup()
        {
            if (string.IsNullOrEmpty(MusicPath))
            {
                ToDefault();
                return true;
            }
            return false;
        }
    }
}
