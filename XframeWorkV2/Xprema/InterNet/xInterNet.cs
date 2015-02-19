using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Xprema.xInterNet
{
   public  class xInterNet
    {

        public static string LocalIPAddress()
        {
            string x;
            x = Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(f =>
                  f.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
            return x.ToString();
        }

        public static bool CheckConnect()
        {
            bool xStatus = false;
            xStatus = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (xStatus == true) { xStatus = true; } else { xStatus = false; } return xStatus;


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">WebSite Url</param>
        /// <param name="filename">Your File Name</param>
        /// <returns></returns>
        public static List<string> DownloadTheFile(string url, string filename)
        {
            List<string> Lst = new List<string>();
            Lst.Clear();
            System.Net.WebClient webClient = new System.Net.WebClient();

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile(url, filename);
            sw.Stop();
            FileInfo fileInfo = new FileInfo(filename);
            long speed = fileInfo.Length / sw.Elapsed.Seconds;

            Lst.Add("Download duration: {0}" + sw.Elapsed);
            Lst.Add("File size: {0}" + fileInfo.Length.ToString("N0"));
            Lst.Add("Speed: {0} bps " + speed.ToString("N0"));

            return Lst;

        }


    }
}
