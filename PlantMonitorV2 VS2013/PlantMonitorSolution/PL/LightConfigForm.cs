using System;
using System.Windows.Forms;
using System.Text;
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

        public byte[] CombineByteArrays(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
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

                    string timeOnStr = lampConfiguration.TimeOn.ToString(); 
                    string timeOffStr = lampConfiguration.TimeOff.ToString();

                    string commandStr = "";
                    if (lampConfiguration.State == 1)
                    {
                        commandStr = "STA" + " " + "SL" + " " + timeOnStr + " " + timeOffStr + " " + "R" + " " + "END";
                    }
                    else if (lampConfiguration.State == 2)
                    {
                        commandStr = "STA" + " " + "SL" + " " + timeOnStr + " " + timeOffStr + " " + "S" + " " + "END";
                    }
                    else 
                    {
                        commandStr = "STA" + " " + "SL" + " " + "END";
                    }

                    byte[] commandByteArray = Encoding.ASCII.GetBytes(commandStr);

                    NetFunc netFunctional = new NetFunc(netConfiguration);
                    netFunctional.UDP_Sender(commandByteArray);
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

                    string timeOnStr = lampConfiguration.TimeOn.ToString();
                    string timeOffStr = lampConfiguration.TimeOff.ToString();

                    string commandStr = "";
                    if (lampConfiguration.State == 1)
                    {
                        commandStr = "STA" + " " + "SL" + " " + timeOnStr + " " + timeOffStr + " " + "R" + " " + "END";
                    }
                    else if (lampConfiguration.State == 2)
                    {
                        commandStr = "STA" + " " + "SL" + " " + timeOnStr + " " + timeOffStr + " " + "S" + " " + "END";
                    }
                    else
                    {
                        commandStr = "STA" + " " + "SL" + " " + "END";
                    }

                    byte[] commandByteArray = Encoding.ASCII.GetBytes(commandStr);

                    NetFunc netFunctional = new NetFunc(netConfiguration);
                    netFunctional.UDP_Sender(commandByteArray);
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
