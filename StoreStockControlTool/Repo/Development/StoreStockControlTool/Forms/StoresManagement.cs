using StoreStockControlTool.Controllers.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using VLStoreModel.Model;
using LinqKit;
using log4net;
using C1.Win.C1Input;
using C1.Win.C1FlexGrid;
using C1.Win.C1List;
using Store_Management.Extensions;

namespace Store_Management.Forms
{
    public partial class StoresManagement : Form
    {
        
        #region Properties
        //Variables
        bool buttonClicked = false;
        bool searchEmpty = false;

        StoresManagementController controller;
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        StoresManagementController newStore;
        #endregion
        
        #region Initialize
        public StoresManagement()
        {
            controller = new StoresManagementController();
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            //Charge C1 Combos
            c1cbAreas.DataSource = controller.GetAllAreas();
            c1cbOwners.DataSource = controller.GetAllOwners();

            //Buttons
            topFillRight.Enabled = false;
            c1Cancel.Enabled = false;
            c1Save.Enabled = false;

            //C1 Combos panel right 
            c1cbOwner2.DataSource = controller.GetAllOwners();
            c1cbArea2.DataSource = controller.GetAllAreas();

            //Button Edit disabled cannot edit if the user click on cfgStores
            c1buttonEdit.Enabled = false;
            c1buttonDelete.Enabled = false;
            c1buttonShowStock.Enabled = false;
            c1buttonNewInventory.Enabled = false;
            c1buttonNewRegularization.Enabled = false;

            this.SetC1ComboVisibleFieldsAll(this);
        }
        #endregion

        #region Resource methods

