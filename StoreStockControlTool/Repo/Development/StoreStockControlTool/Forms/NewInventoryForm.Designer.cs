namespace Store_Management.Forms
{
    partial class NewInventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInventoryForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cfgInventoryList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.BSInventory = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.c1Cancel = new C1.Win.C1Input.C1Button();
            this.c1ButtonAdd = new C1.Win.C1Input.C1Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgInventoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSInventory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.111111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cfgInventoryList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 377);
            this.panel1.TabIndex = 0;
            // 
            // cfgInventoryList
            // 
            this.cfgInventoryList.AutoGenerateColumns = false;
            this.cfgInventoryList.ColumnInfo = resources.GetString("cfgInventoryList.ColumnInfo");
            this.cfgInventoryList.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgInventoryList.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgInventoryList.ColumnPickerInfo.ShowToolButton = false;
            this.cfgInventoryList.DataSource = this.BSInventory;
            this.cfgInventoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgInventoryList.ExtendLastCol = true;
            this.cfgInventoryList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cfgInventoryList.Location = new System.Drawing.Point(0, 0);
            this.cfgInventoryList.Name = "cfgInventoryList";
            this.cfgInventoryList.Rows.Count = 1;
            this.cfgInventoryList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.cfgInventoryList.Size = new System.Drawing.Size(788, 377);
            this.cfgInventoryList.StyleInfo = resources.GetString("cfgInventoryList.StyleInfo");
            this.cfgInventoryList.TabIndex = 0;
            this.cfgInventoryList.UseCompatibleTextRendering = false;
            this.cfgInventoryList.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // BSInventory
            // 
            this.BSInventory.DataSource = typeof(VLStoreModel.Model.Inventory);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.c1Cancel);
            this.panel2.Controls.Add(this.c1ButtonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 35);
            this.panel2.TabIndex = 1;
            // 
            // c1Cancel
            // 
            this.c1Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Cancel.Image = ((System.Drawing.Image)(resources.GetObject("c1Cancel.Image")));
            this.c1Cancel.Location = new System.Drawing.Point(706, 9);
            this.c1Cancel.Name = "c1Cancel";
            this.c1Cancel.Size = new System.Drawing.Size(79, 23);
            this.c1Cancel.TabIndex = 25;
            this.c1Cancel.Text = "Cancel";
            this.c1Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1Cancel.UseVisualStyleBackColor = true;
            this.c1Cancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1Cancel.Click += new System.EventHandler(this.c1Cancel_Click);
            // 
            // c1ButtonAdd
            // 
            this.c1ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonAdd.Image")));
            this.c1ButtonAdd.Location = new System.Drawing.Point(625, 9);
            this.c1ButtonAdd.Name = "c1ButtonAdd";
            this.c1ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.c1ButtonAdd.TabIndex = 24;
            this.c1ButtonAdd.Text = "Add";
            this.c1ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonAdd.UseVisualStyleBackColor = true;
            this.c1ButtonAdd.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonAdd.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonAdd.Click += new System.EventHandler(this.c1ButtonAdd_Click);
            // 
            // NewInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewInventoryForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgInventoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSInventory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgInventoryList;
        private System.Windows.Forms.BindingSource BSInventory;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.C1Input.C1Button c1Cancel;
        private C1.Win.C1Input.C1Button c1ButtonAdd;
    }
}