using System;
using System.Net.Sockets;
using System.Threading;
using NetConfig = PlantMonitorV2.DAL.NetConfig;
using System.Text.RegularExpressions;
using System.Net;

namespace PlantMonitorV2.LL
{
    public class NetFunc
    {
        private static Byte[] ReceivedDataBytes;
        private static Thread udpListenerThread;
        private static UdpClient client;

        public Byte[] ReceivedData
        {
            get
            {
                return ReceivedDataBytes;
            }

            set
            {
                ReceivedDataBytes = value;
            }
        }

        public Thread UdpThreadRecv
        {
            get
            {
                return udpListenerThread;
            }

            set
            {
                udpListenerThread = value;
            }
        }

        public UdpClient udpServer
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        private readonly Regex validIpV4AddressRegex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$", RegexOptions.IgnoreCase);
        private NetConfig netCfg;
        private ErrorLogger errLog;

        public NetFunc(NetConfig netConfig)
        {
            netCfg = netConfig;
            errLog = new ErrorLogger();
        }

        public NetFunc(){}

        public bool IsIpV4AddressValid(string address)
        {
            if (!string.IsNullOrWhiteSpace(address))
            {
                return validIpV4AddressRegex.IsMatch(address.Trim());
            }

            return false;
        }

        public bool IsNetworkPortValid(int xPort)
        {
            bool IsProper = true;
            if (xPort < 0 && xPort > 65535)
            {
                IsProper = false;
            }

            return IsProper;
        }

        public void UDP_Sender(Byte[] xDataToSend)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(netCfg.IpAddr, netCfg.Port);

                udpClient.Send(xDataToSend, xDataToSend.Length);
                Thread.Sleep(100);
                udpClient.Close();
            }
            catch (Exception err)
            {
                if (err.InnerException == null)
                {
                    errLog.SaveLogToTxt(err.StackTrace, err.Message, "None");
                }
                else errLog.SaveLogToTxt(err.StackTrace, err.Message, err.InnerException.ToString());
            }
        }

        public void UDP_Listener()
        {
            try
            {
                client = new UdpClient(netCfg.Port);
            }
            catch (Exception err)
            {
                if (err.InnerException == null)
                {
                    errLog.SaveLogToTxt(err.StackTrace, err.Message, "None");
                }
                else errLog.SaveLogToTxt(err.StackTrace, err.Message, err.InnerException.ToString());

                udpListenerThread.Abort();
            }

            while (true)
            {
                try
                {
                    IPEndPoint remoteIp = new IPEndPoint(IPAddress.Parse(netCfg.IpAddr), netCfg.Port);
                    ReceivedDataBytes = client.Receive(ref remoteIp);
                    ReceivedData = ReceivedDataBytes;
                }
                catch (Exception err)
                {
                    if (err.InnerException == null)
                    {
                        errLog.SaveLogToTxt(err.StackTrace, err.Message, "None");
                    }
                    else errLog.SaveLogToTxt(err.StackTrace, err.Message, err.InnerException.ToString());
                }
                finally
                {
                    //
                }
            }

            //    }
            //    else
            //    {
            //        dispData.ReceivedDataList.Add("Adres IP urządzenia nie został skonfigurowany lub podano błędy adres!");
            //        DataReceivedDelegate(dispData.ReceivedDataList);
            //    }
            //}
            //else
            //{
            //    dispData.ReceivedDataList.Add("Port UDP nie został skonfigurowany lub podano błędny port!");
            //    DataReceivedDelegate(dispData.ReceivedDataList);
            //}
        }
    }
}
