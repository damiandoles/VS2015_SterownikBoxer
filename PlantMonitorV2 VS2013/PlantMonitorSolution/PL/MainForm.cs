﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using TempConfig = PlantMonitorV2.DAL.TempConfig;
using INIConfig = PlantMonitorV2.DAL.INIConfig;
using ErrorLogger = PlantMonitorV2.LL.ErrorLogger;
using NetFunc = PlantMonitorV2.LL.NetFunc;
using NetConfig = PlantMonitorV2.DAL.NetConfig;
using CalibrationPh = PlantMonitorV2.LL.CalibrationPh;
using IrrConfig = PlantMonitorV2.DAL.IrrConfig;
using DisplayData = PlantMonitorV2.LL.DisplayData;
using LampConfig = PlantMonitorV2.DAL.LampConfig;

namespace PlantMonitorV2
{
    public partial class MainForm : Form
    {
        #region [ Variables and objects ]

        ErrorLogger errLog;
        NetConfig netConfiguration;
        NetFunc netFunctional;
        DisplayData dispDta;

        private bool programOK = true;

        #endregion

        #region [ Old Properties ]
      
        public byte Second { get; set; }

        public byte Minute { get; set; }

        public byte Hour { get; set; }

        public byte Day { get; set; }

        public byte Month { get; set; }

        #endregion

        #region [ Constructor ]

        public MainForm()
        {
            InitializeComponent();
            this.trayMenu.Visible = false;
            this.tray.Visible = false;
            this.Closing += new CancelEventHandler(this.AppClosing);

            INIConfig iniConf = new INIConfig();
            netConfiguration = iniConf.GetNetworkConfig();
            //netConfiguration.IpAddr = "255.255.255.255";
            //netConfiguration.Port = 48899;
            errLog = new ErrorLogger();
            netFunctional = new NetFunc(netConfiguration);
            dispDta = new DisplayData(receivedConsole_tbx);
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            //konfiguracja wstepna UDP
            netFunctional.UdpThreadRecv = new Thread(new ThreadStart(netFunctional.UDP_Listener));
            netFunctional.UdpThreadRecv.Start();
        }


        #region [ Buttons and tray events ]
        private void exit_btn_Click(object sender, EventArgs e)
        {           
            try
            {
                netFunctional.UdpThreadRecv.Abort();
                netFunctional.udpServer.Close();
            }
            catch (Exception) { }
            Thread.Sleep(100);
            Application.Exit();
            this.Dispose();
        }

        private void AppClosing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?",
                "Zamknięcie programu", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else
            {
                try
                {
                    netFunctional.UdpThreadRecv.Abort();
                    netFunctional.udpServer.Close();
                }
                catch (Exception){ }
                Thread.Sleep(100);
                Application.Exit();
                this.Dispose();
            }
        }

        private void tray_btn_Click(object sender, EventArgs e)
        {
            tray.Visible = true;
            tray.Text = "BOXER - Interfejs użytkownika";
            tray.Icon = this.Icon;
            tray.ContextMenuStrip = trayMenu;
            this.ShowInTaskbar = false;
            this.Visible = false;
        }
        #endregion

        #region [ Program menu - all logic ]
        private void ResetDevice(object sender, CancelEventArgs a)
        {
            if (MessageBox.Show("Czy na pewno chcesz zresetować sterownik?",
                "Reset sterownika", MessageBoxButtons.YesNo) == DialogResult.No)
                a.Cancel = true;
        }

        private void Temp_submenuitem_Click(object sender, EventArgs e)
        {
            TempControl TempForm = new TempControl(netConfiguration);
            TempForm.Show();
        }

        private void LightControl_submenuitem_Click(object sender, EventArgs e)
        {
            LightControl LightControlForm = new LightControl(netConfiguration);
            LightControlForm.Show();
        }

