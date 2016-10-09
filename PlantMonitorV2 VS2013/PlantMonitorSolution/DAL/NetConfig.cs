namespace PlantMonitorV2.DAL
{
    public class NetConfig
    {
        private static string ipAddres;
        private static int communicationPort;

        public string IpAddr
        {
            get
            {
                return ipAddres;
            }
            set
            {
                ipAddres = value;
            }
        }

        public int Port
        {
            get
            {
                return communicationPort;
            }
            set
            {
                communicationPort = value;
            }
        }
    }
}
