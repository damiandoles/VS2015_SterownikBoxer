namespace PlantMonitorV2.DAL
{
    class IrrConfig
    {
        private static byte mode;
        private static byte freq;
        private static uint number;

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

        public byte Freq
        {
            get
            {
                return freq;
            }
            set
            {
                freq = value;
            }
        }

        public uint Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
