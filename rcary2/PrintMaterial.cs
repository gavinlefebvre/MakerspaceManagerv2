using System;
using System.Collections.Generic;
using System.Text;

namespace mysqlefcore
{
    public class PrintMaterial
    {
        //[Key]
        public int PrintMaterialId { get; set; }
        
        //VARCHAR
        public string MaterialName { get; set; }

        //Listed as VARCHAR, maybe want int/float ??
        public string Unit { get; set; }

        //Should Colors be an editable (by admin) table??
        public string Colors { get; set; }

        public string PricePerUnit { get; set; }

        public ICollection<PrintTracker> TrackerUsedMaterials { get; set; }

        //Machine relation N<->N
        public ICollection<Machine> CompatMachines {get; set; }
    }
}