        private void ResetDevice_submenuitem_Click(object sender, EventArgs e)
        {
            if (programOK == true)
            {
                MessageBox.Show("Sterownik został zresetowany. Reset sterownika zasygnalizuje dźwięk.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO reset urzadzenia - komenda !
                string commandStr = "STA R END";
                byte[] commandByteArray = Encoding.ASCII.GetBytes(commandStr);
                netFunctional.UDP_Sender(commandByteArray);
            }
            else ShowError();
        }

        private void ShowError()
        {
            MessageBox.Show("Sterownik nie został podłączony. Podłącz sterownik. Po wciśnięciu przycisku OK aplikacja zamknie się.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            Application.Exit();
            this.Dispose();
        }

        private void ActualSettings_submenuitem_Click(object sender, EventArgs e)
        {
            string IpAddrInfo = null;
            string UdpPortInfo = null;
            INIConfig iniCfg = new INIConfig();
            TempConfig tempCfg = iniCfg.GetTempConfig();
            IrrConfig irrCfg = iniCfg.GetIrrigationConfig();
            LampConfig lampCfg = iniCfg.GetLampConfig();
            
            if (netConfiguration.IpAddr == "" || netConfiguration.IpAddr == null)
            {
                IpAddrInfo = "Brak/nieskonfigurowano";
            }
            else
            {
                IpAddrInfo = netConfiguration.IpAddr;
            }

            if (netConfiguration.Port == (-1))
            {
                UdpPortInfo = "Brak/nieskonfigurowano";
            }
            else
            {
                UdpPortInfo = netConfiguration.Port.ToString();
            }

            string lampState = null;
            if (lampCfg.State == 1)
            {
                lampState = "wyłączona";
            }
            else if (lampCfg.State == 2)
            {
                lampState = "włączona";
            }

            string fansString = null;
            fansString = "Wentylator wciągający powietrze: " + tempCfg.FanPull + "% mocy" + Environment.NewLine;
            fansString += "Wentylatory wyciągające powietrze: " + tempCfg.FanPush + "% mocy" + Environment.NewLine;

            string tempMode = null; 
            if (tempCfg.Mode == 1) //manual
            {
                tempMode = "manualny";

            }
            else if (tempCfg.Mode == 2) //auto
            {
                tempMode = "automatyczny (tryb max)";
            }

            MessageBox.Show("Ustawione parametry: " + Environment.NewLine + 
                "Lampa włączona: " + lampCfg.TimeOn + "h" + Environment.NewLine + 
                "Lampa wyłączona: " + lampCfg.TimeOff + "h" + Environment.NewLine +
                "Stan lampy: " + lampState + Environment.NewLine +
                "Tryb sterowania temperaturą powietrza: " + tempMode + Environment.NewLine +
                fansString + 
                "Temperatura powietrza (max): " + tempCfg.TempValue + "°C" + Environment.NewLine +
                "Adres IP: " + IpAddrInfo + Environment.NewLine +
                "Port nasłuchu UDP: " + UdpPortInfo, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Information_submenuitem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja wraz ze sterownikiem służy to monitorowania parametrów uprawy roślin w namiocie uprawowym. Wszelkie prawa autorskie zastrzeżone. Jakiekolwiek pytania proszę pisać na adres email: damiandoles@gmail.com", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Help_submenuitem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temperaturę maksymalną/otoczenia oraz czas włączenia/wyłączenia oświetlenia powinno się dostosować do wymagań danej rośliny." + Environment.NewLine + Environment.NewLine +
                "Domyślne parametry to: " + Environment.NewLine +
                "Lammpa załączona: 12h" + Environment.NewLine + 
                "Lampa wyłączona: 12h" + Environment.NewLine +
                "Stan lampy: wyłączona" + Environment.NewLine +
                "Tryb sterowania temperaturą: auto (temperatura maksymalna), Tmax = 25°C" + Environment.NewLine + Environment.NewLine + 
                "Domyślny adres IP: 192.168.0.10" + Environment.NewLine +
                "Pomyślne uruchomienie sterownika (również po resecie) sygnalizowane jest krótkim dźwiękiem." + Environment.NewLine + Environment.NewLine +
                "Po wybraniu opcji kalibracji dowolnej sondy użytkownik ma 15 sekund czasu aby umieścić sondę w odpowiednim buforze pH, zaczynając od bufora o najmniejszym pH. Czas ten sygnalizowany jest dźwiękami buzzera, następnie wykonywany jest pomiar napięcia referencyjnego dla zadanego wzorca pH, który trwa około 30s. Proces wyboru kolejnego bufora powtarza się (cykl 15s z ostrzeżeniem dźwiękowym i 30s pomiar). Nalezy pamiętać, aby przed przystąpieniem do kalibracji przygotować czystą wodę (najlepiej demineralizowaną) oraz chłonny papier. Po każdym pomiarze należy umyć sondę wodą i wytrzeć papierem.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowProgram_traymenu_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Visible = true;
            this.trayMenu.Visible = false;
            this.tray.Visible = false;
        }

        private void CloseProgram_traymenu_Click(object sender, EventArgs e)
        {            
            this.Close();
            this.Dispose();
        }

        private void SetDate_submenuitem_Click(object sender, EventArgs e)
        {
            if (programOK == true)
            {
                //UART_SendData(); // TODO wysylanie daty ?
                MessageBox.Show("Ustawiono datę w sterowniku.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else ShowError();
        }

        private void Irrigation_submenuitem_Click(object sender, EventArgs e)
        {
            Irrigation IrrigationForm = new Irrigation(netConfiguration);
            IrrigationForm.Show();
        }

        private void ustawieniaSiecioweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetConfigForm NetConfigurationForm = new NetConfigForm();
            NetConfigurationForm.Show();
        }

        private void CalibrateWaterpH_submenuitem_Click(object sender, EventArgs e)
        {
            if (programOK == true)
            {
                CalibrationPh calibProbePh = new CalibrationPh();
                calibProbePh.CalibrateWaterProbe(netConfiguration);
            }
            else ShowError();
        }

        private void CalibrateSoilpH_submenuitem_Click(object sender, EventArgs e)
        {
            if (programOK == true)
            {
                CalibrationPh calibProbePh = new CalibrationPh();
                calibProbePh.CalibrateSoilProbe(netConfiguration);
            }
            else ShowError();
        }

        #endregion

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string DiscoveryPassword = "sterownik1"; //sterownik1
            byte[] LogoDataBy = ASCIIEncoding.ASCII.GetBytes(DiscoveryPassword);

            // HF-A11SISTHREAD, port 44889
            //NetConfig netConfig = new NetConfig();
            //netConfig.IpAddr = "255.255.255.255";
            //netConfig.Port = 48899;
            //NetFunc NetInstance = new NetFunc(netConfig);
            //NetInstance.UDP_Sender(LogoDataBy);

            try
            {
                NetConfig netConfig = new NetConfig();
                netConfig.IpAddr = "255.255.255.255";// "192.168.0.255";
                netConfig.Port = 48899;
                NetFunc NetInstance = new NetFunc(netConfig);
                NetInstance.UdpThreadRecv = new Thread(new ThreadStart(NetInstance.UDP_Listener));
                NetInstance.UdpThreadRecv.Start();
                NetInstance.UDP_Sender(LogoDataBy);
            }
            catch (Exception)
            {

            }
        }

        private void przywrócUstawieniaDomyślneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string commandStr = "STA DEF SETT END";

            byte[] cmdSetTemperature = Encoding.ASCII.GetBytes(commandStr);

            NetFunc netFunctional = new NetFunc(netConfiguration);
            netFunctional.UDP_Sender(cmdSetTemperature);
            netFunctional = null;
        }
    }
}