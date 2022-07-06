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
    public partial class ProvidersList : Form
    {
        ProviderListController controller;


        public List<Temp_Providers> selected { get; set; } = new List<Temp_Providers>();
        
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ProvidersList()
        {
            controller = new ProviderListController();
            InitializeComponent();
            cfgProvidersList.DataSource = controller.GetAllProviders();
            cfgProvidersList.Refresh();
        }

        //Clicks
        #region
        private void c1Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void c1ButtonAdd_Click(object sender, EventArgs e)
        {
            ProductsProviders pp = new ProductsProviders();
            try
            {
                foreach (Row row in cfgProvidersList.Rows)
                {
                    if (row.Selected != null && row.Selected)
                    {
                        Temp_Providers plist = (Temp_Providers)row.DataSource;

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
