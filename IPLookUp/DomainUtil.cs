using System.Collections.Generic;
using System.Net;

namespace IPLookUp
{
    public static class DomainUtil
    {
        public static IPAddress[] queryIP(string domain)
        {
            try
            {
                return Dns.GetHostAddresses(domain);
            }
            catch
            {
                return null;
            }
        }

        public static ISet<string> queryDomain(string ip)
        {
            IPAddress hostIPAddress = IPAddress.Parse(ip);
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(hostIPAddress);
                IPAddress[] resultAddress = hostEntry.AddressList;
                string[] resultAlias = hostEntry.Aliases;

                ISet<string> ret = new HashSet<string>();
                ret.Add(hostEntry.HostName);

                foreach (string alias in resultAlias)
                {
                    ret.Add(alias);
                }
                foreach (IPAddress address in resultAddress)
                {
                    ret.Add(address.ToString());
                }
                return ret;
            }
            catch
            {
                return null;
            }
        }
    }
}