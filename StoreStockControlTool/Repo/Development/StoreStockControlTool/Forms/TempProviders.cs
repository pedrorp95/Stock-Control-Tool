using C1.Win.C1List;
using StoreStockControlTool.Controllers.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LinqKit;
using System.Text;
using log4net;
using C1.Win.C1Input;
using C1.Win.C1FlexGrid;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLStoreModel.Model;
using Store_Management.Extensions;

namespace Store_Management.Forms
{
    public  partial class TempProviders : Form
    {

        #region Properties

        bool buttonEditClicked = false;
        bool searchEmpty = false;

        TempProvidersController controller;
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion Properties

        #region Initialize
        public TempProviders()
        {

            controller = new TempProvidersController();
            InitializeComponent();
            InitializeFields();


        }
        private void InitializeFields()
        {
            //Loading combos c1
            c1buttonEdit.Enabled = false;
            c1buttonDelete.Enabled = false;
            SubPanelRight.Enabled = false;
            c1AddProvider.Enabled = false;
            c1ButtonDeletep.Enabled = false;
        }
        #endregion

        #region Resource Methods

        private void FilterPredicate()
        {
            //Mostrar en el cfg para cada columna los datos de la base de datos
            ExpressionStarter<Temp_Providers> predicate = PredicateBuilder.New<Temp_Providers>();
            try
            {
                
                if (!string.IsNullOrEmpty(c1TextBoxCode.Text))
                {
                    searchEmpty = false;
                    string fitlerCode = c1TextBoxCode.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.ProviderCode.ToLower().Contains(fitlerCode));
                }

                if (!string.IsNullOrEmpty(c1tbName.Text))
                {
                    searchEmpty = false;
                    string filterName = c1tbName.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.ProviderName.ToLower().Contains(filterName));
                }


                if (!string.IsNullOrEmpty(c1TextBoxSapCode.Text))
                {
                    searchEmpty = false;
                    string filterPcode = c1TextBoxSapCode.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.SAPProvidercode.ToLower().Contains(filterPcode));
                }

