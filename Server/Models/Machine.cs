namespace MakerspaceManager.Server.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        
        //[Column(TypeName = "varchar(100)")]
        public string MachineName { get; set; }

        public string IPAddress { get; set; }

        public string MACAddress { get; set; }

        public string Model { get; set; }
    }
}