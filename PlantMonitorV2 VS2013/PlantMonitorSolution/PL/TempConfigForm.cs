using System;
using System.Text;
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
                if (AutoTempControl_rbtn.Checked == true)
                {
                    tempCfg.Mode = 2;
                    byte tempByte = Convert.ToByte(Temperature_tbx.Text);
                    if (tempByte > 20 && tempByte < 33)
                    {
                        tempCfg.TempValue = tempByte;

                        string tempValueStr  = tempCfg.TempValue.ToString();

                        string commandStr = "";
                        commandStr = "STA" + " " + "ST" + " " + tempValueStr + " " + "END";

                        byte[] cmdSetTemperature = Encoding.ASCII.GetBytes(commandStr);

                        NetFunc netFunctional = new NetFunc(netConfiguration);
                        netFunctional.UDP_Sender(cmdSetTemperature);
                        netFunctional = null;
                        INIConfig iniCfg = new INIConfig();
                        iniCfg.SetTempConfig(tempCfg);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Podano złą temperaturę. Zakres regulacji temperatury od 20 do 33°C",
                            "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Temperature_tbx.Clear();
                    }
                }
                else if (ManualTempControl_rbtn.Checked == true)
                {
                    int fanPull = trackBar1.Value;
                    int fanPush = trackBar2.Value;

                    tempCfg.Mode = 1;
                    tempCfg.FanPull = Convert.ToByte(fanPull);
                    tempCfg.FanPush = Convert.ToByte(fanPush);

                    string commandStr = "";
                    commandStr = "STA" + " " + "SF" + " " + fanPull + " " + fanPush + " " + "END";

                    byte[] cmdSetTemperature = Encoding.ASCII.GetBytes(commandStr);

                    NetFunc netFunctional = new NetFunc(netConfiguration);
                    netFunctional.UDP_Sender(cmdSetTemperature);
                    netFunctional = null;
                    INIConfig iniCfg = new INIConfig();
                    iniCfg.SetTempConfig(tempCfg);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie zaznaczono żadnej opcji sterowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Temperature_tbx.Clear();
                    this.Close();
                }
            }
            catch (FormatException)
            {
                Temperature_tbx.Clear();
                MessageBox.Show("Nie podano temperatury lub temperatura jest literą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void AutoTempControl_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoTempControl_rbtn.Checked == false)
            {
                trackBar1.Enabled = true;
                trackBar2.Enabled = true;
            }
            else
            {
                trackBar1.Enabled = false;
                trackBar2.Enabled = false;
            }
        }

        private void ManualTempControl_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ManualTempControl_rbtn.Checked == false)
            {
                Temperature_tbx.Enabled = true;
            }
            else
            {
                Temperature_tbx.Enabled = false;
            }
        }
    }
}