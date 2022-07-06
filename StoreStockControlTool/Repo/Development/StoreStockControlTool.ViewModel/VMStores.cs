using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMStores
    {

        public VMStores()
        {
            this.Inventory = new List<Inventory>();
            this.Regularizations = new List<Regularizations>();
            this.StoreLocations = new List<StoreLocations>();
        }

        public int IdStore { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string Owner { get; set; }
        public string Area { get; set; }
        public string StoreLocation { get; set; }
        public string Remarks { get; set; }


        public virtual List<Inventory> Inventory { get; set; }
        public virtual List<Regularizations> Regularizations { get; set; }
        public virtual List<StoreLocations> StoreLocations { get; set; }
        public virtual Temp_Employees Temp_Employees { get; set; }
        public virtual Stores Stores1 { get; set; }
        public virtual Stores Stores2 { get; set; }
        public virtual Temp_Areas Temp_Areas { get; set; }
    }
}
