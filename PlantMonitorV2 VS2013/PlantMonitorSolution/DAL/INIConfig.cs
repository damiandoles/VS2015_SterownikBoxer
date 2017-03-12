using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using IniParser;
using IniParser.Model;

namespace PlantMonitorV2.DAL
{
    class INIConfig
    {
        private string configPath = null;
        private string exeAssemblyDir = null;

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
            catch (Exception)
            {
                MessageBox.Show("Nie znaleziono pliku z ustawieniami!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var path = System.IO.Directory.GetCurrentDirectory();
                var pathWithFileName = System.IO.Path.Combine(path, "configApp.ini");
                System.IO.File.Create(pathWithFileName);
                string sections =

                "[TempConfig]" + Environment.NewLine +
                "mode = 0" + Environment.NewLine +
                "fanPull = 0" + Environment.NewLine +
                "fanPush = 0" + Environment.NewLine +
                "temp = 0" + Environment.NewLine + Environment.NewLine +

                "[LampConfig]" + Environment.NewLine +
                "timeOn = 0" + Environment.NewLine +
                "timeOff = 0" + Environment.NewLine +
                "state = 0" + Environment.NewLine + Environment.NewLine +

                "[IrrConfig]" + Environment.NewLine +
                "mode = 0" + Environment.NewLine +
                "freq = 0" + Environment.NewLine +
                "number = 0" + Environment.NewLine + Environment.NewLine +

                "[NetConfig]" + Environment.NewLine +
                "ipaddr = 0" + Environment.NewLine +
                "port = 0";

                System.IO.File.WriteAllText(pathWithFileName, sections);

                IniWriteValue("LampConfig", "state", "1");
                IniWriteValue("LampConfig", "timeOff", "12");
                IniWriteValue("LampConfig", "timeOn", "12");
                IniWriteValue("TempConfig", "mode", "2");
                IniWriteValue("TempConfig", "temp", "25");
                IniWriteValue("TempConfig", "fanPull", "40");
                IniWriteValue("TempConfig", "fanPush", "60");
                IniWriteValue("IrrConfig", "mode", "0");
                IniWriteValue("IrrConfig", "freq", "0");
                IniWriteValue("IrrConfig", "number", "0");
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
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(configPath);
                data[Section][Key] = Value;
                parser.WriteFile(configPath, data);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            string useFullScreenStr = null;
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(configPath);
                useFullScreenStr = data[Section][Key];
            }
            catch (Exception) { }

            return useFullScreenStr;
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

            tempCfg.FanPush = Convert.ToByte(IniReadValue("TempConfig", "fanPull"));
            tempCfg.FanPull = Convert.ToByte(IniReadValue("TempConfig", "fanPush"));
            tempCfg.TempValue = Convert.ToByte(IniReadValue("TempConfig", "temp"));
            tempCfg.Mode = Convert.ToByte(IniReadValue("TempConfig", "mode"));

            return tempCfg;
        }

        public void SetTempConfig(TempConfig xTempCfg)
        {
            IniWriteValue("TempConfig", "mode", xTempCfg.Mode.ToString());
            IniWriteValue("TempConfig", "temp", xTempCfg.TempValue.ToString());
            IniWriteValue("TempConfig", "fanPull", xTempCfg.FanPull.ToString());
            IniWriteValue("TempConfig", "fanPush", xTempCfg.FanPush.ToString());
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
