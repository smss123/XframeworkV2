using System;
using System.Collections.Generic;
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
    }
}
