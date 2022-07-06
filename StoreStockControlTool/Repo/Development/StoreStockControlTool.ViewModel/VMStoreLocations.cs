using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMStoreLocations
    {

        public VMStoreLocations()
        {
            this.InventoryProducts = new List<InventoryProducts>();
            this.RegularizationProducts = new List<RegularizationProducts>();
        }

        public int IdStore { get; set; }
        public string LocationCode { get; set; }
        public string LocationDescription { get; set; }


        public virtual List<InventoryProducts> InventoryProducts { get; set; }

        public virtual List<RegularizationProducts> RegularizationProducts { get; set; }
        public virtual Stores Stores { get; set; }
    }
}
