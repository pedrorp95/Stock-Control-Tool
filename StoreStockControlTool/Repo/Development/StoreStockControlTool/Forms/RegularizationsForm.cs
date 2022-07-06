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

namespace Store_Management.Forms
{
    public partial class RegularizationsForm : Form
    {
        bool searchEmpty = false;

        #region Properties
        RegularizationController controller;
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Initialize
        public RegularizationsForm()
        {
            controller = new RegularizationController();
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            c1ComboStore.DataSource = controller.GetStores();
            c1ComboUser.DataSource = controller.GetOwners();

            this.SetC1ComboVisibleFieldsAll(this);
        }
        #endregion

        #region Resource Methods
        private void FilterPredicate()
        {
            ExpressionStarter<Regularizations> predicate = PredicateBuilder.New<Regularizations>();

            ExpressionStarter<vRegularizationProducts> predicate2 = PredicateBuilder.New<vRegularizationProducts>();

            try
            {
                //Combo cuando se presiona apply filter STORES
                if (!string.IsNullOrEmpty(c1ComboStore.Text))
                {
                    searchEmpty = false;
                    int filtercbstore = int.Parse(c1ComboStore.SelectedValue.ToString());
                    predicate.And(x => x.IdStore.ToString().Contains((filtercbstore.ToString())));
                    cfgRegularizations.Refresh();

                }

                //Combo cuando se presiona apply filter USERS
                if (!string.IsNullOrEmpty(c1ComboUser.Text))
                {
                    searchEmpty = false;
                    string filterowner = c1ComboUser.SelectedValue.ToString();
                    predicate = predicate.And(x => x.RegularizationUser.ToLower().Contains(filterowner));
                    cfgRegularizations.Refresh();
                }

                //Date cuando se introduce una fecha. DATE
                if (c1Date.Value != null && !string.IsNullOrEmpty(c1Date.Text))
                {
                    searchEmpty = false;
                    DateTime filterDateFrom = ((DateTime)c1Date.Value).Date;
                    predicate = predicate.And(x => x.RegularizationDate != null && x.RegularizationDate.CompareTo(filterDateFrom) >= 0);
                    cfgRegularizations.Refresh();
                }

                cfgRegularizations.DataSource = controller.GetRegularizations(predicate);
                //cfgRegularizations.DataSource = controller.GetRegularizationProducts(predicate2);

                if (c1ComboStore.SelectedValue == null && c1Date.Text == "" && c1ComboUser.SelectedValue == null)
                {
                    searchEmpty = true;
                    cfgRegularizations.DataSource = controller.GetWithoutenter();
                    cfgRegularizations.Refresh();
                }
            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
        }
        #endregion

        #region Events
        private void c1ButtonSearch_Click(object sender, EventArgs e)
        {
            FilterPredicate();
        }

        private void c1ButtonClear_Click(object sender, EventArgs e)
        {
            this.FilterClear(this);
        }

        private void cfgRegularizations_RowColChange(object sender, EventArgs e)
        {
            ExpressionStarter<vRegularizationProducts> predicate2 = PredicateBuilder.New<vRegularizationProducts>();
            try
            {
                if (cfgRegularizations.RowSel > 0)
                {
                    Regularizations regularizations = (Regularizations)cfgRegularizations.Rows[cfgRegularizations.RowSel].DataSource;
                    predicate2 = predicate2.And(x => x.IdRegularization == regularizations.IdRegularization);
                    cfgIn.DataSource = controller.GetRegularizationProducts(predicate2);
                    cfgIn.Refresh();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void c1ComboStore_KeyDown(object sender, KeyEventArgs e)
        {
            c1ComboStore.Text = "";
        }

        private void c1ComboStore_KeyUp(object sender, KeyEventArgs e)
        {
            c1ComboStore.Text = "";
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