                if (!string.IsNullOrEmpty(c1TextBoxAddress.Text))
                {
                    searchEmpty = false;
                    string filterPcode = c1TextBoxAddress.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.Address.ToLower().Contains(filterPcode));
                }

                if (!string.IsNullOrEmpty(c1TextBoxCity.Text))
                {
                    searchEmpty = false;
                    string filterPcode = c1TextBoxCity.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.City.ToLower().Contains(filterPcode));
                }

                if(!string.IsNullOrEmpty(c1TextBoxPhone.Text))
                {
                    searchEmpty = false;
                    string filterPcode = c1TextBoxPhone.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.Telephone.ToLower().Contains(filterPcode));
                }

                if (!string.IsNullOrEmpty(c1TextBoxPostal.Text))
                {
                    searchEmpty = false;
                    string filterPcode = c1TextBoxPostal.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.PostalZip.ToLower().Contains(filterPcode));
                }

                if (!string.IsNullOrEmpty(c1TextBoxCountry.Text))
                {
                    searchEmpty = false;
                    string filterPcode = c1TextBoxCountry.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.Country.ToLower().Contains(filterPcode));
                }

                if (!string.IsNullOrEmpty(c1TextBoxCountryCode.Text))
                {
                    searchEmpty = false;
                    string filterPcode = c1TextBoxCountryCode.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.CountryCode.ToLower().Contains(filterPcode));
                }

                if (c1CheckBoxActive.Checked)
                {
                    searchEmpty = false;
                    bool filterActive = c1CheckBoxActive.Checked;
                    predicate = predicate.And(x => x.Active.Equals(filterActive));
                }

                if (c1TextBoxCode.Text == "" && c1tbName.Text == "" 
                    && c1TextBoxSapCode.Text == "" && c1TextBoxAddress.Text == "" 
                    && c1TextBoxCity.Text == "" && c1TextBoxPhone.Text == ""
                    && c1TextBoxPostal.Text == "" && c1TextBoxCountry.Text == ""
                    && c1TextBoxCountryCode.Text == "" && c1CheckBoxActive.Checked == false)
                {
                    searchEmpty = true;
                    cfgProviders.DataSource = controller.GetWithoutEnter();
                    cfgProviders.Refresh();
                }

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            if (searchEmpty != true)
            {
                cfgProviders.DataSource = controller.GetAllProviders(predicate);
                cfgProviders.Refresh();
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
            this.FilterClear(SubPanelLeft);
            this.FilterClear(FillPanel);
            this.FilterClear(SubFill);
            BSCurrentProviders.Clear();
            c1AddProvider.Enabled = false;
            c1ButtonDeletep.Enabled = false;
        }

        private void c1buttonEdit_Click(object sender, EventArgs e)
        {
            SubPanelRight.Enabled = true;
            SubPanelLeft.Enabled = false;
            buttonEditClicked = true;
        }

        private void c1buttonAdd_Click(object sender, EventArgs e)
        {
            SubPanelRight.Enabled = true;
            SubPanelLeft.Enabled = false;
            c1Code.ReadOnly = false;
        }

        private void c1Cancel_Click(object sender, EventArgs e)
        {
            this.FilterClear(SubPanelRight);
            SubPanelRight.Enabled = false;
            SubPanelLeft.Enabled = true;
            c1Code.ReadOnly = true;
        }

        private void c1Save_Click(object sender, EventArgs e)
        {
            string providercode;
            //Save para edit y add
            if (buttonEditClicked == true)
            {
                controller = new TempProvidersController();
                Temp_Providers providers = (Temp_Providers)cfgProviders.Rows[cfgProviders.RowSel].DataSource;

                providers.ProviderCode = c1Code.Text;
                providers.ProviderName = c1CodeTextBoxName.Text;
                providers.SAPProvidercode = c1TextBoxSAP2.Text;
                providers.Address = c1TextBoxAddress2.Text;
                providers.City = c1TextBoxcity2.Text;
                providers.PostalZip = c1TextBoxPostal2.Text;
                providers.Country = c1TextBoxCountry2.Text;
                providers.CountryCode = c1TextBoxCountryCode2.Text;
                providers.Telephone = c1TextBoxPhone2.Text;
                providers.Active = c1CheckBoxActive2.Checked;

                controller.EditProviders(providers);
                MessageBox.Show("Edited correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //FilterPredicate();
                SaveAndCancel();
                buttonEditClicked = false;
            }

            //                                  ADD
            else
            {
                //Comprobar si los campos estan vacios
                if (c1Code.Text == "")
                {
                    MessageBox.Show("Required Code field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (c1CodeTextBoxName.Text == "")
                {
                    MessageBox.Show("Required Name field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (c1TextBoxCountryCode2.TextLength >3)
                {
                    MessageBox.Show("Max 3 letters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Temp_Providers providers = new Temp_Providers();
                providers.ProviderCode = c1Code.Text;
                providers.ProviderName = c1CodeTextBoxName.Text;
                providers.SAPProvidercode = c1TextBoxSAP2.Text;
                providers.Address = c1TextBoxAddress2.Text;
                providers.City = c1TextBoxcity2.Text;
                providers.PostalZip = c1TextBoxPostal2.Text;
                providers.Country = c1TextBoxCountry2.Text;
                providers.CountryCode = c1TextBoxCountryCode2.Text;
                providers.Telephone = c1TextBoxPhone2.Text;
                providers.Active = c1CheckBoxActive2.Checked;

                providercode = providers.ProviderCode;

                if (controller.CompareProviders(providercode) == true)
                {
                    MessageBox.Show("Provider code already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    controller.AddProviders(providers);
                    MessageBox.Show("Add correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveAndCancel();
                    buttonEditClicked = false;
                }
            }
        }

        private void SaveAndCancel()
        {
            SubPanelRight.Enabled = false;
            SubPanelLeft.Enabled = true;
            BSCurrentProviders.ResetBindings(false);
        }

        private void cfgProviders_RowColChange_1(object sender, EventArgs e)
        {
            if (cfgProviders.RowSel > 0)
            {
                c1buttonEdit.Enabled = true;
                c1buttonAdd.Enabled = false;
                c1buttonDelete.Enabled = true;
                c1AddProvider.Enabled = true;
                c1ButtonDeletep.Enabled = true;

                //Seleccionar registro en el grid
                Temp_Providers providers = (Temp_Providers)cfgProviders.Rows[cfgProviders.RowSel].DataSource;
                BSCurrentProviders.DataSource = providers;
                BSCurrentProviders.ResetBindings(false);

                LoadProductsProvider(providers.ProviderCode);


            }
            else
            {
                c1buttonEdit.Enabled = false;
                c1buttonAdd.Enabled = true;
                c1buttonDelete.Enabled = false;
            }
        }

        private void LoadProductsProvider(string reference)
        {
            cfgProductsProviders.DataSource = controller.GetProductsProviders(reference);
            cfgProductsProviders.Refresh();

            //Cuenta las filas
            if (cfgProductsProviders.Rows.Count >1)
            {
                c1buttonDelete.Enabled = false;
            }
            else
            {
                c1buttonDelete.Enabled = true;
            }
        }

        private void c1buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller = new TempProvidersController();

                    //Clickar sobre el grid
                    Temp_Providers providers = (Temp_Providers)cfgProviders.Rows[cfgProviders.RowSel].DataSource;

                    controller.DeleteProviders(providers);
                    FilterPredicate();
                    SaveAndCancel();
                }

            }
            catch (Exception)
            {
            }
        }

        private void c1TextBoxCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }
        private void c1tbName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1TextBoxSapCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1TextBoxAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1TextBoxCity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1TextBoxPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1TextBoxPostal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1TextBoxCountry_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1TextBoxCountryCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1Code_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1CodeTextBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxSAP2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxAddress2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxcity2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxPostal2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxCountry2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxCountryCode2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxPhone2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1AddProvider_Click(object sender, EventArgs e)
        {
            ProductsList form = new ProductsList();
            Temp_Providers providers = (Temp_Providers)cfgProviders.Rows[cfgProviders.RowSel].DataSource; //Relaciona el proveedor al que le quieres asignar el producto

            if (form.ShowDialog() == DialogResult.OK && form.selected.Count > 0) //Para que el dialogo de la ventana popup vuelva a este formulario
            {
                foreach (Products product in form.selected) //Products de la lista product list
                {
                    ProductsProviders pp = new ProductsProviders(); //Temp_Providers -- ProductsProviders -- Products

                    pp.Products = product; //Relaciona Producto con product provider
                    providers.ProductsProviders.Add(pp); //Relaciona Temp_Provider con product provider
                }
                controller.EditProviders(providers);
            }
        }

        private void cfgProviders_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Delete))
            {

                if (cfgProductsProviders.RowSel > 0)
                {

                    MessageBox.Show("Can't delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    c1buttonDelete_Click(sender, e);
                }
            }
        }
        #endregion

        private void c1ButtonDeletep_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductsProviders pp = (ProductsProviders)cfgProductsProviders.Rows[cfgProductsProviders.RowSel].DataSource;
                controller.DeletePP(pp);
                SaveAndCancel();
            }
        }
    }
 }