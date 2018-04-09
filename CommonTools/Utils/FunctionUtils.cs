using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace CommonTools.Utils
{
    public static class FunctionUtils
    {
        /*
         * ping IP是否成功
         */
        public static bool Ping(string IP)
        {
            Ping pingSender = new Ping();
            int timeout = 2000;
            PingReply pingReply = null; 
            try
            {
                pingReply = pingSender.Send(IP, timeout);
            }
            catch(Exception ex)
            {
                return false;
            }
            return pingReply.Status == IPStatus.Success;
        }

        /*
         * ping IP是否成功
         */
        public static bool PingIcmp(string IP)
        {
            Ping pingSender = new Ping();
            int timeout = 2000;
            PingReply pingReply = null;
            try
            {
                pingReply = pingSender.Send(IP, timeout);
            }
            catch (Exception ex)
            {
                return false;
            }
            return pingReply.Status == IPStatus.Success;
        }
    }
}
