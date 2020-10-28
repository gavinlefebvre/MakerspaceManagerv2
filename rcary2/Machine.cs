using System;
using System.Collections.Generic;
using System.Text;

namespace mysqlefcore
{
    public class Machine
    {
        public int MachineId { get; set; }

        public ICollection<MachineTask> AssignedTasks { get; set; }

        //public ICollection<PrintMaterial> CompatMaterial { get; set; }
        
        //[Column(TypeName = "varchar(100)")]
        public string MachineName { get; set; }

        public string IPAddress { get; set; }

        public string MACAddress { get; set; }

        public string Model { get; set; }
    }
}