namespace Store_Management.Forms
{
    partial class ProductsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsList));
            this.tableProviderList = new System.Windows.Forms.TableLayoutPanel();
            this.ProvidersPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cfgProductsList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.BSProducts = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.c1Cancel = new C1.Win.C1Input.C1Button();
            this.c1ButtonAdd = new C1.Win.C1Input.C1Button();
            this.tableProviderList.SuspendLayout();
            this.ProvidersPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgProductsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProducts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableProviderList
            // 
            this.tableProviderList.ColumnCount = 2;
            this.tableProviderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProviderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProviderList.Controls.Add(this.ProvidersPanel, 0, 0);
            this.tableProviderList.Controls.Add(this.panel2, 1, 1);
            this.tableProviderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableProviderList.Location = new System.Drawing.Point(0, 0);
            this.tableProviderList.Name = "tableProviderList";
            this.tableProviderList.RowCount = 2;
            this.tableProviderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.44444F));
            this.tableProviderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.555555F));
            this.tableProviderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableProviderList.Size = new System.Drawing.Size(800, 450);
            this.tableProviderList.TabIndex = 1;
            // 
            // ProvidersPanel
            // 
            this.tableProviderList.SetColumnSpan(this.ProvidersPanel, 2);
            this.ProvidersPanel.Controls.Add(this.groupBox1);
            this.ProvidersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProvidersPanel.Location = new System.Drawing.Point(3, 3);
            this.ProvidersPanel.Name = "ProvidersPanel";
            this.ProvidersPanel.Size = new System.Drawing.Size(794, 410);
            this.ProvidersPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cfgProductsList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products List";
            // 
            // cfgProductsList
            // 
            this.cfgProductsList.ColumnInfo = resources.GetString("cfgProductsList.ColumnInfo");
            this.cfgProductsList.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgProductsList.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgProductsList.ColumnPickerInfo.ShowToolButton = false;
            this.cfgProductsList.DataSource = this.BSProducts;
            this.cfgProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgProductsList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cfgProductsList.Location = new System.Drawing.Point(3, 23);
            this.cfgProductsList.Name = "cfgProductsList";
            this.cfgProductsList.Rows.Count = 1;
            this.cfgProductsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.cfgProductsList.Size = new System.Drawing.Size(788, 384);
            this.cfgProductsList.StyleInfo = resources.GetString("cfgProductsList.StyleInfo");
            this.cfgProductsList.TabIndex = 0;
            this.cfgProductsList.UseCompatibleTextRendering = false;
            this.cfgProductsList.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // BSProducts
            // 
            this.BSProducts.DataSource = typeof(VLStoreModel.Model.Products);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c1Cancel);
            this.panel2.Controls.Add(this.c1ButtonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(403, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 28);
            this.panel2.TabIndex = 1;
            // 
            // c1Cancel
            // 
            this.c1Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Cancel.Image = ((System.Drawing.Image)(resources.GetObject("c1Cancel.Image")));
            this.c1Cancel.Location = new System.Drawing.Point(306, 3);
            this.c1Cancel.Name = "c1Cancel";
            this.c1Cancel.Size = new System.Drawing.Size(79, 23);
            this.c1Cancel.TabIndex = 23;
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
            this.c1ButtonAdd.Location = new System.Drawing.Point(225, 3);
            this.c1ButtonAdd.Name = "c1ButtonAdd";
            this.c1ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.c1ButtonAdd.TabIndex = 9;
            this.c1ButtonAdd.Text = "Add";
            this.c1ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonAdd.UseVisualStyleBackColor = true;
            this.c1ButtonAdd.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonAdd.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonAdd.Click += new System.EventHandler(this.c1ButtonAdd_Click);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableProviderList);
            this.Name = "ProductsList";
            this.Text = "Products List";
            this.tableProviderList.ResumeLayout(false);
            this.ProvidersPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgProductsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableProviderList;
        private System.Windows.Forms.Panel ProvidersPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgProductsList;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.C1Input.C1Button c1Cancel;
        private C1.Win.C1Input.C1Button c1ButtonAdd;
        private System.Windows.Forms.BindingSource BSProducts;
    }
}