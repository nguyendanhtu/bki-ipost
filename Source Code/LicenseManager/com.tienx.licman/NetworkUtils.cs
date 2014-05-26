using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace TienX.License
{
    class NetworkUtils
    {

        public static List<String> getAllMacAddr()
        {
            var macAddrList = new List<String>();
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in nics)
            {
                var macAddr = adapter.GetPhysicalAddress().ToString();
                if (adapter.Description.ToLower().Contains("virtual") || String.IsNullOrEmpty(macAddr))
                {
                    continue;
                }
                macAddrList.Add(macAddr);
            }
            return macAddrList;
        }

        public static String getMacAddr()
        {
            var macAddrList = new List<String>();
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in nics)
            {
                var macAddr = adapter.GetPhysicalAddress().ToString();
                if (adapter.Description.ToLower().Contains("virtual") || String.IsNullOrEmpty(macAddr))
                {
                    continue;
                }
                // only return MAC Address from first card  
                return macAddr;
            }
            return "NotFound";
        }

        public static byte[] getRequest(String url)
        {
            using (var client = new WebClient())
            {
                byte[] data = client.DownloadData(url);
                return data;
            }
        }
    }
}
