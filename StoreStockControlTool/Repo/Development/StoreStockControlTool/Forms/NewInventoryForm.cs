using C1.Win.C1FlexGrid;
using log4net;
using StoreStockControlTool.Controllers.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLStoreModel.Model;

namespace Store_Management.Forms
{
    
    public partial class NewInventoryForm : Form
    {
        InventoryController controller;
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public List<Inventory> selected { get; set; } = new List<Inventory>();

        public NewInventoryForm()
        {
            controller = new InventoryController();
            InitializeComponent();
            cfgInventoryList.DataSource = controller.GetWithoutEnter();

        }

        private void c1Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c1ButtonAdd_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();

            try
            {
                foreach (Row row in cfgInventoryList.Rows)
                {
                    if (row.Selected != null && row.Selected)
                    {
                        selected.Add(inventory);
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
