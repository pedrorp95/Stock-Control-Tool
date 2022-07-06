namespace Store_Management.Forms
{
    partial class StockControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockControlForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c1ComboStore = new C1.Win.C1List.C1Combo();
            this.CBStores = new System.Windows.Forms.BindingSource(this.components);
            this.c1Label14 = new C1.Win.C1Input.C1Label();
            this.c1ButtonClear = new C1.Win.C1Input.C1Button();
            this.c1ButtonSearch = new C1.Win.C1Input.C1Button();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cfgProducts = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.BSCfgProducts = new System.Windows.Forms.BindingSource(this.components);
            this.botPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1ButtonNTransfer = new C1.Win.C1Input.C1Button();
            this.c1ButtonNewRegularization = new C1.Win.C1Input.C1Button();
            this.c1ButtonNewInventory = new C1.Win.C1Input.C1Button();
            this.cfgLocations = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.BSLocations = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonSearch)).BeginInit();
            this.fillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCfgProducts)).BeginInit();
            this.botPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonNTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonNewRegularization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonNewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cfgLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.groupBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(10, 25, 10, 0);
            this.topPanel.Size = new System.Drawing.Size(945, 100);
            this.topPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c1ComboStore);
            this.groupBox1.Controls.Add(this.c1Label14);
            this.groupBox1.Controls.Add(this.c1ButtonClear);
            this.groupBox1.Controls.Add(this.c1ButtonSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(10, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // c1ComboStore
            // 
            this.c1ComboStore.AutoCompletion = true;
            this.c1ComboStore.AutoSize = false;
            this.c1ComboStore.Caption = "";
            this.c1ComboStore.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1ComboStore.ColumnWidth = 100;
            this.c1ComboStore.ContentHeight = 15;
            this.c1ComboStore.DataSource = this.CBStores;
            this.c1ComboStore.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1ComboStore.DisplayMember = "StoreName";
            this.c1ComboStore.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.c1ComboStore.DropDownWidth = 300;
            this.c1ComboStore.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1ComboStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ComboStore.Images.Add(((System.Drawing.Image)(resources.GetObject("c1ComboStore.Images"))));
            this.c1ComboStore.Location = new System.Drawing.Point(13, 42);
            this.c1ComboStore.MatchEntryTimeout = ((long)(2000));
            this.c1ComboStore.MaxDropDownItems = ((short)(5));
            this.c1ComboStore.MaxLength = 32767;
            this.c1ComboStore.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1ComboStore.Name = "c1ComboStore";
            this.c1ComboStore.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1ComboStore.Size = new System.Drawing.Size(119, 21);
            this.c1ComboStore.TabIndex = 101;
            this.c1ComboStore.ValueMember = "IdStore";
            this.c1ComboStore.VisualStyle = C1.Win.C1List.VisualStyle.Office2010Silver;
            this.c1ComboStore.PropBag = resources.GetString("c1ComboStore.PropBag");
            // 
            // CBStores
            // 
            this.CBStores.DataSource = typeof(VLStoreModel.Model.VStockControl);
            // 
            // c1Label14
            // 
            this.c1Label14.AutoSize = true;
            this.c1Label14.BackColor = System.Drawing.Color.Transparent;
            this.c1Label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label14.ForeColor = System.Drawing.Color.Navy;
            this.c1Label14.Location = new System.Drawing.Point(12, 24);
            this.c1Label14.Name = "c1Label14";
            this.c1Label14.Size = new System.Drawing.Size(34, 15);
            this.c1Label14.TabIndex = 35;
            this.c1Label14.Tag = null;
            this.c1Label14.Text = "Store";
            this.c1Label14.TextDetached = true;
            this.c1Label14.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1ButtonClear
            // 
            this.c1ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonClear.Image")));
            this.c1ButtonClear.Location = new System.Drawing.Point(804, 37);
            this.c1ButtonClear.Name = "c1ButtonClear";
            this.c1ButtonClear.Size = new System.Drawing.Size(106, 23);
            this.c1ButtonClear.TabIndex = 6;
            this.c1ButtonClear.Text = "Reset Filter";
            this.c1ButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonClear.UseVisualStyleBackColor = true;
            this.c1ButtonClear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonClear.Click += new System.EventHandler(this.c1ButtonClear_Click);
            // 
            // c1ButtonSearch
            // 
            this.c1ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonSearch.Image")));
            this.c1ButtonSearch.Location = new System.Drawing.Point(804, 7);
            this.c1ButtonSearch.Name = "c1ButtonSearch";
            this.c1ButtonSearch.Size = new System.Drawing.Size(106, 23);
            this.c1ButtonSearch.TabIndex = 5;
            this.c1ButtonSearch.Text = "Apply filter";
            this.c1ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonSearch.UseVisualStyleBackColor = true;
            this.c1ButtonSearch.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonSearch.Click += new System.EventHandler(this.c1ButtonSearch_Click);
            // 
            // fillPanel
            // 
            this.fillPanel.Controls.Add(this.label2);
            this.fillPanel.Controls.Add(this.cfgProducts);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(0, 100);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Padding = new System.Windows.Forms.Padding(10, 25, 10, 0);
            this.fillPanel.Size = new System.Drawing.Size(945, 211);
            this.fillPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(19, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products";
            // 
            // cfgProducts
            // 
            this.cfgProducts.AutoGenerateColumns = false;
            this.cfgProducts.ColumnInfo = resources.GetString("cfgProducts.ColumnInfo");
            this.cfgProducts.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgProducts.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgProducts.ColumnPickerInfo.ShowToolButton = false;
            this.cfgProducts.DataSource = this.BSCfgProducts;
            this.cfgProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgProducts.ExtendLastCol = true;
            this.cfgProducts.Location = new System.Drawing.Point(10, 25);
            this.cfgProducts.Name = "cfgProducts";
            this.cfgProducts.Rows.Count = 1;
            this.cfgProducts.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgProducts.Size = new System.Drawing.Size(925, 186);
            this.cfgProducts.StyleInfo = resources.GetString("cfgProducts.StyleInfo");
            this.cfgProducts.TabIndex = 0;
            this.cfgProducts.UseCompatibleTextRendering = false;
            this.cfgProducts.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            this.cfgProducts.RowColChange += new System.EventHandler(this.cfgProducts_RowColChange);
            // 
            // BSCfgProducts
            // 
            this.BSCfgProducts.DataSource = typeof(VLStoreModel.Model.VStockControl);
            // 
            // botPanel
            // 
            this.botPanel.Controls.Add(this.label3);
            this.botPanel.Controls.Add(this.panel1);
            this.botPanel.Controls.Add(this.cfgLocations);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Location = new System.Drawing.Point(0, 311);
            this.botPanel.Name = "botPanel";
            this.botPanel.Padding = new System.Windows.Forms.Padding(10, 45, 10, 0);
            this.botPanel.Size = new System.Drawing.Size(945, 277);
            this.botPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locations";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1ButtonNTransfer);
            this.panel1.Controls.Add(this.c1ButtonNewRegularization);
            this.panel1.Controls.Add(this.c1ButtonNewInventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 37);
            this.panel1.TabIndex = 1;
            // 
            // c1ButtonNTransfer
            // 
            this.c1ButtonNTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c1ButtonNTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonNTransfer.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonNTransfer.Image")));
            this.c1ButtonNTransfer.Location = new System.Drawing.Point(295, 3);
            this.c1ButtonNTransfer.Name = "c1ButtonNTransfer";
            this.c1ButtonNTransfer.Size = new System.Drawing.Size(140, 23);
            this.c1ButtonNTransfer.TabIndex = 2;
            this.c1ButtonNTransfer.Text = "New Transfer";
            this.c1ButtonNTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonNTransfer.UseVisualStyleBackColor = true;
            this.c1ButtonNTransfer.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonNTransfer.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonNTransfer.Click += new System.EventHandler(this.c1ButtonNTransfer_Click);
            // 
            // c1ButtonNewRegularization
            // 
            this.c1ButtonNewRegularization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c1ButtonNewRegularization.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonNewRegularization.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonNewRegularization.Image")));
            this.c1ButtonNewRegularization.Location = new System.Drawing.Point(149, 3);
            this.c1ButtonNewRegularization.Name = "c1ButtonNewRegularization";
            this.c1ButtonNewRegularization.Size = new System.Drawing.Size(140, 23);
            this.c1ButtonNewRegularization.TabIndex = 1;
            this.c1ButtonNewRegularization.Text = "New Regularization";
            this.c1ButtonNewRegularization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonNewRegularization.UseVisualStyleBackColor = true;
            this.c1ButtonNewRegularization.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonNewRegularization.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonNewRegularization.Click += new System.EventHandler(this.c1ButtonNewRegularization_Click);
            // 
            // c1ButtonNewInventory
            // 
            this.c1ButtonNewInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c1ButtonNewInventory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonNewInventory.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonNewInventory.Image")));
            this.c1ButtonNewInventory.Location = new System.Drawing.Point(3, 3);
            this.c1ButtonNewInventory.Name = "c1ButtonNewInventory";
            this.c1ButtonNewInventory.Size = new System.Drawing.Size(140, 23);
            this.c1ButtonNewInventory.TabIndex = 0;
            this.c1ButtonNewInventory.Text = "New Inventory";
            this.c1ButtonNewInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonNewInventory.UseVisualStyleBackColor = true;
            this.c1ButtonNewInventory.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonNewInventory.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonNewInventory.Click += new System.EventHandler(this.c1ButtonNewInventory_Click);
            // 
            // cfgLocations
            // 
            this.cfgLocations.AutoGenerateColumns = false;
            this.cfgLocations.ColumnInfo = resources.GetString("cfgLocations.ColumnInfo");
            this.cfgLocations.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgLocations.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgLocations.ColumnPickerInfo.ShowToolButton = false;
            this.cfgLocations.DataSource = this.BSLocations;
            this.cfgLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgLocations.ExtendLastCol = true;
            this.cfgLocations.Location = new System.Drawing.Point(10, 45);
            this.cfgLocations.Name = "cfgLocations";
            this.cfgLocations.Rows.Count = 1;
            this.cfgLocations.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgLocations.Size = new System.Drawing.Size(925, 232);
            this.cfgLocations.StyleInfo = resources.GetString("cfgLocations.StyleInfo");
            this.cfgLocations.TabIndex = 0;
            this.cfgLocations.UseCompatibleTextRendering = false;
            this.cfgLocations.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // BSLocations
            // 
            this.BSLocations.DataSource = typeof(VLStoreModel.Model.StoreLocations);
            // 
            // StockControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(945, 588);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.botPanel);
            this.MinimumSize = new System.Drawing.Size(961, 627);
            this.Name = "StockControlForm";
            this.Text = "Stock Control";
            this.topPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonSearch)).EndInit();
            this.fillPanel.ResumeLayout(false);
            this.fillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCfgProducts)).EndInit();
            this.botPanel.ResumeLayout(false);
            this.botPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonNTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonNewRegularization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonNewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cfgLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel botPanel;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgLocations;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1Button c1ButtonNewInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1Input.C1Button c1ButtonNewRegularization;
        private C1.Win.C1Input.C1Button c1ButtonClear;
        private C1.Win.C1Input.C1Button c1ButtonSearch;
        private C1.Win.C1Input.C1Button c1ButtonNTransfer;
        private C1.Win.C1Input.C1Label c1Label14;
        private C1.Win.C1List.C1Combo c1ComboStore;
        private System.Windows.Forms.BindingSource CBStores;
        private System.Windows.Forms.BindingSource BSCfgProducts;
        private System.Windows.Forms.BindingSource BSLocations;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgProducts;
    }
}