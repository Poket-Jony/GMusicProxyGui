using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;

namespace GMusicProxyGui
{
    public class WebController
    {
        private string url;

        public WebController(string url)
        {
            this.url = url;
        }

        public string RequestString(string request, Dictionary<string, string> parameters)
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string req = Uri.EscapeUriString(url + request + BuildGetUrl(parameters));
                Console.WriteLine(req);
                return client.DownloadString(req);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task RequestFile(string fileName)
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                Console.WriteLine(Uri.EscapeUriString(url));
                await client.DownloadFileTaskAsync(new Uri(Uri.EscapeUriString(url)), fileName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*public async void RequestFile(string request, Dictionary<string, string> parameters, string fileName)
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                await client.DownloadFileTaskAsync(new Uri(Uri.EscapeUriString(url + request + BuildGetUrl(parameters))), fileName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }*/

        private string BuildGetUrl(Dictionary<string, string> parameters)
        {
            string output = "?";
            foreach(KeyValuePair<string, string> param in parameters)
            {
                output += string.Format("{0}={1}&", param.Key, param.Value);
            }
            output = output.Remove(output.Length - 1);
            return output;
        }
    }
}
