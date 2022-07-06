using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMInventory
    {
        public VMInventory()
        {
            this.InventoryProducts = new List<InventoryProducts>();
        }

        public int IdInventory { get; set; }
        public int IdStore { get; set; }
        public System.DateTime InventoryDate { get; set; }
        public string InventoryUser { get; set; }
        public string Remarks { get; set; }

        public Stores Stores { get; set; }
        public Temp_Employees Temp_Employees { get; set; }
        public List<InventoryProducts> InventoryProducts { get; set; }
    }
}
