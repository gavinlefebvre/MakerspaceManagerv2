namespace MakerspaceManager.Server.Models
{
    public class PrintMaterial
    {
        //[Key]
        public int PrintMaterialId { get; set; }
        
        //VARCHAR
        public string MaterialName { get; set; }

        //Listed as VARCHAR, maybe want int/float ??
        public string Unit { get; set; }

        public string Colors { get; set; }

        public string PricePerUnit { get; set; }

        //Machine relation N<->N
        public Machine CompatMachine {get; set; }
    }
}