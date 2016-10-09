//using NetFunc = PlantMonitorV2.LL.NetFunc;
using NetConfig = PlantMonitorV2.DAL.NetConfig;

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

            byte[] cmdCalibratePh = new byte[9];
            cmdCalibratePh[0] = 83; //S
            cmdCalibratePh[1] = 84; //T
            cmdCalibratePh[2] = 65; //A
            cmdCalibratePh[3] = 67; //C - Calibrate
            cmdCalibratePh[4] = 80; //P - Temperature
            cmdCalibratePh[5] = KindOfProbe;
            cmdCalibratePh[6] = 69; //E
            cmdCalibratePh[7] = 78; //N
            cmdCalibratePh[8] = 68; //D

            NetFunc netFunctional = new NetFunc(netCfg);
            netFunctional.UDP_Sender(cmdCalibratePh);
        }

        public void CalibrateWaterProbe(NetConfig netCfg)
        {
            StartCalibrationCMD = 2;
            KindOfProbe = 2;
            // TODO proces kalibracji sond pH - wyslanie odpowiedzi sondy wody

            byte[] cmdCalibratePh = new byte[9];
            cmdCalibratePh[0] = 83; //S
            cmdCalibratePh[1] = 84; //T
            cmdCalibratePh[2] = 65; //A
            cmdCalibratePh[3] = 67; //C - Calibrate
            cmdCalibratePh[4] = 80; //P - Temperature
            cmdCalibratePh[5] = KindOfProbe;
            cmdCalibratePh[6] = 69; //E
            cmdCalibratePh[7] = 78; //N
            cmdCalibratePh[8] = 68; //D

            NetFunc netFunctional = new NetFunc(netCfg);
            netFunctional.UDP_Sender(cmdCalibratePh);
        }
    }
}
