using System;
using System.Windows.Forms;
using System.Threading;
using ErrorLogger = PlantMonitorV2.LL.ErrorLogger;
using NetConfig = PlantMonitorV2.DAL.NetConfig;
using NetFunc = PlantMonitorV2.LL.NetFunc;
using INIConfig = PlantMonitorV2.DAL.INIConfig;

namespace PlantMonitorV2
{
    public partial class NetConfigForm : Form
    {
        private NetConfig netCfgForm;
        private ErrorLogger errLog;
        private string InnerException = null;

        public NetConfigForm()
        {
            netCfgForm = new NetConfig();
            errLog = new ErrorLogger();
            InitializeComponent();
        }

        private void netConfBtn_Click(object sender, EventArgs e)
        {
            bool IsProper = false;
            string ipAddr = ipAddrTbx.Text;
            string portStr = portTbx.Text;

            try
            {
                NetFunc netFunc = new NetFunc(netCfgForm);
                if (netFunc.IsIpV4AddressValid(ipAddr)) 
                {
                    IsProper = true;
                }
                else
                {
                    MessageBox.Show("Podano zły adres IP!",
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ipAddrTbx.Clear();
                    IsProper = false;
                }

                if (IsProper)
                {
                    try
                    {
                        int port = Convert.ToInt32(portStr);
                        if (netFunc.IsNetworkPortValid(port))
                        {
                            netCfgForm.IpAddr = ipAddr;
                            netCfgForm.Port = port;
                            if (!netFunc.UdpThreadRecv.IsAlive)
                            {
                                netFunc.UdpThreadRecv = new Thread(new ThreadStart(netFunc.UDP_Listener));
                                netFunc.UdpThreadRecv.Start();
                            }
                            else
                            {
                                netFunc.UdpThreadRecv.Abort();
                                netFunc.UdpThreadRecv = new Thread(new ThreadStart(netFunc.UDP_Listener));
                                netFunc.UdpThreadRecv.Start();
                            }

                            INIConfig iniCfg = new INIConfig();
                            iniCfg.SetNetworkConfig(netCfgForm);
                            Close();
                        }
                        else
                        {
                            IsProper = false;
                            MessageBox.Show("Numer portu z poza puli liczbowej! Wpisz liczbę od 0 do 65535",
                                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            portTbx.Clear();
                        }
                    }
                    catch (FormatException)
                    {
                        IsProper = false;
                        MessageBox.Show("Nie określono portu lub port jest literą! Wpisz liczbę od 0 do 65535", 
                            "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        portTbx.Clear();
                    }
                }
            }
            catch (Exception err)
            {
                if (err.InnerException == null)
                {
                    InnerException = "None";
                    errLog.SaveLogToTxt(err.StackTrace, err.Message, InnerException);
                }
                else errLog.SaveLogToTxt(err.StackTrace, err.Message, err.InnerException.ToString());
            }
        }
    }
}
