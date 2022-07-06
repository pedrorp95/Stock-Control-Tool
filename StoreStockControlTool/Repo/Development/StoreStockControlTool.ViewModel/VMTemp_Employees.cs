using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMTemp_Employees
    {

        public VMTemp_Employees()
        {
            this.Inventory = new List<Inventory>();
            this.RegularizationProducts = new List<RegularizationProducts>();
            this.Regularizations = new List<Regularizations>();
            this.Stores = new List<Stores>();
        }

        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }


        public virtual List<Inventory> Inventory { get; set; }

        public virtual List<RegularizationProducts> RegularizationProducts { get; set; }

        public virtual List<Regularizations> Regularizations { get; set; }

        public virtual List<Stores> Stores { get; set; }
    }
}
