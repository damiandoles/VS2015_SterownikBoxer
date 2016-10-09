using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace PlantMonitorV2.LL
{
    public delegate void DisplayDelegate(List<string> data);

    public class DisplayData
    {
        private DisplayDelegate displayDlg;
        private List<string> ReceivedDataList = new List<string>();
        private ErrorLogger errLog;
        private TextBox terminalTbx;
        private Timer timerDispParser = null;
        private NetFunc netFun;

        public DisplayData(TextBox xTerminalTbx)
        {
            terminalTbx = xTerminalTbx;
            InitializeDisplayTimer();
            errLog = new ErrorLogger();
        }

        private void InitializeDisplayTimer()
        {
            timerDispParser = new Timer();
            timerDispParser.Interval = 500;
            timerDispParser.Tick += DisplayTimerEvent;
            timerDispParser.Enabled = true;
            timerDispParser.Start();
        }

        private void DisplayTimerEvent(object sender, EventArgs e)
        {
            timerDispParser.Enabled = false;
            netFun = new NetFunc();
            RecvDataParser(netFun.ReceivedData);
            timerDispParser.Enabled = true;
        }

        public void ShowOnConsole(List<string> data)
        {
            if (terminalTbx.InvokeRequired)
            {
                displayDlg = new DisplayDelegate(ShowOnConsole);
                try
                {
                    terminalTbx.Invoke(displayDlg, data);
                }
                catch (Exception err)
                {
                    if (err.InnerException == null)
                    {
                        errLog.SaveLogToTxt(err.StackTrace, err.Message, "None");
                    }
                    else errLog.SaveLogToTxt(err.StackTrace, err.Message, err.InnerException.ToString());
                }
            }
            else
            {
                try
                {
                    if (data.Count > 1) //tylo jeden element czyli error
                    {
                        terminalTbx.Text = data[0];    // header 1
                        terminalTbx.Text += data[1];   // humidity SHT2x
                        terminalTbx.Text += data[2];   // temperature SHT2x
                        terminalTbx.Text += data[3];   // temperature DS18B20 1
                        terminalTbx.Text += data[4];   // temperature DS18B20 2
                        terminalTbx.Text += data[5];   // lux TSL2561T
                        terminalTbx.Text += data[6];   // soil pH
                        terminalTbx.Text += data[7];   // water pH
                        terminalTbx.Text += data[8];   // soil moisture
                        terminalTbx.Text += data[9];   // header 2
                        terminalTbx.Text += data[10];   // light is? ON/OFF
                        terminalTbx.Text += data[11];  // light time ON/OFF
                        data.Clear();
                        ReceivedDataList.Clear();
                    }
                    else
                    {
                        data.Clear();
                        ReceivedDataList.Clear();
                        terminalTbx.Text = data[0];    // error
                    }
                }
                catch (Exception err)
                {
                    if (err.InnerException == null)
                    {
                        errLog.SaveLogToTxt(err.StackTrace, err.Message, "None");
                    }
                    else errLog.SaveLogToTxt(err.StackTrace, err.Message, err.InnerException.ToString());
                }
            }
        }

        public void RecvDataParser(Byte[] xRevData)
        {
            DisplayDelegate DataReceivedDelegate = new DisplayDelegate(ShowOnConsole);
            CalibrationPh calibPh = new CalibrationPh();
            string[] SplitedReceivedData = null;
            string ReceivedDataString = null;
            string humSht = null;
            string tempSht = null;
            string tempDS18B20_1 = null;
            string tempDS18B20_2 = null;
            string lux = null;
            string soilpH = null;
            string waterpH = null;
            string soilmoistureStr = null;
            string lightIs = null;
            int soilmoistureADC = 0;

            try
            {
                if (xRevData != null)
                {
                    ReceivedDataString = Encoding.ASCII.GetString(xRevData);
                    SplitedReceivedData = ReceivedDataString.Split(new char[] { ' ' }); //rozdziela po spacji

                    // STA BOXER humSht tempSht tempDs1 tempDs2 lux soilPh waterpH soilMoist lightState LightHouCnt END
                    if (SplitedReceivedData[0] == "STA" && SplitedReceivedData[12] == "END" && SplitedReceivedData.Length == 13)
                    {
                        if (SplitedReceivedData[1] == "BOXER")
                        {
                            humSht = SplitedReceivedData[2] + " [%RH]";
                            tempSht = SplitedReceivedData[3] + " [°C]";
                            tempDS18B20_1 = SplitedReceivedData[4] + " [°C]";
                            tempDS18B20_2 = SplitedReceivedData[5] + " [°C]";
                            lux = SplitedReceivedData[6] + " [lx]";

                            double soilpHDouble = double.Parse(SplitedReceivedData[7], System.Globalization.CultureInfo.InvariantCulture);
                            double waterpHDouble = double.Parse(SplitedReceivedData[8], System.Globalization.CultureInfo.InvariantCulture);

                            if (calibPh.StartCalibrationCMD == 0)
                            {
                                if ((soilpHDouble <= 0) || (soilpHDouble >= 14))
                                {
                                    soilpH = "------";
                                }
                                else
                                {
                                    soilpH = SplitedReceivedData[7] + " [pH]";
                                }

                                if ((waterpHDouble <= 0) || (waterpHDouble >= 14))
                                {
                                    waterpH = "------";
                                }
                                else
                                {
                                    waterpH = SplitedReceivedData[8] + " [pH]";
                                }
                            }
                            else if (calibPh.StartCalibrationCMD == 1)
                            {
                                soilpH = "KALIBRACJA";

                                if ((waterpHDouble <= 0) || (waterpHDouble >= 14))
                                {
                                    waterpH = "------";
                                }
                                else
                                {
                                    waterpH = SplitedReceivedData[8] + " [pH]";
                                }
                            }
                            else if (calibPh.StartCalibrationCMD == 2)
                            {
                                if ((soilpHDouble <= 0) || (soilpHDouble >= 14))
                                {
                                    soilpH = "------";
                                }
                                else
                                {
                                    soilpH = SplitedReceivedData[7] + " [pH]";
                                }

                                waterpH = "KALIBRACJA";
                            }

                            soilmoistureADC = Convert.ToInt32(SplitedReceivedData[9]);
                            if (soilmoistureADC == 1)
                            {
                                soilmoistureStr = "SUCHA!";
                            }
                            else if (soilmoistureADC == 2)
                            {
                                soilmoistureStr = "OK";
                            }
                            else if (soilmoistureADC == 0)
                            {
                                soilmoistureStr = "BŁĄD!";
                            }

                            byte LightONorOFF = Convert.ToByte(SplitedReceivedData[10]);
                            if (LightONorOFF == 2)
                            {
                                lightIs = "wł.";
                            }
                            else lightIs = "wył.";

                            string LightTime = SplitedReceivedData[11] + " h";

                            ReceivedDataList.Add("========= Informacje podstawowe =========" + Environment.NewLine);
                            ReceivedDataList.Add("Wilgotność powietrza:\t" + humSht + Environment.NewLine);
                            ReceivedDataList.Add("Temperatura przy doniczce:\t" + tempSht + Environment.NewLine);
                            ReceivedDataList.Add("Temperatura przy źr. światła:\t" + tempDS18B20_1 + Environment.NewLine);
                            ReceivedDataList.Add("Temperatura powietrza:\t" + tempDS18B20_2 + Environment.NewLine);
                            ReceivedDataList.Add("Natężenie światła:\t\t" + lux + Environment.NewLine);
                            ReceivedDataList.Add("Wartość pH wody:\t\t" + waterpH + Environment.NewLine);
                            ReceivedDataList.Add("Wartość pH gleby:\t\t" + soilpH + Environment.NewLine);
                            ReceivedDataList.Add("Wilgotność gleby:\t\t" + soilmoistureStr + Environment.NewLine);
                            ReceivedDataList.Add("============== Oświetlenie =============" + Environment.NewLine);
                            ReceivedDataList.Add("Aktualnie:\t\t\t" + lightIs + Environment.NewLine);
                            ReceivedDataList.Add("Czas pracy w danym stanie: \t" + LightTime + Environment.NewLine);

                            DataReceivedDelegate(ReceivedDataList);
                        }
                    }
                    else if (SplitedReceivedData[0] == "STA" && SplitedReceivedData[2] == "END" && SplitedReceivedData.Length == 3)
                    {
                        //STA CD END - koniec kalibracji 
                        if (SplitedReceivedData[1] == "CD")
                        {
                            calibPh.StartCalibrationCMD = 0;
                        }
                    }

                }
            }
            catch (Exception err)
            {
                if (err.InnerException == null)
                {
                    errLog.SaveLogToTxt(err.StackTrace, err.Message, "None");
                }
                else errLog.SaveLogToTxt(err.StackTrace, err.Message, err.InnerException.ToString());
            }
        }
    }
}
