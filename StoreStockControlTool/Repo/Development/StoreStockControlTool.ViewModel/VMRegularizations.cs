using System.Collections.Generic;
using VLStoreModel.Model;

namespace StoreStockControlTool.ViewModel
{
    public class VMRegularizations
    {

        public VMRegularizations()
        {
            this.RegularizationProducts = new List<RegularizationProducts>();
        }

        public int IdRegularization { get; set; }
        public int IdStore { get; set; }
        public string TypeMovement { get; set; }
        public System.DateTime RegularizationDate { get; set; }
        public string RegularizationUser { get; set; }
        public string Remarks { get; set; }


        public List<RegularizationProducts> RegularizationProducts { get; set; }
        public Stores Stores { get; set; }
        public Temp_Employees Temp_Employees { get; set; }
    }
}
