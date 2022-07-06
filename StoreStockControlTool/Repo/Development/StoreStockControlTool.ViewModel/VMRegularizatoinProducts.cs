using System;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMRegularizatoinProducts
    {
        public int IdRegularization { get; set; }
        public int Order { get; set; }
        public string Reference { get; set; }
        public int IdStore { get; set; }
        public string Location { get; set; }
        public string Lot { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public Nullable<double> QuantityIn { get; set; }
        public Nullable<double> QuantityOut { get; set; }
        public string UserForOut { get; set; }
        public string Remarks { get; set; }

        public Products Products { get; set; }
        public Regularizations Regularizations { get; set; }
        public StoreLocations StoreLocations { get; set; }
        public Temp_Employees Temp_Employees { get; set; }
    }
}
