using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using GMusicProxyGui.Controller;

namespace GMusicProxyGui.Model
{
    public class PlaylistEntryModel
    {
        public PlaylistEntryModel(string title, string proxyPath)
        {
            Title = title;
            ProxyPath = proxyPath;
            UpdateIdFromProxyPath();
        }

        public string Title { get; set; }
        public string ProxyPath { get; set; }
        public string ProxyId { get; set; }

        private void UpdateIdFromProxyPath()
        {
            Regex regex = new Regex(@".*id=(.*)");
            if (regex.IsMatch(ProxyPath))
            {
                ProxyId = regex.Match(ProxyPath).Groups[1].Value;
            }
        }

        public static List<PlaylistEntryModel> GetPlaylistEntrysByText(string textString)
        {
            if (string.IsNullOrEmpty(textString))
                return null;

            List<PlaylistEntryModel> entries = new List<PlaylistEntryModel>();
            using (StringReader reader = new StringReader(textString))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                        continue;
                    string[] split = line.Split('|');
                    
                    if (split != null && split.Length != 0)
                    {
                        string title = split[0];
                        string proxyPath = split[1];
                        entries.Add(new PlaylistEntryModel(title, proxyPath));
                    }
                    else
                        throw new Exception("Unexpected entry detected.");
                }
            }
            return entries;
        }

        public override string ToString()
        {
            return ProxyId;
        }
    }
}
