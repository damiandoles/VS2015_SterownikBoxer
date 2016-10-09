using System;
using System.Windows.Forms;
using IrrConfig = PlantMonitorV2.DAL.IrrConfig;
using NetFunc = PlantMonitorV2.LL.NetFunc;
using NetConfig = PlantMonitorV2.DAL.NetConfig;
using INIConfig = PlantMonitorV2.DAL.INIConfig;

namespace PlantMonitorV2
{
    public partial class Irrigation : Form
    {
        private byte autoTimeMode = 1;
        private byte autoSoilHumidityMode = 2;
        private byte manualMode = 3;
        private byte FreqByte;
        private string WaterStr = null;
        private int WaterInt;
        private byte WaterByte;
        private bool acceptParameters = true;
        private IrrConfig irrigationConfig = new IrrConfig();
        private NetConfig netConfiguration;

        public Irrigation(NetConfig netCfg)
        {
            netConfiguration = netCfg;
            InitializeComponent();
        }

        private void Irrigation_btn_Click(object sender, EventArgs e)
        {
            if (TimeMode_rbtn.Checked == true) //auto czasowe
            {
                irrigationConfig.Mode = autoTimeMode;
                try
                {
                    FreqByte = Convert.ToByte(Freq_tbx.Text);

                    if (FreqByte < 1)
                    {
                        MessageBox.Show("Podano złą wartość częstotliwości podlewania. Minimalna częstotliwość to 1 raz na dobę.",
                            "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        acceptParameters = true;
                        irrigationConfig.Freq = FreqByte;
                    }
                }
                catch (FormatException)
                {
                    acceptParameters = false;
                    MessageBox.Show("Nie podano częstotliwości podlewania lub częstotliwośc podlewania nie jest cyfrą.", 
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    acceptParameters = false;
                    MessageBox.Show("Podano złą wartość częstotliwości podlewania. Minimalna częstotliwość to 1 raz na dobę.", 
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(SoilMode_rbtn.Checked == true) //auto względem wilgotności gleby
            {
                irrigationConfig.Mode = autoSoilHumidityMode;
                acceptParameters = true;
            }
            else if(ManualMode_rbtn.Checked == true)
            {
                irrigationConfig.Mode = manualMode;
                acceptParameters = true;
            }
            else if(TimeMode_rbtn.Checked == false && SoilMode_rbtn.Checked == false && ManualMode_rbtn.Checked == false)
            {
                acceptParameters = false;
                MessageBox.Show("Nie wybrałeś żadnego trybu nawadniania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                WaterStr = IrrigationWater_tbx.Text;
                WaterInt = Convert.ToInt32(WaterStr);

                if (WaterInt < 50 && WaterInt >= 2500)
                {
                    acceptParameters = false;
                    MessageBox.Show("Podano złą wartość ilości wody. Podaj liczbę w mililitrach od 50 do 2500.",
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    acceptParameters = true;
                    WaterByte = (byte)(WaterInt / 10); //scaled last zero, for example 2500ml / 10 = 250ml - byte range
                    irrigationConfig.Number = (uint)WaterByte;
                }
            }
            catch (FormatException)
            {
                acceptParameters = false;
                MessageBox.Show("Nie podano ilości wody lub ilośc wody nie jest cyfrą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                acceptParameters = false;
                MessageBox.Show("Podano złą wartość ilości wody. Podaj liczbę w mililitrach od 50 do 2500.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (acceptParameters == true)
            {
                Byte[] cmdIrrigation = new byte[11];

                cmdIrrigation[0] = 83; //S
                cmdIrrigation[1] = 84; //T
                cmdIrrigation[2] = 65; //A
                cmdIrrigation[3] = 83; //S
                cmdIrrigation[4] = 73; //I - irrigation
                cmdIrrigation[5] = irrigationConfig.Mode;
                cmdIrrigation[6] = irrigationConfig.Freq;
                cmdIrrigation[7] = (byte)irrigationConfig.Number;
                cmdIrrigation[8] = 69;  //E
                cmdIrrigation[9] = 78;  //N
                cmdIrrigation[10] = 68; //D

                NetFunc netFunctional = new NetFunc(netConfiguration);
                netFunctional.UDP_Sender(cmdIrrigation);
                netFunctional = null;
                INIConfig iniCfg = new INIConfig();
                iniCfg.SetIrrigationConfig(irrigationConfig);
            }

            this.Close();
        }

        private void AutoTime_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Freq_tbx.Enabled = true;
        }

        private void AutoSoil_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Freq_tbx.Enabled = false;
        }

        private void Manual_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Freq_tbx.Enabled = false;
        }
    }
}
