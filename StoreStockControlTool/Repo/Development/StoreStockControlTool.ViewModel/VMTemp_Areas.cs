using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMTemp_Areas
    {

        public VMTemp_Areas()
        {
            this.Stores = new List<Stores>();
        }

        public string WorkingAreaName { get; set; }
        public string WorkingArea { get; set; }
        public string Telephone { get; set; }
        public string State { get; set; }
        public string PostalZIP { get; set; }
        public string Fax { get; set; }
        public string Country { get; set; }
        public string Contact { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Address { get; set; }


        public virtual List<Stores> Stores { get; set; }
    }
}
