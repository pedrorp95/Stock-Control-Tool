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

namespace Store_Management.Forms
{
    public partial class NewRegularizationForm : Form
    {
        RegularizationController controller;
        public NewRegularizationForm()
        {
            controller = new RegularizationController();
            InitializeComponent();
            cfgRegularizations.DataSource = controller.GetWithoutenter();
        }

        private void c1Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