        //C1TextBox OnlyNumbers
        private void OnlyNumbers()
        {
                if (!(c1tbCode.Text.All(char.IsNumber)))
                {
                    MessageBox.Show("Please you must enter a number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                c1tbCode.Focus();
        }
        //Filter Search
        private void FilterPredicate()
        {
            //Mostrar en el fle los datos de la base de datos
            ExpressionStarter<Stores> predicate = PredicateBuilder.New<Stores>();
            try
            {
                //IdStore
               
                if (!string.IsNullOrEmpty(c1tbCode.Text))
                {
                    searchEmpty = false;
                    int filtertbCode = int.Parse(c1tbCode.Text.Trim().ToString());
                    predicate = predicate.And(x => x.IdStore == filtertbCode);
                }

                //StoreName
                if (!string.IsNullOrEmpty(c1tbName.Text))
                {
                    searchEmpty = false;
                    string filterName = c1tbName.Text.ToLower().Trim().ToString();
                    predicate = predicate.And(x => x.StoreName.ToLower().Contains(filterName));
                }

                //StoreLocation
                if (!string.IsNullOrEmpty(c1tbLocation.Text))
                {
                    searchEmpty = false;
                    string filterLocation = c1tbLocation.Text.ToLower().Trim().ToString();
                    predicate = predicate.And(x => x.StoreLocation.ToLower().Contains(filterLocation));
                }


                //Owners combotext c1
                if (!string.IsNullOrEmpty(c1cbOwners.Text))
                {
                    searchEmpty = false;
                    string filtercbOwners = c1cbOwners.SelectedValue.ToString();
                    predicate = predicate.And(x => x.Owner.ToLower().Contains(filtercbOwners));
                }

                //Areas combotext c1
                if (!string.IsNullOrEmpty(c1cbAreas.Text))
                {
                    searchEmpty = false;
                    string filtercbArea = c1cbAreas.SelectedValue.ToString();
                    predicate = predicate.And(x => x.Area.ToLower().Contains(filtercbArea));
                }

                if (c1tbCode.Text == "" && c1tbName.Text == "" && c1cbOwners.SelectedValue == null && c1cbAreas.SelectedValue == null)
                {
                    searchEmpty = true;
                    cfgStores.DataSource = controller.GetWithoutEnter();
                    cfgStores.Refresh();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }


            if (searchEmpty != true)
            {
                cfgStores.DataSource = controller.GetAllStores(predicate);
                cfgStores.Refresh();
            }      
        }
        private void LoadLocations(int idStore)
        {
            cfgLocations.DataSource = controller.GetStoresLocations(idStore);
            cfgLocations.Refresh();
            //Cuenta las filas
            if (cfgLocations.Rows.Count > 1) //Mayor a 1 porque si no cuenta solo la primera fila que son los campos con los datos.
            {
                c1buttonDelete.Enabled = false;
            }
            else
            {
                c1buttonDelete.Enabled = true;
            }
        }

        private void StoresManagement_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vLStoreManagementDataSet.Stores' Puede moverla o quitarla según sea necesario.
            this.storesTableAdapter.Fill(this.vLStoreManagementDataSet.Stores);
            // TODO: esta línea de código carga datos en la tabla 'vLStoreManagementDataSet.StoreLocations' Puede moverla o quitarla según sea necesario.
            this.storeLocationsTableAdapter.Fill(this.vLStoreManagementDataSet.StoreLocations);
        }


        private void cfgStores_RowColChange_1(object sender, EventArgs e)
        {
            //Mostrar el grid en subtopPanelRight cuenta todos los campos
            if (cfgStores.RowSel >0)
            {
                //Con estas se muestran
                Stores stores = (Stores)cfgStores.Rows[cfgStores.RowSel].DataSource;
                BSCurrentStore.DataSource = stores;
                BSCurrentStore.ResetBindings(true);
                LoadLocations(stores.IdStore);

                c1buttonEdit.Enabled = true;
                c1buttonAdd.Enabled = false;
            }
        }

        #endregion

        #region Events
        
        //Organización botones
        private void BottomC1()
        {
            buttonPanel.Enabled = false;
            panelBot.Enabled = false;
            panelTop.Enabled = false;
            topFillRight.Enabled = true;
            c1Save.Enabled = true;
            c1Cancel.Enabled = true;
        }

        private void SaveAndCancel()
        {
            topFillRight.Enabled = false;
            panelTop.Enabled = true;
            panelBot.Enabled = true;
            buttonPanel.Enabled = true;
            BSCurrentStore.ResetBindings(false);
        }
        private void c1buttonEdit_Click(object sender, EventArgs e)
        {
            BottomC1();
            c1Code.ReadOnly = true;
        }
        private void c1buttonAdd_Click(object sender, EventArgs e)
        {
            BottomC1();

            this.FilterClear(this);
           

            c1Code.ReadOnly = false;
            c1Code.Value = "";
            c1CodeTextBox.Value = "";
            buttonClicked = true;

        }
        private void c1Cancel_Click(object sender, EventArgs e)
        {
            SaveAndCancel();
            buttonClicked = false;
        }
        private void c1Save_Click(object sender, EventArgs e)
        {
            int idstore;
            //Save para edit y add
            if (buttonClicked != true)
            {
                controller = new StoresManagementController();
                Stores stores = (Stores)cfgStores.Rows[cfgStores.RowSel].DataSource;
                stores.StoreName = c1CodeTextBox.Text.ToString();
                stores.Owner = c1cbOwner2.SelectedValue.ToString();
                stores.Area = c1cbArea2.SelectedValue.ToString();

                controller.EditStores(stores);
                MessageBox.Show("Edited correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveAndCancel();
                buttonClicked = false;
            }
            else
            {
                try
                {
                    if (c1CodeTextBox.Text == "")
                    {
                        MessageBox.Show("Required name field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (c1Code.Text == "")
                    {

                        MessageBox.Show("Required code field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (c1cbOwner2.SelectedValue == null)
                    {
                        MessageBox.Show("Required owner field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Stores stores = new Stores();
                    stores.IdStore = Convert.ToInt32(c1Code.Text);
                    stores.StoreName = c1CodeTextBox.Value.ToString();
                    stores.Owner = c1cbOwner2.SelectedValue.ToString();

                    idstore = stores.IdStore;

                    if (c1cbArea2.SelectedValue == null && c1cbArea2.Text == "") 
                    {
                      
                    }

                    else if (c1cbArea2.SelectedValue != null || c1cbArea2.Text == "")
                    {
                        stores.Area = c1cbArea2.SelectedValue.ToString();
                    }

                    if (controller.CompareStores(idstore) == true)
                    {
                        MessageBox.Show("Code already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        controller.AddStores(stores);
                        MessageBox.Show("Add correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveAndCancel();
                        buttonClicked = false;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void c1buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller = new StoresManagementController();

                    //Clickar sobre el grid
                    Stores stores = (Stores)cfgStores.Rows[cfgStores.RowSel].DataSource;

                    controller.DeleteStores(stores);
                    FilterPredicate();
                    SaveAndCancel();
                }

            }
            catch (Exception)
            {
            }
        }
        private void c1ButtonClear_Click_1(object sender, EventArgs e)
        {
            this.FilterClear(this);
            BSCurrentStore.Clear();
            BSCurrentStore.ResetBindings(false);
            c1buttonEdit.Enabled = false;
            c1buttonAdd.Enabled = true;
            c1buttonDelete.Enabled = false;
        }

        private void c1tbCode_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbers();
        }

        private void c1tbCode_Click(object sender, EventArgs e)
        {
            c1tbCode.Clear();
        }
        private void c1ButtonSearch_Click_1(object sender, EventArgs e)
        {
            FilterPredicate();
            //Quiero seleccionar la columna y ordenarla descendentemente.

            if (cfgStores.RowSel > 0)
            {
                cfgStores.ShowSortPosition = ShowSortPositionEnum.Top;
                cfgStores.Sort(C1.Win.C1FlexGrid.SortFlags.Descending, 1);
            }


        }

        private void c1tbName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1tbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void c1tbLocation_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                FilterPredicate();
            }
        }

        private void cfgStores_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Delete))
            {
                
                if (cfgLocations.RowSel > 0)
                {

                    MessageBox.Show("Can't delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    c1buttonDelete_Click(sender, e);
                }
            }
        }
        private void cfgStores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Delete))
            {
                c1buttonDelete_Click(sender, e);
            }
        }

        private void c1CodeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                c1Save_Click(sender, e);
            }
        }
        #endregion
    }
}