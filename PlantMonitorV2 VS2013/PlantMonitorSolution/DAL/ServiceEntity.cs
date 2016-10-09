
namespace PlantMonitorV2.LL
{
    public class ServiceEntity
    {
        public string Name { get; set; }
        public string Machine { get; set; }
        public int CheckTime { get; set; }

        public ServiceEntity(string name, string machine, int checktime)
        {
            this.Name = name;
            this.Machine = machine;
            this.CheckTime = checktime;
        }
    }
}
