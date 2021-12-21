using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace IPLookUp
{
    public static class IPUtil
    {
        private const int MAX_ATTEMPT = 3;
        private static readonly Regex expressionIPv6 = new Regex(@"(?:^|(?<=\s))(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))(?=\s|$)");
        private static readonly Regex expressionMAC = new Regex("^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})|([0-9a-fA-F]{4}\\.[0-9a-fA-F]{4}\\.[0-9a-fA-F]{4})$");

        public static bool isIPv4(string ip)
        {
            string[] splitValue = ip.Split('.');
            if (splitValue.Length != 4)
            {
                return false;
            }
            byte parse;
            return splitValue.All(value => byte.TryParse(value, out parse));
        }

        public static bool matchRegex(Regex regex, string value)
        {
            return regex.Match(value).Success;
        }

        public static bool isIPv6(string ip)
        {
            return matchRegex(expressionIPv6, ip);
        }

        public static bool isIPAddress(string ip)
        {
            return isIPv4(ip) || isIPv6(ip);
        }

        public static string getFirstIPv4Address(IPAddress[] ip)
        {
            foreach (IPAddress data in ip)
            {
                if (data.AddressFamily == AddressFamily.InterNetwork)
                {
                    return data.ToString();
                }
            }
            return null;
        }

        public static string getPublicIPAddress(HttpClient client, out string errorMesssage, bool IPv4 = true)
        {
            string ret = null;
            errorMesssage = null;

            int attempt = 0;
            string url = IPv4 ? "https://ip4.seeip.org/" : "http://v6.ipv6-test.com/api/myip.php";
            while (ret == null && attempt < MAX_ATTEMPT)
            {
                ++attempt;
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.ConnectionClose = true;

                    string response = client.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
                    string candidatePublicIPAddress = response.Replace("\n", string.Empty);

                    if (!isIPAddress(candidatePublicIPAddress))
                    {
                        throw new Exception($"無效的回應格式 : {response}");
                    }
                    ret = candidatePublicIPAddress;
                }
                catch (Exception ex)
                {
                    if (attempt >= MAX_ATTEMPT)
                    {
                        errorMesssage = ex.Message;
                    }
                }
            }
            return ret;
        }

        public static bool isMACAddress(string mac)
        {
            return matchRegex(expressionMAC, mac);
        }
    }
}