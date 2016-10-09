using System;
using System.Windows.Forms;
using LampConfig = PlantMonitorV2.DAL.LampConfig;
using NetFunc = PlantMonitorV2.LL.NetFunc;
using NetConfig = PlantMonitorV2.DAL.NetConfig;
using INIConfig = PlantMonitorV2.DAL.INIConfig;

namespace PlantMonitorV2
{
    public partial class LightControl : Form
    {
        private LampConfig lampConfiguration = new LampConfig();
        private NetConfig netConfiguration;

        enum LampState
        {
            STATE_OFF = 1,
            STATE_ON = 2
        }

        public LightControl(NetConfig netCfg)
        {
            netConfiguration = netCfg;
            InitializeComponent();
        }

        private void SetLightControlSettings_btn_Click(object sender, EventArgs e)
        {
            byte timeON = CheckAndConvertSetTime(TimeON_tbx.Text, "świecenia lampy");
            byte timeOFF = CheckAndConvertSetTime(TimeOFF_tbx.Text, "wyłączenia lampy");

            if (timeON + timeOFF == 24)
            {
                if (TurnOffState.Checked)
                {
                    lampConfiguration.State = 1; //off
                    lampConfiguration.TimeOn = timeON;
                    lampConfiguration.TimeOff = timeOFF;

                    byte[] cmdSetTemperature = new byte[11];
                    cmdSetTemperature[0] = 83; //S
                    cmdSetTemperature[1] = 84; //T
                    cmdSetTemperature[2] = 65; //A
                    cmdSetTemperature[3] = 83; //S - Set
                    cmdSetTemperature[4] = 76; //L - Lamp
                    cmdSetTemperature[5] = lampConfiguration.TimeOn;
                    cmdSetTemperature[6] = lampConfiguration.TimeOff;
                    cmdSetTemperature[7] = lampConfiguration.State;
                    cmdSetTemperature[8] = 69; //E
                    cmdSetTemperature[9] = 78; //N
                    cmdSetTemperature[10] = 68; //D

                    NetFunc netFunctional = new NetFunc(netConfiguration);
                    netFunctional.UDP_Sender(cmdSetTemperature);
                    netFunctional = null;
                    INIConfig iniCfg = new INIConfig();
                    iniCfg.SetLampConfig(lampConfiguration);
                    this.Close();
                }
                else if (TurnOnState.Checked)
                {
                    lampConfiguration.State = 2; //on
                    lampConfiguration.TimeOn = timeON;
                    lampConfiguration.TimeOff = timeOFF;

                    //string command = "STA BOXER SET LAMP " + timeON + " " + timeOFF + " " + MForm.NewLightState + " END";

                    byte[] cmdSetTemperature = new byte[11];
                    cmdSetTemperature[0] = 83; //S
                    cmdSetTemperature[1] = 84; //T
                    cmdSetTemperature[2] = 65; //A
                    cmdSetTemperature[3] = 83; //S - Set
                    cmdSetTemperature[4] = 76; //L - Lamp
                    cmdSetTemperature[5] = lampConfiguration.TimeOn;
                    cmdSetTemperature[6] = lampConfiguration.TimeOff;
                    cmdSetTemperature[7] = lampConfiguration.State;
                    cmdSetTemperature[8] = 69; //E
                    cmdSetTemperature[9] = 78; //N
                    cmdSetTemperature[10] = 68; //D

                    NetFunc netFunctional = new NetFunc(netConfiguration);
                    netFunctional.UDP_Sender(cmdSetTemperature);
                    this.Close();
                }
                else if (!TurnOnState.Checked && !TurnOffState.Checked)
                {
                    MessageBox.Show("Określ początkowy stan oświetlenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Podano złą liczbę czasów. Suma czasów musi być równa 24 (cykl dobowy)", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte CheckAndConvertSetTime(string time, string KindOfTime)
        {
            byte timeByte = 0;
            try
            {
                timeByte = Convert.ToByte(time);
                if (timeByte < 0 || timeByte > 24)
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nie podano czasu " + KindOfTime + " lub czas " + KindOfTime +" jest literą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Podano złą liczbę godzin czasu " + KindOfTime, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return timeByte;
        }
    }
}
