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
using Store_Management.Extensions;
using LinqKit;
using VLStoreModel.Model;
using StoreStockControlTool.ViewModel;

namespace Store_Management.Forms
{
    public partial class StockControlForm : Form
    {
        #region Properties
        //Variables
        bool searchEmpty = false;

        StockControlController controller;
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        StoresManagementController newStore;
        #endregion

        #region Initialize
        public StockControlForm()
        {
            controller = new StockControlController();
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            c1ComboStore.DataSource = controller.GetStores();

            this.SetC1ComboVisibleFieldsAll(this);
        }
        #endregion

        private void c1ButtonSearch_Click(object sender, EventArgs e)
        {
            FilterPredicate();
        }

        #region Resource Methods
        private void FilterPredicate()
        {
            ExpressionStarter<VStockControl> predicate = PredicateBuilder.New<VStockControl>();
            try
            {
                //Combo Stores
                if (!string.IsNullOrEmpty(c1ComboStore.Text))
                {
                    searchEmpty = false;
                    

                    int filtercbstore = int.Parse(c1ComboStore.SelectedValue.ToString());

                    predicate = predicate.And(x => x.IdStore == filtercbstore);
                }

                    cfgProducts.DataSource = controller.GetProductsInStore(predicate);
                    cfgProducts.Refresh();


                if (c1ComboStore.SelectedValue == null )
                {
                    searchEmpty = true;
                    cfgProducts.DataSource = controller.GetWithoutEnter();
                    cfgProducts.Refresh();
                }


            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion

        private void cfgProducts_RowColChange(object sender, EventArgs e)
        {
            if (cfgProducts.RowSel > 0)
            {
                VStockControl slocation = (VStockControl)cfgProducts.Rows[cfgProducts.RowSel].DataSource;
                cfgLocations.DataSource = slocation;
                BSLocations.ResetBindings(true);

                cfgLocations.DataSource = controller.GetStoresLocations(slocation.IdStore);
            }
        }

        private void c1ButtonClear_Click(object sender, EventArgs e)
        {
            this.FilterClear(this);
        }

        private void c1ButtonNewInventory_Click(object sender, EventArgs e)
        {

            bool found = false;

            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "NewInventoryForm")
                {
                    ActivateMdiChild(formChild);
                    //formChild.Focus();
                    found = true;
                    break;
                }

            }
            if (!found)
            {

                NewInventoryForm niForm = new NewInventoryForm();
                niForm.MdiParent = this.MdiParent;
                niForm.Show();
                niForm.WindowState = FormWindowState.Maximized;

            }
        }

        private void c1ButtonNewRegularization_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "NewRegulationFrom")
                {
                    ActivateMdiChild(formChild);
                    //formChild.Focus();
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                NewRegularizationForm nrForm = new NewRegularizationForm();
                nrForm.MdiParent = this.MdiParent;
                nrForm.Show();
                nrForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void c1ButtonNTransfer_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "NewRegulationFrom")
                {
                    ActivateMdiChild(formChild);
                    //formChild.Focus();
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                NewRegularizationForm nrForm = new NewRegularizationForm();
                nrForm.MdiParent = this.MdiParent;
                nrForm.Show();
                nrForm.WindowState = FormWindowState.Maximized;
            }
        }
    }
}