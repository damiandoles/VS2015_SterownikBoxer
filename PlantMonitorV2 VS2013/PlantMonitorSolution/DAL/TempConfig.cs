namespace PlantMonitorV2.DAL
{
    class TempConfig
    {
        private static byte mode;
        private static byte tempValue;
        private static byte fanPull;
        private static byte fanPush;

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

        public byte FanPull
        {
            get
            {
                return fanPull;
            }
            set
            {
                fanPull = value;
            }
        }

        public byte FanPush
        {
            get
            {
                return fanPush;
            }
            set
            {
                fanPush = value;
            }
        }
    }
}
