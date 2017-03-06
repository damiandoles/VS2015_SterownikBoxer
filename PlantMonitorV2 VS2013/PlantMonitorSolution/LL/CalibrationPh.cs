//using NetFunc = PlantMonitorV2.LL.NetFunc;
using NetConfig = PlantMonitorV2.DAL.NetConfig;
using System.Text;

namespace PlantMonitorV2.LL
{
    public class CalibrationPh
    {
        private byte calibrationCommand;
        private byte probeType;

        public byte StartCalibrationCMD
        {
            get
            {
                return calibrationCommand;
            }
            set
            {
                calibrationCommand = value;
            }
        }

        public byte KindOfProbe
        {
            get
            {
                return probeType;
            }
            set
            {
                probeType = value;
            }
        }

        public CalibrationPh() { }

        public void CalibrateSoilProbe(NetConfig netCfg)
        {
            StartCalibrationCMD = 1;
            KindOfProbe = 1;
            // TODO proces kalibracji sond pH - wyslanie odpowiedzi sondy gleby

            string commandStr = "STA CP " + KindOfProbe.ToString() + " END";
            byte[] commandByteArray = Encoding.ASCII.GetBytes(commandStr);

            NetFunc netFunctional = new NetFunc(netCfg);
            netFunctional.UDP_Sender(commandByteArray);
        }

        public void CalibrateWaterProbe(NetConfig netCfg)
        {
            StartCalibrationCMD = 2;
            KindOfProbe = 2;
            // TODO proces kalibracji sond pH - wyslanie odpowiedzi sondy gleby

            string commandStr = "STA CP " + KindOfProbe.ToString() + " END";
            byte[] commandByteArray = Encoding.ASCII.GetBytes(commandStr);

            NetFunc netFunctional = new NetFunc(netCfg);
            netFunctional.UDP_Sender(commandByteArray);
        }
    }
}
