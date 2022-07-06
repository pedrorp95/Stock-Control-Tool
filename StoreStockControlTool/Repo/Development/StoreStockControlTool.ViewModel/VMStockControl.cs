using System;

namespace StoreStockControlTool.ViewModel
{
    public class VMStockControl
    {
        public int IdInventory { get; set; }
        public int Order { get; set; }
        public string Reference { get; set; }
        public int IdStore { get; set; }
        public string Location { get; set; }
        public string Lot { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public double Quantity { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> InventoryDate { get; set; }
    }
}
