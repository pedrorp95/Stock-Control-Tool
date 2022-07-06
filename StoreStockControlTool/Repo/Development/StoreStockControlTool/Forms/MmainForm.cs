using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management.Forms
{
    public partial class MmainForm : Form
    {
        public MmainForm()
        {
            InitializeComponent();
        }

        private void c1ButtonStore_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "StoresManagement")
                {
                    ActivateMdiChild(formChild);
                    formChild.Focus();
                    found = true;
                    break;
                }


            }
            if (!found)
            {
                StoresManagement stores = new StoresManagement();
                stores.MdiParent = this;
                stores.Show();
                stores.WindowState = FormWindowState.Maximized;

            }
        }

        private void c1ButtonProducts_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "ProductsManagement")
                {
                    ActivateMdiChild(formChild);
                    formChild.Focus();
                    found = true;
                    break;
                }


            }
            if (!found)
            {
                ProductsManagement Fproducts = new ProductsManagement();
                Fproducts.MdiParent = this;
                Fproducts.Show();
                Fproducts.WindowState = FormWindowState.Maximized;
            }
        }

        private void c1ButtonProviders_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "TempProviders")
                {
                    ActivateMdiChild(formChild);
                    formChild.Focus();
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                TempProviders Tproviders = new TempProviders();
                Tproviders.MdiParent = this;
                Tproviders.Show();
                Tproviders.WindowState = FormWindowState.Maximized;
            }
        }

        private void c1ButtonStockControl_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(StockControlForm))
                {
                    ActivateMdiChild(frm);
                    frm.Focus();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                StockControlForm scontrol = new StockControlForm();
                scontrol.MdiParent = this;
                scontrol.Show();
                scontrol.WindowState = FormWindowState.Maximized;
            }
        }

        private void c1ButtonInventory_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "InventoryForm")
                {
                    ActivateMdiChild(formChild);
                    formChild.Focus();
                    found = true;
                    break;
                }


            }
            if (!found)
            {
                InventoryForm inventory = new InventoryForm();
                inventory.MdiParent = this;
                inventory.Show();
                inventory.WindowState = FormWindowState.Maximized;
            }
        }

        private void c1ButtonRegularizations_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Form formChild in MdiChildren)
            {
                if (formChild.Name == "RegularizationsForm")
                {
                    ActivateMdiChild(formChild);
                    formChild.Focus();
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                RegularizationsForm reg = new RegularizationsForm();
                reg.MdiParent = this;
                reg.Show();
                reg.WindowState = FormWindowState.Maximized;
            }
        }

        private void c1ButtonTransfer_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(TransferStoresForm))
                {
                    ActivateMdiChild(frm);
                    frm.Focus();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                TransferStoresForm transfer = new TransferStoresForm();
                transfer.MdiParent = this;
                transfer.Show();
                transfer.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
