using LinqKit;
using log4net;
using Store_Management.Extensions;
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
    public partial class InventoryForm : Form
    {
        #region Properties
        bool searchEmpty = false;
        InventoryController controller;
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        #endregion

        #region Initialize
        public InventoryForm()
        {
            controller = new InventoryController();
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            //Cargar los datos del combo para que se muestren.
            c1cbStores.DataSource = controller.GetStores(); 
            c1ComboUser.DataSource = controller.GetUsers();

            this.SetC1ComboVisibleFieldsAll(this);
        }
        #endregion

        #region Resource Methods
        private void FilterPredicate()
        {
            ExpressionStarter<Inventory> predicate = PredicateBuilder.New<Inventory>();
            try
            {

                //Combo cuando se presiona apply filter STORES
                if (!string.IsNullOrEmpty(c1cbStores.Text))
                {
                    searchEmpty = false;
                    int filtercbstore = int.Parse(c1cbStores.SelectedValue.ToString());
                    predicate.And(x => x.IdStore.ToString().Contains((filtercbstore.ToString())));
                    cfgInventory.Refresh();

                }

                //Combo cuando se presiona apply filter USERS
                if (!string.IsNullOrEmpty(c1ComboUser.Text))
                {
                    searchEmpty = false;
                    string filterowner = c1ComboUser.SelectedValue.ToString();
                    predicate = predicate.And(x => x.InventoryUser.ToLower().Contains(filterowner));
                    cfgInventory.Refresh();
                }


                //Date cuando se introduce una fecha. DATEFROM
                if (c1DateFrom.Value != null && !string.IsNullOrEmpty(c1DateFrom.Text))
                {
                    searchEmpty = false;
                    DateTime filterDateFrom = ((DateTime)c1DateFrom.Value).Date;
                    predicate = predicate.And(x => x.InventoryDate != null && x.InventoryDate.CompareTo(filterDateFrom) >= 0);
                    cfgInventory.Refresh();  
                }

                //Date cuando se introduce una fecha. DATETO
                if (c1DateTo.Value != null && !string.IsNullOrEmpty(c1DateTo.Text))
                {
                    searchEmpty = false;
                    DateTime filterDateTo = ((DateTime)c1DateTo.Value).Date;
                    predicate = predicate.And(x => x.InventoryDate != null && x.InventoryDate.CompareTo(filterDateTo) < 0);
                    cfgInventory.Refresh();
                }

                BSInventory.DataSource = controller.GetInventories(predicate);


                if (c1cbStores.SelectedValue == null && c1DateFrom.Text == "" && c1DateTo.Text == "" && c1ComboUser.SelectedValue == null)
                {
                    searchEmpty = true;
                    BSInventory.DataSource = controller.GetWithoutEnter();
                    cfgInventory.Refresh();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        //191; 93
        #endregion

        #region Events
        private void c1ButtonSearch_Click(object sender, EventArgs e)
        {
            FilterPredicate();
        }


        private void cfgInventory_RowColChange(object sender, EventArgs e)
        {
            ExpressionStarter<vInventoryProducts> predicate2 = PredicateBuilder.New<vInventoryProducts>();

            try
            {
                if (cfgInventory.RowSel > 0)
                {
                    Inventory inventory = (Inventory)cfgInventory.Rows[cfgInventory.RowSel].DataSource;
                    predicate2 = predicate2.And(x => x.IdInventory == inventory.IdInventory);
                    cfgProducts.DataSource = controller.GetInventoryProducts(predicate2);
                    cfgProducts.Refresh();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void c1ButtonClear_Click(object sender, EventArgs e)
        {
            this.FilterClear(this);
        }

        private void c1cbStores_KeyDown(object sender, KeyEventArgs e)
        {
            c1cbStores.Text = "";
        }

        private void c1cbStores_KeyUp(object sender, KeyEventArgs e)
        {
            c1cbStores.Text = "";
        }

        private void c1ComboUser_KeyDown(object sender, KeyEventArgs e)
        {
            c1ComboUser.Text = "";
        }

        private void c1ComboUser_KeyUp(object sender, KeyEventArgs e)
        {
            c1ComboUser.Text = "";
        }
        #endregion

    }
}