using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace PlantMonitorV2.DAL
{
    class INIConfig
    {
        private string configPath = null;
        private string exeAssemblyDir = null;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        /// <summary>
        /// INIFile Constructor.
        /// </summary>
        public INIConfig()
        {
            try
            {
                exeAssemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                configPath = Path.Combine(exeAssemblyDir, "configApp.ini");
                int length = configPath.Length;
                configPath = configPath.Substring(6, length - 6); //cut "file:\\" from string
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while opening the configuration file. Verify error message. \n\r" + err.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Write Data to the INI File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// Section name
        /// <PARAM name="Key"></PARAM>
        /// Key Name
        /// <PARAM name="Value"></PARAM>
        /// Value Name
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.configPath);
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <PARAM name="Path"></PARAM>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, this.configPath);
            return temp.ToString();

        }

        public LampConfig GetLampConfig()
        {
            LampConfig lampTempCfg = new LampConfig();

            lampTempCfg.TimeOff = Convert.ToByte(IniReadValue("LampConfig", "timeOff"));
            lampTempCfg.TimeOn = Convert.ToByte(IniReadValue("LampConfig", "timeOn"));
            lampTempCfg.State = Convert.ToByte(IniReadValue("LampConfig", "state"));

            return lampTempCfg;
        }

        public void SetLampConfig(LampConfig xLampCfg)
        {
            IniWriteValue("LampConfig", "state", xLampCfg.State.ToString());
            IniWriteValue("LampConfig", "timeOff", xLampCfg.TimeOff.ToString());
            IniWriteValue("LampConfig", "timeOn", xLampCfg.TimeOn.ToString());
        }

        public TempConfig GetTempConfig()
        {
            TempConfig tempCfg = new TempConfig();

            tempCfg.TempValue = Convert.ToByte(IniReadValue("TempConfig", "temp"));
            tempCfg.Mode = Convert.ToByte(IniReadValue("TempConfig", "state"));

            return tempCfg;
        }

        public void SetTempConfig(TempConfig xTempCfg)
        {
            IniWriteValue("TempConfig", "state", xTempCfg.Mode.ToString());
            IniWriteValue("TempConfig", "temp", xTempCfg.TempValue.ToString());
        }

        public IrrConfig GetIrrigationConfig()
        {
            IrrConfig irrCfg = new IrrConfig();
       
            irrCfg.Mode = Convert.ToByte(IniReadValue("IrrConfig", "mode"));
            irrCfg.Freq = Convert.ToByte(IniReadValue("IrrConfig", "freq"));
            irrCfg.Number = Convert.ToUInt32(IniReadValue("IrrConfig", "number"));

            return irrCfg;
        }

        public void SetIrrigationConfig(IrrConfig xIrrCfg)
        {
            IniWriteValue("IrrConfig", "mode", xIrrCfg.Mode.ToString());
            IniWriteValue("IrrConfig", "freq", xIrrCfg.Freq.ToString());
            IniWriteValue("IrrConfig", "number", xIrrCfg.Number.ToString());
        }

        public NetConfig GetNetworkConfig()
        {
            NetConfig netCfg = new NetConfig();
            netCfg.IpAddr = IniReadValue("NetConfig", "ipaddr");
            netCfg.Port = Convert.ToInt32(IniReadValue("NetConfig", "port"));

            return netCfg;
        }

        public void SetNetworkConfig(NetConfig xNetCfg)
        {
            IniWriteValue("NetConfig", "ipaddr", xNetCfg.IpAddr);
            IniWriteValue("NetConfig", "port", xNetCfg.Port.ToString());
        }
    }
}
