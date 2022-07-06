using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMProductTypes
    {

        public VMProductTypes()
        {
            this.Products = new List<Products>();
        }

        public int IdType { get; set; }
        public string TypeName { get; set; }


        public virtual List<Products> Products { get; set; }
    }
}
