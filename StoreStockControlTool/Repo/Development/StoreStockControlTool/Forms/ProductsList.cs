using LinqKit;
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
using Store_Management.Extensions;
using C1.Win.C1FlexGrid;

namespace Store_Management.Forms
{
    public partial class ProductsList : Form
    {
        ProductsListController controller;
        public List<Products> selected { get; set; } = new List<Products>();

        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ProductsList()
        {
            controller = new ProductsListController();
            InitializeComponent();
            cfgProductsList.DataSource = controller.GetAllProducts();
            cfgProductsList.Refresh();
        }

        private void c1Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c1ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Row row in cfgProductsList.Rows)
                {
                    if (row.Selected != null && row.Selected)
                    {
                        Products plist = (Products)row.DataSource;
                        selected.Add(plist);
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
