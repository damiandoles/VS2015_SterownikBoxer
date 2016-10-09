using System;
using System.Windows.Forms;
using TempConfig = PlantMonitorV2.DAL.TempConfig;
using NetFunc = PlantMonitorV2.LL.NetFunc;
using NetConfig = PlantMonitorV2.DAL.NetConfig;
using INIConfig = PlantMonitorV2.DAL.INIConfig;

namespace PlantMonitorV2
{
    public partial class TempControl : Form
    {
        private TempConfig tempCfg = new TempConfig();
        private NetConfig netConfiguration;

        public TempControl(NetConfig netCfg)
        {
            netConfiguration = netCfg;
            InitializeComponent();
        }

        private void SetTemperature_btn_Click(object sender, EventArgs e)
        {
            try
            {
                byte tempByte = Convert.ToByte(Temperature_tbx.Text);
                if (TurnOFFTempControlling_rbtn.Enabled == true)
                {
                    if (tempByte > 20)
                    {
                        tempCfg.Mode = 0;
                        tempCfg.TempValue = tempByte;

                        byte[] cmdSetTemperature = new byte[10];
                        cmdSetTemperature[0] = 83; //S
                        cmdSetTemperature[1] = 84; //T
                        cmdSetTemperature[2] = 65; //A
                        cmdSetTemperature[3] = 83; //S - Set
                        cmdSetTemperature[4] = 84; //T - Temperature
                        cmdSetTemperature[5] = tempCfg.TempValue;
                        cmdSetTemperature[6] = tempCfg.Mode;
                        cmdSetTemperature[7] = 69; //E
                        cmdSetTemperature[8] = 78; //N
                        cmdSetTemperature[9] = 68; //D

                        NetFunc netFunctional = new NetFunc(netConfiguration);
                        netFunctional.UDP_Sender(cmdSetTemperature);
                        netFunctional = null;
                        INIConfig iniCfg = new INIConfig();
                        iniCfg.SetTempConfig(tempCfg);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Podano złą temperaturę. Dla tego trybu minimalna temperatura to 20°C.",
                            "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Temperature_tbx.Clear();
                    }
                }
                else
                {
                    if (tempByte <= 15 && tempByte >= 45)
                    {
                        MessageBox.Show("Podano złą temperaturę. Zakres temperatury dla tego trybu w przedziale od 15°C do 45°C.", 
                            "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Temperature_tbx.Clear();
                    }
                    else
                    {
                        tempCfg.Mode = 1;
                        tempCfg.TempValue = tempByte;

                        byte[] cmdSetTemperature = new byte[10];
                        cmdSetTemperature[0] = 83; //S
                        cmdSetTemperature[1] = 84; //T
                        cmdSetTemperature[2] = 65; //A
                        cmdSetTemperature[3] = 83; //S - Set
                        cmdSetTemperature[4] = 84; //T - Temperature
                        cmdSetTemperature[5] = tempCfg.TempValue;
                        cmdSetTemperature[6] = tempCfg.Mode;
                        cmdSetTemperature[7] = 69; //E
                        cmdSetTemperature[8] = 78; //N
                        cmdSetTemperature[9] = 68; //D

                        NetFunc netFunctional = new NetFunc(netConfiguration);
                        netFunctional.UDP_Sender(cmdSetTemperature);
                        netFunctional = null;
                        INIConfig iniCfg = new INIConfig();
                        iniCfg.SetTempConfig(tempCfg);
                        this.Close();
                    }
                }
            }
            catch (FormatException)
            {
                Temperature_tbx.Clear();
                MessageBox.Show("Nie podano temperatury lub temperatura jest literą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}