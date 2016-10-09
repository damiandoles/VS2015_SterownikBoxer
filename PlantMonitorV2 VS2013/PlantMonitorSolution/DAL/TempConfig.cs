namespace PlantMonitorV2.DAL
{
    class TempConfig
    {
        private static byte mode;
        private static byte tempValue;

        public byte Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        public byte TempValue
        {
            get
            {
                return tempValue;
            }
            set
            {
                tempValue = value;
            }
        }
    }
}
