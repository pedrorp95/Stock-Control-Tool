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
    public partial class ProductsManagement : Form
    {

        #region Properties
        //Variables
        bool buttonEditClicked = false;
        bool searchEmpty = false;
        double stock;
        bool vuelta = false;

        ProductsManagementController controller;
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion Properties

        #region Initialize
        public ProductsManagement()
        {
            controller = new ProductsManagementController();
            InitializeComponent();

            InitializeFields();
            c1ButtonEdit.Enabled = false;
            subTopPanelRight.Enabled = false;

        }

        private void InitializeFields()
        {
            //C1 ComboBox
            c1ComboBoxType.DataSource = controller.GetAllTypes();
            //c1ComboBoxType.SelectedIndex = -1;
            SetC1ComboVisibleFields(c1ComboBoxType);
            c1Save.Enabled = false;
            c1Cancel.Enabled = false;
            c1ButtonDelete.Enabled = false;
            c1AddProvider.Enabled = false;
            c1ButtonDeletep.Enabled = false;
        }
        #endregion

        #region Resource methods
        //Show C1Combo
        public void SetC1ComboVisibleFields(Control ctl)
        {
            try
            {
                if (ctl.GetType() == typeof(C1Combo))
                {
                    changeComboVisibleFields((C1Combo)ctl);
                }

            }
            catch (Exception ex)
            {

                log.Error(ex.Message, ex);
            }
        }
        //Show C1Combo
        private void changeComboVisibleFields(C1Combo item)
        {
            item.ExtendRightColumn = true;
            item.ColumnHeaders = false;
            if (String.IsNullOrEmpty(item.DisplayMember)) return;

            foreach (Split split in item.Splits)
            {
                foreach (C1DisplayColumn columnDisplay in split.DisplayColumns)
                {
                    if (String.IsNullOrWhiteSpace(columnDisplay.DataColumn.DataField)) continue;

                    if (columnDisplay.DataColumn.DataField != item.DisplayMember)
                    {
                        columnDisplay.Visible = false;
                    }
                }
            }
        }

        //Predicate Search
        private void FilterPredicate()
        {
            //Mostrar en el cfg para cada columna los datos de la base de datos
            ExpressionStarter<Products> predicate = PredicateBuilder.New<Products>();
            try
            {
                //Reference c1textbox
                if (!string.IsNullOrEmpty(c1textboxReference.Text))
                {
                    searchEmpty = false;
                    string filterReference = c1textboxReference.Text.ToLower().Trim();
                    predicate = predicate.And(x => x.Reference.ToLower().Contains(filterReference));
                }

                //Reference ProductName
                if (!string.IsNullOrEmpty(c1textboxName.Text))
                {
                    searchEmpty = false;
                    string filterProductName = c1textboxName.Text.ToLower().Trim().ToString();
                    predicate = predicate.And(x => x.ProductName.ToLower().Contains(filterProductName));
                }

                //Idtypes combotext c1
                if (!string.IsNullOrEmpty(c1ComboBoxType.Text))
                {
                    searchEmpty = false;
                    string filterTypes = c1ComboBoxType.SelectedValue.ToString();
                    predicate = predicate.And(x => x.IdType.ToString().Contains(filterTypes));
                }

                // Stock c1textbox
                if (!string.IsNullOrEmpty(c1TextBoxStock.Text))
                {
                    searchEmpty = false;
                    int filterStock = int.Parse(c1TextBoxStock.Text.Trim().ToString());
                    predicate = predicate.And(x => x.StockMin == filterStock);
                }

                if (c1textboxReference.Text == "" && c1textboxName.Text == "" && c1ComboBoxType.SelectedValue == null && c1TextBoxStock.Text == "")
                {
                    searchEmpty = true;
                    cfgProducts.DataSource = controller.GetWithoutenter();
                    cfgProducts.Refresh();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            if (searchEmpty != true)
            {
                cfgProducts.DataSource = controller.GetAllProducts(predicate);
                cfgProducts.Refresh();
            } 
        }

        private void OnlyFloat(Control item)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Text, "[^0-9^.]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    item.Text = item.Text.Remove(item.Text.Length - 1);
                }
            }
            catch (Exception)
            {

                throw;
            } 
        }
        private void c1ComboBoxStock3_TextChanged(object sender, EventArgs e)
        {
            OnlyFloat(c1ComboBoxStock3);
        }

        private void cfgProducts_RowColChange_1(object sender, EventArgs e)
        {
            if (cfgProducts.RowSel > 0)
            {
                c1ButtonEdit.Enabled = true;
                c1AddProvider.Enabled = true;
                c1ButtonDeletep.Enabled = true;
                //AQUI HAY QUE GUARDAR EL PRODUCTO PARA AÑADIRLO DESPUES
                Products products = (Products)cfgProducts.Rows[cfgProducts.RowSel].DataSource;
                BSCurrentProducts.DataSource = products;
                BSCurrentProducts.ResetBindings(false);


                LoadProducts(products.Reference);

                c1ButtonAdd.Enabled = false;
                c1ButtonDelete.Enabled = true;
            }
            else
            {
                c1ButtonAdd.Enabled = true;
                c1ButtonDelete.Enabled = false;
                BSCurrentProducts.Clear();
            }  
        }

        private void LoadProducts(string reference)
        {
            cfgProductProviders.DataSource = controller.GetProducts(reference);
            cfgProductProviders.Refresh();
            //Cuenta las filas
            if (cfgProductProviders.Rows.Count > 1)
            {
                c1ButtonDelete.Enabled = false;
            }
            else
            {
                c1ButtonDelete.Enabled = true;
            }
        }
        #endregion

        #region Events
        private void c1buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                c1TextBoxSafetyFile.Text = openFileDialog1.FileName;
            }
        }
        private void c1ButtonSearch_Click(object sender, EventArgs e)
        {
            FilterPredicate();
        }


        private void c1ButtonClear_Click(object sender, EventArgs e)
        {
            this.FilterClear(this);
            c1ButtonEdit.Enabled = false;
            c1AddProvider.Enabled = false;
            c1ButtonDeletep.Enabled = false;

        }

        private void c1ButtonEdit_Click(object sender, EventArgs e)
        {
            c1textboxReference2.ReadOnly = true;
            subTopPanelRight.Enabled = true;
            subTopPanelLeft.Enabled = false;
            buttonEditClicked = true;
            c1Save.Enabled = true;
            c1Cancel.Enabled = true;
            c1AddProvider.Enabled = false;
            c1ButtonDeletep.Enabled=false;

        }
        private void SaveAndCancel()
        {
            subTopPanelRight.Enabled = false;
            subTopPanelLeft.Enabled = true;
            BSCurrentProducts.ResetBindings(false);
        }
        private void c1Save_Click(object sender, EventArgs e)
        {
            int id;
            string reference;

            //TIENE QUE SER EL MISMO SAVE PARA EDITAR Y AÑADIR
            if (buttonEditClicked !=false)
            {
                controller = new ProductsManagementController();
                Products products = (Products)cfgProducts.Rows[cfgProducts.RowSel].DataSource;
                products.Reference = c1textboxReference2.Text.ToString();
                products.ProductName = c1textboxName2.Text.ToString();
                products.IdType = Convert.ToInt32(c1TextBoxType2.Text);
                products.StockMin = Convert.ToDouble(c1ComboBoxStock3.Text.ToString());
                id = products.IdType;


                if (controller.CompareProductsIdType(id) == false)
                {
                    MessageBox.Show("Type doesn't exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c1TextBoxType2.Focus();
                }

                else
                {
                    if (c1ComboBoxStock3 == null)
                    {
                        products.StockMin = Convert.ToDouble(c1ComboBoxStock3.Value.ToString());
                    }

                    if (c1ComboQuse2 == null)
                    {
                        products.QuantityInUse = Convert.ToDouble(c1ComboQuse2.SelectedText.ToString());
                    }

                    //Checkbox
                    products.UseExpirationDate = c1CheckBoxExpiredDate.Checked;
                    products.WarningForMinStock = c1CheckBoxWarningMinStock.Checked;
                    products.UseLot = c1CheckBoxUseLot.Checked;

                    products.Dimensions = c1TextBoxDimension.Text.ToString();
                    //Safety file no db

                    controller.EditProducts(products);
                    MessageBox.Show("Edited correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveAndCancel();
                    buttonEditClicked = false;
                }

                
            }
            
            //                                                              AÑADIR
            else
            {

                //Comprobar si los campos estan vacios
                if (c1textboxReference2.Text =="")
                {
                    MessageBox.Show("Required Reference field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (c1textboxName2.Text =="")
                {
                    MessageBox.Show("Required Name field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (c1TextBoxType2.Text == "")
                {
                    MessageBox.Show("Required Type field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

                Products products = new Products();
                products.Reference = c1textboxReference2.Value.ToString();
                 products.ProductName = c1textboxName2.Value.ToString();
                products.IdType = Convert.ToInt32(c1TextBoxType2.Text);

                id = products.IdType;
                reference = products.Reference;


      
                if (controller.CompareProductsIdType(id) == true)
                    {
                    if (controller.CompareReference(reference) == false)
                    {
                        MessageBox.Show("Reference already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        controller.AddProducts(products);
                        MessageBox.Show("Add correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveAndCancel();
                        buttonEditClicked = false;
                    }
                   
                    }
                    else
                    {
                        MessageBox.Show("Type doesn't exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
            }
            //c1Cancel.Enabled = false;
            //c1Save.Enabled = false;
            c1AddProvider.Enabled = true;
            c1ButtonDeletep.Enabled = true;
        }
        private void c1ButtonAdd_Click(object sender, EventArgs e)
        {
            this.FilterClear(subTopPanelRight);
            c1textboxReference2.ReadOnly = false;
            subTopPanelLeft.Enabled = true;
            subTopPanelRight.Enabled = true;
            c1Cancel.Enabled = true;
            c1Save.Enabled = true;
        }

        private void c1ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller = new ProductsManagementController();
                    //Clickar sobre el grid
                    Products products = (Products)cfgProducts.Rows[cfgProducts.RowSel].DataSource;
                    controller.DeleteProducts(products);
                    FilterPredicate();
                    SaveAndCancel();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void c1Cancel_Click(object sender, EventArgs e)
        {
            this.FilterClear(subTopPanelRight);
            subTopPanelRight.Enabled = false;
            subTopPanelLeft.Enabled = true;
            c1Save.Enabled = false;
            c1Cancel.Enabled = false;
            c1AddProvider.Enabled = true;
            c1ButtonDeletep.Enabled = true;
        }



        private void c1textboxReference_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1ButtonSearch_Click(sender,e);
            }
        }
        private void cfgProducts_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Delete))
            {
                c1ButtonDelete_Click(sender, e);
            }
        }


        private void c1textboxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1ButtonSearch_Click(sender, e);
            }
        }
        private void c1textboxReference2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1textboxName2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxType2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1ComboBoxStock3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1ComboBoxStockMin2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1ComboQuse2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxDimension_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }

        private void c1TextBoxSafetyFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }


        public void c1AddProvider_Click(object sender, EventArgs e)
        {
            ProvidersList form = new ProvidersList();
            Products products = (Products)cfgProducts.Rows[cfgProducts.RowSel].DataSource; //Seleccionado el producto al que queremos añadir proveedor

            if (form.ShowDialog() == DialogResult.OK && form.selected.Count > 0)
            {
                foreach (Temp_Providers provider in form.selected)
                {
                    ProductsProviders pp = new ProductsProviders(); //Products -- ProductsProviders -- Temp_Providers

                    pp.Temp_Providers = provider;
                    products.ProductsProviders.Add(pp);

                }
                controller.EditProducts(products);
            }
        }

        private void cfgProducts_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Delete))
            {
                c1ButtonDelete_Click(sender, e);
            }
        }
        #endregion Events

        private void c1ButtonDeletep_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductsProviders pp = (ProductsProviders)cfgProductProviders.Rows[cfgProductProviders.RowSel].DataSource;
                controller.DeletePP(pp);
                SaveAndCancel();
            }
        }

        private void c1TextBoxStock_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1ButtonSearch_Click(sender, e);
            }
        }
    }
}