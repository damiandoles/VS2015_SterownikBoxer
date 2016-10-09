namespace PlantMonitorV2.DAL
{
    class LampConfig
    {
        private static byte lampState;
        private static byte lampTimeOff;
        private static byte lampTimeOn;

        public byte State
        {
            get
            {
                return lampState;
            }
            set
            {
                lampState = value;
            }
        }

        public byte TimeOn
        {
            get
            {
                return lampTimeOn;
            }
            set
            {
                lampTimeOn = value;
            }
        }

        public byte TimeOff
        {
            get
            {
                return lampTimeOff;
            }
            set
            {
                lampTimeOff = value;
            }
        }
    }
}
