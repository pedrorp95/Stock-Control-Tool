using System;
using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMTemp_Providers
    {
        public VMTemp_Providers()
        {
            this.ProductsProviders = new List<ProductsProviders>();
        }

        public string ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public string SAPProvidercode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalZip { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Telephone { get; set; }
        public Nullable<bool> Active { get; set; }


        public virtual List<ProductsProviders> ProductsProviders { get; set; }
    }
}
