using System;
using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMProducts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VMProducts()
        {
            this.InventoryProducts = new List<InventoryProducts>();
            this.ProductsProviders = new List<ProductsProviders>();
            this.RegularizationProducts = new List<RegularizationProducts>();
        }

        public string Reference { get; set; }
        public string ProductName { get; set; }
        public int IdType { get; set; }
        public Nullable<bool> UseExpirationDate { get; set; }
        public Nullable<bool> UseLot { get; set; }
        public Nullable<double> StockMin { get; set; }
        public Nullable<double> QuantityInUse { get; set; }
        public Nullable<bool> WarningForMinStock { get; set; }
        public string Dimensions { get; set; }


        public List<InventoryProducts> InventoryProducts { get; set; }
        public ProductTypes ProductTypes { get; set; }

        public List<ProductsProviders> ProductsProviders { get; set; }

        public List<RegularizationProducts> RegularizationProducts { get; set; }
        public Products Products1 { get; set; }
        public Products Products2 { get; set; }
    }
}
