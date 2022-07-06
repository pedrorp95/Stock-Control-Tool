using System;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMProductsProviders
    {
        public string Reference { get; set; }
        public string ProviderCode { get; set; }
        public string ProviderReference { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> DeliveryDays { get; set; }
        public Nullable<bool> DefaultProvider { get; set; }

        public Products Products { get; set; }
        public Temp_Providers Temp_Providers { get; set; }
    }
}
